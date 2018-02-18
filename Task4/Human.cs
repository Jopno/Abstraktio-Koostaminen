using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MammalApplication
{
    class Human : Mammal
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        private int age;

        public override int Age
        {
            get { return age; }
            set
            {
                age = value;
            }

        }
        public override void Move()
        {
            Console.WriteLine("I move");
        }

        public void Grow()
        {
            age += 1;
        }
        public override string ToString()
        {
            return Name + " " + Weight + " " + Height + " " + Age;
        }


    }
}
