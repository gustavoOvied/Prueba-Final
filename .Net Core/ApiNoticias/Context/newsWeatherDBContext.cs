using ApiNoticias.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiNoticias.Context
{
    public class newsWeatherDBContext : DbContext
    {

        public newsWeatherDBContext(DbContextOptions<newsWeatherDBContext> options) : base(options)
        {
        }

        public DbSet<HistoryDB> History {get; set; }
    }
}
