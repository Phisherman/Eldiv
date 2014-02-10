namespace Eldiv
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.timerLoop = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonRectangle = new System.Windows.Forms.RadioButton();
            this.radioButtonEllipse = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonUnfilled = new System.Windows.Forms.RadioButton();
            this.radioButtonFilled = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxShowPrimitiveCounter = new System.Windows.Forms.CheckBox();
            this.checkBoxRandomChanging = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.Color.White;
            this.pictureBoxMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxMain.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(664, 671);
            this.pictureBoxMain.TabIndex = 0;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxMain_Paint);
            this.pictureBoxMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseDown);
            this.pictureBoxMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseMove);
            this.pictureBoxMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseUp);
            // 
            // timerLoop
            // 
            this.timerLoop.Enabled = true;
            this.timerLoop.Interval = 20;
            this.timerLoop.Tick += new System.EventHandler(this.timerLoop_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonRectangle);
            this.groupBox1.Controls.Add(this.radioButtonEllipse);
            this.groupBox1.Location = new System.Drawing.Point(678, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form";
            // 
            // radioButtonRectangle
            // 
            this.radioButtonRectangle.AutoSize = true;
            this.radioButtonRectangle.Location = new System.Drawing.Point(8, 44);
            this.radioButtonRectangle.Name = "radioButtonRectangle";
            this.radioButtonRectangle.Size = new System.Drawing.Size(72, 17);
            this.radioButtonRectangle.TabIndex = 1;
            this.radioButtonRectangle.Text = "Rechteck";
            this.radioButtonRectangle.UseVisualStyleBackColor = true;
            this.radioButtonRectangle.CheckedChanged += new System.EventHandler(this.radioButtonRectangle_CheckedChanged);
            // 
            // radioButtonEllipse
            // 
            this.radioButtonEllipse.AutoSize = true;
            this.radioButtonEllipse.Checked = true;
            this.radioButtonEllipse.Location = new System.Drawing.Point(8, 20);
            this.radioButtonEllipse.Name = "radioButtonEllipse";
            this.radioButtonEllipse.Size = new System.Drawing.Size(55, 17);
            this.radioButtonEllipse.TabIndex = 0;
            this.radioButtonEllipse.TabStop = true;
            this.radioButtonEllipse.Text = "Ellipse";
            this.radioButtonEllipse.UseVisualStyleBackColor = true;
            this.radioButtonEllipse.CheckedChanged += new System.EventHandler(this.radioButtonEllipse_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonUnfilled);
            this.groupBox2.Controls.Add(this.radioButtonFilled);
            this.groupBox2.Location = new System.Drawing.Point(678, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 71);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zeichenstil";
            // 
            // radioButtonUnfilled
            // 
            this.radioButtonUnfilled.AutoSize = true;
            this.radioButtonUnfilled.Location = new System.Drawing.Point(7, 44);
            this.radioButtonUnfilled.Name = "radioButtonUnfilled";
            this.radioButtonUnfilled.Size = new System.Drawing.Size(67, 17);
            this.radioButtonUnfilled.TabIndex = 1;
            this.radioButtonUnfilled.Text = "Ungefüllt";
            this.radioButtonUnfilled.UseVisualStyleBackColor = true;
            this.radioButtonUnfilled.CheckedChanged += new System.EventHandler(this.radioButtonUnfilled_CheckedChanged);
            // 
            // radioButtonFilled
            // 
            this.radioButtonFilled.AutoSize = true;
            this.radioButtonFilled.Checked = true;
            this.radioButtonFilled.Location = new System.Drawing.Point(7, 20);
            this.radioButtonFilled.Name = "radioButtonFilled";
            this.radioButtonFilled.Size = new System.Drawing.Size(55, 17);
            this.radioButtonFilled.TabIndex = 0;
            this.radioButtonFilled.TabStop = true;
            this.radioButtonFilled.Text = "Gefüllt";
            this.radioButtonFilled.UseVisualStyleBackColor = true;
            this.radioButtonFilled.CheckedChanged += new System.EventHandler(this.radioButtonFilled_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxShowPrimitiveCounter);
            this.groupBox3.Controls.Add(this.checkBoxRandomChanging);
            this.groupBox3.Location = new System.Drawing.Point(678, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(138, 72);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sonstiges";
            // 
            // checkBoxShowPrimitiveCounter
            // 
            this.checkBoxShowPrimitiveCounter.AutoSize = true;
            this.checkBoxShowPrimitiveCounter.Location = new System.Drawing.Point(8, 44);
            this.checkBoxShowPrimitiveCounter.Name = "checkBoxShowPrimitiveCounter";
            this.checkBoxShowPrimitiveCounter.Size = new System.Drawing.Size(99, 17);
            this.checkBoxShowPrimitiveCounter.TabIndex = 1;
            this.checkBoxShowPrimitiveCounter.Text = "Primitivenzähler";
            this.checkBoxShowPrimitiveCounter.UseVisualStyleBackColor = true;
            this.checkBoxShowPrimitiveCounter.CheckedChanged += new System.EventHandler(this.checkBoxShowParticleCounter_CheckedChanged);
            // 
            // checkBoxRandomChanging
            // 
            this.checkBoxRandomChanging.AutoSize = true;
            this.checkBoxRandomChanging.Location = new System.Drawing.Point(8, 20);
            this.checkBoxRandomChanging.Name = "checkBoxRandomChanging";
            this.checkBoxRandomChanging.Size = new System.Drawing.Size(117, 17);
            this.checkBoxRandomChanging.TabIndex = 0;
            this.checkBoxRandomChanging.Text = "Zufallsveränderung";
            this.checkBoxRandomChanging.UseVisualStyleBackColor = true;
            this.checkBoxRandomChanging.CheckedChanged += new System.EventHandler(this.checkBoxRandomChanging_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 671);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxMain);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(844, 709);
            this.MinimumSize = new System.Drawing.Size(844, 709);
            this.Name = "FormMain";
            this.Text = "Eldiv";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Timer timerLoop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonRectangle;
        private System.Windows.Forms.RadioButton radioButtonEllipse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonUnfilled;
        private System.Windows.Forms.RadioButton radioButtonFilled;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxRandomChanging;
        private System.Windows.Forms.CheckBox checkBoxShowPrimitiveCounter;
    }
}

