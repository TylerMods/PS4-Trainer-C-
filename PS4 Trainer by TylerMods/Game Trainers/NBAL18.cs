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
    public partial class NBAL18 : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public NBAL18()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[1] == "1.11")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.11");
            }

            Util.attachToGame("eboot.bin", "NBA Live 18", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglREP_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglREP.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x52D5EC, new byte[] { 0xBB, 0x7F, 0x96, 0x98, 0x00, 0x90, 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x52D5F5, new byte[] { 0x41, 0x89, 0x9C, 0x24, 0xB0, 0x00, 0x00, 0x00 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x52D5EC, new byte[] { 0x48, 0x39, 0x01, 0x0F, 0x84, 0x99, 0x00, 0x00, 0x00 });
                    PS4.WriteMemory(processID, 0x52D5F5, new byte[] { 0x41, 0x01, 0x9C, 0x24, 0xB0, 0x00, 0x00, 0x00 });
                }

            }


        }

        private void tglHype_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHype.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x2C5884C, new byte[] { 0x41, 0x89, 0x04, 0xBE });
                    PS4.WriteMemory(processID, 0x2C5880E, new byte[] { 0xB8, 0x7F, 0x96, 0x98, 0x00 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x2C5884C, new byte[] { 0x49, 0x8, 0x04, 0xBE });
                    PS4.WriteMemory(processID, 0x2C5880E, new byte[] { 0x83, 0xF9, 0x03, 0x72, 0x3D });
                }

            }

        }

        private void tglSP_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglSP.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x596770, new byte[] { 0x01, 0xB7, 0x58, 0x0C, 0x00, 0x00 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x596770, new byte[] { 0x89, 0xB7, 0x58, 0x0C, 0x00, 0x00 });
                }

            }
        }

        private void btnEXP_Click(object sender, EventArgs e)
        {
            if (attached)
            {
                PS4.WriteMemory(processID, 0x248CE19AC, new byte[] { 0xBB, 0x7F, 0x96, 0x98, 0x00, 0x90 });
            }
        }
            private void btnLeftTeam200_Click(object sender, EventArgs e)
            {
                if (attached)
                {
                    PS4.WriteMemory(processID, 0x24D8BC628, new byte[] { 0xC8 });
                }
            }
        }
}
