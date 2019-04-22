namespace PS4_Trainer_by_TylerMods.Game_Trainers
{
    partial class YakuzaKiwami
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YakuzaKiwami));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.numCP = new theme.FlatNumeric();
            this.flatLabel5 = new theme.FlatLabel();
            this.btnCP = new theme.FlatButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tglGauge = new theme.FlatToggle();
            this.flatLabel4 = new theme.FlatLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tglEXP = new theme.FlatToggle();
            this.flatLabel2 = new theme.FlatLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tglGodMode = new theme.FlatToggle();
            this.flatLabel1 = new theme.FlatLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numMoney = new theme.FlatNumeric();
            this.flatLabel3 = new theme.FlatLabel();
            this.btnMoney = new theme.FlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmrHealth = new System.Windows.Forms.Timer(this.components);
            this.tmrGauge = new System.Windows.Forms.Timer(this.components);
            this.tmrEXP = new System.Windows.Forms.Timer(this.components);
            this.btnAttach = new theme.FlatButton();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 349);
            this.panel1.TabIndex = 69;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel6.Controls.Add(this.numCP);
            this.panel6.Controls.Add(this.flatLabel5);
            this.panel6.Controls.Add(this.btnCP);
            this.panel6.Location = new System.Drawing.Point(3, 161);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(374, 73);
            this.panel6.TabIndex = 47;
            // 
            // numCP
            // 
            this.numCP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.numCP.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.numCP.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.numCP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numCP.ForeColor = System.Drawing.Color.White;
            this.numCP.Location = new System.Drawing.Point(84, 21);
            this.numCP.Maximum = ((long)(99999999));
            this.numCP.Minimum = ((long)(0));
            this.numCP.Name = "numCP";
            this.numCP.Size = new System.Drawing.Size(154, 30);
            this.numCP.TabIndex = 3;
            this.numCP.Text = "flatNumeric1";
            this.numCP.Value = ((long)(0));
            // 
            // flatLabel5
            // 
            this.flatLabel5.AutoSize = true;
            this.flatLabel5.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel5.ForeColor = System.Drawing.Color.White;
            this.flatLabel5.Location = new System.Drawing.Point(15, 26);
            this.flatLabel5.Name = "flatLabel5";
            this.flatLabel5.Size = new System.Drawing.Size(26, 20);
            this.flatLabel5.TabIndex = 2;
            this.flatLabel5.Text = "CP";
            // 
            // btnCP
            // 
            this.btnCP.BackColor = System.Drawing.Color.Transparent;
            this.btnCP.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnCP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCP.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCP.Location = new System.Drawing.Point(259, 14);
            this.btnCP.Name = "btnCP";
            this.btnCP.Rounded = false;
            this.btnCP.Size = new System.Drawing.Size(103, 44);
            this.btnCP.TabIndex = 0;
            this.btnCP.Text = "Set";
            this.btnCP.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnCP.Click += new System.EventHandler(this.btnCP_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel5.Controls.Add(this.tglGauge);
            this.panel5.Controls.Add(this.flatLabel4);
            this.panel5.Location = new System.Drawing.Point(383, 82);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(369, 73);
            this.panel5.TabIndex = 47;
            // 
            // tglGauge
            // 
            this.tglGauge.BackColor = System.Drawing.Color.Transparent;
            this.tglGauge.Checked = false;
            this.tglGauge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tglGauge.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tglGauge.Location = new System.Drawing.Point(277, 19);
            this.tglGauge.Name = "tglGauge";
            this.tglGauge.Options = theme.FlatToggle._Options.Style3;
            this.tglGauge.Size = new System.Drawing.Size(76, 33);
            this.tglGauge.TabIndex = 3;
            this.tglGauge.Text = "flatToggle1";
            this.tglGauge.CheckedChanged += new theme.FlatToggle.CheckedChangedEventHandler(this.tglGauge_CheckedChanged);
            // 
            // flatLabel4
            // 
            this.flatLabel4.AutoSize = true;
            this.flatLabel4.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel4.ForeColor = System.Drawing.Color.White;
            this.flatLabel4.Location = new System.Drawing.Point(15, 25);
            this.flatLabel4.Name = "flatLabel4";
            this.flatLabel4.Size = new System.Drawing.Size(102, 20);
            this.flatLabel4.TabIndex = 2;
            this.flatLabel4.Text = "Infinite Gauge";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel4.Controls.Add(this.tglEXP);
            this.panel4.Controls.Add(this.flatLabel2);
            this.panel4.Location = new System.Drawing.Point(3, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(374, 73);
            this.panel4.TabIndex = 46;
            // 
            // tglEXP
            // 
            this.tglEXP.BackColor = System.Drawing.Color.Transparent;
            this.tglEXP.Checked = false;
            this.tglEXP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tglEXP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tglEXP.Location = new System.Drawing.Point(286, 19);
            this.tglEXP.Name = "tglEXP";
            this.tglEXP.Options = theme.FlatToggle._Options.Style3;
            this.tglEXP.Size = new System.Drawing.Size(76, 33);
            this.tglEXP.TabIndex = 4;
            this.tglEXP.Text = "flatToggle1";
            this.tglEXP.CheckedChanged += new theme.FlatToggle.CheckedChangedEventHandler(this.tglEXP_CheckedChanged);
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(15, 26);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(165, 20);
            this.flatLabel2.TabIndex = 2;
            this.flatLabel2.Text = "Experience / Skill Points";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel3.Controls.Add(this.tglGodMode);
            this.panel3.Controls.Add(this.flatLabel1);
            this.panel3.Location = new System.Drawing.Point(383, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(369, 73);
            this.panel3.TabIndex = 46;
            // 
            // tglGodMode
            // 
            this.tglGodMode.BackColor = System.Drawing.Color.Transparent;
            this.tglGodMode.Checked = false;
            this.tglGodMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tglGodMode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tglGodMode.Location = new System.Drawing.Point(277, 18);
            this.tglGodMode.Name = "tglGodMode";
            this.tglGodMode.Options = theme.FlatToggle._Options.Style3;
            this.tglGodMode.Size = new System.Drawing.Size(76, 33);
            this.tglGodMode.TabIndex = 3;
            this.tglGodMode.Text = "flatToggle1";
            this.tglGodMode.CheckedChanged += new theme.FlatToggle.CheckedChangedEventHandler(this.tglGodMode_CheckedChanged);
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(15, 25);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(103, 20);
            this.flatLabel1.TabIndex = 2;
            this.flatLabel1.Text = "Infinite Health";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel2.Controls.Add(this.numMoney);
            this.panel2.Controls.Add(this.flatLabel3);
            this.panel2.Controls.Add(this.btnMoney);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 73);
            this.panel2.TabIndex = 45;
            // 
            // numMoney
            // 
            this.numMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.numMoney.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.numMoney.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.numMoney.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numMoney.ForeColor = System.Drawing.Color.White;
            this.numMoney.Location = new System.Drawing.Point(84, 21);
            this.numMoney.Maximum = ((long)(99999999));
            this.numMoney.Minimum = ((long)(0));
            this.numMoney.Name = "numMoney";
            this.numMoney.Size = new System.Drawing.Size(154, 30);
            this.numMoney.TabIndex = 3;
            this.numMoney.Text = "flatNumeric1";
            this.numMoney.Value = ((long)(0));
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(15, 26);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(54, 20);
            this.flatLabel3.TabIndex = 2;
            this.flatLabel3.Text = "Money";
            // 
            // btnMoney
            // 
            this.btnMoney.BackColor = System.Drawing.Color.Transparent;
            this.btnMoney.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnMoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoney.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMoney.Location = new System.Drawing.Point(259, 14);
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Rounded = false;
            this.btnMoney.Size = new System.Drawing.Size(103, 44);
            this.btnMoney.TabIndex = 0;
            this.btnMoney.Text = "Set";
            this.btnMoney.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnMoney.Click += new System.EventHandler(this.btnMoney_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(346, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 70;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 28);
            this.label4.TabIndex = 68;
            this.label4.Text = "Cheater : Weysincha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.label3.Location = new System.Drawing.Point(389, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 28);
            this.label3.TabIndex = 67;
            this.label3.Text = "CUSA07615";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.label1.Location = new System.Drawing.Point(312, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 28);
            this.label1.TabIndex = 66;
            this.label1.Text = "Game Version : 1.00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(518, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // tmrHealth
            // 
            this.tmrHealth.Interval = 500;
            this.tmrHealth.Tick += new System.EventHandler(this.tmrHealth_Tick);
            // 
            // tmrGauge
            // 
            this.tmrGauge.Interval = 500;
            this.tmrGauge.Tick += new System.EventHandler(this.tmrGauge_Tick);
            // 
            // tmrEXP
            // 
            this.tmrEXP.Interval = 500;
            this.tmrEXP.Tick += new System.EventHandler(this.tmrEXP_Tick);
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
            this.btnAttach.TabIndex = 71;
            this.btnAttach.Text = "Attach";
            this.btnAttach.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // YakuzaKiwami
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "YakuzaKiwami";
            this.Size = new System.Drawing.Size(758, 455);
            this.Load += new System.EventHandler(this.YakuzaKiwami_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private theme.FlatLabel flatLabel1;
        private System.Windows.Forms.Panel panel2;
        private theme.FlatNumeric numMoney;
        private theme.FlatLabel flatLabel3;
        private theme.FlatButton btnMoney;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private theme.FlatToggle tglGodMode;
        private System.Windows.Forms.Timer tmrHealth;
        private System.Windows.Forms.Panel panel6;
        private theme.FlatNumeric numCP;
        private theme.FlatLabel flatLabel5;
        private theme.FlatButton btnCP;
        private System.Windows.Forms.Panel panel5;
        private theme.FlatToggle tglGauge;
        private theme.FlatLabel flatLabel4;
        private System.Windows.Forms.Panel panel4;
        private theme.FlatLabel flatLabel2;
        private System.Windows.Forms.Timer tmrGauge;
        private theme.FlatToggle tglEXP;
        private System.Windows.Forms.Timer tmrEXP;
        private theme.FlatButton btnAttach;
    }
}
