namespace PS4_Trainer_by_TylerMods
{
    partial class IPSelect
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IPSelect));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lstPS4s = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.lblFirmware = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.txtIP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtFirmware = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnRemove = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDefaultPS4 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.alrtDefaultChanged = new theme.FlatAlertBox();
            this.btnInstructions = new Bunifu.Framework.UI.BunifuThinButton2();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lstPS4s);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(272, 360);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lstPS4s
            // 
            this.lstPS4s.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lstPS4s.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPS4s.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lstPS4s.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lstPS4s.FormattingEnabled = true;
            this.lstPS4s.ItemHeight = 15;
            this.lstPS4s.Location = new System.Drawing.Point(3, 3);
            this.lstPS4s.Name = "lstPS4s";
            this.lstPS4s.Size = new System.Drawing.Size(269, 360);
            this.lstPS4s.Sorted = true;
            this.lstPS4s.TabIndex = 49;
            this.lstPS4s.SelectedIndexChanged += new System.EventHandler(this.lstPS4s_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblFirmware);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblIP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(272, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 100);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(340, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 26);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblFirmware
            // 
            this.lblFirmware.AutoSize = true;
            this.lblFirmware.Font = new System.Drawing.Font("Neo Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirmware.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFirmware.Location = new System.Drawing.Point(3, 75);
            this.lblFirmware.Name = "lblFirmware";
            this.lblFirmware.Size = new System.Drawing.Size(104, 20);
            this.lblFirmware.TabIndex = 2;
            this.lblFirmware.Text = "IP Firmware : ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Neo Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblName.Location = new System.Drawing.Point(2, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(79, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "IP Name : ";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Neo Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIP.Location = new System.Drawing.Point(2, 43);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(100, 20);
            this.lblIP.TabIndex = 0;
            this.lblIP.Text = "IP Selected : ";
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtIP.ForeColor = System.Drawing.Color.White;
            this.txtIP.HintForeColor = System.Drawing.Color.Empty;
            this.txtIP.HintText = "";
            this.txtIP.isPassword = false;
            this.txtIP.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.txtIP.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(59)))));
            this.txtIP.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtIP.LineThickness = 3;
            this.txtIP.Location = new System.Drawing.Point(311, 107);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(127, 33);
            this.txtIP.TabIndex = 26;
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.HintForeColor = System.Drawing.Color.White;
            this.txtName.HintText = "";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.txtName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(59)))));
            this.txtName.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtName.LineThickness = 3;
            this.txtName.Location = new System.Drawing.Point(339, 148);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(127, 33);
            this.txtName.TabIndex = 27;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFirmware
            // 
            this.txtFirmware.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtFirmware.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirmware.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtFirmware.ForeColor = System.Drawing.Color.White;
            this.txtFirmware.HintForeColor = System.Drawing.Color.Empty;
            this.txtFirmware.HintText = "";
            this.txtFirmware.isPassword = false;
            this.txtFirmware.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.txtFirmware.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(59)))));
            this.txtFirmware.LineMouseHoverColor = System.Drawing.Color.White;
            this.txtFirmware.LineThickness = 3;
            this.txtFirmware.Location = new System.Drawing.Point(364, 189);
            this.txtFirmware.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirmware.Name = "txtFirmware";
            this.txtFirmware.Size = new System.Drawing.Size(127, 33);
            this.txtFirmware.TabIndex = 28;
            this.txtFirmware.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Neo Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(274, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "IP :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Neo Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(274, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Neo Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(274, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Firmware :";
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveBorderThickness = 1;
            this.btnAdd.ActiveCornerRadius = 1;
            this.btnAdd.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnAdd.ActiveForecolor = System.Drawing.Color.White;
            this.btnAdd.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.ButtonText = "Add PS4";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleCornerRadius = 1;
            this.btnAdd.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnAdd.IdleForecolor = System.Drawing.Color.White;
            this.btnAdd.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnAdd.Location = new System.Drawing.Point(278, 222);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(213, 44);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.ActiveBorderThickness = 1;
            this.btnRemove.ActiveCornerRadius = 1;
            this.btnRemove.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnRemove.ActiveForecolor = System.Drawing.Color.White;
            this.btnRemove.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.btnRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemove.BackgroundImage")));
            this.btnRemove.ButtonText = "Remove Selected PS4";
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnRemove.IdleBorderThickness = 1;
            this.btnRemove.IdleCornerRadius = 1;
            this.btnRemove.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnRemove.IdleForecolor = System.Drawing.Color.White;
            this.btnRemove.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnRemove.Location = new System.Drawing.Point(278, 266);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(213, 44);
            this.btnRemove.TabIndex = 32;
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnDefaultPS4
            // 
            this.btnDefaultPS4.ActiveBorderThickness = 1;
            this.btnDefaultPS4.ActiveCornerRadius = 1;
            this.btnDefaultPS4.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnDefaultPS4.ActiveForecolor = System.Drawing.Color.White;
            this.btnDefaultPS4.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnDefaultPS4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.btnDefaultPS4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDefaultPS4.BackgroundImage")));
            this.btnDefaultPS4.ButtonText = "Make This Your Default PS4";
            this.btnDefaultPS4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDefaultPS4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefaultPS4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnDefaultPS4.IdleBorderThickness = 1;
            this.btnDefaultPS4.IdleCornerRadius = 1;
            this.btnDefaultPS4.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnDefaultPS4.IdleForecolor = System.Drawing.Color.White;
            this.btnDefaultPS4.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnDefaultPS4.Location = new System.Drawing.Point(279, 310);
            this.btnDefaultPS4.Margin = new System.Windows.Forms.Padding(0);
            this.btnDefaultPS4.Name = "btnDefaultPS4";
            this.btnDefaultPS4.Size = new System.Drawing.Size(213, 44);
            this.btnDefaultPS4.TabIndex = 33;
            this.btnDefaultPS4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDefaultPS4.Click += new System.EventHandler(this.btnDefaultPS4_Click);
            // 
            // alrtDefaultChanged
            // 
            this.alrtDefaultChanged.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.alrtDefaultChanged.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alrtDefaultChanged.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.alrtDefaultChanged.kind = theme.FlatAlertBox._Kind.Success;
            this.alrtDefaultChanged.Location = new System.Drawing.Point(454, 107);
            this.alrtDefaultChanged.Name = "alrtDefaultChanged";
            this.alrtDefaultChanged.Size = new System.Drawing.Size(186, 42);
            this.alrtDefaultChanged.TabIndex = 50;
            this.alrtDefaultChanged.Text = "Default Changed!";
            this.alrtDefaultChanged.Visible = false;
            // 
            // btnInstructions
            // 
            this.btnInstructions.ActiveBorderThickness = 1;
            this.btnInstructions.ActiveCornerRadius = 1;
            this.btnInstructions.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnInstructions.ActiveForecolor = System.Drawing.Color.White;
            this.btnInstructions.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnInstructions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.btnInstructions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInstructions.BackgroundImage")));
            this.btnInstructions.ButtonText = "Instructions";
            this.btnInstructions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnInstructions.IdleBorderThickness = 1;
            this.btnInstructions.IdleCornerRadius = 1;
            this.btnInstructions.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnInstructions.IdleForecolor = System.Drawing.Color.White;
            this.btnInstructions.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnInstructions.Location = new System.Drawing.Point(495, 152);
            this.btnInstructions.Margin = new System.Windows.Forms.Padding(0);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(148, 44);
            this.btnInstructions.TabIndex = 51;
            this.btnInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // IPSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(643, 360);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.alrtDefaultChanged);
            this.Controls.Add(this.btnDefaultPS4);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFirmware);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IPSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IPSelect";
            this.Load += new System.EventHandler(this.IPSelect_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFirmware;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIP;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtIP;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFirmware;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRemove;
        private System.Windows.Forms.ListBox lstPS4s;
        private System.Windows.Forms.PictureBox btnClose;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDefaultPS4;
        private theme.FlatAlertBox alrtDefaultChanged;
        private Bunifu.Framework.UI.BunifuThinButton2 btnInstructions;
    }
}