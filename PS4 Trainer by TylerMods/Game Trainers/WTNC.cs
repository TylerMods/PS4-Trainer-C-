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
    public partial class WTNC : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public WTNC()
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
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00");
            }

            Util.attachToGame("eboot.bin", "Wolfenstein II : The New Colossus", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x127bbd5, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x127bbd5, new byte[] { 0xc5, 0xfa, 0x11, 0x43, 0x10 });
                }

            }

        }

        private void tglGoldHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglGoldHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x127baa3, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x127baa3, new byte[] { 0xc4, 0xc1, 0x7a, 0x11, 0x44, 0x24, 0x10 });
                }

            }

        }

        private void tglAmmo_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglAmmo.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x158b41b, new byte[] { 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x158b41b, new byte[] { 0x89, 0x01 });
                }

            }

        }

        private void tglShield_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglShield.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x127bb90, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x127bb90, new byte[] { 0xc5, 0xfa, 0x11, 0x4b, 0x28 });
                }

            }

        }

        private void tglFullAmmo_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglFullAmmo.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x1592BA3, new byte[] { 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x1592BA3, new byte[] { 0x89, 0x43, 0x30 });
                }

            }

        }

        private void tglThrowables_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglThrowables.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x158B3B2, new byte[] { 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x158B3B2, new byte[] { 0x01, 0x73, 0x30 });
                }

            }

        }
    }
}
