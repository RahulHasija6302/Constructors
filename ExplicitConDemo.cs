using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class ExplicitConDemo
    {
        //Demonstration for Explicit Constructor
        public ExplicitConDemo() {
            Console.WriteLine("Constructor is called");
        }
        static void Main(string[] args)
        {
            ExplicitConDemo obj = new ExplicitConDemo();

            Console.WriteLine();
        }
    }
}
