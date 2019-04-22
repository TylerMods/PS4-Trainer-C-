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
    public partial class DWE : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public DWE()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[1] == "1.01")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.01");
            }

            Util.attachToGame("eboot.bin", "Darksiders Warmastered Edition", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xab7b38, new byte[] { 0xc5, 0xfa, 0x58, 0xc1 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0xab7b38, new byte[] { 0xc5, 0xfa, 0x5c, 0xc1 });
                }

            }

        }

        private void tglChaosAfter_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglChaosAfter.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x5f96c6, new byte[] { 0x0f, 0x44, 0xca });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x5f96c6, new byte[] { 0x0f, 0x4c, 0xca });
                }

            }


        }

        private void tglOneHitChaos_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglOneHitChaos.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x5f9afe, new byte[] { 0xc5, 0xfa, 0x11, 0x53, 0x08 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x5f9afe, new byte[] { 0xc5, 0xfa, 0x11, 0x4b, 0x08 });
                }

            }


        }

        private void tglOneHitWrath_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglOneHitWrath.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x5f9473, new byte[] { 0xc5, 0xfa, 0x58, 0x43, 0x04 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x5f9473, new byte[] { 0xc5, 0xfb, 0x58, 0x43, 0x04 });
                }

            }


        }

        private void tglWrath_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglWrath.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x5f9478, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x5f9478, new byte[] { 0xc5, 0xfa, 0x11, 0x43, 0x04 });
                }

            }

        }

        private void tglSouls_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglSouls.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xAD881B, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0xAD881B, new byte[] { 0xC5, 0xFA, 0x11, 0x87, 0x00, 0x08, 0x00, 0x00 });
                }

            }

        }

        private void tglHorseBurst_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHorseBurst.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x73f0a9, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x73f0a9, new byte[] { 0x89, 0x83, 0x5c, 0x06, 0x00, 0x00 });
                }

            }

        }
    }
}
