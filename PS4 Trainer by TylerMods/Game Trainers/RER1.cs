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
using System.Threading;

namespace PS4_Trainer_by_TylerMods.Game_Trainers
{
    public partial class RER1 : UserControl
    {
        PS4RPC PS4 = main.PS4;
        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public RER1()
        {
            InitializeComponent();
        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x76C0FC, new byte[] { 0xc5, 0xfa, 0x11, 0x9f, 0x48, 0x13, 0x00, 0x00 });
                    Thread.Sleep(500);
                    PS4.WriteMemory(processID, 0x76C0FC, new byte[] { 0xc5, 0xfa, 0x11, 0xa7, 0x48, 0x13, 0x00, 0x00 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x76C0FC, new byte[] { 0xc5, 0xfa, 0x11, 0x87, 0x48, 0x13, 0x00, 0x00 });
                }
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0];
            var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[0] == "CUSA06314" || Util.GameInfoArray()[1] == "1.00")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00");
            }

            Util.attachToGame("eboot.bin", "Resident Evil Revelations", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglAmmo_CheckedChanged(object sender)
        {
            if (attached)
                if (tglAmmo.Checked == true)
                    PS4.WriteMemory(processID, 0x6168b0, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                else
                    PS4.WriteMemory(processID, 0x6168b0, new byte[] { 0x89, 0x88, 0x04, 0x15, 0x00, 0x00 });

        }

        private void btnFAQ_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you don't have 1 hit kill, do this... Enable the cheat, start a match, disable the cheat, get killed, enable the cheat. Done.");
        }

        private void tglBP_CheckedChanged(object sender)
        {
            if (attached)
                if (tglBP.Checked == true)
                    PS4.WriteMemory(processID, 0x8E80E8, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                else
                    PS4.WriteMemory(processID, 0x8E80E8, new byte[] { 0x89, 0x8b, 0x18, 0x01, 0x00, 0x00 });

        }

        private void tglMulti_CheckedChanged(object sender)
        {
            if (attached)
                if (tglBP.Checked == true)
                    PS4.WriteMemory(processID, 0x9C277D, new byte[] { 0x44, 0x01, 0xb0, 0xcc, 0x1d, 0x00, 0x00 });
                else
                    PS4.WriteMemory(processID, 0x9C277D, new byte[] { 0x44, 0x89, 0xb8, 0xcc, 0x1d, 0x00, 0x00 });
        }

        private void btnLevel_Click(object sender, EventArgs e)
        {
            if (attached)
                    PS4.WriteMemory(processID, 0x906192, new byte[] { 0x45, 0x01, 0x97, 0xa8, 0x05, 0x00, 0x00 });
        }
    }
}
