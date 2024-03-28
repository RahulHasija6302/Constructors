using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Constructor3
    {
       public int x = 100;
       
      

      class Second
        {
            //By default an implicit constructor intializes the value with 0
            public int x;//gives 0
            public Second(int x)
            {
                this.x = x;
            }
        }
       static void Main()
        {
            Constructor3 ct1 = new Constructor3();
            Constructor3 ct2 = new Constructor3();
            Constructor3 ct3 = new Constructor3();

            Console.WriteLine(ct1.x + " "+ ct2.x + " " + ct3.x);

            Second s1 = new Second(100);
            Second s2 = new Second(200);
            Second s3 = new Second(300);

            Console.WriteLine(s1.x + " " + s2.x + " " + s3.x);



        }
    }

}
