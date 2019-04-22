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
    public partial class AlienIsolation : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public AlienIsolation()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[1] == "1.04")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.04");
            }

            Util.attachToGame("eboot.bin", "Alien Isolation", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglMaterials_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglMaterials.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x5ae72e, new byte[] { 0x01});
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x5ae72e, new byte[] { 0x89 });
                }

            }

        }

        private void flatToggle1_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (flatToggle1.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x41e8b4, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90});
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x41e8b4, new byte[] { 0x41, 0x89, 0x85, 0x28, 0x01, 0x00, 0x00 });
                }

            }

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x12245d7, new byte[] { 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x12245d7, new byte[] { 0x48, 0x8b, 0x43, 0x40 });
                }

            }

        }
    }
}
