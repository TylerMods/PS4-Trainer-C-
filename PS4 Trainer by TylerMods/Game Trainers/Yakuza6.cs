using System;
using System.Windows.Forms;
using librpc;
using System.Collections.Generic;

namespace PS4_Trainer_by_TylerMods.Game_Trainers
{
    public partial class Yakuza6 : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public Yakuza6()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[1] == "01.05")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.05");
            }

            Util.attachToGame("eboot.bin", "Yakuza 6", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xEC236B, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0xEC236B, new byte[] { 0x48, 0x89, 0x90, 0x70, 0x03, 0x00, 0x00 });
                }
            }
        }

        private void tglGauge_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglGauge.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xEB2D00, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0xEB2965, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0xEB2D00, new byte[] { 0xC5, 0xFA, 0x11, 0x80, 0x80, 0x03, 0x00, 0x00 });
                    PS4.WriteMemory(processID, 0xEB2965, new byte[] { 0xC5, 0xFA, 0x11, 0x88, 0x80, 0x03, 0x00, 0x00 });
                }
            }
        }

        private void tglItems_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglItems.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x11AA1C3, new byte[] { 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x11AA1C3, new byte[] { 0x44, 0x89, 0x69, 0xF4 });
                }
            }
        }

        private void tglMoney_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglMoney.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x11A8F1E, new byte[] { 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x11A8F1E, new byte[] { 0x4A, 0x89, 0x0C, 0xE8 });
                }
            }
        }
    }
}
