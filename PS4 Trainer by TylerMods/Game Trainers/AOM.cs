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
    public partial class AOM : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public AOM()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[1] == "1.05")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}");
            }

            Util.attachToGame("eboot.bin", "Agents of Mayhem", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglAmmo_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglAmmo.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x415d15, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x415d15, new byte[] { 0x89, 0xbb, 0xc8, 0x00, 0x00, 0x00 });
                }

            }

        }

        private void tglSpread_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglSpread.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x97181a, new byte[] { 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x97181a, new byte[] { 0x89, 0x07 });
                }

            }

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xe20449, new byte[] { 0xe9, 0x82, 0xf8, 0x0b, 0x01, 0x90 });
                    PS4.WriteMemory(processID, 0x1edfcd0, new byte[] { 0x41, 0x83, 0xBC, 0x24, 0x81, 0x00, 0x00, 0x00, 0x00, 0x74, 0x0D, 0xC4, 0xC1, 0x7A, 0x11, 0x04, 0x24, 0xE9, 0x69, 0x07, 0xF4, 0xFE, 0x00, 0x00, 0x49, 0xC7, 0xC7, 0xFF, 0x0B, 0x00, 0x00, 0xF3, 0x4D, 0x0F, 0x2A, 0xCF, 0xC4, 0x41, 0x7A, 0x11, 0x0C, 0x24, 0xE9, 0x4F, 0x07, 0xF4, 0xFE });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0xe20449, new byte[] { 0xc4, 0xc1, 0x7a, 0x11, 0x04, 0x24 });
                    PS4.WriteMemory(processID, 0x1edfcd0, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }

            }

        }
    }
}
