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
    public partial class TQ : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public TQ()
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
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}");
            }

            Util.attachToGame("eboot.bin", "Titan Quest", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x875e33, new byte[] { 0xe9, 0x28, 0x88, 0x4e, 0x00 });
                    PS4.WriteMemory(processID, 0xd5e660, new byte[] { 0x83, 0xBF, 0x5A, 0x01, 0x00, 0x00, 0x00, 0x0F, 0x84, 0xCB, 0x77, 0xB1, 0xFF, 0xC5, 0xFA, 0x11, 0x4F, 0x20, 0xE9, 0xC1, 0x77, 0xB1, 0xFF });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x875e33, new byte[] { 0xc5, 0xfa, 0x11, 0x43, 0x08 });
                    PS4.WriteMemory(processID, 0xd5e660, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }

            }


        }

        private void tglMagic_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglMagic.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x876458, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x876458, new byte[] { 0xc5, 0xfa, 0x11, 0x43, 0x34 });
                }

            }

        }

        private void tglInfMoney_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglInfMoney.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x86747d, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x86747d, new byte[] { 0x89, 0x87, 0xb4, 0x0f, 0x00, 0x00 });
                }

            }

        }

        private void tglx2Money_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglx2Money.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x86747d, new byte[] { 0x01, 0x87, 0xb4, 0x0f, 0x00, 0x00 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x86747d, new byte[] { 0x89, 0x87, 0xb4, 0x0f, 0x00, 0x00 });
                }

            }

        }

        private void tglSP_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglSP.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x92d9d9, new byte[] { 0x01, 0x47, 0x48 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x92d9d9, new byte[] { 0x89, 0x47, 0x48 });
                }

            }

        }
    }
}
