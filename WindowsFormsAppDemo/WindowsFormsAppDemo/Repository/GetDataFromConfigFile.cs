using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using WindowsFormsAppDemo.Models;

namespace WindowsFormsAppDemo.Repository
{
    class GetDataFromConfigFile
    {
        public Tuple<List<Changwats>,List<Amphoes>,List<Tambons>> GetData()
        {
            Tuple<List<Changwats>, List<Amphoes>, List<Tambons>> result = null;

            try
            {
                var appDir = AppDomain.CurrentDomain.BaseDirectory;

                var pathChangwats = Path.Combine(appDir, "changwats.json");
                var pathAmphoes = Path.Combine(appDir, "amphoes.json");
                var pathTambons = Path.Combine(appDir, "tambons.json");

                String JSONstringChangwats = File.ReadAllText(pathChangwats);
                String JSONstringAmphoes = File.ReadAllText(pathAmphoes);
                String JSONstringTambons = File.ReadAllText(pathTambons);


                JavaScriptSerializer ser = new JavaScriptSerializer();

                List<Changwats> dataChangwatsList = ser.Deserialize<List<Changwats>>(JSONstringChangwats);
                List<Amphoes> dataAmphoesList = ser.Deserialize<List<Amphoes>>(JSONstringAmphoes);
                List<Tambons> dataTambonsList = ser.Deserialize<List<Tambons>>(JSONstringTambons);

                result = new Tuple<List<Changwats>, List<Amphoes>, List<Tambons>>(dataChangwatsList, dataAmphoesList, dataTambonsList);

            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
             
            return result;
        }
    }
}
