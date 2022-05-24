using System;

namespace LearnToCode.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Hello("John");
            Hello("Terry");
        }


        static void Hello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}
