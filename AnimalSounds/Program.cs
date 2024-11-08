namespace AnimalSounds
{
    public class Program
    {
        static void Main(string[] args)
        {
            //WARNING change switch case or the program will run infinite
            Animals cat = AnimalFactory.CreateAnimal(enmAnimals.Cat, "Cat");
            Animals dog = AnimalFactory.CreateAnimal(enmAnimals.Dog, "Dog");
            Animals sheep = AnimalFactory.CreateAnimal(enmAnimals.Sheep, "Sheep");

            cat.MakeSound();
            dog.MakeSound();
            sheep.MakeSound();

            Console.ReadLine();
        }
    }
}
