using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppDemo.Models;
using WindowsFormsAppDemo.Repository;

namespace WindowsFormsAppDemo
{
    public partial class Form1 : Form
    {
        private Tuple<List<Changwats>, List<Amphoes>, List<Tambons>> dataConfig;
        public Form1()
        {
            GetDataFromConfigFile data = new GetDataFromConfigFile();
            this.dataConfig = data.GetData();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Changwats> changwats = dataConfig.Item1.ToList();
            cbRegion.Items.Add(new Changwats { pid = "0", name = "<-- เลือกจังหวัด -->" });
            foreach(Changwats r in changwats)
            {
                cbRegion.Items.Add(new Changwats { pid = r.pid, name = r.name });
            }
            cbRegion.DisplayMember = "name";
            cbRegion.ValueMember = "pid";
            cbRegion.SelectedIndex = 0;
            //List<Amphoes> amphoes = dataConfig.Item2.ToList();
            //List<Tambons> tambons = dataConfig.Item3.ToList();

        }

        private void cbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cbRegion.Text);
        }
    }
}
