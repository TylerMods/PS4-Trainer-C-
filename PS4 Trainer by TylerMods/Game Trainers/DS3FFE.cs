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
    public partial class DS3FFE : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public DS3FFE()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];
            if (Util.GameInfoArray()[0] == "CUSA07439" || Util.GameInfoArray()[1] == "1.00")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00");
            }

            Util.attachToGame("eboot.bin", "Dark Souls 3 : Fire Fades Edition", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (tglHealth.Checked)
                tmrHealth.Start();
            else
                tmrHealth.Stop();

        }

        private void tglEnergy_CheckedChanged(object sender)
        {
            if (tglEnergy.Checked)
                tmrEnergy.Start();
            else
                tmrEnergy.Stop();
        }

        private void tglBombs_CheckedChanged(object sender)
        {
            if (tglBombs.Checked)
                tmrBombs.Start();
            else
                tmrBombs.Stop();
        }

        private void btnSouls_Click(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@1F243DE8_3_63DE8+10+520+B8+FFFFFFFFFFFFFE4C", processID);
                byte[] money = BitConverter.GetBytes((int)numSouls.Value);
                if (adr > 0)
                {
                    PS4.WriteMemory(processID, adr, money);
                }
                else { }
            }
        }

        private void tmrHealth_Tick(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@1F26CB50_3_8CB50+80+1398+128+D8", processID);
                byte[] money = BitConverter.GetBytes(9999);
                if (adr > 0)
                {
                    PS4.WriteMemory(processID, adr, money);
                }
                else { }
            }

        }

        private void tmrEnergy_Tick(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@1F26CB50_3_8CB50+40+28+420+2E0+8+BE8+114", processID);
                byte[] money = BitConverter.GetBytes(9999);
                if (adr > 0)
                {
                    PS4.WriteMemory(processID, adr, money);
                }
                else { }
            }

        }

        private void tmrBombs_Tick(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@1F2F7AC0_3_117AC0+258+68+160+148+4C0", processID);
                if (adr > 0)
                {
                    PS4.WriteInt16(processID, adr, 99);
                }
                else { }
            }

        }
    }
}
