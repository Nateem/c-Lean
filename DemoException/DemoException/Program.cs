using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoException
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tuple
            #region
            //var a = Utility.GetTestText("NateeM");

            //var result = Utility.TestTurple();

            //Console.WriteLine(result.Item1);
            //Console.WriteLine(result.Item2);
            //Console.WriteLine(result.Item3);
            #endregion

            FolderUtility f = new FolderUtility(DateTime.Now);
            f.CheckDirectory();
            f.CreateLogFile();
            try
            {
                f.WriteLogFile();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            //Console.WriteLine(a);
            Console.ReadKey();
        }

    }
}
