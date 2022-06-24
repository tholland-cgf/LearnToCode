using LearnToCode.ConsoleUI.Classes;
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
            TestInheritance2();
            TestInheritance();



            IExercise exercise;

            exercise = new StringExercises("The quick brown fox jumps over the lazy dog.");
            exercise.Execute();

            exercise = new LoopExercises();
            exercise.Execute();

            exercise = new FileReadAndWriteExercises(@"c:\temp\names.txt");
            exercise.Execute();

            exercise = new BasicLoopExercises();
            exercise.Execute();



            Console.ReadLine();
        }


        static void TestInheritance()
        {
            List<IAnimal> animals = new List<IAnimal>();


            Classes.IAnimal d = new Classes.Dog();
            Classes.IAnimal b = new Classes.Bird();
            Classes.IAnimal c = new Classes.Cat();

            d.MakeNoise();
            d.Move();

        }

        static void TestInheritance2()
        {
            List<IAnimal> animals = new List<IAnimal>();


            animals.Add( new Classes.Dog());
            animals.Add(new Classes.Bird());
            animals.Add(new Classes.Cat());


            foreach (var a in animals)
            {
                a.MakeNoise();
                a.Move();
            }

        }
        //private static void ListTest()
        //{
        //    List<string> names = new List<string>();


        //    Console.WriteLine("Enter a name");
        //    //get name from user
        //    string name1 = Console.ReadLine();
        //    //and add to list
        //    names.Add(name1);


        //    Console.WriteLine("And another...");
        //    //less code
        //    //get next name from user
        //    names.Add(Console.ReadLine());


        //    Console.WriteLine("And one more...");
        //    //...and another
        //    names.Add(Console.ReadLine());



        //    Console.WriteLine("Printing the list of names in the same order they were entered");
        //    //print out the name in the order they were added
        //    foreach (var name in names)
        //    {
        //        Console.WriteLine(name);
        //    }


        //    Console.WriteLine("Printing the list of names in the alpha order");
        //    names.Sort();
        //    foreach (var name in names)
        //    {
        //        Console.WriteLine(name);
        //    }
        //}

        //private static void ReadPersistedListTest()
        //{
        //    List<string> names = new List<string>();
        //    var existingNames = File.ReadAllLines(FILE_PATH);

        //    foreach (var name in existingNames)
        //    {
        //        Console.WriteLine(name);
        //        names.Add(name);
        //    }
        //}



    }
}

