using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClient.Models
{
	public class Film
	{ 
	
		public int ID { get; set; }

		private string _titre;

		public string Titre
		{
			get { return _titre; }
			set { _titre = value; }
		}

		private string _acteurPrincipal;

		public string ActeurPrincipal
		{
			get { return _acteurPrincipal; }
			set { _acteurPrincipal = value; }
		}

		private string _realisateur;

		public string Realisateur
		{
			get { return _realisateur; }
			set { _realisateur = value; }
		}

		private int _anneeDeSortie;

		public int AnneeDeSortie
		{
			get { return _anneeDeSortie; }
			set { _anneeDeSortie = value; }
		}


	}
}
