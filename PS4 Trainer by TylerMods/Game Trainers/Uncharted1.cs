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
    public partial class Uncharted1 : UserControl
    {
        PS4RPC PS4 = main.PS4;
        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public Uncharted1()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            if (Util.GameInfoArray()[0] == "CUSA02343" || Util.GameInfoArray()[1] == "1.00" || Util.GameInfoArray()[1] == "1.02")
            {

            }
            else
            {
                MessageBox.Show("Wrong CUSA or game version! Cheats may not work!");
            }

            Util.attachToGame("eboot.bin", "Uncharted 1", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            if (attached)

                PS4.WriteMemory(processID, 0x6CF8B0, new byte[] { 0x41, 0xC6, 0x87, 0xE8, 0x47, 0x00, 0x00, 0x00, 0xEB, 0x04, 0xAC, 0x0E, 0x00, 0x00, 0x41, 0xC6, 0x87, 0x44, 0x48, 0x00, 0x00, 0x01, 0xEB, 0x05, 0x84, 0x9D, 0x0E, 0x00, 0x00 });
            MetroMessageBox.Show(this, "L3 + Left Pad Opens 1 menu then L3 + Right Pad opens another. L3 + R3 = noclip.", "Controls", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btn102_Click(object sender, EventArgs e)
        {
            if (attached)

                PS4.WriteMemory(processID, 0x6CFEA0, new byte[] { 0x41, 0xC6, 0x87, 0xE8, 0x47, 0x00, 0x00, 0x00, 0xEB, 0x04, 0xAC, 0x0E, 0x00, 0x00, 0x41, 0xC6, 0x87, 0x44, 0x48, 0x00, 0x00, 0x01, 0xEB, 0x05, 0x84, 0x9D, 0x0E, 0x00, 0x00 });
            MetroMessageBox.Show(this, "L3 + Left Pad Opens 1 menu then L3 + Right Pad opens another. L3 + R3 = noclip.", "Controls", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
