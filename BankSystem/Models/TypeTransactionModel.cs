using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Models
{
    internal class TypeTransactionModel :IModel
    {
        public int id { get; set; }
        public string name_type { get; set; }
    }
}
