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
    public partial class RE6 : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public RE6()
        {
            InitializeComponent();
        }

        private void numMoney_Click(object sender, EventArgs e)
        {

        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[0] == "CUSA03856" || Util.GameInfoArray()[1] == "1.00")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\n You need v01.00");
            }

            Util.attachToGame("eboot.bin", "Resident Evil 6", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@5E7CDDE0_3_9DE0+28+28+20+38+5B0+518", processID);
                if (adr > 0)
                {
                    PS4.WriteInt32(processID, adr, (int)numSP.Value);
                }
                else {  }
            }
        }

        private void btnAssaultRifleAmmo_Click(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@5E7CD2D8_3_92D8+28+568+C8+148+58+1A8+8+6FE", processID);
                if (adr > 0)
                {
                    PS4.WriteInt16(processID, adr, 9999);
                }
                else { }
            }
        }

        private void tmrHealth_Tick(object sender, EventArgs e)
        {

        }

        private void tmrAssaultRifleAmmo_Tick(object sender, EventArgs e)
        {
        }

        private void tmrStamina_Tick(object sender, EventArgs e)
        {
        }
        private void tglStamina_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglStamina.Checked)
                {
                    PS4.WriteMemory(processID, 0xB9DA9B, new byte[] { 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");

                    PS4.WriteMemory(processID, 0xB9DA9B, new byte[] { 0x89, 0xD8 });
                }
            }

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked)
                {
                    PS4.WriteMemory(processID, 0xB1240B, new byte[] { 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");

                    PS4.WriteMemory(processID, 0xB1240B, new byte[] { 0x29, 0xF1 });
                }
            }


        }

        private void tglAssaultRifleAmmo_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglAssaultRifleAmmo.Checked)
                {
                    PS4.WriteMemory(processID, processEntry + 0xF324C4, new byte[] { 0x90, 0x90 });
                }
                else
                { 
                    PS4.WriteMemory(processID, processEntry + 0xF324C4, new byte[] { 0x29, 0xF0 });
                }
            }
        }
    }
}
