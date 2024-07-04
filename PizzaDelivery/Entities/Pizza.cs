using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDelivery.Entities
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public List<Recipe> Recipes { get; set; }
        public string RecipesString
        {
            get
            {
                string result = string.Empty;

                if (Recipes != null)
                {
                    var size = Recipes.Count;
                    for (var i = 0; i < size - 1; i++)
                    {
                        result += $"{Recipes[i].Name} - {Recipes[i].Quantity}\n";
                    }
                    result += $"{Recipes[size - 1].Name} - {Recipes[size - 1].Quantity}";
                }

                return result;
            }
        }
        public Pizza()
        {
            Recipes = new List<Recipe>();
        }
    }
}
