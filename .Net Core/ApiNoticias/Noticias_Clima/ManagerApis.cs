using ApiNoticias.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiNoticias.Noticias_Clima
{
    public class ManagerApis
    {
        public ActionResult<NewsTiempo> GetNoticiaTiempo(string ciudad)
        {

            
            var getNoti = new Noticias_Clima.ApiNoticias().GetNoticias(ciudad);
            var getClima = new Noticias_Clima.ApiClima().GetTiempo(ciudad);

            

            List<NewsTiempo> union = new List<NewsTiempo>();

            new NewsTiempo
            {
                title = getNoti.GetNoticias(ciudad);
            }
        }
    }
}
