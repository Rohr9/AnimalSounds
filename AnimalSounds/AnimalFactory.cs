namespace AnimalSounds
{
    public static class AnimalFactory
    {
        public static Animals CreateAnimal(enmAnimals animalType, string name)
        {
            switch (animalType)
            {
                case enmAnimals.Cat:
                    return new Cat(name);

                case enmAnimals.Dog:
                    return new Dog(name);

                case enmAnimals.Sheep:
                    return new Sheep(name);
                default:
                    throw new ArgumentException("Unknown animal");

            };
        }

        public static Animals CreateAnimal(enmAnimals animalType)
        {
            switch (animalType)
            {
                case enmAnimals.Cat:
                    return new Cat("Katniss");

                case enmAnimals.Dog:
                    return new Dog("Doggie");

                case enmAnimals.Sheep:
                    return new Sheep("Laura");
                default:
                    throw new ArgumentException("Unknown animal");

            };
        }
    }
}

//Switch casae for each animal?