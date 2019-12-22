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
    public partial class SellReport : Form
    {
        ProductRepo _productRepo;
        public SellReport()
        {
            _productRepo = new ProductRepo();
            InitializeComponent();
        }

        private void SellReport_Load(object sender, EventArgs e)
        {
            SellTableFetch();
        }
        private void SellTableFetch()
        {
            DataTable billsData = _productRepo.GetAllBills();
            sellReportGridView.DataSource = billsData;

        }
    }
}
