namespace Constructors
{
    internal class Constructor1
    {
        int i; bool b;
        static void Main(string[] args)
        {
            Constructor1 con = new Constructor1();
            Console.WriteLine(con.i); //gives 0
            Console.WriteLine(con.b); //gives false 
            //Values given by implicit constructor
            Console.ReadLine();

        }
    }
}
