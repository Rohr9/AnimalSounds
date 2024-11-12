namespace AnimalSounds
{
    public class Program
    {
        static void Main(string[] args)
        {
            //WARNING change switch case or the program will run infinite
            Animals cat = AnimalFactory.CreateAnimal(enmAnimals.Cat, "Katniss");
            Animals dog = AnimalFactory.CreateAnimal(enmAnimals.Dog, "Doggie");
            Animals sheep = AnimalFactory.CreateAnimal(enmAnimals.Sheep, "Laura");

            cat.MakeSound();
            dog.MakeSound();
            sheep.MakeSound();

            Console.ReadLine();
        }
    }
}
