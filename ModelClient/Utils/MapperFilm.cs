using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal = DAL_Framework.Models;
using Local = ModelClient.Models;

namespace ModelClient.Utils
{
    public static class Mappers
    {
        public static Local.Film ToLocal(this Dal.Film f)
        {
            return new Local.Film
            {
                ID = f.ID,
                Titre = f.Titre,
                AnneeDeSortie = f.AnneeDeSortie,
                ActeurPrincipal = f.ActeurPrincipal,
                Realisateur = f.Realisateur
            };
        }

        public static Dal.Film ToGlobal(this Local.Film f)
        {
            return new Dal.Film
            {
                ID = f.ID,
                Titre = f.Titre,
                AnneeDeSortie = f.AnneeDeSortie,
                ActeurPrincipal = f.ActeurPrincipal,
                Realisateur = f.Realisateur

            };
        }
    }
}
