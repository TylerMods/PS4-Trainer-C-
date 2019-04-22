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
    public partial class TF2 : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public TF2()
        {
            InitializeComponent();
            pnlAmmo.Visible = false;
            pnlHealth.Visible = false;
            pnlRecoil.Visible = false;
            pnlJump.Visible = false;
            tglThrust.Visible = false;
            tgl1hit.Visible = false;
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[1] == "01.07" || Util.GameInfoArray()[1] == "01.13")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}");
            }

            Util.attachToGame("eboot.bin", "Titan Fall 2", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void tglAmmo_CheckedChanged_1(object sender)
        {
            if (!attached)
                return;
            if (tglAmmo.Checked)
            {

                switch (cmbCUSA.Text)
                {
                    case "CUSA01540":
                        PS4.WriteMemory(processID, 0x8F7B2402, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                        break;
                    case "CUSA04027":
                        PS4.WriteMemory(processID, 0x8FBCFB42, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                        break;
                }

            }
            else
            {

                switch (cmbCUSA.Text)
                {
                    case "CUSA01540":
                        PS4.WriteMemory(processID, 0x8F7B2402, new byte[] { 0x41, 0x89, 0x9C, 0x24, 0xF0, 0x0E, 0x00, 0x00 });
                        break;
                    case "CUSA04027":
                        PS4.WriteMemory(processID, 0x8FBCFB42, new byte[] { 0x41, 0x89, 0x9C, 0x24, 0xF0, 0x0E, 0x00, 0x00 });
                        break;
                }

            }

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x83A20D, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x83A20D, new byte[] { 0xE8, 0xBE, 0xAF, 0xC0, 0xFF });
                }

            }

        }

        private void tglSpray_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglSpray.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x8FBABFF4, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x8FBABFF4, new byte[] { 0x41, 0x89, 0x9D, 0x08, 0x0F, 0x00, 0x00 });
                }

            }

        }

        private void cmbCUSA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCUSA.Text == "CUSA01540")
            {
                lblVersion.Text = "Game Version : 1.07";
                pnlHealth.Visible = false;
                pnlRecoil.Visible = true;
                pnlAmmo.Visible = true;
                pnlJump.Visible = false;
                tglThrust.Visible = false;
                tgl1hit.Visible = false;
            }
            if (cmbCUSA.Text == "CUSA04027")
            {
                lblVersion.Text = "Game Version : 1.13";
                pnlHealth.Visible = true;
                pnlRecoil.Visible = false;
                pnlAmmo.Visible = true;
                pnlJump.Visible = true;
                tglThrust.Visible = true;
                tgl1hit.Visible = true;
            }
        }

        private void tglJump_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglJump.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x4D14CA, new byte[] { 0x31, 0xDB });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x4D14CA, new byte[] { 0xFF, 0xC3 });
                }

            }

        }

        private void tglThrust_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglThrust.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x4D16AA, new byte[] { 0xF8, 0x28, 0xC8 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x4D16AA, new byte[] { 0xFA, 0x5C, 0xC9});
                }

            }


        }

        private void tgl1hit_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglThrust.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x44538D, new byte[] { 0xE9, 0x6E, 0xD1, 0x94, 0x00 });
                    PS4.WriteMemory(processID, 0xD92500, new byte[] { 0x80, 0x7B, 0x02, 0xC9, 0xC4, 0xC1, 0x7A, 0x2A, 0xCC, 0x77, 0x04, 0xC5, 0xF8, 0x28, 0xC1, 0xE9, 0x7E, 0x2E, 0x6B, 0xFF });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x44538D, new byte[] { 0xC4, 0xC1, 0x7A, 0x2A, 0xCC });
                    PS4.WriteMemory(processID, 0xD92500, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }

            }

        }
    }
}
