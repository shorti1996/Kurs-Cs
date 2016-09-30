namespace Kalkulator
{
    partial class Form2
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
            this.textBoxRe1 = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.labelRe1 = new System.Windows.Forms.Label();
            this.comboBoxOperations = new System.Windows.Forms.ComboBox();
            this.labelIm1 = new System.Windows.Forms.Label();
            this.labelRe2 = new System.Windows.Forms.Label();
            this.labelIm2 = new System.Windows.Forms.Label();
            this.textBoxIm1 = new System.Windows.Forms.TextBox();
            this.textBoxRe2 = new System.Windows.Forms.TextBox();
            this.textBoxIm2 = new System.Windows.Forms.TextBox();
            this.buttonKeySolve = new System.Windows.Forms.Button();
            this.buttonKeyCE = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPower = new System.Windows.Forms.Button();
            this.buttonPhase = new System.Windows.Forms.Button();
            this.labelOperationsOnC1 = new System.Windows.Forms.Label();
            this.buttonKeyMagnitude = new System.Windows.Forms.Button();
            this.labelComplex1Plus = new System.Windows.Forms.Label();
            this.labelComplex2Plus = new System.Windows.Forms.Label();
            this.labelComplex1i = new System.Windows.Forms.Label();
            this.labelComplex2i = new System.Windows.Forms.Label();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxRe1
            // 
            this.textBoxRe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxRe1.Location = new System.Drawing.Point(3, 47);
            this.textBoxRe1.Name = "textBoxRe1";
            this.textBoxRe1.Size = new System.Drawing.Size(128, 26);
            this.textBoxRe1.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(3, 3);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 25);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 4;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelMain.Controls.Add(this.labelRe1, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonBack, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.comboBoxOperations, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxRe1, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.labelRe2, 0, 4);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxRe2, 0, 5);
            this.tableLayoutPanelMain.Controls.Add(this.buttonKeySolve, 0, 6);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxIm1, 2, 2);
            this.tableLayoutPanelMain.Controls.Add(this.labelIm1, 2, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonKeyCE, 2, 0);
            this.tableLayoutPanelMain.Controls.Add(this.labelIm2, 2, 4);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxIm2, 2, 5);
            this.tableLayoutPanelMain.Controls.Add(this.labelComplex1Plus, 1, 2);
            this.tableLayoutPanelMain.Controls.Add(this.labelComplex2Plus, 1, 5);
            this.tableLayoutPanelMain.Controls.Add(this.labelComplex1i, 3, 2);
            this.tableLayoutPanelMain.Controls.Add(this.labelComplex2i, 3, 5);
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 8;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(375, 197);
            this.tableLayoutPanelMain.TabIndex = 2;
            // 
            // labelRe1
            // 
            this.labelRe1.AutoSize = true;
            this.labelRe1.Location = new System.Drawing.Point(3, 31);
            this.labelRe1.Name = "labelRe1";
            this.labelRe1.Size = new System.Drawing.Size(29, 13);
            this.labelRe1.TabIndex = 3;
            this.labelRe1.Text = "Real";
            // 
            // comboBoxOperations
            // 
            this.comboBoxOperations.FormattingEnabled = true;
            this.comboBoxOperations.Items.AddRange(new object[] {
            "Add",
            "Substract",
            "Multiply",
            "Divide"});
            this.comboBoxOperations.Location = new System.Drawing.Point(3, 79);
            this.comboBoxOperations.Name = "comboBoxOperations";
            this.comboBoxOperations.Size = new System.Drawing.Size(113, 21);
            this.comboBoxOperations.TabIndex = 6;
            // 
            // labelIm1
            // 
            this.labelIm1.AutoSize = true;
            this.labelIm1.Location = new System.Drawing.Point(183, 31);
            this.labelIm1.Name = "labelIm1";
            this.labelIm1.Size = new System.Drawing.Size(52, 13);
            this.labelIm1.TabIndex = 4;
            this.labelIm1.Text = "Imaginary";
            // 
            // labelRe2
            // 
            this.labelRe2.AutoSize = true;
            this.labelRe2.Location = new System.Drawing.Point(3, 103);
            this.labelRe2.Name = "labelRe2";
            this.labelRe2.Size = new System.Drawing.Size(29, 13);
            this.labelRe2.TabIndex = 5;
            this.labelRe2.Text = "Real";
            // 
            // labelIm2
            // 
            this.labelIm2.AutoSize = true;
            this.labelIm2.Location = new System.Drawing.Point(183, 103);
            this.labelIm2.Name = "labelIm2";
            this.labelIm2.Size = new System.Drawing.Size(52, 13);
            this.labelIm2.TabIndex = 6;
            this.labelIm2.Text = "Imaginary";
            // 
            // textBoxIm1
            // 
            this.textBoxIm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxIm1.Location = new System.Drawing.Point(183, 47);
            this.textBoxIm1.Name = "textBoxIm1";
            this.textBoxIm1.Size = new System.Drawing.Size(128, 26);
            this.textBoxIm1.TabIndex = 7;
            // 
            // textBoxRe2
            // 
            this.textBoxRe2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxRe2.Location = new System.Drawing.Point(3, 119);
            this.textBoxRe2.Name = "textBoxRe2";
            this.textBoxRe2.Size = new System.Drawing.Size(128, 26);
            this.textBoxRe2.TabIndex = 8;
            // 
            // textBoxIm2
            // 
            this.textBoxIm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxIm2.Location = new System.Drawing.Point(183, 119);
            this.textBoxIm2.Name = "textBoxIm2";
            this.textBoxIm2.Size = new System.Drawing.Size(128, 26);
            this.textBoxIm2.TabIndex = 9;
            // 
            // buttonKeySolve
            // 
            this.buttonKeySolve.Location = new System.Drawing.Point(3, 151);
            this.buttonKeySolve.Name = "buttonKeySolve";
            this.buttonKeySolve.Size = new System.Drawing.Size(75, 25);
            this.buttonKeySolve.TabIndex = 10;
            this.buttonKeySolve.Text = "Solve";
            this.buttonKeySolve.UseVisualStyleBackColor = true;
            this.buttonKeySolve.Click += new System.EventHandler(this.buttonKeySolve_Click);
            // 
            // buttonKeyCE
            // 
            this.buttonKeyCE.Location = new System.Drawing.Point(183, 3);
            this.buttonKeyCE.Name = "buttonKeyCE";
            this.buttonKeyCE.Size = new System.Drawing.Size(75, 25);
            this.buttonKeyCE.TabIndex = 12;
            this.buttonKeyCE.Text = "CE";
            this.buttonKeyCE.UseVisualStyleBackColor = true;
            this.buttonKeyCE.Click += new System.EventHandler(this.buttonKeyCE_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxResult.Location = new System.Drawing.Point(12, 215);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(375, 27);
            this.textBoxResult.TabIndex = 11;
            this.textBoxResult.Text = "Result";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.buttonPower, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttonPhase, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelOperationsOnC1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonKeyMagnitude, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(407, 15);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(82, 227);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // buttonPower
            // 
            this.buttonPower.Location = new System.Drawing.Point(3, 87);
            this.buttonPower.Name = "buttonPower";
            this.buttonPower.Size = new System.Drawing.Size(75, 23);
            this.buttonPower.TabIndex = 2;
            this.buttonPower.Text = "Power";
            this.buttonPower.UseVisualStyleBackColor = true;
            this.buttonPower.Click += new System.EventHandler(this.buttonPower_Click);
            // 
            // buttonPhase
            // 
            this.buttonPhase.Location = new System.Drawing.Point(3, 58);
            this.buttonPhase.Name = "buttonPhase";
            this.buttonPhase.Size = new System.Drawing.Size(75, 23);
            this.buttonPhase.TabIndex = 1;
            this.buttonPhase.Text = "Phase";
            this.buttonPhase.UseVisualStyleBackColor = true;
            this.buttonPhase.Click += new System.EventHandler(this.buttonPhase_Click);
            // 
            // labelOperationsOnC1
            // 
            this.labelOperationsOnC1.AutoSize = true;
            this.labelOperationsOnC1.Location = new System.Drawing.Point(3, 0);
            this.labelOperationsOnC1.Name = "labelOperationsOnC1";
            this.labelOperationsOnC1.Size = new System.Drawing.Size(76, 26);
            this.labelOperationsOnC1.TabIndex = 3;
            this.labelOperationsOnC1.Text = "Operations on Complex1";
            // 
            // buttonKeyMagnitude
            // 
            this.buttonKeyMagnitude.Location = new System.Drawing.Point(3, 29);
            this.buttonKeyMagnitude.Name = "buttonKeyMagnitude";
            this.buttonKeyMagnitude.Size = new System.Drawing.Size(75, 23);
            this.buttonKeyMagnitude.TabIndex = 0;
            this.buttonKeyMagnitude.Text = "Magnitude";
            this.buttonKeyMagnitude.UseVisualStyleBackColor = true;
            this.buttonKeyMagnitude.Click += new System.EventHandler(this.buttonKeyMagnitude_Click);
            // 
            // labelComplex1Plus
            // 
            this.labelComplex1Plus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelComplex1Plus.AutoSize = true;
            this.labelComplex1Plus.Location = new System.Drawing.Point(158, 53);
            this.labelComplex1Plus.Name = "labelComplex1Plus";
            this.labelComplex1Plus.Size = new System.Drawing.Size(13, 13);
            this.labelComplex1Plus.TabIndex = 13;
            this.labelComplex1Plus.Text = "+";
            // 
            // labelComplex2Plus
            // 
            this.labelComplex2Plus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelComplex2Plus.AutoSize = true;
            this.labelComplex2Plus.Location = new System.Drawing.Point(158, 125);
            this.labelComplex2Plus.Name = "labelComplex2Plus";
            this.labelComplex2Plus.Size = new System.Drawing.Size(13, 13);
            this.labelComplex2Plus.TabIndex = 14;
            this.labelComplex2Plus.Text = "+";
            // 
            // labelComplex1i
            // 
            this.labelComplex1i.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelComplex1i.AutoSize = true;
            this.labelComplex1i.Location = new System.Drawing.Point(319, 53);
            this.labelComplex1i.Name = "labelComplex1i";
            this.labelComplex1i.Size = new System.Drawing.Size(9, 13);
            this.labelComplex1i.TabIndex = 15;
            this.labelComplex1i.Text = "i";
            // 
            // labelComplex2i
            // 
            this.labelComplex2i.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelComplex2i.AutoSize = true;
            this.labelComplex2i.Location = new System.Drawing.Point(319, 125);
            this.labelComplex2i.Name = "labelComplex2i";
            this.labelComplex2i.Size = new System.Drawing.Size(9, 13);
            this.labelComplex2i.TabIndex = 16;
            this.labelComplex2i.Text = "i";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 250);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.textBoxResult);
            this.Name = "Form2";
            this.Text = "Complex Calculator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRe1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Label labelRe1;
        private System.Windows.Forms.ComboBox comboBoxOperations;
        private System.Windows.Forms.Label labelIm1;
        private System.Windows.Forms.Label labelRe2;
        private System.Windows.Forms.Label labelIm2;
        private System.Windows.Forms.TextBox textBoxIm1;
        private System.Windows.Forms.TextBox textBoxRe2;
        private System.Windows.Forms.TextBox textBoxIm2;
        private System.Windows.Forms.Button buttonKeySolve;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonKeyCE;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonPower;
        private System.Windows.Forms.Button buttonPhase;
        private System.Windows.Forms.Label labelOperationsOnC1;
        private System.Windows.Forms.Button buttonKeyMagnitude;
        private System.Windows.Forms.Label labelComplex1Plus;
        private System.Windows.Forms.Label labelComplex2Plus;
        private System.Windows.Forms.Label labelComplex1i;
        private System.Windows.Forms.Label labelComplex2i;
    }
}