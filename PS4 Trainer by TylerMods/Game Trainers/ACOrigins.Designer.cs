namespace PS4_Trainer_by_TylerMods.Game_Trainers
{
    partial class ACOrigins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACOrigins));
            this.btnAttach = new theme.FlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlHealth = new System.Windows.Forms.Panel();
            this.tglHealth = new theme.FlatToggle();
            this.flatLabel2 = new theme.FlatLabel();
            this.pnlEXP = new System.Windows.Forms.Panel();
            this.numEXP = new theme.FlatNumeric();
            this.flatLabel1 = new theme.FlatLabel();
            this.btnEXP = new theme.FlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlAbilityPoints = new System.Windows.Forms.Panel();
            this.tglAbilityPoints = new theme.FlatToggle();
            this.flatLabel5 = new theme.FlatLabel();
            this.pnlMoney = new System.Windows.Forms.Panel();
            this.tglMoney = new theme.FlatToggle();
            this.flatLabel4 = new theme.FlatLabel();
            this.pnlAmmo = new System.Windows.Forms.Panel();
            this.tglAmmo = new theme.FlatToggle();
            this.flatLabel3 = new theme.FlatLabel();
            this.tmrHealth = new System.Windows.Forms.Timer(this.components);
            this.btnCheaters = new theme.FlatButton();
            this.cmbVersion = new theme.FlatComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHealth.SuspendLayout();
            this.pnlEXP.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlAbilityPoints.SuspendLayout();
            this.pnlMoney.SuspendLayout();
            this.pnlAmmo.SuspendLayout();
            this.SuspendLayout();
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
            this.btnAttach.TabIndex = 97;
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
            this.pictureBox2.TabIndex = 96;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.label3.TabIndex = 93;
            this.label3.Text = "CUSA05625";
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
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
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
            this.pnlEXP.Controls.Add(this.numEXP);
            this.pnlEXP.Controls.Add(this.flatLabel1);
            this.pnlEXP.Controls.Add(this.btnEXP);
            this.pnlEXP.Location = new System.Drawing.Point(381, 3);
            this.pnlEXP.Name = "pnlEXP";
            this.pnlEXP.Size = new System.Drawing.Size(374, 73);
            this.pnlEXP.TabIndex = 46;
            // 
            // numEXP
            // 
            this.numEXP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.numEXP.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.numEXP.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.numEXP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numEXP.ForeColor = System.Drawing.Color.White;
            this.numEXP.Location = new System.Drawing.Point(103, 20);
            this.numEXP.Maximum = ((long)(9999999));
            this.numEXP.Minimum = ((long)(0));
            this.numEXP.Name = "numEXP";
            this.numEXP.Size = new System.Drawing.Size(145, 30);
            this.numEXP.TabIndex = 3;
            this.numEXP.Text = "flatNumeric1";
            this.numEXP.Value = ((long)(0));
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(13, 24);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(34, 20);
            this.flatLabel1.TabIndex = 2;
            this.flatLabel1.Text = "EXP";
            // 
            // btnEXP
            // 
            this.btnEXP.BackColor = System.Drawing.Color.Transparent;
            this.btnEXP.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnEXP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEXP.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEXP.Location = new System.Drawing.Point(254, 14);
            this.btnEXP.Name = "btnEXP";
            this.btnEXP.Rounded = false;
            this.btnEXP.Size = new System.Drawing.Size(112, 44);
            this.btnEXP.TabIndex = 0;
            this.btnEXP.Text = "Set";
            this.btnEXP.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnEXP.Click += new System.EventHandler(this.btnEXP_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.pnlAbilityPoints);
            this.panel1.Controls.Add(this.pnlMoney);
            this.panel1.Controls.Add(this.pnlAmmo);
            this.panel1.Controls.Add(this.pnlHealth);
            this.panel1.Controls.Add(this.pnlEXP);
            this.panel1.Location = new System.Drawing.Point(0, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 349);
            this.panel1.TabIndex = 95;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlAbilityPoints
            // 
            this.pnlAbilityPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.pnlAbilityPoints.Controls.Add(this.tglAbilityPoints);
            this.pnlAbilityPoints.Controls.Add(this.flatLabel5);
            this.pnlAbilityPoints.Location = new System.Drawing.Point(3, 161);
            this.pnlAbilityPoints.Name = "pnlAbilityPoints";
            this.pnlAbilityPoints.Size = new System.Drawing.Size(375, 73);
            this.pnlAbilityPoints.TabIndex = 49;
            // 
            // tglAbilityPoints
            // 
            this.tglAbilityPoints.BackColor = System.Drawing.Color.Transparent;
            this.tglAbilityPoints.Checked = false;
            this.tglAbilityPoints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tglAbilityPoints.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tglAbilityPoints.Location = new System.Drawing.Point(287, 19);
            this.tglAbilityPoints.Name = "tglAbilityPoints";
            this.tglAbilityPoints.Options = theme.FlatToggle._Options.Style3;
            this.tglAbilityPoints.Size = new System.Drawing.Size(76, 33);
            this.tglAbilityPoints.TabIndex = 5;
            this.tglAbilityPoints.Text = "flatToggle1";
            this.tglAbilityPoints.CheckedChanged += new theme.FlatToggle.CheckedChangedEventHandler(this.tglAbilityPoints_CheckedChanged);
            // 
            // flatLabel5
            // 
            this.flatLabel5.AutoSize = true;
            this.flatLabel5.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel5.ForeColor = System.Drawing.Color.White;
            this.flatLabel5.Location = new System.Drawing.Point(13, 24);
            this.flatLabel5.Name = "flatLabel5";
            this.flatLabel5.Size = new System.Drawing.Size(145, 20);
            this.flatLabel5.TabIndex = 2;
            this.flatLabel5.Text = "Infinite Ability Points";
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
            // pnlAmmo
            // 
            this.pnlAmmo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.pnlAmmo.Controls.Add(this.tglAmmo);
            this.pnlAmmo.Controls.Add(this.flatLabel3);
            this.pnlAmmo.Location = new System.Drawing.Point(3, 82);
            this.pnlAmmo.Name = "pnlAmmo";
            this.pnlAmmo.Size = new System.Drawing.Size(375, 73);
            this.pnlAmmo.TabIndex = 48;
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
            this.flatLabel3.Size = new System.Drawing.Size(167, 20);
            this.flatLabel3.TabIndex = 2;
            this.flatLabel3.Text = "Infinite Ammo + Money";
            // 
            // tmrHealth
            // 
            this.tmrHealth.Interval = 500;
            this.tmrHealth.Tick += new System.EventHandler(this.tmrHealth_Tick);
            // 
            // btnCheaters
            // 
            this.btnCheaters.BackColor = System.Drawing.Color.Transparent;
            this.btnCheaters.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnCheaters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheaters.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCheaters.Location = new System.Drawing.Point(3, 75);
            this.btnCheaters.Name = "btnCheaters";
            this.btnCheaters.Rounded = false;
            this.btnCheaters.Size = new System.Drawing.Size(116, 28);
            this.btnCheaters.TabIndex = 98;
            this.btnCheaters.Text = "Cheaters";
            this.btnCheaters.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnCheaters.Click += new System.EventHandler(this.btnCheaters_Click);
            // 
            // cmbVersion
            // 
            this.cmbVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmbVersion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbVersion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVersion.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cmbVersion.ForeColor = System.Drawing.Color.White;
            this.cmbVersion.FormattingEnabled = true;
            this.cmbVersion.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.cmbVersion.ItemHeight = 18;
            this.cmbVersion.Items.AddRange(new object[] {
            "v1.00",
            "v1.41"});
            this.cmbVersion.Location = new System.Drawing.Point(391, 79);
            this.cmbVersion.Name = "cmbVersion";
            this.cmbVersion.Size = new System.Drawing.Size(121, 24);
            this.cmbVersion.TabIndex = 99;
            this.cmbVersion.SelectedIndexChanged += new System.EventHandler(this.cmbVersion_SelectedIndexChanged);
            // 
            // ACOrigins
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.btnCheaters);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbVersion);
            this.Name = "ACOrigins";
            this.Size = new System.Drawing.Size(758, 455);
            this.Load += new System.EventHandler(this.ACOrigins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlHealth.ResumeLayout(false);
            this.pnlHealth.PerformLayout();
            this.pnlEXP.ResumeLayout(false);
            this.pnlEXP.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlAbilityPoints.ResumeLayout(false);
            this.pnlAbilityPoints.PerformLayout();
            this.pnlMoney.ResumeLayout(false);
            this.pnlMoney.PerformLayout();
            this.pnlAmmo.ResumeLayout(false);
            this.pnlAmmo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private theme.FlatButton btnAttach;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlHealth;
        private theme.FlatToggle tglHealth;
        private theme.FlatLabel flatLabel2;
        private System.Windows.Forms.Panel pnlEXP;
        private theme.FlatNumeric numEXP;
        private theme.FlatLabel flatLabel1;
        private theme.FlatButton btnEXP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer tmrHealth;
        private System.Windows.Forms.Panel pnlAmmo;
        private theme.FlatToggle tglAmmo;
        private theme.FlatLabel flatLabel3;
        private theme.FlatButton btnCheaters;
        private theme.FlatComboBox cmbVersion;
        private System.Windows.Forms.Panel pnlMoney;
        private theme.FlatToggle tglMoney;
        private theme.FlatLabel flatLabel4;
        private System.Windows.Forms.Panel pnlAbilityPoints;
        private theme.FlatToggle tglAbilityPoints;
        private theme.FlatLabel flatLabel5;
    }
}
