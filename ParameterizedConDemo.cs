using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class ParameterizedConDemo
    {

        int x;
        //Demonstration for parameterized constructor
        public ParameterizedConDemo(int i) { 
            Console.WriteLine("Parameterized Constructor is called " + i);
        }

        public void display()
        {
            Console.WriteLine("Value of x: " + x);
        }

        static void Main(string[] args)
        {
            ParameterizedConDemo pc1 = new ParameterizedConDemo(10);
            ParameterizedConDemo pc2 = new ParameterizedConDemo(20);

            pc1.display(); //gives 0 because implicit constructor has defined its value
            pc2.display();
            Console.WriteLine();
        }
    }
}
