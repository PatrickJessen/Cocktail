using Cocktail.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktail
{
    public class CocktailCtx : DbContext
    {
        public DbSet<ICollection<Drink>> Cocktails { get; set; }
        public CocktailCtx() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CocktailDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Drink>().HasMany(c => c.Ingredients).WithMany().UsingEntity(join => join.ToTable("Ingredients"));
        }
    }
}
