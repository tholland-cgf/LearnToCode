using System;

namespace LearnToCode.ConsoleUI.Interfaces
{
    class Cat : IAnimal
    {
        public void MakeNoise()
        {
            Console.WriteLine("meow");
        }

        public void Move()
        {
            Console.WriteLine("Stalking");
        }
    }


}
