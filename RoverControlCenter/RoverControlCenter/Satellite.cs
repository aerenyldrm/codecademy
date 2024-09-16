namespace RoverControlCenter
{
    class Satellite(string alias, int yearLaunched) : IDirectable // primary constructor
    {
        // property
        public string Alias
        { get; private set; } = alias;

        public int YearLaunched
        { get; private set; } = yearLaunched;

        // interface method
        public string GetInfo()
        {
            return $"Alias: {Alias}, Year Launched: {YearLaunched}.";
        }

        public virtual string Explore()
        {
            return "Satellite explores the deep space!";
        }

        public virtual string Collect()
        {
            return "Satellite collects photographic evidence!";
        }
    }
}