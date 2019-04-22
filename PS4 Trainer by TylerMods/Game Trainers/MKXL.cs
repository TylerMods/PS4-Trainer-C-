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
    public partial class MKXL : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public MKXL()
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

            Util.attachToGame("eboot.bin", "Mortal Kombat XL", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglMoney_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglMoney.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x73ed85, new byte[] { 0xE9, 0xCE, 0xCC, 0xFE, 0x01, 0x90 });
                    PS4.WriteMemory(processID, 0x272bA58, new byte[] { 0x41, 0xC7, 0x41, 0x08, 0x9B, 0x96, 0x7F, 0x00, 0x89, 0xD8, 0xE9, 0x24, 0x33, 0x01, 0xFE });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x73ed85, new byte[] { 0x41, 0x89, 0x59, 0x08, 0x89, 0xd8 });
                    PS4.WriteMemory(processID, 0x272bA58, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }

            }

        }

        private void tglFatality_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglFatality.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x9a2a8a, new byte[] { 0x01, 0x8C, 0x98, 0xF4, 0x87, 0x0A, 0x00 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x9a2a8a, new byte[] { 0x89, 0x8c, 0x98, 0xf4, 0x87, 0x0a, 0x00 });
                }

            }

        }

        private void tglSkip_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglSkip.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x9a2dc2, new byte[] { 0x49, 0x03, 0x04, 0x24 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x9a2dc2, new byte[] { 0x49, 0x8b, 0x04, 0x24 });
                }

            }

        }
    }
}
