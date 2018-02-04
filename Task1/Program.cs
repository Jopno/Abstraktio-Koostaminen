using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Porsche = new Car("Porsche", "911");
            Porsche.addTyre("Nokia", "Hakkapeliitta", "20R16");
            Porsche.addTyre("Nokia", "Hakkapeliitta", "20R16");
            Porsche.addTyre("Nokia", "Hakkapeliitta", "20R16");
            Porsche.addTyre("Nokia", "Hakkapeliitta", "20R16");

            Porsche.Print();
        }
    }

}
