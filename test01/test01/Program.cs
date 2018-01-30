using System;

namespace test01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Number : ");
            string a = Console.ReadLine();
            Class1 c1 = new Class1(a);
            Console.ReadKey();
        }
    }
}
