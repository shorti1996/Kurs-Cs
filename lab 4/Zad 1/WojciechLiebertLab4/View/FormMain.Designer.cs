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
            this.dataGridViewPet = new System.Windows.Forms.DataGridView();
            this.buttonGetFromServer = new System.Windows.Forms.Button();
            this.tabControlData = new System.Windows.Forms.TabControl();
            this.tabPageQuery = new System.Windows.Forms.TabPage();
            this.splitContainerQuery = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxInsert = new System.Windows.Forms.GroupBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.labelInsert = new System.Windows.Forms.Label();
            this.textBoxInsert = new System.Windows.Forms.TextBox();
            this.groupBoxQuery = new System.Windows.Forms.GroupBox();
            this.comboBoxOperationQuery = new System.Windows.Forms.ComboBox();
            this.labelFilterQuery = new System.Windows.Forms.Label();
            this.textBoxFilterQuery = new System.Windows.Forms.TextBox();
            this.labelColumnQuery = new System.Windows.Forms.Label();
            this.comboBoxDatabaseQuery = new System.Windows.Forms.ComboBox();
            this.textBoxColumn = new System.Windows.Forms.TextBox();
            this.labelDatabaseQuery = new System.Windows.Forms.Label();
            this.dataGridViewQuery = new System.Windows.Forms.DataGridView();
            this.tabPagePet = new System.Windows.Forms.TabPage();
            this.tabPageOwner = new System.Windows.Forms.TabPage();
            this.dataGridViewOwner = new System.Windows.Forms.DataGridView();
            this.tabPageVet = new System.Windows.Forms.TabPage();
            this.dataGridViewVet = new System.Windows.Forms.DataGridView();
            this.tabPageVisit = new System.Windows.Forms.TabPage();
            this.dataGridViewVisit = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPet)).BeginInit();
            this.tabControlData.SuspendLayout();
            this.tabPageQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerQuery)).BeginInit();
            this.splitContainerQuery.Panel1.SuspendLayout();
            this.splitContainerQuery.Panel2.SuspendLayout();
            this.splitContainerQuery.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxInsert.SuspendLayout();
            this.groupBoxQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery)).BeginInit();
            this.tabPagePet.SuspendLayout();
            this.tabPageOwner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOwner)).BeginInit();
            this.tabPageVet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVet)).BeginInit();
            this.tabPageVisit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisit)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPet
            // 
            this.dataGridViewPet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPet.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewPet.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPet.Name = "dataGridViewPet";
            this.dataGridViewPet.Size = new System.Drawing.Size(1035, 548);
            this.dataGridViewPet.TabIndex = 0;
            // 
            // buttonGetFromServer
            // 
            this.buttonGetFromServer.Location = new System.Drawing.Point(20, 602);
            this.buttonGetFromServer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGetFromServer.Name = "buttonGetFromServer";
            this.buttonGetFromServer.Size = new System.Drawing.Size(125, 28);
            this.buttonGetFromServer.TabIndex = 1;
            this.buttonGetFromServer.Text = "Pobierz Dane";
            this.buttonGetFromServer.UseVisualStyleBackColor = true;
            this.buttonGetFromServer.Click += new System.EventHandler(this.buttonGetFromServer_Click);
            // 
            // tabControlData
            // 
            this.tabControlData.Controls.Add(this.tabPageQuery);
            this.tabControlData.Controls.Add(this.tabPagePet);
            this.tabControlData.Controls.Add(this.tabPageOwner);
            this.tabControlData.Controls.Add(this.tabPageVet);
            this.tabControlData.Controls.Add(this.tabPageVisit);
            this.tabControlData.Location = new System.Drawing.Point(16, 12);
            this.tabControlData.Name = "tabControlData";
            this.tabControlData.SelectedIndex = 0;
            this.tabControlData.Size = new System.Drawing.Size(1049, 583);
            this.tabControlData.TabIndex = 2;
            // 
            // tabPageQuery
            // 
            this.tabPageQuery.Controls.Add(this.splitContainerQuery);
            this.tabPageQuery.Location = new System.Drawing.Point(4, 25);
            this.tabPageQuery.Name = "tabPageQuery";
            this.tabPageQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQuery.Size = new System.Drawing.Size(1041, 554);
            this.tabPageQuery.TabIndex = 4;
            this.tabPageQuery.Text = "Szukaj";
            this.tabPageQuery.UseVisualStyleBackColor = true;
            // 
            // splitContainerQuery
            // 
            this.splitContainerQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerQuery.Location = new System.Drawing.Point(3, 3);
            this.splitContainerQuery.Name = "splitContainerQuery";
            // 
            // splitContainerQuery.Panel1
            // 
            this.splitContainerQuery.Panel1.AutoScroll = true;
            this.splitContainerQuery.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainerQuery.Panel2
            // 
            this.splitContainerQuery.Panel2.Controls.Add(this.dataGridViewQuery);
            this.splitContainerQuery.Size = new System.Drawing.Size(1035, 548);
            this.splitContainerQuery.SplitterDistance = 360;
            this.splitContainerQuery.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxInsert);
            this.panel1.Controls.Add(this.groupBoxQuery);
            this.panel1.Controls.Add(this.labelColumnQuery);
            this.panel1.Controls.Add(this.comboBoxDatabaseQuery);
            this.panel1.Controls.Add(this.textBoxColumn);
            this.panel1.Controls.Add(this.labelDatabaseQuery);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 548);
            this.panel1.TabIndex = 1;
            // 
            // groupBoxInsert
            // 
            this.groupBoxInsert.Controls.Add(this.buttonInsert);
            this.groupBoxInsert.Controls.Add(this.labelInsert);
            this.groupBoxInsert.Controls.Add(this.textBoxInsert);
            this.groupBoxInsert.Location = new System.Drawing.Point(3, 219);
            this.groupBoxInsert.Name = "groupBoxInsert";
            this.groupBoxInsert.Size = new System.Drawing.Size(354, 118);
            this.groupBoxInsert.TabIndex = 7;
            this.groupBoxInsert.TabStop = false;
            this.groupBoxInsert.Text = "Wstawianie";
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(6, 77);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 4;
            this.buttonInsert.Text = "Wstaw";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // labelInsert
            // 
            this.labelInsert.AutoSize = true;
            this.labelInsert.Location = new System.Drawing.Point(9, 28);
            this.labelInsert.Name = "labelInsert";
            this.labelInsert.Size = new System.Drawing.Size(49, 17);
            this.labelInsert.TabIndex = 3;
            this.labelInsert.Text = "Wstaw";
            // 
            // textBoxInsert
            // 
            this.textBoxInsert.Location = new System.Drawing.Point(6, 48);
            this.textBoxInsert.Name = "textBoxInsert";
            this.textBoxInsert.Size = new System.Drawing.Size(329, 22);
            this.textBoxInsert.TabIndex = 0;
            // 
            // groupBoxQuery
            // 
            this.groupBoxQuery.Controls.Add(this.comboBoxOperationQuery);
            this.groupBoxQuery.Controls.Add(this.labelFilterQuery);
            this.groupBoxQuery.Controls.Add(this.textBoxFilterQuery);
            this.groupBoxQuery.Location = new System.Drawing.Point(3, 131);
            this.groupBoxQuery.Name = "groupBoxQuery";
            this.groupBoxQuery.Size = new System.Drawing.Size(354, 82);
            this.groupBoxQuery.TabIndex = 0;
            this.groupBoxQuery.TabStop = false;
            this.groupBoxQuery.Text = "Filtrowanie";
            // 
            // comboBoxOperationQuery
            // 
            this.comboBoxOperationQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperationQuery.FormattingEnabled = true;
            this.comboBoxOperationQuery.Items.AddRange(new object[] {
            "Like",
            "<",
            "<=",
            "=",
            ">",
            ">="});
            this.comboBoxOperationQuery.Location = new System.Drawing.Point(7, 46);
            this.comboBoxOperationQuery.Name = "comboBoxOperationQuery";
            this.comboBoxOperationQuery.Size = new System.Drawing.Size(101, 24);
            this.comboBoxOperationQuery.TabIndex = 6;
            // 
            // labelFilterQuery
            // 
            this.labelFilterQuery.AutoSize = true;
            this.labelFilterQuery.Location = new System.Drawing.Point(10, 28);
            this.labelFilterQuery.Name = "labelFilterQuery";
            this.labelFilterQuery.Size = new System.Drawing.Size(31, 17);
            this.labelFilterQuery.TabIndex = 3;
            this.labelFilterQuery.Text = "Filtr";
            // 
            // textBoxFilterQuery
            // 
            this.textBoxFilterQuery.Location = new System.Drawing.Point(114, 46);
            this.textBoxFilterQuery.Name = "textBoxFilterQuery";
            this.textBoxFilterQuery.Size = new System.Drawing.Size(222, 22);
            this.textBoxFilterQuery.TabIndex = 0;
            this.textBoxFilterQuery.TextChanged += new System.EventHandler(this.textBoxFilterQuery_TextChanged);
            // 
            // labelColumnQuery
            // 
            this.labelColumnQuery.AutoSize = true;
            this.labelColumnQuery.Location = new System.Drawing.Point(10, 71);
            this.labelColumnQuery.Name = "labelColumnQuery";
            this.labelColumnQuery.Size = new System.Drawing.Size(182, 17);
            this.labelColumnQuery.TabIndex = 5;
            this.labelColumnQuery.Text = "Kolumna (kliknij w komórkę)";
            // 
            // comboBoxDatabaseQuery
            // 
            this.comboBoxDatabaseQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDatabaseQuery.FormattingEnabled = true;
            this.comboBoxDatabaseQuery.Location = new System.Drawing.Point(10, 28);
            this.comboBoxDatabaseQuery.Name = "comboBoxDatabaseQuery";
            this.comboBoxDatabaseQuery.Size = new System.Drawing.Size(329, 24);
            this.comboBoxDatabaseQuery.TabIndex = 2;
            this.comboBoxDatabaseQuery.TextChanged += new System.EventHandler(this.comboBoxDatabaseQuery_TextChanged);
            // 
            // textBoxColumn
            // 
            this.textBoxColumn.Location = new System.Drawing.Point(10, 91);
            this.textBoxColumn.Name = "textBoxColumn";
            this.textBoxColumn.ReadOnly = true;
            this.textBoxColumn.Size = new System.Drawing.Size(329, 22);
            this.textBoxColumn.TabIndex = 4;
            // 
            // labelDatabaseQuery
            // 
            this.labelDatabaseQuery.AutoSize = true;
            this.labelDatabaseQuery.Location = new System.Drawing.Point(10, 8);
            this.labelDatabaseQuery.Name = "labelDatabaseQuery";
            this.labelDatabaseQuery.Size = new System.Drawing.Size(90, 17);
            this.labelDatabaseQuery.TabIndex = 1;
            this.labelDatabaseQuery.Text = "Baza danych";
            // 
            // dataGridViewQuery
            // 
            this.dataGridViewQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewQuery.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewQuery.Name = "dataGridViewQuery";
            this.dataGridViewQuery.RowTemplate.Height = 24;
            this.dataGridViewQuery.Size = new System.Drawing.Size(671, 548);
            this.dataGridViewQuery.TabIndex = 0;
            this.dataGridViewQuery.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewQuery_CellMouseClick);
            // 
            // tabPagePet
            // 
            this.tabPagePet.Controls.Add(this.dataGridViewPet);
            this.tabPagePet.Location = new System.Drawing.Point(4, 25);
            this.tabPagePet.Name = "tabPagePet";
            this.tabPagePet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePet.Size = new System.Drawing.Size(1041, 554);
            this.tabPagePet.TabIndex = 0;
            this.tabPagePet.Text = "Zwierzątko";
            this.tabPagePet.UseVisualStyleBackColor = true;
            // 
            // tabPageOwner
            // 
            this.tabPageOwner.Controls.Add(this.dataGridViewOwner);
            this.tabPageOwner.Location = new System.Drawing.Point(4, 25);
            this.tabPageOwner.Name = "tabPageOwner";
            this.tabPageOwner.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOwner.Size = new System.Drawing.Size(1041, 554);
            this.tabPageOwner.TabIndex = 1;
            this.tabPageOwner.Text = "Właściciel";
            this.tabPageOwner.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOwner
            // 
            this.dataGridViewOwner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOwner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOwner.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewOwner.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewOwner.Name = "dataGridViewOwner";
            this.dataGridViewOwner.Size = new System.Drawing.Size(1035, 548);
            this.dataGridViewOwner.TabIndex = 1;
            // 
            // tabPageVet
            // 
            this.tabPageVet.Controls.Add(this.dataGridViewVet);
            this.tabPageVet.Location = new System.Drawing.Point(4, 25);
            this.tabPageVet.Name = "tabPageVet";
            this.tabPageVet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVet.Size = new System.Drawing.Size(1041, 554);
            this.tabPageVet.TabIndex = 2;
            this.tabPageVet.Text = "Weterynarz";
            this.tabPageVet.UseVisualStyleBackColor = true;
            // 
            // dataGridViewVet
            // 
            this.dataGridViewVet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVet.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewVet.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewVet.Name = "dataGridViewVet";
            this.dataGridViewVet.Size = new System.Drawing.Size(1035, 548);
            this.dataGridViewVet.TabIndex = 2;
            // 
            // tabPageVisit
            // 
            this.tabPageVisit.Controls.Add(this.dataGridViewVisit);
            this.tabPageVisit.Location = new System.Drawing.Point(4, 25);
            this.tabPageVisit.Name = "tabPageVisit";
            this.tabPageVisit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVisit.Size = new System.Drawing.Size(1041, 554);
            this.tabPageVisit.TabIndex = 3;
            this.tabPageVisit.Text = "Wizyta";
            this.tabPageVisit.UseVisualStyleBackColor = true;
            // 
            // dataGridViewVisit
            // 
            this.dataGridViewVisit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVisit.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewVisit.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewVisit.Name = "dataGridViewVisit";
            this.dataGridViewVisit.Size = new System.Drawing.Size(1035, 548);
            this.dataGridViewVisit.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 643);
            this.Controls.Add(this.tabControlData);
            this.Controls.Add(this.buttonGetFromServer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Weterynarz";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPet)).EndInit();
            this.tabControlData.ResumeLayout(false);
            this.tabPageQuery.ResumeLayout(false);
            this.splitContainerQuery.Panel1.ResumeLayout(false);
            this.splitContainerQuery.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerQuery)).EndInit();
            this.splitContainerQuery.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxInsert.ResumeLayout(false);
            this.groupBoxInsert.PerformLayout();
            this.groupBoxQuery.ResumeLayout(false);
            this.groupBoxQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery)).EndInit();
            this.tabPagePet.ResumeLayout(false);
            this.tabPageOwner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOwner)).EndInit();
            this.tabPageVet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVet)).EndInit();
            this.tabPageVisit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPet;
        private System.Windows.Forms.Button buttonGetFromServer;
        private System.Windows.Forms.TabControl tabControlData;
        private System.Windows.Forms.TabPage tabPagePet;
        private System.Windows.Forms.TabPage tabPageOwner;
        private System.Windows.Forms.DataGridView dataGridViewOwner;
        private System.Windows.Forms.TabPage tabPageVet;
        private System.Windows.Forms.TabPage tabPageVisit;
        private System.Windows.Forms.TabPage tabPageQuery;
        private System.Windows.Forms.DataGridView dataGridViewVet;
        private System.Windows.Forms.DataGridView dataGridViewVisit;
        private System.Windows.Forms.SplitContainer splitContainerQuery;
        private System.Windows.Forms.GroupBox groupBoxQuery;
        private System.Windows.Forms.Label labelColumnQuery;
        private System.Windows.Forms.TextBox textBoxColumn;
        private System.Windows.Forms.Label labelFilterQuery;
        private System.Windows.Forms.ComboBox comboBoxDatabaseQuery;
        private System.Windows.Forms.Label labelDatabaseQuery;
        private System.Windows.Forms.TextBox textBoxFilterQuery;
        private System.Windows.Forms.DataGridView dataGridViewQuery;
        private System.Windows.Forms.ComboBox comboBoxOperationQuery;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxInsert;
        private System.Windows.Forms.Label labelInsert;
        private System.Windows.Forms.TextBox textBoxInsert;
        private System.Windows.Forms.Button buttonInsert;
    }
}

