namespace Inventory_Management_System
{
    partial class PasswordChange
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.currentPasswordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newPasswordBox = new System.Windows.Forms.TextBox();
            this.loginStoredPass = new System.Windows.Forms.TextBox();
            this.adminIdBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Change Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // currentPasswordBox
            // 
            this.currentPasswordBox.Location = new System.Drawing.Point(203, 10);
            this.currentPasswordBox.Name = "currentPasswordBox";
            this.currentPasswordBox.Size = new System.Drawing.Size(186, 20);
            this.currentPasswordBox.TabIndex = 1;
            this.currentPasswordBox.TextChanged += new System.EventHandler(this.currentPasswordBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "New Password";
            // 
            // newPasswordBox
            // 
            this.newPasswordBox.Location = new System.Drawing.Point(203, 45);
            this.newPasswordBox.Name = "newPasswordBox";
            this.newPasswordBox.Size = new System.Drawing.Size(186, 20);
            this.newPasswordBox.TabIndex = 3;
            // 
            // loginStoredPass
            // 
            this.loginStoredPass.Location = new System.Drawing.Point(395, 10);
            this.loginStoredPass.Name = "loginStoredPass";
            this.loginStoredPass.Size = new System.Drawing.Size(186, 20);
            this.loginStoredPass.TabIndex = 5;
            this.loginStoredPass.Visible = false;
            // 
            // adminIdBox
            // 
            this.adminIdBox.Location = new System.Drawing.Point(12, 10);
            this.adminIdBox.Name = "adminIdBox";
            this.adminIdBox.Size = new System.Drawing.Size(74, 20);
            this.adminIdBox.TabIndex = 6;
            this.adminIdBox.Visible = false;
            // 
            // PasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 157);
            this.Controls.Add(this.adminIdBox);
            this.Controls.Add(this.loginStoredPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newPasswordBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentPasswordBox);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PasswordChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Change";
            this.Load += new System.EventHandler(this.PasswordChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox currentPasswordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newPasswordBox;
        private System.Windows.Forms.TextBox loginStoredPass;
        private System.Windows.Forms.TextBox adminIdBox;
    }
}