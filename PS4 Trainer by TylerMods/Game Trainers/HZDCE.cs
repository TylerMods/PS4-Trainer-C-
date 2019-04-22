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
using System.Threading;

namespace PS4_Trainer_by_TylerMods.Game_Trainers
{
    public partial class HZDCE : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public HZDCE()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[1] == "01.52")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.52");
            }

            Util.attachToGame("eboot.bin", "Horizon Zero Dawn Complete Edition", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
            //if (Util.GameInfoArray()[0] != "CUSA10212" || Util.GameInfoArray()[0] != "CUSA10211" || Util.GameInfoArray()[0] != "CUSA10237")
            //{
            //    pnlHit.Visible = false;
            //}
        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (tglHealth.Checked == true)
            {
                tglNormalHealth.Checked = false;
                tglHit.Checked = false;
            }
            if (attached)
            {
                MessageBox.Show("If Infinite Health stops working, just restart to a checkpoint.");
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xE38B42, new byte[] { 0xC5, 0xFA, 0x11, 0x43, 0x64 });
                    PS4.WriteMemory(processID, 0x1f0fb60, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                    Thread.Sleep(10);
                    PS4.WriteMemory(processID, 0xE38B42, new byte[] { 0xE9, 0x19, 0x70, 0x0D, 0x01 });
                    PS4.WriteMemory(processID, 0x1f0fb60, new byte[] { 0x83, 0xBB, 0xF0, 0x01, 0x00, 0x00, 0x03, 0x0F, 0x84, 0xDA, 0x8F, 0xF2, 0xFE, 0xC5, 0xFA, 0x11, 0x43, 0x64, 0xE9, 0xD0, 0x8F, 0xF2, 0xFE });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0xE38B42, new byte[] { 0xC5, 0xFA, 0x11, 0x43, 0x64 });
                    PS4.WriteMemory(processID, 0x1f0fb60, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }
            }
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@5788400_3_30B8400+50+0+18+38+100+28+0+44", processID);
                byte[] money = BitConverter.GetBytes((int)numSP.Value);
                if (adr > 0)
                {
                    PS4.WriteMemory(processID, adr, money);
                }
                else { }
            }
        }

        private void tglArrows_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglArrows.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x132F020, new byte[] { 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x132F020, new byte[] { 0x44, 0x29, 0xF0 });
                }
            }

        }

        private void tglSkillPoints_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglSkillPoints.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x19D7324, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x19D7324, new byte[] { 0x41, 0x29, 0x44, 0x24, 0x64 });
                }
            }

        }

        private void flatToggle1_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (flatToggle1.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x132f020, new byte[] { 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x132f020, new byte[] { 0x44, 0x29, 0xF0 });
                }
            }

        }

        private void tglTime_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglTime.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x15bb878, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x76, 0x14, 0x48 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x15bb878, new byte[] { 0xC5, 0xFA, 0x11, 0x51, 0x1C, 0x76, 0x14, 0x48 });
                }
            }

        }

        private void tglDuplicateSkillPoints_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglDuplicateSkillPoints.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x19D7324, new byte[] { 0x41, 0x01, 0x44, 0x24, 0x64 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x19D7324, new byte[] { 0x41, 0x29, 0x44, 0x24, 0x64 });
                }
            }

        }

        private void btnCheaters_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this,
    "TylerMods" +
    "\nCain532" +
    "\nTalixme" +
    "\nSean",
    "Cheaters", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void tglHit_CheckedChanged(object sender)
        {
            if (tglHit.Checked == true)
            {
                tglHealth.Checked = false;
                tglNormalHealth.Checked = false;
            }
            if (attached)
            {
                if (Util.GameInfoArray()[0] == "CUSA10212")
                {
                    if (tglHit.Checked == true)
                    {
                        PS4.WriteMemory(processID, 0xE38B47, new byte[] { 0xE9, 0x2D, 0x32, 0x0F, 0x01, 0x90, 0x90 });
                        PS4.WriteMemory(processID, 0x1f29200, new byte[] { 0x48, 0x8B, 0xB0, 0xD8, 0x00, 0x00, 0x00, 0x83, 0x7B, 0x50, 0x02, 0x90, 0x90, 0x90, 0x0F, 0x85, 0x05, 0x00, 0x00, 0x00, 0xE9, 0xB9, 0xCD, 0xF0, 0xFE, 0xC7, 0x43, 0x64, 0x00, 0x00, 0x00, 0x00, 0xE9, 0xAD, 0xCD, 0xF0, 0xFE });
                    }
                    else
                    {
                        //MessageBox.Show("Currently unable to turn this feature off.");
                        PS4.WriteMemory(processID, 0xE38B47, new byte[] { 0x48, 0x8B, 0xB0, 0xD8, 0x00, 0x00, 0x00 });
                        PS4.WriteMemory(processID, 0x1F2BD7C, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                    }
                }
                if (Util.GameInfoArray()[0] == "CUSA10211" || Util.GameInfoArray()[0] == "CUSA10237")
                {
                    if (tglHit.Checked == true)
                    {
                        PS4.WriteMemory(processID, 0xE38B42, new byte[] { 0xC5, 0xFA, 0x11, 0x43, 0x64 });
                        PS4.WriteMemory(processID, 0x1f0fb60, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                        Thread.Sleep(10);
                        PS4.WriteMemory(processID, 0xe38b42, new byte[] { 0xE9, 0xC9, 0xAC, 0x4E, 0x01 });
                        PS4.WriteMemory(processID, 0x2323810, new byte[] { 0x83, 0xBB, 0xF0, 0x01, 0x00, 0x00, 0x03, 0x74, 0x0C, 0xC7, 0x43, 0x64, 0x00, 0x00, 0x00, 0x00, 0xE9, 0x22, 0x53, 0xB1, 0xFE, 0xC5, 0xFA, 0x11, 0x43, 0x64, 0xE9, 0x18, 0x53, 0xB1, 0xFE });
                    }
                    else
                    {
                        //MessageBox.Show("Currently unable to turn this feature off.");
                        PS4.WriteMemory(processID, 0xe38b42, new byte[] { 0xC5, 0xFA, 0x11, 0x43, 0x64 });
                        PS4.WriteMemory(processID, 0x2323810, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                    }
                }

            }

        }

        private void tglNormalHealth_CheckedChanged(object sender)
        {
            if (tglNormalHealth.Checked == true)
            {
                tglHealth.Checked = false;
                tglHit.Checked = false;
            }
            if (attached)
            {
                MessageBox.Show("If Infinite Health stops working, just restart to a checkpoint.");
                if (tglNormalHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xE38B42, new byte[] { 0xC5, 0xFA, 0x11, 0x43, 0x64 });
                    PS4.WriteMemory(processID, 0x1f0fb60, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                    Thread.Sleep(10);
                    PS4.WriteMemory(processID, 0xE38B42, new byte[] { 0xE9, 0x29, 0xef, 0x0e, 0x01 });
                    PS4.WriteMemory(processID, 0x1f27a70, new byte[] { 0x83, 0xBB, 0xF0, 0x01, 0x00, 0x00, 0x03, 0x0F, 0x84, 0xCA, 0x10, 0xF1, 0xFE, 0xC7, 0x43, 0x64, 0x00, 0x00, 0x00, 0x00, 0xE9, 0xBE, 0x10, 0xF1, 0xFE });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0xE38B42, new byte[] { 0xC5, 0xFA, 0x11, 0x43, 0x64 });
                    PS4.WriteMemory(processID, 0x1f27a70, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }

            }
        }
    }
}
