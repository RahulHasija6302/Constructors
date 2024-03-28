using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class StaticConDemo
    {
        //Demonstration of static constructor
        static StaticConDemo() {
            Console.WriteLine("Static Constructor is being executed");
        }
        public static void Main()
        {
            //Static Constructor are always the first to execute in a class
            Console.WriteLine("Main Method is being executed");
        }
    }
}
