using System;

namespace LearnToCode.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InputTest();
            Console.ReadLine();
        }

        private static void InputTest()
        {
            Console.Write("Enter a whole number: ");
            int input;

            while(!int.TryParse(Console.ReadLine(),out input ))
            {
                Console.WriteLine("You must enter a whole number");
            }

            LoopTest(input);

        }

        private static void LoopTest(int max)
        {
            for (int i = 1; i <= max; i++)
            {
                Console.WriteLine($"{i} x {i} = {i * i}");
            }
        }

        static void Output(string value)
        {
            Console.WriteLine($"Outputting {value}");
        }


    }
}
