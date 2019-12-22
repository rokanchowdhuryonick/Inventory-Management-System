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
    public partial class Products : Form
    {
        private ProductRepo _productRepo;
        public Products()
        {
            InitializeComponent();
            _productRepo = new ProductRepo();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            CategoryTableFetch();
            ProductTableFetch();
            GenerateBarcode();

        }

        private void CategoryTableFetch()
        {
            DataTable catData = _productRepo.GetAllCategory();
            productCategoryBox.DataSource = catData;
            //  this.categoryTableAdapter.Fill(catData);
            productCategoryBox.ValueMember = catData.Columns[1].ColumnName;
            productCategoryBox.DisplayMember = catData.Columns[1].ColumnName;
        }
        private void ProductTableFetch()
        {
            DataTable productData = _productRepo.GetAllProducts();
            productDataGridView.DataSource = productData;

        }

        private void ProductSavebtn_Click(object sender, EventArgs e)
        {
            if (productIdBox.Text.Trim().Length==0 || IsEmpty(productIdBox.Text))
            {
                string barcode = productBarcodeBox.Text.Trim();
                string productName = productNameBox.Text.Trim();
                string productCategory = productCategoryBox.Text.Trim();
                string purchasePrice = productPurchasePriceBox.Text;
                string sellPrice = productSellPriceBox.Text.Trim();
                string stock = productStockAmountBox.Text.Trim();
                string status = productStatusBox.Text.Trim();

                if (IsEmpty(barcode) || IsEmpty(productName) || IsEmpty(purchasePrice) || IsEmpty(sellPrice) || IsEmpty(stock) || IsEmpty(status))
                {
                    MessageBox.Show("Required field is empty..!");

                }
                else
                {
                    var inserted = _productRepo.InsertProduct(barcode, productName, productCategory, purchasePrice, sellPrice, stock, status);
                    if (inserted > 0)
                    {
                        Clear();
                        MessageBox.Show("Data Successfully Added...!!");
                        ProductTableFetch();
                    }
                }
            }
            else
            {
                MessageBox.Show("Clear the filed first..!! \nBecause you are trying to add a product which already exists...!!");
            }
            
        }

        private void GenerateBarcode()
        {
            string barCode = "110001";
            DataTable dt = _productRepo.GetAllProducts();
            int totalData = dt.Rows.Count;
            bool dataHas =  totalData > 0 ? true : false;
            if (dataHas)
            {
                var newBarcode = Int32.Parse(dt.Rows[totalData-1].Field<string>(1)) + 1;
                barCode = newBarcode.ToString();
            }

            productBarcodeBox.Text = barCode;

        }

        private bool IsEmpty(string value)
        {
            if (string.IsNullOrEmpty(value) || value.Length==0)
            {
                return true;
            }
            return false;
        }

        private void Clear()
        {
            productBarcodeBox.Clear();
            productNameBox.Clear();
            productPurchasePriceBox.Clear();
            productSellPriceBox.Clear();
            productStockAmountBox.Clear();
            productIdBox.Clear();
            GenerateBarcode();
        }

        private void ProductDataGridView_Click(object sender, EventArgs e)
        {
            string productId = productDataGridView.CurrentRow.Cells[0].Value.ToString();
            DataTable productByID = _productRepo.GetProductByID(productId);
            if (productByID.Rows.Count > 0)
            {
                productIdBox.Text = productByID.Rows[0].Field<int>(0).ToString();
                productBarcodeBox.Text = productByID.Rows[0].Field<string>(1);
                productNameBox.Text = productByID.Rows[0].Field<string>(2);
                productPurchasePriceBox.Text = productByID.Rows[0].Field<string>(3);
                productSellPriceBox.Text = productByID.Rows[0].Field<string>(4);
                productStockAmountBox.Text = productByID.Rows[0].Field<string>(5);
                string category = productByID.Rows[0].Field<string>(6);
                productCategoryBox.Text = category;
                productStatusBox.Text = productByID.Rows[0].Field<string>(7);

            }
        }

        private void ProductBoxClearbtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void ProductUpdatebtn_Click(object sender, EventArgs e)
        {
            string productId = productIdBox.Text;
            if (IsEmpty(productId))
            {
                MessageBox.Show("Select any row to edit..!!");
            }
            else
            {
                string productName = productNameBox.Text.Trim();
                string productCategory = productCategoryBox.Text.Trim();
                string purchasePrice = productPurchasePriceBox.Text;
                string sellPrice = productSellPriceBox.Text.Trim();
                string stock = productStockAmountBox.Text.Trim();
                string status = productStatusBox.Text.Trim();

                if ( IsEmpty(productName) || IsEmpty(purchasePrice) || IsEmpty(sellPrice) || IsEmpty(stock) || IsEmpty(status))
                {
                    MessageBox.Show("Required field is empty..!");

                }
                else
                {
                    var updated = _productRepo.UpdateProduct(productId, productName, productCategory, purchasePrice, sellPrice, stock, status);
                    if (updated > 0)
                    {
                        Clear();
                        MessageBox.Show("Data Successfully updated...!!");
                        ProductTableFetch();
                    }
                }

            }
        }

        private void ProductDeletebtn_Click(object sender, EventArgs e)
        {
            if (IsEmpty(productIdBox.Text.Trim()))
            {
                MessageBox.Show("Hey bro, Select any product first!");
            }
            else
            {
                string productId = productIdBox.Text.Trim();

                var deleted = _productRepo.DeleteProduct(productId);
                if (deleted > 0)
                {
                    Clear();
                    MessageBox.Show("Product successfully deleted...!!");
                    ProductTableFetch();
                }

            }
        }
    }
}
