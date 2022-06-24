using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnToCode.ConsoleUI.Classes
{
    interface IAnimal
    {

        void Move();
        void MakeNoise();
    }

    class Dog:IAnimal
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
