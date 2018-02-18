using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeApplication
{
    class Fridge
    {
        public List<Ingredient> ingredients = new List<Ingredient>();
        public string Name { get; set; }
        public string Model { get; set; }

        public Fridge (string name, string model)
        {
            Name = name;
            Model = model;
        }

        public void CollectIngredients()
        {
            foreach (Ingredient ingredient in ingredients)
            {
                DateTime Date = ingredient.BestBefore;
                Console.WriteLine("Ingredient:  {0} Best Before: {1}", ingredient.Name, Date.ToString("d"));
            }
        }

        public override string ToString()
        {
            return "Name: " + Name + "Model: " + Model;
        }

    }
}
