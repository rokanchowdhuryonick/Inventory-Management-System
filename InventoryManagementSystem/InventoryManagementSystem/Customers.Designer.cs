namespace Inventory_Management_System
{
    partial class Customers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customerNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerPhoneBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customerAddressBox = new System.Windows.Forms.TextBox();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.customerIdBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerNameBox
            // 
            this.customerNameBox.Location = new System.Drawing.Point(92, 21);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.Size = new System.Drawing.Size(172, 20);
            this.customerNameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone";
            // 
            // customerPhoneBox
            // 
            this.customerPhoneBox.Location = new System.Drawing.Point(315, 21);
            this.customerPhoneBox.Name = "customerPhoneBox";
            this.customerPhoneBox.Size = new System.Drawing.Size(172, 20);
            this.customerPhoneBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            // 
            // customerAddressBox
            // 
            this.customerAddressBox.Location = new System.Drawing.Point(92, 50);
            this.customerAddressBox.Name = "customerAddressBox";
            this.customerAddressBox.Size = new System.Drawing.Size(283, 20);
            this.customerAddressBox.TabIndex = 4;
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.customerDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.customerDataGridView.Location = new System.Drawing.Point(1, 180);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.Size = new System.Drawing.Size(497, 319);
            this.customerDataGridView.TabIndex = 21;
            this.customerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGridView_CellContentClick);
            this.customerDataGridView.Click += new System.EventHandler(this.CustomerDataGridView_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Add Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(116, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Delete Customer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(232, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Update Customer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(365, 95);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // customerIdBox
            // 
            this.customerIdBox.Location = new System.Drawing.Point(412, 50);
            this.customerIdBox.Name = "customerIdBox";
            this.customerIdBox.Size = new System.Drawing.Size(60, 20);
            this.customerIdBox.TabIndex = 26;
            this.customerIdBox.Visible = false;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 500);
            this.Controls.Add(this.customerIdBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customerAddressBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerPhoneBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerNameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerPhoneBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerAddressBox;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox customerIdBox;
    }
}