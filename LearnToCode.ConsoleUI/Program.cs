using LearnToCode.ConsoleUI.Interfaces;
using LearnToCode.ConsoleUI.Exercises;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LearnToCode.Repository;
using LearnToCode.Models;

namespace LearnToCode.ConsoleUI
{
    internal class Program
    {
        const string FILE_PATH = @"c:\temp\names.txt";
        static void Main(string[] args)
        {
            TestRepo();
            //Inheritance01();
            //Inheritance02();

            //Interfaces02();
            //Interfaces01();

            //Loops();

            Console.ReadLine();
        }

        private static void Loops()
        {
            IExercise exercise = new StringExercises("The quick brown fox jumps over the lazy dog.");
            exercise.Execute();

            //exercise = new LoopExercises();
            
            //exercise.Execute();

            //exercise = new FileReadAndWriteExercises(@"c:\temp\names.txt");
            //exercise.Execute();

            exercise = new BasicLoopExercises();
            exercise.Execute();
        }

        static void Interfaces01()
        {

            //Animal a= new IAnimal();


            Dog d = new Dog();
            IAnimal b = new Bird();
            IAnimal c = new Cat();

            d.MakeNoise();
            d.Move();

        }

        static void Interfaces02()
        {
            List<IAnimal> animals = new List<IAnimal>();


            animals.Add(new Dog());
            animals.Add(new Bird());
            animals.Add(new Cat());


            foreach (var a in animals)
            {
                a.MakeNoise();
                a.Move();
            }

        }

        static void Inheritance01()
        {
            //List<IAnimal> animals = new List<IAnimal>();


            Inheritance.Dog d = new Inheritance.Dog();

            d.Eat();



            Inheritance.Cat c = new Inheritance.Cat();
            c.Eat();
        }

        static void Inheritance02()
        {
            List<Inheritance.IAnimal2> animals = new List<Inheritance.IAnimal2>();


            animals.Add(new Inheritance.Dog());
            animals.Add(new Inheritance.Cat());



            foreach (var a in animals)
            {
                a.MakeNoise();
                a.Move();
                a.Eat();
            }



            Inheritance.Cat c = new Inheritance.Cat();
            
            
        }

        static void TestDbRepo()
        {
            IPersonRepository repo = new PersonSqlRepository();
            IEnumerable<Person> plist = repo.GetPersonList("");

            //pass list on to a web page or other service that will use the list

        }
        static void TestFileRepo()
        {
            IPersonRepository repo = new PersonFileRepository();
            IEnumerable<Person> plist = repo.GetPersonList("");

            //pass list on to a web page or other service that will use the list

        }
    }
}

