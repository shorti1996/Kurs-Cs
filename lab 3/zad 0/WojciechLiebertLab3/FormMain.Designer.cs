namespace WojciechLiebertLab3
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
            this.labelWojciechLiebert = new System.Windows.Forms.Label();
            this.groupBoxPanel = new System.Windows.Forms.GroupBox();
            this.buttonShape = new System.Windows.Forms.Button();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.textBoxStartY = new System.Windows.Forms.TextBox();
            this.labelStartY = new System.Windows.Forms.Label();
            this.textBoxStartX = new System.Windows.Forms.TextBox();
            this.labelStartX = new System.Windows.Forms.Label();
            this.buttonElipseFill = new System.Windows.Forms.Button();
            this.buttonRectangleFill = new System.Windows.Forms.Button();
            this.buttonElipse = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.groupBoxProperties = new System.Windows.Forms.GroupBox();
            this.buttonTimerStart = new System.Windows.Forms.Button();
            this.textBoxShift = new System.Windows.Forms.TextBox();
            this.buttonMove = new System.Windows.Forms.Button();
            this.timerMove = new System.Windows.Forms.Timer(this.components);
            this.labelGuide = new System.Windows.Forms.Label();
            this.buttonTimerStop = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonRespawn = new System.Windows.Forms.Button();
            this.groupBoxPanel.SuspendLayout();
            this.groupBoxProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWojciechLiebert
            // 
            this.labelWojciechLiebert.AutoSize = true;
            this.labelWojciechLiebert.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWojciechLiebert.Location = new System.Drawing.Point(12, 9);
            this.labelWojciechLiebert.Name = "labelWojciechLiebert";
            this.labelWojciechLiebert.Size = new System.Drawing.Size(394, 55);
            this.labelWojciechLiebert.TabIndex = 0;
            this.labelWojciechLiebert.Text = "Wojciech Liebert";
            // 
            // groupBoxPanel
            // 
            this.groupBoxPanel.Controls.Add(this.buttonShape);
            this.groupBoxPanel.Controls.Add(this.textBoxHeight);
            this.groupBoxPanel.Controls.Add(this.labelHeight);
            this.groupBoxPanel.Controls.Add(this.textBoxWidth);
            this.groupBoxPanel.Controls.Add(this.labelWidth);
            this.groupBoxPanel.Controls.Add(this.textBoxStartY);
            this.groupBoxPanel.Controls.Add(this.labelStartY);
            this.groupBoxPanel.Controls.Add(this.textBoxStartX);
            this.groupBoxPanel.Controls.Add(this.labelStartX);
            this.groupBoxPanel.Controls.Add(this.buttonElipseFill);
            this.groupBoxPanel.Controls.Add(this.buttonRectangleFill);
            this.groupBoxPanel.Controls.Add(this.buttonElipse);
            this.groupBoxPanel.Controls.Add(this.buttonRectangle);
            this.groupBoxPanel.Location = new System.Drawing.Point(22, 68);
            this.groupBoxPanel.Name = "groupBoxPanel";
            this.groupBoxPanel.Size = new System.Drawing.Size(303, 171);
            this.groupBoxPanel.TabIndex = 1;
            this.groupBoxPanel.TabStop = false;
            this.groupBoxPanel.Text = "Panel";
            // 
            // buttonShape
            // 
            this.buttonShape.Location = new System.Drawing.Point(168, 19);
            this.buttonShape.Name = "buttonShape";
            this.buttonShape.Size = new System.Drawing.Size(75, 23);
            this.buttonShape.TabIndex = 12;
            this.buttonShape.Text = "Kształt";
            this.buttonShape.UseVisualStyleBackColor = true;
            this.buttonShape.Click += new System.EventHandler(this.buttonShape_Click);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(112, 143);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeight.TabIndex = 11;
            this.textBoxHeight.Text = "100";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(113, 126);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(57, 13);
            this.labelHeight.TabIndex = 10;
            this.labelHeight.Text = "Wysokość";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(6, 143);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(100, 20);
            this.textBoxWidth.TabIndex = 9;
            this.textBoxWidth.Text = "100";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(7, 126);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(57, 13);
            this.labelWidth.TabIndex = 8;
            this.labelWidth.Text = "Szerokość";
            // 
            // textBoxStartY
            // 
            this.textBoxStartY.Location = new System.Drawing.Point(112, 103);
            this.textBoxStartY.Name = "textBoxStartY";
            this.textBoxStartY.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartY.TabIndex = 7;
            this.textBoxStartY.Text = "250";
            // 
            // labelStartY
            // 
            this.labelStartY.AutoSize = true;
            this.labelStartY.Location = new System.Drawing.Point(113, 86);
            this.labelStartY.Name = "labelStartY";
            this.labelStartY.Size = new System.Drawing.Size(39, 13);
            this.labelStartY.TabIndex = 6;
            this.labelStartY.Text = "Start Y";
            // 
            // textBoxStartX
            // 
            this.textBoxStartX.Location = new System.Drawing.Point(6, 103);
            this.textBoxStartX.Name = "textBoxStartX";
            this.textBoxStartX.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartX.TabIndex = 5;
            this.textBoxStartX.Text = "250";
            // 
            // labelStartX
            // 
            this.labelStartX.AutoSize = true;
            this.labelStartX.Location = new System.Drawing.Point(7, 86);
            this.labelStartX.Name = "labelStartX";
            this.labelStartX.Size = new System.Drawing.Size(39, 13);
            this.labelStartX.TabIndex = 4;
            this.labelStartX.Text = "Start X";
            // 
            // buttonElipseFill
            // 
            this.buttonElipseFill.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonElipseFill.Location = new System.Drawing.Point(87, 56);
            this.buttonElipseFill.Name = "buttonElipseFill";
            this.buttonElipseFill.Size = new System.Drawing.Size(75, 23);
            this.buttonElipseFill.TabIndex = 3;
            this.buttonElipseFill.Text = "Elipsa";
            this.buttonElipseFill.UseVisualStyleBackColor = false;
            this.buttonElipseFill.Click += new System.EventHandler(this.buttonElipseFill_Click);
            // 
            // buttonRectangleFill
            // 
            this.buttonRectangleFill.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRectangleFill.Location = new System.Drawing.Point(6, 56);
            this.buttonRectangleFill.Name = "buttonRectangleFill";
            this.buttonRectangleFill.Size = new System.Drawing.Size(75, 23);
            this.buttonRectangleFill.TabIndex = 2;
            this.buttonRectangleFill.Text = "Prostokąt";
            this.buttonRectangleFill.UseVisualStyleBackColor = false;
            this.buttonRectangleFill.Click += new System.EventHandler(this.buttonRectangleFill_Click);
            // 
            // buttonElipse
            // 
            this.buttonElipse.Location = new System.Drawing.Point(87, 19);
            this.buttonElipse.Name = "buttonElipse";
            this.buttonElipse.Size = new System.Drawing.Size(75, 23);
            this.buttonElipse.TabIndex = 1;
            this.buttonElipse.Text = "Elipsa";
            this.buttonElipse.UseVisualStyleBackColor = true;
            this.buttonElipse.Click += new System.EventHandler(this.buttonElipse_Click);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.Location = new System.Drawing.Point(6, 19);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(75, 23);
            this.buttonRectangle.TabIndex = 0;
            this.buttonRectangle.Text = "Prostokąt";
            this.buttonRectangle.UseVisualStyleBackColor = true;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // groupBoxProperties
            // 
            this.groupBoxProperties.Controls.Add(this.buttonRespawn);
            this.groupBoxProperties.Controls.Add(this.buttonClear);
            this.groupBoxProperties.Controls.Add(this.buttonTimerStop);
            this.groupBoxProperties.Controls.Add(this.buttonTimerStart);
            this.groupBoxProperties.Controls.Add(this.textBoxShift);
            this.groupBoxProperties.Controls.Add(this.buttonMove);
            this.groupBoxProperties.Location = new System.Drawing.Point(331, 68);
            this.groupBoxProperties.Name = "groupBoxProperties";
            this.groupBoxProperties.Size = new System.Drawing.Size(368, 78);
            this.groupBoxProperties.TabIndex = 2;
            this.groupBoxProperties.TabStop = false;
            this.groupBoxProperties.Text = "Właściwości";
            // 
            // buttonTimerStart
            // 
            this.buttonTimerStart.Location = new System.Drawing.Point(7, 47);
            this.buttonTimerStart.Name = "buttonTimerStart";
            this.buttonTimerStart.Size = new System.Drawing.Size(75, 23);
            this.buttonTimerStart.TabIndex = 2;
            this.buttonTimerStart.Text = "TimerStart";
            this.buttonTimerStart.UseVisualStyleBackColor = true;
            this.buttonTimerStart.Click += new System.EventHandler(this.buttonTimerStart_Click);
            // 
            // textBoxShift
            // 
            this.textBoxShift.Location = new System.Drawing.Point(89, 20);
            this.textBoxShift.Name = "textBoxShift";
            this.textBoxShift.Size = new System.Drawing.Size(100, 20);
            this.textBoxShift.TabIndex = 1;
            this.textBoxShift.Text = "5";
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(7, 18);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(75, 23);
            this.buttonMove.TabIndex = 0;
            this.buttonMove.Text = "Przesuń";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timerMove
            // 
            this.timerMove.Interval = 20;
            this.timerMove.Tick += new System.EventHandler(this.timerMove_Tick);
            // 
            // labelGuide
            // 
            this.labelGuide.AutoSize = true;
            this.labelGuide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGuide.Location = new System.Drawing.Point(412, 33);
            this.labelGuide.Name = "labelGuide";
            this.labelGuide.Size = new System.Drawing.Size(287, 25);
            this.labelGuide.TabIndex = 3;
            this.labelGuide.Text = "Press Z and  X keys to move";
            // 
            // buttonTimerStop
            // 
            this.buttonTimerStop.Location = new System.Drawing.Point(89, 46);
            this.buttonTimerStop.Name = "buttonTimerStop";
            this.buttonTimerStop.Size = new System.Drawing.Size(75, 23);
            this.buttonTimerStop.TabIndex = 3;
            this.buttonTimerStop.Text = "TimerStop";
            this.buttonTimerStop.UseVisualStyleBackColor = true;
            this.buttonTimerStop.Click += new System.EventHandler(this.buttonTimerStop_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(287, 17);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Wyczyść";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonRespawn
            // 
            this.buttonRespawn.Location = new System.Drawing.Point(257, 46);
            this.buttonRespawn.Name = "buttonRespawn";
            this.buttonRespawn.Size = new System.Drawing.Size(105, 23);
            this.buttonRespawn.TabIndex = 5;
            this.buttonRespawn.Text = "Cofnij przesunięcie";
            this.buttonRespawn.UseVisualStyleBackColor = true;
            this.buttonRespawn.Click += new System.EventHandler(this.buttonRespawn_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 550);
            this.Controls.Add(this.labelGuide);
            this.Controls.Add(this.groupBoxProperties);
            this.Controls.Add(this.groupBoxPanel);
            this.Controls.Add(this.labelWojciechLiebert);
            this.Name = "FormMain";
            this.Text = "Kształty";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressed);
            this.groupBoxPanel.ResumeLayout(false);
            this.groupBoxPanel.PerformLayout();
            this.groupBoxProperties.ResumeLayout(false);
            this.groupBoxProperties.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWojciechLiebert;
        private System.Windows.Forms.GroupBox groupBoxPanel;
        private System.Windows.Forms.Button buttonElipse;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.Button buttonElipseFill;
        private System.Windows.Forms.Button buttonRectangleFill;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.TextBox textBoxStartY;
        private System.Windows.Forms.Label labelStartY;
        private System.Windows.Forms.TextBox textBoxStartX;
        private System.Windows.Forms.Label labelStartX;
        private System.Windows.Forms.Button buttonShape;
        private System.Windows.Forms.GroupBox groupBoxProperties;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.TextBox textBoxShift;
        private System.Windows.Forms.Button buttonTimerStart;
        private System.Windows.Forms.Timer timerMove;
        private System.Windows.Forms.Label labelGuide;
        private System.Windows.Forms.Button buttonTimerStop;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRespawn;
    }
}

