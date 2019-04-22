namespace PS4_Trainer_by_TylerMods
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.lblCUSA = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.alrtCUSACopied = new theme.FlatAlertBox();
            this.altShortcut = new theme.FlatAlertBox();
            this.cmbFavorites = new theme.FlatComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteFav = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddFavorite = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnShortcut = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnTrainerSite = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDonated = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSpreadsheet = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnChangelog = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDonate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pbGameImage = new System.Windows.Forms.PictureBox();
            this.btnGameChecker = new Bunifu.Framework.UI.BunifuThinButton2();
            this.flatTabControl1 = new theme.FlatTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameImage)).BeginInit();
            this.flatTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCUSA
            // 
            this.lblCUSA.AutoSize = true;
            this.lblCUSA.BackColor = System.Drawing.Color.Transparent;
            this.lblCUSA.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCUSA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.lblCUSA.Location = new System.Drawing.Point(39, 57);
            this.lblCUSA.Name = "lblCUSA";
            this.lblCUSA.Size = new System.Drawing.Size(61, 21);
            this.lblCUSA.TabIndex = 32;
            this.lblCUSA.Text = "CUSA : ";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.lblVersion.Location = new System.Drawing.Point(27, 78);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(73, 21);
            this.lblVersion.TabIndex = 33;
            this.lblVersion.Text = "Version : ";
            // 
            // alrtCUSACopied
            // 
            this.alrtCUSACopied.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.alrtCUSACopied.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alrtCUSACopied.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.alrtCUSACopied.kind = theme.FlatAlertBox._Kind.Success;
            this.alrtCUSACopied.Location = new System.Drawing.Point(277, 10);
            this.alrtCUSACopied.Name = "alrtCUSACopied";
            this.alrtCUSACopied.Size = new System.Drawing.Size(208, 42);
            this.alrtCUSACopied.TabIndex = 41;
            this.alrtCUSACopied.Text = "Copied to clipboard!";
            this.alrtCUSACopied.Visible = false;
            // 
            // altShortcut
            // 
            this.altShortcut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.altShortcut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.altShortcut.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.altShortcut.kind = theme.FlatAlertBox._Kind.Success;
            this.altShortcut.Location = new System.Drawing.Point(6, 359);
            this.altShortcut.Name = "altShortcut";
            this.altShortcut.Size = new System.Drawing.Size(208, 42);
            this.altShortcut.TabIndex = 43;
            this.altShortcut.Text = "Shortcut Created!";
            this.altShortcut.Visible = false;
            // 
            // cmbFavorites
            // 
            this.cmbFavorites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmbFavorites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFavorites.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFavorites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFavorites.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cmbFavorites.ForeColor = System.Drawing.Color.White;
            this.cmbFavorites.FormattingEnabled = true;
            this.cmbFavorites.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.cmbFavorites.ItemHeight = 18;
            this.cmbFavorites.Items.AddRange(new object[] {
            "7 Days to Die",
            "Agents of Mayhem",
            "Alien Isolation",
            "Amazing Spiderman 2",
            "Amnesia Collection Dark Descent",
            "Assassins Creed Origins",
            "Assassins Creed Syndicate",
            "Assassins Creed Unity",
            "Batman Arkham Knight",
            "Battlefield 1",
            "Battlefield 4",
            "Battlefield Hardline",
            "Bioshock : The Collection",
            "Bioshock 2 : The Collection",
            "Bioshock Infinite : The Collection",
            "Bloodborne",
            "Borderlands 2",
            "Borderlands The Pre-Sequel",
            "Crash Bandicoot Trilogy",
            "Darksiders 1",
            "Darksiders 2",
            "Dark Souls 3 FFE",
            "Dead Nation",
            "Dead or Alive Xtreme 3",
            "Dead Rising 4",
            "Deus Ex Mankind Divided",
            "Devil May Cry 3",
            "Devil May Cry 4",
            "Diablo 3",
            "Digimon Cyber Sleuth",
            "Dishonored 2",
            "Dishonored Death of an Outsider",
            "DOOM",
            "Dragon Fall FighterZ",
            "Dragon Ball Z: Xenoverse 2",
            "Dragon Quest Heroes 2",
            "Dying Light",
            "Extinction",
            "Fallout 4",
            "Far Cry 4",
            "Far Cry 5",
            "Far Cry Primal",
            "Final Fantasy XV",
            "Ghostbusters",
            "Ghost Recon Wildlands",
            "God of War 4",
            "Gravity Rush",
            "Hitman Game of the Year",
            "Hokuto Ga Gotoku",
            "Homefront The Revolution",
            "Horizon Zero Dawn",
            "Infamous First Light",
            "Infamous Second Son",
            "Injustice 2",
            "Just Cause 3",
            "Killzone Shadow Fall",
            "Kingdom Hearts 1",
            "LEGO The Hobbit",
            "Lords of the Fallen",
            "Mad Max",
            "Mafia III",
            "Mass Effect Andromeda",
            "Metro Redux",
            "Middle Earth Shadow of War",
            "Metal Gear Solid V",
            "Minecraft",
            "Monster Hunter World",
            "Mortal Kombat X",
            "Mortal Kombat XL",
            "NBA 2K17",
            "NBA 2K18",
            "NBA Live 18",
            "NieR: Automata",
            "Nioh",
            "NFS Payback",
            "Outlast 2",
            "Persona 5",
            "PES 18",
            "Prey",
            "Rainbow Six Siege",
            "Ratchet and Clank",
            "Resident Evil 0",
            "Resident Evil 1",
            "Resident Evil 4",
            "Resident Evil 5",
            "Resident Evil 6",
            "Resident Evil 7",
            "Resident Evil Revelations",
            "Resident Evil Revelations 2",
            "Resogun",
            "Rise of the Tomb Raider",
            "Shadow of the Colossus",
            "Skyrim",
            "Sleeping Dogs",
            "Sniper Elite 4",
            "Sonic Mania",
            "Star Wars Battlefront 2",
            "Tekken 7",
            "The Evil Within 1",
            "The Evil Within 2",
            "The Last of Us",
            "The Order 1886",
            "The Technomancer",
            "Thief",
            "Tomb Raider Definitive Edition",
            "Transformers Devastation",
            "Trials Fusion",
            "TWTHK",
            "UFC3",
            "Uncharted 1",
            "Uncharted 2",
            "Uncharted 3",
            "Uncharted 4",
            "Uncharted Lost Legacy",
            "Watchdogs 1",
            "Watchdogs 2",
            "Witcher 3",
            "Wolfenstein 1",
            "Wolfenstein 2",
            "Wolfenstein The Old Blood",
            "WWE 2K18",
            "Yakuza 6",
            "Yakuza Kiwami",
            "Yakuza Zero"});
            this.cmbFavorites.Location = new System.Drawing.Point(371, 141);
            this.cmbFavorites.Name = "cmbFavorites";
            this.cmbFavorites.Size = new System.Drawing.Size(221, 24);
            this.cmbFavorites.TabIndex = 47;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.listBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(219, 401);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.label1.Location = new System.Drawing.Point(398, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 21);
            this.label1.TabIndex = 49;
            this.label1.Text = "Add/Remove Favorites★";
            // 
            // btnDeleteFav
            // 
            this.btnDeleteFav.ActiveBorderThickness = 1;
            this.btnDeleteFav.ActiveCornerRadius = 1;
            this.btnDeleteFav.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnDeleteFav.ActiveForecolor = System.Drawing.Color.White;
            this.btnDeleteFav.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnDeleteFav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.btnDeleteFav.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteFav.BackgroundImage")));
            this.btnDeleteFav.ButtonText = "Delete Selected";
            this.btnDeleteFav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteFav.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFav.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnDeleteFav.IdleBorderThickness = 1;
            this.btnDeleteFav.IdleCornerRadius = 1;
            this.btnDeleteFav.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnDeleteFav.IdleForecolor = System.Drawing.Color.White;
            this.btnDeleteFav.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnDeleteFav.Location = new System.Drawing.Point(465, 166);
            this.btnDeleteFav.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteFav.Name = "btnDeleteFav";
            this.btnDeleteFav.Size = new System.Drawing.Size(118, 42);
            this.btnDeleteFav.TabIndex = 46;
            this.btnDeleteFav.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteFav.Click += new System.EventHandler(this.btnDeleteFav_Click);
            // 
            // btnAddFavorite
            // 
            this.btnAddFavorite.ActiveBorderThickness = 1;
            this.btnAddFavorite.ActiveCornerRadius = 1;
            this.btnAddFavorite.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnAddFavorite.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddFavorite.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnAddFavorite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.btnAddFavorite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddFavorite.BackgroundImage")));
            this.btnAddFavorite.ButtonText = "Add";
            this.btnAddFavorite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFavorite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFavorite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnAddFavorite.IdleBorderThickness = 1;
            this.btnAddFavorite.IdleCornerRadius = 1;
            this.btnAddFavorite.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnAddFavorite.IdleForecolor = System.Drawing.Color.White;
            this.btnAddFavorite.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnAddFavorite.Location = new System.Drawing.Point(382, 166);
            this.btnAddFavorite.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddFavorite.Name = "btnAddFavorite";
            this.btnAddFavorite.Size = new System.Drawing.Size(71, 42);
            this.btnAddFavorite.TabIndex = 45;
            this.btnAddFavorite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddFavorite.Click += new System.EventHandler(this.btnAddFavorite_Click);
            // 
            // btnShortcut
            // 
            this.btnShortcut.ActiveBorderThickness = 1;
            this.btnShortcut.ActiveCornerRadius = 1;
            this.btnShortcut.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnShortcut.ActiveForecolor = System.Drawing.Color.White;
            this.btnShortcut.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnShortcut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.btnShortcut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShortcut.BackgroundImage")));
            this.btnShortcut.ButtonText = "Add Shortcut To Desktop";
            this.btnShortcut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShortcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShortcut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnShortcut.IdleBorderThickness = 1;
            this.btnShortcut.IdleCornerRadius = 1;
            this.btnShortcut.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnShortcut.IdleForecolor = System.Drawing.Color.White;
            this.btnShortcut.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnShortcut.Location = new System.Drawing.Point(0, 108);
            this.btnShortcut.Margin = new System.Windows.Forms.Padding(0);
            this.btnShortcut.Name = "btnShortcut";
            this.btnShortcut.Size = new System.Drawing.Size(200, 54);
            this.btnShortcut.TabIndex = 42;
            this.btnShortcut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShortcut.Click += new System.EventHandler(this.btnShortcut_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 1;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.bunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Copy CUSA";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 1;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.bunifuThinButton22.Location = new System.Drawing.Point(203, 10);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(71, 42);
            this.bunifuThinButton22.TabIndex = 40;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // btnTrainerSite
            // 
            this.btnTrainerSite.ActiveBorderThickness = 1;
            this.btnTrainerSite.ActiveCornerRadius = 1;
            this.btnTrainerSite.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnTrainerSite.ActiveForecolor = System.Drawing.Color.White;
            this.btnTrainerSite.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnTrainerSite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.btnTrainerSite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTrainerSite.BackgroundImage")));
            this.btnTrainerSite.ButtonText = "Download Trainer Fresh";
            this.btnTrainerSite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrainerSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainerSite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnTrainerSite.IdleBorderThickness = 1;
            this.btnTrainerSite.IdleCornerRadius = 1;
            this.btnTrainerSite.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnTrainerSite.IdleForecolor = System.Drawing.Color.White;
            this.btnTrainerSite.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnTrainerSite.Location = new System.Drawing.Point(549, 54);
            this.btnTrainerSite.Margin = new System.Windows.Forms.Padding(0);
            this.btnTrainerSite.Name = "btnTrainerSite";
            this.btnTrainerSite.Size = new System.Drawing.Size(200, 54);
            this.btnTrainerSite.TabIndex = 39;
            this.btnTrainerSite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTrainerSite.Click += new System.EventHandler(this.btnTrainerSite_Click);
            // 
            // btnDonated
            // 
            this.btnDonated.ActiveBorderThickness = 1;
            this.btnDonated.ActiveCornerRadius = 1;
            this.btnDonated.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnDonated.ActiveForecolor = System.Drawing.Color.White;
            this.btnDonated.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnDonated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.btnDonated.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDonated.BackgroundImage")));
            this.btnDonated.ButtonText = "Donators / Patrons";
            this.btnDonated.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDonated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnDonated.IdleBorderThickness = 1;
            this.btnDonated.IdleCornerRadius = 1;
            this.btnDonated.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnDonated.IdleForecolor = System.Drawing.Color.White;
            this.btnDonated.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnDonated.Location = new System.Drawing.Point(283, 54);
            this.btnDonated.Margin = new System.Windows.Forms.Padding(0);
            this.btnDonated.Name = "btnDonated";
            this.btnDonated.Size = new System.Drawing.Size(200, 54);
            this.btnDonated.TabIndex = 38;
            this.btnDonated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDonated.Click += new System.EventHandler(this.btnDonated_Click);
            // 
            // btnSave
            // 
            this.btnSave.ActiveBorderThickness = 1;
            this.btnSave.ActiveCornerRadius = 1;
            this.btnSave.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnSave.ActiveForecolor = System.Drawing.Color.White;
            this.btnSave.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.ButtonText = "Download Image";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleCornerRadius = 1;
            this.btnSave.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnSave.IdleForecolor = System.Drawing.Color.White;
            this.btnSave.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnSave.Location = new System.Drawing.Point(3, 324);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 54);
            this.btnSave.TabIndex = 37;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSpreadsheet
            // 
            this.btnSpreadsheet.ActiveBorderThickness = 1;
            this.btnSpreadsheet.ActiveCornerRadius = 1;
            this.btnSpreadsheet.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnSpreadsheet.ActiveForecolor = System.Drawing.Color.White;
            this.btnSpreadsheet.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnSpreadsheet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.btnSpreadsheet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSpreadsheet.BackgroundImage")));
            this.btnSpreadsheet.ButtonText = "Games Being Worked On";
            this.btnSpreadsheet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpreadsheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpreadsheet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnSpreadsheet.IdleBorderThickness = 1;
            this.btnSpreadsheet.IdleCornerRadius = 1;
            this.btnSpreadsheet.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnSpreadsheet.IdleForecolor = System.Drawing.Color.White;
            this.btnSpreadsheet.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnSpreadsheet.Location = new System.Drawing.Point(0, 54);
            this.btnSpreadsheet.Margin = new System.Windows.Forms.Padding(0);
            this.btnSpreadsheet.Name = "btnSpreadsheet";
            this.btnSpreadsheet.Size = new System.Drawing.Size(200, 54);
            this.btnSpreadsheet.TabIndex = 36;
            this.btnSpreadsheet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSpreadsheet.Click += new System.EventHandler(this.btnSpreadsheet_Click);
            // 
            // btnChangelog
            // 
            this.btnChangelog.ActiveBorderThickness = 1;
            this.btnChangelog.ActiveCornerRadius = 1;
            this.btnChangelog.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnChangelog.ActiveForecolor = System.Drawing.Color.White;
            this.btnChangelog.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnChangelog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.btnChangelog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChangelog.BackgroundImage")));
            this.btnChangelog.ButtonText = "View Changelog";
            this.btnChangelog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangelog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangelog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnChangelog.IdleBorderThickness = 1;
            this.btnChangelog.IdleCornerRadius = 1;
            this.btnChangelog.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnChangelog.IdleForecolor = System.Drawing.Color.White;
            this.btnChangelog.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnChangelog.Location = new System.Drawing.Point(550, 0);
            this.btnChangelog.Margin = new System.Windows.Forms.Padding(0);
            this.btnChangelog.Name = "btnChangelog";
            this.btnChangelog.Size = new System.Drawing.Size(200, 54);
            this.btnChangelog.TabIndex = 35;
            this.btnChangelog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChangelog.Click += new System.EventHandler(this.btnChangelog_Click);
            // 
            // btnDonate
            // 
            this.btnDonate.ActiveBorderThickness = 1;
            this.btnDonate.ActiveCornerRadius = 1;
            this.btnDonate.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnDonate.ActiveForecolor = System.Drawing.Color.White;
            this.btnDonate.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnDonate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.btnDonate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDonate.BackgroundImage")));
            this.btnDonate.ButtonText = "Donate";
            this.btnDonate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDonate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnDonate.IdleBorderThickness = 1;
            this.btnDonate.IdleCornerRadius = 1;
            this.btnDonate.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnDonate.IdleForecolor = System.Drawing.Color.White;
            this.btnDonate.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnDonate.Location = new System.Drawing.Point(283, 0);
            this.btnDonate.Margin = new System.Windows.Forms.Padding(0);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(200, 54);
            this.btnDonate.TabIndex = 34;
            this.btnDonate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 1;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Check For Updates";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 1;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(0, 0);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(200, 54);
            this.bunifuThinButton21.TabIndex = 31;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // pbGameImage
            // 
            this.pbGameImage.BackColor = System.Drawing.Color.Transparent;
            this.pbGameImage.Location = new System.Drawing.Point(6, 111);
            this.pbGameImage.Name = "pbGameImage";
            this.pbGameImage.Size = new System.Drawing.Size(197, 210);
            this.pbGameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGameImage.TabIndex = 30;
            this.pbGameImage.TabStop = false;
            // 
            // btnGameChecker
            // 
            this.btnGameChecker.ActiveBorderThickness = 1;
            this.btnGameChecker.ActiveCornerRadius = 1;
            this.btnGameChecker.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnGameChecker.ActiveForecolor = System.Drawing.Color.White;
            this.btnGameChecker.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnGameChecker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.btnGameChecker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGameChecker.BackgroundImage")));
            this.btnGameChecker.ButtonText = "Game Checker";
            this.btnGameChecker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGameChecker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGameChecker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnGameChecker.IdleBorderThickness = 1;
            this.btnGameChecker.IdleCornerRadius = 1;
            this.btnGameChecker.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnGameChecker.IdleForecolor = System.Drawing.Color.White;
            this.btnGameChecker.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.btnGameChecker.Location = new System.Drawing.Point(3, 3);
            this.btnGameChecker.Margin = new System.Windows.Forms.Padding(0);
            this.btnGameChecker.Name = "btnGameChecker";
            this.btnGameChecker.Size = new System.Drawing.Size(200, 54);
            this.btnGameChecker.TabIndex = 29;
            this.btnGameChecker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGameChecker.Click += new System.EventHandler(this.btnGameChecker_Click);
            // 
            // flatTabControl1
            // 
            this.flatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(137)))), ((int)(((byte)(234)))));
            this.flatTabControl1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatTabControl1.Controls.Add(this.tabPage1);
            this.flatTabControl1.Controls.Add(this.tabPage2);
            this.flatTabControl1.Controls.Add(this.tabPage3);
            this.flatTabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatTabControl1.ItemSize = new System.Drawing.Size(120, 40);
            this.flatTabControl1.Location = new System.Drawing.Point(0, 0);
            this.flatTabControl1.Name = "flatTabControl1";
            this.flatTabControl1.SelectedIndex = 0;
            this.flatTabControl1.Size = new System.Drawing.Size(760, 455);
            this.flatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.flatTabControl1.TabIndex = 50;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage1.Controls.Add(this.btnGameChecker);
            this.tabPage1.Controls.Add(this.pbGameImage);
            this.tabPage1.Controls.Add(this.lblCUSA);
            this.tabPage1.Controls.Add(this.lblVersion);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.bunifuThinButton22);
            this.tabPage1.Controls.Add(this.alrtCUSACopied);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(752, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Game Information";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnAddFavorite);
            this.tabPage2.Controls.Add(this.btnDeleteFav);
            this.tabPage2.Controls.Add(this.cmbFavorites);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(752, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Favorites";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage3.Controls.Add(this.btnShortcut);
            this.tabPage3.Controls.Add(this.altShortcut);
            this.tabPage3.Controls.Add(this.bunifuThinButton21);
            this.tabPage3.Controls.Add(this.btnDonate);
            this.tabPage3.Controls.Add(this.btnTrainerSite);
            this.tabPage3.Controls.Add(this.btnChangelog);
            this.tabPage3.Controls.Add(this.btnDonated);
            this.tabPage3.Controls.Add(this.btnSpreadsheet);
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(752, 407);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Helpful Buttons";
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.flatTabControl1);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(758, 455);
            this.Load += new System.EventHandler(this.Home_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbGameImage)).EndInit();
            this.flatTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGameImage;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGameChecker;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Label lblCUSA;
        private System.Windows.Forms.Label lblVersion;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDonate;
        private Bunifu.Framework.UI.BunifuThinButton2 btnChangelog;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSpreadsheet;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDonated;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTrainerSite;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private theme.FlatAlertBox alrtCUSACopied;
        private Bunifu.Framework.UI.BunifuThinButton2 btnShortcut;
        private theme.FlatAlertBox altShortcut;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddFavorite;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDeleteFav;
        public theme.FlatComboBox cmbFavorites;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox listBox1;
        private theme.FlatTabControl flatTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}
