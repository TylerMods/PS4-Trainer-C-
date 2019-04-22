using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace PS4_Trainer_by_TylerMods
{
    public partial class Updater : Form
    {
        static Assembly assembly = Assembly.GetExecutingAssembly();
        FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
        private void StartDownload()
        {
        
                string downloadUrl = "https://pastebin.com/raw/1mR2KRkA";
                string updateFileUrl;

                WebClient wb = new WebClient();

                updateFileUrl = wb.DownloadString(downloadUrl);

                wb.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wb_DownloadProgressChanged);
                wb.DownloadFileCompleted += new AsyncCompletedEventHandler(wb_DownloadFileCompleted);
                wb.DownloadFileAsync(new Uri(updateFileUrl), "Update.exe");

         

        }
        static int thing;
        void wb_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e) //So, what exactly is it doin. I can show you
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                label_bytes.Text = $"{(e.BytesReceived / 1024d / 1024d).ToString("0.00")}mb / {(e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00")}mb";
                thing = e.ProgressPercentage;
            });
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Value = thing;

            label_percent.Text = $"{thing}%";
        }
        void wb_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                string fileName = "PS4 Trainer by TylerMods.exe";
                File.Move(fileName, $"old");
                File.Move("Update.exe", fileName);

                this.Close();
                //Process.Start($@"{Application.StartupPath}\{fileName}");
            });
        }

        public Updater()
        {
            InitializeComponent();
            StartDownload();
            this.Activate();
        }

        private void progressBar_progressChanged(object sender, EventArgs e)
        {

        }

        private void Updater_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_bytes_Click(object sender, EventArgs e)
        {

        }
    }
}
