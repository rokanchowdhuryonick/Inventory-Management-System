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
    public partial class Dashboard : Form
    {
        public DataTable LoginAdminData;
        private ProductRepo _productRepo;
        private CustomerRepo _customerRepo;

       // public Dashboard()
       // {
           // InitializeComponent();
            
       // }

        public Dashboard(DataTable _adminData)
        {
            LoginAdminData = _adminData;
            InitializeComponent();
            _productRepo = new ProductRepo();
            _customerRepo = new CustomerRepo();
            CustomerListFetch();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMsg();
            GenerateBillNo();
        }

        private void LoadMsg()
        {
            labelAdminName.Text = "Welcome, " + LoginAdminData.Rows[0].Field<string>(1).Trim();
        }

        private void CustomerListFetch()
        {
            DataTable customerData = _customerRepo.GetAllCustomer();
            customerNameBox.DataSource = customerData;
            customerNameBox.ValueMember = customerData.Columns[0].ColumnName;
            customerNameBox.DisplayMember = customerData.Columns[1].ColumnName;
        }

        private void RokanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordChange passwordChange = new PasswordChange(LoginAdminData);
            passwordChange.Show();
        }

        private void AddProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products productObj = new Products();
            productObj.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customers customerObj = new Customers();
            customerObj.Show();
        }

        private void CategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category categoryObj = new Category();
            categoryObj.Show();

        }

        private void CustomerNameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string customerId = customerNameBox.SelectedValue.ToString();
            DataTable customerData = _customerRepo.GetCustomerByID(customerId);
            if (customerData.Rows.Count > 0)
            {
                phoneNumberBox.Text = customerData.Rows[0].Field<string>(2);

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string phone = phoneNumberBox.Text.Trim();
            DataTable customerDataByPhone = _customerRepo.GetCustomerByPhone(phone);
            if (customerDataByPhone.Rows.Count>0)
            {
                customerNameBox.Text = customerDataByPhone.Rows[0].Field<string>(1);

            }
            else
            {
                MessageBox.Show("Not found!");
            }
        }

        private void GenerateBillNo()
        {
            string billNo = "1001";
            DataTable dt = _productRepo.GetAllBills();
            int totalData = dt.Rows.Count;
            bool dataHas = totalData > 0 ? true : false;
            if (dataHas)
            {
                var newBill = Int32.Parse(dt.Rows[totalData - 1].Field<string>(1)) + 1;
                billNo = newBill.ToString();
            }

            billNoBox.Text = billNo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string barcode = barcodeBox.Text.Trim();
            DataTable productDataByBarcode = _productRepo.GetProductByBarcode(barcode);
            if (productDataByBarcode.Rows.Count > 0)
            {
                //customerNameBox.Text = productDataByBarcode.Rows[0].Field<string>(1);
               // sellGridView.
                int tot;
                int qty;

                if (sellGridView.RowCount == 1)
                {


                    qty = 1;
                    tot = int.Parse(productDataByBarcode.Rows[0].Field<string>(3)) * 1;
                    string[] row = new string[] { productDataByBarcode.Rows[0].Field<int>(0).ToString(),
                    productDataByBarcode.Rows[0].Field<string>(2),
                    productDataByBarcode.Rows[0].Field<string>(1),
                    productDataByBarcode.Rows[0].Field<string>(4),
                 qty.ToString(),
                tot.ToString()};

                    sellGridView.Rows.Add(row);


                }
                else
                {
                   // MessageBox.Show("Problem occur in cart");
                   
                    foreach (DataGridViewRow r in sellGridView.Rows)
                    {
                        var cell1 = sellGridView.CurrentRow.Cells[0].Value;
                        var cell2 = r.Cells[0].Value;
                        if ((cell1!=null)&&(cell2!=null))
                        {
                            if (cell1.ToString() == cell2.ToString())
                            {
                                MessageBox.Show("Item is already in the cart");
                                // return;
                            }
                            else
                            {
                                if (sellGridView.CurrentRow.Cells[0].Value.ToString() != productDataByBarcode.Rows[0].Field<int>(0).ToString())
                                {
                                    qty = 1;
                                    tot = int.Parse(productDataByBarcode.Rows[0].Field<string>(3)) * 1;
                                    string[] row = new string[] { productDataByBarcode.Rows[0].Field<int>(0).ToString(),
                    productDataByBarcode.Rows[0].Field<string>(2),
                    productDataByBarcode.Rows[0].Field<string>(1),
                    productDataByBarcode.Rows[0].Field<string>(4),
                 qty.ToString(),
                tot.ToString()};
                                    sellGridView.Rows.Add(row);
                                }
                                else
                                {
                                    MessageBox.Show("Item is already in the cart........");
                                    //  return;
                                }
                            }
                        }
                        
                    }
/*
                    if (sellGridView.CurrentRow.Cells[0].Value==null)
                    {
                        // sellGridView.RowsAdded.Selected = True;
                        //  sellGridView.SelectedRows. //clear selection
                      //  sellGridView.Rows[sellGridView.CurrentRow.Index+1].Selected = true;

                        
                    }
                    
                    */

                }

            }
            else
            {
                MessageBox.Show("Not found!");
            }
        }

        private void sellGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int total;
            if (sellGridView.CurrentCell.ColumnIndex == 4)
            {
                foreach (DataGridViewRow row in sellGridView.Rows)
                {
                    var cell1 = row.Cells[4].Value;
                    var cell2 = row.Cells[3].Value;
                    if ((cell1 != null) && (cell2 != null))
                    {
                        string barcode = row.Cells[2].Value.ToString();
                        DataTable ProductByBarcode = _productRepo.GetProductByBarcode(barcode);
                        int stock = int.Parse(ProductByBarcode.Rows[0].Field<string>(5));
                        if ((stock - int.Parse(cell1.ToString()))<0)
                        {
                            MessageBox.Show("Product quantity is out of stock!");
                        }
                        else
                        {
                            total = int.Parse(cell1.ToString()) * int.Parse(cell2.ToString());
                            row.Cells[5].Value = total;
                        }
                        
                    }
                }
            }
        }

        private void netTotal()
        {
            int total=0;
            foreach (DataGridViewRow row in sellGridView.Rows)
            {
                var cell1 = row.Cells[5].Value;
                if (cell1 != null)
                {
                    total = total + int.Parse(cell1.ToString());
                    
                }
            }
            netTotalBox.Text = total.ToString();
        }

        private void sellGridView_SelectionChanged(object sender, EventArgs e)
        {
            netTotal();
        }

        private bool IsEmpty(string value)
        {
            if (string.IsNullOrEmpty(value) || value.Length == 0)
            {
                return true;
            }
            return false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string total = netTotalBox.Text.Trim();

                if (total.Length == 0 || !IsEmpty(total))
            {
                string billNo = billNoBox.Text;
                string customerId = customerNameBox.SelectedValue.ToString();
                string customerPhone = phoneNumberBox.Text.Trim();
                string barcode = barcodeBox.Text.Trim();

                if (IsEmpty(billNo) || IsEmpty(customerId) || IsEmpty(customerPhone))
                {
                    MessageBox.Show("Required field is empty..!");

                }
                else
                {
                    if (StockOutCheck())
                    {
                        MessageBox.Show("One or some product is out of stock!");
                    }
                    else
                    {
                        var inserted = _productRepo.SellProduct(billNo, total, customerId, barcode);
                        if (inserted > 0)
                        {
                            Clear();
                            MessageBox.Show("Data Successfully Added...!!");
                            UpdateStock();
                        }
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Clear the filed first..!! \nBecause you are trying to add a product which already exists...!!");
            }
        }


        private bool StockOutCheck()
        {
            foreach (DataGridViewRow row in sellGridView.Rows)
            {
                var cell1 = row.Cells[4].Value;
                var cell2 = row.Cells[3].Value;
                if ((cell1 != null) && (cell2 != null))
                {
                    string barcode = row.Cells[2].Value.ToString();
                    DataTable ProductByBarcode = _productRepo.GetProductByBarcode(barcode);
                    int stock = int.Parse(ProductByBarcode.Rows[0].Field<string>(5));
                    if ((stock - int.Parse(cell1.ToString())) < 0)
                    {
                        return true;
                    }

                }
            }
            return false;
        }

        private bool UpdateStock()
        {
            foreach (DataGridViewRow row in sellGridView.Rows)
            {
                var cell1 = row.Cells[4].Value;
                var barcode = row.Cells[2].Value;
                if ((cell1 != null)  && (barcode!=null))
                {
                    DataTable forStock = _productRepo.GetProductByBarcode(barcode.ToString());
                    var StockValue = forStock.Rows[0].Field<string>(5);
                    var stock = (int.Parse(StockValue.ToString()) - int.Parse(cell1.ToString())).ToString();
                    MessageBox.Show(stock);
                    var updated = _productRepo.UpdateStock(barcode.ToString(), stock);
                    if (updated > 0)
                    {
                        sellGridView.Rows.Clear();
                        sellGridView.Refresh();
                        Clear();
                        return true;
                    }

                }
            }
            return false;
        }
        private void Clear()
        {
            barcodeBox.Clear();
            netTotalBox.Clear();
            GenerateBillNo();
        }

        private void sellReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellReport sellReport = new SellReport();
            sellReport.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
            this.Dispose();
        }
    }
}


