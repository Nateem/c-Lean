using System;

namespace test01
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int m;
            bool isNumber;
            
            do
            {
                Console.Write("Input Type Number Only: ");
                string a = Console.ReadLine();
                isNumber = int.TryParse(a, out m);

            }
            while (!isNumber);

            Class1 c1 = new Class1(m);
            Console.ReadKey();
        }
    }
}
