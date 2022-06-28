using System;

namespace LearnToCode.ConsoleUI.Interfaces
{
    class Dog :IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Walking");
        }

        public void MakeNoise()
        {
            Console.WriteLine("Bark");
        }


    }


}
