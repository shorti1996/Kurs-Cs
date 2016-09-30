namespace SuperZarcie.View
{
    partial class FormOrder
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
            this.dataGridViewMeals = new System.Windows.Forms.DataGridView();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.superZarcieDataSet1 = new SuperZarcie.SuperZarcieDataSet();
            this.buttonPlaceOrder = new System.Windows.Forms.Button();
            this.customerTableAdapter1 = new SuperZarcie.SuperZarcieDataSetTableAdapters.CustomerTableAdapter();
            this.mealTableAdapter1 = new SuperZarcie.SuperZarcieDataSetTableAdapters.MealTableAdapter();
            this.orderTableAdapter1 = new SuperZarcie.SuperZarcieDataSetTableAdapters.OrderTableAdapter();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superZarcieDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMeals
            // 
            this.dataGridViewMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMeals.Location = new System.Drawing.Point(13, 146);
            this.dataGridViewMeals.Name = "dataGridViewMeals";
            this.dataGridViewMeals.RowTemplate.Height = 24;
            this.dataGridViewMeals.Size = new System.Drawing.Size(548, 426);
            this.dataGridViewMeals.TabIndex = 0;
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(567, 146);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowTemplate.Height = 24;
            this.dataGridViewOrder.Size = new System.Drawing.Size(465, 426);
            this.dataGridViewOrder.TabIndex = 1;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(12, 578);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Odśwież";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(93, 578);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(957, 578);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 4;
            this.buttonRemove.Text = "Usuń";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(95, 62);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(274, 22);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(95, 90);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(274, 22);
            this.textBoxSurname.TabIndex = 6;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(94, 118);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(274, 22);
            this.textBoxAddress.TabIndex = 7;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 65);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(33, 17);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Imię";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(13, 93);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(67, 17);
            this.labelSurname.TabIndex = 9;
            this.labelSurname.Text = "Nazwisko";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(13, 121);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 17);
            this.labelAddress.TabIndex = 10;
            this.labelAddress.Text = "Adres";
            // 
            // superZarcieDataSet1
            // 
            this.superZarcieDataSet1.DataSetName = "SuperZarcieDataSet";
            this.superZarcieDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonPlaceOrder
            // 
            this.buttonPlaceOrder.Location = new System.Drawing.Point(899, 61);
            this.buttonPlaceOrder.Name = "buttonPlaceOrder";
            this.buttonPlaceOrder.Size = new System.Drawing.Size(133, 79);
            this.buttonPlaceOrder.TabIndex = 11;
            this.buttonPlaceOrder.Text = "Złóż zamówienie";
            this.buttonPlaceOrder.UseVisualStyleBackColor = true;
            this.buttonPlaceOrder.Click += new System.EventHandler(this.buttonPlaceOrder_Click);
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // mealTableAdapter1
            // 
            this.mealTableAdapter1.ClearBeforeFill = true;
            // 
            // orderTableAdapter1
            // 
            this.orderTableAdapter1.ClearBeforeFill = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 12);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(94, 23);
            this.buttonLogin.TabIndex = 12;
            this.buttonLogin.Text = "Logowanie";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(112, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "<- Logowanie dla pracownika";
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 613);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonPlaceOrder);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewOrder);
            this.Controls.Add(this.dataGridViewMeals);
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMeals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superZarcieDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMeals;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxAddress;
        private SuperZarcieDataSet superZarcieDataSet1;
        private SuperZarcieDataSetTableAdapters.CustomerTableAdapter customerTableAdapter1;
        private SuperZarcieDataSetTableAdapters.MealTableAdapter mealTableAdapter1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Button buttonPlaceOrder;
        private SuperZarcieDataSetTableAdapters.OrderTableAdapter orderTableAdapter1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label1;
    }
}