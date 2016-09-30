namespace WojciechLiebertLab1v2
{
    partial class Form1
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
            System.Windows.Forms.Label LabelName;
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            LabelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new System.Drawing.Point(12, 9);
            LabelName.Name = "LabelName";
            LabelName.Size = new System.Drawing.Size(40, 13);
            LabelName.TabIndex = 0;
            LabelName.Text = "Nazwa";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(58, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxName.Size = new System.Drawing.Size(214, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(15, 35);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(36, 13);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Hasło";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPassword.Location = new System.Drawing.Point(58, 32);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(214, 20);
            this.textBoxPassword.TabIndex = 3;
            // 
            // buttonLogin
            // 
            this.buttonLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLogin.Location = new System.Drawing.Point(58, 59);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonLogin.Size = new System.Drawing.Size(214, 52);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Zaloguj";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 120);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(LabelName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
    }
}

