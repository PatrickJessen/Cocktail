using Cocktail.Interfaces;
using Cocktail.Models;
using Cocktail.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Cocktail
{
    /// <summary>
    /// Context class that Inherits from DbContext
    /// </summary>
    public class CocktailCtx : DbContext
    {
        public DbSet<Drink> Drinks { get; set; }
        public CocktailCtx() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // This connection string should be in App settings and not here!
            optionsBuilder.UseSqlServer("Server=PJJ-P15S-2022\\SQLEXPRESS;Database=CocktailDB;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true;");
        }
    }
}
