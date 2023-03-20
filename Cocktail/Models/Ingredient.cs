using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktail.Models
{
    //public enum Flavor
    //{
    //    LimeJuice, TripleSec, Tequila, DarkRum, OrangeCuracao, AlmondSyrup, FreshCream,
    //    Kahlua, Vodka, Cachaca, OrangeJuice, TomatoJuice, Bourbon, Water, ItalianSweetVermouth,
    //    FrenchDryVermouth, Gin, WhiteRum, PinkGrapefruit, CranberryJuice, Coingtreau, Soda, CherryBrandy,
    //    LemonJuice, SloeGin, PineappleJuice, CoconutCream, GrapefruitJuice, Cola, PeachPuree, Prosecco
    //}
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
    }
}
