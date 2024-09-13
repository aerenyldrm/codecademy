namespace StellarLifecycleSimulator
{
    internal class Star(string name, string type)
    {
        public string name = name;
        public string type = type;
        public int age = 0;
        public double brightness = 1;

        public Star(string name) : this(name, "Unknown")
        {
            Console.WriteLine("Star type set to default value: Unknown.");
        }

        public void Shine()
        {
            Console.WriteLine($"Star {name} is shining with brightness {brightness}.");
        }

        public void GrowOlder()
        {
            age++;
            brightness *= (double)9 / 10;
        }

        public void Supernova()
        {
            brightness = 0;
            Console.WriteLine($"Star {name} has exploded in a supernova.");
        }
    }
}