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
    public partial class ACS : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public ACS()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[1] == "1.52")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.52");
            }

            Util.attachToGame("eboot.bin", "Assassins Creed Syndicate", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x18d1890, new byte[] { 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x18d1890, new byte[] { 0x89, 0x37 });
                }

            }

        }

        private void tglx2Money_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglx2Money.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x1eb59bb, new byte[] { 0x41, 0x01, 0x44, 0x24, 0x28 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x1eb59bb, new byte[] { 0x41, 0x89, 0x44, 0x24, 0x28 });
                }

            }

        }

        private void tglAmmo_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglAmmo.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x1ebf9d9, new byte[] { 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x1ebf9d9, new byte[] { 0x45, 0x89, 0x7e, 0x28 });
                }

            }

        }

        private void tglInfMoney_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglInfMoney.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x1eb59bb, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x1eb59bb, new byte[] { 0x41, 0x89, 0x44, 0x24, 0x28 });
                }

            }

        }
    }
}
