namespace WojciechLiebertEgz0
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
            this.components = new System.ComponentModel.Container();
            this.textBoxB1 = new System.Windows.Forms.TextBox();
            this.labelB1 = new System.Windows.Forms.Label();
            this.buttonB1 = new System.Windows.Forms.Button();
            this.richTextBoxTriangle = new System.Windows.Forms.RichTextBox();
            this.buttonB2 = new System.Windows.Forms.Button();
            this.textBoxTriangleN = new System.Windows.Forms.TextBox();
            this.labelTriangleN = new System.Windows.Forms.Label();
            this.progressBarB3 = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.buttonB3 = new System.Windows.Forms.Button();
            this.timerB3 = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewB4Egzaminator = new System.Windows.Forms.DataGridView();
            this.labelB4 = new System.Windows.Forms.Label();
            this.dataGridViewB4Test = new System.Windows.Forms.DataGridView();
            this.buttonB4Show = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB4Egzaminator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB4Test)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxB1
            // 
            this.textBoxB1.Location = new System.Drawing.Point(12, 55);
            this.textBoxB1.Name = "textBoxB1";
            this.textBoxB1.Size = new System.Drawing.Size(228, 22);
            this.textBoxB1.TabIndex = 0;
            // 
            // labelB1
            // 
            this.labelB1.AutoSize = true;
            this.labelB1.Location = new System.Drawing.Point(12, 32);
            this.labelB1.Name = "labelB1";
            this.labelB1.Size = new System.Drawing.Size(54, 17);
            this.labelB1.TabIndex = 1;
            this.labelB1.Text = "ilość @";
            // 
            // buttonB1
            // 
            this.buttonB1.Location = new System.Drawing.Point(12, 83);
            this.buttonB1.Name = "buttonB1";
            this.buttonB1.Size = new System.Drawing.Size(97, 23);
            this.buttonB1.TabIndex = 2;
            this.buttonB1.Text = "B.1 Policz";
            this.buttonB1.UseVisualStyleBackColor = true;
            this.buttonB1.Click += new System.EventHandler(this.B1_Policz_Click);
            // 
            // richTextBoxTriangle
            // 
            this.richTextBoxTriangle.Location = new System.Drawing.Point(288, 84);
            this.richTextBoxTriangle.Name = "richTextBoxTriangle";
            this.richTextBoxTriangle.Size = new System.Drawing.Size(238, 226);
            this.richTextBoxTriangle.TabIndex = 3;
            this.richTextBoxTriangle.Text = "";
            // 
            // buttonB2
            // 
            this.buttonB2.Location = new System.Drawing.Point(288, 316);
            this.buttonB2.Name = "buttonB2";
            this.buttonB2.Size = new System.Drawing.Size(89, 23);
            this.buttonB2.TabIndex = 4;
            this.buttonB2.Text = "B.2 Trójkąt";
            this.buttonB2.UseVisualStyleBackColor = true;
            this.buttonB2.Click += new System.EventHandler(this.buttonB2_Click);
            // 
            // textBoxTriangleN
            // 
            this.textBoxTriangleN.Location = new System.Drawing.Point(288, 55);
            this.textBoxTriangleN.Name = "textBoxTriangleN";
            this.textBoxTriangleN.Size = new System.Drawing.Size(100, 22);
            this.textBoxTriangleN.TabIndex = 5;
            // 
            // labelTriangleN
            // 
            this.labelTriangleN.AutoSize = true;
            this.labelTriangleN.Location = new System.Drawing.Point(288, 32);
            this.labelTriangleN.Name = "labelTriangleN";
            this.labelTriangleN.Size = new System.Drawing.Size(111, 17);
            this.labelTriangleN.TabIndex = 6;
            this.labelTriangleN.Text = "wielkość trójkąta";
            // 
            // progressBarB3
            // 
            this.progressBarB3.Location = new System.Drawing.Point(567, 136);
            this.progressBarB3.Name = "progressBarB3";
            this.progressBarB3.Size = new System.Drawing.Size(329, 23);
            this.progressBarB3.Step = 6;
            this.progressBarB3.TabIndex = 7;
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(567, 31);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(46, 17);
            this.labelProgress.TabIndex = 8;
            this.labelProgress.Text = "label1";
            // 
            // buttonB3
            // 
            this.buttonB3.Location = new System.Drawing.Point(570, 193);
            this.buttonB3.Name = "buttonB3";
            this.buttonB3.Size = new System.Drawing.Size(143, 23);
            this.buttonB3.TabIndex = 9;
            this.buttonB3.Text = "B.3 Pasek postępu";
            this.buttonB3.UseVisualStyleBackColor = true;
            this.buttonB3.Click += new System.EventHandler(this.buttonB3_Click);
            // 
            // timerB3
            // 
            this.timerB3.Interval = 1000;
            this.timerB3.Tick += new System.EventHandler(this.timerB3_Tick);
            // 
            // dataGridViewB4Egzaminator
            // 
            this.dataGridViewB4Egzaminator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewB4Egzaminator.Location = new System.Drawing.Point(15, 361);
            this.dataGridViewB4Egzaminator.Name = "dataGridViewB4Egzaminator";
            this.dataGridViewB4Egzaminator.RowTemplate.Height = 24;
            this.dataGridViewB4Egzaminator.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewB4Egzaminator.TabIndex = 10;
            // 
            // labelB4
            // 
            this.labelB4.AutoSize = true;
            this.labelB4.Location = new System.Drawing.Point(12, 338);
            this.labelB4.Name = "labelB4";
            this.labelB4.Size = new System.Drawing.Size(25, 17);
            this.labelB4.TabIndex = 11;
            this.labelB4.Text = "B4";
            // 
            // dataGridViewB4Test
            // 
            this.dataGridViewB4Test.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewB4Test.Location = new System.Drawing.Point(262, 361);
            this.dataGridViewB4Test.Name = "dataGridViewB4Test";
            this.dataGridViewB4Test.RowTemplate.Height = 24;
            this.dataGridViewB4Test.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewB4Test.TabIndex = 12;
            // 
            // buttonB4Show
            // 
            this.buttonB4Show.Location = new System.Drawing.Point(15, 528);
            this.buttonB4Show.Name = "buttonB4Show";
            this.buttonB4Show.Size = new System.Drawing.Size(75, 23);
            this.buttonB4Show.TabIndex = 13;
            this.buttonB4Show.Text = "B.4";
            this.buttonB4Show.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 645);
            this.Controls.Add(this.buttonB4Show);
            this.Controls.Add(this.dataGridViewB4Test);
            this.Controls.Add(this.labelB4);
            this.Controls.Add(this.dataGridViewB4Egzaminator);
            this.Controls.Add(this.buttonB3);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.progressBarB3);
            this.Controls.Add(this.labelTriangleN);
            this.Controls.Add(this.textBoxTriangleN);
            this.Controls.Add(this.buttonB2);
            this.Controls.Add(this.richTextBoxTriangle);
            this.Controls.Add(this.buttonB1);
            this.Controls.Add(this.labelB1);
            this.Controls.Add(this.textBoxB1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB4Egzaminator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewB4Test)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxB1;
        private System.Windows.Forms.Label labelB1;
        private System.Windows.Forms.Button buttonB1;
        private System.Windows.Forms.RichTextBox richTextBoxTriangle;
        private System.Windows.Forms.Button buttonB2;
        private System.Windows.Forms.TextBox textBoxTriangleN;
        private System.Windows.Forms.Label labelTriangleN;
        private System.Windows.Forms.ProgressBar progressBarB3;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.Button buttonB3;
        private System.Windows.Forms.Timer timerB3;
        private System.Windows.Forms.DataGridView dataGridViewB4Egzaminator;
        private System.Windows.Forms.Label labelB4;
        private System.Windows.Forms.DataGridView dataGridViewB4Test;
        private System.Windows.Forms.Button buttonB4Show;
    }
}

