using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Models
{
    internal class TransactionModel :IModel
    {
        public int Id { get; set; }
        public int From_account_id { get; set; }
        public string Branch_id { get; set; }
        public DateTime Date_of_trans { get; set; }
        public float Amount { get; set; }
        public string Pin { get; set; }
        public int id_type { get; set; }
        public int To_account_id { get; set; }
        public int Employee_id { get; set; }
        public string content { get; set; }
    }
}
