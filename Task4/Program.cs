using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MammalApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human
            {
                Name = "Joni",
                Weight = 85,
                Height = 180,
                Age = 21
            };

            Adult adult = new Adult
            {
                Name = "Jorma",
                Weight = 55,
                Height = 190,
                Job = "Engineer",
                Age = 45

            };

            Baby baby = new Baby
            {
                Name = "Pena",
                Weight = 5,
                Height = 45,
                Age = 1,
                Diaper = "Pampers" 
            };

            human.Move();
            adult.Move();
            baby.Move();



            adult.Grow();
            human.Grow();
            baby.Grow();


            Console.WriteLine(human.ToString());
            Console.WriteLine(adult.ToString());
            Console.WriteLine(baby.ToString());





        }
    }
}
