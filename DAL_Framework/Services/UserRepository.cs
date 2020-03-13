using DAL_Framework.Models;
using DAL_Framework.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Framework.Services
{
    public class UserRepository : IRepository<User>
    {

        private const string connecString = @"Data Source=FORMA-VDI1114\TFTIC;Initial Catalog = ASP_Film; Persist Security Info=True;User ID = sa; Password=tftic@2012";

        private readonly SqlConnection connec = new SqlConnection(connecString);

        public void Create(User u)
        {
            using (SqlCommand cmd = connec.CreateCommand())
            {
                string command = "Insert into [User] ([Login],[Password]) values (@log,@pwd)";

                //Parametres
                SqlParameter PLogin = new SqlParameter("log", u.Login);
                SqlParameter PPwd = new SqlParameter("pwd", u.Pwd);               

                //construction de la cmd
                cmd.CommandText = command;
                cmd.Parameters.Add(PLogin);
                cmd.Parameters.Add(PPwd);
               
                //exec
                connec.Open();
                cmd.ExecuteScalar();
                connec.Close();
                
            }
        }

        public void Delete(int id)
        {
            connec.Open();
            using (SqlCommand cmd = connec.CreateCommand())
            {
                cmd.CommandText = "DELETE FROM [User] WHERE IdUser = @id";
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();
                connec.Close();

            }
        }

        public List<User> GetAll()
        {
            List<User> l = new List<User>();
            connec.Open();

            //creation de la cmd
            using (SqlCommand cmd = connec.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM [User]";

                //execution
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    //creation de la liste en bouclant sur le DR
                    while (dr.Read())
                    {
                        l.Add(new User
                        {
                            ID = (int)dr["IdUser"],
                            Login = dr["Login"].ToString(),
                            Pwd = dr["Password"].ToString(),
                            IsActive = (bool)dr["isActive"],
                            IsAdmin = (bool)dr["isAdmin"]
                        });
                    }
                }
            }
            connec.Close();
            return l;
        }

        public User GetOne(int id)
        {
            connec.Open();
            User u = new User();

            //creation de la cmd
            using (SqlCommand cmd = connec.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM [User] WHERE IdUser = @id";
                cmd.Parameters.AddWithValue("id", id);

                //exécution et boucle sur le DR pour garnir l'objet
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dr.Read();
                    u.ID = (int)dr["IdUser"];
                    u.Login = dr["Login"].ToString();
                    u.Pwd = dr["Password"].ToString();
                    u.IsActive = (bool)dr["isActive"];
                    u.IsAdmin = (bool)dr["isAdmin"];

                    connec.Close();
                    return u;
                }
            }
        }

        public void Update(User u)
        {
            //Creation de l'objet commande
            using (SqlCommand cmd = connec.CreateCommand())
            {
                string command = "UPDATE [User] SET [Login] = @login, [Password] = @pwd, isActive = @actif, isAdmin = @admin WHERE IdUser = @id";

                //Parametres
                SqlParameter PLogin = new SqlParameter("login", u.Login);
                SqlParameter PPwd = new SqlParameter("pwd", u.Pwd);
                SqlParameter PActive = new SqlParameter("actif", u.IsActive);
                SqlParameter PAdmin = new SqlParameter("admin", u.IsAdmin);
                cmd.Parameters.AddWithValue("id", u.ID);

                //construction de la cmd
                cmd.CommandText = command;
                cmd.Parameters.Add(PLogin);
                cmd.Parameters.Add(PPwd);
                cmd.Parameters.Add(PActive);
                cmd.Parameters.Add(PAdmin);

                //exec
                connec.Open();
                cmd.ExecuteScalar();
                connec.Close();

            }
        }

        public void UpdateDroits(User u)
        {
            //Creation de l'objet commande
            using (SqlCommand cmd = connec.CreateCommand())
            {
                string command = "UPDATE [User] SET isActive = @actif, isAdmin = @admin WHERE IdUser = @id";

                //Parametres
                SqlParameter PActive = new SqlParameter("actif", u.IsActive);
                SqlParameter PAdmin = new SqlParameter("admin", u.IsAdmin);
                cmd.Parameters.AddWithValue("id", u.ID);

                //construction de la cmd
                cmd.CommandText = command;
                cmd.Parameters.Add(PActive);
                cmd.Parameters.Add(PAdmin);

                //exec
                connec.Open();
                cmd.ExecuteScalar();
                connec.Close();

            }
        }

    }
}
