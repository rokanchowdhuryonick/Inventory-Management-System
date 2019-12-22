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
    public partial class PasswordChange : Form
    {
        protected DataTable LoginAdminData;
        private DataTable adminPassData;
        AdminRepo _adminRepo = new AdminRepo();
        public PasswordChange()
        {
            InitializeComponent();
        }

        public PasswordChange(DataTable loginAdminData)
        {
            LoginAdminData = loginAdminData;
            InitializeComponent();
            this.AcceptButton = button1;
        }

        private void PasswordChange_Load(object sender, EventArgs e)
        {
            fetchPass(LoginAdminData);

        }

        private void fetchPass(DataTable loginData)
        {
            string adminID = loginData.Rows[0].Field<int>(0).ToString();
            adminIdBox.Text = adminID;
            adminPassData =_adminRepo.GetAdminPassByID(adminID);
            loginStoredPass.Text = adminPassData.Rows[0].Field<string>(0).Trim();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string storedPass = loginStoredPass.Text.Trim();
            string currentPass = currentPasswordBox.Text.Trim();
            if (storedPass==currentPass)
            {
                string newPass = newPasswordBox.Text.Trim();
                string adminId = adminIdBox.Text.Trim();
                
                var updated = _adminRepo.UpdateAdminPass(adminId, newPass);
                if (updated>0)
                {
                    MessageBox.Show("Password Updated");
                    clear();
                }
                else
                {
                    MessageBox.Show("Failed to update!");
                }
            }
            else
            {
                MessageBox.Show("Sorry...!! Current password not matched..!!");
            }
        }

        private void clear()
        {
            currentPasswordBox.Text = "";
            newPasswordBox.Text = "";
            adminPassData = _adminRepo.GetAdminPassByID(adminIdBox.Text.Trim());
            loginStoredPass.Text = adminPassData.Rows[0].Field<string>(0).Trim();
        }

        private void currentPasswordBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
