using BankSystem.Controlles;
using BankSystem.Models;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace BankSystem.Controllers
{
    internal class BranchController : IController
    {
        ConnectDB db = new ConnectDB();
        public List<IModel> Items { get; private set; } = new List<IModel>();
        public bool Create(IModel model)
        {
            BranchModel branch = (BranchModel)model;
            branch.Status = "Active";
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();
                string query = "INSERT INTO BRANCH (branch_id, name, house_no, city, status) VALUES (@branch_id, @name, @house_no, @city, @status)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@branch_id", branch.Branch_id);
                    command.Parameters.AddWithValue("@name", branch.Name);
                    command.Parameters.AddWithValue("@house_no", branch.House_no);
                    command.Parameters.AddWithValue("@city", branch.City);
                    command.Parameters.AddWithValue("@status", branch.Status);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool Update(IModel model)
        {
            BranchModel branch = (BranchModel)model;
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();
                string query = "UPDATE BRANCH SET name = @name, house_no = @house_no, city = @city WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", branch.Name);
                    command.Parameters.AddWithValue("@house_no", branch.House_no);
                    command.Parameters.AddWithValue("@city", branch.City);
                    command.Parameters.AddWithValue("@id", branch.Id);
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

                    string query = "UPDATE BRANCH SET STATUS = CASE WHEN STATUS = 'Block' THEN 'Active' ELSE 'Block' END WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", Id);
                        int rowsAffected = command.ExecuteNonQuery();

                        // Nếu cập nhật thành công, lấy trạng thái mới
                        if (rowsAffected > 0)
                        {
                            // Lấy trạng thái mới sau khi cập nhật
                            string getStatusQuery = "SELECT STATUS FROM BRANCH WHERE id = @id";
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

        public int UpdateOrCreate(IModel model)
        {
            BranchModel branch = (BranchModel)model;

            if (IsExist(branch.Id))
            {
                Update(branch);
                return 1;
            }
            else
            {
                Create(branch);
                return 2;
            }
        }
        public IModel? Read(Object id)
        {
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();
                string query = "SELECT * FROM BRANCH WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return new BranchModel
                        {
                            Id = (int)reader["id"],
                            Branch_id = (string)reader["branch_id"],
                            Name = (string)reader["name"],
                            House_no = (string)reader["house_no"],
                            City = (string)reader["city"],
                            Status = (string)reader["status"]

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
                string query = "SELECT * FROM BRANCH";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BranchModel branch = new BranchModel
                            {
                                Id = (int)reader["id"],
                                Branch_id = (string)reader["branch_id"],
                                Name = (string)reader["name"],
                                House_no = (string)reader["house_no"],
                                City = (string)reader["city"],
                                Status = (string)reader["status"]
                            };
                            Items.Add(branch);
                        }
                    }
                }
            }
            return Items.Count > 0; // Trả về true nếu có dữ liệu
        }
        public bool Load(Object id)
        {
            var branch = Read(id);
            if (branch != null)
            {
                Items.Clear();
                Items.Add(branch);
                return true;
            }
            return false;
        }

        public bool IsExist(object id)
        {
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM BRANCH WHERE id = @id";
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
            BranchModel branch = (BranchModel)model;
            return IsExist(branch.Id);
        }
        public string GetBranchName(string branchId)
        {
            string branchName = string.Empty;
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT name FROM BRANCH WHERE branch_id = @Branch_Id";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Branch_Id", branchId);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            branchName = result.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Có lỗi xảy ra: " + ex.Message);
                }
            }
            return branchName;
        }
        public string GetNameBr(string branchhid)
        {
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();
                string query = "SELECT name FROM BRANCH WHERE branch_id = @branch_Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@branch_Id", branchhid);
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        return result.ToString();
                    }
                    else
                    {
                        return "Không tìm thấy ngân hàng";
                    }
                }
            }
        }
        public string GetBranchIdByName(string branchName)
        {
            string branchId = null;

            using (SqlConnection conn = new SqlConnection(db.GetConnectionString()))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT BRANCH_ID FROM BRANCH WHERE NAME = @branchName", conn);
                cmd.Parameters.AddWithValue("@branchName", branchName);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    branchId = result.ToString();
                }
            }

            return branchId;
        }

        // Lấy danh sách tên chi nhánh
        public List<string> GetBranchNames()
        {
            List<string> branchNames = new List<string>();

            using (SqlConnection conn = new SqlConnection(db.GetConnectionString()))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT NAME FROM BRANCH", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    branchNames.Add(reader["NAME"].ToString());
                }
            }

            return branchNames;
        }
    }
}

