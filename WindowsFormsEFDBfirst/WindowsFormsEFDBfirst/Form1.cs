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
        private bool IsCreate;
        public Form1()
        {
            db = new NorthwindDBContext();

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IsCreate = true;
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
            IsCreate = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            tbProductID.Text = string.Empty;
            tbProductName.Text = string.Empty;
            cbCategoryID.SelectedIndex = cbCategoryID.FindString("");
            tbQuantityPerUnit.Text = string.Empty;
            tbUnitPrice.Text = string.Empty;
            tbUnitsInStock.Text = string.Empty;
            tbUnitsOnOrder.Text = string.Empty;
            tbReorderLevel.Text = string.Empty;

            IsCreate = true;
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsCreate)
            {
                Categories select = (Categories)cbCategoryID.SelectedItem;
                bool discount;
                if (rb1.Checked)
                {
                    discount = true;
                }
                else
                {
                    discount = false;
                }
                Products p = new Products();

                p.ProductName = tbProductName.Text;
                p.CategoryID = select.CategoryID;
                p.QuantityPerUnit = tbQuantityPerUnit.Text;
                p.UnitPrice = Convert.ToDecimal(tbUnitPrice.Text);
                p.UnitsInStock = Convert.ToInt16(tbUnitsInStock.Text);
                p.UnitsOnOrder = Convert.ToInt16(tbUnitsOnOrder.Text);
                p.ReorderLevel = Convert.ToInt16(tbReorderLevel.Text);
                p.Discontinued = discount;

                try
                {
                    if (CreateProcess(p))
                    {
                        clearForm();
                        GridRefresh();
                        MessageBox.Show("บันทึกสำเร็จ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                int productId = Convert.ToInt16(tbProductID.Text);
                try
                {
                    if (UpdateProcess(productId))
                    {
                        clearForm();
                        GridRefresh();
                        MessageBox.Show("แก้ไขสำเร็จ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool UpdateProcess(int productId)
        {
            bool result = false;
            Categories select = (Categories)cbCategoryID.SelectedItem;
            bool discount;
            if (rb1.Checked)
            {
                discount = true;
            }
            else
            {
                discount = false;
            }
            Products p = product.Where(_p => _p.ProductID == productId).First();
            p.ProductName = tbProductName.Text;
            p.CategoryID = select.CategoryID;
            p.QuantityPerUnit = tbQuantityPerUnit.Text;
            p.UnitPrice = Convert.ToDecimal(tbUnitPrice.Text);
            p.UnitsInStock = Convert.ToInt16(tbUnitsInStock.Text);
            p.UnitsOnOrder = Convert.ToInt16(tbUnitsOnOrder.Text);
            p.ReorderLevel = Convert.ToInt16(tbReorderLevel.Text);
            p.Discontinued = discount;
            
            try
            {
                db.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;

        }

        private bool CreateProcess(Products p)
        {
            bool result = false;
            try
            {
                db.Products.Add(p);
                db.SaveChanges();
                result = true;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tbProductID.Text == string.Empty)
            {
                MessageBox.Show("ไม่พบข้อมูลที่ต้องการลบ", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int productId = Convert.ToInt16(tbProductID.Text);
            try
            {
                if (DeleteProcess(productId))
                {
                    clearForm();
                    GridRefresh();
                    MessageBox.Show("ลบสำเร็จ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool DeleteProcess(int productId)
        {
            bool result = false;
            try
            {
                Products d = product.Where(p => p.ProductID == productId).First();
                db.Products.Remove(d);
                db.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
    }
}
