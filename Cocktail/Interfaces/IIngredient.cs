using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktail.Interfaces
{
    /// <summary>
    /// Simple Ingredient interface for scaleable ingredients that could be added in the future
    /// </summary>
    public interface IIngredient
    {
        int Id { get; set; }
        int DrinkId { get; set; }
        string Name { get; set; }
        double Amount { get; set; }
    }
}
