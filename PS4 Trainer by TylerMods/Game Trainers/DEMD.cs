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
    public partial class DEMD : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public DEMD()
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

            Util.attachToGame("eboot.bin", "Deus Ex Mankind Divided", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x1061136, new byte[] { 0xe9, 0x85, 0x11, 0xa7, 0x02 });
                    PS4.WriteMemory(processID, 0x03ad22c0, new byte[] { 0x49, 0xc7, 0xc0, 0x00, 0x00, 0x00, 0x00, 0x4c, 0x39, 0x83, 0x40, 0x04, 0x00, 0x00, 0x0f, 0x84, 0x67, 0xee, 0x58, 0xfd, 0xc5, 0xfa, 0x11, 0x43, 0x44, 0xe9, 0x5d, 0xee, 0x58, 0xfd });
                }
                else
                {
                    MessageBox.Show("Currently unable to turn this feature off.");
                    //PS4.WriteMemory(processID, 0x1061136, new byte[] { 0xc5, 0xfa, 0x11, 0x43, 0x08 });
                    //PS4.WriteMemory(processID, 0x03ad22c0, new byte[] { 0xe9 85 11 a7 02 });
                }

            }

        }

        private void tglReload_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglReload.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x182ef6c, new byte[] { 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x182ef6c, new byte[] { 0x44, 0x89, 0x73, 0x40 });
                }

            }

        }

        private void tglHack_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHack.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x1c16e27, new byte[] { 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x1c16e27, new byte[] { 0x89, 0x4b, 0x34 });
                }

            }

        }
    }
}
