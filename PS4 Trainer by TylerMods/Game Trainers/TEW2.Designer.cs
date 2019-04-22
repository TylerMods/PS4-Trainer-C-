namespace PS4_Trainer_by_TylerMods.Game_Trainers
{
    partial class TEW2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TEW2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlGel = new System.Windows.Forms.Panel();
            this.tglGel = new theme.FlatToggle();
            this.flatLabel3 = new theme.FlatLabel();
            this.pnlWeaponParts = new System.Windows.Forms.Panel();
            this.tglWeaponParts = new theme.FlatToggle();
            this.flatLabel1 = new theme.FlatLabel();
            this.pnlComponents = new System.Windows.Forms.Panel();
            this.flatButton2 = new theme.FlatButton();
            this.tglGunpowder = new theme.FlatToggle();
            this.flatLabel2 = new theme.FlatLabel();
            this.pnlHealth = new System.Windows.Forms.Panel();
            this.tglHealth = new theme.FlatToggle();
            this.flatLabel10 = new theme.FlatLabel();
            this.pnlAmmo = new System.Windows.Forms.Panel();
            this.tglSemiHandgunAmmo = new theme.FlatToggle();
            this.flatLabel4 = new theme.FlatLabel();
            this.btnAttach = new theme.FlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmrHealth = new System.Windows.Forms.Timer(this.components);
            this.cmbVersion = new theme.FlatComboBox();
            this.pnlResistance = new System.Windows.Forms.Panel();
            this.tglResistance = new theme.FlatToggle();
            this.flatLabel5 = new theme.FlatLabel();
            this.panel1.SuspendLayout();
            this.pnlGel.SuspendLayout();
            this.pnlWeaponParts.SuspendLayout();
            this.pnlComponents.SuspendLayout();
            this.pnlHealth.SuspendLayout();
            this.pnlAmmo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlResistance.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.pnlResistance);
            this.panel1.Controls.Add(this.pnlGel);
            this.panel1.Controls.Add(this.pnlWeaponParts);
            this.panel1.Controls.Add(this.pnlComponents);
            this.panel1.Controls.Add(this.pnlHealth);
            this.panel1.Controls.Add(this.pnlAmmo);
            this.panel1.Location = new System.Drawing.Point(0, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 349);
            this.panel1.TabIndex = 95;
            // 
            // pnlGel
            // 
            this.pnlGel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.pnlGel.Controls.Add(this.tglGel);
            this.pnlGel.Controls.Add(this.flatLabel3);
            this.pnlGel.Location = new System.Drawing.Point(3, 161);
            this.pnlGel.Name = "pnlGel";
            this.pnlGel.Size = new System.Drawing.Size(378, 73);
            this.pnlGel.TabIndex = 49;
            this.pnlGel.Visible = false;
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
            // pnlWeaponParts
            // 
            this.pnlWeaponParts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.pnlWeaponParts.Controls.Add(this.tglWeaponParts);
            this.pnlWeaponParts.Controls.Add(this.flatLabel1);
            this.pnlWeaponParts.Location = new System.Drawing.Point(384, 82);
            this.pnlWeaponParts.Name = "pnlWeaponParts";
            this.pnlWeaponParts.Size = new System.Drawing.Size(371, 73);
            this.pnlWeaponParts.TabIndex = 48;
            // 
            // tglWeaponParts
            // 
            this.tglWeaponParts.BackColor = System.Drawing.Color.Transparent;
            this.tglWeaponParts.Checked = false;
            this.tglWeaponParts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tglWeaponParts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tglWeaponParts.Location = new System.Drawing.Point(290, 21);
            this.tglWeaponParts.Name = "tglWeaponParts";
            this.tglWeaponParts.Options = theme.FlatToggle._Options.Style3;
            this.tglWeaponParts.Size = new System.Drawing.Size(76, 33);
            this.tglWeaponParts.TabIndex = 3;
            this.tglWeaponParts.Text = "flatToggle1";
            this.tglWeaponParts.CheckedChanged += new theme.FlatToggle.CheckedChangedEventHandler(this.tglWeaponParts_CheckedChanged);
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(13, 24);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(149, 20);
            this.flatLabel1.TabIndex = 2;
            this.flatLabel1.Text = "Infinite Weapon Parts";
            // 
            // pnlComponents
            // 
            this.pnlComponents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.pnlComponents.Controls.Add(this.flatButton2);
            this.pnlComponents.Controls.Add(this.tglGunpowder);
            this.pnlComponents.Controls.Add(this.flatLabel2);
            this.pnlComponents.Location = new System.Drawing.Point(3, 82);
            this.pnlComponents.Name = "pnlComponents";
            this.pnlComponents.Size = new System.Drawing.Size(378, 73);
            this.pnlComponents.TabIndex = 99;
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
            this.flatButton2.Click += new System.EventHandler(this.flatButton2_Click);
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
            this.tglGunpowder.CheckedChanged += new theme.FlatToggle.CheckedChangedEventHandler(this.tglGunpowder_CheckedChanged);
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
            // pnlHealth
            // 
            this.pnlHealth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.pnlHealth.Controls.Add(this.tglHealth);
            this.pnlHealth.Controls.Add(this.flatLabel10);
            this.pnlHealth.Location = new System.Drawing.Point(3, 3);
            this.pnlHealth.Name = "pnlHealth";
            this.pnlHealth.Size = new System.Drawing.Size(378, 73);
            this.pnlHealth.TabIndex = 48;
            this.pnlHealth.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
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
            this.flatLabel10.Click += new System.EventHandler(this.flatLabel10_Click);
            // 
            // pnlAmmo
            // 
            this.pnlAmmo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.pnlAmmo.Controls.Add(this.tglSemiHandgunAmmo);
            this.pnlAmmo.Controls.Add(this.flatLabel4);
            this.pnlAmmo.Location = new System.Drawing.Point(384, 3);
            this.pnlAmmo.Name = "pnlAmmo";
            this.pnlAmmo.Size = new System.Drawing.Size(371, 73);
            this.pnlAmmo.TabIndex = 47;
            this.pnlAmmo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
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
            this.flatLabel4.Click += new System.EventHandler(this.flatLabel4_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.label4.Location = new System.Drawing.Point(-2, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 28);
            this.label4.TabIndex = 94;
            this.label4.Text = "Cheater : TylerMods";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.label3.Location = new System.Drawing.Point(396, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 28);
            this.label3.TabIndex = 93;
            this.label3.Text = "CUSA06166";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tmrHealth
            // 
            this.tmrHealth.Interval = 500;
            this.tmrHealth.Tick += new System.EventHandler(this.tmrHealth_Tick);
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
            "v1.04"});
            this.cmbVersion.Location = new System.Drawing.Point(394, 78);
            this.cmbVersion.Name = "cmbVersion";
            this.cmbVersion.Size = new System.Drawing.Size(118, 24);
            this.cmbVersion.TabIndex = 100;
            this.cmbVersion.SelectedIndexChanged += new System.EventHandler(this.cmbVersion_SelectedIndexChanged);
            // 
            // pnlResistance
            // 
            this.pnlResistance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.pnlResistance.Controls.Add(this.tglResistance);
            this.pnlResistance.Controls.Add(this.flatLabel5);
            this.pnlResistance.Location = new System.Drawing.Point(384, 161);
            this.pnlResistance.Name = "pnlResistance";
            this.pnlResistance.Size = new System.Drawing.Size(371, 73);
            this.pnlResistance.TabIndex = 49;
            // 
            // tglResistance
            // 
            this.tglResistance.BackColor = System.Drawing.Color.Transparent;
            this.tglResistance.Checked = false;
            this.tglResistance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tglResistance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tglResistance.Location = new System.Drawing.Point(290, 21);
            this.tglResistance.Name = "tglResistance";
            this.tglResistance.Options = theme.FlatToggle._Options.Style3;
            this.tglResistance.Size = new System.Drawing.Size(76, 33);
            this.tglResistance.TabIndex = 3;
            this.tglResistance.Text = "flatToggle1";
            this.tglResistance.CheckedChanged += new theme.FlatToggle.CheckedChangedEventHandler(this.tglResistance_CheckedChanged);
            // 
            // flatLabel5
            // 
            this.flatLabel5.AutoSize = true;
            this.flatLabel5.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.flatLabel5.ForeColor = System.Drawing.Color.White;
            this.flatLabel5.Location = new System.Drawing.Point(13, 24);
            this.flatLabel5.Name = "flatLabel5";
            this.flatLabel5.Size = new System.Drawing.Size(128, 20);
            this.flatLabel5.TabIndex = 2;
            this.flatLabel5.Text = "Infinite Resistance";
            // 
            // TEW2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.cmbVersion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TEW2";
            this.Size = new System.Drawing.Size(758, 455);
            this.Load += new System.EventHandler(this.TEW2_Load);
            this.panel1.ResumeLayout(false);
            this.pnlGel.ResumeLayout(false);
            this.pnlGel.PerformLayout();
            this.pnlWeaponParts.ResumeLayout(false);
            this.pnlWeaponParts.PerformLayout();
            this.pnlComponents.ResumeLayout(false);
            this.pnlComponents.PerformLayout();
            this.pnlHealth.ResumeLayout(false);
            this.pnlHealth.PerformLayout();
            this.pnlAmmo.ResumeLayout(false);
            this.pnlAmmo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlResistance.ResumeLayout(false);
            this.pnlResistance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlAmmo;
        private theme.FlatToggle tglSemiHandgunAmmo;
        private theme.FlatLabel flatLabel4;
        private theme.FlatButton btnAttach;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlHealth;
        private theme.FlatToggle tglHealth;
        private theme.FlatLabel flatLabel10;
        private System.Windows.Forms.Panel pnlComponents;
        private theme.FlatButton flatButton2;
        private theme.FlatToggle tglGunpowder;
        private theme.FlatLabel flatLabel2;
        private System.Windows.Forms.Timer tmrHealth;
        private System.Windows.Forms.Panel pnlWeaponParts;
        private theme.FlatToggle tglWeaponParts;
        private theme.FlatLabel flatLabel1;
        private System.Windows.Forms.Panel pnlGel;
        private theme.FlatToggle tglGel;
        private theme.FlatLabel flatLabel3;
        private theme.FlatComboBox cmbVersion;
        private System.Windows.Forms.Panel pnlResistance;
        private theme.FlatToggle tglResistance;
        private theme.FlatLabel flatLabel5;
    }
}
