using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClient.Models
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

		private bool _isActive;

		public bool IsActive
		{
			get { return _isActive; }
			set { _isActive = value; }
		}

		private bool _isAdmin;

		public bool IsAdmin
		{
			get { return _isAdmin; }
			set { _isAdmin = value; }
		}


	}
}
