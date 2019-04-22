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
    public partial class Outlast2 : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public Outlast2()
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

            Util.attachToGame("eboot.bin", "Outlast 2", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x1e38c6a, new byte[] { 0xc4, 0x41, 0x7a, 0x11, 0x87, 0x88, 0x7f, 0x00, 0x00 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x1e38c6a, new byte[] { 0xc4, 0xc1, 0x7a, 0x11, 0x87, 0x88, 0x7f, 0x00, 0x00 });
                }

            }

        }

        private void tglNightVision_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglNightVision.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x1eb8a67, new byte[] { 0xc4, 0xc1, 0x7a, 0x11, 0x97, 0x7c, 0x82, 0x00, 0x00 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x1eb8a67, new byte[] { 0xc4, 0xc1, 0x7a, 0x11, 0x8f, 0x7c, 0x82, 0x00, 0x00 });
                }

            }

        }
    }
}
