namespace Inventory_Management_System
{
    partial class Products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.productNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productPurchasePriceBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productSellPriceBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.productStockAmountBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.productBarcodeBox = new System.Windows.Forms.TextBox();
            this.productCategoryBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.productStatusBox = new System.Windows.Forms.ComboBox();
            this.productSavebtn = new System.Windows.Forms.Button();
            this.productUpdatebtn = new System.Windows.Forms.Button();
            this.productDeletebtn = new System.Windows.Forms.Button();
            this.productBoxClearbtn = new System.Windows.Forms.Button();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productIdBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productNameBox
            // 
            this.productNameBox.Location = new System.Drawing.Point(593, 28);
            this.productNameBox.Name = "productNameBox";
            this.productNameBox.Size = new System.Drawing.Size(239, 20);
            this.productNameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Purchase Price";
            // 
            // productPurchasePriceBox
            // 
            this.productPurchasePriceBox.Location = new System.Drawing.Point(97, 68);
            this.productPurchasePriceBox.Name = "productPurchasePriceBox";
            this.productPurchasePriceBox.Size = new System.Drawing.Size(103, 20);
            this.productPurchasePriceBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sell Price";
            // 
            // productSellPriceBox
            // 
            this.productSellPriceBox.Location = new System.Drawing.Point(339, 64);
            this.productSellPriceBox.Name = "productSellPriceBox";
            this.productSellPriceBox.ShortcutsEnabled = false;
            this.productSellPriceBox.Size = new System.Drawing.Size(103, 20);
            this.productSellPriceBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "In Stock";
            // 
            // productStockAmountBox
            // 
            this.productStockAmountBox.Location = new System.Drawing.Point(571, 68);
            this.productStockAmountBox.Name = "productStockAmountBox";
            this.productStockAmountBox.Size = new System.Drawing.Size(114, 20);
            this.productStockAmountBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Barcode";
            // 
            // productBarcodeBox
            // 
            this.productBarcodeBox.Enabled = false;
            this.productBarcodeBox.Location = new System.Drawing.Point(97, 28);
            this.productBarcodeBox.Name = "productBarcodeBox";
            this.productBarcodeBox.Size = new System.Drawing.Size(152, 20);
            this.productBarcodeBox.TabIndex = 10;
            // 
            // productCategoryBox
            // 
            this.productCategoryBox.DisplayMember = "cat_name";
            this.productCategoryBox.FormattingEnabled = true;
            this.productCategoryBox.Location = new System.Drawing.Point(339, 27);
            this.productCategoryBox.Name = "productCategoryBox";
            this.productCategoryBox.Size = new System.Drawing.Size(161, 21);
            this.productCategoryBox.TabIndex = 12;
            this.productCategoryBox.ValueMember = "cat_name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(691, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Status";
            // 
            // productStatusBox
            // 
            this.productStatusBox.FormattingEnabled = true;
            this.productStatusBox.Items.AddRange(new object[] {
            "Available",
            "Un-available"});
            this.productStatusBox.Location = new System.Drawing.Point(747, 68);
            this.productStatusBox.Name = "productStatusBox";
            this.productStatusBox.Size = new System.Drawing.Size(85, 21);
            this.productStatusBox.TabIndex = 14;
            // 
            // productSavebtn
            // 
            this.productSavebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.productSavebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productSavebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productSavebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productSavebtn.Location = new System.Drawing.Point(183, 108);
            this.productSavebtn.Name = "productSavebtn";
            this.productSavebtn.Size = new System.Drawing.Size(89, 31);
            this.productSavebtn.TabIndex = 16;
            this.productSavebtn.Text = "Add Product";
            this.productSavebtn.UseVisualStyleBackColor = false;
            this.productSavebtn.Click += new System.EventHandler(this.ProductSavebtn_Click);
            // 
            // productUpdatebtn
            // 
            this.productUpdatebtn.BackColor = System.Drawing.Color.CadetBlue;
            this.productUpdatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productUpdatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productUpdatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productUpdatebtn.Location = new System.Drawing.Point(298, 108);
            this.productUpdatebtn.Name = "productUpdatebtn";
            this.productUpdatebtn.Size = new System.Drawing.Size(111, 31);
            this.productUpdatebtn.TabIndex = 17;
            this.productUpdatebtn.Text = "Update Product";
            this.productUpdatebtn.UseVisualStyleBackColor = false;
            this.productUpdatebtn.Click += new System.EventHandler(this.ProductUpdatebtn_Click);
            // 
            // productDeletebtn
            // 
            this.productDeletebtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.productDeletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productDeletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productDeletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDeletebtn.Location = new System.Drawing.Point(427, 108);
            this.productDeletebtn.Name = "productDeletebtn";
            this.productDeletebtn.Size = new System.Drawing.Size(111, 31);
            this.productDeletebtn.TabIndex = 18;
            this.productDeletebtn.Text = "Delete Product";
            this.productDeletebtn.UseVisualStyleBackColor = false;
            this.productDeletebtn.Click += new System.EventHandler(this.ProductDeletebtn_Click);
            // 
            // productBoxClearbtn
            // 
            this.productBoxClearbtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.productBoxClearbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productBoxClearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productBoxClearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productBoxClearbtn.Location = new System.Drawing.Point(565, 108);
            this.productBoxClearbtn.Name = "productBoxClearbtn";
            this.productBoxClearbtn.Size = new System.Drawing.Size(81, 31);
            this.productBoxClearbtn.TabIndex = 19;
            this.productBoxClearbtn.Text = "Clear";
            this.productBoxClearbtn.UseVisualStyleBackColor = false;
            this.productBoxClearbtn.Click += new System.EventHandler(this.ProductBoxClearbtn_Click);
            // 
            // productDataGridView
            // 
            this.productDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.productDataGridView.Location = new System.Drawing.Point(1, 180);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.Size = new System.Drawing.Size(860, 319);
            this.productDataGridView.TabIndex = 20;
            this.productDataGridView.Click += new System.EventHandler(this.ProductDataGridView_Click);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            // 
            // productIdBox
            // 
            this.productIdBox.Location = new System.Drawing.Point(15, 108);
            this.productIdBox.Name = "productIdBox";
            this.productIdBox.ShortcutsEnabled = false;
            this.productIdBox.Size = new System.Drawing.Size(76, 20);
            this.productIdBox.TabIndex = 21;
            this.productIdBox.Visible = false;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 500);
            this.Controls.Add(this.productIdBox);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.productBoxClearbtn);
            this.Controls.Add(this.productDeletebtn);
            this.Controls.Add(this.productUpdatebtn);
            this.Controls.Add(this.productSavebtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.productStatusBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.productCategoryBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.productBarcodeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.productStockAmountBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productSellPriceBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productPurchasePriceBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productNameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productPurchasePriceBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productSellPriceBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox productStockAmountBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox productBarcodeBox;
        private System.Windows.Forms.ComboBox productCategoryBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox productStatusBox;
        private System.Windows.Forms.Button productSavebtn;
        private System.Windows.Forms.Button productUpdatebtn;
        private System.Windows.Forms.Button productDeletebtn;
        private System.Windows.Forms.Button productBoxClearbtn;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.TextBox productIdBox;
    }
}