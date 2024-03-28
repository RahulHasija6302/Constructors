using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class StaticVNonStatic
    {
        static int y;
        public int x;

        //A static constructor must be parameterless
        static StaticVNonStatic()
        {
            Console.WriteLine("This is a static constructor");
        }
        public StaticVNonStatic(int x)
        {
            this.x = x;
            Console.WriteLine("This is a non-static constructor");
        }
        static void Main()
        {
            Console.WriteLine("This is the Main Method");
            StaticVNonStatic svn1 = new StaticVNonStatic(10);
            StaticVNonStatic svn2 = new StaticVNonStatic(20);
            StaticVNonStatic svn3 = new StaticVNonStatic(30);



            //A static member of a class can be directly accessed by the static 
            //block of class
            Console.WriteLine(y);
            Console.WriteLine(svn1.x + " " + svn2.x + " " + svn3.x);
            Console.ReadLine();
        }
    }
}
