namespace PS4_Trainer_by_TylerMods.Game_Trainers
{
    partial class TEW1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TEW1));
            this.tmrHealth = new System.Windows.Forms.Timer(this.components);
            this.btnAttach = new theme.FlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tglSemiHandgunAmmo = new theme.FlatToggle();
            this.flatLabel4 = new theme.FlatLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.flatLabel10 = new theme.FlatLabel();
            this.flatButton2 = new theme.FlatButton();
            this.tglGunpowder = new theme.FlatToggle();
            this.tglHealth = new theme.FlatToggle();
            this.flatLabel2 = new theme.FlatLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tglReload = new theme.FlatToggle();
            this.flatLabel1 = new theme.FlatLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tglGel = new theme.FlatToggle();
            this.flatLabel3 = new theme.FlatLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrHealth
            // 
            this.tmrHealth.Interval = 500;
            // 
            // btnAttach
            // 
            this.btnAttach.BackColor = System.Drawing.Color.Transparent;
            this.btnAttach.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnAttach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttach.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAttach.Location = new System.Drawing.Point(395, 3);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Rounded = false;
            this.btnAttach.Size = new System.Drawing.Size(118, 44);
            this.btnAttach.TabIndex = 104;
            this.btnAttach.Text = "Attach";
            this.btnAttach.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(351, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 103;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.label3.Location = new System.Drawing.Point(390, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 28);
            this.label3.TabIndex = 100;
            this.label3.Text = "CUSA01082 ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.label1.Location = new System.Drawing.Point(313, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 28);
            this.label1.TabIndex = 99;
            this.label1.Text = "Game Version : 1.00";
            // 
            // tglSemiHandgunAmmo
            // 
            this.tglSemiHandgunAmmo.BackColor = System.Drawing.Color.Transparent;
            this.tglSemiHandgunAmmo.Checked = false;
            this.tglSemiHandgunAmmo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tglSemiHandgunAmmo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tglSemiHandgunAmmo.Location = new System.Drawing.Point(290, 21);
            this.tglSemiHandgunAmmo.Name = "tglSemiHandgunAmmo";
            this.tglSemiHandgunAmmo.Options = theme.FlatToggle._Options.Style3;
            this.tglSemiHandgunAmmo.Size = new System.Drawing.Size(76, 33);
            this.tglSemiHandgunAmmo.TabIndex = 3;
            this.tglSemiHandgunAmmo.Text = "flatToggle1";
            this.tglSemiHandgunAmmo.CheckedChanged += new theme.FlatToggle.CheckedChangedEventHandler(this.tglSemiHandgunAmmo_CheckedChanged);
            // 
            // flatLabel4
            // 
            this.flatLabel4.AutoSize = true;
            this.flatLabel4.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel4.ForeColor = System.Drawing.Color.White;
            this.flatLabel4.Location = new System.Drawing.Point(13, 24);
            this.flatLabel4.Name = "flatLabel4";
            this.flatLabel4.Size = new System.Drawing.Size(104, 20);
            this.flatLabel4.TabIndex = 2;
            this.flatLabel4.Text = "Infinite Ammo";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel5.Controls.Add(this.tglSemiHandgunAmmo);
            this.panel5.Controls.Add(this.flatLabel4);
            this.panel5.Location = new System.Drawing.Point(384, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(371, 73);
            this.panel5.TabIndex = 47;
            // 
            // flatLabel10
            // 
            this.flatLabel10.AutoSize = true;
            this.flatLabel10.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel10.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel10.ForeColor = System.Drawing.Color.White;
            this.flatLabel10.Location = new System.Drawing.Point(13, 24);
            this.flatLabel10.Name = "flatLabel10";
            this.flatLabel10.Size = new System.Drawing.Size(103, 20);
            this.flatLabel10.TabIndex = 2;
            this.flatLabel10.Text = "Infinite Health";
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.flatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton2.Location = new System.Drawing.Point(155, 17);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Rounded = false;
            this.flatButton2.Size = new System.Drawing.Size(42, 37);
            this.flatButton2.TabIndex = 98;
            this.flatButton2.Text = "Help";
            this.flatButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // tglGunpowder
            // 
            this.tglGunpowder.BackColor = System.Drawing.Color.Transparent;
            this.tglGunpowder.Checked = false;
            this.tglGunpowder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tglGunpowder.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tglGunpowder.Location = new System.Drawing.Point(290, 21);
            this.tglGunpowder.Name = "tglGunpowder";
            this.tglGunpowder.Options = theme.FlatToggle._Options.Style3;
            this.tglGunpowder.Size = new System.Drawing.Size(76, 33);
            this.tglGunpowder.TabIndex = 4;
            this.tglGunpowder.Text = "flatToggle1";
            // 
            // tglHealth
            // 
            this.tglHealth.BackColor = System.Drawing.Color.Transparent;
            this.tglHealth.Checked = false;
            this.tglHealth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tglHealth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tglHealth.Location = new System.Drawing.Point(290, 21);
            this.tglHealth.Name = "tglHealth";
            this.tglHealth.Options = theme.FlatToggle._Options.Style3;
            this.tglHealth.Size = new System.Drawing.Size(76, 33);
            this.tglHealth.TabIndex = 3;
            this.tglHealth.Text = "flatToggle1";
            this.tglHealth.CheckedChanged += new theme.FlatToggle.CheckedChangedEventHandler(this.tglHealth_CheckedChanged);
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(13, 24);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(143, 20);
            this.flatLabel2.TabIndex = 2;
            this.flatLabel2.Text = "Infinite Components";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(519, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel4.Controls.Add(this.flatButton2);
            this.panel4.Controls.Add(this.tglGunpowder);
            this.panel4.Controls.Add(this.flatLabel2);
            this.panel4.Location = new System.Drawing.Point(293, 258);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(378, 73);
            this.panel4.TabIndex = 99;
            this.panel4.Visible = false;
            // 
            // tglReload
            // 
            this.tglReload.BackColor = System.Drawing.Color.Transparent;
            this.tglReload.Checked = false;
            this.tglReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tglReload.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tglReload.Location = new System.Drawing.Point(290, 21);
            this.tglReload.Name = "tglReload";
            this.tglReload.Options = theme.FlatToggle._Options.Style3;
            this.tglReload.Size = new System.Drawing.Size(76, 33);
            this.tglReload.TabIndex = 3;
            this.tglReload.Text = "flatToggle1";
            this.tglReload.CheckedChanged += new theme.FlatToggle.CheckedChangedEventHandler(this.tglReload_CheckedChanged);
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(13, 24);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(80, 20);
            this.flatLabel1.TabIndex = 2;
            this.flatLabel1.Text = "No Reload";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel2.Controls.Add(this.tglReload);
            this.panel2.Controls.Add(this.flatLabel1);
            this.panel2.Location = new System.Drawing.Point(384, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 73);
            this.panel2.TabIndex = 48;
            // 
            // tglGel
            // 
            this.tglGel.BackColor = System.Drawing.Color.Transparent;
            this.tglGel.Checked = false;
            this.tglGel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tglGel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tglGel.Location = new System.Drawing.Point(290, 21);
            this.tglGel.Name = "tglGel";
            this.tglGel.Options = theme.FlatToggle._Options.Style3;
            this.tglGel.Size = new System.Drawing.Size(76, 33);
            this.tglGel.TabIndex = 3;
            this.tglGel.Text = "flatToggle1";
            this.tglGel.CheckedChanged += new theme.FlatToggle.CheckedChangedEventHandler(this.tglGel_CheckedChanged);
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(13, 24);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(81, 20);
            this.flatLabel3.TabIndex = 2;
            this.flatLabel3.Text = "Infinite Gel";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel3.Controls.Add(this.tglGel);
            this.panel3.Controls.Add(this.flatLabel3);
            this.panel3.Location = new System.Drawing.Point(3, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 73);
            this.panel3.TabIndex = 49;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(1, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 349);
            this.panel1.TabIndex = 102;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel9.Controls.Add(this.tglHealth);
            this.panel9.Controls.Add(this.flatLabel10);
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(378, 73);
            this.panel9.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.label4.Location = new System.Drawing.Point(-1, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 28);
            this.label4.TabIndex = 101;
            this.label4.Text = "Cheater : TylerMods";
            // 
            // TEW1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Name = "TEW1";
            this.Size = new System.Drawing.Size(758, 455);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrHealth;
        private theme.FlatButton btnAttach;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private theme.FlatToggle tglSemiHandgunAmmo;
        private theme.FlatLabel flatLabel4;
        private System.Windows.Forms.Panel panel5;
        private theme.FlatLabel flatLabel10;
        private theme.FlatButton flatButton2;
        private theme.FlatToggle tglGunpowder;
        private theme.FlatToggle tglHealth;
        private theme.FlatLabel flatLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private theme.FlatToggle tglReload;
        private theme.FlatLabel flatLabel1;
        private System.Windows.Forms.Panel panel2;
        private theme.FlatToggle tglGel;
        private theme.FlatLabel flatLabel3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label4;
    }
}
