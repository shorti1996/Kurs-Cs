namespace WojciechLiebertLab4
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
            this.dataGridViewDatabase = new System.Windows.Forms.DataGridView();
            this.buttonShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDatabase
            // 
            this.dataGridViewDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatabase.Location = new System.Drawing.Point(16, 15);
            this.dataGridViewDatabase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewDatabase.Name = "dataGridViewDatabase";
            this.dataGridViewDatabase.Size = new System.Drawing.Size(739, 394);
            this.dataGridViewDatabase.TabIndex = 0;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(16, 417);
            this.buttonShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(100, 28);
            this.buttonShow.TabIndex = 1;
            this.buttonShow.Text = "Wyświetl";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click_1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 458);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.dataGridViewDatabase);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.Text = "data";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatabase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDatabase;
        private System.Windows.Forms.Button buttonShow;
    }
}

