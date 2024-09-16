namespace RoverControlCenter
{
    class MoonRover(string alias, int yearLanded) : Rover(alias, yearLanded) // primary constructor, inherit from Rover
    {
        // method
        public override string Explore()
        {
            return "Moon rover explores the surface!";
        }

        public override string Collect()
        {
            return "Moon rover collects rocks!";
        }
    }
}