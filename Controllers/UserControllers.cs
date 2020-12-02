using parqueo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parqueo.Controllers
{
    class UserControllers
    {
        parqueodbEntities6 _db = new parqueodbEntities6();

        public Users Login(string pAccount, string pPassword)
        {
            var res = _db.Users.Where(i => i.account == pAccount && i.password == pPassword).SingleOrDefault();
            if (res != null)
            {
                App.app._name = res.name;
                App.app._type = res.type;
            }
            
            return res;
        }

        public bool Insert (boletaPago1 boletaPago1)
        {
            _db.boletaPago1.Add(boletaPago1);
            return _db.SaveChanges() > 0;
        }

    }
}
