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
    public partial class BTHC : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public BTHC()
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

            Util.attachToGame("MAGNOLIA.elf", "Borderlands 2", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x1067a67, new byte[] { 0xe9, 0x94, 0x7f, 0xc7, 0x00, 0x90, 0x90, 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x1cdfa00, new byte[] { 0x49, 0xC7, 0xC7, 0x4B, 0x18, 0x96, 0x7F, 0xF3, 0x49, 0x0F, 0x2A, 0xDF, 0xC4, 0xC1, 0x7A, 0x11, 0x9C, 0x24, 0xA0, 0x00, 0x00, 0x00, 0xE9, 0x56, 0x80, 0x38, 0xFF });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x1067a67, new byte[] { 0xc4, 0xc1, 0x7a, 0x11, 0x9c, 0x24, 0xa0, 0x00, 0x00, 0x00 });
                    PS4.WriteMemory(processID, 0x1cdfa00, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }

            }

        }

        private void tglAmmo_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglAmmo.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x45b77e, new byte[] { 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0xac94cf, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x45b77e, new byte[] { 0x41, 0x89, 0x0e });
                    PS4.WriteMemory(processID, 0xb3e432, new byte[] { 0xc5, 0xfa, 0x11, 0x9b, 0xa0, 0x00, 0x00, 0x00 });
                }

            }

        }

        private void tglMoney_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglMoney.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x1068de2, new byte[] { 0xE9, 0x99, 0x6C, 0xC7, 0x00, 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x1cdfa80, new byte[] { 0x42, 0xC7, 0x84, 0xB3, 0x78, 0x04, 0x00, 0x00, 0x7F, 0x96, 0x98, 0x00, 0xE9, 0x59, 0x93, 0x38, 0xFF });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x1068de2, new byte[] { 0x42, 0x89, 0x84, 0xB3, 0x78, 0x04, 0x00, 0x00 });
                    PS4.WriteMemory(processID, 0x1cdfa80, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }

            }

        }

        private void tglTokens_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglTokens.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x45bbfe, new byte[] { 0xe9, 0x3d, 0x3e, 0x88, 0x01, 0x90 });
                    PS4.WriteMemory(processID, 0x1cdfa40, new byte[] { 0x41, 0xC7, 0x07, 0x42, 0xC6, 0x00, 0x00, 0x41, 0x89, 0x06, 0xE9, 0xB5, 0xC1, 0x77, 0xFE });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x45bbfe, new byte[] { 0x41, 0x89, 0x07, 0x41, 0x89, 0x06 });
                    PS4.WriteMemory(processID, 0x1cdfa40, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }

            }
        }
    }
}
