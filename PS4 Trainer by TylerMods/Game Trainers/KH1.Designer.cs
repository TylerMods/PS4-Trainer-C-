namespace PS4_Trainer_by_TylerMods.Game_Trainers
{
    partial class KH1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KH1));
            this.tglMoney = new theme.FlatToggle();
            this.pnlMoney = new System.Windows.Forms.Panel();
            this.flatLabel4 = new theme.FlatLabel();
            this.tglAmmo = new theme.FlatToggle();
            this.flatLabel3 = new theme.FlatLabel();
            this.pnlAmmo = new System.Windows.Forms.Panel();
            this.numMoney = new theme.FlatNumeric();
            this.flatLabel1 = new theme.FlatLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlHealth = new System.Windows.Forms.Panel();
            this.tglHealth = new theme.FlatToggle();
            this.flatLabel2 = new theme.FlatLabel();
            this.pnlEXP = new System.Windows.Forms.Panel();
            this.btnMoney = new theme.FlatButton();
            this.btnAttach = new theme.FlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrHealth = new System.Windows.Forms.Timer(this.components);
            this.pnlMoney.SuspendLayout();
            this.pnlAmmo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlHealth.SuspendLayout();
            this.pnlEXP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tglMoney
            // 
            this.tglMoney.BackColor = System.Drawing.Color.Transparent;
            this.tglMoney.Checked = false;
            this.tglMoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tglMoney.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tglMoney.Location = new System.Drawing.Point(290, 19);
            this.tglMoney.Name = "tglMoney";
            this.tglMoney.Options = theme.FlatToggle._Options.Style3;
            this.tglMoney.Size = new System.Drawing.Size(76, 33);
            this.tglMoney.TabIndex = 6;
            this.tglMoney.Text = "flatToggle1";
            this.tglMoney.CheckedChanged += new theme.FlatToggle.CheckedChangedEventHandler(this.tglMoney_CheckedChanged);
            // 
            // pnlMoney
            // 
            this.pnlMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.pnlMoney.Controls.Add(this.tglMoney);
            this.pnlMoney.Controls.Add(this.flatLabel4);
            this.pnlMoney.Location = new System.Drawing.Point(381, 82);
            this.pnlMoney.Name = "pnlMoney";
            this.pnlMoney.Size = new System.Drawing.Size(374, 73);
            this.pnlMoney.TabIndex = 47;
            this.pnlMoney.Visible = false;
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
            this.flatLabel4.Text = "Infinite Money";
            // 
            // tglAmmo
            // 
            this.tglAmmo.BackColor = System.Drawing.Color.Transparent;
            this.tglAmmo.Checked = false;
            this.tglAmmo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tglAmmo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tglAmmo.Location = new System.Drawing.Point(287, 19);
            this.tglAmmo.Name = "tglAmmo";
            this.tglAmmo.Options = theme.FlatToggle._Options.Style3;
            this.tglAmmo.Size = new System.Drawing.Size(76, 33);
            this.tglAmmo.TabIndex = 5;
            this.tglAmmo.Text = "flatToggle1";
            this.tglAmmo.CheckedChanged += new theme.FlatToggle.CheckedChangedEventHandler(this.tglAmmo_CheckedChanged);
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(13, 24);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(104, 20);
            this.flatLabel3.TabIndex = 2;
            this.flatLabel3.Text = "Infinite Ammo";
            // 
            // pnlAmmo
            // 
            this.pnlAmmo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.pnlAmmo.Controls.Add(this.tglAmmo);
            this.pnlAmmo.Controls.Add(this.flatLabel3);
            this.pnlAmmo.Location = new System.Drawing.Point(3, 82);
            this.pnlAmmo.Name = "pnlAmmo";
            this.pnlAmmo.Size = new System.Drawing.Size(375, 73);
            this.pnlAmmo.TabIndex = 48;
            this.pnlAmmo.Visible = false;
            // 
            // numMoney
            // 
            this.numMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.numMoney.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.numMoney.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.numMoney.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numMoney.ForeColor = System.Drawing.Color.White;
            this.numMoney.Location = new System.Drawing.Point(103, 20);
            this.numMoney.Maximum = ((long)(9999999));
            this.numMoney.Minimum = ((long)(0));
            this.numMoney.Name = "numMoney";
            this.numMoney.Size = new System.Drawing.Size(145, 30);
            this.numMoney.TabIndex = 3;
            this.numMoney.Text = "flatNumeric1";
            this.numMoney.Value = ((long)(0));
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(13, 24);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(54, 20);
            this.flatLabel1.TabIndex = 2;
            this.flatLabel1.Text = "Money";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.pnlMoney);
            this.panel1.Controls.Add(this.pnlAmmo);
            this.panel1.Controls.Add(this.pnlHealth);
            this.panel1.Controls.Add(this.pnlEXP);
            this.panel1.Location = new System.Drawing.Point(0, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 349);
            this.panel1.TabIndex = 102;
            // 
            // pnlHealth
            // 
            this.pnlHealth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.pnlHealth.Controls.Add(this.tglHealth);
            this.pnlHealth.Controls.Add(this.flatLabel2);
            this.pnlHealth.Location = new System.Drawing.Point(3, 3);
            this.pnlHealth.Name = "pnlHealth";
            this.pnlHealth.Size = new System.Drawing.Size(375, 73);
            this.pnlHealth.TabIndex = 47;
            // 
            // tglHealth
            // 
            this.tglHealth.BackColor = System.Drawing.Color.Transparent;
            this.tglHealth.Checked = false;
            this.tglHealth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tglHealth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tglHealth.Location = new System.Drawing.Point(287, 19);
            this.tglHealth.Name = "tglHealth";
            this.tglHealth.Options = theme.FlatToggle._Options.Style3;
            this.tglHealth.Size = new System.Drawing.Size(76, 33);
            this.tglHealth.TabIndex = 5;
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
            this.flatLabel2.Size = new System.Drawing.Size(103, 20);
            this.flatLabel2.TabIndex = 2;
            this.flatLabel2.Text = "Infinite Health";
            // 
            // pnlEXP
            // 
            this.pnlEXP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.pnlEXP.Controls.Add(this.numMoney);
            this.pnlEXP.Controls.Add(this.flatLabel1);
            this.pnlEXP.Controls.Add(this.btnMoney);
            this.pnlEXP.Location = new System.Drawing.Point(381, 3);
            this.pnlEXP.Name = "pnlEXP";
            this.pnlEXP.Size = new System.Drawing.Size(374, 73);
            this.pnlEXP.TabIndex = 46;
            // 
            // btnMoney
            // 
            this.btnMoney.BackColor = System.Drawing.Color.Transparent;
            this.btnMoney.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnMoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoney.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMoney.Location = new System.Drawing.Point(254, 14);
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Rounded = false;
            this.btnMoney.Size = new System.Drawing.Size(112, 44);
            this.btnMoney.TabIndex = 0;
            this.btnMoney.Text = "Set";
            this.btnMoney.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnMoney.Click += new System.EventHandler(this.btnMoney_Click);
            // 
            // btnAttach
            // 
            this.btnAttach.BackColor = System.Drawing.Color.Transparent;
            this.btnAttach.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnAttach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttach.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAttach.Location = new System.Drawing.Point(394, 3);
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
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
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
            this.label3.Location = new System.Drawing.Point(389, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 28);
            this.label3.TabIndex = 101;
            this.label3.Text = "CUSA05786";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(518, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 100;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 28);
            this.label4.TabIndex = 96;
            this.label4.Text = "Cheater : TylerMods";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.label1.Location = new System.Drawing.Point(312, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 28);
            this.label1.TabIndex = 95;
            this.label1.Text = "Game Version : 1.04";
            // 
            // tmrHealth
            // 
            this.tmrHealth.Interval = 800;
            this.tmrHealth.Tick += new System.EventHandler(this.tmrHealth_Tick);
            // 
            // KH1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "KH1";
            this.Size = new System.Drawing.Size(758, 455);
            this.pnlMoney.ResumeLayout(false);
            this.pnlMoney.PerformLayout();
            this.pnlAmmo.ResumeLayout(false);
            this.pnlAmmo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlHealth.ResumeLayout(false);
            this.pnlHealth.PerformLayout();
            this.pnlEXP.ResumeLayout(false);
            this.pnlEXP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private theme.FlatToggle tglMoney;
        private System.Windows.Forms.Panel pnlMoney;
        private theme.FlatLabel flatLabel4;
        private theme.FlatToggle tglAmmo;
        private theme.FlatLabel flatLabel3;
        private System.Windows.Forms.Panel pnlAmmo;
        private theme.FlatNumeric numMoney;
        private theme.FlatLabel flatLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlHealth;
        private theme.FlatToggle tglHealth;
        private theme.FlatLabel flatLabel2;
        private System.Windows.Forms.Panel pnlEXP;
        private theme.FlatButton btnMoney;
        private theme.FlatButton btnAttach;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrHealth;
    }
}
