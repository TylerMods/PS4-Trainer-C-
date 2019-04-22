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
    public partial class YakuzaKiwami : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public YakuzaKiwami()
        {
            InitializeComponent();
        }

        private void tglGodMode_CheckedChanged(object sender)
        {
            if (tglGodMode.Checked == true)
            {
                tmrHealth.Start();
            }
            else
            {
                tmrHealth.Stop();
            }
        }

        private void tmrGauge_Tick(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, entryList[16] + 0x6EFEC, 1184081920);
        }

        private void tglEXP_CheckedChanged(object sender)
        {
            if (tglEXP.Checked == true)
            {
                tmrEXP.Start();
            }
            else
            {
                tmrEXP.Stop();
            }
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, entryList[16] + 0x744A8, (int)numMoney.Value);
        }

        private void YakuzaKiwami_Load(object sender, EventArgs e)
        {
        }

        private void btnCP_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, entryList[16] + 0x74538, (int)numCP.Value);
        }

        private void tmrHealth_Tick(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, entryList[16] + 0x6EFE4, 75678592);
        }

        private void tglGauge_CheckedChanged(object sender)
        {
            if (tglGauge.Checked == true)
            {
                tmrGauge.Start();
            }
            else
            {
                tmrGauge.Stop();
            }
        }

        private void tmrEXP_Tick(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, entryList[16] + 0x6F018, 999999);
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[0] == "CUSA07615" || Util.GameInfoArray()[1] == "1.00")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00");
            }
            Util.attachToGame("eboot.bin", "Yakuza Kiwami", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }
    }
}
