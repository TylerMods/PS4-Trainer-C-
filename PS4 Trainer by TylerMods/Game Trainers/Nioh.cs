using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using librpc;

namespace PS4_Trainer_by_TylerMods.Game_Trainers
{
    public partial class Nioh : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public Nioh()
        {
            InitializeComponent();
            pnlHealth.Visible = false;
            pnlStamina.Visible = false;
            pnlRock.Visible = false;
            pnlGold.Visible = false;
            pnlAmrita.Visible = true;
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[1] == "01.10" || Util.GameInfoArray()[1] == "01.21")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}");
            }

            Util.attachToGame("eboot.bin", "Nioh", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (!attached)
                return;
            if (tglHealth.Checked)
            {

                switch (cmbVersion.Text)
                {
                    case "v1.10":
                        PS4.WriteMemory(processID, 0x58FFD6, new byte[] { 0xE9, 0xB8, 0x1F, 0xC6, 0x90, 0x90 });
                        PS4.WriteMemory(processID, 0x11f1f93, new byte[] { 0x41, 0x83, 0xBD, 0xC8, 0x01, 0x00, 0x00, 0x00, 0x0F, 0x84, 0x3C, 0xE0, 0x39, 0xFF, 0x49, 0x89, 0x4D, 0x10, 0x48, 0x39, 0xC8, 0xE9, 0x30, 0xE0, 0x39, 0xFF });
                        break;
                    case "v1.21":
                        PS4.WriteMemory(processID, 0xAB3A09, new byte[] { 0xE9, 0xF2, 0x3D, 0xD4, 0x00, 0x90 });
                        PS4.WriteMemory(processID, 0x13F7800, new byte[] { 0x49, 0x8B, 0x46, 0x18, 0x89, 0xC1, 0x49, 0x89, 0x46, 0x20, 0xE9, 0x00, 0xC2, 0x2B, 0xFF });
                        break;
                }

            }
            else
            {

                switch (cmbVersion.Text)
                {
                    case "v1.10":
                        PS4.WriteMemory(processID, 0x58FFD6, new byte[] { 0x49, 0x89, 0x4D, 0x10, 0x48, 0x39, 0xC8 });
                        PS4.WriteMemory(processID, 0x11f1f93, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                        break;
                    case "v1.21":
                        PS4.WriteMemory(processID, 0xAB3A09, new byte[] { 0x49, 0x8B, 0x46, 0x20, 0x89, 0xC1 });
                        PS4.WriteMemory(processID, 0x13F7800, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                        break;
                }

            }
        }

        private void tglStamina_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglStamina.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x59197b, new byte[] { 0xC5, 0xFA, 0x11, 0x07 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x59197b, new byte[] { 0xc5, 0xfa, 0x11, 0x2f });
                }

            }

        }

        private void tglMedicine_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglMedicine.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x6BA22D, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x6BA22D, new byte[] { 0x66, 0x42, 0x89, 0x84, 0x2B, 0x18, 0x02, 0x00, 0x00 });
                }

            }

        }

        private void cmbVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVersion.Text == "v1.10")
            {
                pnlHealth.Visible = false;
                pnlStamina.Visible = true;
                pnlRock.Visible = true;
                pnlGold.Visible = false;
                pnlAmrita.Visible = false;
            }
            if (cmbVersion.Text == "v1.21")
            {
                pnlHealth.Visible = true;
                pnlStamina.Visible = false;
                pnlRock.Visible = false;
                pnlGold.Visible = true;
                pnlAmrita.Visible = true;
            }
        }

        private void tglGold_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglGold.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x8E8F7E, new byte[] { 0xE9, 0xEE, 0xE8, 0xF0, 0x00, 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x17F7871, new byte[] { 0xC7, 0x40, 0x10, 0xFF, 0xE0, 0xF5, 0x05, 0x4C, 0x8B, 0x78, 0x10, 0x4C, 0x8B, 0x63, 0x78, 0xE9, 0x01, 0x17, 0x0F, 0xFF });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x8E8F7E, new byte[] { 0x4C, 0x8B, 0x78, 0x10, 0x4C, 0x8B, 0x63, 0x78 });
                    PS4.WriteMemory(processID, 0x17F7871, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }

            }
        }

        private void tglAmrita_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglGold.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x8E8D7E, new byte[] { 0xE9, 0xDA, 0xEA, 0xF0, 0x00, 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x17F785D, new byte[] { 0xC7, 0x40, 0x08, 0xFF, 0xE0, 0xF5, 0x05, 0x4C, 0x8B, 0x78, 0x08, 0x4C, 0x8B, 0x63, 0x70, 0xE9, 0x15, 0x15, 0x0F, 0xFF });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x8E8D7E, new byte[] { 0x4C, 0x8B, 0x78, 0x08, 0x4C, 0x8B, 0x63, 0x70 });
                    PS4.WriteMemory(processID, 0x17F785D, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }

            }
        }
    }
}
