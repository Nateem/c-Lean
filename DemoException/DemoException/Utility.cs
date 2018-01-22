using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoException
{
    class Utility
    {
        public static string GetTestText(string text)
        {
            return ($"Hello Mr. {text}");
        }
        public static Tuple<string,int,DateTime> TestTurple()
        {
            string a = "hello";
            int b = 20;
            DateTime c = new DateTime(1991, 5, 4);
            return Tuple.Create(a, b, c);
        }
    }
}
