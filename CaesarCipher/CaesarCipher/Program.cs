using System;

namespace CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            //Prepare for Encryption
            //ask the user for a secret message and store the result in a variable
            Console.Write("Enter your secret Message\n");
            string input = Console.ReadLine();



            //Convert the captured string to an array of characters.
            char[] secretMessage = input.ToCharArray();


            //Create a new, empty array of characters to hold the encrypted message. It should be named encryptedMessage and have a length equal to the length of secretMessage.

            char[] encryptedMessage = new char[secretMessage.Length];





            //Encrypt


            //We’ll need to perform encryption for every letter in the message.
            //Create an empty for loop that loops through each character of secretMessage
            for (int i = 0; i < secretMessage.Length; i++)
            {
                //Within the loop, access the character at position i in the secretMessage array and store it in a variable
                char letter = secretMessage[i];

                //Find the position of the character in the alphabet array using the method Array.IndexOf().Store the value in a variable
                int letterPosition = Array.IndexOf(alphabet, letter);



                //Add 3 to the letter position and store the value in a variable
                //We can “wrap around” by using the modulo operator: %.On the line where you add 3 to the letter position, surround the expression letterPosition + 3 with parentheses and take the modulo of 26.
                int newLetterPosition = (letterPosition + 3) % 26;



                //Find the new encrypted character by getting the character in the alphabet array with that new position
                char letterEncoded = alphabet[newLetterPosition];


                //Add the encrypted character to the array encryptedMessage.Store the character at the index i(the iterator variable)
                encryptedMessage[i] = letterEncoded;
            }

            //Now we need to convert our array of encrypted characters back into a readable string that we can print to the console
            string encodedString = String.Join("", encryptedMessage);
            Console.WriteLine($"your encoded message is : {encodedString}");

            Console.ReadLine();
        }
    }
}

//What went wrong? When the program tried to encrypt the z in citizen, it found its index in the alphabet, 25. It looked up the letter 3 spaces to the right, which would be alphabet[28].

//This threw an error because the alphabet is only 26 letters!

//We can “wrap around” by using the modulo operator: %.On the line where you add 3 to the letter position, surround the expression letterPosition + 3 with parentheses and take the modulo of 26.

//Now the new letter position will never go past 26