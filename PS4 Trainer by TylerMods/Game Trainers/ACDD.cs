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

namespace PS4_Trainer_by_TylerMods.API
{
    public partial class ACDD : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public ACDD()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[1] == "1.02")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}");
            }

            Util.attachToGame("amnesia.elf", "Amnesia Collection - Dark Descent", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x6590ae, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x6590ae, new byte[] { 0xc4, 0xc1, 0x7a, 0x11, 0x8f, 0xdc, 0x00, 0x00, 0x00 });
                }

            }

        }

        private void tglTinderbox_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglTinderbox.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x4ca787, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x4ca787, new byte[] { 0xff, 0x89, 0xf0, 0x00, 0x00, 0x00 });
                }

            }

        }

        private void tglLamp_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglLamp.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x659d54, new byte[] { 0xc5, 0xfa, 0x11, 0x9f, 0xe4, 0x00, 0x00, 0x00 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x659d54, new byte[] { 0xc5, 0xfa, 0x11, 0x87, 0xe4, 0x00, 0x00, 0x00 });
                }

            }

        }
    }
}
