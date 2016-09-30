namespace KredekKeyMoves
{
    partial class KredekKeyMoves
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
            this.textBoxMove = new System.Windows.Forms.TextBox();
            this.labelInformation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPaint
            // 
            this.buttonPaint.Location = new System.Drawing.Point(12, 36);
            this.buttonPaint.Name = "buttonPaint";
            this.buttonPaint.Size = new System.Drawing.Size(75, 23);
            this.buttonPaint.TabIndex = 1;
            this.buttonPaint.Text = "Rysuj";
            this.buttonPaint.UseVisualStyleBackColor = true;
            this.buttonPaint.Click += new System.EventHandler(this.buttonPaint_Click);
            this.buttonPaint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonPaint_KeyDown);
            // 
            // textBoxMove
            // 
            this.textBoxMove.Location = new System.Drawing.Point(122, 39);
            this.textBoxMove.Name = "textBoxMove";
            this.textBoxMove.Size = new System.Drawing.Size(212, 20);
            this.textBoxMove.TabIndex = 2;
            this.textBoxMove.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMove_KeyDown);
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Location = new System.Drawing.Point(122, 13);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(223, 13);
            this.labelInformation.TabIndex = 3;
            this.labelInformation.Text = "Kliknij textBox i naciśnij strzałki na klawiaturze";
            // 
            // KredekKeyMoves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 262);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.textBoxMove);
            this.Controls.Add(this.buttonPaint);
            this.Name = "KredekKeyMoves";
            this.Text = "Ruch strzałkami button i textbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPaint;
        private System.Windows.Forms.TextBox textBoxMove;
        private System.Windows.Forms.Label labelInformation;
    }
}

