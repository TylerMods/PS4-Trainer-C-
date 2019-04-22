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
    public partial class SonicMania : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public SonicMania()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[0] == "CUSA07023" || Util.GameInfoArray()[1] == "1.03")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.03");
            }

            Util.attachToGame("eboot.bin", "Sonic Mania", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void btnRings_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, processEntry + 0x6440FC, (int)numRings.Value);
        }

        private void btnLives_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, processEntry + 0x644108, (int)numLives.Value);
        }

        private void btnSilverMedals_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, entryList[17] + 0x12604, (int)numSilverMedals.Value);
        }
    }
}
