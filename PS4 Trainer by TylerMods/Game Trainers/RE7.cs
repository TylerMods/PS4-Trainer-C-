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
    public partial class RE7 : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public RE7()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[0] == "CUSA03842" || Util.GameInfoArray()[1] == "1.00" || Util.GameInfoArray()[1] == "v1.06")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00 or v01.06");
            }

            Util.attachToGame("eboot.bin", "Resident Evil 7", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void tglHealth_CheckedChanged(object sender)
        {

            if (attached)
            {
                    if (cmbVersion.Text == "v1.00")
                    {
                        if (tglHealth.Checked)
                        {
                            PS4.WriteMemory(processID, 0x30dcf8e, new byte[] { 0xC5, 0xF2, 0x58, 0xD0 });
                        }
                        else
                        {
                            PS4.WriteMemory(processID, 0x30dcf8e, new byte[] { 0xC5, 0xF2, 0x5C, 0xD0 });
                        }
                    }
                }
                if (cmbVersion.Text == "Gold Edition v1.00")
                {
                    if (tglHealth.Checked)
                    {
                        PS4.WriteMemory(processID, 0x4B81CC2, new byte[] { 0xE9, 0x09, 0xAA, 0xD8, 0x03 });
                        PS4.WriteMemory(processID, 0x890C6D0, new byte[] { 0x81, 0x78, 0x20, 0x00, 0x00, 0x7A, 0x44, 0x0F, 0x85, 0x05, 0x00, 0x00, 0x00, 0xE9, 0xE5, 0x55, 0x27, 0xFC, 0xC5, 0xFA, 0x11, 0x50, 0x24, 0xE9, 0xDB, 0x55, 0x27, 0xFC });
                    }
                    else
                    {
                        PS4.WriteMemory(processID, 0x4B81CC2, new byte[] { 0xC5, 0xFA, 0x11, 0x50, 0x24 });
                        PS4.WriteMemory(processID, 0x890C6D0, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                    }
                }
            if (cmbVersion.Text == "v1.06")
            {
                if (tglHealth.Checked)
                {
                    PS4.WriteMemory(processID, 0x5075A9D, new byte[] { 0xE9, 0x04, 0x0D, 0x9A, 0x03 });
                    PS4.WriteMemory(processID, 0x890C6D0, new byte[] { 0x9C, 0x0F, 0x02, 0xFB, 0x00, 0x00, 0x83, 0x78, 0x64, 0xFF, 0xC5, 0xFA, 0x11, 0x50, 0x24, 0xC7, 0x40, 0x24, 0x00, 0x40, 0xA6, 0x45, 0xE9, 0xE7, 0xF2, 0x65, 0xFC });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x5075A9D, new byte[] { 0xC5, 0xFA, 0x11, 0x50, 0x24 });
                    PS4.WriteMemory(processID, 0x890C6D0, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }
            }
        }

        private void tmrHealth_Tick(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@12F480D0_3_6C0D0+D0+B0+E0+70+24", processID);
                if (adr > 0)
                {
                    PS4.WriteSingle(processID, adr, 500);
                }
                else {  }
            }

        }

        private void tglItems_CheckedChanged(object sender)
        {

                if (attached)
                {
                if (cmbVersion.Text == "v1.00")
                {
                    if (tglItems.Checked)
                    {
                        PS4.WriteMemory(processID, 0x34e0a3a, new byte[] { 0xe9, 0xa1, 0xba, 0xa5, 0x03 });
                        PS4.WriteMemory(processID, 0x34e0a3f, new byte[] { 0x90 });
                        PS4.WriteMemory(processID, 0x6f3c4e0, new byte[] { 0xb8, 0x15, 0x02, 0x00, 0x00 });
                        PS4.WriteMemory(processID, 0x6f3c4e5, new byte[] { 0x3d, 0x15, 0x02, 0x00, 0x00 });
                        PS4.WriteMemory(processID, 0x6f3c4ea, new byte[] { 0x44, 0x29, 0xe0 });
                        PS4.WriteMemory(processID, 0x6f3c4ed, new byte[] { 0xe9, 0x4e, 0x45, 0x5a, 0xfc });
                    }
                    else
                    {
                        PS4.WriteMemory(processID, 0x34e0a3a, new byte[] { 0x44, 0x29, 0xe0 });
                        PS4.WriteMemory(processID, 0x34e0a3d, new byte[] { 0x0f, 0x29, 0xe0 });
                    }
                }
                    if (cmbVersion.Text == "Gold Edition v1.00")
                    {
                        if (tglAmmo106.Checked)
                        {
                            PS4.WriteMemory(processID, 0x59461E8, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                        }
                        else
                        {
                            //MessageBox.Show("Currently unable to turn this feature off.");;
                            PS4.WriteMemory(processID, 0x59461E8, new byte[] { 0x89, 0x86, 0x88, 0x00, 0x00, 0x00 });
                        }
                    }
                }
            }

        private void cmbVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVersion.Text == "v1.00")
            {
                lblCUSA.Text = "CUSA03842";
                pnlAmmo106.Visible = false;
                pnlItems106.Visible = false;
                pnlHealth100.Visible = true;
                pnlItems100.Visible = true;
                pnl2xItems.Visible = false;
            }
            if (cmbVersion.Text == "v1.06")
            {
                lblCUSA.Text = "CUSA03842";
                pnlAmmo106.Visible = true;
                pnlItems106.Visible = true;
                pnlHealth100.Visible = false;
                pnlItems100.Visible = false;
                pnl2xItems.Visible = false;
            }
            if (cmbVersion.Text == "Gold Edition v1.00")
            {
                lblCUSA.Text = "CUSA09473";
                pnlAmmo106.Visible = true;
                pnlItems106.Visible = false;
                pnlHealth100.Visible = true;
                pnlItems100.Visible = true;
                pnl2xItems.Visible = true;
                
            }

        }

        private void RE7_Load(object sender, EventArgs e)
        {
            if (cmbVersion.Text == "")
            {
                pnlAmmo106.Visible = false;
                pnlItems106.Visible = false;
                pnlHealth100.Visible = false;
                pnlItems100.Visible = false;
                pnl2xItems.Visible = false;
            }

        }

        private void tglAmmo106_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (cmbVersion.Text == "v1.00")
                {
                    if (tglAmmo106.Checked)
                    {
                        PS4.WriteMemory(processID, 0x1347059, new byte[] { 0x90, 0x90, 0x90, 0x90 });
                    }
                    else
                    {
                        //MessageBox.Show("Currently unable to turn this feature off.");;
                        PS4.WriteMemory(processID, 0x1347059, new byte[] { 0x45, 0x89, 0x7d, 0x24 });
                    }

                }
                if (cmbVersion.Text == "v1.06")
                {
                    if (tglAmmo106.Checked)
                    {
                        PS4.WriteMemory(processID, 0x1347046, new byte[] { 0xE9, 0x35, 0xF7, 0x6C, 0x07, 0x90 });
                        PS4.WriteMemory(processID, 0x8A16780, new byte[] { 0x41, 0xBF, 0x14, 0x02, 0x00, 0x00, 0xB8, 0x14, 0x02, 0x00, 0x00, 0xE9, 0xBC, 0x08, 0x93, 0xF8 });
                    }
                    else
                    {
                        //MessageBox.Show("Currently unable to turn this feature off.");
                        PS4.WriteMemory(processID, 0x1347046, new byte[] { 0x41, 0xff, 0xcf, 0x44, 0x39, 0xf8 });
                        //PS4.WriteMemory(processID, 0x34e0a3d, new byte[] { 0x0f, 0x29, 0xe0 });
                    }
                }
                if (cmbVersion.Text == "Gold Edition v1.00")
                {
                    if (tglAmmo106.Checked)
                    {
                        PS4.WriteMemory(processID, 0x5946139, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                    }
                    else
                    {
                        PS4.WriteMemory(processID, 0x5946139, new byte[] { 0x89, 0x86, 0x88, 0x00, 0x00, 0x00 });
                    }
                }
            }

        }

        private void tglItems106_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglItems106.Checked)
                {
                    PS4.WriteMemory(processID, 0x3A3773A, new byte[] { 0xE9, 0x57, 0xF0, 0xFD, 0x04, 0x90 });
                    PS4.WriteMemory(processID, 0x8A16796, new byte[] { 0xB8, 0x15, 0x02, 0x00, 0x00, 0x3D, 0x15, 0x02, 0x00, 0x00, 0x44, 0x29, 0xE0, 0xE9, 0x98, 0x0F, 0x02, 0xFB });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x3A3773A, new byte[] { 0x44, 0x29, 0xe0, 0x0f, 0x4c, 0xc1 });
                    //PS4.WriteMemory(processID, 0x34e0a3d, new byte[] { 0x0f, 0x29, 0xe0 });
                }
            }

        }

        private void tgl2xItems_CheckedChanged(object sender)
        {
            if (attached)
                if (tgl2xItems.Checked)
                {
                    PS4.WriteMemory(processID, 0x59461E8, new byte[] { 0x01, 0x86, 0x88, 0x00, 0x00, 0x00 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");;
                    PS4.WriteMemory(processID, 0x59461E8, new byte[] { 0x89, 0x86, 0x88, 0x00, 0x00, 0x00 });
                }

        }
    }
}
