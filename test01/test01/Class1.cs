using System;
using System.Collections.Generic;
using System.Text;

namespace test01
{
    class Class1
    {
        int  loop;
        int m;
        public Class1(string max)
        {
            //Console.WriteLine(max);
            int.TryParse(max , out m);
            //Console.WriteLine(m);
            this.loop = m;
            Init(m);
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
