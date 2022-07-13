using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnToCode.ConsoleUI.StringStuff
{

    public class SomeThingBase
    {
        public void Blah(string foo)
        {
            Console.WriteLine(foo);
        }

    }
    public class SomeThing
        : SomeThingBase
    {
        new public void  Blah(string foo)
        {
            Console.WriteLine(foo);
        }

        public void Blah(int bar)
        {
            Console.WriteLine(bar);
        }

        public void Blah(string foo,int bar)
        {
            Console.WriteLine(foo);
        }

        public void Blah( int bar, string foo)
        {
            Console.WriteLine(foo);
        }

    }
}
