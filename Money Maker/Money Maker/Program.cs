using System;

namespace Money_Maker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");

            Console.WriteLine("Enter an amount to convert to coins:");
            string str = Console.ReadLine();

            //Convert the captured value (a string) to a number.
            double amount = Convert.ToDouble(str);


            Console.Write($"{amount} is equals to: \n");


            //Define two variables that hold those values.
            int goldValue = 10;
            int silverValue = 5;

            // Divide the amount by the value of a gold coin
            // Round down to the nearest integer
            // Store the result in a double variable called goldCoins

            double goldcoins = Math.Floor(amount / goldValue);


            //Use the modulo(%) operator to find the remaining amount and store it in a double variable.
            double remainder = amount % goldValue;


            //Find the maximum number of silver coins that “fit” into the remainder:
            //Divide the remainder by the value of a silver coin
            //Round down to the nearest integer
            //Store the result in a double variable called silverCoins

            double silverCoins = Math.Floor(remainder / silverValue);


            //Use the modulo(%) operator to find the remaining amount and store it in a double variable.
            remainder = remainder % silverValue;



            // Print out all of the coins!
            Console.WriteLine($"Gold coins: {goldcoins} \n");
            Console.WriteLine($"Silver coins: {silverCoins} \n");
            Console.WriteLine($"Bronze coins: {remainder}");

            Console.ReadLine();

        }

    }
}
