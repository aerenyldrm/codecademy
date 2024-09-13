using System.Globalization;

namespace StellarLifecycleSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");

            Star sun = new Star("Sun", "G-Type");
            sun.Shine();
            sun.GrowOlder();
            sun.Shine();
            sun.Supernova();

            Star unknownStar = new Star("Mystery Star");
            unknownStar.Shine();
            unknownStar.GrowOlder();
        }
    }
}