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
    public partial class Minecraft : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public Minecraft()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[1] == "01.00")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00");
            }

            Util.attachToGame("eboot.bin", "Minecraft", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x7F55FB, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x7F55FB, new byte[] { 0x44, 0x29, 0xBB, 0x5C, 0x02, 0x00, 0x00 });
                }

            }

        }

        private void tglHunger_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHunger.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x74CDA0, new byte[] { 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x74CDA0, new byte[] { 0x89, 0x03 });
                }

            }

        }

        private void tglThrow_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglThrow.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x77688D, new byte[] { 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x77688D, new byte[] { 0x89, 0x43, 0x18 });
                }

            }

        }

        private void tglBuild_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglBuild.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x86011B, new byte[] { 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x86011B, new byte[] { 0xFF, 0x48, 0x18 });
                }

            }

        }
    }
}
