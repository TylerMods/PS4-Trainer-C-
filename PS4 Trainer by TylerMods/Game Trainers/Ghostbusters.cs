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
    public partial class Ghostbusters : UserControl
    {
        PS4RPC PS4 = main.PS4;
        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public Ghostbusters()
        {
            InitializeComponent();
        }

        private void numIntuition_Click(object sender, EventArgs e)
        {

        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];
            if (Util.GameInfoArray()[0] == "CUSA04312" || Util.GameInfoArray()[1] == "1.00")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00");
            }

            Util.attachToGame("eboot.bin", "Ghostbusters", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void tmrHealth_Tick(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@4106B10_3_2B2B10+50+70+8+430+958+3C0+6C", processID);
                if (adr > 0)
                {
                    PS4.WriteSingle(processID, adr, 1000);
                }
                else { tmrHealth.Enabled = false; tglHealth.Checked = false; MessageBox.Show("Wrong Section"); }
            }
        }

        private void btnXP_Click(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@4033140_3_1DF140+8+3F0+70+8+3B0+B2C", processID);
                if (adr > 0)
                {
                    PS4.WriteSingle(processID, adr, (int)numXP.Value);
                }
                else { MessageBox.Show("Wrong Section"); }
            }
        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (tglHealth.Checked)
                tmrHealth.Start();
            else
                tmrHealth.Stop();
        }
    }
}
