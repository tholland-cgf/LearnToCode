using LearnToCode.ConsoleUI.Interfaces;
using LearnToCode.ConsoleUI.Exercises;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LearnToCode.ConsoleUI
{
    internal class Program
    {
        const string FILE_PATH = @"c:\temp\names.txt";
        static void Main(string[] args)
        {
            Interfaces02();
            Interfaces01();

            Loops();

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
            List<IAnimal> animals = new List<IAnimal>();


            IAnimal d = new Dog();
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


    }
}

