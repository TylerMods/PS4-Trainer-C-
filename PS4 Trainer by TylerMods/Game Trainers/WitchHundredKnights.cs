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
    public partial class WitchHundredKnights : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public WitchHundredKnights()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[0] == "CUSA10135" || Util.GameInfoArray()[1] == "1.00")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00");
            }

            Util.attachToGame("eboot.bin", "The Witch and The Hundred Knights", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void btnSkillPoints_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x207219220, (int)numSkillPoints.Value);
        }

        private void btnLevel_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x207212798, (int)numLevel.Value);
        }

        private void btnMana_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x206DC2758, (int)numMana.Value);
        }

        private void tgl1Kill_CheckedChanged(object sender)
        {
            if (tgl1Kill.Checked)
                tmr1Kill.Start();
            else
                tmr1Kill.Stop();
        }

        private void tmr1Kill_Tick(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x2072128C0, 0);
        }

        private void btnMaxSkills_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x207211F74, 9);
            PS4.WriteInt32(processID, 0x207211F9C, 9);
            PS4.WriteInt32(processID, 0x207211FC4, 9);
            PS4.WriteInt32(processID, 0x207211FEC, 9);
            PS4.WriteInt32(processID, 0x207212014, 9);
            PS4.WriteInt32(processID, 0x20721203C, 9);
            PS4.WriteInt32(processID, 0x207212064, 9);
        }
    }
}
