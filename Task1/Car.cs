using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Car : Vehicle
    {
        public Car(string brand, string model) : base(brand, model)
        {
        }

        private string CarType { get; set; }

    }
}
