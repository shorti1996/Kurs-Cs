namespace WojciechLiebertLab5
{
    partial class FormMain
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
            this.labelWojciechLiebert = new System.Windows.Forms.Label();
            this.dataGridViewDisplay = new System.Windows.Forms.DataGridView();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxPricePerUnit = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelPricePerUnit = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWojciechLiebert
            // 
            this.labelWojciechLiebert.AutoSize = true;
            this.labelWojciechLiebert.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWojciechLiebert.Location = new System.Drawing.Point(13, 13);
            this.labelWojciechLiebert.Name = "labelWojciechLiebert";
            this.labelWojciechLiebert.Size = new System.Drawing.Size(486, 69);
            this.labelWojciechLiebert.TabIndex = 0;
            this.labelWojciechLiebert.Text = "Wojciech Liebert";
            // 
            // dataGridViewDisplay
            // 
            this.dataGridViewDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplay.Location = new System.Drawing.Point(25, 85);
            this.dataGridViewDisplay.Name = "dataGridViewDisplay";
            this.dataGridViewDisplay.RowTemplate.Height = 24;
            this.dataGridViewDisplay.Size = new System.Drawing.Size(1078, 414);
            this.dataGridViewDisplay.TabIndex = 1;
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(25, 521);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(75, 23);
            this.buttonDisplay.TabIndex = 2;
            this.buttonDisplay.Text = "Wyświetl";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(25, 549);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Odśwież";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(118, 596);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(118, 522);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(251, 22);
            this.textBoxProductName.TabIndex = 5;
            // 
            // textBoxPricePerUnit
            // 
            this.textBoxPricePerUnit.Location = new System.Drawing.Point(118, 567);
            this.textBoxPricePerUnit.Name = "textBoxPricePerUnit";
            this.textBoxPricePerUnit.Size = new System.Drawing.Size(251, 22);
            this.textBoxPricePerUnit.TabIndex = 6;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(115, 502);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(50, 17);
            this.labelProductName.TabIndex = 7;
            this.labelProductName.Text = "Nazwa";
            // 
            // labelPricePerUnit
            // 
            this.labelPricePerUnit.AutoSize = true;
            this.labelPricePerUnit.Location = new System.Drawing.Point(115, 547);
            this.labelPricePerUnit.Name = "labelPricePerUnit";
            this.labelPricePerUnit.Size = new System.Drawing.Size(105, 17);
            this.labelPricePerUnit.TabIndex = 8;
            this.labelPricePerUnit.Text = "Cena za sztukę";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(202, 596);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(286, 596);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(82, 23);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "Uaktualnij";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 683);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelPricePerUnit);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.textBoxPricePerUnit);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.dataGridViewDisplay);
            this.Controls.Add(this.labelWojciechLiebert);
            this.Name = "FormMain";
            this.Text = "WojciechLiebertLab5";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWojciechLiebert;
        private System.Windows.Forms.DataGridView dataGridViewDisplay;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxPricePerUnit;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelPricePerUnit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
    }
}

