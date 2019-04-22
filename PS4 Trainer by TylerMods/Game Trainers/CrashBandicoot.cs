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
    public partial class CrashBandicoot : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public CrashBandicoot()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[0] == "CUSA07399" || Util.GameInfoArray()[1] == "1.00")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00");
            }

            Util.attachToGame("eboot.bin", "Crash Bandicoot N-sane Trilogy", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void flatComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnApples_Click(object sender, EventArgs e)
        {
                if (attached)
                    PS4.WriteInt32(processID, 0x2587CD9A0, (int)numApples.Value);
        }

        private void btnLives_Click(object sender, EventArgs e)
        {
                if (attached)
                    PS4.WriteInt32(processID, 0x24F9EA114, (int)numLives.Value);
        }

        private void btnBoxes_Click(object sender, EventArgs e)
        {
                if (attached)
                    PS4.WriteInt32(processID, 0x2587CC1A0, (int)numBoxes.Value);
        }

        private void btnDiamonds_Click(object sender, EventArgs e)
        {
                if (attached)
                    PS4.WriteInt32(processID, 0x24F9EA11C, (int)numDiamonds.Value);
        }

        private void btnSaphir_Click(object sender, EventArgs e)
        {
                if (attached)
                    PS4.WriteInt32(processID, 0x24F9EA120, (int)numSaphir.Value);
        }

        private void btnGold_Click(object sender, EventArgs e)
        {
                if (attached)
                    PS4.WriteInt32(processID, 0x24F9EA124, (int)numGold.Value);

        }

        private void btnPlatin_Click(object sender, EventArgs e)
        {
                if (attached)
                    PS4.WriteInt32(processID, 0x24F9EA128, (int)numPlatin.Value);

        }

        private void btnKeys_Click(object sender, EventArgs e)
        {
                if (attached)
                    PS4.WriteInt32(processID, 0x24F9EA118, (int)numKeys.Value);
        }
    }
}
