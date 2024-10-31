using BankSystem.Controlles;
using System.Data;
using System.Data.SqlClient;
using BankSystem.Models;
using BankSystem.Views;

namespace BankSystem.Controllers 
{
    internal class AccountController : IController
    {
        ConnectDB db = new ConnectDB();
        public List<IModel> Items { get; private set; } = new List<IModel>();
        public bool Create(IModel model)
        {
            AccountModel account =(AccountModel)model;
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();
                string query = "INSERT INTO ACCOUNT (customer_id, date_opend, balance, status) VALUES (@customer_id, @date_opend, @balance, @status)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@customer_id", account.Customer_id);
                    command.Parameters.AddWithValue("@date_opend", account.Date_opend);
                    command.Parameters.AddWithValue("@balance", account.Balance);
                    command.Parameters.AddWithValue("@status", account.Status);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool Update(IModel model)
        {
            AccountModel account = (AccountModel)model;
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();
                string query = "UPDATE ACCOUNT SET balance = @balance WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@balance", account.Balance);
                    command.Parameters.AddWithValue("@id", account.Id);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool Delete(Object Id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
                {
                    connection.Open();

                    string query = "UPDATE ACCOUNT SET STATUS = CASE WHEN STATUS = 'Block' THEN 'Active' ELSE 'Block' END WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", Id);
                        int rowsAffected = command.ExecuteNonQuery();

                        // Nếu cập nhật thành công, lấy trạng thái mới
                        if (rowsAffected > 0)
                        {
                            // Lấy trạng thái mới sau khi cập nhật
                            string getStatusQuery = "SELECT STATUS FROM ACCOUNT WHERE id = @id";
                            using (SqlCommand getStatusCommand = new SqlCommand(getStatusQuery, connection))
                            {
                                getStatusCommand.Parameters.AddWithValue("@id", Id);
                                string newStatus = getStatusCommand.ExecuteScalar()?.ToString();
                                return true;
                            }
                        }
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Có lỗi xảy ra: " + ex.Message);
                return false;
            }
        }
        public IModel? Read(Object id)
        {
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();
                string query = "SELECT * FROM ACCOUNT WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        int accountId = (int)reader["id"];
                        long customerid = (long)reader["customerid"];

                        DateTime dateOpened;
                        if (!DateTime.TryParse(reader["date_opend"].ToString(), out dateOpened))
                        {
                            dateOpened = DateTime.MinValue; 
                        }
                        float balance;
                        if (!float.TryParse(reader["balance"].ToString(), out balance))
                        {
                            balance = 0;
                        }
                        string status = (string)reader["status"];
                        return new AccountModel
                        {
                            Id = accountId,
                            Customer_id = customerid,
                            Date_opend = dateOpened,
                            Balance = balance,
                            Status = status
                        };
                    }
                    return null; // Trả về null nếu không tìm thấy bản ghi
                }
            }
        }
        public bool Load()
        {
            Items.Clear();

            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();
                string query = "SELECT * FROM ACCOUNT";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AccountModel account = new AccountModel
                            {
                                Id = (int)reader["id"], 
                                Customer_id = (long)reader["customer_id"], 
                                Date_opend = DateTime.TryParse(reader["date_opend"].ToString(), out DateTime dateOpened) ? dateOpened : DateTime.MinValue,
                                Balance = float.TryParse(reader["balance"].ToString(), out float balance) ? balance : 0f,
                                Status = (string)reader["status"] 
                            };
                            Items.Add(account); 
                        }
                    }
                }
            }
            return Items.Count > 0; // Trả về true nếu có dữ liệu
        }
        public bool Load(Object id)
        {
            var account = Read(id);
            if (account != null)
            {
                Items.Clear();
                Items.Add(account);
                return true;
            }
            return false;
        }

        public bool IsExist(object id)
        {
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM ACCOUNT WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        public bool IsExist(IModel model)
        {
            AccountModel account = (AccountModel)model;
            return IsExist(account.Id);
        }
        public int GetAccountIdByCustomerId(long customerId)
        {
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();
                string query = "SELECT id FROM ACCOUNT WHERE customer_id = @customer_Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@customer_Id", customerId);
                    var result = command.ExecuteScalar();

                    // Kiểm tra nếu không tìm thấy tài khoản, trả về giá trị mặc định
                    if (result == null)
                    {
                        return -1; // Hoặc có thể trả về 0 tùy thuộc vào logic của bạn
                    }

                    // Chuyển đổi kết quả về kiểu int
                    return (int)result;
                }
            }
        }
        public long GetAccountNumber(int id)
        {
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();
                string query = "SELECT customer_id FROM ACCOUNT WHERE id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt64(result);
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
        public List<string> GetAccount()
        {
            List<string> accountList = new List<string>();

            using (SqlConnection conn = new SqlConnection(db.GetConnectionString()))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT CUSTOMER_ID FROM ACCOUNT", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    accountList.Add(reader["CUSTOMER_ID"].ToString());
                }
            }
            return accountList;
        }
    }
}
