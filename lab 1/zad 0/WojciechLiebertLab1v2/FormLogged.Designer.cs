namespace WojciechLiebertLab1v2
{
    partial class FormLogged
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
            this.labelCounter = new System.Windows.Forms.Label();
            this.textBoxCounter = new System.Windows.Forms.TextBox();
            this.buttonCount = new System.Windows.Forms.Button();
            this.TextBoxSpace = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelCounter
            // 
            this.labelCounter.AutoSize = true;
            this.labelCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCounter.Location = new System.Drawing.Point(44, 34);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(57, 20);
            this.labelCounter.TabIndex = 0;
            this.labelCounter.Text = "Licznik";
            // 
            // textBoxCounter
            // 
            this.textBoxCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCounter.Location = new System.Drawing.Point(125, 31);
            this.textBoxCounter.Name = "textBoxCounter";
            this.textBoxCounter.Size = new System.Drawing.Size(107, 26);
            this.textBoxCounter.TabIndex = 1;
            this.textBoxCounter.Text = "5";
            this.textBoxCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonCount
            // 
            this.buttonCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCount.Location = new System.Drawing.Point(125, 63);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(107, 41);
            this.buttonCount.TabIndex = 2;
            this.buttonCount.Text = "Licznik";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // TextBoxSpace
            // 
            this.TextBoxSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxSpace.Location = new System.Drawing.Point(37, 110);
            this.TextBoxSpace.Multiline = true;
            this.TextBoxSpace.Name = "TextBoxSpace";
            this.TextBoxSpace.Size = new System.Drawing.Size(195, 173);
            this.TextBoxSpace.TabIndex = 3;
            this.TextBoxSpace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxSpace.TextChanged += new System.EventHandler(this.Space_TextChanged);
            // 
            // FormLogged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 311);
            this.Controls.Add(this.TextBoxSpace);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.textBoxCounter);
            this.Controls.Add(this.labelCounter);
            this.Name = "FormLogged";
            this.Text = "FormLogged";
            this.Load += new System.EventHandler(this.FormLogged_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.TextBox textBoxCounter;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.TextBox TextBoxSpace;
    }
}