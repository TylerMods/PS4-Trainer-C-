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
    public partial class BSI : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public BSI()
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

            Util.attachToGame("eboot.bin", "Bioshock Infinite : The Collection", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xC5BD25, new byte[] { 0xE9, 0x96, 0x61, 0x10, 0x01, 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x1D61EC0, new byte[] { 0x81, 0x7B, 0x7D, 0x43, 0x03, 0x98, 0x76, 0x0F, 0x85, 0x05, 0x00, 0x00, 0x00, 0xE9, 0x5B, 0x9E, 0xEF, 0xFE, 0xC5, 0xFA, 0x11, 0x83, 0xC0, 0x35, 0x00, 0x00, 0xE9, 0x4E, 0x9E, 0xEF, 0xFE });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0xC5BD25, new byte[] { 0xC5, 0xFA, 0x11, 0x83, 0xC0, 0x35, 0x00, 0x00 });
                    PS4.WriteMemory(processID, 0x1D61EC0, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }

            }

        }

        private void tglSalt_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglSalt.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x118F388, new byte[] { 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x118F388, new byte[] { 0x29, 0xD8 });
                }

            }

        }

        private void tglAmmo_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglAmmo.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xCB3998, new byte[] { 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0xCB3998, new byte[] { 0x03, 0x55, 0xA4 });
                }

            }

        }

        private void tglMoney_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglMoney.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x118F1CF, new byte[] { 0x49, 0x89, 0x7C, 0x24, 0x64 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x118F1CF, new byte[] { 0x45, 0x29, 0x74, 0x24, 0x64 });
                }

            }

        }
    }
}
