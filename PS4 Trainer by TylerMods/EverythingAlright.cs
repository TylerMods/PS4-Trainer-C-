using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS4_Trainer_by_TylerMods
{
    public partial class EverythingAlright : Form
    {
        public EverythingAlright()
        {
            InitializeComponent();
            //var myScreen = Screen.FromControl(this);

            //this.Left = myScreen.Bounds.Left;
            //this.Top = myScreen.Bounds.Top;

            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width,
                                      workingArea.Bottom - Size.Height);
        }

        private void btnDiscord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/62YxXdj");
            this.Close();
        }

        private void NeedHelp_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EverythingAlright_Load(object sender, EventArgs e)
        {
            tmrEverythingAlright.Start();
        }

        private void tmrEverythingAlright_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
