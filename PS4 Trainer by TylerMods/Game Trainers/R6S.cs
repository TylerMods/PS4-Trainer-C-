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
    public partial class R6S : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public R6S()
        {
            InitializeComponent();
            pnlAmmo.Visible = false;
            pnlHealth.Visible = false;
            pnlThrowables.Visible = false;

        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[1] == "01.00" || Util.GameInfoArray()[1] == "01.46")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}");
            }

            Util.attachToGame("eboot.bin", "Rainbow Six Siege", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglAmmo_CheckedChanged(object sender)
        {
            if (!attached)
                return;
            if (tglAmmo.Checked)
            {

                switch (cmbVersion.Text)
                {
                    case "v1.00":
                        PS4.WriteMemory(processID, 0xac94cf, new byte[] { 0xE9, 0xBD, 0x34, 0x42, 0xFE, 0x90, 0x90, 0x90, 0x90, 0x90 });
                        PS4.WriteMemory(processID, 0x417e3e, new byte[] { 0xC7, 0x40, 0x24, 0xD6, 0x01, 0x00, 0x00, 0x0F, 0x85, 0x15, 0xCC, 0xBD, 0x01, 0xE9, 0x36, 0xCB, 0xBD, 0x01 });
                        break;
                    case "v1.46":
                        PS4.WriteMemory(processID, 0x1D37460, new byte[] { 0x90, 0x90, 0x90, 0x90 });
                        break;
                }

            }
            else
            {

                switch (cmbVersion.Text)
                {
                    case "v1.00":
                        PS4.WriteMemory(processID, 0xac94cf, new byte[] { 0x44, 0x89, 0x60, 0x24, 0x0F, 0x85, 0xDA, 0x00, 0x00, 0x00 });
                        PS4.WriteMemory(processID, 0x417e3e, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                        break;
                    case "v1.46":
                        //MessageBox.Show("Unable to turn this feature off.");
                        PS4.WriteMemory(processID, 0x1D37460, new byte[] { 0x44, 0x89, 0x70, 0x50 });
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
                    PS4.WriteMemory(processID, 0x28EB0C1, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                    //PS4.WriteMemory(processID, 0x28EB0C1, new byte[] { 0xE9, 0x35, 0xC9, 0x0E, 0x02, 0x00, 0x00 });
                    //PS4.WriteMemory(processID, 0x49D79FB, new byte[] { 0x41, 0x83, 0xBF, 0x10, 0x00, 0xFF, 0xFF, 0x00, 0x0F, 0x84, 0xBF, 0x36, 0xF1, 0xFD, 0x41, 0x89, 0xB7, 0x18, 0x01, 0x00, 0x00, 0xE9, 0xB3, 0x36, 0xF1, 0xFD });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x28EB0C1, new byte[] { 0x41, 0x89, 0xB7, 0x18, 0x01, 0x00, 0x00 });
                    //PS4.WriteMemory(processID, 0x49D79FB, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }

            }

        }

        private void cmbVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVersion.Text == "v1.00")
            {
                pnlAmmo.Visible = true;
                pnlHealth.Visible = false;
                pnlThrowables.Visible = false;
                lblCUSA.Text = "CUSA01800";
            }
            if (cmbVersion.Text == "v1.46")
            {
                pnlAmmo.Visible = true;
                pnlHealth.Visible = true;
                pnlThrowables.Visible = true;
                lblCUSA.Text = "CUSA01788";
            }
        }

        private void tglThrowables_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglThrowables.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x1CB79DA, new byte[] { 0x90, 0x90});
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x1CB79DA, new byte[] { 0x89, 0x30 });
                }

            }

        }

        private void tglBlanks_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglBlanks.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x1D3AECE, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x1D3AECE, new byte[] { 0xC4, 0xC1, 0x7A, 0x11, 0x85, 0x80, 0x02, 0x00, 0x00 });
                }

            }

        }

        private void tglSpread_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglBlanks.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x1D3AECE, new byte[] { 0xC4, 0x41, 0x7A, 0x11, 0x95, 0x80, 0x02, 0x00, 0x00 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x1D3AECE, new byte[] { 0xC4, 0xC1, 0x7A, 0x11, 0x85, 0x80, 0x02, 0x00, 0x00 });
                }

            }

        }

        private void tglLeftGun_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglLeftGun.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x1D3B6EC, new byte[] { 0xC4, 0xC1, 0x7A, 0x11, 0x95, 0xD0, 0x02, 0x00, 0x00 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x1D3B6EC, new byte[] { 0xC4, 0xC1, 0x7A, 0x11, 0xAD, 0xD0, 0x02, 0x00, 0x00 });
                }

            }

        }
    }
}
