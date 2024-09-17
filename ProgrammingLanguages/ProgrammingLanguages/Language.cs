using System;

namespace ProgrammingLanguages
{
    public class Language
    {
        // property
        public int Year
        { get; set; }

        public string Name
        { get; set; }

        public string ChiefDeveloper
        { get; set; }

        public string PredecessorSet
        { get; set; }

        // constructor
        public Language(int year, string name, string chiefDeveloper, string predecessorSet)
        {
            Year = year;
            Name = name;
            ChiefDeveloper = chiefDeveloper;
            PredecessorSet = predecessorSet;
        }

        // class method
        public static Language FromTSV(string TSVLine)
        {
            string[] valueSet = TSVLine.Split('\t');
            Language language = new Language(
              Convert.ToInt32(valueSet[0]),
              Convert.ToString(valueSet[1]),
              Convert.ToString(valueSet[2]),
              Convert.ToString(valueSet[3]));
            return language;
        }

        // instance method
        public string Prettify()
        {
            return $"{Year}, {Name}, {ChiefDeveloper}, {PredecessorSet}";
        }
    }
}