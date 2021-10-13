using Microsoft.EntityFrameworkCore;
using Parcial2Naipe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial2Naipe.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 

        }
        public DbSet<Naipe> Naipe { get; set; }
    }

}
