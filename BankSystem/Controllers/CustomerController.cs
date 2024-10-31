using BankSystem.Controlles;
using BankSystem.Models;
using BankSystem.Views;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace BankSystem.Controllers
{
    internal class CustomerController : IController
    {
        ConnectDB db = new ConnectDB();
        AccountController acc = new AccountController();
        public List<IModel> Items { get; private set; } = new List<IModel>();
        public bool Create(IModel model)
        {
            CustomerModel customer = (CustomerModel)model;
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();
                string query = "INSERT INTO CUSTOMER (cus_id, name, phone, email, house_no, city, pin) VALUES (@cus_id, @name, @phone, @email, @house_no, @city, @pin)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@cus_id", customer.Cus_Id);
                    command.Parameters.AddWithValue("@name", customer.Name);
                    command.Parameters.AddWithValue("@phone", customer.Phone);
                    command.Parameters.AddWithValue("@email", customer.Email);
                    command.Parameters.AddWithValue("@house_no", customer.Address);
                    command.Parameters.AddWithValue("@city", customer.City);
                    command.Parameters.AddWithValue("@pin", customer.Pin);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool Update(IModel model)
        {
            CustomerModel customer = (CustomerModel)model;
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();
                string query = "UPDATE CUSTOMER SET name = @name, phone = @phone, email = @email, house_no = @house_no, city = @city WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", customer.Name);
                    command.Parameters.AddWithValue("@phone", customer.Phone);
                    command.Parameters.AddWithValue("@email", customer.Email);
                    command.Parameters.AddWithValue("@house_no", customer.Address);
                    command.Parameters.AddWithValue("@city", customer.City);
                    command.Parameters.AddWithValue("@id", customer.Id);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool Delete(object id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
                {
                    connection.Open();

                    string query = "SELECT STATUS FROM ACCOUNT WHERE customer_id = @customer_id";
                    string currentStatus;

                    using (SqlCommand checkStatusCommand = new SqlCommand(query, connection))
                    {
                        checkStatusCommand.Parameters.AddWithValue("@customer_id", id);
                        currentStatus = checkStatusCommand.ExecuteScalar()?.ToString();
                    }

                    if (currentStatus == "Block")
                    {
                        return false; 
                    }
                    string query2 = "UPDATE ACCOUNT SET STATUS = 'Block' WHERE customer_id = @customer_id";
                    using (SqlCommand command = new SqlCommand(query2, connection))
                    {
                        command.Parameters.AddWithValue("@customer_id", id);
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Có lỗi xảy ra: " + ex.Message);
                return false;
            }
        }
        public long UpdateOrCreate(IModel model)
        {
            CustomerModel customer = (CustomerModel)model;

            if (IsExist(customer.Id))
            {
                Update(customer);
                return 1;
            }
            else
            {
                long newCustomerId = RegisterCus(customer.Name, customer.Phone, customer.Email, customer.Address, customer.City);

                if (newCustomerId > 0)
                {
                    AccountModel newAccount = new AccountModel
                    {
                        Customer_id = newCustomerId, 
                        Balance = 100, 
                        Date_opend = DateTime.Now,
                        Status = "Active"
                    };
                    acc.Create(newAccount);
                    return 2; 
                }
                return 0; 
            }
        }
        public IModel? Read(Object id)
        {
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();
                string query = "SELECT * FROM CUSTOMER WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return new CustomerModel
                        {
                            Id = (int)reader["id"],
                            Cus_Id = (long)reader["cus_id"],
                            Name = (string)reader["name"],
                            Phone = (string)reader["phone"],
                            Email = (string)reader["email"],
                            Address = (string)reader["house_no"],
                            City = (string)reader["city"],
                            Pin = (string)reader["pin"]
                        };
                    }
                    return null;
                }
            }
        }
        public bool Load()
        {
            Items.Clear();

            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();
                string query = "SELECT * FROM CUSTOMER";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CustomerModel customer = new CustomerModel
                            {
                                Id = (int)reader["id"],
                                Cus_Id = (long)reader["cus_id"],
                                Name = (string)reader["name"],
                                Phone = (string)reader["phone"],
                                Email = (string)reader["email"],
                                Address = (string)reader["house_no"],
                                City = (string)reader["city"],
                                Pin = (string)reader["pin"]
                            };
                            Items.Add(customer);
                        }
                    }
                }
            }
            return Items.Count > 0; 
        }
        public bool Load(Object id)
        {
            var customer = Read(id);
            if (customer != null)
            {
                Items.Clear();
                Items.Add(customer);
                return true;
            }
            return false;
        }

        public bool IsExist(object id)
        {
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM CUSTOMER WHERE id = @id";
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
            EmployeeModel employee = (EmployeeModel)model;
            return IsExist(employee.Id);
        }
        public long GetAccountNumber(int id)
        {
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();
                long idfound = 0; // Khởi tạo giá trị trả về mặc định nếu không tìm thấy

                string query = "SELECT CUS_ID FROM CUSTOMER WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    // Thực hiện truy vấn và lấy giá trị
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        idfound = Convert.ToInt64(result);
                    }
                    else
                    {
                        idfound = 0;
                    }
                }

                return idfound; // Trả về giá trị tìm thấy hoặc 0 nếu không tìm thấy
            }
        }
        public string GetCustomerName(int accountId)
        {
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();
                string query = "SELECT name FROM CUSTOMER WHERE id = @AccountId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccountId", accountId);
                    object result = command.ExecuteScalar();
                    return result != null ? result.ToString() : string.Empty; // Trả về tên hoặc chuỗi rỗng
                }
            }
        }
        public string GetAccountStatus(long customerId)
        {
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();

                string query = "SELECT STATUS FROM ACCOUNT WHERE customer_id = @customer_id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@customer_id", customerId);
                    object result = command.ExecuteScalar();

                    // Kiểm tra kết quả trả về
                    if (result == null)
                    {
                        return "Không có khách hàng nhận tiền";
                    }

                    return result.ToString();
                }
            }
        }


        private long GenerateRandomId(int length = 10)
        {
            Random random = new Random();
            string id = "";
            for (int i = 0; i < length; i++)
            {
                id += random.Next(0, 10).ToString();
            }
            return Convert.ToInt64(id);
        }

        private string GenerateRandomPin(int length = 6)
        {
            Random random = new Random();
            string pin = "";
            for (int i = 0; i < length; i++)
            {
                pin += random.Next(0, 10);
            }
            return pin;
        }

        public long RegisterCus(string name, string phone, string email, string address, string city)
        {
            // Tạo tài khoản và mã pin ngẫu nhiên
            long accountNumber = GenerateRandomId();
            string pin = GenerateRandomPin();

            // Gọi hàm lưu dữ liệu vào bảng Customer
            CustomerModel customer = new CustomerModel
            {
                Cus_Id = accountNumber,
                Name = name,
                Phone = phone,
                Email = email,
                Address = address,
                City = city,
                Pin = pin
            };

            bool success = Create(customer);
            return success ? accountNumber : 0; 
        }

        //Kiểm tra số điện thoại
        public bool IsValidPhone(string phone)
        {
            string phonePattern = @"^\d{10,11}$";
            return Regex.IsMatch(phone, phonePattern);
        }
        //Kiểm tra định dạng email
        public bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            string vietnameseCharactersPattern = @"[àáạảãâầấậẩẫêềếệểễôồốộổỗơờớợởỡúùụủũưừứựửữýỳỵỷỹ]";
            return Regex.IsMatch(email, emailPattern) && !Regex.IsMatch(email, vietnameseCharactersPattern);
        }
        public string GetCustomerNameByAccountId(string accountId)
        {
            string customerName = null;

            using (SqlConnection conn = new SqlConnection(db.GetConnectionString()))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT NAME FROM CUSTOMER WHERE cus_ID = @account_Id", conn);
                cmd.Parameters.AddWithValue("@account_Id", accountId);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    customerName = result.ToString();
                }
            }
            return customerName;
        }
    }
}


