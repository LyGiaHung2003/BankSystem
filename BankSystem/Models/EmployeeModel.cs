using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Models
{
    internal class EmployeeModel : IModel
    {
        public int Id { get; set; }
        public string User_Name { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
    }
}
