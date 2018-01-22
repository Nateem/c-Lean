using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static myClass.MyClass1;

namespace myClass
{
    class Program
    {
        static void Main(string[] args)
        {

            MyClass1 m1 = new MyClass1();
            MyClass2 m2 = new MyClass2(DateTime.Now);
            List<Member> allresult = m1.GetAllMemberInfo();
            Member objectMember = allresult
                .Where(m => m.Name.Trim().ToLower().Contains("tt")).FirstOrDefault();
        }
        
       
    }
    
}
