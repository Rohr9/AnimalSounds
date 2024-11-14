using System.Media;

namespace AnimalSounds
{
    public class Cat : Animals
    {
        public Cat(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine("Meow");
            using (SoundPlayer sound = new SoundPlayer("C:\\Users\\Tec\\source\\repos\\AnimalSounds\\AnimalSounds\\Sounds\\cat.wav")) //har copy path fra lydfilerne i Sounds mappen
            {
                sound.Load();
                sound.PlaySync();
            }

        }

    }
}
