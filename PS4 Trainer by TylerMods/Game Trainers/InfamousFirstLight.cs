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
    public partial class InfamousFirstLight : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public InfamousFirstLight()
        {
            InitializeComponent();
        }

        private void InfamousFirstLight_Load(object sender, EventArgs e)
        {
        }

        private void btnSkillPoints_Click(object sender, EventArgs e)
        {
            PS4.WriteMemory(processID, processEntry + 0x1112DEC, new byte[] { 0x63 });
        }

        private void tglMeleeFinisher_CheckedChanged(object sender)
        {
            if (tglMeleeFinisher.Checked)
                tmrMeleeFinisher.Start();
            else
                tmrMeleeFinisher.Stop();
        }

        private void tmrMeleeFinisher_Tick(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteMemory(processID, processEntry + 0x1112DE8, new byte[] { 0x02 });
        }

        private void tmrNeon_Tick(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, processEntry + 0x1112DF0, 1101004800);
        }

        private void tglNeon_CheckedChanged(object sender)
        {
            if (tglNeon.Checked)
                tmrNeon.Start();
            else
                tmrNeon.Stop();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[0] == "CUSA00897" || Util.GameInfoArray()[1] == "1.04")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.04");
            }

            Util.attachToGame("eboot.bin", "Infamous : First Light", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }
    }
}
