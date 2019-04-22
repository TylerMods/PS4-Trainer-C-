namespace PS4_Trainer_by_TylerMods.Game_Trainers
{
    partial class DS3FFE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DS3FFE));
            this.tmrHealth = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.flatLabel5 = new theme.FlatLabel();
            this.tglEnergy = new theme.FlatToggle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numSouls = new theme.FlatNumeric();
            this.btnSouls = new theme.FlatButton();
            this.flatLabel1 = new theme.FlatLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAttach = new theme.FlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flatLabel2 = new theme.FlatLabel();
            this.tglHealth = new theme.FlatToggle();
            this.tmrEnergy = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.flatLabel3 = new theme.FlatLabel();
            this.tglBombs = new theme.FlatToggle();
            this.tmrBombs = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrHealth
            // 
            this.tmrHealth.Interval = 500;
            this.tmrHealth.Tick += new System.EventHandler(this.tmrHealth_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(1, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 349);
            this.panel1.TabIndex = 137;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel6.Controls.Add(this.flatLabel5);
            this.panel6.Controls.Add(this.tglEnergy);
            this.panel6.Location = new System.Drawing.Point(379, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(375, 73);
            this.panel6.TabIndex = 46;
            this.panel6.Visible = false;
            // 
            // flatLabel5
            // 
            this.flatLabel5.AutoSize = true;
            this.flatLabel5.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel5.ForeColor = System.Drawing.Color.White;
            this.flatLabel5.Location = new System.Drawing.Point(13, 24);
            this.flatLabel5.Name = "flatLabel5";
            this.flatLabel5.Size = new System.Drawing.Size(104, 20);
            this.flatLabel5.TabIndex = 2;
            this.flatLabel5.Text = "Infinite Energy";
            // 
            // tglEnergy
            // 
            this.tglEnergy.BackColor = System.Drawing.Color.Transparent;
            this.tglEnergy.Checked = false;
            this.tglEnergy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tglEnergy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tglEnergy.Location = new System.Drawing.Point(296, 20);
            this.tglEnergy.Name = "tglEnergy";
            this.tglEnergy.Options = theme.FlatToggle._Options.Style3;
            this.tglEnergy.Size = new System.Drawing.Size(76, 33);
            this.tglEnergy.TabIndex = 5;
            this.tglEnergy.Text = "flatToggle1";
            this.tglEnergy.CheckedChanged += new theme.FlatToggle.CheckedChangedEventHandler(this.tglEnergy_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel3.Controls.Add(this.numSouls);
            this.panel3.Controls.Add(this.btnSouls);
            this.panel3.Controls.Add(this.flatLabel1);
            this.panel3.Location = new System.Drawing.Point(3, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(374, 73);
            this.panel3.TabIndex = 46;
            // 
            // numSouls
            // 
            this.numSouls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.numSouls.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.numSouls.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.numSouls.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numSouls.ForeColor = System.Drawing.Color.White;
            this.numSouls.Location = new System.Drawing.Point(108, 20);
            this.numSouls.Maximum = ((long)(9999999));
            this.numSouls.Minimum = ((long)(0));
            this.numSouls.Name = "numSouls";
            this.numSouls.Size = new System.Drawing.Size(145, 30);
            this.numSouls.TabIndex = 5;
            this.numSouls.Text = "flatNumeric1";
            this.numSouls.Value = ((long)(0));
            // 
            // btnSouls
            // 
            this.btnSouls.BackColor = System.Drawing.Color.Transparent;
            this.btnSouls.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnSouls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSouls.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSouls.Location = new System.Drawing.Point(259, 14);
            this.btnSouls.Name = "btnSouls";
            this.btnSouls.Rounded = false;
            this.btnSouls.Size = new System.Drawing.Size(109, 44);
            this.btnSouls.TabIndex = 4;
            this.btnSouls.Text = "Set";
            this.btnSouls.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnSouls.Click += new System.EventHandler(this.btnSouls_Click);
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(13, 24);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(44, 20);
            this.flatLabel1.TabIndex = 2;
            this.flatLabel1.Text = "Souls";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.label4.Location = new System.Drawing.Point(-1, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 28);
            this.label4.TabIndex = 136;
            this.label4.Text = "Cheater : Unkown";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.label3.Location = new System.Drawing.Point(394, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 28);
            this.label3.TabIndex = 135;
            this.label3.Text = "CUSA07439";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.label1.Location = new System.Drawing.Point(317, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 28);
            this.label1.TabIndex = 134;
            this.label1.Text = "Game Version : 1.00";
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
            this.btnAttach.TabIndex = 139;
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
            this.pictureBox2.TabIndex = 138;
            this.pictureBox2.TabStop = false;
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
            this.pictureBox1.TabIndex = 133;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel2.Controls.Add(this.flatLabel2);
            this.panel2.Controls.Add(this.tglHealth);
            this.panel2.Location = new System.Drawing.Point(2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 73);
            this.panel2.TabIndex = 47;
            this.panel2.Visible = false;
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
            // tglHealth
            // 
            this.tglHealth.BackColor = System.Drawing.Color.Transparent;
            this.tglHealth.Checked = false;
            this.tglHealth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tglHealth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tglHealth.Location = new System.Drawing.Point(296, 20);
            this.tglHealth.Name = "tglHealth";
            this.tglHealth.Options = theme.FlatToggle._Options.Style3;
            this.tglHealth.Size = new System.Drawing.Size(76, 33);
            this.tglHealth.TabIndex = 5;
            this.tglHealth.Text = "flatToggle1";
            this.tglHealth.CheckedChanged += new theme.FlatToggle.CheckedChangedEventHandler(this.tglHealth_CheckedChanged);
            // 
            // tmrEnergy
            // 
            this.tmrEnergy.Interval = 500;
            this.tmrEnergy.Tick += new System.EventHandler(this.tmrEnergy_Tick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel4.Controls.Add(this.flatLabel3);
            this.panel4.Controls.Add(this.tglBombs);
            this.panel4.Location = new System.Drawing.Point(379, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(375, 73);
            this.panel4.TabIndex = 47;
            this.panel4.Visible = false;
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(13, 24);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(105, 20);
            this.flatLabel3.TabIndex = 2;
            this.flatLabel3.Text = "Infinite Bombs";
            // 
            // tglBombs
            // 
            this.tglBombs.BackColor = System.Drawing.Color.Transparent;
            this.tglBombs.Checked = false;
            this.tglBombs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tglBombs.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tglBombs.Location = new System.Drawing.Point(296, 20);
            this.tglBombs.Name = "tglBombs";
            this.tglBombs.Options = theme.FlatToggle._Options.Style3;
            this.tglBombs.Size = new System.Drawing.Size(76, 33);
            this.tglBombs.TabIndex = 5;
            this.tglBombs.Text = "flatToggle1";
            this.tglBombs.CheckedChanged += new theme.FlatToggle.CheckedChangedEventHandler(this.tglBombs_CheckedChanged);
            // 
            // tmrBombs
            // 
            this.tmrBombs.Interval = 500;
            this.tmrBombs.Tick += new System.EventHandler(this.tmrBombs_Tick);
            // 
            // DS3FFE
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DS3FFE";
            this.Size = new System.Drawing.Size(758, 455);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrHealth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private theme.FlatLabel flatLabel3;
        private theme.FlatToggle tglBombs;
        private System.Windows.Forms.Panel panel2;
        private theme.FlatLabel flatLabel2;
        private theme.FlatToggle tglHealth;
        private System.Windows.Forms.Panel panel6;
        private theme.FlatLabel flatLabel5;
        private theme.FlatToggle tglEnergy;
        private System.Windows.Forms.Panel panel3;
        private theme.FlatNumeric numSouls;
        private theme.FlatButton btnSouls;
        private theme.FlatLabel flatLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private theme.FlatButton btnAttach;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmrEnergy;
        private System.Windows.Forms.Timer tmrBombs;
    }
}
