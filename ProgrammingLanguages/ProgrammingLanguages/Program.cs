using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgrammingLanguages
{
    class Program
    {
        static void Main()
        {
            List<Language> languageSet = File.ReadAllLines("./languageSet.tsv")
              .Skip(1)
              .Select(line => Language.FromTSV(line))
              .ToList();
            /*
            foreach (Language language in languageSet)
              Console.WriteLine(language.Prettify());

            Console.WriteLine(); // line break

            var languageFilter = languageSet.Select(l => $"{l.Year}, {l.Name}, {l.ChiefDeveloper}");

            foreach (string lf in languageFilter)
              Console.WriteLine(lf);

            Console.WriteLine(); // line break
            */
            var csFilter = languageSet
              .Where(l => l.Name.Contains("C#"))
              .Select(l => l);

            PrettyPrintAll(csFilter);

            Console.WriteLine(); // line break

            var microsoftFilter = languageSet
              .Where(l => l.ChiefDeveloper.Contains("Microsoft"))
              .Select(l => l);

            PrettyPrintAll(microsoftFilter);

            Console.WriteLine(); // line break

            var lispFilter = languageSet
              .Where(l => l.PredecessorSet.Contains("Lisp"))
              .Select(l => l);

            PrettyPrintAll(lispFilter);

            Console.WriteLine(); // line break

            var scriptFilter = from l in languageSet
                               where l.Name.Contains("Script")
                               select l.Name;

            PrintAll(scriptFilter);

            Console.WriteLine(); // line break

            Console.WriteLine(languageSet.Count());

            Console.WriteLine(); // line break

            var yearFilter = from l in languageSet
                             where l.Year >= 1995 && l.Year <= 2005
                             select l;

            Console.WriteLine(yearFilter.Count());

            Console.WriteLine(); // line break

            var millenniumFilter = languageSet
              .Where(l => l.Year >= 2000)
              .Select(l => $"{l.Name}: INVENTED WITHIN {l.Year}.");

            PrintAll(millenniumFilter);

            // method
            void PrettyPrintAll(IEnumerable<Language> languageSet)
            {
                foreach (Language language in languageSet)
                    Console.WriteLine(language.Prettify());
            }

            void PrintAll(IEnumerable<Object> objectSet)
            {
                foreach (Object anObject in objectSet)
                    Console.WriteLine(anObject);
            }
        }
    }
}