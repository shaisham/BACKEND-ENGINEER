using System;

namespace TrueorFalse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();


            // Type your code below

            //We’ll need arrays to hold the questions, answers, and user responses. First declare and initialize a questions array of  string[]. The array should contain your own true or false questions.


            string[] questions = new string[]
            {
                "About 36 and 42 islands make up New York City", "Only one capital exists in South Africa", "he largest ocean in the world is the Atlantic Ocean", "The tallest mountain in the world is Mount Everest. "
            };

            //Declare and initialize an answers array of type bool[]. It should contain the correct answers for each question, in the same order.

            bool[] answers = new bool[]
            {
                true, false, false, true
            };

            //Declare responses array of type bool[]. It should be an empty array with the same length as the questions array

            bool[] responses = new bool[questions.Length];

            //To avoid any errors later on, write yourself an if statement that checks if the length of the questions array IS NOT equal to the length of the answers array. If they are not equal, write a warning to the console

            if (questions.Length != answers.Length)
            {
                Console.WriteLine("Warning! x doesn't equal y.");
            }


            //Now we’ll loop through the questions array, asking each question and recording the user’s responses.First, create a variable askingIndex to keep track of the currently asked question. Set it to 0
            int askingIndex = 0;

            //Build an empty foreach loop that iterates through each question in questions.

            foreach (string question in questions)
            {

                //input — the text the user enters
                //isBool — true if the user input can be converted to a boolean, otherwise false
                //inputBool — the boolean version of the user’s entry
                string input;
                bool isBool;
                bool inputBool;


                //Print the current question to the console
                Console.WriteLine(question);

                //Print the current question to the console
                Console.WriteLine("True of False?");


                //Capture the user’s input in input
                input = Console.ReadLine();

                //Call the method Boolean.TryParse() to convert the user input to a boolean value
                isBool = Boolean.TryParse(input, out inputBool);



                //We may have to ask the current question multiple times if the user responds in the wrong format. Create an empty while loop within the foreach loop.It should continue looping while isBool is false
                while (!isBool)
                {
                    Console.WriteLine("Pleaee respond with True or False!");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }

                responses[askingIndex] = inputBool;
                askingIndex++;

            }
            //scoringIndex — to loop through the responses. Set to 0
            //score — to count the number of correct responses.Set to 0

            int scoringIndex = 0;
            int score = 0;

            foreach (bool answer in answers)
            {
                //use scoringIndex to access an element in responses and store the value in a variable.
                bool response = responses[scoringIndex];
                Console.Write(scoringIndex + 1 + ".");
                Console.WriteLine($"input: { response}| answer: {answer}");

                if (response = answer)
                {
                    score++;
                }
                scoringIndex++;
            }
            Console.WriteLine($"you got {score} out of {questions.Length} correct");


            Console.ReadLine();
        }
    }
}
