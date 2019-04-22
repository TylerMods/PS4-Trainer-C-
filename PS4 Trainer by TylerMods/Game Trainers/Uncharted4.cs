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
    public partial class Uncharted4 : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public Uncharted4()
        {
            InitializeComponent();
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            //if (attached)
            //    PS4.WriteInt32(processID, processEntry + 0x04FC2E95, 1);
            //MetroMessageBox.Show(this, "L3 + Left Pad Opens 1 menu then L3 + Right Pad opens another. L3 + R3 = noclip.", "Controls", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            if (attached)
            {
                PS4.WriteMemory(processID, (ulong)((long)processEntry + 1239597), new byte[35]
                {
            197,
            250,
            17,
            132,
            36,
            48,
            7,
            0,
            0,
            128,
            184,
            157,
            46,
            0,
            0,
            0,
            15,
            133,
            21,
            14,
            0,
            0,
            198,
            128,
            149,
            46,
            0,
            0,
            1,
            235,
            4,
            8,
            14,
            0,
            0
                });
                MetroMessageBox.Show(this, "L3 + Left Pad Opens 1 menu then L3 + Right Pad opens another. L3 + R3 = noclip.", "Controls", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MetroMessageBox.Show(this, "Be sure you injected the payload and are attached to the game.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            if (Util.GameInfoArray()[1] == "1.00" || Util.GameInfoArray()[1] == "1.18" || Util.GameInfoArray()[1] == "1.23" || Util.GameInfoArray()[1] == "1.32")
            {

            }
            else
            {
                MessageBox.Show("Wrong game version! Cheats may not work!");
            }
            Util.attachToGame("eboot.bin", "Uncharted 4 : A Thief's End", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void btn118_Click(object sender, EventArgs e)
        {
            //if (attached)
            //    PS4.WriteInt32(processID, processEntry + 0x491AE79, 1);
            //MetroMessageBox.Show(this, "L3 + Left Pad Opens 1 menu then L3 + Right Pad opens another. L3 + R3 = noclip.", "Controls", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            if (attached)
            {
                PS4.WriteMemory(processID, (ulong)((long)processEntry + 2052805), new byte[26]
                {
            128,
            184,
            136,
            46,
            0,
            0,
            0,
            15,
            133,
            215,
            34,
            0,
            0,
            198,
            128,
            121,
            46,
            0,
            0,
            1,
            235,
            4,
            202,
            34,
            0,
            0
                });
                MetroMessageBox.Show(this, "L3 + Left Pad Opens 1 menu then L3 + Right Pad opens another. L3 + R3 = noclip.", "Controls", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MetroMessageBox.Show(this, "Be sure you injected the payload and are attached to the game.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn132_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x110491AE79, 1);
            MetroMessageBox.Show(this, "L3 + Left Pad Opens 1 menu then L3 + Right Pad opens another. L3 + R3 = noclip.", "Controls", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btn123_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x110491AE79, 1);
            MetroMessageBox.Show(this, "L3 + Left Pad Opens 1 menu then L3 + Right Pad opens another. L3 + R3 = noclip.", "Controls", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
