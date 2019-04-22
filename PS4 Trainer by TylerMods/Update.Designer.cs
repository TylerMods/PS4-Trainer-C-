namespace PS4_Trainer_by_TylerMods
{
    partial class Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.lblCurrent = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNewer = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtChangelog = new System.Windows.Forms.RichTextBox();
            this.btnSelectIP = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(52, 4);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(243, 28);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Would you like to update?";
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.color = System.Drawing.Color.SeaGreen;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "Yes";
            this.bunifuTileButton1.Location = new System.Drawing.Point(24, 95);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(126, 124);
            this.bunifuTileButton1.TabIndex = 1;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.Crimson;
            this.bunifuTileButton2.color = System.Drawing.Color.Crimson;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.Red;
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton2.Image")));
            this.bunifuTileButton2.ImagePosition = 20;
            this.bunifuTileButton2.ImageZoom = 50;
            this.bunifuTileButton2.LabelPosition = 41;
            this.bunifuTileButton2.LabelText = "No";
            this.bunifuTileButton2.Location = new System.Drawing.Point(192, 95);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(126, 124);
            this.bunifuTileButton2.TabIndex = 2;
            this.bunifuTileButton2.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblCurrent.ForeColor = System.Drawing.Color.White;
            this.lblCurrent.Location = new System.Drawing.Point(39, 32);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(160, 28);
            this.lblCurrent.TabIndex = 3;
            this.lblCurrent.Text = "Current Version : ";
            // 
            // lblNewer
            // 
            this.lblNewer.AutoSize = true;
            this.lblNewer.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.lblNewer.ForeColor = System.Drawing.Color.White;
            this.lblNewer.Location = new System.Drawing.Point(39, 61);
            this.lblNewer.Name = "lblNewer";
            this.lblNewer.Size = new System.Drawing.Size(151, 28);
            this.lblNewer.TabIndex = 4;
            this.lblNewer.Text = "Newer Version : ";
            // 
            // txtChangelog
            // 
            this.txtChangelog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.txtChangelog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChangelog.ForeColor = System.Drawing.Color.White;
            this.txtChangelog.Location = new System.Drawing.Point(344, 4);
            this.txtChangelog.Name = "txtChangelog";
            this.txtChangelog.ReadOnly = true;
            this.txtChangelog.Size = new System.Drawing.Size(337, 269);
            this.txtChangelog.TabIndex = 5;
            this.txtChangelog.Text = "";
            // 
            // btnSelectIP
            // 
            this.btnSelectIP.ActiveBorderThickness = 1;
            this.btnSelectIP.ActiveCornerRadius = 1;
            this.btnSelectIP.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnSelectIP.ActiveForecolor = System.Drawing.Color.White;
            this.btnSelectIP.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnSelectIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.btnSelectIP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectIP.BackgroundImage")));
            this.btnSelectIP.ButtonText = "Show Changelog";
            this.btnSelectIP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnSelectIP.IdleBorderThickness = 1;
            this.btnSelectIP.IdleCornerRadius = 1;
            this.btnSelectIP.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnSelectIP.IdleForecolor = System.Drawing.Color.White;
            this.btnSelectIP.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnSelectIP.Location = new System.Drawing.Point(24, 224);
            this.btnSelectIP.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelectIP.Name = "btnSelectIP";
            this.btnSelectIP.Size = new System.Drawing.Size(294, 44);
            this.btnSelectIP.TabIndex = 29;
            this.btnSelectIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSelectIP.Click += new System.EventHandler(this.btnSelectIP_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(343, 277);
            this.Controls.Add(this.btnSelectIP);
            this.Controls.Add(this.txtChangelog);
            this.Controls.Add(this.lblNewer);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.bunifuTileButton2);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Update";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCurrent;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNewer;
        private System.Windows.Forms.RichTextBox txtChangelog;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSelectIP;
    }
}