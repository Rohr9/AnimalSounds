using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Dog : Animals
    {
        public Dog(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine("Vow");
        }
    }
}
