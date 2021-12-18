using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiNoticias.Models
{
    public class NewsTiempo
    {
        public string title { get; set; }
        public string author { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public decimal lon { get; set; }
        public decimal lat { get; set; }
        public string name { get; set; }
    }
}
