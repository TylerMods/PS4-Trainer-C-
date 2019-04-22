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
    public partial class BS1 : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public BS1()
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

            Util.attachToGame("LaunchOrbis.elf", "Bioshock : The Collection", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x4B0FAD, new byte[] { 0xE9, 0x3E, 0x94, 0xD4, 0x01, 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x21FA3F0, new byte[] { 0x81, 0x3B, 0x48, 0xC5, 0x44, 0x02, 0x0F, 0x85, 0x05, 0x00, 0x00, 0x00, 0xE9, 0xB4, 0x6B, 0x2B, 0xFE, 0xC5, 0xFA, 0x11, 0x8B, 0xD0, 0x06, 0x00, 0x00, 0xE9, 0xA7, 0x6B, 0x2B, 0xFE });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x4B0FAD, new byte[] { 0xC5, 0xFA, 0x11, 0x8B, 0xD0, 0x06, 0x00, 0x00 });
                    PS4.WriteMemory(processID, 0x21FA3F0, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }

            }

        }

        private void tglEve_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglEve.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x4C3CB8, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x4C3CB8, new byte[] { 0xC5, 0xFA, 0x11, 0x8B, 0x68, 0x0D, 0x00, 0x00 });
                }

            }

        }

        private void tglAmmo_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglAmmo.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x130D1D6, new byte[] { 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x130D1D6, new byte[] { 0x41, 0x89, 0x07 });
                }

            }

        }

        private void tglMoney_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglMoney.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x4C408A, new byte[] { 0x01 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x4C408A, new byte[] { 0x89 });
                }

            }

        }

        private void tglAdam_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglAdam.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x4C4442, new byte[] { 0x41, 0x01 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x4C4442, new byte[] { 0x41, 0x89 });
                }

            }

        }
    }
}
