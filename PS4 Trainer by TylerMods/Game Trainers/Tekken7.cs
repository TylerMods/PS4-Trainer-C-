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
    public partial class Tekken7 : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public Tekken7()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[0] == "CUSA06014" || Util.GameInfoArray()[1] == "1.00")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00");
            }

            Util.attachToGame("eboot.bin", "Tekken 7", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@35AB8C60_3_18C60+8+0+98", processID);
                byte[] money = BitConverter.GetBytes((int)numMoney.Value);
                if (adr > 0)
                {
                    PS4.WriteMemory(processID, adr, money);
                }
                else { MessageBox.Show("Wrong Section"); }
            }
        }

        private void tglLeftSideFigherHealth_CheckedChanged(object sender)
        {
            if (tglLeftSideFigherHealth.Checked)
                tmrLeftSideFigherHealth.Start();
            else
                tmrLeftSideFigherHealth.Stop();
        }

        private void tglRightSideFigherHealth_CheckedChanged(object sender)
        {
            if (tglRightSideFigherHealth.Checked)
                tmrRightSideFigherHealth.Start();
            else
                tmrRightSideFigherHealth.Stop();
        }

        private void tmrLeftSideFigherHealth_Tick(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@35AD8560_3_38560+304", processID);
                byte[] money = BitConverter.GetBytes((int)numMoney.Value);
                if (adr > 0)
                {
                    PS4.WriteMemory(processID, adr, money);
                }
                else { tmrLeftSideFigherHealth.Enabled = false; tglLeftSideFigherHealth.Checked = false; MessageBox.Show("Wrong Section"); }
            }
        }

        private void tmrRightSideFigherHealth_Tick(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@35ADB350_3_3B350+304", processID);
                byte[] money = BitConverter.GetBytes((int)numMoney.Value);
                if (adr > 0)
                {
                    PS4.WriteMemory(processID, adr, money);
                }
                else { tmrRightSideFigherHealth.Enabled = false; tglRightSideFigherHealth.Checked = false; MessageBox.Show("Wrong Section"); }
            }
        }
    }
}
