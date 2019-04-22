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
    public partial class DBZF : UserControl
    {
        PS4RPC PS4 = main.PS4;
        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public DBZF()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[0] == "CUSA08992" || Util.GameInfoArray()[1] == "1.00")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00");
            }

            Util.attachToGame("eboot.bin", "Dragon Ball FigherZ", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);


        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (tglHealth.Checked)
                tmrHealth.Start();
            else
                tmrHealth.Stop();
        }

        private void tmrHealth_Tick(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@5F35268_3_8F1268+158+8+6B8+CEC", processID);
                if (adr > 0)
                {
                    PS4.WriteInt32(processID, adr, 5000);
                }
                else { }
            }

        }

        private void btnEXP_Click(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@5E5B500_3_817500+20+88+D0+8+30+F118+D508+AFC0+8+20C", processID);
                if (adr > 0)
                {
                    PS4.WriteInt32(processID, adr, (int)numEXP.Value);
                }
                else { }
            }


        }

        private void btnZeni_Click(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@5AA2E78_3_45EE78+5A10", processID);
                if (adr > 0)
                {
                    PS4.WriteInt32(processID, adr, (int)numZeni.Value);
                }
                else { }
            }


        }

        private void btnPZC_Click(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@5AA2E78_3_45EE78+5A18", processID);
                if (adr > 0)
                {
                    PS4.WriteInt32(processID, adr, (int)numPZC.Value);
                }
                else { }
            }

        }
    }
}
