using BankSystem.Controlles;
using System.Data;
using System.Data.SqlClient;
using BankSystem.Models;
using System.Text;
using System.Security.Cryptography;



namespace BankSystem.Controllers;

internal class EmployeeController : IController
{
    ConnectDB db = new ConnectDB();
    public List<IModel> Items { get; private set; } = new List<IModel>();

    public bool Create(IModel model)
    {
        EmployeeModel employee = (EmployeeModel)model;
        employee.Status = "Active";

        // Mã hóa mật khẩu
        employee.Password = HashPassword(employee.Password);

        using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
        {
            connection.Open();
            string query = "INSERT INTO EMPLOYEE (user_name, employee_name, password, role, status) VALUES (@user_name, @employee_name, @password, @role, @status)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@user_name", employee.User_Name);
                command.Parameters.AddWithValue("@employee_name", employee.Name);
                command.Parameters.AddWithValue("@password", employee.Password);
                command.Parameters.AddWithValue("@role", employee.Role);
                command.Parameters.AddWithValue("@status", employee.Status);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
    public bool Update(IModel model)
    {
        EmployeeModel employee = (EmployeeModel)model;
        using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
        {
            connection.Open();
            string query = "UPDATE EMPLOYEE SET user_name = @user_name, employee_name = @employee_name, role = @role WHERE id = @id";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@user_name", employee.User_Name);
                command.Parameters.AddWithValue("@employee_name", employee.Name);
                command.Parameters.AddWithValue("@role", employee.Role);
                command.Parameters.AddWithValue("@id", employee.Id);
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

                string query = "UPDATE EMPLOYEE SET STATUS = CASE WHEN STATUS = 'Block' THEN 'Active' ELSE 'Block' END WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", Id);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        string getStatusQuery = "SELECT STATUS FROM EMPLOYEE WHERE id = @id";
                        using (SqlCommand getStatusCommand = new SqlCommand(getStatusQuery, connection))
                        {
                            getStatusCommand.Parameters.AddWithValue("@id", Id);
                            string newStatus = getStatusCommand.ExecuteScalar()?.ToString();
                            return !string.IsNullOrEmpty(newStatus);
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
        EmployeeModel employee = (EmployeeModel)model;

        if (IsExist(employee.Id))
        {
            Update(employee);
            return 1;
        }
        else
        {
            Create(employee);
            return 2;
        }
    }

    public IModel? Read(Object id)
    {
        using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
        {
            connection.Open();
            string query = "SELECT * FROM EMPLOYEE WHERE id = @id";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new EmployeeModel
                    {
                        Id = (int)reader["id"],
                        User_Name = (string)reader["user_name"],
                        Name = (string)reader["employee_name"],
                        Password = (string)reader["Password"],
                        Role = (string)reader["role"]
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
            string query = "SELECT * FROM EMPLOYEE";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EmployeeModel employee = new EmployeeModel
                        {
                            Id = (int)reader["id"],
                            User_Name = (string)reader["user_name"],
                            Name = (string)reader["employee_name"],
                            Password = (string)reader["password"],
                            Role = (string)reader["role"],
                            Status = (string)reader["status"]
                        };
                        Items.Add(employee);
                    }
                }
            }
        }
        return Items.Count > 0; // Trả về true nếu có dữ liệu
    }
    public bool Load(Object id)
    {
        var employee = Read(id);
        if(employee != null)
        {
            Items.Clear();
            Items.Add(employee);
            return true;
        }
        return false;
    }

    public bool IsExist(object id)
    {
        using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
        {
            connection.Open();
            string query = "SELECT COUNT(*) FROM EMPLOYEE WHERE id = @id";
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
    private string HashPassword(string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2")); // Chuyển đổi từng byte thành chuỗi hex
            }
            return builder.ToString();
        }
    }
    public string Login(string id, string password)
    {
        string role = null;
        using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
        {
            try
            {
                connection.Open();
                string queryAccountExists = "SELECT ROLE, STATUS, Password FROM EMPLOYEE WHERE user_name = @user_name";
                using (SqlCommand command = new SqlCommand(queryAccountExists, connection))
                {
                    command.Parameters.AddWithValue("@user_name", id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("Tài khoản không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return null;
                        }
                        string status = reader["STATUS"].ToString();
                        role = reader["ROLE"].ToString();
                        string storedPassword = reader["Password"].ToString();

                        if (status == "Block")
                        {
                            MessageBox.Show("Tài khoản đã bị khóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return null;
                        }

                        string hashedPassword = HashPassword(password);
                        if (hashedPassword != storedPassword)
                        {
                            MessageBox.Show("Mật khẩu không chính xác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return null;
                        }
                    }
                }
                return role;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }
        return null;
    }

    public string GetNameEmp(int id)
    {
        using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
        {
            connection.Open();
            string query = "SELECT employee_name FROM EMPLOYEE WHERE id = @Id";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    return result.ToString(); 
                }
                else
                {
                    return "Không tìm thấy nhân viên"; 
                }
            }
        }
    }

    public int GetEmployeeId(string userName)
    {
        using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
        {
            connection.Open();
            string query = "SELECT id FROM EMPLOYEE WHERE user_name = @user_name";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@user_name", userName);
                object result = command.ExecuteScalar();

                if (result != null && result is int id)
                {
                    return id; 
                }
                else
                {
                    return -1; 
                }
            }
        }
    }
}