using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiNoticias.Models
{
    public class HistoryDB
    {
        [Key]
        public int id { get; set; }
        [Key]
        public string _name { get; set; }
        public string title { get; set; }
    }
}
