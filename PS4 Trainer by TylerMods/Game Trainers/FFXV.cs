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
    public partial class FFXV : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public FFXV()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[0] == "CUSA01615" || Util.GameInfoArray()[1] == "1.23")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.23");
            }
            Util.attachToGame("eboot.bin", "Final Fantasy XV", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
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
            ulong adr = Util.GetPointerAdress("@5804110_3_274110+18+B0+90+10+18+308+188", processID);
            byte[] money = BitConverter.GetBytes((int)numNocticHealth.Value);
            if (adr > 0)
            {
                PS4.WriteMemory(processID, adr, money);
            }
            else { }
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            ulong adr = Util.GetPointerAdress("@57CDBC0_3_23DBC0+358+30+0+1F0+10+88", processID);
            byte[] money = BitConverter.GetBytes((int)numEXP.Value);
            if (adr > 0)
            {
                PS4.WriteMemory(processID, adr, money);
            }
            else { }

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tglNoctisMP_CheckedChanged(object sender)
        {
            if (tglNoctisMP.Checked)
                tmrNoctisMP.Start();
            else
                tmrNoctisMP.Stop();

        }

        private void tmrNoctisMP_Tick(object sender, EventArgs e)
        {
            ulong adr = Util.GetPointerAdress("@5804110_3_274110+18+B0+88+18+308+1DC", processID);
            byte[] money = BitConverter.GetBytes(101);
            if (adr > 0)
            {
                PS4.WriteMemory(processID, adr, money);
            }
            else { }

        }
    }
}
