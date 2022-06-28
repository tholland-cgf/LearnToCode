using LearnToCode.ConsoleUI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnToCode.ConsoleUI.Inheritance
{
    public abstract class Animal: IAnimal2
    {
        public string Name { get; set; }
        public int Age { get; set; }
        

        public abstract void Move();
        public abstract void MakeNoise();

        public virtual void Eat() 
        {
            Console.WriteLine("Animal eating the way that animals do");
        }
    }
}
