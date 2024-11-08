﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Cat : Animals
    {
        public Cat(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
