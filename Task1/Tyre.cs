using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Tyre
    {
        private string Model { get; set; }
        private string Type { get; set; }
        private string TyreSize { get; set; }
        public Tyre(string model, string type, string tyreSize)
        {
            Model = model;
            Type = type;
            TyreSize = tyreSize;
            Console.WriteLine("Tyre " + Model + " added to vehicle " + this.Model);

        }
        public string Print()
        {
            return Model + " " + Type + " " + TyreSize;
        }


    }
}
    