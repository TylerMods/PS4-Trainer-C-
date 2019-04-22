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
    public partial class BTPS : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public BTPS()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[1] == "1.02")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}");
            }

            Util.attachToGame("ARBUTUS.elf", "Borderlands The Pre-Sequal", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x10555bb, new byte[] { 0xe9, 0x70, 0x08, 0x10, 0x01, 0x90, 0x90, 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x2155e30, new byte[] { 0x49, 0xC7, 0xC7, 0x4B, 0x18, 0x96, 0x7F, 0xF3, 0x49, 0x0F, 0x2A, 0xDF, 0xC4, 0xC1, 0x7A, 0x11, 0x9C, 0x24, 0xA0, 0x00, 0x00, 0x00, 0xE9, 0x7A, 0xF7, 0xEF, 0xFE });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x10555bb, new byte[] { 0xC4, 0xC1, 0x7A, 0x11, 0x9C, 0x24, 0xA0, 0x00, 0x00, 0x00 });
                    PS4.WriteMemory(processID, 0x2155e30, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }

            }


        }

        private void tglAmmo_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglAmmo.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x45bc5e, new byte[] { 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0xab5dd2, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90  });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x45bc5e, new byte[] { 0x41, 0x89, 0x0e });
                    PS4.WriteMemory(processID, 0xab5dd2, new byte[] { 0xc5, 0xfa, 0x11, 0x9b, 0xa0, 0x00, 0x00, 0x00 });
                }

            }


        }

        private void tglMoney_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglMoney.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x1056763, new byte[] { 0xE9, 0xF8, 0xF6, 0x0F, 0x01, 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x2155e60, new byte[] { 0x42, 0xC7, 0x84, 0xB3, 0x80, 0x04, 0x00, 0x00, 0x7F, 0x96, 0x98, 0x00, 0xE9, 0xFA, 0x08, 0xF0, 0xFE });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x1056763, new byte[] { 0x42, 0x89, 0x94, 0xb3, 0x80, 0x04, 0x00, 0x00 });
                    PS4.WriteMemory(processID, 0x2155e60, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }

            }

        }
    }
}
