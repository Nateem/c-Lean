using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace DemoException
{
    class FolderUtility
    {
        private static string path = Properties.Resources.path;

        private  DateTime _indexDate;
        public FolderUtility(DateTime dateIndex)
        {
            this._indexDate = dateIndex;
        }

        public void CheckDirectory()
        {
            string month = _indexDate.Month.ToString("d2");
            if (!Directory.Exists(@path + month))
            {
                Directory.CreateDirectory(@path + month);


            }
        }
        public void CreateLogFile()
        {
            DateTime thisday = DateTime.Now;
            DateTime _modDay = this._indexDate;

            string thismonth = thisday.Month.ToString("d2");
            string thistoday = thisday.Year.ToString() + thisday.Month.ToString("d2") + thisday.Day.ToString("d2");

            string _modmonth = _modDay.Month.ToString("d2");
            string _modtoday = _modDay.Year.ToString() + _modDay.Month.ToString("d2") + _modDay.Day.ToString("d2");
               
            if(!File.Exists(@path + _modmonth + $"\\{_modtoday}.txt"))
            {
                StreamWriter file = new StreamWriter(@path + _modmonth + $"\\{_modtoday}.txt");
            }
        }
        public void WriteLogFile()
        {
            List<string> ErrorList = new List<string>();
            for (var i = 1; i < 10; i++)
            {
                ErrorList.Add("Error" + i);
            }
            DateTime thisday = DateTime.Now;
            DateTime _modDay = this._indexDate;

            string thismonth = thisday.Month.ToString("d2");
            string thistoday = thisday.Year.ToString() + thisday.Month.ToString("d2") + thisday.Day.ToString("d2");

            string _modmonth = _modDay.Month.ToString("d2");
            string _modtoday = _modDay.Year.ToString() + _modDay.Month.ToString("d2") + _modDay.Day.ToString("d2");

            if (File.Exists(@path + _modmonth + $"\\{_modtoday}.txts"))
            {
                foreach(string _text in ErrorList)
                {
                    File.AppendAllText(@path + _modmonth + $"\\{_modtoday}.txt", 
                        _text+$"Time : {DateTime.Now.ToString("HH:mm")}" + "\r\n");
                }
            }
            else
            {
                Exception Error = new Exception("Can not Write File");
                throw Error;
            }
        }
    }
}
