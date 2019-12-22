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
    public partial class Customers : Form
    {
        private CustomerRepo _customerRepo;
        public Customers()
        {
            InitializeComponent();
            _customerRepo = new CustomerRepo();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string customerName = customerNameBox.Text.Trim();
            string customerPhone = customerPhoneBox.Text.Trim();
            string customerAddress = customerAddressBox.Text.Trim();
            if (IsEmpty(customerName) || IsEmpty(customerPhone) || IsEmpty(customerAddress))
            {
                MessageBox.Show("Required field is empty..!");

            }
            else
            {
                var inserted = _customerRepo.InsertCustomer(customerName, customerPhone, customerAddress);
                if (inserted > 0)
                {
                    Clear();
                    MessageBox.Show("Data Successfully Added...!!");
                    CustomerTableFetch();
                }
            }

        }
        private void CustomerTableFetch()
        {
            DataTable customerData = _customerRepo.GetAllCustomer();
            customerDataGridView.DataSource = customerData;

        }

        private bool IsEmpty(string value)
        {
            if (string.IsNullOrEmpty(value) || value.Length == 0)
            {
                return true;
            }
            return false;
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            CustomerTableFetch();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            customerNameBox.Text = "";
            customerPhoneBox.Text = "";
            customerAddressBox.Text = "";
            customerIdBox.Text = "";
        }

        private void CustomerDataGridView_Click(object sender, EventArgs e)
        {
            string customerId = customerDataGridView.CurrentRow.Cells[0].Value.ToString();
            DataTable customerByID = _customerRepo.GetCustomerByID(customerId);
            if (customerByID.Rows.Count>0)
            {
                customerIdBox.Text = customerByID.Rows[0].Field<int>(0).ToString();
                customerNameBox.Text = customerByID.Rows[0].Field<string>(1);
                customerPhoneBox.Text = customerByID.Rows[0].Field<string>(2);
                customerAddressBox.Text = customerByID.Rows[0].Field<string>(3);
                

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (IsEmpty(customerIdBox.Text.Trim()))
            {
                MessageBox.Show("Hey bro, Select customer first!");
            }
            else
            {
                string customerId = customerIdBox.Text.Trim();
                string customerName = customerNameBox.Text.Trim();
                string customerPhone = customerPhoneBox.Text.Trim();
                string customerAddress = customerAddressBox.Text.Trim();
                if (IsEmpty(customerName) || IsEmpty(customerPhone) || IsEmpty(customerAddress))
                {
                    MessageBox.Show("Required field is empty..!");

                }
                else
                {
                    var updated = _customerRepo.UpdateCustomer(customerId, customerName, customerPhone, customerAddress);
                    if (updated > 0)
                    {
                        Clear();
                        MessageBox.Show("Data Updated...!!");
                        CustomerTableFetch();
                    }
                }

            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (IsEmpty(customerIdBox.Text.Trim()))
            {
                MessageBox.Show("Hey bro, Select customer first!");
            }
            else
            {
                string customerId = customerIdBox.Text.Trim();
                
                var deleted = _customerRepo.DeleteCustomer(customerId);
                if (deleted > 0)
                {
                    Clear();
                    MessageBox.Show("Successfully deleted...!!");
                    CustomerTableFetch();
                }

            }

        }

        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
