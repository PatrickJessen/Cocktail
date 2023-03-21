using Cocktail.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktail.Models
{
    /// <summary>
    /// Simple Drink object that implements the IDrink interface
    /// </summary>
    public class Drink : IDrink
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
