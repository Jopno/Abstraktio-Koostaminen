﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MammalApplication
{
    abstract class Mammal
    {
        public abstract int Age { get; set; }

        public abstract void Move();
    }
}
