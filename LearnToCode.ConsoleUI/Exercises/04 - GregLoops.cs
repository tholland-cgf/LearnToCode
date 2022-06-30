using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnToCode.ConsoleUI.Exercises
{
    public class GregLoops
        : IExercise
    {
        string[] fnames = { "Bob", "Jeff", "Isaac", "Ishmal", "Yoko" };

        public void Execute()
        {
            GregForEachLoop();
            GregForLoop();
            GregForReverse();
            GregWhileLoop();
            GregWhileReverse();
        }
          
        private void GregForEachLoop()
        {
            Console.WriteLine("Using a foreach loop to enumerate the array of names");
            Console.WriteLine("----------------------------------------------------");
            foreach (var item in fnames)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        private void GregForLoop()
        {
            Console.WriteLine("Using a for loop to enumerate the array of names");
            Console.WriteLine("------------------------------------------------");
            for (int i = 0; i < fnames.Length; i+=3)
            {
                var item = fnames[i];
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        
        private void GregForReverse()
        {
            Console.WriteLine("using a for loop to enumerate the array of names but in reverse");
            Console.WriteLine("---------------------------------------------------------------");
         
            for (int i = fnames.Length-1; i > -1 ; i--)
            {
               var item = fnames[i]; 
               Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();


        }

        private void GregWhileLoop()
        {
            Console.WriteLine("Using a while loop to enumerate the array of names");
            Console.WriteLine("--------------------------------------------------");

            int i = 0;
            while (i< fnames.Length)
            {
                Console.WriteLine(fnames[i]);
                i++;
            }
            Console.WriteLine();
            Console.WriteLine();

        }

       private void GregWhileReverse()
        {
            Console.WriteLine("Using a while loop to enumerate the array of neames but in reverse");
            Console.WriteLine("------------------------------------------------------------------");
            int i = fnames.Length - 1;
            while (i > -1)
            {
                Console.WriteLine(fnames[i]);
                i--;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Fin");
        }
    }
}
