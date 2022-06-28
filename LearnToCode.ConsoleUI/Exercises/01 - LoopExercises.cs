using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnToCode.ConsoleUI.Exercises
{
    public class LoopExercises
        : IExercise
    {
        string[] names = { "Terry", "Rob", "Greg", "Trevor", "Andy" };

        public void Execute()
        {
            ArrayForEachLoop();
            ArrayForLoop();
            WhileLoop();
        }

        private void ArrayForEachLoop()
        {
            Console.WriteLine("Using a foreach loop to enumerate the array of names");
            Console.WriteLine("----------------------------------------------------");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();


        }

        private void ArrayReverseForLoop()
        {
            Console.WriteLine("Using a for loop to enumerate the array of names in reverse");
            Console.WriteLine("-----------------------------------------------------------");
            for (int i = 0; i < names.Length; i += 2)
            {
                var item = names[i];
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();


        }

        private void ArrayForLoop()
        {
            Console.WriteLine("Using a for loop to enumerate the array of names");
            Console.WriteLine("------------------------------------------------");
            for (int i = 0; i < names.Length; i+=2)
            {
                var item = names[i];
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();


        }

        
        private void WhileLoop()
        {
            Console.WriteLine("Using a while loop to enumerate the array of names");
            Console.WriteLine("--------------------------------------------------");

            int i = 0;
            while (i< names.Length)
            {
                Console.WriteLine(names[i]);
                i+=2;
            }

            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
