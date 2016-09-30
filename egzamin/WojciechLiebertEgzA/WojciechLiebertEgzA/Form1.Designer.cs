namespace WojciechLiebertEgzA
{
    partial class Form1
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
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.buttonA1 = new System.Windows.Forms.Button();
            this.dataGridViewSuppliers = new System.Windows.Forms.DataGridView();
            this.buttonA2Suppliers = new System.Windows.Forms.Button();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.buttonA2Products = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.RowTemplate.Height = 24;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewCustomers.TabIndex = 0;
            // 
            // buttonA1
            // 
            this.buttonA1.Location = new System.Drawing.Point(12, 168);
            this.buttonA1.Name = "buttonA1";
            this.buttonA1.Size = new System.Drawing.Size(130, 23);
            this.buttonA1.TabIndex = 1;
            this.buttonA1.Text = "A.1 klienci";
            this.buttonA1.UseVisualStyleBackColor = true;
            this.buttonA1.Click += new System.EventHandler(this.buttonA1_Click);
            // 
            // dataGridViewSuppliers
            // 
            this.dataGridViewSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuppliers.Location = new System.Drawing.Point(283, 12);
            this.dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            this.dataGridViewSuppliers.RowTemplate.Height = 24;
            this.dataGridViewSuppliers.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewSuppliers.TabIndex = 2;
            // 
            // buttonA2Suppliers
            // 
            this.buttonA2Suppliers.Location = new System.Drawing.Point(283, 168);
            this.buttonA2Suppliers.Name = "buttonA2Suppliers";
            this.buttonA2Suppliers.Size = new System.Drawing.Size(130, 23);
            this.buttonA2Suppliers.TabIndex = 3;
            this.buttonA2Suppliers.Text = "A.2 Dostawcy";
            this.buttonA2Suppliers.UseVisualStyleBackColor = true;
            this.buttonA2Suppliers.Click += new System.EventHandler(this.buttonA2Suppliers_Click);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(529, 12);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowTemplate.Height = 24;
            this.dataGridViewProducts.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewProducts.TabIndex = 4;
            // 
            // buttonA2Products
            // 
            this.buttonA2Products.Location = new System.Drawing.Point(529, 168);
            this.buttonA2Products.Name = "buttonA2Products";
            this.buttonA2Products.Size = new System.Drawing.Size(130, 23);
            this.buttonA2Products.TabIndex = 5;
            this.buttonA2Products.Text = "A.2 Produkty";
            this.buttonA2Products.UseVisualStyleBackColor = true;
            this.buttonA2Products.Click += new System.EventHandler(this.buttonA2Products_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 528);
            this.Controls.Add(this.buttonA2Products);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.buttonA2Suppliers);
            this.Controls.Add(this.dataGridViewSuppliers);
            this.Controls.Add(this.buttonA1);
            this.Controls.Add(this.dataGridViewCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.Button buttonA1;
        private System.Windows.Forms.DataGridView dataGridViewSuppliers;
        private System.Windows.Forms.Button buttonA2Suppliers;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button buttonA2Products;
    }
}

