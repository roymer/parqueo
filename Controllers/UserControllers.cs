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
        parqueodbEntities _db = new parqueodbEntities();

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

    }
}
