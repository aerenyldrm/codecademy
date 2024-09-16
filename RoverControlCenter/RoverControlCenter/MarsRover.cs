namespace RoverControlCenter
{
    class MarsRover(string alias, int yearLanded) : Rover(alias, yearLanded) // primary constructor, inherit from Rover
    {   
        // method
        public override string Explore()
        {
            return "Mars rover explores the surface!";
        }

        public override string Collect()
        {
            return "Mars rover collects rocks!";
        }
    }
}