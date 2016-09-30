namespace SuperZarcie.View
{
    partial class FormDriver
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
            this.dataGridViewDisplay = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.superZarcieDataSet1 = new SuperZarcie.SuperZarcieDataSet();
            this.orderTableAdapter1 = new SuperZarcie.SuperZarcieDataSetTableAdapters.OrderTableAdapter();
            this.customerTableAdapter1 = new SuperZarcie.SuperZarcieDataSetTableAdapters.CustomerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superZarcieDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDisplay
            // 
            this.dataGridViewDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplay.Location = new System.Drawing.Point(12, 59);
            this.dataGridViewDisplay.Name = "dataGridViewDisplay";
            this.dataGridViewDisplay.RowTemplate.Height = 24;
            this.dataGridViewDisplay.Size = new System.Drawing.Size(931, 494);
            this.dataGridViewDisplay.TabIndex = 0;
            this.dataGridViewDisplay.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewDisplay_RowHeaderMouseClick);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(12, 12);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(135, 41);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Odśwież";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(215, 12);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(135, 41);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "Usuń zamówienie";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // superZarcieDataSet1
            // 
            this.superZarcieDataSet1.DataSetName = "SuperZarcieDataSet";
            this.superZarcieDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderTableAdapter1
            // 
            this.orderTableAdapter1.ClearBeforeFill = true;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // FormDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 565);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewDisplay);
            this.Name = "FormDriver";
            this.Text = "data";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superZarcieDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDisplay;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonRemove;
        private SuperZarcieDataSet superZarcieDataSet1;
        private SuperZarcieDataSetTableAdapters.OrderTableAdapter orderTableAdapter1;
        private SuperZarcieDataSetTableAdapters.CustomerTableAdapter customerTableAdapter1;
    }
}