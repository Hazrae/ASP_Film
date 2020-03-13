using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Global = ModelClient.Models;
using View = ASP_FIrst.Models;

namespace ASP_FIrst.Utils
{
    public static class MapperUser
    {
        public static Global.User ToGlobal(this View.UserSignup u)
        {
            return new Global.User
            {
                Login = u.Login,
                Pwd = u.Pwd,
                IsActive = u.IsActive,
                IsAdmin = u.IsAdmin
            };
        }

        public static View.UserSignup ToLocal(this Global.User u)
        {
            return new View.UserSignup
            {
                ID = u.ID,
                Login = u.Login,
                Pwd = u.Pwd,
                IsActive = u.IsActive,
                IsAdmin = u.IsAdmin
            };
        }
    }
}