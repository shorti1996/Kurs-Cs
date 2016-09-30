namespace ListaElementowDowolnegoRodzaju
{
    partial class MainForm
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
            this.groupBoxLaptops = new System.Windows.Forms.GroupBox();
            this.buttonExport = new System.Windows.Forms.Button();
            this.textBoxRAM = new System.Windows.Forms.TextBox();
            this.textBoxGraphics = new System.Windows.Forms.TextBox();
            this.labelRAM = new System.Windows.Forms.Label();
            this.labelGraphics = new System.Windows.Forms.Label();
            this.textBoxProcessor = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.labelProcesor = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewLaptops = new System.Windows.Forms.DataGridView();
            this.groupBoxPreview = new System.Windows.Forms.GroupBox();
            this.buttonChangeImage = new System.Windows.Forms.Button();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.groupBoxLaptops.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLaptops)).BeginInit();
            this.groupBoxPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxLaptops
            // 
            this.groupBoxLaptops.Controls.Add(this.buttonExport);
            this.groupBoxLaptops.Controls.Add(this.textBoxRAM);
            this.groupBoxLaptops.Controls.Add(this.textBoxGraphics);
            this.groupBoxLaptops.Controls.Add(this.labelRAM);
            this.groupBoxLaptops.Controls.Add(this.labelGraphics);
            this.groupBoxLaptops.Controls.Add(this.textBoxProcessor);
            this.groupBoxLaptops.Controls.Add(this.textBoxModel);
            this.groupBoxLaptops.Controls.Add(this.textBoxBrand);
            this.groupBoxLaptops.Controls.Add(this.labelProcesor);
            this.groupBoxLaptops.Controls.Add(this.labelModel);
            this.groupBoxLaptops.Controls.Add(this.labelBrand);
            this.groupBoxLaptops.Controls.Add(this.buttonDelete);
            this.groupBoxLaptops.Controls.Add(this.buttonEdit);
            this.groupBoxLaptops.Controls.Add(this.buttonAdd);
            this.groupBoxLaptops.Controls.Add(this.dataGridViewLaptops);
            this.groupBoxLaptops.Location = new System.Drawing.Point(2, 4);
            this.groupBoxLaptops.Name = "groupBoxLaptops";
            this.groupBoxLaptops.Size = new System.Drawing.Size(565, 470);
            this.groupBoxLaptops.TabIndex = 4;
            this.groupBoxLaptops.TabStop = false;
            this.groupBoxLaptops.Text = "Laptopy";
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(304, 435);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 15;
            this.buttonExport.Text = "Eksportuj";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // textBoxRAM
            // 
            this.textBoxRAM.Location = new System.Drawing.Point(121, 403);
            this.textBoxRAM.Name = "textBoxRAM";
            this.textBoxRAM.Size = new System.Drawing.Size(258, 20);
            this.textBoxRAM.TabIndex = 14;
            // 
            // textBoxGraphics
            // 
            this.textBoxGraphics.Location = new System.Drawing.Point(121, 379);
            this.textBoxGraphics.Name = "textBoxGraphics";
            this.textBoxGraphics.Size = new System.Drawing.Size(258, 20);
            this.textBoxGraphics.TabIndex = 13;
            // 
            // labelRAM
            // 
            this.labelRAM.AutoSize = true;
            this.labelRAM.Location = new System.Drawing.Point(54, 406);
            this.labelRAM.Name = "labelRAM";
            this.labelRAM.Size = new System.Drawing.Size(31, 13);
            this.labelRAM.TabIndex = 12;
            this.labelRAM.Text = "RAM";
            // 
            // labelGraphics
            // 
            this.labelGraphics.AutoSize = true;
            this.labelGraphics.Location = new System.Drawing.Point(44, 382);
            this.labelGraphics.Name = "labelGraphics";
            this.labelGraphics.Size = new System.Drawing.Size(41, 13);
            this.labelGraphics.TabIndex = 11;
            this.labelGraphics.Text = "Grafika";
            // 
            // textBoxProcessor
            // 
            this.textBoxProcessor.Location = new System.Drawing.Point(121, 355);
            this.textBoxProcessor.Name = "textBoxProcessor";
            this.textBoxProcessor.Size = new System.Drawing.Size(258, 20);
            this.textBoxProcessor.TabIndex = 10;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(121, 331);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(258, 20);
            this.textBoxModel.TabIndex = 9;
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(121, 307);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(258, 20);
            this.textBoxBrand.TabIndex = 8;
            // 
            // labelProcesor
            // 
            this.labelProcesor.AutoSize = true;
            this.labelProcesor.Location = new System.Drawing.Point(36, 358);
            this.labelProcesor.Name = "labelProcesor";
            this.labelProcesor.Size = new System.Drawing.Size(49, 13);
            this.labelProcesor.TabIndex = 7;
            this.labelProcesor.Text = "Procesor";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(49, 334);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(36, 13);
            this.labelModel.TabIndex = 6;
            this.labelModel.Text = "Model";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(48, 310);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(37, 13);
            this.labelBrand.TabIndex = 5;
            this.labelBrand.Text = "Marka";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(206, 435);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(108, 435);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edytuj";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(10, 435);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewLaptops
            // 
            this.dataGridViewLaptops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLaptops.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewLaptops.MultiSelect = false;
            this.dataGridViewLaptops.Name = "dataGridViewLaptops";
            this.dataGridViewLaptops.ReadOnly = true;
            this.dataGridViewLaptops.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLaptops.Size = new System.Drawing.Size(551, 282);
            this.dataGridViewLaptops.TabIndex = 1;
            this.dataGridViewLaptops.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClickLaptop);
            this.dataGridViewLaptops.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClickLaptop);
            // 
            // groupBoxPreview
            // 
            this.groupBoxPreview.Controls.Add(this.buttonChangeImage);
            this.groupBoxPreview.Controls.Add(this.pictureBoxPreview);
            this.groupBoxPreview.Location = new System.Drawing.Point(573, 4);
            this.groupBoxPreview.Name = "groupBoxPreview";
            this.groupBoxPreview.Size = new System.Drawing.Size(414, 470);
            this.groupBoxPreview.TabIndex = 5;
            this.groupBoxPreview.TabStop = false;
            this.groupBoxPreview.Text = "Podgląd";
            // 
            // buttonChangeImage
            // 
            this.buttonChangeImage.Location = new System.Drawing.Point(6, 435);
            this.buttonChangeImage.Name = "buttonChangeImage";
            this.buttonChangeImage.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeImage.TabIndex = 16;
            this.buttonChangeImage.Text = "Zmień Obraz";
            this.buttonChangeImage.UseVisualStyleBackColor = true;
            this.buttonChangeImage.Click += new System.EventHandler(this.buttonChangeImage_Click);
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(402, 400);
            this.pictureBoxPreview.TabIndex = 0;
            this.pictureBoxPreview.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 477);
            this.Controls.Add(this.groupBoxPreview);
            this.Controls.Add(this.groupBoxLaptops);
            this.Name = "MainForm";
            this.Text = "Główne okno";
            this.groupBoxLaptops.ResumeLayout(false);
            this.groupBoxLaptops.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLaptops)).EndInit();
            this.groupBoxPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLaptops;
        private System.Windows.Forms.TextBox textBoxRAM;
        private System.Windows.Forms.TextBox textBoxGraphics;
        private System.Windows.Forms.Label labelRAM;
        private System.Windows.Forms.Label labelGraphics;
        private System.Windows.Forms.TextBox textBoxProcessor;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.Label labelProcesor;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewLaptops;
        private System.Windows.Forms.GroupBox groupBoxPreview;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonChangeImage;
    }
}

