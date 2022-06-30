using System;

namespace LearnToCode.ConsoleUI.Interfaces
{
    class Dog : IAnimal

    {

        public int Age { get; set; }
        public string Name { get; set; }

      

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
//private string _name;

//public string Name
//{
//    get
//    {
//        return _name;
//    }

//    set 
//    {
//        _name = value;
//    }
//}