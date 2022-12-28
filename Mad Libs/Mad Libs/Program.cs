using System;

namespace Mad_Libs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
      This program In this project, we’ll use C# to write a Mad Libs word game! Mad Libs are short stories with blanks for the player to fill in that represent different parts of speech. 
      Author: shameer...
      */


            // Let the user know that the program is starting:
            Console.WriteLine("The MAT LABS is starting");


            // Give the Mad Lib a title:
            string title = "The title is Kingexpt";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.Write(" Enter a name: ");
            string name = Console.ReadLine();

            Console.Write("\n Enter any Three adjectives:\n");
            string adj1 = Console.ReadLine();
            string adj2 = Console.ReadLine();
            string adj3 = Console.ReadLine();

            Console.WriteLine("\n Enter a verb:");
            string verb = Console.ReadLine();
            Console.WriteLine("\n Enter any two nouns \n");
            string noun1 = Console.ReadLine();
            string noun2 = Console.ReadLine();

            Console.WriteLine("\n Enter a animal:");
            string animal = Console.ReadLine();

            Console.WriteLine("Enter a food:");
            string food = Console.ReadLine();

            Console.WriteLine("Enter a fruit:");
            string fruit = Console.ReadLine();

            Console.WriteLine("Enter a superhero:");
            string superhero = Console.ReadLine();

            Console.WriteLine("Enter a country:");
            string country = Console.ReadLine();

            Console.WriteLine("Enter a dessert:");
            string dessert = Console.ReadLine();

            Console.WriteLine("Enter a year:");
            string year = Console.ReadLine();

            // The template for the story:

            string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);
            Console.ReadLine();
        }
    }
}
