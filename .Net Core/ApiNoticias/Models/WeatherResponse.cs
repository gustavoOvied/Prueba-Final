using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiNoticias.Models
{
    public class WeatherResponse
    {
        public decimal lon { get; set; }
        public decimal lat { get; set; }
        public string name { get; set; }
    }
}
