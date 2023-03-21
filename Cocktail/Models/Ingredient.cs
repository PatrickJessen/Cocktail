using Cocktail.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktail.Models
{
    /// <summary>
    /// Simple Ingredient object that implements the IIngredient interface
    /// </summary>
    public class Ingredient : IIngredient
    {
        [Key]
        public int Id { get; set;  }
        [ForeignKey("Drink")] // Foreign key to Drink.Id
        public int DrinkId { get; set;  }
        public string Name { get; set; }
        public double Amount { get; set; }
    }
}
