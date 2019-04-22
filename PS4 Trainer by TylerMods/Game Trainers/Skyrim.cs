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
    public partial class Skyrim : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public Skyrim()
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

            Util.attachToGame("eboot.bin", "Skyrim", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xb988d5, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0xb988d5, new byte[] { 0xc5, 0xfa, 0x11, 0x04, 0xc1 });
                }

            }

        }

        private void tglInfMoney_CheckedChanged(object sender)
        {
            if (tglDupMoney.Checked == true)
            {
                tglDupMoney.Checked = false;
            }
            if (attached)
            {
                if (tglInfMoney.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x53cfbf, new byte[] { 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x53cfbf, new byte[] { 0x41, 0x29, 0x46, 0x10 });
                }

            }

        }

        private void tglDupMoney_CheckedChanged(object sender)
        {
            if (tglInfMoney.Checked == true)
            {
                tglInfMoney.Checked = false;
            }
            if (attached)
            {
                if (tglDupMoney.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x53cfbf, new byte[] { 0x41, 0x01, 0x46, 0x10 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x53cfbf, new byte[] { 0x41, 0x29, 0x46, 0x10 });
                }

            }

        }
    }
}
