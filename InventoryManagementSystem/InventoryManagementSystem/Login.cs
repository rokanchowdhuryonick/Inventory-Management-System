using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Inventory_Management_System
{
    public partial class Login : Form
    {
        private AdminRepo _adminRepo;
        protected DataTable _adminData;
        public Login()
        {
            InitializeComponent();
            _adminRepo = new AdminRepo();
            this.AcceptButton = button1;
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            string userName = this.userName.Text.Trim();
            string userPass = this.userPass.Text.Trim();
            
            

            if (_adminRepo.AdminLoginVerify(userName, userPass))
            {
                _adminData = _adminRepo.GetAdminByID(userName, userPass);
                Dashboard dashboard = new Dashboard(_adminData);
                this.Hide();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Sorry Bro, username or password was incorrect bro...!! \nTry again man..!!");
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
