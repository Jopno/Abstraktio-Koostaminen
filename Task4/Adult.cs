using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MammalApplication
{
    class Adult : Human
    {

        public string Job { get; set; }

        public override void Move()
        {
            Console.WriteLine("I walk");
        }

        public override string ToString()
        {
            return base.ToString() + " " + Job;
        }
    }
}
