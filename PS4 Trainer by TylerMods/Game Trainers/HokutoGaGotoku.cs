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
    public partial class HokutoGaGotoku : UserControl
    {
        PS4RPC PS4 = main.PS4;
        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public HokutoGaGotoku()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[0] == "CUSA10053" || Util.GameInfoArray()[1] == "1.00")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00");
            }

            Util.attachToGame("eboot.bin", "Hokuto Ga Gotoku", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
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
                PS4.WriteInt16(processID, 0x2000B26D4, 9999);
        }

        private void tglAura_CheckedChanged(object sender)
        {
            
        }

        private void tmrAura_Tick(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteSingle(processID, 0x2000B26DC, 7000);
        }

        private void btnMaxLevel_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteByte(processID, 0x2000B26D1, 99);
        }

        private void tglToki_CheckedChanged(object sender)
        {
            if (tglToki.Checked)
                tmrToki.Start();
            else
                tmrToki.Stop();

        }

        private void tglSouther_CheckedChanged(object sender)
        {
            if (tglSouther.Checked)
                tmrSouther.Start();
            else
                tmrSouther.Stop();

        }

        private void tglRei_CheckedChanged(object sender)
        {
            if (tglRei.Checked)
                tmrRei.Start();
            else
                tmrRei.Stop();

        }

        private void tglShin_CheckedChanged(object sender)
        {
            if (tglShin.Checked)
                tmrShin.Start();
            else
                tmrShin.Stop();

        }

        private void tmrToki_Tick(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteSingle(processID, 0x2000C891C, 0);

        }

        private void tmrRei_Tick(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteSingle(processID, 0x2000C8934, 0);

        }

        private void tmrSouther_Tick(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteSingle(processID, 0x2000C8944, 0);

        }

        private void tmrShin_Tick(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteSingle(processID, 0x2000C88FC, 0);

        }

        private void btnAura_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteSingle(processID, 0x2000B26DC, 7000);
        }

        private void btnGrey_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt16(processID, 0x2000B2708, 99);

        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt16(processID, 0x2000B270C, 99);

        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt16(processID, 0x2000B2710, 99);

        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt16(processID, 0x2000B270E, 99);

        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt16(processID, 0x2000B270A, 99);

        }

        private void btnPoker_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x2000B7E20, (int)numPoker.Value);
        }

        private void btnArena_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x2000B7E58, (int)numArena.Value);

        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x2000B7E08, (int)numMoney.Value);

        }

        private void btnBPCarMoney_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x2000B7EB8, (int)numBPCarMoney.Value);
        }

        private void tglVehicle_CheckedChanged(object sender)
        {
            if (tglVehicle.Checked)
                tmrVehicle.Start();
            else
                tmrVehicle.Stop();

        }

        private void tmrVehicle_Tick(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@2532B20_3_112B20+28+848+410+0+50+0+A8+20+A24", processID);
                if (adr > 0)
                {
                    PS4.WriteSingle(processID, adr, 350);
                }
                else { MessageBox.Show("Wrong Section"); }
            }
        }
    }
}
