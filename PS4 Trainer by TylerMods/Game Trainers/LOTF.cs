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
    public partial class LOTF : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public LOTF()
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

            Util.attachToGame("eboot.bin", "Lords of the Fallen", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x63375c, new byte[] { 0xe9, 0x3f, 0x6b, 0x82, 0x01});
                    PS4.WriteMemory(processID, 0x1e5a2a0, new byte[] { 0x49, 0xC7, 0xC1, 0x00, 0x00, 0x00, 0x00, 0x4D, 0x39, 0x8C, 0x24, 0x00, 0x06, 0x00, 0x00, 0x0F, 0x84, 0xAE, 0x94, 0x7D, 0xFE, 0xC4, 0xC1, 0x7A, 0x11, 0x54, 0x24, 0x74, 0xE9, 0xA2, 0x94, 0x7D, 0xFE });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x63375c, new byte[] { 0xc4, 0xc1, 0x7a, 0x11, 0x54, 0x24, 0x74 });
                    PS4.WriteMemory(processID, 0x1e5a2a0, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00});
                }

            }

        }

        private void tglSky_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglSky.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x4f9a29, new byte[] { 0xc5, 0xfa, 0x11, 0x13 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x4f9a29, new byte[] { 0xc5, 0xfa, 0x11, 0x03 });
                }

            }

        }

        private void tglStamina_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglStamina.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x633DA1, new byte[] { 0xc5, 0xfa, 0x11, 0x53, 0x7c });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x633DA1, new byte[] { 0xc5, 0xfa, 0x11, 0x5b, 0x7c });
                }

            }

        }
    }
}
