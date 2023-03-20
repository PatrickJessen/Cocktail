using Cocktail;
using Cocktail.Models;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main(string[] args)
    {

        using (var dbContext = new CocktailCtx())
        {
            var cocktail = new Drink
            {
                Name = "Mojito",
                Ingredients = new List<Ingredient>
                {
                    new Ingredient { Name = "Mint leaves" },
                    new Ingredient { Name = "Sugar" },
                    new Ingredient { Name = "Lime juice" },
                    new Ingredient { Name = "White rum" },
                    new Ingredient { Name = "Soda water" }
                }
            };

            dbContext.Cocktails.Add(MakeCocktails());
            dbContext.SaveChanges();
        }

        Console.WriteLine("Cocktail added to database!");
        Console.ReadLine();
    }

    static ICollection<Drink> MakeCocktails()
    {
        ICollection<Drink> cocktails = new List<Drink>();
        cocktails.Add(new Drink
        {
            Id = 1,
            Name = "Margarita",
            Ingredients = new List<Ingredient>
        { new Ingredient { Id = 1, Name = "Lime Juice", Amount = 60.0 },
          new Ingredient { Id = 2, Name = "Triple Sec", Amount = 30.0 },
          new Ingredient { Id = 3, Name = "Tequila", Amount = 60.0 },
          new Ingredient { Id = 4, Name = "Salt rim, Crushed ice, lime segment"}}
        });
        cocktails.Add(new Drink
        {
            Id = 2,
            Name = "Mai Tai",
            Ingredients = new List<Ingredient>
        { new Ingredient { Id = 1, Name = "Dark Rum", Amount = 50.0 },
          new Ingredient { Id = 2, Name = "Orange Curacao", Amount = 15.0 },
          new Ingredient { Id = 3, Name = "Lime Juice", Amount = 10.0 },
          new Ingredient { Id = 4, Name = "Lime Section, Maraschino Cherry, Lime segment"}}
        });
        cocktails.Add(new Drink
        {
            Id = 3,
            Name = "White Russian",
            Ingredients = new List<Ingredient>
        { new Ingredient { Id = 1, Name = "Fresh Cream", Amount = 30.0 },
          new Ingredient { Id = 2, Name = "Kahlua", Amount = 30.0 },
          new Ingredient { Id = 3, Name = "Vodka", Amount = 90.0 }}
        });
        return cocktails;
    }
}