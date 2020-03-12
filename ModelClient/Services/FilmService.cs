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
    public class FilmService : IRepository<Film>
    {
        FilmRepository DalInstance;

        public FilmService()
        {
            DalInstance = new FilmRepository();
        }

        public void Create(Film f)
        {
            DalInstance.Create(f.ToGlobal());
        }

        public List<Film> GetAll()
        {
            return DalInstance.GetAll().Select(f => f.ToLocal()).ToList();
        }

        public Film GetOne(int id)
        {
            return DalInstance.GetOne(id).ToLocal();
        }

        public void Delete(int id)
        {
            DalInstance.Delete(id);
        }

        public void Update(Film f)
        {
            DalInstance.Update(f.ToGlobal());
        }
        
    }
}
