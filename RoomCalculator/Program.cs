using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) Ask the user to input the length and width of the classroom.
            //2) Display the area and perimeter of the classroom
            //3) Display how many paint containers and squares of carpet you will need.
            //4) Prompt the user to continue to measure rooms.

            char runAgain = 'y';

            while (runAgain == 'y')
            {

                Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");
                Console.WriteLine("Please input the length");
                Console.WriteLine();

                string input = Console.ReadLine();
                double length = double.Parse(input);

                Console.WriteLine("Please Input the width");
                Console.WriteLine();

                input = Console.ReadLine();
                double width = double.Parse(input);

                Console.WriteLine("Please input the height");
                Console.WriteLine();

                input = Console.ReadLine();
                double height = double.Parse(input);

                double area = length * width;
                double perimeter = length * 2 + width * 2;
                double volume = length * width * height;

                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);
                Console.WriteLine("Volume: " + volume);

                double paintcan = perimeter * height / 5;
                double floortile = area / 5;

                Console.WriteLine("Paint Cans: " + paintcan);
                Console.WriteLine("Floor Tiles " + floortile);

                Console.WriteLine("Would you like to try a different room (y/n)");
                runAgain = char.Parse(Console.ReadLine());


            }








        }
    }
}
