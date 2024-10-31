using BankSystem.Controlles;
using BankSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Controllers
{
    internal class TypeTransactionContoller : IController
    {
        ConnectDB db = new ConnectDB();
        public List<IModel> Items { get; private set; } = new List<IModel>();

        public bool Create(IModel model)
        {
            TypeTransactionModel type = (TypeTransactionModel)model;
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();
                string query = "INSERT INTO TYPETRANSACTION (ID, NAME_TYPE) VALUES (@ID, @NAMETYPE)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", type.id);
                    command.Parameters.AddWithValue("@NAMETYPE", type.name_type);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool Update(IModel model)
        {
            TypeTransactionModel type = (TypeTransactionModel)model;
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();
                string query = "UPDATE EMPLOYEE SET name_type = @name_type WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", type.id);
                    command.Parameters.AddWithValue("@NAMETYPE", type.name_type);
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

                    string query = "";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", Id);
                        int rowsAffected = command.ExecuteNonQuery();
                        return true;   
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
            TypeTransactionModel type = (TypeTransactionModel)model;

            if (IsExist(type.id))
            {
                Update(type);
                return 1;
            }
            else
            {
                Create(type);
                return 2;
            }
        }

        public IModel? Read(Object id)
        {
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();
                string query = "SELECT * FROM Typetransaction WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return new TypeTransactionModel
                        {
                            id = (int)reader["id"],
                            name_type = (string)reader["name_type"],
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
                string query = "SELECT * FROM Typetransaction";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TypeTransactionModel type = new TypeTransactionModel
                            {
                                id = (int)reader["id"],
                                name_type = (string)reader["name_type"],
                            };
                            Items.Add(type);
                        }
                    }
                }
            }
            return Items.Count > 0; // Trả về true nếu có dữ liệu
        }
        public bool Load(Object id)
        {
            var type = Read(id);
            if (type != null)
            {
                Items.Clear();
                Items.Add(type);
                return true;
            }
            return false;
        }

        public bool IsExist(object id)
        {
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Typetransaction WHERE id = @id";
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
            TypeTransactionModel type = (TypeTransactionModel)model;
            return IsExist(type.id);
        }
    }
}
