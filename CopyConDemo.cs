using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class CopyConDemo
    {
        int x;

        //Parameterized Constructor
        public CopyConDemo(int i) { 
            x = i;
        }
        //Here Copy Constructor is used the whole class is being passed
        //as class is a user defined datatype
        //Copy Constructor 
        public CopyConDemo(CopyConDemo obj)
        {
            x = obj.x;
        }
        public void Display()
        {
            Console.WriteLine("The value of x: " +x);
        }

        static void Main(string[] args)
        {
            CopyConDemo cd1 = new CopyConDemo(10);
            //passing another objects instance to copy constructor
            CopyConDemo cd2  = new CopyConDemo(cd1);//gives 10
            cd1.Display();
            cd2.Display();

            Console.ReadLine();
        }
    }
}
