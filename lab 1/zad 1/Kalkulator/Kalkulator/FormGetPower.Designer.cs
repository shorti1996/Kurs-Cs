namespace Kalkulator
{
    partial class FormGetPower
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
            this.textBoxReal = new System.Windows.Forms.TextBox();
            this.textBoxImaginary = new System.Windows.Forms.TextBox();
            this.labelReal = new System.Windows.Forms.Label();
            this.labelImaginary = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxReal
            // 
            this.textBoxReal.Location = new System.Drawing.Point(12, 28);
            this.textBoxReal.Name = "textBoxReal";
            this.textBoxReal.Size = new System.Drawing.Size(100, 20);
            this.textBoxReal.TabIndex = 0;
            this.textBoxReal.TextChanged += new System.EventHandler(this.textBoxReal_TextChanged);
            // 
            // textBoxImaginary
            // 
            this.textBoxImaginary.Location = new System.Drawing.Point(128, 28);
            this.textBoxImaginary.Name = "textBoxImaginary";
            this.textBoxImaginary.Size = new System.Drawing.Size(100, 20);
            this.textBoxImaginary.TabIndex = 1;
            // 
            // labelReal
            // 
            this.labelReal.AutoSize = true;
            this.labelReal.Location = new System.Drawing.Point(12, 9);
            this.labelReal.Name = "labelReal";
            this.labelReal.Size = new System.Drawing.Size(29, 13);
            this.labelReal.TabIndex = 2;
            this.labelReal.Text = "Real";
            // 
            // labelImaginary
            // 
            this.labelImaginary.AutoSize = true;
            this.labelImaginary.Location = new System.Drawing.Point(128, 9);
            this.labelImaginary.Name = "labelImaginary";
            this.labelImaginary.Size = new System.Drawing.Size(52, 13);
            this.labelImaginary.TabIndex = 3;
            this.labelImaginary.Text = "Imaginary";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(12, 65);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormGetPower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 107);
            this.ControlBox = false;
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelImaginary);
            this.Controls.Add(this.labelReal);
            this.Controls.Add(this.textBoxImaginary);
            this.Controls.Add(this.textBoxReal);
            this.Name = "FormGetPower";
            this.Text = "Power";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxReal;
        private System.Windows.Forms.TextBox textBoxImaginary;
        private System.Windows.Forms.Label labelReal;
        private System.Windows.Forms.Label labelImaginary;
        private System.Windows.Forms.Button buttonOK;
    }
}