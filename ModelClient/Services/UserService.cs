
using DAL_Framework.Repositories;
using DAL_Framework.Services;
using ModelClient.Models;
using ModelClient.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClient.Services
{
    public class UserService : IRepository<User>
    {
        UserRepository dalInstance;

        public void Create(User u)
        {
            dalInstance.Create(u.ToGlobal());
        }

        public void Delete(int id)
        {
            dalInstance.Delete(id);
        }

        public List<User> GetAll()
        {
            return dalInstance.GetAll().Select(u => u.ToLocal()).ToList();
        }

        public User GetOne(int id)
        {
            return dalInstance.GetOne(id).ToLocal();
        }

        public void Update(User u)
        {
            dalInstance.Update(u.ToGlobal());
        }
    }
}
