using System;

namespace LearnToCode.ConsoleUI.Inheritance
{
    class Cat : Animal
    {

       

        public override void MakeNoise()
        {
            Console.WriteLine("meow");
        }

        public override void Move()
        {
            Console.WriteLine("Stalking");
        }
    }


}
