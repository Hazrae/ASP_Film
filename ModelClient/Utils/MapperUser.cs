using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal = DAL_Framework.Models;
using Local = ModelClient.Models;

namespace ModelClient.Utils
{
    public static class MapperUser
    {
        public static Local.User ToLocal(this Dal.User u)
        {
            return new Local.User
            {
                ID = u.ID,
                Login = u.Login,
                Pwd = u.Pwd,
                Role = u.Role,
               
            };
        }

        public static Dal.User ToGlobal(this Local.User u)
        {
            return new Dal.User
            {
                ID = u.ID,
                Login = u.Login,
                Pwd = u.Pwd,
                Role = u.Role,
            };
        }
    }
}
