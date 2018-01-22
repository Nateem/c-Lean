using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsEFDBfirst.DataAccess;

namespace WindowsFormsEFDBfirst
{
    public partial class Form1 : Form
    {
        private NorthwindDBContext db;
        private List<Products> product;
        private List<Categories> categories;
        public Form1()
        {
            db = new NorthwindDBContext();

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GridRefresh();
            BindCategory();
        }

        private void BindCategory()
        {
            categories = db.Categories.ToList();
            cbCategoryID.Items.Add(new Categories { CategoryID = 0, CategoryName = "<-- เลิอกสินค้า -->" });
            foreach(Categories cat in categories)
            {
                cbCategoryID.Items.Add(new Categories { CategoryID = cat.CategoryID, CategoryName = cat.CategoryName });
            }
            cbCategoryID.DisplayMember = "CategoryName";
            cbCategoryID.ValueMember = "CategoryID";
            cbCategoryID.SelectedIndex = 0;
        }

        private void GridRefresh()
        {
            product = db.Products.ToList();
            dataGridView1.DataSource = product;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("กำ....... กดผิด","ERROR !",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow row = this.dataGridView1.SelectedRows[0];

            int index = (int)row.Cells["ProductID"].Value;

            Products pro = product.Where(p => p.ProductID == index).FirstOrDefault();

            BindObjectToform(pro);
        }

        private void BindObjectToform(Products pro)
        {
            tbProductID.Text = (pro.ProductID).ToString();
            tbProductName.Text = pro.ProductName;
            cbCategoryID.Text = pro.Categories.CategoryName;
            tbQuantityPerUnit.Text = pro.QuantityPerUnit;
            tbUnitPrice.Text = (pro.UnitPrice).ToString();
            tbUnitsInStock.Text = (pro.UnitsInStock).ToString();
            tbUnitsOnOrder.Text = (pro.UnitsOnOrder).ToString();
            tbReorderLevel.Text = (pro.ReorderLevel).ToString();
            if (pro.Discontinued)
            {
                rb1.Checked = true;
            }
            else
            {
                rb2.Checked = true;
            }
        }
    }
}
