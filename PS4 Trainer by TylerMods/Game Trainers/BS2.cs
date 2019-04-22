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
    public partial class BS2 : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public BS2()
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

            Util.attachToGame("LaunchOrbis.elf", "Bioshock 2 : The Collection", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x824D61, new byte[] { 0xE9, 0x2A, 0x58, 0x14, 0x01, 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x196A590, new byte[] { 0x81, 0x3B, 0xF8, 0x76, 0xCE, 0x01, 0x0F, 0x85, 0x05, 0x00, 0x00, 0x00, 0xE9, 0xC8, 0xA7, 0xEB, 0xFE, 0xC5, 0xFA, 0x11, 0x8B, 0x30, 0x07, 0x00, 0x00, 0xE9, 0xBB, 0xA7, 0xEB, 0xFE });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x824D61, new byte[] { 0xC5, 0xFA, 0x11, 0x8B, 0x30, 0x07, 0x00, 0x00 });
                    PS4.WriteMemory(processID, 0x196A590, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }

            }

        }

        private void tglEve_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglEve.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x83E4B3, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x83E4B3, new byte[] { 0xC5, 0xFA, 0x11, 0x8B, 0x90, 0x0F, 0x00, 0x00 });
                }

            }

        }

        private void tglAmmo_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglAmmo.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xB543A6, new byte[] { 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0xB543A6, new byte[] { 0x41, 0x89, 0x07 });
                }

            }

        }

        private void tglMoney_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglMoney.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x83E97A, new byte[] { 0x01 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x83E97A, new byte[] { 0x89 });
                }

            }

        }

        private void tglAdam_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglAdam.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x83ED32, new byte[] { 0x41, 0x01 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x83ED32, new byte[] { 0x41, 0x89 });
                }

            }

        }
    }
}
