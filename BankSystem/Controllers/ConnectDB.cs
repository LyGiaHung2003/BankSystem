using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlClient;
using System.Drawing;

namespace BankSystem.Controlles
{
    internal class ConnectDB
    {
        private string connectionString = @"Data Source=LAPTOP-NAGA7OVA\MSSQLSERVER2;Initial Catalog = BankSystem; User ID = hung; Password=123456;TrustServerCertificate=True";

        // Phương thức để lấy chuỗi kết nối
        public string GetConnectionString()
        {
            return connectionString;
        }
    }
}
