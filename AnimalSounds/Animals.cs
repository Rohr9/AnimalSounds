namespace AnimalSounds
{
    public abstract class Animals
    {
        public string Name { get; set; }

        public Animals(string name)
        {
            Name = name;
        }

        public abstract void MakeSound();
    }
}
