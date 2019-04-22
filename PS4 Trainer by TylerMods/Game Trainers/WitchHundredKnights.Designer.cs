namespace PS4_Trainer_by_TylerMods.Game_Trainers
{
    partial class WitchHundredKnights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WitchHundredKnights));
            this.btnMana = new theme.FlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.flatLabel1 = new theme.FlatLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numMana = new theme.FlatNumeric();
            this.tmr1Kill = new System.Windows.Forms.Timer(this.components);
            this.flatLabel3 = new theme.FlatLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tgl1Kill = new theme.FlatToggle();
            this.flatLabel4 = new theme.FlatLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flatLabel2 = new theme.FlatLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAttach = new theme.FlatButton();
            this.numLevel = new theme.FlatNumeric();
            this.btnLevel = new theme.FlatButton();
            this.numSkillPoints = new theme.FlatNumeric();
            this.btnSkillPoints = new theme.FlatButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnMaxSkills = new theme.FlatButton();
            this.flatLabel5 = new theme.FlatLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMana
            // 
            this.btnMana.BackColor = System.Drawing.Color.Transparent;
            this.btnMana.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnMana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMana.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMana.Location = new System.Drawing.Point(259, 16);
            this.btnMana.Name = "btnMana";
            this.btnMana.Rounded = false;
            this.btnMana.Size = new System.Drawing.Size(109, 44);
            this.btnMana.TabIndex = 4;
            this.btnMana.Text = "Set";
            this.btnMana.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnMana.Click += new System.EventHandler(this.btnMana_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(337, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 85;
            this.pictureBox2.TabStop = false;
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(15, 26);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(46, 20);
            this.flatLabel1.TabIndex = 2;
            this.flatLabel1.Text = "Mana";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel3.Controls.Add(this.numMana);
            this.panel3.Controls.Add(this.btnMana);
            this.panel3.Controls.Add(this.flatLabel1);
            this.panel3.Location = new System.Drawing.Point(380, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(375, 73);
            this.panel3.TabIndex = 50;
            // 
            // numMana
            // 
            this.numMana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.numMana.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.numMana.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.numMana.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numMana.ForeColor = System.Drawing.Color.White;
            this.numMana.Location = new System.Drawing.Point(108, 22);
            this.numMana.Maximum = ((long)(9999999));
            this.numMana.Minimum = ((long)(0));
            this.numMana.Name = "numMana";
            this.numMana.Size = new System.Drawing.Size(145, 30);
            this.numMana.TabIndex = 5;
            this.numMana.Text = "flatNumeric1";
            this.numMana.Value = ((long)(0));
            // 
            // tmr1Kill
            // 
            this.tmr1Kill.Interval = 500;
            this.tmr1Kill.Tick += new System.EventHandler(this.tmr1Kill_Tick);
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(15, 26);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(79, 20);
            this.flatLabel3.TabIndex = 2;
            this.flatLabel3.Text = "Skill Points";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 349);
            this.panel1.TabIndex = 84;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel5.Controls.Add(this.tgl1Kill);
            this.panel5.Controls.Add(this.flatLabel4);
            this.panel5.Location = new System.Drawing.Point(380, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(375, 73);
            this.panel5.TabIndex = 49;
            // 
            // tgl1Kill
            // 
            this.tgl1Kill.BackColor = System.Drawing.Color.Transparent;
            this.tgl1Kill.Checked = false;
            this.tgl1Kill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tgl1Kill.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tgl1Kill.Location = new System.Drawing.Point(292, 21);
            this.tgl1Kill.Name = "tgl1Kill";
            this.tgl1Kill.Options = theme.FlatToggle._Options.Style3;
            this.tgl1Kill.Size = new System.Drawing.Size(76, 33);
            this.tgl1Kill.TabIndex = 49;
            this.tgl1Kill.Text = "flatToggle1";
            this.tgl1Kill.CheckedChanged += new theme.FlatToggle.CheckedChangedEventHandler(this.tgl1Kill_CheckedChanged);
            // 
            // flatLabel4
            // 
            this.flatLabel4.AutoSize = true;
            this.flatLabel4.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel4.ForeColor = System.Drawing.Color.White;
            this.flatLabel4.Location = new System.Drawing.Point(13, 24);
            this.flatLabel4.Name = "flatLabel4";
            this.flatLabel4.Size = new System.Drawing.Size(103, 20);
            this.flatLabel4.TabIndex = 2;
            this.flatLabel4.Text = "1 Kill Level Up";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel4.Controls.Add(this.numLevel);
            this.panel4.Controls.Add(this.btnLevel);
            this.panel4.Controls.Add(this.flatLabel2);
            this.panel4.Location = new System.Drawing.Point(3, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(368, 73);
            this.panel4.TabIndex = 49;
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(15, 26);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(43, 20);
            this.flatLabel2.TabIndex = 2;
            this.flatLabel2.Text = "Level";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel2.Controls.Add(this.numSkillPoints);
            this.panel2.Controls.Add(this.flatLabel3);
            this.panel2.Controls.Add(this.btnSkillPoints);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 73);
            this.panel2.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 28);
            this.label4.TabIndex = 83;
            this.label4.Text = "Cheater : TylerMods";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.label3.Location = new System.Drawing.Point(395, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 28);
            this.label3.TabIndex = 82;
            this.label3.Text = "CUSA10135";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.label1.Location = new System.Drawing.Point(329, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 28);
            this.label1.TabIndex = 81;
            this.label1.Text = "Game Version 1.00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(518, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
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
            this.btnAttach.TabIndex = 79;
            this.btnAttach.Text = "Attach";
            this.btnAttach.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // numLevel
            // 
            this.numLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.numLevel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.numLevel.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.numLevel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numLevel.ForeColor = System.Drawing.Color.White;
            this.numLevel.Location = new System.Drawing.Point(111, 22);
            this.numLevel.Maximum = ((long)(9999999));
            this.numLevel.Minimum = ((long)(0));
            this.numLevel.Name = "numLevel";
            this.numLevel.Size = new System.Drawing.Size(136, 30);
            this.numLevel.TabIndex = 7;
            this.numLevel.Text = "flatNumeric1";
            this.numLevel.Value = ((long)(0));
            // 
            // btnLevel
            // 
            this.btnLevel.BackColor = System.Drawing.Color.Transparent;
            this.btnLevel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLevel.Location = new System.Drawing.Point(253, 16);
            this.btnLevel.Name = "btnLevel";
            this.btnLevel.Rounded = false;
            this.btnLevel.Size = new System.Drawing.Size(109, 44);
            this.btnLevel.TabIndex = 6;
            this.btnLevel.Text = "Set";
            this.btnLevel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnLevel.Click += new System.EventHandler(this.btnLevel_Click);
            // 
            // numSkillPoints
            // 
            this.numSkillPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.numSkillPoints.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.numSkillPoints.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.numSkillPoints.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numSkillPoints.ForeColor = System.Drawing.Color.White;
            this.numSkillPoints.Location = new System.Drawing.Point(111, 23);
            this.numSkillPoints.Maximum = ((long)(9999999));
            this.numSkillPoints.Minimum = ((long)(0));
            this.numSkillPoints.Name = "numSkillPoints";
            this.numSkillPoints.Size = new System.Drawing.Size(136, 30);
            this.numSkillPoints.TabIndex = 9;
            this.numSkillPoints.Text = "flatNumeric2";
            this.numSkillPoints.Value = ((long)(0));
            // 
            // btnSkillPoints
            // 
            this.btnSkillPoints.BackColor = System.Drawing.Color.Transparent;
            this.btnSkillPoints.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnSkillPoints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSkillPoints.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSkillPoints.Location = new System.Drawing.Point(253, 17);
            this.btnSkillPoints.Name = "btnSkillPoints";
            this.btnSkillPoints.Rounded = false;
            this.btnSkillPoints.Size = new System.Drawing.Size(109, 44);
            this.btnSkillPoints.TabIndex = 8;
            this.btnSkillPoints.Text = "Set";
            this.btnSkillPoints.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnSkillPoints.Click += new System.EventHandler(this.btnSkillPoints_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel6.Controls.Add(this.btnMaxSkills);
            this.panel6.Controls.Add(this.flatLabel5);
            this.panel6.Location = new System.Drawing.Point(3, 161);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(368, 73);
            this.panel6.TabIndex = 50;
            // 
            // btnMaxSkills
            // 
            this.btnMaxSkills.BackColor = System.Drawing.Color.Transparent;
            this.btnMaxSkills.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnMaxSkills.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaxSkills.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMaxSkills.Location = new System.Drawing.Point(253, 16);
            this.btnMaxSkills.Name = "btnMaxSkills";
            this.btnMaxSkills.Rounded = false;
            this.btnMaxSkills.Size = new System.Drawing.Size(109, 44);
            this.btnMaxSkills.TabIndex = 6;
            this.btnMaxSkills.Text = "Set";
            this.btnMaxSkills.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnMaxSkills.Click += new System.EventHandler(this.btnMaxSkills_Click);
            // 
            // flatLabel5
            // 
            this.flatLabel5.AutoSize = true;
            this.flatLabel5.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel5.ForeColor = System.Drawing.Color.White;
            this.flatLabel5.Location = new System.Drawing.Point(15, 26);
            this.flatLabel5.Name = "flatLabel5";
            this.flatLabel5.Size = new System.Drawing.Size(74, 20);
            this.flatLabel5.TabIndex = 2;
            this.flatLabel5.Text = "Max Skills";
            // 
            // WitchHundredKnights
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAttach);
            this.Name = "WitchHundredKnights";
            this.Size = new System.Drawing.Size(758, 455);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private theme.FlatButton btnMana;
        private System.Windows.Forms.PictureBox pictureBox2;
        private theme.FlatLabel flatLabel1;
        private System.Windows.Forms.Panel panel3;
        private theme.FlatNumeric numMana;
        private System.Windows.Forms.Timer tmr1Kill;
        private theme.FlatLabel flatLabel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private theme.FlatToggle tgl1Kill;
        private theme.FlatLabel flatLabel4;
        private System.Windows.Forms.Panel panel4;
        private theme.FlatLabel flatLabel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private theme.FlatButton btnAttach;
        private theme.FlatNumeric numLevel;
        private theme.FlatButton btnLevel;
        private theme.FlatNumeric numSkillPoints;
        private theme.FlatButton btnSkillPoints;
        private System.Windows.Forms.Panel panel6;
        private theme.FlatButton btnMaxSkills;
        private theme.FlatLabel flatLabel5;
    }
}
