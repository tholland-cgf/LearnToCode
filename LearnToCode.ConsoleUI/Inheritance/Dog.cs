using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnToCode.ConsoleUI.Inheritance
{
    public class Dog : Animal
    {



        public override void MakeNoise()
        {
            Console.WriteLine("Bark");
        }


        public override void Move()
        {
            Console.WriteLine("Walking");
        }

        public override void Eat() 
        {
            Console.WriteLine("Dog eating out of a bowl and waging its tail");
        }

    }
}
