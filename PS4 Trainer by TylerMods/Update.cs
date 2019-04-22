using System;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace PS4_Trainer_by_TylerMods
{
    public partial class Update : Form
    {

        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string newVersion = wb.DownloadString("https://pastebin.com/raw/2NzfaX9q");
            string yourVersion = fvi.FileVersion;

            lblCurrent.Text = $"Current Version - {yourVersion}";
            lblNewer.Text = $"Newer Version - {newVersion}";

        }

        void success()
        {
            this.Hide();
            try
            {
                Updater updater = new Updater();
                updater.Show();
                updater.FormClosed += new FormClosedEventHandler(Updater_FormClosed);

                void Updater_FormClosed(object sender, FormClosedEventArgs e)
                {
                    UpdateSuccess US = new UpdateSuccess();
                    US.Show();
                    US.FormClosed += new FormClosedEventHandler(UpdateSuccess_FormClosed);
                }
                void UpdateSuccess_FormClosed(object sender, FormClosedEventArgs e)
                {
                    Application.Exit();
                }
            }
            catch
            {
                MessageBox.Show("Failed to check for updates!", "No internet connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            success();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSelectIP_Click(object sender, EventArgs e)
        {
            var allChangeLogs = ChangelogData.GetAll();
            ChangeLog changeLog = allChangeLogs[0];

            if (btnSelectIP.ButtonText == "Show Changelog")
            {
                this.Size = new System.Drawing.Size(685, 277);
                btnSelectIP.ButtonText = "Hide Changelog";
                txtChangelog.Text = (changeLog.Changelog);
            }
            else if (btnSelectIP.ButtonText == "Hide Changelog")
            {
                this.Size = new System.Drawing.Size(343, 277);
                btnSelectIP.ButtonText = "Show Changelog";
            }

        }
    }
}
