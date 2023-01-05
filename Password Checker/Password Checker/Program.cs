using System;

namespace Password_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int minLength = 8;
            string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "!@#$%^&*()_+";


            //Now we’ll capture input from the user. Ask the user to enter a password and capture their input in a variable.
            Console.WriteLine("\n ENTER A PASSWORD \n");
            string password = Console.ReadLine();
            // Console.WriteLine(password);
            int score = 0;

            if (password.Length >= minLength)
            {
                score++;
            }
            //Tools.Contains(target, list);
            if (Tools.Contains(password, upperCase))
            {
                score++;
            }
            if (Tools.Contains(password, lowerCase))
            {
                score++;
            }
            if (Tools.Contains(password, digits))
            {
                score++;
            }
            if (Tools.Contains(password, specialChars))
            {
                score++;
            }
            Console.WriteLine(score);
            //Run the code using these below given examples.
            //oooOVER-9000! should get a 5
            //thatsallfolks should get a 2
            //" "(a bunch of spaces) should get a 0


            switch (score)
            {
                case 5:
                    Console.WriteLine("the password is extremely strong");
                    break;
                case 4:
                    Console.WriteLine("the password is extremely strong");
                    break;
                case 3:
                    Console.WriteLine("the password is strong");
                    break;
                case 2:
                    Console.WriteLine("the password is medium");
                    break;
                case 1:
                    Console.WriteLine("the password is weak");
                    break;
                default:
                    Console.WriteLine("the password doesn’t meet any of the standards");
                    break;
            }
            /*Test your program with a few passwords! Here are some examples to use:

word scores a 1. Weak.
woRD scores a 2. Medium.
1woRD scores a 3. Strong.
2woRDsss scores a 4. Extremely strong!
2woRDsss! scores a 5. Extremely strong again!
" " scores a 0. It’s a bunch of spaces…It doesn’t meet any of the standards.*/



            Console.ReadLine();

        }
    }
}
