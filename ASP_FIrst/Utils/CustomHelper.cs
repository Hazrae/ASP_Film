using ModelClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Reflection;

namespace ASP_FIrst.Utils
{
    public static class CustomHelper
    {


        public static MvcHtmlString TabGenerique<TEntity> (this HtmlHelper html, IEnumerable<TEntity> list)
        {

            Type typelist = typeof(TEntity);

            PropertyInfo[] tav = typelist.GetProperties();

            TagBuilder tag = new TagBuilder("table");
            TagBuilder tagRow = new TagBuilder("tr");

            foreach (PropertyInfo prop in tav)
            {
                TagBuilder tagElem = new TagBuilder("th");
                tagElem.InnerHtml = prop.Name;
                tagRow.InnerHtml += tagElem.ToString();
            }
            tag.InnerHtml += tagRow.ToString();

            foreach (TEntity item in list)
            {
                TagBuilder tagRowElem = new TagBuilder("tr");
                foreach (PropertyInfo prop in tav)
                {
                    TagBuilder tagElem = new TagBuilder("td");
                    tagElem.InnerHtml = prop.GetValue(item).ToString();
                    tagRowElem.InnerHtml += tagElem.ToString();
                }
                tag.InnerHtml += tagRowElem.ToString();
                
            }

            tag.AddCssClass("table");
            return new MvcHtmlString(tag.ToString());
        }

        public static MvcHtmlString TabList(this HtmlHelper html, List<Film> listFilm)
        {
            TagBuilder tag = new TagBuilder("table");

            TagBuilder tagRow = new TagBuilder("tr");
            TagBuilder tadHead = new TagBuilder("th");
            tadHead.SetInnerText("Titre");
            TagBuilder tadHead1 = new TagBuilder("th");
            tadHead1.SetInnerText("Acteur Principal");
            TagBuilder tadHead2 = new TagBuilder("th");
            tadHead2.SetInnerText("Année de Sortie");

            tagRow.InnerHtml += tadHead.ToString();
            tagRow.InnerHtml += tadHead1.ToString();
            tagRow.InnerHtml += tadHead2.ToString();

            tag.InnerHtml += tagRow.ToString();

            foreach (Film f in listFilm)
            {
                TagBuilder tagRowElem = new TagBuilder("tr");
                TagBuilder tadElem = new TagBuilder("td");
                tadElem.SetInnerText(f.Titre);
                TagBuilder tadElem1 = new TagBuilder("td");
                tadElem1.SetInnerText(f.ActeurPrincipal);
                TagBuilder tadElem2 = new TagBuilder("td");
                tadElem2.SetInnerText(f.AnneeDeSortie.ToString());

                tagRowElem.InnerHtml += tadElem.ToString();
                tagRowElem.InnerHtml += tadElem1.ToString();
                tagRowElem.InnerHtml += tadElem2.ToString();

                tag.InnerHtml += tagRowElem.ToString();
            }

            tag.AddCssClass("table");
            return new MvcHtmlString(tag.ToString());
        }
    }
}