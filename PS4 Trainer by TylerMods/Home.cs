using System;
using System.Windows.Forms;
using System.Net;
using System.Reflection;
using System.Diagnostics;
using System.IO;
using MetroFramework;
using System.Linq;
using System.Drawing;

namespace PS4_Trainer_by_TylerMods
{
    public partial class Home : UserControl
    {
        private void RefreshFavoriteGames()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(main.FavoriteGames.GetAllGames().ToArray());
        }   
        public Home()
        {
            InitializeComponent();
            RefreshFavoriteGames();
            
            
        }

        private void btnGameChecker_Click(object sender, EventArgs e)
        {
            var version = Util.GameInfoArray()[1]; //Grabs process's version
            var cusa = Util.GameInfoArray()[0]; //Grabs process's CUSA
            try
            {
                Calling.Notify("CUSA : " + $"{cusa}" + "\nVersion : " + $"{version}"); //Notifies PS4 with CUSA and Vesrion running
                pbGameImage.Load("https://store.playstation.com/store/api/chihiro/00_09_000/titlecontainer/US/en/999/" + Util.GameInfoArray()[0] + "_00/image"); //Uses the CUSA that was grabbed to load the image from the website.
                lblCUSA.Text = "CUSA : " + $"{cusa}";
                lblVersion.Text = "Version : " + $"{version}";
            }
            catch
            {
                lblCUSA.Text = "Make sure you are on the game!";
                lblVersion.Text = "This checks the game you have loaded on your PS4!";

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
                else
                {
                    MessageBox.Show("No updates found!");
                }
            }
            catch
            {
                MessageBox.Show("Failed to check for updates! You must have an internet connection to check for updates!", "No internet connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
                Updater();
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://paypal.me/darrell75");
            System.Diagnostics.Process.Start("https://www.patreon.com/TylerMods");
        }

        private void btnChangelog_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://pastebin.com/9vECK948");
        }

        private void btnSpreadsheet_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/spreadsheets/d/1ewt_dczs7MnCZGiLe2o1oN3Buno5IMtkeqrWChv8SME/edit?usp=sharing");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0];
            string imageUrl = ("https://store.playstation.com/store/api/chihiro/00_09_000/titlecontainer/US/en/999/" + Util.GameInfoArray()[0] + "_00/image");
            string saveLocation = @"Images\" + $"{cusa}.png";
            if (System.IO.Directory.Exists("Images"))
            {
                
            }
            else
            {
                System.IO.Directory.CreateDirectory("Images");
            }
                byte[] imageBytes;
                HttpWebRequest imageRequest = (HttpWebRequest)WebRequest.Create(imageUrl);
                WebResponse imageResponse = imageRequest.GetResponse();

                Stream responseStream = imageResponse.GetResponseStream();

                using (BinaryReader br = new BinaryReader(responseStream))
                {
                    imageBytes = br.ReadBytes(500000);
                    br.Close();
                }
                responseStream.Close();
                imageResponse.Close();

                FileStream fs = new FileStream(saveLocation, FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);
                try
                {
                    bw.Write(imageBytes);
                }
                finally
                {
                    fs.Close();
                    bw.Close();
                }
        }

        private void btnDonated_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "bigfirebird \naldizzle89 \nIH8UALL", "Huge thank you to these people for supporting the trainer!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnTrainerSite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ps4trainer.com/");
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(lblCUSA.Text);
                alrtCUSACopied.Visible = true;
            }
           catch
            {
                MessageBox.Show("Failed to copy to clipboard.");
            }
        }

        private void flatAlertBox2_Click(object sender, EventArgs e)
        {

        }
        private void appShortcutToDesktop(string linkName)
        {
            string deskDir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            using (StreamWriter writer = new StreamWriter(deskDir + "\\" + linkName + ".url"))
            {
                string app = System.Reflection.Assembly.GetExecutingAssembly().Location;
                writer.WriteLine("[InternetShortcut]");
                writer.WriteLine("URL=file:///" + app);
                writer.WriteLine("IconIndex=0");
                string icon = app.Replace('\\', '/');
                writer.WriteLine("IconFile=" + icon);
                writer.Flush();
            }
        }
        private void btnShortcut_Click(object sender, EventArgs e)
        {
            try
            {
                appShortcutToDesktop("PS4 Trainer by TylerMods");
                altShortcut.Visible = true;
            }
            catch
            {
                MessageBox.Show("Failed to create shortcut!");
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
        }

        private void btnAddFavorite_Click(object sender, EventArgs e)
        {
            main.FavoriteGames.AddNewGame(cmbFavorites.Text);
            RefreshFavoriteGames();
        }

        private void btnDeleteFav_Click(object sender, EventArgs e)
        {
            main.FavoriteGames.Delete(listBox1.SelectedItem.ToString());
            RefreshFavoriteGames();
        }

        private void Home_Load_1(object sender, EventArgs e)
        {
        }

        private void btnAttachHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This allows you to no longer require attaching if you are still on your game and need to reboot the trainer. Just boot the trainer and it will attach for you.");
        }
    }
}
