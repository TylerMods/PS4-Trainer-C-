namespace PS4_Trainer_by_TylerMods.Game_Trainers
{
    partial class FFXV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFXV));
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numNocticHealth = new theme.FlatNumeric();
            this.flatLabel1 = new theme.FlatLabel();
            this.tglNoctisMP = new theme.FlatToggle();
            this.panel7 = new System.Windows.Forms.Panel();
            this.flatLabel6 = new theme.FlatLabel();
            this.tglHealth = new theme.FlatToggle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numEXP = new theme.FlatNumeric();
            this.flatLabel2 = new theme.FlatLabel();
            this.btnSP = new theme.FlatButton();
            this.tmrHealth = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.btnAttach = new theme.FlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFAQ = new theme.FlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tmrNoctisMP = new System.Windows.Forms.Timer(this.components);
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.label1.Location = new System.Drawing.Point(312, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 28);
            this.label1.TabIndex = 97;
            this.label1.Text = "Game Version : 1.23";
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Location = new System.Drawing.Point(0, 109);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(758, 344);
            this.panel5.TabIndex = 99;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.flatLabel1);
            this.panel1.Controls.Add(this.tglNoctisMP);
            this.panel1.Location = new System.Drawing.Point(3, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 73);
            this.panel1.TabIndex = 46;
            // 
            // numNocticHealth
            // 
            this.numNocticHealth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.numNocticHealth.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.numNocticHealth.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.numNocticHealth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numNocticHealth.ForeColor = System.Drawing.Color.White;
            this.numNocticHealth.Location = new System.Drawing.Point(119, 21);
            this.numNocticHealth.Maximum = ((long)(99999999));
            this.numNocticHealth.Minimum = ((long)(0));
            this.numNocticHealth.Name = "numNocticHealth";
            this.numNocticHealth.Size = new System.Drawing.Size(145, 30);
            this.numNocticHealth.TabIndex = 4;
            this.numNocticHealth.Text = "flatNumeric1";
            this.numNocticHealth.Value = ((long)(0));
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(14, 26);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(76, 20);
            this.flatLabel1.TabIndex = 2;
            this.flatLabel1.Text = "Noctis MP";
            // 
            // tglNoctisMP
            // 
            this.tglNoctisMP.BackColor = System.Drawing.Color.Transparent;
            this.tglNoctisMP.Checked = false;
            this.tglNoctisMP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tglNoctisMP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tglNoctisMP.Location = new System.Drawing.Point(278, 18);
            this.tglNoctisMP.Name = "tglNoctisMP";
            this.tglNoctisMP.Options = theme.FlatToggle._Options.Style3;
            this.tglNoctisMP.Size = new System.Drawing.Size(76, 33);
            this.tglNoctisMP.TabIndex = 1;
            this.tglNoctisMP.Text = "flatToggle1";
            this.tglNoctisMP.CheckedChanged += new theme.FlatToggle.CheckedChangedEventHandler(this.tglNoctisMP_CheckedChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel7.Controls.Add(this.numNocticHealth);
            this.panel7.Controls.Add(this.flatLabel6);
            this.panel7.Controls.Add(this.tglHealth);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(375, 73);
            this.panel7.TabIndex = 45;
            // 
            // flatLabel6
            // 
            this.flatLabel6.AutoSize = true;
            this.flatLabel6.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel6.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel6.ForeColor = System.Drawing.Color.White;
            this.flatLabel6.Location = new System.Drawing.Point(14, 26);
            this.flatLabel6.Name = "flatLabel6";
            this.flatLabel6.Size = new System.Drawing.Size(99, 20);
            this.flatLabel6.TabIndex = 2;
            this.flatLabel6.Text = "Noctis Health";
            // 
            // tglHealth
            // 
            this.tglHealth.BackColor = System.Drawing.Color.Transparent;
            this.tglHealth.Checked = false;
            this.tglHealth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tglHealth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tglHealth.Location = new System.Drawing.Point(278, 18);
            this.tglHealth.Name = "tglHealth";
            this.tglHealth.Options = theme.FlatToggle._Options.Style3;
            this.tglHealth.Size = new System.Drawing.Size(76, 33);
            this.tglHealth.TabIndex = 1;
            this.tglHealth.Text = "flatToggle1";
            this.tglHealth.CheckedChanged += new theme.FlatToggle.CheckedChangedEventHandler(this.tglHealth_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel2.Controls.Add(this.numEXP);
            this.panel2.Controls.Add(this.flatLabel2);
            this.panel2.Controls.Add(this.btnSP);
            this.panel2.Location = new System.Drawing.Point(380, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 73);
            this.panel2.TabIndex = 46;
            // 
            // numEXP
            // 
            this.numEXP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.numEXP.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.numEXP.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.numEXP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numEXP.ForeColor = System.Drawing.Color.White;
            this.numEXP.Location = new System.Drawing.Point(104, 21);
            this.numEXP.Maximum = ((long)(99999999));
            this.numEXP.Minimum = ((long)(0));
            this.numEXP.Name = "numEXP";
            this.numEXP.Size = new System.Drawing.Size(145, 30);
            this.numEXP.TabIndex = 3;
            this.numEXP.Text = "flatNumeric1";
            this.numEXP.Value = ((long)(0));
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(14, 26);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(80, 20);
            this.flatLabel2.TabIndex = 2;
            this.flatLabel2.Text = "Noctis EXP";
            // 
            // btnSP
            // 
            this.btnSP.BackColor = System.Drawing.Color.Transparent;
            this.btnSP.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSP.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSP.Location = new System.Drawing.Point(255, 14);
            this.btnSP.Name = "btnSP";
            this.btnSP.Rounded = false;
            this.btnSP.Size = new System.Drawing.Size(117, 44);
            this.btnSP.TabIndex = 0;
            this.btnSP.Text = "Set";
            this.btnSP.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnSP.Click += new System.EventHandler(this.btnSP_Click);
            // 
            // tmrHealth
            // 
            this.tmrHealth.Interval = 500;
            this.tmrHealth.Tick += new System.EventHandler(this.tmrHealth_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 28);
            this.label4.TabIndex = 100;
            this.label4.Text = "Cheater : Darkmage1991";
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
            this.btnAttach.TabIndex = 94;
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
            this.label3.TabIndex = 98;
            this.label3.Text = "CUSA01615";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(518, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
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
            this.btnFAQ.TabIndex = 95;
            this.btnFAQ.Text = "?";
            this.btnFAQ.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnFAQ.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(351, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 101;
            this.pictureBox2.TabStop = false;
            // 
            // tmrNoctisMP
            // 
            this.tmrNoctisMP.Interval = 500;
            this.tmrNoctisMP.Tick += new System.EventHandler(this.tmrNoctisMP_Tick);
            // 
            // FFXV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFAQ);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FFXV";
            this.Size = new System.Drawing.Size(758, 455);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private theme.FlatLabel flatLabel6;
        private theme.FlatToggle tglHealth;
        private System.Windows.Forms.Panel panel2;
        private theme.FlatNumeric numEXP;
        private theme.FlatLabel flatLabel2;
        private theme.FlatButton btnSP;
        private System.Windows.Forms.Timer tmrHealth;
        private System.Windows.Forms.Label label4;
        private theme.FlatButton btnAttach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private theme.FlatButton btnFAQ;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private theme.FlatLabel flatLabel1;
        private theme.FlatToggle tglNoctisMP;
        private System.Windows.Forms.Timer tmrNoctisMP;
        private theme.FlatNumeric numNocticHealth;
    }
}
