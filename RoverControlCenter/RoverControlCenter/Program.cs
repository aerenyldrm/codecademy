using System;

namespace RoverControlCenter
{
    class Program
    {
        static void Main()
        {
            MoonRover lunokhod = new("Lunokhod 1", 1970);
            MoonRover apollo = new("Apollo 15", 1971);
            MarsRover sojourner = new("Sojourner", 1997);
            Satellite sputnik = new("Sputnik", 1957);

            Object[] probeArray = [lunokhod, apollo, sojourner, sputnik];

            foreach (Object probe in probeArray)
                Console.WriteLine($"Tracking a {probe.GetType()}.");

            Console.WriteLine(); // line break

            IDirectable[] entireProbeArray = [lunokhod, apollo, sojourner, sputnik];
            DirectAll(entireProbeArray);
        }

        static void DirectAll(IDirectable[] probeArray)
        {
            int counter = 1;

            foreach (IDirectable probe in probeArray)
            {
                Console.WriteLine(probe.GetInfo());
                Console.WriteLine(probe.Explore());
                Console.WriteLine(probe.Collect());
                if (counter != 4)
                    Console.WriteLine(); // line break
                counter++;
            }
        }
    }
}