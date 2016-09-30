namespace WojciechLiebertLab2
{
    partial class FormWojciechLiebert
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
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.groupBoxStudents = new System.Windows.Forms.GroupBox();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelIndex = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxNotes = new System.Windows.Forms.GroupBox();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.labelNote = new System.Windows.Forms.Label();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxIndexNotes = new System.Windows.Forms.TextBox();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelIndexNotes = new System.Windows.Forms.Label();
            this.buttonDeleteNotes = new System.Windows.Forms.Button();
            this.buttonEditNotes = new System.Windows.Forms.Button();
            this.buttonAddNotes = new System.Windows.Forms.Button();
            this.dataGridViewNotes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.groupBoxStudents.SuspendLayout();
            this.groupBoxNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWojciechLiebert
            // 
            this.labelWojciechLiebert.AutoSize = true;
            this.labelWojciechLiebert.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWojciechLiebert.Location = new System.Drawing.Point(2, 9);
            this.labelWojciechLiebert.Name = "labelWojciechLiebert";
            this.labelWojciechLiebert.Size = new System.Drawing.Size(340, 57);
            this.labelWojciechLiebert.TabIndex = 0;
            this.labelWojciechLiebert.Text = "Wojciech Liebert";
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewStudents.MultiSelect = false;
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudents.Size = new System.Drawing.Size(379, 282);
            this.dataGridViewStudents.TabIndex = 1;
            this.dataGridViewStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClickStudents);
            this.dataGridViewStudents.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RowHeaderMouseClickStudents);
            this.dataGridViewStudents.Enter += new System.EventHandler(this.RowHeaderMouseClickStudents);
            // 
            // groupBoxStudents
            // 
            this.groupBoxStudents.Controls.Add(this.textBoxIndex);
            this.groupBoxStudents.Controls.Add(this.textBoxSurname);
            this.groupBoxStudents.Controls.Add(this.textBoxName);
            this.groupBoxStudents.Controls.Add(this.labelIndex);
            this.groupBoxStudents.Controls.Add(this.labelSurname);
            this.groupBoxStudents.Controls.Add(this.labelName);
            this.groupBoxStudents.Controls.Add(this.buttonDelete);
            this.groupBoxStudents.Controls.Add(this.buttonEdit);
            this.groupBoxStudents.Controls.Add(this.buttonAdd);
            this.groupBoxStudents.Controls.Add(this.dataGridViewStudents);
            this.groupBoxStudents.Location = new System.Drawing.Point(12, 69);
            this.groupBoxStudents.Name = "groupBoxStudents";
            this.groupBoxStudents.Size = new System.Drawing.Size(391, 470);
            this.groupBoxStudents.TabIndex = 3;
            this.groupBoxStudents.TabStop = false;
            this.groupBoxStudents.Text = "Studenci";
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Location = new System.Drawing.Point(127, 367);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(258, 20);
            this.textBoxIndex.TabIndex = 10;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(127, 337);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(258, 20);
            this.textBoxSurname.TabIndex = 9;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(127, 307);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(258, 20);
            this.textBoxName.TabIndex = 8;
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Location = new System.Drawing.Point(32, 371);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(59, 13);
            this.labelIndex.TabIndex = 7;
            this.labelIndex.Text = "Nr Indeksu";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(38, 340);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(53, 13);
            this.labelSurname.TabIndex = 6;
            this.labelSurname.Text = "Nazwisko";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(65, 310);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(26, 13);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Imię";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(236, 435);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(127, 435);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edytuj";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(16, 435);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBoxNotes
            // 
            this.groupBoxNotes.Controls.Add(this.textBoxNotes);
            this.groupBoxNotes.Controls.Add(this.labelNote);
            this.groupBoxNotes.Controls.Add(this.textBoxSubject);
            this.groupBoxNotes.Controls.Add(this.textBoxDate);
            this.groupBoxNotes.Controls.Add(this.textBoxIndexNotes);
            this.groupBoxNotes.Controls.Add(this.labelSubject);
            this.groupBoxNotes.Controls.Add(this.labelDate);
            this.groupBoxNotes.Controls.Add(this.labelIndexNotes);
            this.groupBoxNotes.Controls.Add(this.buttonDeleteNotes);
            this.groupBoxNotes.Controls.Add(this.buttonEditNotes);
            this.groupBoxNotes.Controls.Add(this.buttonAddNotes);
            this.groupBoxNotes.Controls.Add(this.dataGridViewNotes);
            this.groupBoxNotes.Location = new System.Drawing.Point(409, 69);
            this.groupBoxNotes.Name = "groupBoxNotes";
            this.groupBoxNotes.Size = new System.Drawing.Size(391, 470);
            this.groupBoxNotes.TabIndex = 11;
            this.groupBoxNotes.TabStop = false;
            this.groupBoxNotes.Text = "Oceny";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(127, 401);
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(258, 20);
            this.textBoxNotes.TabIndex = 12;
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(52, 407);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(39, 13);
            this.labelNote.TabIndex = 11;
            this.labelNote.Text = "Ocena";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(127, 368);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(258, 20);
            this.textBoxSubject.TabIndex = 10;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(127, 337);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(258, 20);
            this.textBoxDate.TabIndex = 9;
            // 
            // textBoxIndexNotes
            // 
            this.textBoxIndexNotes.Enabled = false;
            this.textBoxIndexNotes.Location = new System.Drawing.Point(127, 307);
            this.textBoxIndexNotes.Name = "textBoxIndexNotes";
            this.textBoxIndexNotes.Size = new System.Drawing.Size(258, 20);
            this.textBoxIndexNotes.TabIndex = 8;
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(38, 374);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(53, 13);
            this.labelSubject.TabIndex = 7;
            this.labelSubject.Text = "Przedmiot";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(61, 340);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(30, 13);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Data";
            // 
            // labelIndexNotes
            // 
            this.labelIndexNotes.AutoSize = true;
            this.labelIndexNotes.Location = new System.Drawing.Point(32, 310);
            this.labelIndexNotes.Name = "labelIndexNotes";
            this.labelIndexNotes.Size = new System.Drawing.Size(59, 13);
            this.labelIndexNotes.TabIndex = 5;
            this.labelIndexNotes.Text = "Nr Indeksu";
            // 
            // buttonDeleteNotes
            // 
            this.buttonDeleteNotes.Location = new System.Drawing.Point(236, 435);
            this.buttonDeleteNotes.Name = "buttonDeleteNotes";
            this.buttonDeleteNotes.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteNotes.TabIndex = 4;
            this.buttonDeleteNotes.Text = "Usuń";
            this.buttonDeleteNotes.UseVisualStyleBackColor = true;
            this.buttonDeleteNotes.Click += new System.EventHandler(this.buttonDeleteNotes_Click);
            // 
            // buttonEditNotes
            // 
            this.buttonEditNotes.Location = new System.Drawing.Point(127, 435);
            this.buttonEditNotes.Name = "buttonEditNotes";
            this.buttonEditNotes.Size = new System.Drawing.Size(75, 23);
            this.buttonEditNotes.TabIndex = 3;
            this.buttonEditNotes.Text = "Edytuj";
            this.buttonEditNotes.UseVisualStyleBackColor = true;
            this.buttonEditNotes.Click += new System.EventHandler(this.buttonEditNotes_Click);
            // 
            // buttonAddNotes
            // 
            this.buttonAddNotes.Location = new System.Drawing.Point(16, 435);
            this.buttonAddNotes.Name = "buttonAddNotes";
            this.buttonAddNotes.Size = new System.Drawing.Size(75, 23);
            this.buttonAddNotes.TabIndex = 2;
            this.buttonAddNotes.Text = "Dodaj";
            this.buttonAddNotes.UseVisualStyleBackColor = true;
            this.buttonAddNotes.Click += new System.EventHandler(this.buttonAddNotes_Click);
            // 
            // dataGridViewNotes
            // 
            this.dataGridViewNotes.CausesValidation = false;
            this.dataGridViewNotes.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewNotes.Name = "dataGridViewNotes";
            this.dataGridViewNotes.ReadOnly = true;
            this.dataGridViewNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNotes.Size = new System.Drawing.Size(379, 282);
            this.dataGridViewNotes.TabIndex = 1;
            this.dataGridViewNotes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClickNotes);
            // 
            // FormWojciechLiebert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 547);
            this.Controls.Add(this.groupBoxNotes);
            this.Controls.Add(this.groupBoxStudents);
            this.Controls.Add(this.labelWojciechLiebert);
            this.Name = "FormWojciechLiebert";
            this.Text = "Wojciech Liebert";
            this.Load += new System.EventHandler(this.FormWojciechLiebert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.groupBoxStudents.ResumeLayout(false);
            this.groupBoxStudents.PerformLayout();
            this.groupBoxNotes.ResumeLayout(false);
            this.groupBoxNotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWojciechLiebert;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.GroupBox groupBoxStudents;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBoxNotes;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxIndexNotes;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelIndexNotes;
        private System.Windows.Forms.Button buttonDeleteNotes;
        private System.Windows.Forms.Button buttonEditNotes;
        private System.Windows.Forms.Button buttonAddNotes;
        private System.Windows.Forms.DataGridView dataGridViewNotes;
    }
}

