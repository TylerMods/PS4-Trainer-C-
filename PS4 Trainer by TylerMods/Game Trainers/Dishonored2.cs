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
    public partial class Dishonored2 : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public Dishonored2()
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

            Util.attachToGame("eboot.bin", "Dishonored 2", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglAmmo_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglAmmo.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x16D078C, new byte[] { 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    MessageBox.Show("Currently unable to turn this feature off.");
                   //PS4.WriteMemory(processID, 0xac94cf, new byte[] { 0xc5, 0xfa, 0x11, 0x43, 0x08 });
                }

            }


        }

        private void tglMagic_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglMagic.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x19360D5, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    MessageBox.Show("Currently unable to turn this feature off.");
                    //PS4.WriteMemory(processID, 0x19360D5, new byte[] { 0xc5, 0xfa, 0x11, 0x43, 0x08 });
                }

            }

        }
    }
}
