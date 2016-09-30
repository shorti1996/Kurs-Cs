namespace MouseMoveKredek
{
    partial class FormMouseMove
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
            this.buttonPaint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPaint
            // 
            this.buttonPaint.Location = new System.Drawing.Point(15, 13);
            this.buttonPaint.Name = "buttonPaint";
            this.buttonPaint.Size = new System.Drawing.Size(75, 23);
            this.buttonPaint.TabIndex = 0;
            this.buttonPaint.Text = "Rysuj";
            this.buttonPaint.UseVisualStyleBackColor = true;
            this.buttonPaint.Click += new System.EventHandler(this.buttonPaint_Click);
            // 
            // FormMouseMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonPaint);
            this.Name = "FormMouseMove";
            this.Text = "Kredek - przesuwanie myszą obiektu";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormMouseMove_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMouseMove_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPaint;
    }
}

