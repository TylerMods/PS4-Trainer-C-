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
using MetroFramework;

namespace PS4_Trainer_by_TylerMods.Game_Trainers
{
    public partial class Uncharted2 : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public Uncharted2()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            if (Util.GameInfoArray()[0] == "CUSA02343" || Util.GameInfoArray()[1] == "1.00")
            {

            }
            else
            {
                MessageBox.Show("Wrong CUSA or game version! Cheats may not work!");
            }
            Util.attachToGame("big2-ps4_Shipping.elf", "Uncharted 2", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            if (attached)

                PS4.WriteMemory(processID, 0x54C4FD, new byte[] { 0xC6, 0x81, 0x21, 0x48, 0x00, 0x00, 0x00, 0xEB, 0x04, 0xC1, 0x0B, 0x00, 0x00, 0xC6, 0x81, 0x8C, 0x48, 0x00, 0x00, 0x01, 0xEB, 0x05, 0x84, 0xB3, 0x0B, 0x00, 0x00});
            MetroMessageBox.Show(this, "L3 + Left Pad Opens 1 menu then L3 + Right Pad opens another. L3 + R3 = noclip.", "Controls", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
