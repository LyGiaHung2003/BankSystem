using BankSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Controllers
{
    interface IController
    {
        List<IModel> Items { get; }
        public bool Create(IModel model);
        public bool Update(IModel model);
        public bool Delete(Object id);
        public IModel Read(object id);
        public bool Load();
        public bool Load(Object id);
        public bool IsExist(Object id);
        public bool IsExist(IModel model);
    }
}
