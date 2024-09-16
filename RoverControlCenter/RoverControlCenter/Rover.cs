namespace RoverControlCenter
{
    class Rover(string alias, int yearLanded) : IDirectable // primary constructor
    {
        // property
        public string Alias
        { get; private set; } = alias;

        public int YearLanded
        { get; private set; } = yearLanded;

        // interface method
        public string GetInfo()
        {
            return $"Alias: {Alias}, Year Landed: {YearLanded}.";
        }

        public virtual string Explore()
        {
            return "Rover explores the surface!";
        }

        public virtual string Collect()
        {
            return "Rover collects rocks!";
        }
    }
}