using Cocktail;
using Cocktail.Interfaces;
using Cocktail.Managers;
using Cocktail.Models;
using Cocktail.Services;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main(string[] args)
    {

        //IService<Drink> service = new DrinkService();
        ServiceManager<Drink> manager = new ServiceManager<Drink>(new DrinkService());
        Drink drink = new Drink
        {
            Name = "Mai Tai2",
            Ingredients = new List<Ingredient>
        { new Ingredient { Name = "Dark Rum1", Amount = 50.0 },
          new Ingredient { Name = "Orange Curacao", Amount = 15.0 },
          new Ingredient { Name = "Lime Juice", Amount = 10.0 },
          new Ingredient { Name = "Lime Section, Maraschino Cherry, Lime segment"}}
        };
        manager.AddItem(drink);
        var f = manager.GetAll();
        foreach (var item in f)
        {
            Console.WriteLine(item.Name);
        }
        manager.Update(1, drink);
        Drink fs = manager.GetById(3);
        Console.WriteLine(fs.Name);
        manager.Delete(1);
        Console.WriteLine("Cocktail added to database!");
        Console.ReadLine();
    }
}