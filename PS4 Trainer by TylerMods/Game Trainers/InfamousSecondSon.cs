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
    public partial class InfamousSecondSon : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public InfamousSecondSon()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[0] == "CUSA00223" || Util.GameInfoArray()[1] == "1.04")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.04");
            }

            Util.attachToGame("eboot.bin", "Infamous Second Son", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void tglHealth_CheckedChanged_1(object sender)
        {
            if (attached)
            {
                if (cmbVersion.Text == "v1.04")
                {
                    if (tglHealth.Checked == true)
                    {
                        PS4.WriteMemory(processID, 0x5C5732, new byte[] { 0x90, 0x90, 0x90, 0x90 });
                    }
                    else
                    {
                        //MessageBox.Show("Currently unable to turn this feature off.");
                        PS4.WriteMemory(processID, 0x5C5732, new byte[] { 0xC5, 0xEA, 0x5C, 0xD1 });
                    }
                }
                if (cmbVersion.Text == "v1.00")
                {
                    if (tglHealth.Checked == true)
                    {
                        PS4.WriteMemory(processID, 0x5C3876, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                    }
                    else
                    {
                        //MessageBox.Show("Currently unable to turn this feature off.");
                        PS4.WriteMemory(processID, 0x5C3876, new byte[] { 0xc4, 0xc1, 0x7a, 0x11, 0x96, 0x50, 0xee, 0x01, 0x00 });
                    }

                }
            }

        }

        private void tglEnergy_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (cmbVersion.Text == "v1.04")
                {
                    if (tglEnergy.Checked == true)
                    {
                        PS4.WriteMemory(processID, 0x5C49A2, new byte[] { 0x90, 0x90, 0x90, 0x90 });
                    }
                    else
                    {
                        //MessageBox.Show("Currently unable to turn this feature off.");
                        PS4.WriteMemory(processID, 0x5C49A2, new byte[] { 0xC5, 0xF2, 0x5D, 0xC8 });
                    }
                }
                if (cmbVersion.Text == "v1.00")
                {
                    if (tglEnergy.Checked == true)
                    {
                        PS4.WriteMemory(processID, 0x5C2AEE, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                    }
                    else
                    {
                        //MessageBox.Show("Currently unable to turn this feature off.");
                        PS4.WriteMemory(processID, 0x5C2AEE, new byte[] { 0xc5, 0xfa, 0x11, 0x8f, 0xe8, 0xa1, 0x01, 0x00 });
                    }

                }
            }

        }

        private void tglSP_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (cmbVersion.Text == "v1.04")
                {
                    if (tglSP.Checked == true)
                    {
                        PS4.WriteMemory(processID, 0x598061, new byte[] { 0xBB, 0xE7, 0x03, 0x00, 0x00, 0x89, 0x9F, 0xE0, 0x00, 0x00, 0x00, 0x90, 0x90 });
                    }
                    else
                    {
                        //MessageBox.Show("Currently unable to turn this feature off.");
                        PS4.WriteMemory(processID, 0x598061, new byte[] { 0x89, 0x9F, 0xE0, 0x00, 0x00, 0x00, 0x80, 0xBF, 0xC9, 0x0A, 0x02, 0x00, 0x00 });
                    }
                }
                if (cmbVersion.Text == "v1.00")
                {
                    if (tglSP.Checked == true)
                    {
                        PS4.WriteMemory(processID, 0x596711, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                    }
                    else
                    {
                        //MessageBox.Show("Currently unable to turn this feature off.");
                        PS4.WriteMemory(processID, 0x596711, new byte[] { 0x89, 0x9f, 0xe0, 0x00, 0x00, 0x00 });

                    }
                }
            }
        }

        private void tglBombs_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (cmbVersion.Text == "v1.04")
                {
                    if (tglBombs.Checked == true)
                    {
                        PS4.WriteMemory(processID, 0x598F18, new byte[] { 0xBE, 0x05, 0x00, 0x00, 0x00, 0x89, 0xB7, 0xDC, 0x00, 0x00, 0x00, 0x90, 0x90 });
                    }
                    else
                    {
                        //MessageBox.Show("Currently unable to turn this feature off.");
                        PS4.WriteMemory(processID, 0x598F18, new byte[] { 0x89, 0xB7, 0xDC, 0x00, 0x00, 0x00, 0x80, 0xBF, 0xC9, 0x0A, 0x02, 0x00, 0x00 });
                    }
                }
                if (cmbVersion.Text == "v1.00")
                {
                    if (tglBombs.Checked == true)
                    {
                        PS4.WriteMemory(processID, 0x5975c8, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                    }
                    else
                    {
                        //MessageBox.Show("Currently unable to turn this feature off.");
                        PS4.WriteMemory(processID, 0x5975c8, new byte[] { 0x89, 0xb7, 0xdc, 0x00, 0x00, 0x00 });
                    }

                }
            }

        }


        private void btnHero_Click(object sender, EventArgs e)
        {
            if (attached)
            {
                PS4.WriteMemory(processID, 0x129BD08, new byte[] { 0xA0, 0xE6, 0x87, 0x45 });
            }

        }

        private void btnInfamous_Click(object sender, EventArgs e)
        {
            if (attached)
            {
                PS4.WriteMemory(processID, 0x129BD08, new byte[] { 0x00, 0xCA, 0xE6, 0xFD });
            }
        }

        private void InfamousSecondSon_Load(object sender, EventArgs e)
        {
            pnlBombs.Visible = false;
            pnlHealth.Visible = false;
            pnlHero.Visible = false;
            pnlInfamous.Visible = false;
            pnlSmoke.Visible = false;
            pnlSP.Visible = false;
        }

        private void cmbVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVersion.Text != "")
            {
                pnlBombs.Visible = true;
                pnlHealth.Visible = true;
                pnlHero.Visible = true;
                pnlInfamous.Visible = true;
                pnlSmoke.Visible = true;
                pnlSP.Visible = true;
            }
        }
    }
}
