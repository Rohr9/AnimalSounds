using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    public class Sheep : Animals
    {
        public Sheep(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine("Baaah");
        }
    }
}
