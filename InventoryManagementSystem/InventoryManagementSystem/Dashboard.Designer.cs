namespace Inventory_Management_System
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelAdminName = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.billNoBox = new System.Windows.Forms.TextBox();
            this.customerNameBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.barcodeBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.phoneNumberBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.sellGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.netTotalBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.sellReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(800, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(994, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.sellReportToolStripMenuItem});
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.addProductToolStripMenuItem.Text = "Stock";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.AddProductToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.ProductsToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.CategoryToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.CustomersToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.ChangePasswordToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // labelAdminName
            // 
            this.labelAdminName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAdminName.AutoSize = true;
            this.labelAdminName.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelAdminName.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdminName.Location = new System.Drawing.Point(722, -1);
            this.labelAdminName.MinimumSize = new System.Drawing.Size(270, 20);
            this.labelAdminName.Name = "labelAdminName";
            this.labelAdminName.Padding = new System.Windows.Forms.Padding(1);
            this.labelAdminName.Size = new System.Drawing.Size(270, 24);
            this.labelAdminName.TabIndex = 2;
            this.labelAdminName.Text = "Welcome,  Admin";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(860, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(821, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bill No";
            // 
            // billNoBox
            // 
            this.billNoBox.Enabled = false;
            this.billNoBox.Location = new System.Drawing.Point(57, 42);
            this.billNoBox.Name = "billNoBox";
            this.billNoBox.Size = new System.Drawing.Size(118, 20);
            this.billNoBox.TabIndex = 6;
            // 
            // customerNameBox
            // 
            this.customerNameBox.FormattingEnabled = true;
            this.customerNameBox.Location = new System.Drawing.Point(287, 42);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.Size = new System.Drawing.Size(215, 21);
            this.customerNameBox.TabIndex = 7;
            this.customerNameBox.SelectedIndexChanged += new System.EventHandler(this.CustomerNameBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Customer Name";
            // 
            // barcodeBox
            // 
            this.barcodeBox.Location = new System.Drawing.Point(64, 80);
            this.barcodeBox.Name = "barcodeBox";
            this.barcodeBox.Size = new System.Drawing.Size(111, 20);
            this.barcodeBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Barcode";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(197, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.Location = new System.Drawing.Point(570, 43);
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(167, 20);
            this.phoneNumberBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(524, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Phone";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(744, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 22);
            this.button2.TabIndex = 14;
            this.button2.Text = "Find";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // sellGridView
            // 
            this.sellGridView.AccessibleName = "";
            this.sellGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sellGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.sellGridView.Location = new System.Drawing.Point(12, 141);
            this.sellGridView.Name = "sellGridView";
            this.sellGridView.Size = new System.Drawing.Size(970, 233);
            this.sellGridView.TabIndex = 15;
            this.sellGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.sellGridView_CellEndEdit);
            this.sellGridView.SelectionChanged += new System.EventHandler(this.sellGridView_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "SL. No.";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Product Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Barcode";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Qty";
            this.Column5.Name = "Column5";
            this.Column5.Width = 130;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Amount";
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Net Bill";
            // 
            // netTotalBox
            // 
            this.netTotalBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.netTotalBox.Location = new System.Drawing.Point(57, 387);
            this.netTotalBox.Name = "netTotalBox";
            this.netTotalBox.Size = new System.Drawing.Size(108, 20);
            this.netTotalBox.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(16, 422);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 36);
            this.button3.TabIndex = 19;
            this.button3.Text = "Purchase";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // sellReportToolStripMenuItem
            // 
            this.sellReportToolStripMenuItem.Name = "sellReportToolStripMenuItem";
            this.sellReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sellReportToolStripMenuItem.Text = "Sell Report";
            this.sellReportToolStripMenuItem.Click += new System.EventHandler(this.sellReportToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.BackColor = System.Drawing.Color.DarkRed;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 470);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.netTotalBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sellGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.phoneNumberBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.barcodeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customerNameBox);
            this.Controls.Add(this.billNoBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelAdminName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.Label labelAdminName;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox billNoBox;
        private System.Windows.Forms.ComboBox customerNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox barcodeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox phoneNumberBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView sellGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox netTotalBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem sellReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}