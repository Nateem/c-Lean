using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myClass
{
    class MyClass2
    {
        private DateTime date;
        public MyClass2(DateTime _date)
        {
            this.date = _date;
        } 
        public string GetDateNow()
        {
            
            var _Moddate = date;
            return ($"Now is {_Moddate.Day.ToString("d2")} Month : {_Moddate.Month.ToString("m2")} Year : {_Moddate.Year.ToString("yyyy")}");
        }
    }
}
