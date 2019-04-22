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
    public partial class SOTC : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public SOTC()
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

            if (Util.GameInfoArray()[0] == "CUSA08809" || Util.GameInfoArray()[1] == "1.00")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00");
            }

            Util.attachToGame("eboot.bin", "Shadow of The Colussus", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglGrip_CheckedChanged(object sender)
        {
            if (tglGrip.Checked)
                tmrGrip.Start();
            else
                tmrGrip.Stop();
        }

        private void tmrHealth_Tick(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x3665C78, 1133903872);
        }

        private void tmrGrip_Tick(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x3665C90, 1133903872);
        }
    }
}
