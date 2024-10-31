using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Models
{
    internal class BranchModel : IModel
    {
        public int Id { get; set; }
        public string Branch_id{ get;set;}
        public string Name { get; set; }
        public string House_no { get; set; }
        public string City { get; set; }
        public string Status { get; set; }
    }
}
