using System;
namespace ArchitectArithmetic
{
    //In this project, you’ll use methods to build a program that calculates the material cost for any architect’s floor plan.
    class Program
    {
        public static void Main(string[] args)
        {

            //Use conditional statements and Console.ReadLine() to allow users to pick which monument for which they’d like to calculate a cost.
            Console.WriteLine("What monument would you like to work with? ");
            Console.Write("Teotihuacan(1), Taj Mahal(2), Great Mosque of Mecca(3) : ");
            string monumnet = Console.ReadLine();

            double TotalArea;


            switch (monumnet)
            {
                case "1":
                    // Calculate the area of each part, add them together, and store the result in a variable.
                    TotalArea = Rect(2500, 1500) + Circle(0.5 * 375) + Triangle(500, 750);
                    break;
                case "2":
                    TotalArea = Rect(90.5, 90.5) - 2 * Rect(24, 24);
                    break;
                case "3":
                    TotalArea = Rect(180, 106) + Rect(200, 264) + Triangle(264, 84);
                    break;
                default:
                    TotalArea = 0;
                    break;

            }

            //Multiply the total area by the cost of flooring material – 180 Mexican pesos – and store the result in a variable.
            double totalCost = TotalArea * 180;
            Console.WriteLine($"My plan costs: {Math.Round(totalCost, 2)} pesos");

            Console.ReadLine();

        }
        static double Rect(double Length, double Width)
        {
            //area = length \times widtharea=length×width
            return Length * Width;

        }
        static double Circle(double radius)
        {
            //area=π×radius2
            return Math.PI * Math.Pow(radius, 2);

        }

        static double Triangle(double bottom, double Height)
        {
            //area=0.5×bottom×height
            return 0.5 * bottom * Height;

        }

    }


}
