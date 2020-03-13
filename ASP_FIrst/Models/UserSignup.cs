using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_FIrst.Models
{
    public class UserSignup
    {

		private int _id;

		public int ID
		{
			get { return _id; }
			set { _id = value; }
		}

		private string _login;

		[Required(ErrorMessage = "Le login est obligatoire")]
		public string Login
		{
			get { return _login; }
			set { _login = value; }
		}

		private string _pwd;
		[Required(ErrorMessage = "Le password est obligatoire")]
		[DataType(DataType.Password)]
		[DisplayName("Password")]
		public string Pwd
		{
			get { return _pwd; }
			set { _pwd = value; }
		}

		private string _pwdCheck;
		[System.ComponentModel.DataAnnotations.Compare("Pwd")]
		[DataType(DataType.Password)]
		[Required(ErrorMessage = "La confirmation est obligatoire")]
		[DisplayName("Vérification du Password")]
		public string PwdCheck
		{
			get { return _pwdCheck; }
			set { _pwdCheck = value; }
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