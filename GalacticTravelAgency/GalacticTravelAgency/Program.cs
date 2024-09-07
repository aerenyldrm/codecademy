using System;

public class GalacticTravelAgency
{
    public static void Main(string[] args)
    {
        // create passenger profiles
        string passengerName = "Zara";
        int passengerAge = 28 + 1;
        string ticketType = "First Class";
        string preferredPlanet = "Mars";

        // print and basic operations
        Console.WriteLine(passengerName);
        Console.WriteLine(passengerAge);
        Console.WriteLine(ticketType);
        Console.WriteLine(preferredPlanet);

        // explicit and implicit conversions
        double passengerAgeDouble = (double)passengerAge;
        Console.WriteLine(passengerAgeDouble);

        double passengerAgeDouble2 = passengerAge;
        Console.WriteLine(passengerAgeDouble2);

        string passengerAgeString = Convert.ToString(passengerAge);
        Console.WriteLine(passengerAgeString);
    }
}