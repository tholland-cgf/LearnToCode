using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnToCode.ConsoleUI.Exercises
{
    public class StringExercises
        : IExercise
    {
        private readonly string _value;

        public StringExercises(string value)
        {
            _value = value;
        }
        
        
        public void Execute()
        {
            Console.WriteLine($"The string value we are looking at is '{_value}'");
            Console.WriteLine($"This string is '{_value.Length} characters long'");

            foreach (var character in _value)
            {
                Console.WriteLine($"'{character}'");
            }


            GetIndividualLetterCounts();

            Console.WriteLine();
            Console.WriteLine();
        }

        void GetIndividualLetterCounts()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;
            int f = 0;
            int g = 0;
            int h = 0;
            int i = 0;
            int j = 0;
            int k = 0;
            int l = 0;
            int m = 0;
            int n = 0;
            int o = 0;
            int p = 0;
            int q = 0;
            int r = 0;
            int s = 0;
            int t = 0;
            int u = 0;
            int v = 0;
            int w = 0;
            int x = 0;
            int y = 0;
            int z = 0;


            foreach (var character in _value)
            {
                if (character == 'a') a++;
                if (character == 'b') b++;
                if (character == 'c') c++;
                if (character == 'd') d++;
                if (character == 'e') e++;
                if (character == 'f') f++;
                if (character == 'g') g++;
                if (character == 'h') h++;
                if (character == 'i') i++;
                if (character == 'j') j++;
                if (character == 'k') k++;
                if (character == 'l') l++;
                if (character == 'm') m++;
                if (character == 'n') n++;
                if (character == 'o') o++;
                if (character == 'p') p++;
                if (character == 'q') q++;
                if (character == 'r') r++;
                if (character == 's') s++;
                if (character == 't') t++;
                if (character == 'u') u++;
                if (character == 'v') v++;
                if (character == 'w') w++;
                if (character == 'x') x++;
                if (character == 'y') y++;
                if (character == 'z') z++;
            }

            Console.WriteLine($"The letter 'a' appears {a} times");
            Console.WriteLine($"The letter 'b' appears {b} times");
            Console.WriteLine($"The letter 'c' appears {c} times");
            Console.WriteLine($"The letter 'd' appears {d} times");
            Console.WriteLine($"The letter 'e' appears {e} times");
            Console.WriteLine($"The letter 'f' appears {f} times");
            Console.WriteLine($"The letter 'g' appears {g} times");
            Console.WriteLine($"The letter 'h' appears {h} times");
            Console.WriteLine($"The letter 'i' appears {i} times");
            Console.WriteLine($"The letter 'j' appears {j} times");
            Console.WriteLine($"The letter 'k' appears {k} times");
            Console.WriteLine($"The letter 'l' appears {l} times");
            Console.WriteLine($"The letter 'm' appears {m} times");
            Console.WriteLine($"The letter 'n' appears {n} times");
            Console.WriteLine($"The letter 'o' appears {o} times");
            Console.WriteLine($"The letter 'p' appears {p} times");
            Console.WriteLine($"The letter 'q' appears {q} times");
            Console.WriteLine($"The letter 'r' appears {r} times");
            Console.WriteLine($"The letter 's' appears {s} times");
            Console.WriteLine($"The letter 't' appears {t} times");
            Console.WriteLine($"The letter 'u' appears {u} times");
            Console.WriteLine($"The letter 'v' appears {v} times");
            Console.WriteLine($"The letter 'w' appears {w} times");
            Console.WriteLine($"The letter 'x' appears {x} times");
            Console.WriteLine($"The letter 'y' appears {y} times");
            Console.WriteLine($"The letter 'z' appears {z} times");

        }


    }
}
