using Cocktail;
using Cocktail.Interfaces;
using Cocktail.Models;
using Cocktail.Services;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main(string[] args)
    {

        IService<Drink> service = new DrinkService();
        Drink drink = new Drink
        {
            Name = "Mai Tai2",
            Ingredients = new List<Ingredient>
        { new Ingredient { Name = "Dark Rum1", Amount = 50.0 },
          new Ingredient { Name = "Orange Curacao", Amount = 15.0 },
          new Ingredient { Name = "Lime Juice", Amount = 10.0 },
          new Ingredient { Name = "Lime Section, Maraschino Cherry, Lime segment"}}
        };
        service.AddItem(drink);
        var f = service.GetAll();
        foreach (var item in f)
        {
            Console.WriteLine(item.Name);
        }
        service.Update(1, drink);
        Drink fs = service.GetById(3);
        Console.WriteLine(fs.Name);
        service.Delete(1);
        Console.WriteLine("Cocktail added to database!");
        Console.ReadLine();
    }
}