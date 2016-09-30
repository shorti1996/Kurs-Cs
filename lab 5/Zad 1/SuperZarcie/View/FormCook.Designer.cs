namespace SuperZarcie.View
{
    partial class FormCook
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
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.dataGridViewMeals = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.splitContainerDisplay = new System.Windows.Forms.SplitContainer();
            this.textBoxBoxId = new System.Windows.Forms.TextBox();
            this.labelBox = new System.Windows.Forms.Label();
            this.buttonAddBox = new System.Windows.Forms.Button();
            this.superZarcieDataSet1 = new SuperZarcie.SuperZarcieDataSet();
            this.orderTableAdapter1 = new SuperZarcie.SuperZarcieDataSetTableAdapters.OrderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDisplay)).BeginInit();
            this.splitContainerDisplay.Panel1.SuspendLayout();
            this.splitContainerDisplay.Panel2.SuspendLayout();
            this.splitContainerDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superZarcieDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrders.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowTemplate.Height = 24;
            this.dataGridViewOrders.Size = new System.Drawing.Size(865, 507);
            this.dataGridViewOrders.TabIndex = 0;
            this.dataGridViewOrders.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewOrders_RowHeaderMouseClick);
            // 
            // dataGridViewMeals
            // 
            this.dataGridViewMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMeals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMeals.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMeals.Name = "dataGridViewMeals";
            this.dataGridViewMeals.RowTemplate.Height = 24;
            this.dataGridViewMeals.Size = new System.Drawing.Size(559, 507);
            this.dataGridViewMeals.TabIndex = 1;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(12, 46);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Odśwież";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // splitContainerDisplay
            // 
            this.splitContainerDisplay.Location = new System.Drawing.Point(12, 75);
            this.splitContainerDisplay.Name = "splitContainerDisplay";
            // 
            // splitContainerDisplay.Panel1
            // 
            this.splitContainerDisplay.Panel1.Controls.Add(this.dataGridViewOrders);
            // 
            // splitContainerDisplay.Panel2
            // 
            this.splitContainerDisplay.Panel2.Controls.Add(this.dataGridViewMeals);
            this.splitContainerDisplay.Size = new System.Drawing.Size(1428, 507);
            this.splitContainerDisplay.SplitterDistance = 865;
            this.splitContainerDisplay.TabIndex = 3;
            // 
            // textBoxBoxId
            // 
            this.textBoxBoxId.Location = new System.Drawing.Point(1219, 12);
            this.textBoxBoxId.Name = "textBoxBoxId";
            this.textBoxBoxId.Size = new System.Drawing.Size(221, 22);
            this.textBoxBoxId.TabIndex = 4;
            // 
            // labelBox
            // 
            this.labelBox.AutoSize = true;
            this.labelBox.Location = new System.Drawing.Point(1109, 12);
            this.labelBox.Name = "labelBox";
            this.labelBox.Size = new System.Drawing.Size(104, 17);
            this.labelBox.TabIndex = 5;
            this.labelBox.Text = "Numer pudełka";
            // 
            // buttonAddBox
            // 
            this.buttonAddBox.Location = new System.Drawing.Point(1349, 40);
            this.buttonAddBox.Name = "buttonAddBox";
            this.buttonAddBox.Size = new System.Drawing.Size(91, 23);
            this.buttonAddBox.TabIndex = 6;
            this.buttonAddBox.Text = "Zatwiedź";
            this.buttonAddBox.UseVisualStyleBackColor = true;
            this.buttonAddBox.Click += new System.EventHandler(this.buttonAddBox_Click);
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
            // FormCook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 639);
            this.Controls.Add(this.buttonAddBox);
            this.Controls.Add(this.labelBox);
            this.Controls.Add(this.textBoxBoxId);
            this.Controls.Add(this.splitContainerDisplay);
            this.Controls.Add(this.buttonRefresh);
            this.Name = "FormCook";
            this.Text = "FormCook";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeals)).EndInit();
            this.splitContainerDisplay.Panel1.ResumeLayout(false);
            this.splitContainerDisplay.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDisplay)).EndInit();
            this.splitContainerDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.superZarcieDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SuperZarcieDataSet superZarcieDataSet1;
        private SuperZarcieDataSetTableAdapters.OrderTableAdapter orderTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.DataGridView dataGridViewMeals;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.SplitContainer splitContainerDisplay;
        private System.Windows.Forms.TextBox textBoxBoxId;
        private System.Windows.Forms.Label labelBox;
        private System.Windows.Forms.Button buttonAddBox;
    }
}