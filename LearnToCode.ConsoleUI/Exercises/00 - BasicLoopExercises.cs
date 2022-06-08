using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnToCode.ConsoleUI.Exercises
{
    public class BasicLoopExercises
        : IExercise
    {
        public void Execute()
        {
            Console.WriteLine("Enter a number.  I will then square each number from 1 to that number");
            Console.WriteLine("---------------------------------------------------------------------");

            int max = -1;
            if(int.TryParse(Console.ReadLine(), out max))
                SquareLoop(max);
        }

        private void SquareLoop(int max)
        {
            for (int i = 1; i <= max; i++)
            {
                Console.WriteLine($"{i} x {i} = {i * i}");
            }
        }
    }
}
