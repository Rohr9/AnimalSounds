using System.Media;

namespace AnimalSounds
{
    public class Dog : Animals
    {
        public Dog(string name) : base(name) { }

        public override void MakeSound()
        {
            Console.WriteLine("Vow");
            using (SoundPlayer sound = new SoundPlayer("C:\\Users\\Tec\\source\\repos\\AnimalSounds\\AnimalSounds\\Sounds\\dog.wav"))
            {
                sound.Load();
                sound.PlaySync();
            }
        }
    }
}
