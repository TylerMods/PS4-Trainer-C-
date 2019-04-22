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
    public partial class KH1 : UserControl
    {
        PS4RPC PS4 = main.PS4;
        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public KH1()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[0] == "CUSA05786" || Util.GameInfoArray()[1] == "1.04")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.04");
            }

            Util.attachToGame("kingdom1.elf", "Kingdom Hearts", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
                if (tglHealth.Checked)
                    tmrHealth.Start();
                else
                    tmrHealth.Stop();

        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x301ee0c, (int)numMoney.Value);
        }

        private void tmrHealth_Tick(object sender, EventArgs e)
        {
                    PS4.WriteSingle(processID, 0x2EA7CEC, 5);
        }

        private void tglAmmo_CheckedChanged(object sender)
        {

        }

        private void tglMoney_CheckedChanged(object sender)
        {

        }
    }
}
