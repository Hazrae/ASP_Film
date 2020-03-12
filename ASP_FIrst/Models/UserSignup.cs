using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_FIrst.Models
{
    public class UserSignup
    {
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

		private string _pwdCheck;
		public string PwdCheck
		{
			get { return _pwdCheck; }
			set { _pwdCheck = value; }
		}

		private string _role;

		public string Role
		{
			get { return _role; }
			set { _role = value; }
		}
	}
}