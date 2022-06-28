using System;

namespace LearnToCode.ConsoleUI.Interfaces
{
    class Cat : IAnimal
    {

        public int Age { get; set; }
        public string Name { get; set; }

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
