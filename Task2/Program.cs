using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            Fridge CoolFridge = new Fridge("ROSENLEW", "2516");

            ingredients.Add(new Ingredient("Butter", new DateTime(2018, 2, 2)));
            ingredients.Add(new Ingredient("Milk", new DateTime(2018, 2, 2)));
            ingredients.Add(new Ingredient("Cheese", new DateTime(2018, 2, 2)));
            ingredients.Add(new Ingredient("Ham", new DateTime(2018, 1, 1)));
            ingredients.Add(new Ingredient("Cream", new DateTime(2018, 12, 2)));
            ingredients.Add(new Ingredient("Tomatoes", new DateTime(2018, 2, 3)));

            foreach (Ingredient ingredient in ingredients)
            {
                CoolFridge.ingredients.Add(ingredient);
            }

            Console.WriteLine(CoolFridge.ToString());
            CoolFridge.CollectIngredients();
            Console.ReadKey();
        }
    }
}
