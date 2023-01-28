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
            List<Language> languages = File.ReadAllLines("./LanguagesProgramming.tsv")
              .Skip(1)
              .Select(line => Language.FromTsv(line))
              .ToList();


            //print each item in languages by calling its Prettify() method.
            foreach (var lang in languages)
            {
                // Console.WriteLine(lang.Prettify());
            }


            //Write a query that returns a string for each language. It should include the year, name, and chief developer of each language. Print each one to the console.

            var basicInfo = languages.Select(x => $"{x.Year}, {x.Name}, {x.ChiefDeveloper}");

            foreach (var lang in basicInfo)
            {
                // Console.WriteLine(lang);
            }


            //Find the language(s) with the name "C#". Use the Prettify() method to print the results to the console.

            var csharpLangs = languages.Where(x => x.Name == "C#");

            foreach (var lang in csharpLangs)
            {
                //  Console.WriteLine(lang.Prettify());
            }


            //Find all of the languages which have "Microsoft" included in their ChiefDeveloper property.

            var microsoftLangs = languages.Where(x => x.ChiefDeveloper.Contains("Microsoft"));
            foreach (var lang in microsoftLangs)
            {
                //Console.WriteLine(lang.Prettify());
            }


            //Find all of the languages that descend from Lisp.
            var lispLangs = languages.Where(x => x.Predecessors.Contains("Lisp"));
            foreach (var lang in lispLangs)
            {
                //Console.WriteLine(lang.Prettify());
            }


            //Find all of the language names that contain the word "Script" (capital S). Make sure the query only selects the name of each language
            var scriptLangs = languages
                .Where(x => x.Name.Contains("Script"))
                .Select(x => x.Name);

            foreach (var lang in scriptLangs)
            {
                // Console.WriteLine(lang);
            }

            //How many languages are included in the languages list?
            //  Console.WriteLine($"Number of Languages are {languages.Count}");


            //How many languages were launched between 1995 and 2005?
            var nearMilleniumLangs = languages.Where(x => x.Year >= 1995 && x.Year <= 2005).Select(x => $"{x.Name} was invented in {x.Year}");
            //  Console.WriteLine($"Near Millenium Languages are {nearMilleniumLangs.Count()}");

            /*Print a string for each of those near-millennium languages.
            In your query add a Select operation that returns a string of this format for each element*/

            foreach (var lang in nearMilleniumLangs)
            {
                //Console.WriteLine(lang);
            }

            // PrettyPrintAll(lispLangs);
            // PrintAll(nearMilleniumLangs);




            /*Try sorting a query alphabetically (on the name of each language) using the OrderBy() method.*/
            var ordered = languages.OrderBy(x => x.Name);
            //PrettyPrintAll(ordered);


            //Find the oldest language in the list using the Min() method.
            var oldest = languages.Min(x => x.Year);
            //Console.WriteLine(oldest);


            Console.ReadLine();
        }



        /*Write a method PrettyPrintAll() that handles that for us. It should: ; return nothing; accept an argument of type IEnumerable<Language> ; pretty print every language in the argument*/

        public static void PrettyPrintAll(IEnumerable<Language> langs)
        {
            foreach (Language lang in langs)
            {
                Console.WriteLine(lang.Prettify());
            }
        }

        /*Write a method PrintAll() that handles that for us. It should:

           return nothing
           accept an argument of type IEnumerable<Object>
           prints every object in the argument*/

        public static void PrintAll(IEnumerable<Object> sequence)
        {
            foreach (Object obj in sequence)
            {
                Console.WriteLine(obj);
            }
        }

    }
}
