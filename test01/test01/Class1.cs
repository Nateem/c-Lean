using System;
using System.Collections.Generic;
using System.Text;

namespace test01
{
    class Class1
    {
        public Class1(int max)
        {
            //Console.WriteLine(max);
            
            //Console.WriteLine(m);
        
            Init(max);
        }
        public void Init(int max) {
            int i = 0;
            int x = 0;
            do
            {

                if (i == max)
                {

                    Console.WriteLine($" {i - x} \n");
                    i = x;
                    x++;
                }
                else
                {
                    Console.Write($" {i - x}");
                }
                i++;
            }
            while ( i <= max);
            
        }
    }
}
