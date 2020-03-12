using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Framework.Models
{
    public class User
    {
		private int _id;

		public int ID
		{
			get { return _id; }
			set { _id = value; }
		}

		private string _login;

		public string Login
		{
			get { return _login; }
			set { _login = value; }
		}

		private string _pwd;

		public string Pwd
		{
			get { return _pwd; }
			set { _pwd = value; }
		}

		private string _role;

		public string Role
		{
			get { return _role; }
			set { _role = value; }
		}




	}
}
