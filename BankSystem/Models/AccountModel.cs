using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Models
{
    internal class AccountModel : IModel
    {
        public int Id { get; set; }
        public long Customer_id { get; set; }
        public DateTime Date_opend { get; set; }
        public float Balance { get; set; }
        public string Status { get; set; }

    }
}
