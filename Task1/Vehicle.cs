using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    abstract class Vehicle
    {
        private string Brand { get; set; }
        private string Model { get; set; }
        private List<Tyre> tyres = new List<Tyre>();

        public string addTyre(string model, string type, string tyreSize)
        {
            tyres.Add(new Tyre(model, type, tyreSize));
            return "Tyre " + model + " added to " + Brand;
        }
        public string PrintTyres()
        {
            string array = "";
            foreach (Tyre tyres in tyres)
            {
                array = array + " " + tyres.Print() + "\n";
            }
            return array;
        }

        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;
            Console.WriteLine("Created a new vehichle {0} model {1}", brand, model);
        }

        public void Print()
        {
            Console.WriteLine("Vehicle name: " + Brand + " Model:" + Model);
            Console.WriteLine("Tyres:");
            Console.WriteLine(PrintTyres());
        }

    }


}
