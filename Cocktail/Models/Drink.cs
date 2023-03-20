using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktail.Models
{
    public class Drink
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
