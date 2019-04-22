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
using MetroFramework;

namespace PS4_Trainer_by_TylerMods
{
    public partial class TheLastofUs : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public TheLastofUs()
        {
            InitializeComponent();
            cmbCUSA.SelectedIndex = 0;
        }

        private void btnDebugMenu_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteMemory(processID, 0x403A28, new byte[] { 0x80, 0xB9, 0x87, 0x2E, 0x00, 0x00, 0x00, 0x0F, 0x85, 0x1F, 0x0D, 0x00, 0x00, 0xC6, 0x81, 0x81, 0x2E, 0x00, 0x00, 0x01, 0xEB, 0x04, 0x12, 0x0D, 0x00, 0x00, 0x89, 0xC0 });
            MetroMessageBox.Show(this, "L3 + Left Pad Opens 1 menu then L3 + Right Pad opens another. L3 + R3 = noclip.", "Controls", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void TheLastofUs_Load(object sender, EventArgs e)
        {
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            Util.attachToGame("eboot.bin", "The Last of Us", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteMemory(processID, processEntry + 0x49E540B3, new byte[] { 0x80, 0xB9, 0x87, 0x2E, 0x00, 0x00, 0x00, 0x0F, 0x85, 0x03, 0x12, 0x00, 0x00, 0xC6, 0x81, 0x81, 0x2E, 0x00, 0x00, 0x01, 0xEB, 0x04, 0xF6, 0x11, 0x00, 0x00, 0x48, 0x8D });
            MetroMessageBox.Show(this, "L3 + Left Pad Opens 1 menu then L3 + Right Pad opens another. L3 + R3 = noclip.", "Controls", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void cmbCUSA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCUSA.Text == "CUSA00552")
            {
                pnlAmmo.Visible = false;
                pnlHealth.Visible = false;
            }
            if (cmbCUSA.Text == "CUSA00557")
            {
                pnlAmmo.Visible = true;
                pnlHealth.Visible = true;
            }
        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xac94cf, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0xac94cf, new byte[] { 0xc5, 0xfa, 0x11, 0x43, 0x08 });
                }

            }

        }

        private void tglAmmo_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglAmmo.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xA82AE2, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0xA82AE2, new byte[] { 0x66, 0xff, 0x8b, 0x5c, 0x07, 0x00, 0x00 });
                }

            }

        }

        private void btn108_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteMemory(processID, 0x403C75, new byte[] { 0xC6, 0x81, 0x81, 0x2E, 0x00, 0x00, 0x01, 0xEB, 0x04 });
            MetroMessageBox.Show(this, "L3 + Left Pad Opens 1 menu then L3 + Right Pad opens another. L3 + R3 = noclip.", "Controls", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
