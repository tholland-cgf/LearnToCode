using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnToCode.ConsoleUI.Exercises
{
    public class FileReadAndWriteExercises
        : IExercise
    {
        string _filePath;

        public FileReadAndWriteExercises(string path)
        {
            _filePath = path;
        }


        public void Execute()
        {
            ReadWritePersistedListTest();
        }


        private void ReadWritePersistedListTest()
        {

            //read lines in file...
            List<string> names = GetLinesFromFile(_filePath).ToList();

            //Output list to console
            PrintList("Names currently in file:", names);

            //keep asking user for name until they enter empty string
            Console.WriteLine("Enter another new to add to file:");
            Console.Write("-");
            string enteredName = Console.ReadLine();
            while (!string.IsNullOrEmpty(enteredName))
            {
                names.Add(enteredName);
                Console.Write("-");
                enteredName = Console.ReadLine();
            }


            //Save current list to file
            SaveLinesToFile(_filePath, names);

            //read lines in file..
            names = GetLinesFromFile(_filePath).ToList();

            //Output list to console
            PrintList("Names currently in file:", names);


        }
        void PrintList(string title, IEnumerable<string> list)
        {

            Console.WriteLine(title);
            Console.WriteLine("------------------------------");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine();
        }
        static IEnumerable<string> GetLinesFromFile(string filepath)
        {
            Console.WriteLine($"Reading lines from {filepath}");
            return File.ReadAllLines(filepath);
        }
        static void SaveLinesToFile(string filepath, IEnumerable<string> lines)
        {
            Console.WriteLine($"Writing current list to {filepath}");
            File.WriteAllLines(filepath, lines);
        }
    }
}
