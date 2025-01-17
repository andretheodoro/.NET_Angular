using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CURSONETANDRE.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CURSONETANDRE.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){  }

        public DbSet<Eventos> Eventos {get; set;}
    }
}