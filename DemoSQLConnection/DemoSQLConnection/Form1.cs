using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSQLConnection
{
    public partial class Form1 : Form
    {
        private SqlConnection conn;
        private DataTable data = new DataTable();

        public Form1()
        {
            //conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ManualConnection"].ConnectionString);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //if(conn.State == ConnectionState.Closed)
            //{
            //    conn.Open();
            //}
            //string query = $"SELECT * FROM Shippers";
            //SqlDataAdapter da = new SqlDataAdapter(query, conn);
            //da.SelectCommand.CommandTimeout = 1000;
            //da.Fill(data);
            //conn.Close();
            string cus_id = "BERGS";
            using (conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ManualConnection"].ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("CustOrderHist", conn))
                {

                    command.Parameters.AddWithValue("@CustomerID", cus_id);
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        da.SelectCommand.CommandTimeout = 1000;
                        da.Fill(data);
                    }
                }
                
                
            }

            dataGridView1.DataSource = data;
        }
    }
}
