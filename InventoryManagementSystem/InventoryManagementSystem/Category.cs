using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Category : Form
    {
        private ProductRepo _productRepo;
        public Category()
        {
            InitializeComponent();
            _productRepo = new ProductRepo();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            CategoryTableFetch();
            categoryGridView.Columns[0].Width = 30;
            categoryGridView.Columns[1].Width = 190;
        }

        private void CategoryTableFetch()
        {
            DataTable categoryData = _productRepo.GetAllCategory();
            categoryGridView.DataSource = categoryData;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (categoryIdBox.Text.Trim().Length == 0 || IsEmpty(categoryIdBox.Text))
            {
                string categoryName = categoryNameBox.Text.Trim();
                if (IsEmpty(categoryName))
                {
                    MessageBox.Show("Required field is empty..!");

                }
                else
                {
                    var inserted = _productRepo.InsertCategory(categoryName);
                    if (inserted > 0)
                    {
                        Clear();
                        MessageBox.Show("Data Successfully Added...!!");
                        CategoryTableFetch();
                    }
                }
            }
            else
            {
                MessageBox.Show("This Data already exists..!!\n Clear field please..");
            }

            
        }

        private void Clear()
        {
            categoryNameBox.Clear();
            categoryIdBox.Clear();
        }

        private bool IsEmpty(string value)
        {
            if (string.IsNullOrEmpty(value) || value.Length == 0)
            {
                return true;
            }
            return false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (IsEmpty(categoryIdBox.Text.Trim()))
            {
                MessageBox.Show("Hey bro, Select category first!");
            }
            else
            {
                string categoryId = categoryIdBox.Text.Trim();
                string categoryName = categoryNameBox.Text.Trim();
                if (IsEmpty(categoryName))
                {
                    MessageBox.Show("Required field is empty..!");

                }
                else
                {
                    var updated = _productRepo.UpdateCategory(categoryId, categoryName);
                    if (updated > 0)
                    {
                        Clear();
                        MessageBox.Show("Data Updated...!!");
                        CategoryTableFetch();
                    }
                }

            }
        }

        private void CategoryGridView_Click(object sender, EventArgs e)
        {
            string categoryId = categoryGridView.CurrentRow.Cells[0].Value.ToString();
            DataTable categoryByID = _productRepo.GetCategoryByID(categoryId);
            if (categoryByID.Rows.Count > 0)
            {
                categoryIdBox.Text = categoryByID.Rows[0].Field<int>(0).ToString();
                categoryNameBox.Text = categoryByID.Rows[0].Field<string>(1);


            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void categoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
