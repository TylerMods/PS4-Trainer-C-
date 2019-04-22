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
    public partial class DMC3 : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public DMC3()
        {
            InitializeComponent();
        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (tglHealth.Checked)
                tmrHealth.Start();
            else
                tmrHealth.Stop();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[0] == "CUSA09263" || Util.GameInfoArray()[1] == "1.00")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00");
            }

            Util.attachToGame("dmc3.elf", "DMC3", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void tmrHealth_Tick(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteSingle(processID, 0x2917BDF5C, 12000);
        }

        private void tglVergilTrigger_CheckedChanged(object sender)
        {
            if (tglVergilTrigger.Checked)
                tmrVergilTrigger.Start();
            else
                tmrVergilTrigger.Stop();
        }
        private void tmrVergilTrigger_Tick(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteSingle(processID, 0x2917BDCF8, 10000);
        }

        private void tmrZeroDamage_Tick(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteSingle(processID, 0x28D7C0384, 0);
        }

        private void flatToggle1_CheckedChanged(object sender)
        {
            if (tglZeroDamage.Checked)
                tmrZeroDamage.Start();
            else
                tmrZeroDamage.Stop();
        }

        private void btnRO_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x28D7C0310, 0);
        }
    }
}
