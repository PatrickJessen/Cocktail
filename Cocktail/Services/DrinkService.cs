using Cocktail.Interfaces;
using Cocktail.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktail.Services
{
    /// <summary>
    /// Service object for drinks that handles all the CRUD
    /// </summary>
    public class DrinkService : IService<Drink>
    {
        private CocktailCtx cocktailCtx;
        public DrinkService()
        {
            cocktailCtx = new CocktailCtx();
        }
        public void AddItem(Drink item)
        {
            cocktailCtx.Drinks.Add(item);
            cocktailCtx.SaveChanges();
        }

        public void Delete(int id)
        {
            Drink drink = cocktailCtx.Drinks.Include(d => d.Ingredients).Where(m => m.Id == id).Single();
            cocktailCtx.Drinks.Remove(drink);
            cocktailCtx.SaveChanges();
        }

        public ICollection<Drink> GetAll()
        {
            ICollection<Drink> drinks = cocktailCtx.Drinks.Include(d => d.Ingredients).ToList();
            return drinks;
        }

        public Drink GetById(int id)
        {
            return cocktailCtx.Drinks.Where(x => x.Id == id).Include(d => d.Ingredients).Where(m => m.Id == id).Single();
        }

        public void Update(int id, Drink item)
        {
            Drink drink = cocktailCtx.Drinks.Include(d => d.Ingredients).Where(m => m.Id == id).Single();
            drink.Ingredients = item.Ingredients;
            drink.Name = item.Name;
            cocktailCtx.SaveChanges();
        }
    }
}
