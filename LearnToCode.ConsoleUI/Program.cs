using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LearnToCode.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadPersistedListTest();
            //ListTest();
            //InputTest();
            Console.ReadLine();
        }

        private static void ListTest()
        {
            List<string> names = new List<string>();


            Console.WriteLine("Enter a name");
            //get name from user
            string name1 = Console.ReadLine();
            //and add to list
            names.Add(name1);


            Console.WriteLine("And another...");
            //less code
            //get next name from user
            names.Add(Console.ReadLine());


            Console.WriteLine("And one more...");
            //...and another
            names.Add(Console.ReadLine());



            Console.WriteLine("Printing the list of names in the same order they were entered");
            //print out the name in the order they were added
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }


            Console.WriteLine("Printing the list of names in the alpha order");
            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        private static void ReadPersistedListTest()
        {
            List<string> names = new List<string>();
            var existingNames = File.ReadAllLines("Names.txt");

            foreach (var name in existingNames)
            {
                Console.WriteLine(name);
                names.Add(name);
            }


            

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

