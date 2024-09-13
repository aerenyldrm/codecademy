using System;

namespace TheObjectOfYourAffection
{
    public class Profile(string? name, int age, string? city, string? country, string pronoun = "it")
    {
        private string[] hobbies = [];
        
        public string? Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string? City { get { return city; } set { city = value; } }
        public string? Country { get { return country; } set { country = value; } }
        public string? Pronoun { get { return pronoun; } set { country = value; } }

        public string ViewProfile()
        {
            string returnString = $"{Name}.\n{Age}.\n{City}.\n{Country}.\n{Pronoun}.";

            if (hobbies.Length > 0)
            {
                returnString += "\n";
                foreach (string hobby in hobbies)
                    returnString += $"{hobby} ";
                returnString = returnString.Trim(); returnString += ".";
            }

            return returnString.ToUpper();
        }

        public void SetHobby(string[] hobbies)
        {
            this.hobbies = hobbies;
        }
    }
}
