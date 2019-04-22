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
    public partial class DMC4 : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public DMC4()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[1] == "1.00")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}");
            }

            Util.attachToGame("eboot.bin", "Devil May Cry 4 Special Edition", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x695CE3, new byte[] { 0xC5, 0xFA, 0x10, 0x43, 0x40, 0xC5, 0xFA, 0x5C, 0xD9 });
                    PS4.WriteMemory(processID, 0x12E7232, new byte[] { 0xC5, 0xFA, 0x10, 0x43, 0x40, 0xC5, 0xFA, 0x5C, 0xD9, 0x83, 0xBB, 0x9C, 0x00, 0x00, 0x00, 0x03, 0x0F, 0x85, 0xA4, 0xEA, 0x3A, 0xFF, 0xE9, 0xA4, 0xEA, 0x3A, 0xFF });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x695CE3, new byte[] { 0xE9, 0x4A, 0x15, 0xC5, 0x00 });
                    PS4.WriteMemory(processID, 0x12E7232, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00});
                }

            }

        }

        private void tglDevil_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglDevil.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x9E050A, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x9E050A, new byte[] { 0x89, 0x83, 0x10, 0x0D, 0x01, 0x00 });
                }

            }

        }

        private void tglRed_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglRed.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x603BE4, new byte[] { 0xB8, 0x00, 0x0F, 0x24, 0x3F, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x603BE4, new byte[] { 0x8B, 0x83, 0x84, 0x01, 0x00, 0x00 });
                }

            }

        }

        private void tglBlue_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglBlue.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x62004C, new byte[] { 0xB8, 0x00, 0x0F, 0x24, 0x3F });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x62004C, new byte[] { 0x3D, 0x3F, 0x42, 0x0F, 0x00 });
                }

            }

        }
    }
}
