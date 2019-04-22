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
using MetroFramework;

namespace PS4_Trainer_by_TylerMods.Game_Trainers
{
    public partial class YakuzaZero : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public YakuzaZero()
        {
            InitializeComponent();
        }

        private void flatButton3_Click(object sender, EventArgs e)
        {

        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[0] == "CUSA05133" || Util.GameInfoArray()[1] == "1.00")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00");
            }
            Util.attachToGame("eboot.bin", "Yakuza Zero", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void btnKiryuMoney_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, entryList[15] + 0x77028, (int)numKiryuMoney.Value);
        }

        private void tglKiryuHP_CheckedChanged(object sender)
        {
            if (tglKiryuHP.Checked)
                tmrKiryuHP.Start();
            else
                tmrKiryuHP.Stop();

        }

        private void tglKiryuGauge_CheckedChanged(object sender)
        {
            if (tglKiryuGauge.Checked)
                tmrKiryuGauge.Start();
            else
                tmrKiryuGauge.Stop();

        }

        private void tglMajimaHP_CheckedChanged(object sender)
        {
            if (tglMajimaHP.Checked)
                tmrMajimaHP.Start();
            else
                tmrMajimaHP.Stop();

        }

        private void tglMajimaGauge_CheckedChanged(object sender)
        {
            if (tglMajimaGauge.Checked)
                tmrMajimaGauge.Start();
            else
                tmrMajimaGauge.Stop();

        }

        private void btnKiryuCP_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, entryList[15] + 0x77148, (int)numKiryuCP.Value);
        }

        private void btnMajimaMoney_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, entryList[15] + 0x77030, (int)numMajimaMoney.Value);
        }

        private void btnMajimaCP_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, entryList[15] + 0x77150, (int)numMajimaCP.Value);
        }

        private void tmrKiryuGauge_Tick(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, entryList[15] + 0x6F02C, (int)numKiryuGauge.Value);
        }

        private void tmrKiryuHP_Tick(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, entryList[15] + 0x6F024, (int)numKiryuHP.Value);
        }

        private void tmrMajimaGauge_Tick(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, entryList[15] + 0x6F42C, (int)numMajimaGauge.Value);
        }

        private void tmrMajimaHP_Tick(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, entryList[15] + 0x6F424, (int)numMajimaHP.Value);
        }

        private void btnFAQ_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this,
            "Q1 : Why are there numbers already in the boxes?" +
            "\nA1 : These numbers represent max health.",
            "Help", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnResetKiryuGauge_Click(object sender, EventArgs e)
        {
            numKiryuGauge.Value = 1185157120;
        }

        private void btnResetMajimaGauge_Click(object sender, EventArgs e)
        {
            numMajimaGauge.Value = 1185157120;
        }

        private void btnResetKiryuHP_Click(object sender, EventArgs e)
        {
            numKiryuHP.Value = 64552960;
        }

        private void btnResetMajimaHP_Click(object sender, EventArgs e)
        {
            numMajimaHP.Value = 64552960;
        }
    }
}
