namespace PS4_Trainer_by_TylerMods.Game_Trainers
{
    partial class WTOB
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WTOB));
            this.tglGoldHealth = new theme.FlatToggle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flatLabel2 = new theme.FlatLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flatLabel3 = new theme.FlatLabel();
            this.tglShield = new theme.FlatToggle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flatLabel1 = new theme.FlatLabel();
            this.tglAmmo = new theme.FlatToggle();
            this.panel7 = new System.Windows.Forms.Panel();
            this.flatLabel6 = new theme.FlatLabel();
            this.tglHealth = new theme.FlatToggle();
            this.btnAttach = new theme.FlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFAQ = new theme.FlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tglGoldHealth
            // 
            this.tglGoldHealth.BackColor = System.Drawing.Color.Transparent;
            this.tglGoldHealth.Checked = false;
            this.tglGoldHealth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tglGoldHealth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tglGoldHealth.Location = new System.Drawing.Point(294, 21);
            this.tglGoldHealth.Name = "tglGoldHealth";
            this.tglGoldHealth.Options = theme.FlatToggle._Options.Style3;
            this.tglGoldHealth.Size = new System.Drawing.Size(76, 33);
            this.tglGoldHealth.TabIndex = 1;
            this.tglGoldHealth.Text = "flatToggle1";
            this.tglGoldHealth.CheckedChanged += new theme.FlatToggle.CheckedChangedEventHandler(this.tglGoldHealth_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel2.Controls.Add(this.flatLabel2);
            this.panel2.Controls.Add(this.tglGoldHealth);
            this.panel2.Location = new System.Drawing.Point(382, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 73);
            this.panel2.TabIndex = 48;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(26, 25);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(139, 20);
            this.flatLabel2.TabIndex = 2;
            this.flatLabel2.Text = "Infinite Gold Health";
            this.flatLabel2.Click += new System.EventHandler(this.flatLabel2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel3.Controls.Add(this.flatLabel3);
            this.panel3.Controls.Add(this.tglShield);
            this.panel3.Location = new System.Drawing.Point(382, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 73);
            this.panel3.TabIndex = 47;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(26, 25);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(100, 20);
            this.flatLabel3.TabIndex = 2;
            this.flatLabel3.Text = "Infinite Shield";
            this.flatLabel3.Click += new System.EventHandler(this.flatLabel3_Click);
            // 
            // tglShield
            // 
            this.tglShield.BackColor = System.Drawing.Color.Transparent;
            this.tglShield.Checked = false;
            this.tglShield.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tglShield.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tglShield.Location = new System.Drawing.Point(294, 21);
            this.tglShield.Name = "tglShield";
            this.tglShield.Options = theme.FlatToggle._Options.Style3;
            this.tglShield.Size = new System.Drawing.Size(76, 33);
            this.tglShield.TabIndex = 1;
            this.tglShield.Text = "flatToggle1";
            this.tglShield.CheckedChanged += new theme.FlatToggle.CheckedChangedEventHandler(this.tglShield_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.label1.Location = new System.Drawing.Point(312, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 28);
            this.label1.TabIndex = 89;
            this.label1.Text = "Game Version : 1.00";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Location = new System.Drawing.Point(0, 109);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(758, 344);
            this.panel5.TabIndex = 91;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.flatLabel1);
            this.panel1.Controls.Add(this.tglAmmo);
            this.panel1.Location = new System.Drawing.Point(3, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 73);
            this.panel1.TabIndex = 46;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(26, 25);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(104, 20);
            this.flatLabel1.TabIndex = 2;
            this.flatLabel1.Text = "Infinite Ammo";
            this.flatLabel1.Click += new System.EventHandler(this.flatLabel1_Click);
            // 
            // tglAmmo
            // 
            this.tglAmmo.BackColor = System.Drawing.Color.Transparent;
            this.tglAmmo.Checked = false;
            this.tglAmmo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tglAmmo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tglAmmo.Location = new System.Drawing.Point(295, 21);
            this.tglAmmo.Name = "tglAmmo";
            this.tglAmmo.Options = theme.FlatToggle._Options.Style3;
            this.tglAmmo.Size = new System.Drawing.Size(76, 33);
            this.tglAmmo.TabIndex = 1;
            this.tglAmmo.Text = "flatToggle1";
            this.tglAmmo.CheckedChanged += new theme.FlatToggle.CheckedChangedEventHandler(this.tglAmmo_CheckedChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel7.Controls.Add(this.flatLabel6);
            this.panel7.Controls.Add(this.tglHealth);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(378, 73);
            this.panel7.TabIndex = 45;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // flatLabel6
            // 
            this.flatLabel6.AutoSize = true;
            this.flatLabel6.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel6.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel6.ForeColor = System.Drawing.Color.White;
            this.flatLabel6.Location = new System.Drawing.Point(26, 25);
            this.flatLabel6.Name = "flatLabel6";
            this.flatLabel6.Size = new System.Drawing.Size(103, 20);
            this.flatLabel6.TabIndex = 2;
            this.flatLabel6.Text = "Infinite Health";
            this.flatLabel6.Click += new System.EventHandler(this.flatLabel6_Click);
            // 
            // tglHealth
            // 
            this.tglHealth.BackColor = System.Drawing.Color.Transparent;
            this.tglHealth.Checked = false;
            this.tglHealth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tglHealth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tglHealth.Location = new System.Drawing.Point(295, 18);
            this.tglHealth.Name = "tglHealth";
            this.tglHealth.Options = theme.FlatToggle._Options.Style3;
            this.tglHealth.Size = new System.Drawing.Size(76, 33);
            this.tglHealth.TabIndex = 1;
            this.tglHealth.Text = "flatToggle1";
            this.tglHealth.CheckedChanged += new theme.FlatToggle.CheckedChangedEventHandler(this.tglHealth_CheckedChanged);
            // 
            // btnAttach
            // 
            this.btnAttach.BackColor = System.Drawing.Color.Transparent;
            this.btnAttach.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnAttach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttach.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAttach.Location = new System.Drawing.Point(394, 4);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Rounded = false;
            this.btnAttach.Size = new System.Drawing.Size(118, 44);
            this.btnAttach.TabIndex = 86;
            this.btnAttach.Text = "Attach";
            this.btnAttach.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.label3.Location = new System.Drawing.Point(389, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 28);
            this.label3.TabIndex = 90;
            this.label3.Text = "CUSA01540";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(518, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnFAQ
            // 
            this.btnFAQ.BackColor = System.Drawing.Color.Transparent;
            this.btnFAQ.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnFAQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFAQ.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnFAQ.Location = new System.Drawing.Point(357, 4);
            this.btnFAQ.Name = "btnFAQ";
            this.btnFAQ.Rounded = false;
            this.btnFAQ.Size = new System.Drawing.Size(21, 25);
            this.btnFAQ.TabIndex = 87;
            this.btnFAQ.Text = "?";
            this.btnFAQ.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnFAQ.Visible = false;
            this.btnFAQ.Click += new System.EventHandler(this.btnFAQ_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(351, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 93;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 28);
            this.label4.TabIndex = 92;
            this.label4.Text = "Cheater : JgDuff";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // WTOB
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFAQ);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Name = "WTOB";
            this.Size = new System.Drawing.Size(758, 455);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private theme.FlatToggle tglGoldHealth;
        private System.Windows.Forms.Panel panel2;
        private theme.FlatLabel flatLabel2;
        private System.Windows.Forms.Panel panel3;
        private theme.FlatLabel flatLabel3;
        private theme.FlatToggle tglShield;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private theme.FlatLabel flatLabel1;
        private theme.FlatToggle tglAmmo;
        private System.Windows.Forms.Panel panel7;
        private theme.FlatLabel flatLabel6;
        private theme.FlatToggle tglHealth;
        private theme.FlatButton btnAttach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private theme.FlatButton btnFAQ;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
    }
}
