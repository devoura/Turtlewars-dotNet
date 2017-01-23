namespace $safeprojectname$
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.livesRemainingLabel = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.fiende3 = new System.Windows.Forms.PictureBox();
            this.fiende1 = new System.Windows.Forms.PictureBox();
            this.fiende2 = new System.Windows.Forms.PictureBox();
            this.prosjektil = new System.Windows.Forms.PictureBox();
            this.spiller = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fiende3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiende1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiende2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosjektil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiller)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(13, 13);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(0, 13);
            this.scoreLabel.TabIndex = 4;
            // 
            // livesRemainingLabel
            // 
            this.livesRemainingLabel.AutoSize = true;
            this.livesRemainingLabel.Location = new System.Drawing.Point(237, 13);
            this.livesRemainingLabel.Name = "livesRemainingLabel";
            this.livesRemainingLabel.Size = new System.Drawing.Size(0, 13);
            this.livesRemainingLabel.TabIndex = 6;
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(126, 9);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 13);
            this.timerLabel.TabIndex = 7;
            // 
            // fiende3
            // 
            this.fiende3.BackColor = System.Drawing.Color.Transparent;
            this.fiende3.BackgroundImage = global::$safeprojectname$.Properties.Resources.croc;
            this.fiende3.Location = new System.Drawing.Point(12, 183);
            this.fiende3.Name = "fiende3";
            this.fiende3.Size = new System.Drawing.Size(100, 23);
            this.fiende3.TabIndex = 5;
            this.fiende3.TabStop = false;
            // 
            // fiende1
            // 
            this.fiende1.BackColor = System.Drawing.Color.Transparent;
            this.fiende1.BackgroundImage = global::$safeprojectname$.Properties.Resources.croc;
            this.fiende1.Location = new System.Drawing.Point(12, 29);
            this.fiende1.Name = "fiende1";
            this.fiende1.Size = new System.Drawing.Size(100, 23);
            this.fiende1.TabIndex = 3;
            this.fiende1.TabStop = false;
            // 
            // fiende2
            // 
            this.fiende2.BackColor = System.Drawing.Color.Transparent;
            this.fiende2.BackgroundImage = global::$safeprojectname$.Properties.Resources.croc2;
            this.fiende2.Location = new System.Drawing.Point(172, 111);
            this.fiende2.Name = "fiende2";
            this.fiende2.Size = new System.Drawing.Size(100, 25);
            this.fiende2.TabIndex = 2;
            this.fiende2.TabStop = false;
            // 
            // prosjektil
            // 
            this.prosjektil.BackColor = System.Drawing.Color.Transparent;
            this.prosjektil.BackgroundImage = global::$safeprojectname$.Properties.Resources.turtle;
            this.prosjektil.Location = new System.Drawing.Point(172, 242);
            this.prosjektil.Name = "prosjektil";
            this.prosjektil.Size = new System.Drawing.Size(23, 38);
            this.prosjektil.TabIndex = 1;
            this.prosjektil.TabStop = false;
            // 
            // spiller
            // 
            this.spiller.BackColor = System.Drawing.Color.Transparent;
            this.spiller.BackgroundImage = global::$safeprojectname$.Properties.Resources.turtle;
            this.spiller.Location = new System.Drawing.Point(172, 286);
            this.spiller.Name = "spiller";
            this.spiller.Size = new System.Drawing.Size(23, 35);
            this.spiller.TabIndex = 0;
            this.spiller.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImage = global::$safeprojectname$.Properties.Resources.water2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 331);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.livesRemainingLabel);
            this.Controls.Add(this.fiende3);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.fiende1);
            this.Controls.Add(this.fiende2);
            this.Controls.Add(this.prosjektil);
            this.Controls.Add(this.spiller);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.fiende3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiende1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiende2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prosjektil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spiller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox spiller;
        private System.Windows.Forms.PictureBox prosjektil;
        private System.Windows.Forms.PictureBox fiende2;
        private System.Windows.Forms.PictureBox fiende1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.PictureBox fiende3;
        private System.Windows.Forms.Label livesRemainingLabel;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label timerLabel;
    }
}