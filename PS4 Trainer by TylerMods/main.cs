using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using librpc;
using PS4_Trainer_by_TylerMods.Properties;
using MetroFramework;
using System.Reflection;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.ComponentModel;
using System.Linq;
using System.Collections.Generic;

namespace PS4_Trainer_by_TylerMods
{
    public partial class main : Form
    {
        public static PS4RPC PS4;
        public static Favorites FavoriteGames  = new Favorites();
        static List<Control> allGamesButtons = new List<Control>();

        public main()
        {
            InitializeComponent();
            Updater();
            DeleteOld();
            lblVersion.Text = Application.ProductVersion;
            cmbFirmware.SelectedIndex = Settings.Default.firmwareIndex;

        
            

            tglFavorites_CheckedChanged(null);
            var count = flowLayoutPanel1.Controls.Count.ToString();
            int x = int.Parse(count) - 3;
            lblGameCount.Text = "Games | " + x;


            var allButtons = flowLayoutPanel1.Controls;
            int i = 0;
            foreach (Control gameButton in allButtons)
            {
                if (!gameButton.Name.Contains("load") || gameButton.Name.Contains("Home"))
                    continue;
                    allGamesButtons.Add(gameButton);
                gameButton.Visible = true;
                i++;
            }

            InitPS4RPC(); // this first time, on boot

            this.Activated += delegate {
                PS4 defaultPS4 = IPSelect.PS4Consoles.DefaultPS4();
                int index = cmbFirmware.FindString(defaultPS4.Firmware);
                cmbFirmware.SelectedIndex = index;
            };
            new Thread(new ThreadStart(PayloadChecker)).Start();
        }
        public static void InitPS4RPC()
        {
            //try
            //{
            PS4 ps4 = IPSelect.PS4Consoles.DefaultPS4();
            if (ps4.IPAddress != null)
                PS4 = new PS4RPC(ps4.IPAddress);
            //}
            //catch
            //{
            //    IPSelect.PS4Consoles.DeletePS4(IPSelect.PS4Consoles.DefaultPS4().IPAddress);
            //}
        }
        void ToggleFavorites(bool toggle)
        {
            var allFavoriteGames = FavoriteGames.GetAllGames();

            foreach (var game in allGamesButtons)
            {
                if (toggle && allFavoriteGames.Exists(x => x == game.Text))
                {
                    game.Visible = true;
                    continue;
                }
                else if (!toggle)
                {
                    game.Visible = true;
                }
                else{
                    game.Visible = false;
                }
            }
        }

        private void setLabelText(Label label, string text)
        {
            if (label.InvokeRequired)
            {
                MethodInvoker mi = new MethodInvoker(() => label.Text = text);
                label.Invoke(mi);
            }
        }

        private void PayloadChecker()
        {

            try
            {
                Calling.Notify("Payload already injected!");
                string resp = "Payload already injected!";
                setLabelText(lblConnect, resp);
                lblConnect.Text = "Payload already injected!";
            }
            catch (Exception ex)
            {
                string resp = "Payload not sent";
                setLabelText(lblConnect, resp);
            }


        }
      
        private void txtIP_OnValueChanged(object sender, EventArgs e)
        {
            //if (IPAddress.TryParse(txtIP.Text, out IPAddress address))
            //{
            //    if (txtIP.Text.Count(c => c == '.') == 3 && address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
            //        PS4 = new PS4RPC(address);
            //} //this is code not making sense, each time you change the text you init the object : )

        }
        private void main_Load(object sender, EventArgs e)
        {
            Launching launching = new Launching();
            launching.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(PayloadChecker)).Start();
            Thread.Sleep(2000);
        }


        void send_pay_load(string IP, string payloadPath, int port)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.ReceiveTimeout = 1500;
            socket.SendTimeout = 1500;
            socket.Connect(new IPEndPoint(IPAddress.Parse(IP), port));
            socket.SendFile(payloadPath);
            socket.Close();
        }

        void SendPayload(string IP)
        {
            string payloadPath = "";

            switch (cmbFirmware.Text)
            {
                case "": MessageBox.Show("Please select a firmware."); break;
                case "4.05": payloadPath = Application.StartupPath + @"\payloads\4_05"; break;
                case "4.55": payloadPath = Application.StartupPath + @"\payloads\4_55"; break;
                case "5.05": payloadPath = Application.StartupPath + @"\payloads\5_05"; break;
                case "5.05 - Mira": payloadPath = Application.StartupPath + @"\payloads\5_05_Mira"; break;
                case "5.07": payloadPath = Application.StartupPath + @"\payloads\5_05"; break;
            }
            if (payloadPath.Length > 0)
            {
                try
                {
                    send_pay_load(IP, payloadPath + @"\payload.bin", 9020);
                    if (cmbFirmware.Text == "5.05 - Mira" || cmbFirmware.Text == "4.05" || cmbFirmware.Text == "4.55")
                    {
                        send_pay_load(IP, payloadPath + @"\kpayload.elf", 9023);
                    }
                    Thread.Sleep(2000);
                    lblConnect.Text = "Payload Successful!";

                }
                catch (Exception ex)
                {
                    lblConnect.Text = "Payload Error!";
                    MessageBox.Show(this, "Failed to send payload. Be sure to try downloading fresh from PS4Trainer.com. " +
    "\nYou could also try clearing your PS4 Web Browser Data in the PS4 Web Browser settings " +
    "after launching the PS4 Web Browser and pressing the options button on your controller. " +
    "\nMake sure you are using either HEN or Mira+HEN accordingly. \n If you are using HEN... " +
    "don't bother sending the payload. Just visit the AlAzif DNS server, go to PS4 RTEs, then " +
    "enable the TylerMods button and it will run HEN and my trainer's payload together.");

                    MetroMessageBox.Show(this, $"{ex.Message}\n\n{ex.ToString()}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void lblVersion_Click(object sender, EventArgs e)
        {
            Changelog changelog = new Changelog();
            child_panel.Controls.Clear();
            child_panel.Controls.Add(changelog);
        }
        private void btnPayload_Click(object sender, EventArgs e)
        {
            SendPayload(IPSelect.PS4Consoles.DefaultPS4().IPAddress);
            EverythingAlright everythingAlright = new EverythingAlright();
            everythingAlright.Show();
        }

        #region Load Childs

        enum GameTrainer
        {
            DBZX2,
            IFL,
            MGSV,
            NBA17,
            RE4,
            RE5,
            TLOU,
            YK,
            uc4,
            diablo3,
            uc1,
            uc2,
            uc3,
            ucll,
            gow4,
            sonicmania,
            dqh2,
            yz,
            NBA18,
            NFSP,
            RE7,
            Tekken7,
            TEW2,
            RAC,
            DLEE,
            ISS,
            DMC3,
            BBGOTY,
            GB,
            FarCry5,
            HGG,
            ACO,
            KSF,
            twthk,
            cbt,
            rotr,
            MHW,
            DAX3,
            HZDCE,
            W3GOTY,
            RE6,
            SOTC,
            FFXV,
            UFC3,
            DS3FFE,
            Resogun,
            RER1,
            BMAN,
            RER2,
            DOOM,
            gow3,
            AS2,
            WatchDogs1,
            DBFZ,
            BF1,
            Injustice2,
            WatchDogs2,
            DeadNation,
            KH1,
            JustCause3,
            MadMax,
            TO1886,
            DeadRising4,
            WTNO,
            WTNC,
            WTOB,
            TEW1,
            MEA,
            DWE,
            HitmanGOTY,
            D2,
            AlienIsolation,
            RE0,
            RE1,
            GravityRush,
            SWB,
            TombRaider,
            Fallout4,
            Yakuza6,
            Mafia3,
            HR,
            NA,
            Minecraft,
            Home,
            MESW,
            MR,
            _7Days,
            SleepingDogs,
            MKX,
            DSCS,
            GRW,
            Skyrim,
            ACS,
            Dishonored2,
            DDOO,
            Outlast2,
            DMC4,
            NBAL18,
            FCP,
            ACDD,
            Persona5,
            WWE18,
            ACU,
            LOTF,
            R6S,
            TF,
            AOM,
            SE4,
            DEMD,
            TD,
            BFH,
            LEGOHOBBIT,
            Nioh,
            MKXL,
            TF2,
            FIFA18,
            TQ,
            Technomancer,
            Thief,
            PES18,
            BS1,
            BS2,
            BSI,
            BTHC,
            BTPS,
            FC4,
            GOW3,
            BF4,
            Prey,
            Extinction
        }
        private class GetTrainerClass
        {
            public static GameTrainer Game;
        }
        private class SelectedGame
        {
            public static DragonBallZXenoverse2 DBZX2;
            public static Game_Trainers.InfamousFirstLight IFL;
            public static MGSV MetalGear5;
            public static NBA2K17 NBA17;
            public static re4 ResEvil4;
            public static Game_Trainers.re5 ResEvil5;
            public static TheLastofUs TheLastofUs;
            public static Game_Trainers.YakuzaKiwami YakuzaKiwami;
            public static Game_Trainers.Uncharted4 Uncharted4;
            public static Game_Trainers.Diablo3 Diablo3;
            public static Game_Trainers.Uncharted1 Uncharted1;
            public static Game_Trainers.Uncharted2 Uncharted2;
            public static Game_Trainers.Uncharted3 Uncharted3;
            public static Game_Trainers.UnchartedLL UnchartedLL;
            public static Game_Trainers.GodofWar4 GodofWar4;
            public static Game_Trainers.SonicMania SonicMania;
            public static Game_Trainers.DragonQH2 DragonQH2;
            public static Game_Trainers.YakuzaZero YakuzaZero;
            public static Game_Trainers.NBA2K18 NBA2K18;
            public static Game_Trainers.NFSPayback NFSPayback;
            public static Game_Trainers.RE7 RE7;
            public static Game_Trainers.Tekken7 Tekken7;
            public static Game_Trainers.TEW2 TEW2;
            public static Game_Trainers.RAC RAC;
            public static Game_Trainers.DyingLightEE DyingLightEE;
            public static Game_Trainers.InfamousSecondSon InfamousSecondSon;
            public static Game_Trainers.DMC3 DMC3;
            public static Game_Trainers.bbgoty Bbgoty;
            public static Game_Trainers.Ghostbusters Ghostbusters;
            public static Game_Trainers.FarCry5 FarCry5;
            public static Game_Trainers.HokutoGaGotoku HokutoGaGotoku;
            public static Game_Trainers.ACOrigins ACOrigins;
            public static Game_Trainers.KillzoneSF KillzoneSF;
            public static Game_Trainers.WitchHundredKnights WitchHundredKnights;
            public static Game_Trainers.CrashBandicoot CrashBandicoot;
            public static Game_Trainers.ROTR20Year ROTR20Year;
            public static Game_Trainers.MHW MHW;
            public static Game_Trainers.DAX3 DAX3;
            public static Game_Trainers.HZDCE HZDCE;
            public static Game_Trainers.Witcher3 Witcher3;
            public static Game_Trainers.RE6 RE6;
            public static Game_Trainers.SOTC SOTC;
            public static Game_Trainers.FFXV FFXV;
            public static Game_Trainers.UFC3 UFC3;
            public static Game_Trainers.DS3FFE DS3FFE;
            public static Game_Trainers.Resogun Resogun;
            public static Game_Trainers.RER1 RER1;
            public static Game_Trainers.BMAN BMAN;
            public static Game_Trainers.RER2 RER2;
            public static Game_Trainers.DOOM DOOM;
            public static Game_Trainers.GOW3 GOW3;
            public static Game_Trainers.AS2 AS2;
            public static Game_Trainers.WatchDogs1 WatchDogs1;
            public static Game_Trainers.DBZF DBZF;
            public static Game_Trainers.BF1 BF1;
            public static Game_Trainers.Injustice2 Injustice2;
            public static Game_Trainers.WatchDogs2 WatchDogs2;
            public static Game_Trainers.DeadNation DeadNation;
            public static Game_Trainers.KH1 KH1;
            public static Game_Trainers.JustCause3 JustCause3;
            public static Game_Trainers.MadMax MadMax;
            public static Game_Trainers.TO1886 TO1886;
            public static Game_Trainers.DeadRising4 DeadRising4;
            public static Game_Trainers.WTNO WTNO;
            public static Game_Trainers.WTNC WTNC;
            public static Game_Trainers.WTOB WTOB;
            public static Game_Trainers.TEW1 TEW1;
            public static Game_Trainers.MEA MEA;
            public static Game_Trainers.DWE DWE;
            public static Game_Trainers.HitmanGOTY HitmanGOTY;
            public static Game_Trainers.D2 D2;
            public static Game_Trainers.AlienIsolation AlienIsolation;
            public static Game_Trainers.RE0 RE0;
            public static Game_Trainers.RE1 RE1;
            public static Game_Trainers.GravityRush GravityRush;
            public static Game_Trainers.SWB SWB;
            public static Game_Trainers.TombRaider TombRaider;
            public static Game_Trainers.Fallout4 Fallout4;
            public static Game_Trainers.Yakuza6 Yakuza6;
            public static Game_Trainers.Mafia3 Mafia3;
            public static Game_Trainers.HR HR;
            public static Game_Trainers.NA NA;
            public static Game_Trainers.Minecraft Minecraft;
            public static Home Home;
            public static Game_Trainers.MESW MESW;
            public static Game_Trainers.MR MR;
            public static Game_Trainers._7Days _7Days;
            public static Game_Trainers.SleepingDogs SleepingDogs;
            public static Game_Trainers.MKX MKX;
            public static Game_Trainers.DSCS DSCS;
            public static Game_Trainers.GRW GRW;
            public static Game_Trainers.Skyrim Skyrim;
            public static Game_Trainers.ACS ACS;
            public static Game_Trainers.Dishonored2 Dishonored2;
            public static Game_Trainers.DDOO DDOO;
            public static Game_Trainers.Outlast2 Outlast2;
            public static Game_Trainers.DMC4 DMC4;
            public static Game_Trainers.NBAL18 NBAL18;
            public static Game_Trainers.FCP FCP;
            public static API.ACDD ACDD;
            public static Game_Trainers.Persona5 Persona5;
            public static Game_Trainers.WWE18 WWE18;
            public static Game_Trainers.ACU ACU;
            public static Game_Trainers.LOTF LOTF;
            public static Game_Trainers.R6S R6S;
            public static Game_Trainers.TF TF;
            public static Game_Trainers.AOM AOM;
            public static Game_Trainers.SE4 SE4;
            public static Game_Trainers.DEMD DEMD;
            public static Game_Trainers.TD TD;
            public static Game_Trainers.BFH BFH;
            public static Game_Trainers.LEGOHOBBIT LEGOHOBBIT;
            public static Game_Trainers.Nioh Nioh;
            public static Game_Trainers.MKXL MKXL;
            public static Game_Trainers.TF2 TF2;
            public static Game_Trainers.FIFA18 FIFA18;
            public static Game_Trainers.TQ TQ;
            public static Game_Trainers.Technomancer Technomancer;
            public static Game_Trainers.Thief Thief;
            public static Game_Trainers.PES18 PES18;
            public static Game_Trainers.BS1 BS1;
            public static Game_Trainers.BS2 BS2;
            public static Game_Trainers.BSI BSI;
            public static Game_Trainers.BTHC BTHC;
            public static Game_Trainers.BTPS BTPS;
            public static Game_Trainers.FC4 FC4;
            public static Game_Trainers.BF4 BF4;
            public static Game_Trainers.Prey Prey;
            public static Game_Trainers.Extinction Extinction;
        }
        private Control CreateInstance(GameTrainer Game)
        {
            Control Result = null;
            switch (Game)
            {
                case GameTrainer.DBZX2:
                    if (SelectedGame.DBZX2 == null)
                        SelectedGame.DBZX2 = new DragonBallZXenoverse2();
                    Result = SelectedGame.DBZX2;
                    break;
                case GameTrainer.IFL:
                    if (SelectedGame.IFL == null)
                        SelectedGame.IFL = new Game_Trainers.InfamousFirstLight();
                    Result = SelectedGame.IFL;
                    break;
                case GameTrainer.MGSV:
                    if (SelectedGame.MetalGear5 == null)
                        SelectedGame.MetalGear5 = new MGSV();
                    Result = SelectedGame.MetalGear5;
                    break;
                case GameTrainer.NBA17:
                    if (SelectedGame.NBA17 == null)
                        SelectedGame.NBA17 = new NBA2K17();
                    Result = SelectedGame.NBA17;
                    break;
                case GameTrainer.RE4:
                    if (SelectedGame.ResEvil4 == null)
                        SelectedGame.ResEvil4 = new re4();
                    Result = SelectedGame.ResEvil4;
                    break;
                case GameTrainer.RE5:
                    if (SelectedGame.ResEvil5 == null)
                        SelectedGame.ResEvil5 = new Game_Trainers.re5();
                    Result = SelectedGame.ResEvil5;
                    break;
                case GameTrainer.TLOU:
                    if (SelectedGame.TheLastofUs == null)
                        SelectedGame.TheLastofUs = new TheLastofUs();
                    Result = SelectedGame.TheLastofUs;
                    break;
                case GameTrainer.YK:
                    if (SelectedGame.YakuzaKiwami == null)
                        SelectedGame.YakuzaKiwami = new Game_Trainers.YakuzaKiwami();
                    Result = SelectedGame.YakuzaKiwami;
                    break;
                case GameTrainer.uc4:
                    if (SelectedGame.Uncharted4 == null)
                        SelectedGame.Uncharted4 = new Game_Trainers.Uncharted4();
                    Result = SelectedGame.Uncharted4;
                    break;
                case GameTrainer.diablo3:
                    if (SelectedGame.Diablo3 == null)
                        SelectedGame.Diablo3 = new Game_Trainers.Diablo3();
                    Result = SelectedGame.Diablo3;
                    break;
                case GameTrainer.uc1:
                    if (SelectedGame.Uncharted1 == null)
                        SelectedGame.Uncharted1 = new Game_Trainers.Uncharted1();
                    Result = SelectedGame.Uncharted1;
                    break;
                case GameTrainer.uc2:
                    if (SelectedGame.Uncharted2 == null)
                        SelectedGame.Uncharted2 = new Game_Trainers.Uncharted2();
                    Result = SelectedGame.Uncharted2;
                    break;
                case GameTrainer.uc3:
                    if (SelectedGame.Uncharted3 == null)
                        SelectedGame.Uncharted3 = new Game_Trainers.Uncharted3();
                    Result = SelectedGame.Uncharted3;
                    break;
                case GameTrainer.ucll:
                    if (SelectedGame.UnchartedLL == null)
                        SelectedGame.UnchartedLL = new Game_Trainers.UnchartedLL();
                    Result = SelectedGame.UnchartedLL;
                    break;
                case GameTrainer.gow4:
                    if (SelectedGame.GodofWar4 == null)
                        SelectedGame.GodofWar4 = new Game_Trainers.GodofWar4();
                    Result = SelectedGame.GodofWar4;
                    break;
                case GameTrainer.sonicmania:
                    if (SelectedGame.SonicMania == null)
                        SelectedGame.SonicMania = new Game_Trainers.SonicMania();
                    Result = SelectedGame.SonicMania;
                    break;
                case GameTrainer.dqh2:
                    if (SelectedGame.DragonQH2 == null)
                        SelectedGame.DragonQH2 = new Game_Trainers.DragonQH2();
                    Result = SelectedGame.DragonQH2;
                    break;
                case GameTrainer.yz:
                    if (SelectedGame.YakuzaZero == null)
                        SelectedGame.YakuzaZero = new Game_Trainers.YakuzaZero();
                    Result = SelectedGame.YakuzaZero;
                    break;
                case GameTrainer.NBA18:
                    if (SelectedGame.NBA2K18 == null)
                        SelectedGame.NBA2K18 = new Game_Trainers.NBA2K18();
                    Result = SelectedGame.NBA2K18;
                    break;
                case GameTrainer.NFSP:
                    if (SelectedGame.NFSPayback == null)
                        SelectedGame.NFSPayback = new Game_Trainers.NFSPayback();
                    Result = SelectedGame.NFSPayback;
                    break;
                case GameTrainer.RE7:
                    if (SelectedGame.RE7 == null)
                        SelectedGame.RE7 = new Game_Trainers.RE7();
                    Result = SelectedGame.RE7;
                    break;
                case GameTrainer.Tekken7:
                    if (SelectedGame.Tekken7 == null)
                        SelectedGame.Tekken7 = new Game_Trainers.Tekken7();
                    Result = SelectedGame.Tekken7;
                    break;
                case GameTrainer.TEW2:
                    if (SelectedGame.TEW2 == null)
                        SelectedGame.TEW2 = new Game_Trainers.TEW2();
                    Result = SelectedGame.TEW2;
                    break;
                case GameTrainer.RAC:
                    if (SelectedGame.RAC == null)
                        SelectedGame.RAC = new Game_Trainers.RAC();
                    Result = SelectedGame.RAC;
                    break;
                case GameTrainer.DLEE:
                    if (SelectedGame.DyingLightEE == null)
                        SelectedGame.DyingLightEE = new Game_Trainers.DyingLightEE();
                    Result = SelectedGame.DyingLightEE;
                    break;
                case GameTrainer.ISS:
                    if (SelectedGame.InfamousSecondSon == null)
                        SelectedGame.InfamousSecondSon = new Game_Trainers.InfamousSecondSon();
                    Result = SelectedGame.InfamousSecondSon;
                    break;
                case GameTrainer.DMC3:
                    if (SelectedGame.DMC3 == null)
                        SelectedGame.DMC3 = new Game_Trainers.DMC3();
                    Result = SelectedGame.DMC3;
                    break;
                case GameTrainer.BBGOTY:
                    if (SelectedGame.Bbgoty == null)
                        SelectedGame.Bbgoty = new Game_Trainers.bbgoty();
                    Result = SelectedGame.Bbgoty;
                    break;
                case GameTrainer.GB:
                    if (SelectedGame.Ghostbusters == null)
                        SelectedGame.Ghostbusters = new Game_Trainers.Ghostbusters();
                    Result = SelectedGame.Ghostbusters;
                    break;
                case GameTrainer.FarCry5:
                    if (SelectedGame.FarCry5 == null)
                        SelectedGame.FarCry5 = new Game_Trainers.FarCry5();
                    Result = SelectedGame.FarCry5;
                    break;
                case GameTrainer.HGG:
                    if (SelectedGame.HokutoGaGotoku == null)
                        SelectedGame.HokutoGaGotoku = new Game_Trainers.HokutoGaGotoku();
                    Result = SelectedGame.HokutoGaGotoku;
                    break;
                case GameTrainer.ACO:
                    if (SelectedGame.ACOrigins == null)
                        SelectedGame.ACOrigins = new Game_Trainers.ACOrigins();
                    Result = SelectedGame.ACOrigins;
                    break;
                case GameTrainer.KSF:
                    if (SelectedGame.KillzoneSF == null)
                        SelectedGame.KillzoneSF = new Game_Trainers.KillzoneSF();
                    Result = SelectedGame.KillzoneSF;
                    break;
                case GameTrainer.twthk:
                    if (SelectedGame.WitchHundredKnights == null)
                        SelectedGame.WitchHundredKnights = new Game_Trainers.WitchHundredKnights();
                    Result = SelectedGame.WitchHundredKnights;
                    break;
                case GameTrainer.cbt:
                    if (SelectedGame.CrashBandicoot == null)
                        SelectedGame.CrashBandicoot = new Game_Trainers.CrashBandicoot();
                    Result = SelectedGame.CrashBandicoot;
                    break;
                case GameTrainer.rotr:
                    if (SelectedGame.ROTR20Year == null)
                        SelectedGame.ROTR20Year = new Game_Trainers.ROTR20Year();
                    Result = SelectedGame.ROTR20Year;
                    break;
                case GameTrainer.MHW:
                    if (SelectedGame.MHW == null)
                        SelectedGame.MHW = new Game_Trainers.MHW();
                    Result = SelectedGame.MHW;
                    break;
                case GameTrainer.DAX3:
                    if (SelectedGame.DAX3 == null)
                        SelectedGame.DAX3 = new Game_Trainers.DAX3();
                    Result = SelectedGame.DAX3;
                    break;
                case GameTrainer.HZDCE:
                    if (SelectedGame.HZDCE == null)
                        SelectedGame.HZDCE = new Game_Trainers.HZDCE();
                    Result = SelectedGame.HZDCE;
                    break;
                case GameTrainer.W3GOTY:
                    if (SelectedGame.Witcher3 == null)
                        SelectedGame.Witcher3 = new Game_Trainers.Witcher3();
                    Result = SelectedGame.Witcher3;
                    break;
                case GameTrainer.RE6:
                    if (SelectedGame.RE6 == null)
                        SelectedGame.RE6 = new Game_Trainers.RE6();
                    Result = SelectedGame.RE6;
                    break;
                case GameTrainer.SOTC:
                    if (SelectedGame.SOTC == null)
                        SelectedGame.SOTC = new Game_Trainers.SOTC();
                    Result = SelectedGame.SOTC;
                    break;
                case GameTrainer.FFXV:
                    if (SelectedGame.FFXV == null)
                        SelectedGame.FFXV = new Game_Trainers.FFXV();
                    Result = SelectedGame.FFXV;
                    break;
                case GameTrainer.UFC3:
                    if (SelectedGame.UFC3 == null)
                        SelectedGame.UFC3 = new Game_Trainers.UFC3();
                    Result = SelectedGame.UFC3;
                    break;
                case GameTrainer.DS3FFE:
                    if (SelectedGame.DS3FFE == null)
                        SelectedGame.DS3FFE = new Game_Trainers.DS3FFE();
                    Result = SelectedGame.DS3FFE;
                    break;
                case GameTrainer.Resogun:
                    if (SelectedGame.Resogun == null)
                        SelectedGame.Resogun = new Game_Trainers.Resogun();
                    Result = SelectedGame.Resogun;
                    break;
                case GameTrainer.RER1:
                    if (SelectedGame.RER1 == null)
                        SelectedGame.RER1 = new Game_Trainers.RER1();
                    Result = SelectedGame.RER1;
                    break;
                case GameTrainer.BMAN:
                    if (SelectedGame.BMAN == null)
                        SelectedGame.BMAN = new Game_Trainers.BMAN();
                    Result = SelectedGame.BMAN;
                    break;
                case GameTrainer.RER2:
                    if (SelectedGame.RER2 == null)
                        SelectedGame.RER2 = new Game_Trainers.RER2();
                    Result = SelectedGame.RER2;
                    break;
                case GameTrainer.DOOM:
                    if (SelectedGame.DOOM == null)
                        SelectedGame.DOOM = new Game_Trainers.DOOM();
                    Result = SelectedGame.DOOM;
                    break;
                case GameTrainer.gow3:
                    if (SelectedGame.GOW3 == null)
                        SelectedGame.GOW3 = new Game_Trainers.GOW3();
                    Result = SelectedGame.GOW3;
                    break;
                case GameTrainer.AS2:
                    if (SelectedGame.AS2 == null)
                        SelectedGame.AS2 = new Game_Trainers.AS2();
                    Result = SelectedGame.AS2;
                    break;
                case GameTrainer.WatchDogs1:
                    if (SelectedGame.WatchDogs1 == null)
                        SelectedGame.WatchDogs1 = new Game_Trainers.WatchDogs1();
                    Result = SelectedGame.WatchDogs1;
                    break;
                case GameTrainer.DBFZ:
                    if (SelectedGame.DBZF == null)
                        SelectedGame.DBZF = new Game_Trainers.DBZF();
                    Result = SelectedGame.DBZF;
                    break;
                case GameTrainer.BF1:
                    if (SelectedGame.BF1 == null)
                        SelectedGame.BF1 = new Game_Trainers.BF1();
                    Result = SelectedGame.BF1;
                    break;
                case GameTrainer.Injustice2:
                    if (SelectedGame.Injustice2 == null)
                        SelectedGame.Injustice2 = new Game_Trainers.Injustice2();
                    Result = SelectedGame.Injustice2;
                    break;
                case GameTrainer.WatchDogs2:
                    if (SelectedGame.WatchDogs2 == null)
                        SelectedGame.WatchDogs2 = new Game_Trainers.WatchDogs2();
                    Result = SelectedGame.WatchDogs2;
                    break;
                case GameTrainer.DeadNation:
                    if (SelectedGame.DeadNation == null)
                        SelectedGame.DeadNation = new Game_Trainers.DeadNation();
                    Result = SelectedGame.DeadNation;
                    break;
                case GameTrainer.KH1:
                    if (SelectedGame.KH1 == null)
                        SelectedGame.KH1 = new Game_Trainers.KH1();
                    Result = SelectedGame.KH1;
                    break;
                case GameTrainer.JustCause3:
                    if (SelectedGame.JustCause3 == null)
                        SelectedGame.JustCause3 = new Game_Trainers.JustCause3();
                    Result = SelectedGame.JustCause3;
                    break;
                case GameTrainer.MadMax:
                    if (SelectedGame.MadMax == null)
                        SelectedGame.MadMax = new Game_Trainers.MadMax();
                    Result = SelectedGame.MadMax;
                    break;
                case GameTrainer.TO1886:
                    if (SelectedGame.TO1886 == null)
                        SelectedGame.TO1886 = new Game_Trainers.TO1886();
                    Result = SelectedGame.TO1886;
                    break;
                case GameTrainer.DeadRising4:
                    if (SelectedGame.DeadRising4 == null)
                        SelectedGame.DeadRising4 = new Game_Trainers.DeadRising4();
                    Result = SelectedGame.DeadRising4;
                    break;
                case GameTrainer.WTNO:
                    if (SelectedGame.WTNO == null)
                        SelectedGame.WTNO = new Game_Trainers.WTNO();
                    Result = SelectedGame.WTNO;
                    break;
                case GameTrainer.WTNC:
                    if (SelectedGame.WTNC == null)
                        SelectedGame.WTNC = new Game_Trainers.WTNC();
                    Result = SelectedGame.WTNC;
                    break;
                case GameTrainer.WTOB:
                    if (SelectedGame.WTOB == null)
                        SelectedGame.WTOB = new Game_Trainers.WTOB();
                    Result = SelectedGame.WTOB;
                    break;
                case GameTrainer.TEW1:
                    if (SelectedGame.TEW1 == null)
                        SelectedGame.TEW1 = new Game_Trainers.TEW1();
                    Result = SelectedGame.TEW1;
                    break;
                case GameTrainer.MEA:
                    if (SelectedGame.MEA == null)
                        SelectedGame.MEA = new Game_Trainers.MEA();
                    Result = SelectedGame.MEA;
                    break;
                case GameTrainer.DWE:
                    if (SelectedGame.DWE == null)
                        SelectedGame.DWE = new Game_Trainers.DWE();
                    Result = SelectedGame.DWE;
                    break;
                case GameTrainer.HitmanGOTY:
                    if (SelectedGame.HitmanGOTY == null)
                        SelectedGame.HitmanGOTY = new Game_Trainers.HitmanGOTY();
                    Result = SelectedGame.HitmanGOTY;
                    break;
                case GameTrainer.D2:
                    if (SelectedGame.D2 == null)
                        SelectedGame.D2 = new Game_Trainers.D2();
                    Result = SelectedGame.D2;
                    break;
                case GameTrainer.AlienIsolation:
                    if (SelectedGame.AlienIsolation == null)
                        SelectedGame.AlienIsolation = new Game_Trainers.AlienIsolation();
                    Result = SelectedGame.AlienIsolation;
                    break;
                case GameTrainer.RE0:
                    if (SelectedGame.RE0 == null)
                        SelectedGame.RE0 = new Game_Trainers.RE0();
                    Result = SelectedGame.RE0;
                    break;
                case GameTrainer.RE1:
                    if (SelectedGame.RE1 == null)
                        SelectedGame.RE1 = new Game_Trainers.RE1();
                    Result = SelectedGame.RE1;
                    break;
                case GameTrainer.GravityRush:
                    if (SelectedGame.GravityRush == null)
                        SelectedGame.GravityRush = new Game_Trainers.GravityRush();
                    Result = SelectedGame.GravityRush;
                    break;
                case GameTrainer.SWB:
                    if (SelectedGame.SWB == null)
                        SelectedGame.SWB = new Game_Trainers.SWB();
                    Result = SelectedGame.SWB;
                    break;
                case GameTrainer.TombRaider:
                    if (SelectedGame.TombRaider == null)
                        SelectedGame.TombRaider = new Game_Trainers.TombRaider();
                    Result = SelectedGame.TombRaider;
                    break;
                case GameTrainer.Fallout4:
                    if (SelectedGame.Fallout4 == null)
                        SelectedGame.Fallout4 = new Game_Trainers.Fallout4();
                    Result = SelectedGame.Fallout4;
                    break;
                case GameTrainer.Yakuza6:
                    if (SelectedGame.Yakuza6 == null)
                        SelectedGame.Yakuza6 = new Game_Trainers.Yakuza6();
                    Result = SelectedGame.Yakuza6;
                    break;
                case GameTrainer.Mafia3:
                    if (SelectedGame.Mafia3 == null)
                        SelectedGame.Mafia3 = new Game_Trainers.Mafia3();
                    Result = SelectedGame.Mafia3;
                    break;
                case GameTrainer.HR:
                    if (SelectedGame.HR == null)
                        SelectedGame.HR = new Game_Trainers.HR();
                    Result = SelectedGame.HR;
                    break;
                case GameTrainer.NA:
                    if (SelectedGame.NA == null)
                        SelectedGame.NA = new Game_Trainers.NA();
                    Result = SelectedGame.NA;
                    break;
                case GameTrainer.Minecraft:
                    if (SelectedGame.Minecraft == null)
                        SelectedGame.Minecraft = new Game_Trainers.Minecraft();
                    Result = SelectedGame.Minecraft;
                    break;
                case GameTrainer.Home:
                    if (SelectedGame.Home == null)
                        SelectedGame.Home = new Home();
                    Result = SelectedGame.Home;
                    break;
                case GameTrainer.MESW:
                    if (SelectedGame.MESW == null)
                        SelectedGame.MESW = new Game_Trainers.MESW();
                    Result = SelectedGame.MESW;
                    break;
                case GameTrainer.MR:
                    if (SelectedGame.MR == null)
                        SelectedGame.MR = new Game_Trainers.MR();
                    Result = SelectedGame.MR;
                    break;
                case GameTrainer._7Days:
                    if (SelectedGame._7Days == null)
                        SelectedGame._7Days = new Game_Trainers._7Days();
                    Result = SelectedGame._7Days;
                    break;
                case GameTrainer.SleepingDogs:
                    if (SelectedGame.SleepingDogs == null)
                        SelectedGame.SleepingDogs = new Game_Trainers.SleepingDogs();
                    Result = SelectedGame.SleepingDogs;
                    break;
                case GameTrainer.MKX:
                    if (SelectedGame.MKX == null)
                        SelectedGame.MKX = new Game_Trainers.MKX();
                    Result = SelectedGame.MKX;
                    break;
                case GameTrainer.DSCS:
                    if (SelectedGame.DSCS == null)
                        SelectedGame.DSCS = new Game_Trainers.DSCS();
                    Result = SelectedGame.DSCS;
                    break;
                case GameTrainer.GRW:
                    if (SelectedGame.GRW == null)
                        SelectedGame.GRW = new Game_Trainers.GRW();
                    Result = SelectedGame.GRW;
                    break;
                case GameTrainer.Skyrim:
                    if (SelectedGame.Skyrim == null)
                        SelectedGame.Skyrim = new Game_Trainers.Skyrim();
                    Result = SelectedGame.Skyrim;
                    break;
                case GameTrainer.ACS:
                    if (SelectedGame.ACS == null)
                        SelectedGame.ACS = new Game_Trainers.ACS();
                    Result = SelectedGame.ACS;
                    break;
                case GameTrainer.Dishonored2:
                    if (SelectedGame.Dishonored2 == null)
                        SelectedGame.Dishonored2 = new Game_Trainers.Dishonored2();
                    Result = SelectedGame.Dishonored2;
                    break;
                case GameTrainer.DDOO:
                    if (SelectedGame.DDOO == null)
                        SelectedGame.DDOO = new Game_Trainers.DDOO();
                    Result = SelectedGame.DDOO;
                    break;
                case GameTrainer.Outlast2:
                    if (SelectedGame.Outlast2 == null)
                        SelectedGame.Outlast2 = new Game_Trainers.Outlast2();
                    Result = SelectedGame.Outlast2;
                    break;
                case GameTrainer.DMC4:
                    if (SelectedGame.DMC4 == null)
                        SelectedGame.DMC4 = new Game_Trainers.DMC4();
                    Result = SelectedGame.DMC4;
                    break;
                case GameTrainer.NBAL18:
                    if (SelectedGame.NBAL18 == null)
                        SelectedGame.NBAL18 = new Game_Trainers.NBAL18();
                    Result = SelectedGame.NBAL18;
                    break;
                case GameTrainer.FCP:
                    if (SelectedGame.FCP == null)
                        SelectedGame.FCP = new Game_Trainers.FCP();
                    Result = SelectedGame.FCP;
                    break;
                case GameTrainer.ACDD:
                    if (SelectedGame.ACDD == null)
                        SelectedGame.ACDD = new API.ACDD();
                    Result = SelectedGame.ACDD;
                    break;
                case GameTrainer.Persona5:
                    if (SelectedGame.Persona5 == null)
                        SelectedGame.Persona5 = new Game_Trainers.Persona5();
                    Result = SelectedGame.Persona5;
                    break;
                case GameTrainer.WWE18:
                    if (SelectedGame.WWE18 == null)
                        SelectedGame.WWE18 = new Game_Trainers.WWE18();
                    Result = SelectedGame.WWE18;
                    break;
                case GameTrainer.ACU:
                    if (SelectedGame.ACU == null)
                        SelectedGame.ACU = new Game_Trainers.ACU();
                    Result = SelectedGame.ACU;
                    break;
                case GameTrainer.LOTF:
                    if (SelectedGame.LOTF == null)
                        SelectedGame.LOTF = new Game_Trainers.LOTF();
                    Result = SelectedGame.LOTF;
                    break;
                case GameTrainer.R6S:
                    if (SelectedGame.R6S == null)
                        SelectedGame.R6S = new Game_Trainers.R6S();
                    Result = SelectedGame.R6S;
                    break;
                case GameTrainer.TF:
                    if (SelectedGame.TF == null)
                        SelectedGame.TF = new Game_Trainers.TF();
                    Result = SelectedGame.TF;
                    break;
                case GameTrainer.AOM:
                    if (SelectedGame.AOM == null)
                        SelectedGame.AOM = new Game_Trainers.AOM();
                    Result = SelectedGame.AOM;
                    break;
                case GameTrainer.SE4:
                    if (SelectedGame.SE4 == null)
                        SelectedGame.SE4 = new Game_Trainers.SE4();
                    Result = SelectedGame.SE4;
                    break;
                case GameTrainer.DEMD:
                    if (SelectedGame.DEMD == null)
                        SelectedGame.DEMD = new Game_Trainers.DEMD();
                    Result = SelectedGame.DEMD;
                    break;
                case GameTrainer.TD:
                    if (SelectedGame.TD == null)
                        SelectedGame.TD = new Game_Trainers.TD();
                    Result = SelectedGame.TD;
                    break;
                case GameTrainer.BFH:
                    if (SelectedGame.BFH == null)
                        SelectedGame.BFH = new Game_Trainers.BFH();
                    Result = SelectedGame.BFH;
                    break;
                case GameTrainer.LEGOHOBBIT:
                    if (SelectedGame.LEGOHOBBIT == null)
                        SelectedGame.LEGOHOBBIT = new Game_Trainers.LEGOHOBBIT();
                    Result = SelectedGame.LEGOHOBBIT;
                    break;
                case GameTrainer.Nioh:
                    if (SelectedGame.Nioh == null)
                        SelectedGame.Nioh = new Game_Trainers.Nioh();
                    Result = SelectedGame.Nioh;
                    break;
                case GameTrainer.MKXL:
                    if (SelectedGame.MKXL == null)
                        SelectedGame.MKXL = new Game_Trainers.MKXL();
                    Result = SelectedGame.MKXL;
                    break;
                case GameTrainer.TF2:
                    if (SelectedGame.TF2 == null)
                        SelectedGame.TF2 = new Game_Trainers.TF2();
                    Result = SelectedGame.TF2;
                    break;
                case GameTrainer.FIFA18:
                    if (SelectedGame.FIFA18 == null)
                        SelectedGame.FIFA18 = new Game_Trainers.FIFA18();
                    Result = SelectedGame.FIFA18;
                    break;
                case GameTrainer.TQ:
                    if (SelectedGame.TQ == null)
                        SelectedGame.TQ = new Game_Trainers.TQ();
                    Result = SelectedGame.TQ;
                    break;
                case GameTrainer.Technomancer:
                    if (SelectedGame.Technomancer == null)
                        SelectedGame.Technomancer = new Game_Trainers.Technomancer();
                    Result = SelectedGame.Technomancer;
                    break;
                case GameTrainer.Thief:
                    if (SelectedGame.Thief == null)
                        SelectedGame.Thief = new Game_Trainers.Thief();
                    Result = SelectedGame.Thief;
                    break;
                case GameTrainer.PES18:
                    if (SelectedGame.PES18 == null)
                        SelectedGame.PES18 = new Game_Trainers.PES18();
                    Result = SelectedGame.PES18;
                    break;
                case GameTrainer.BS1:
                    if (SelectedGame.BS1 == null)
                        SelectedGame.BS1 = new Game_Trainers.BS1();
                    Result = SelectedGame.BS1;
                    break;
                case GameTrainer.BS2:
                    if (SelectedGame.BS2 == null)
                        SelectedGame.BS2 = new Game_Trainers.BS2();
                    Result = SelectedGame.BS2;
                    break;
                case GameTrainer.BSI:
                    if (SelectedGame.BSI == null)
                        SelectedGame.BSI = new Game_Trainers.BSI();
                    Result = SelectedGame.BSI;
                    break;
                case GameTrainer.BTHC:
                    if (SelectedGame.BTHC == null)
                        SelectedGame.BTHC = new Game_Trainers.BTHC();
                    Result = SelectedGame.BTHC;
                    break;
                case GameTrainer.BTPS:
                    if (SelectedGame.BTPS == null)
                        SelectedGame.BTPS = new Game_Trainers.BTPS();
                    Result = SelectedGame.BTPS;
                    break;
                case GameTrainer.FC4:
                    if (SelectedGame.FC4 == null)
                        SelectedGame.FC4 = new Game_Trainers.FC4();
                    Result = SelectedGame.FC4;
                    break;
                case GameTrainer.BF4:
                    if (SelectedGame.BF4 == null)
                        SelectedGame.BF4 = new Game_Trainers.BF4();
                    Result = SelectedGame.BF4;
                    break;
                case GameTrainer.Prey:
                    if (SelectedGame.Prey == null)
                        SelectedGame.Prey = new Game_Trainers.Prey();
                    Result = SelectedGame.Prey;
                    break;
                case GameTrainer.Extinction:
                    if (SelectedGame.Extinction == null)
                        SelectedGame.Extinction = new Game_Trainers.Extinction();
                    Result = SelectedGame.Extinction;
                    break;
            }
            return Result;
        }
        private void TheStuff(object sender, EventArgs e)
        {
            theme.FlatButton Btn = sender as theme.FlatButton;
            theme.FlatButton[] Buttons = { load_DragonBallZXenoverse2, load_InfamousFirstLight, load_mgsV, load_nba2k17, load_re4, load_re5, load_tlou, load_ucll, load_YakuzaKiwami, load_diablo3, load_uc1, load_uc2, load_uc3, load_uc4, load_gow4, load_sonicmania, load_dqh2, load_YakuzaZero, load_nba2k18, load_NFSPayback, load_re7, load_tekken7, load_tew2, load_ratchetClank, load_dyinglight, load_infSecSon, load_DMC3, load_acorigins, load_ghostbusters, load_farcry5, load_hokutogagotogku, load_acorigins, load_killzonesf, load_twthk, load_bbgoty, load_CrashBandicoot, load_rotr, load_MHW, load_DAX3, load_HZDCE, load_Witcher3GOTY, load_re6, load_SOTC, load_FFXV, load_UFC3, load_DS3FFE, load_Resogun, load_RER1, load_BMAN, load_RER2, load_DOOM, load_gow3, load_AS2, load_WatchDogs1, load_DBFZ, load_BF1, load_Injustice2, load_WatchDogs2, load_DeadNation, load_KH1, load_JustCause3, load_MadMax, load_TO1886, load_DeadRising4, load_WTNO, load_WTNC, load_WTOB, load_TEW1, load_MEA, load_DWE, load_HitmanGOTY, load_D2, load_AlienIsolation, load_RE0, load_RE1, load_GravityRush, load_SWB, load_TombRaider, load_Fallout4, load_Yakuza6, load_Mafia3, load_HR, load_NA, load_Minecraft, load_Home, load_MESW, load_MR, load_7Days, load_SleepingDogs, load_MKX, load_DSCS, load_Skyrim, load_ACS, load_Dishonored2, load_DDOO, load_Outlast2, load_DMC4, load_NBAL18, load_FCP, load_ACDD, load_Persona5, load_WWE18, load_ACU, load_LOTF, load_R6S, load_TF, load_AOM, load_SE4, load_DEMD, load_TD, load_BFH, load_LEGOHOBBIT, load_Nioh, load_MKXL, load_TF2, load_FIFA18, load_TQ, load_Technomancer, load_Thief, load_PES18, load_BS1, load_BS2, load_BSI, load_BTHC, load_BTPS, load_FC4, load_BF4, load_Prey, load_Extinction };
            foreach (var item in Buttons) item.BackColor = Color.Transparent;
            for (int i = 0; i < Buttons.Length; i++)
                if (Btn.Name != Buttons[i].Name)
                    Btn.BackColor = Color.FromArgb(63, 147, 234);
            child_panel.Controls.Clear();
            switch (Btn.Name)
            {
                case "load_DragonBallZXenoverse2":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.DBZX2));
                    break;
                case "load_InfamousFirstLight":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.IFL));
                    break;
                case "load_mgsV":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.MGSV));
                    break;
                case "load_nba2k17":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.NBA17));
                    break;
                case "load_re4":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.RE4));
                    break;
                case "load_re5":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.RE5));
                    break;
                case "load_tlou":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.TLOU));
                    break;
                case "load_YakuzaKiwami":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.YK));
                    break;
                case "load_uc4":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.uc4));
                    break;
                case "load_diablo3":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.diablo3));
                    break;
                case "load_uc1":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.uc1));
                    break;
                case "load_uc2":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.uc2));
                    break;
                case "load_uc3":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.uc3));
                    break;
                case "load_ucll":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.ucll));
                    break;
                case "load_gow4":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.gow4));
                    break;
                case "load_sonicmania":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.sonicmania));
                    break;
                case "load_dqh2":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.dqh2));
                    break;
                case "load_YakuzaZero":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.yz));
                    break;
                case "load_nba2k18":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.NBA18));
                    break;
                case "load_NFSPayback":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.NFSP));
                    break;
                case "load_re7":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.RE7));
                    break;
                case "load_tekken7":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.Tekken7));
                    break;
                case "load_tew2":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.TEW2));
                    break;
                case "load_ratchetClank":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.RAC));
                    break;
                case "load_dyinglight":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.DLEE));
                    break;
                case "load_infSecSon":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.ISS));
                    break;
                case "load_DMC3":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.DMC3));
                    break;
                case "load_bbgoty":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.BBGOTY));
                    break;
                case "load_ghostbusters":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.GB));
                    break;
                case "load_farcry5":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.FarCry5));
                    break;
                case "load_hokutogagotogku":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.HGG));
                    break;
                case "load_acorigins":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.ACO));
                    break;
                case "load_killzonesf":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.KSF));
                    break;
                case "load_twthk":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.twthk));
                    break;
                case "load_CrashBandicoot":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.cbt));
                    break;
                case "load_rotr":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.rotr));
                    break;
                case "load_MHW":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.MHW));
                    break;
                case "load_DAX3":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.DAX3));
                    break;
                case "load_HZDCE":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.HZDCE));
                    break;
                case "load_Witcher3GOTY":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.W3GOTY));
                    break;
                case "load_re6":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.RE6));
                    break;
                case "load_SOTC":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.SOTC));
                    break;
                case "load_FFXV":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.FFXV));
                    break;
                case "load_UFC3":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.UFC3));
                    break;
                case "load_DS3FFE":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.DS3FFE));
                    break;
                case "load_Resogun":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.Resogun));
                    break;
                case "load_RER1":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.RER1));
                    break;
                case "load_BMAN":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.BMAN));
                    break;
                case "load_RER2":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.RER2));
                    break;
                case "load_DOOM":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.DOOM));
                    break;
                case "load_gow3":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.gow3));
                    break;
                case "load_AS2":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.AS2));
                    break;
                case "load_WatchDogs1":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.WatchDogs1));
                    break;
                case "load_DBFZ":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.DBFZ));
                    break;
                case "load_BF1":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.BF1));
                    break;
                case "load_Injustice2":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.Injustice2));
                    break;
                case "load_WatchDogs2":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.WatchDogs2));
                    break;
                case "load_DeadNation":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.DeadNation));
                    break;
                case "load_KH1":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.KH1));
                    break;
                case "load_JustCause3":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.JustCause3));
                    break;
                case "load_MadMax":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.MadMax));
                    break;
                case "load_TO1886":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.TO1886));
                    break;
                case "load_DeadRising4":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.DeadRising4));
                    break;
                case "load_WTNO":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.WTNO));
                    break;
                case "load_WTNC":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.WTNC));
                    break;
                case "load_WTOB":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.WTOB));
                    break;
                case "load_TEW1":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.TEW1));
                    break;
                case "load_MEA":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.MEA));
                    break;
                case "load_DWE":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.DWE));
                    break;
                case "load_HitmanGOTY":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.HitmanGOTY));
                    break;
                case "load_D2":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.D2));
                    break;
                case "load_AlienIsolation":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.AlienIsolation));
                    break;
                case "load_RE0":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.RE0));
                    break;
                case "load_RE1":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.RE1));
                    break;
                case "load_GravityRush":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.GravityRush));
                    break;
                case "load_SWB":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.SWB));
                    break;
                case "load_TombRaider":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.TombRaider));
                    break;
                case "load_Fallout4":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.Fallout4));
                    break;
                case "load_Yakuza6":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.Yakuza6));
                    break;
                case "load_Mafia3":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.Mafia3));
                    break;
                case "load_HR":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.HR));
                    break;
                case "load_NA":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.NA));
                    break;
                case "load_Minecraft":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.Minecraft));
                    break;
                case "load_Home":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.Home));
                    break;
                case "load_MESW":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.MESW));
                    break;
                case "load_MR":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.MR));
                    break;
                case "load_7Days":
                    child_panel.Controls.Add(CreateInstance(GameTrainer._7Days));
                    break;
                case "load_SleepingDogs":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.SleepingDogs));
                    break;
                case "load_MKX":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.MKX));
                    break;
                case "load_DSCS":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.DSCS));
                    break;
                case "load_GRW":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.GRW));
                    break;
                case "load_Skyrim":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.Skyrim));
                    break;
                case "load_ACS":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.ACS));
                    break;
                case "load_Dishonored2":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.Dishonored2));
                    break;
                case "load_DDOO":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.DDOO));
                    break;
                case "load_Outlast2":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.Outlast2));
                    break;
                case "load_DMC4":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.DMC4));
                    break;
                case "load_NBAL18":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.NBAL18));
                    break;
                case "load_FCP":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.FCP));
                    break;
                case "load_ACDD":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.ACDD));
                    break;
                case "load_Persona5":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.Persona5));
                    break;
                case "load_WWE18":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.WWE18));
                    break;
                case "load_ACU":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.ACU));
                    break;
                case "load_LOTF":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.LOTF));
                    break;
                case "load_R6S":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.R6S));
                    break;
                case "load_TF":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.TF));
                    break;
                case "load_AOM":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.AOM));
                    break;
                case "load_SE4":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.SE4));
                    break;
                case "load_DEMD":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.DEMD));
                    break;
                case "load_TD":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.TD));
                    break;
                case "load_BFH":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.BFH));
                    break;
                case "load_LEGOHOBBIT":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.LEGOHOBBIT));
                    break;
                case "load_Nioh":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.Nioh));
                    break;
                case "load_MKXL":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.MKXL));
                    break;
                case "load_TF2":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.TF2));
                    break;
                case "load_FIFA18":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.FIFA18));
                    break;
                case "load_TQ":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.TQ));
                    break;
                case "load_Technomancer":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.Technomancer));
                    break;
                case "load_Thief":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.Thief));
                    break;
                case "load_PES18":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.PES18));
                    break;
                case "load_BS1":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.BS1));
                    break;
                case "load_BS2":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.BS2));
                    break;
                case "load_BSI":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.BSI));
                    break;
                case "load_BTHC":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.BTHC));
                    break;
                case "load_BTPS":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.BTPS));
                    break;
                case "load_FC4":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.FC4));
                    break;
                case "load_BF4":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.BF4));
                    break;
                case "load_Prey":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.Prey));
                    break;
                case "load_Extinction":
                    child_panel.Controls.Add(CreateInstance(GameTrainer.Extinction));
                    break;
            }
        }

        #endregion

        private void btnCredits_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this,
                "TylerMods, Cain532" +
                "\nShiningami, DeathRGH" +
                "\ngolden, Andrew2007" +
                "\nChendoChap, BISOON",
                "Credits", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        void DeleteOld()
        {
            string filePath = $@"{Application.StartupPath}\old";
            string filePath1 = $@"{Application.StartupPath}\old.exe";
            string filePath2 = $@"{Application.StartupPath}\settings.ini";
            try
            {
                if (File.Exists(filePath))
                    File.Delete(filePath);
                if (File.Exists(filePath1))
                    File.Delete(filePath1);
                if (File.Exists(filePath2))
                    File.Delete(filePath2);
            }
            catch
            {
                MessageBox.Show("Check Task Manager and make sure you are not running any processes of the trainer. \nIt is common for people to not click the Ok button upon Update Success and that screen is still there.");
            }
        }

        void Updater()
        {

            try
            {
                WebClient wb = new WebClient();
                Assembly assembly = Assembly.GetExecutingAssembly();
                FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
                string newVersion = wb.DownloadString("https://pastebin.com/raw/2NzfaX9q");
                string yourVersion = fvi.FileVersion;

                if (newVersion != yourVersion)
                {
                    Update update = new Update();
                    update.Show();
                }
            }
            catch
            {
                MessageBox.Show("Failed to check for updates! You must have an internet connection to check for updates!", "No internet connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picFAQ_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this,
                "Q1: Why does it look like some buttons are missing? " +
                "\nA1: This is because we are not ready to release the game that belongs there but it is being worked on." +
                "\nQ2 : Why does it actively refuse the payload?" +
                "\nA2 : You need to be sure you enable HEN and then open Original before sending the payload. Also try clearing your cache.",
                "FAQ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }

        private void metroScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //timer1.Start();
        }

        private void child_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbFirmware_SelectedIndexChanged(object sender, EventArgs e)
        {
            int version = -1;

            switch (cmbFirmware.Text)
            {
                case "4.05": version = 405; break;
                case "4.55": version = 455; break;
                case "5.05": version = 505; break;
                case "5.05 - Mira": version = 505; break;
                    //case "5.07": version = 505; break;
            }
            Calling.version = version;

            Settings.Default.firmwareIndex = cmbFirmware.SelectedIndex;
            Settings.Default.Save();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void formSkin1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("https://discord.gg/bUEQj9p");
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void lblConnect_Click(object sender, EventArgs e)
        {
        }

        private void SearchBar(object sender, EventArgs e)
        {
            
            //Button load_ = sender as Button;
            //switch (load_.Name)
            //{
            //    case "load_":
            //        LoadButtons();
            //        break;
            //}
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            foreach (theme.FlatButton uc in flowLayoutPanel1.Controls.OfType<theme.FlatButton>())
            {
                if (!uc.Text.ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    uc.Visible = false;
                }
                else
                {
                    uc.Visible = true;
                }
            }

        }


        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void lblGameCount_Click(object sender, EventArgs e)
        {

        }

        private void tmrEverythingAlright_Tick(object sender, EventArgs e)
        {

        }

        private void tglFavorites_CheckedChanged(object sender)
        {
            ToggleFavorites(tglFavorites.Checked);


            //problem
            //if (tglFavorites.Checked)
            //{
            //    if (SelectedGame.Home.listBox1.Items.Count == 0)
            //    {
            //        lblNoFavs.Visible = true;
            //    }
            //    else
            //    {
            //        lblNoFavs.Visible = false;
            //    }
            //    pnlSearch.Visible = false;
            //}
            //else
            //{
            //    pnlSearch.Visible = true;
            //    lblNoFavs.Visible = false;
            //}
        }

        private void btnSelectIP_Click(object sender, EventArgs e)
        {
            IPSelect ipselect = new IPSelect();
            ipselect.Show();
        }
    }
}