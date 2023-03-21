using Cocktail.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktail.Interfaces
{
    /// <summary>
    /// Simple drink interface for scaleable drinks that could be added in the future
    /// </summary>
    public interface IDrink
    {
        int Id { get; set; }
        string Name { get; set; }
        ICollection<Ingredient> Ingredients { get; set; }
    }
}
