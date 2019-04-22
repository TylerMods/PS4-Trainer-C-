namespace PS4_Trainer_by_TylerMods.Game_Trainers
{
    partial class TombRaider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TombRaider));
            this.tmrHealth = new System.Windows.Forms.Timer(this.components);
            this.flatLabel3 = new theme.FlatLabel();
            this.tglNoReload = new theme.FlatToggle();
            this.pnlReload = new System.Windows.Forms.Panel();
            this.flatLabel4 = new theme.FlatLabel();
            this.tglSP = new theme.FlatToggle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnAttach = new theme.FlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlAmmo = new System.Windows.Forms.Panel();
            this.flatLabel1 = new theme.FlatLabel();
            this.tglAmmo = new theme.FlatToggle();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlHealth = new System.Windows.Forms.Panel();
            this.flatLabel6 = new theme.FlatLabel();
            this.tglHealth = new theme.FlatToggle();
            this.btnFAQ = new theme.FlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlReload.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlAmmo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            this.pnlHealth.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrHealth
            // 
            this.tmrHealth.Interval = 500;
            this.tmrHealth.Tick += new System.EventHandler(this.tmrHealth_Tick);
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(14, 25);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(80, 20);
            this.flatLabel3.TabIndex = 2;
            this.flatLabel3.Text = "No Reload";
            // 
            // tglNoReload
            // 
            this.tglNoReload.BackColor = System.Drawing.Color.Transparent;
            this.tglNoReload.Checked = false;
            this.tglNoReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tglNoReload.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tglNoReload.Location = new System.Drawing.Point(294, 21);
            this.tglNoReload.Name = "tglNoReload";
            this.tglNoReload.Options = theme.FlatToggle._Options.Style3;
            this.tglNoReload.Size = new System.Drawing.Size(76, 33);
            this.tglNoReload.TabIndex = 1;
            this.tglNoReload.Text = "flatToggle1";
            this.tglNoReload.CheckedChanged += new theme.FlatToggle.CheckedChangedEventHandler(this.tglNoReload_CheckedChanged);
            // 
            // pnlReload
            // 
            this.pnlReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.pnlReload.Controls.Add(this.flatLabel3);
            this.pnlReload.Controls.Add(this.tglNoReload);
            this.pnlReload.Location = new System.Drawing.Point(382, 82);
            this.pnlReload.Name = "pnlReload";
            this.pnlReload.Size = new System.Drawing.Size(373, 73);
            this.pnlReload.TabIndex = 47;
            // 
            // flatLabel4
            // 
            this.flatLabel4.AutoSize = true;
            this.flatLabel4.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel4.ForeColor = System.Drawing.Color.White;
            this.flatLabel4.Location = new System.Drawing.Point(14, 25);
            this.flatLabel4.Name = "flatLabel4";
            this.flatLabel4.Size = new System.Drawing.Size(129, 20);
            this.flatLabel4.TabIndex = 2;
            this.flatLabel4.Text = "Infinite Skill Points";
            // 
            // tglSP
            // 
            this.tglSP.BackColor = System.Drawing.Color.Transparent;
            this.tglSP.Checked = false;
            this.tglSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tglSP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tglSP.Location = new System.Drawing.Point(294, 18);
            this.tglSP.Name = "tglSP";
            this.tglSP.Options = theme.FlatToggle._Options.Style3;
            this.tglSP.Size = new System.Drawing.Size(76, 33);
            this.tglSP.TabIndex = 1;
            this.tglSP.Text = "flatToggle1";
            this.tglSP.CheckedChanged += new theme.FlatToggle.CheckedChangedEventHandler(this.tglSP_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.flatLabel4);
            this.panel1.Controls.Add(this.tglSP);
            this.panel1.Location = new System.Drawing.Point(382, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 73);
            this.panel1.TabIndex = 47;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.lblVersion.Location = new System.Drawing.Point(312, 78);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(200, 28);
            this.lblVersion.TabIndex = 106;
            this.lblVersion.Text = "Game Version : 1.00";
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
            this.btnAttach.TabIndex = 103;
            this.btnAttach.Text = "Attach";
            this.btnAttach.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(518, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 105;
            this.pictureBox1.TabStop = false;
            // 
            // pnlAmmo
            // 
            this.pnlAmmo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.pnlAmmo.Controls.Add(this.flatLabel1);
            this.pnlAmmo.Controls.Add(this.tglAmmo);
            this.pnlAmmo.Location = new System.Drawing.Point(3, 82);
            this.pnlAmmo.Name = "pnlAmmo";
            this.pnlAmmo.Size = new System.Drawing.Size(378, 73);
            this.pnlAmmo.TabIndex = 46;
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(10, 25);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(176, 20);
            this.flatLabel1.TabIndex = 2;
            this.flatLabel1.Text = "Infinite Ammo/Resources";
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
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(351, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 109;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 28);
            this.label4.TabIndex = 108;
            this.label4.Text = "Cheater : JgDuff";
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.pnlReload);
            this.panel5.Controls.Add(this.pnlAmmo);
            this.panel5.Controls.Add(this.pnlHealth);
            this.panel5.Location = new System.Drawing.Point(0, 109);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(758, 344);
            this.panel5.TabIndex = 107;
            // 
            // pnlHealth
            // 
            this.pnlHealth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.pnlHealth.Controls.Add(this.flatLabel6);
            this.pnlHealth.Controls.Add(this.tglHealth);
            this.pnlHealth.Location = new System.Drawing.Point(3, 3);
            this.pnlHealth.Name = "pnlHealth";
            this.pnlHealth.Size = new System.Drawing.Size(378, 73);
            this.pnlHealth.TabIndex = 45;
            // 
            // flatLabel6
            // 
            this.flatLabel6.AutoSize = true;
            this.flatLabel6.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel6.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel6.ForeColor = System.Drawing.Color.White;
            this.flatLabel6.Location = new System.Drawing.Point(10, 25);
            this.flatLabel6.Name = "flatLabel6";
            this.flatLabel6.Size = new System.Drawing.Size(103, 20);
            this.flatLabel6.TabIndex = 2;
            this.flatLabel6.Text = "Infinite Health";
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
            this.btnFAQ.TabIndex = 104;
            this.btnFAQ.Text = "?";
            this.btnFAQ.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnFAQ.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.label1.Location = new System.Drawing.Point(389, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 28);
            this.label1.TabIndex = 110;
            this.label1.Text = "CUSA00109";
            // 
            // TombRaider
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnFAQ);
            this.Name = "TombRaider";
            this.Size = new System.Drawing.Size(758, 455);
            this.pnlReload.ResumeLayout(false);
            this.pnlReload.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlAmmo.ResumeLayout(false);
            this.pnlAmmo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.pnlHealth.ResumeLayout(false);
            this.pnlHealth.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrHealth;
        private theme.FlatLabel flatLabel3;
        private theme.FlatToggle tglNoReload;
        private System.Windows.Forms.Panel pnlReload;
        private theme.FlatLabel flatLabel4;
        private theme.FlatToggle tglSP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVersion;
        private theme.FlatButton btnAttach;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlAmmo;
        private theme.FlatLabel flatLabel1;
        private theme.FlatToggle tglAmmo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnlHealth;
        private theme.FlatLabel flatLabel6;
        private theme.FlatToggle tglHealth;
        private theme.FlatButton btnFAQ;
        private System.Windows.Forms.Label label1;
    }
}
