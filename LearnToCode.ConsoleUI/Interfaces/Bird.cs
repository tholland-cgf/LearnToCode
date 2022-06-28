using System;

namespace LearnToCode.ConsoleUI.Interfaces
{
    class Bird : IAnimal
    {
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
