using System.Media;

namespace AnimalSounds
{
    public class Sheep : Animals
    {
        public Sheep(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine("Baaah");
            using (SoundPlayer sound = new SoundPlayer("C:\\Users\\Tec\\source\\repos\\AnimalSounds\\AnimalSounds\\Sounds\\sheep.wav"))
            {
                sound.Load();
                sound.PlaySync();
            }
        }
    }
}
