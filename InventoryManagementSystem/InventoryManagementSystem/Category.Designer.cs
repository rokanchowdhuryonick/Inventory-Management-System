namespace Inventory_Management_System
{
    partial class Category
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
            this.categoryNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.categoryGridView = new System.Windows.Forms.DataGridView();
            this.categoryIdBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // categoryNameBox
            // 
            this.categoryNameBox.Location = new System.Drawing.Point(52, 22);
            this.categoryNameBox.Name = "categoryNameBox";
            this.categoryNameBox.Size = new System.Drawing.Size(194, 20);
            this.categoryNameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(128, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(64, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(193, 48);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // categoryGridView
            // 
            this.categoryGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryGridView.Location = new System.Drawing.Point(5, 122);
            this.categoryGridView.Name = "categoryGridView";
            this.categoryGridView.Size = new System.Drawing.Size(267, 157);
            this.categoryGridView.TabIndex = 6;
            this.categoryGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryGridView_CellContentClick);
            this.categoryGridView.Click += new System.EventHandler(this.CategoryGridView_Click);
            // 
            // categoryIdBox
            // 
            this.categoryIdBox.Location = new System.Drawing.Point(6, 2);
            this.categoryIdBox.Name = "categoryIdBox";
            this.categoryIdBox.Size = new System.Drawing.Size(31, 20);
            this.categoryIdBox.TabIndex = 7;
            this.categoryIdBox.Visible = false;
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 284);
            this.Controls.Add(this.categoryIdBox);
            this.Controls.Add(this.categoryGridView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryNameBox);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox categoryNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView categoryGridView;
        private System.Windows.Forms.TextBox categoryIdBox;
    }
}