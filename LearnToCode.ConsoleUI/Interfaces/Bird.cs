using System;

namespace LearnToCode.ConsoleUI.Interfaces
{
    class Bird : IAnimal
    {
        public int Age { get; set; }
        public string Name { get; set; }


        public void MakeNoise()
        {
            Console.WriteLine("Squawk");
        }

        public void Move()
        {
            Console.WriteLine("Flying");
        }
    }


}
