using System;

namespace ExquisiteCorpse
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildACreature("ghost", "bug", "monster");

            //RandomMode();


            Console.ReadLine();
        }


        // Next, we need to take the string values that are passed into the BuildACreature() parameters and convert them to ints using TranslateToNumber().
        //Call TranslateToNumber() three times, one for each body part.Save your method calls to a set of int variables.You can call them headNum, etc.
        static void BuildACreature(string head, string body, string feet)
        {
            int HeadNum = TranslateToNumber("head");
            int BodyNum = TranslateToNumber("body");
            int feetNum = TranslateToNumber("feet");
            SwitchCase(HeadNum, BodyNum, feetNum);

        }


        //we will create a custom method that uses the built-in Random() class and it’s method.Next() to randomly assemble a body each time the program is run.
        static void RandomMode()
        {
            //We’ll create an instance and new Random object
            Random randomNumber = new Random();

            //            Next, we want to use the Random class’s Next() method to randomly pick a number between 1 and inclusive of 3. For that reason, the range we will use is (1, 4) where 1 is the minimum value and 4 is the maximum.

            //Since there are three things we want to randomly select, we’ll want to call the Next() method three times, each time saving it to a new variable.In total, there should be three variables with a random value, one of the head, body, and feet.

            int head = randomNumber.Next(1, 4);
            int body = randomNumber.Next(1, 4);
            int feet = randomNumber.Next(1, 4);
            SwitchCase(head, body, feet);
        }


        //        To start refactoring our code, we’ll create a new custom method to store our switch statement.Call this method SwitchCase() and give it int parameters named head, body, and feet.

        //11.
        //Now, inside of the SwitchCase(), write three switch statements that use the parameter integer values to call the different creature methods.

        static void SwitchCase(int head, int body, int feet)
        {
            switch (head)
            {
                case 1:
                    GhostHead();
                    break;
                case 2:
                    BugHead();
                    break;
                case 3:
                    MonsterHead();
                    break;

            }
            switch (body)
            {
                case 1:
                    GhostBody();
                    break;


                case 2:
                    BugBody();
                    break;
                case 3:
                    MonsterBody();
                    break;

            }
            switch (feet)
            {
                case 1:
                    GhostFeet();
                    break;

                case 2:
                    BugFeet();
                    break;
                case 3:
                    MonsterFeet();
                    break;

            }

        }
        //In order to keep using strings, we need to create a method that translates the meaning of our string data into ints.This method will take in a creature name and translate it to an int that SwitchCase() can make sense of.
        static int TranslateToNumber(string creature)
        {
            switch (creature)
            {
                case "ghost":
                    return 1;
                case "bug":
                    return 2;

                case "monster":
                    return 3;
                default: return 1;


            }
        }

        static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　  (,___,)");
        }

        static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }

    }
}
