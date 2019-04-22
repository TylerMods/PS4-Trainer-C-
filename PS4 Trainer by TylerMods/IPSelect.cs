using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS4_Trainer_by_TylerMods
{
    public partial class IPSelect : Form
    {

        public static PS4Consoles PS4Consoles = new PS4Consoles();
        static string ipTracker;
        public IPSelect()
        {
            InitializeComponent();
            RefreshPS4Consoles();
            ipTracker = PS4Consoles.DefaultPS4().IPAddress;
        }

        private void RefreshPS4Consoles()
        {
            lstPS4s.Items.Clear();
            var allPS4s = PS4Consoles.GetAllPS4s();
            PS4 defaultPS4 = PS4Consoles.DefaultPS4();
            try
            {
                int defaultIndex = -1;
                foreach (var ps4 in allPS4s)
                {
                    lstPS4s.Items.Add(ps4.Name);

                    if (ps4.Name == defaultPS4.Name)
                        lstPS4s.SelectedIndex = defaultIndex + 1;

                    defaultIndex++;
                }
            }
            catch
            {
                MessageBox.Show("There was an issue loading your PS4 list. Please contact us via Discord. \n\nIf you already know what a registry is, visit regedit.exe and delete the PS44 that may contain the invalid IP address.");
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            PS4 ps4 = new PS4();

            ps4.Name = txtName.Text;
            ps4.IPAddress = txtIP.Text;
            ps4.Firmware = txtFirmware.Text;
            PS4Consoles.AddPS4(ps4);
            RefreshPS4Consoles();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string ps4Name = lstPS4s.SelectedItem.ToString();
            PS4Consoles.DeletePS4(ps4Name);
            lstPS4s.Items.Remove(lstPS4s.SelectedItem);
        }

        private void lstPS4s_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstPS4s.SelectedItem == null)
                return;
            string ps4Name = lstPS4s.SelectedItem.ToString();
            PS4 ps4 = PS4Consoles.GetPS4Details(ps4Name);

            lblName.Text = "IP Name : " + ps4.Name;
            lblIP.Text = "IP Selected : " + ps4.IPAddress;
            lblFirmware.Text = "IP Firmware : " + ps4.Firmware;
        }

        private void IPSelect_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (ipTracker != PS4Consoles.DefaultPS4().IPAddress)
                main.InitPS4RPC();

            this.Close();

            Launching.main.Activate();
        }

        private void btnDefaultPS4_Click(object sender, EventArgs e)
        {
            try
            {
                PS4Consoles.SetDefault(lstPS4s.SelectedItem.ToString());
                alrtDefaultChanged.kind = (theme.FlatAlertBox._Kind.Success);
                alrtDefaultChanged.Text = "Default Changed!";
                alrtDefaultChanged.Visible = true;
            }
            catch
            {
                MessageBox.Show("Failed to set/change default PS4.");
                alrtDefaultChanged.kind = (theme.FlatAlertBox._Kind.Error);
                alrtDefaultChanged.Text = "Change Failed!";
                alrtDefaultChanged.Visible = true;
            }
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "1. Fill in blank text. " +
                "\n2. Click Add PS4. " +
                "\n3. Select your PS4 in the list to the left. " +
                "\n4. Click Make This Your Default PS4. " +
                "\n\n -------Tips------- " +
                "\nWhen typing in your Firmware and you use Mira, type 5.05 - Mira. " +
                "\nDouble check your IP and make sure you haven't typed any extra periods or spaces or anything.");
        }
    }
}
