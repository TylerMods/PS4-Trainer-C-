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
    public partial class ACU : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public ACU()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[1] == "1.05")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}");
            }

            Util.attachToGame("eboot.bin", "Assassins Creed Unity", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglEagle_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglEagle.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x2e66cf6, new byte[] { 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x2e66cf6, new byte[] { 0xc5, 0xfa, 0x5c, 0xc9 });
                }

            }
        }

        private void tglMoneyConsumables_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglMoneyConsumables.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x2a46674, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x2a46674, new byte[] { 0x41, 0x89, 0x44, 0x24, 0x28 });
                }

            }
        }

        private void tgl2xMoney_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tgl2xMoney.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x2a46674, new byte[] { 0x41, 0x01, 0x44, 0x24, 0x28 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x2a46674, new byte[] { 0x41, 0x89, 0x44, 0x24, 0x28 });
                }

            }


        }
    }
}
