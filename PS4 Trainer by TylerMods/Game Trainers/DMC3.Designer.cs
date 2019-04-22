namespace PS4_Trainer_by_TylerMods.Game_Trainers
{
    partial class DMC3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMC3));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numRO = new theme.FlatNumeric();
            this.btnRO = new theme.FlatButton();
            this.flatLabel1 = new theme.FlatLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tglZeroDamage = new theme.FlatToggle();
            this.flatLabel4 = new theme.FlatLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tglVergilTrigger = new theme.FlatToggle();
            this.flatLabel2 = new theme.FlatLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tglHealth = new theme.FlatToggle();
            this.flatLabel3 = new theme.FlatLabel();
            this.btnAttach = new theme.FlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmrHealth = new System.Windows.Forms.Timer(this.components);
            this.tmrVergilTrigger = new System.Windows.Forms.Timer(this.components);
            this.tmrZeroDamage = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(337, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 78;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 349);
            this.panel1.TabIndex = 77;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel3.Controls.Add(this.numRO);
            this.panel3.Controls.Add(this.btnRO);
            this.panel3.Controls.Add(this.flatLabel1);
            this.panel3.Location = new System.Drawing.Point(380, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(375, 73);
            this.panel3.TabIndex = 50;
            // 
            // numRO
            // 
            this.numRO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.numRO.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.numRO.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.numRO.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numRO.ForeColor = System.Drawing.Color.White;
            this.numRO.Location = new System.Drawing.Point(108, 22);
            this.numRO.Maximum = ((long)(9999999));
            this.numRO.Minimum = ((long)(0));
            this.numRO.Name = "numRO";
            this.numRO.Size = new System.Drawing.Size(145, 30);
            this.numRO.TabIndex = 5;
            this.numRO.Text = "flatNumeric1";
            this.numRO.Value = ((long)(0));
            // 
            // btnRO
            // 
            this.btnRO.BackColor = System.Drawing.Color.Transparent;
            this.btnRO.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnRO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRO.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRO.Location = new System.Drawing.Point(259, 16);
            this.btnRO.Name = "btnRO";
            this.btnRO.Rounded = false;
            this.btnRO.Size = new System.Drawing.Size(109, 44);
            this.btnRO.TabIndex = 4;
            this.btnRO.Text = "Set";
            this.btnRO.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnRO.Click += new System.EventHandler(this.btnRO_Click);
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(15, 26);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(70, 20);
            this.flatLabel1.TabIndex = 2;
            this.flatLabel1.Text = "Red Orbs";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel5.Controls.Add(this.tglZeroDamage);
            this.panel5.Controls.Add(this.flatLabel4);
            this.panel5.Location = new System.Drawing.Point(380, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(375, 73);
            this.panel5.TabIndex = 49;
            // 
            // tglZeroDamage
            // 
            this.tglZeroDamage.BackColor = System.Drawing.Color.Transparent;
            this.tglZeroDamage.Checked = false;
            this.tglZeroDamage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tglZeroDamage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tglZeroDamage.Location = new System.Drawing.Point(292, 21);
            this.tglZeroDamage.Name = "tglZeroDamage";
            this.tglZeroDamage.Options = theme.FlatToggle._Options.Style3;
            this.tglZeroDamage.Size = new System.Drawing.Size(76, 33);
            this.tglZeroDamage.TabIndex = 49;
            this.tglZeroDamage.Text = "flatToggle1";
            this.tglZeroDamage.CheckedChanged += new theme.FlatToggle.CheckedChangedEventHandler(this.flatToggle1_CheckedChanged);
            // 
            // flatLabel4
            // 
            this.flatLabel4.AutoSize = true;
            this.flatLabel4.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel4.ForeColor = System.Drawing.Color.White;
            this.flatLabel4.Location = new System.Drawing.Point(13, 24);
            this.flatLabel4.Name = "flatLabel4";
            this.flatLabel4.Size = new System.Drawing.Size(101, 20);
            this.flatLabel4.TabIndex = 2;
            this.flatLabel4.Text = "Zero Damage";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel4.Controls.Add(this.tglVergilTrigger);
            this.panel4.Controls.Add(this.flatLabel2);
            this.panel4.Location = new System.Drawing.Point(3, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(372, 73);
            this.panel4.TabIndex = 49;
            // 
            // tglVergilTrigger
            // 
            this.tglVergilTrigger.BackColor = System.Drawing.Color.Transparent;
            this.tglVergilTrigger.Checked = false;
            this.tglVergilTrigger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tglVergilTrigger.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tglVergilTrigger.Location = new System.Drawing.Point(286, 19);
            this.tglVergilTrigger.Name = "tglVergilTrigger";
            this.tglVergilTrigger.Options = theme.FlatToggle._Options.Style3;
            this.tglVergilTrigger.Size = new System.Drawing.Size(76, 33);
            this.tglVergilTrigger.TabIndex = 48;
            this.tglVergilTrigger.Text = "flatToggle1";
            this.tglVergilTrigger.CheckedChanged += new theme.FlatToggle.CheckedChangedEventHandler(this.tglVergilTrigger_CheckedChanged);
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(15, 26);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(150, 20);
            this.flatLabel2.TabIndex = 2;
            this.flatLabel2.Text = "Infinite Death Trigger";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel2.Controls.Add(this.tglHealth);
            this.panel2.Controls.Add(this.flatLabel3);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 73);
            this.panel2.TabIndex = 45;
            // 
            // tglHealth
            // 
            this.tglHealth.BackColor = System.Drawing.Color.Transparent;
            this.tglHealth.Checked = false;
            this.tglHealth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tglHealth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tglHealth.Location = new System.Drawing.Point(286, 21);
            this.tglHealth.Name = "tglHealth";
            this.tglHealth.Options = theme.FlatToggle._Options.Style3;
            this.tglHealth.Size = new System.Drawing.Size(76, 33);
            this.tglHealth.TabIndex = 48;
            this.tglHealth.Text = "flatToggle1";
            this.tglHealth.CheckedChanged += new theme.FlatToggle.CheckedChangedEventHandler(this.tglHealth_CheckedChanged);
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(15, 26);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(199, 20);
            this.flatLabel3.TabIndex = 2;
            this.flatLabel3.Text = "Dante / Vergil Infinite Health";
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
            this.btnAttach.TabIndex = 72;
            this.btnAttach.Text = "Attach";
            this.btnAttach.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 28);
            this.label4.TabIndex = 76;
            this.label4.Text = "Cheater : Breheim + t3fury";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.label3.Location = new System.Drawing.Point(395, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 28);
            this.label3.TabIndex = 75;
            this.label3.Text = "CUSA09263";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.label1.Location = new System.Drawing.Point(329, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 28);
            this.label1.TabIndex = 74;
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
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // tmrHealth
            // 
            this.tmrHealth.Interval = 500;
            this.tmrHealth.Tick += new System.EventHandler(this.tmrHealth_Tick);
            // 
            // tmrVergilTrigger
            // 
            this.tmrVergilTrigger.Interval = 500;
            this.tmrVergilTrigger.Tick += new System.EventHandler(this.tmrVergilTrigger_Tick);
            // 
            // tmrZeroDamage
            // 
            this.tmrZeroDamage.Interval = 500;
            this.tmrZeroDamage.Tick += new System.EventHandler(this.tmrZeroDamage_Tick);
            // 
            // DMC3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DMC3";
            this.Size = new System.Drawing.Size(758, 455);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private theme.FlatButton btnAttach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private theme.FlatLabel flatLabel3;
        private theme.FlatToggle tglHealth;
        private System.Windows.Forms.Timer tmrHealth;
        private System.Windows.Forms.Timer tmrVergilTrigger;
        private System.Windows.Forms.Panel panel5;
        private theme.FlatLabel flatLabel4;
        private System.Windows.Forms.Panel panel4;
        private theme.FlatToggle tglVergilTrigger;
        private theme.FlatLabel flatLabel2;
        private theme.FlatToggle tglZeroDamage;
        private System.Windows.Forms.Timer tmrZeroDamage;
        private System.Windows.Forms.Panel panel3;
        private theme.FlatLabel flatLabel1;
        private theme.FlatNumeric numRO;
        private theme.FlatButton btnRO;
    }
}
