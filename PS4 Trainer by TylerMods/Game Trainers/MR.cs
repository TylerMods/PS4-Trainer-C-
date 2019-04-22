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
    public partial class MR : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public MR()
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

            Util.attachToGame("eboot.bin", "Metro Redux", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglGas_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglGas.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x6513AE, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x6513AE, new byte[] { 0xC4, 0xC1, 0x7A, 0x11, 0x84, 0x24, 0x5C, 0x04, 0x00, 0x00 });
                }

            }

        }

        private void tglReload_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglReload.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x610E9D, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x610E9D, new byte[] { 0x41, 0x89, 0xB4, 0x24, 0x58, 0x04, 0x00, 0x00 });
                }

            }


        }

        private void tglAmmo_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglAmmo.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x5EC11A, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x5EC11A, new byte[] { 0x41, 0x89, 0xB6, 0x00, 0x05, 0x00, 0x00 });
                }

            }


        }

        private void tglPressure_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglPressure.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x626D7A, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x626D7A, new byte[] { 0xC5, 0xFA, 0x11, 0x83, 0x00, 0x0C, 0x00, 0x00 });
                }

            }

        }

        private void tglAmmo101_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglAmmo101.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x611e3d, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x611e3d, new byte[] { 0x41, 0x89, 0xB4, 0x24, 0x58, 0x04, 0x00, 0x00 });
                }

            }


        }
    }
}
