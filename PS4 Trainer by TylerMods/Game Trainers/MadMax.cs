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
    public partial class MadMax : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public MadMax()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[1] == "1.04")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.04");
            }

            Util.attachToGame("eboot.bin", "Mad Max", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
    }

        private void tglMoney_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglMoney.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x3F3960, new byte[] { 0xE9, 0xCB, 0x85, 0xF5, 0x00, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x134BF30, new byte[] { 0x41, 0xC7, 0x44, 0xCA, 0x0C, 0x80, 0x4F, 0xC3, 0x47, 0xE9, 0x29, 0x7A, 0x0A, 0xFF });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x3F3960, new byte[] { 0xC4, 0xC1, 0x7A, 0x11, 0x4C, 0xCA, 0x0C });
                    PS4.WriteMemory(processID, 0x134BF30, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 , 0x00, 0x00});
                }
            }
        }

        private void tglAttack_CheckedChanged(object sender)
        {
            if (attached)
                if (tglAttack.Checked == true)
                    PS4.WriteMemory(processID, 0x71E7BD, new byte[] { 0xC4, 0xC1, 0x7A, 0x11, 0x8C, 0x1F, 0x88, 0x00, 0x00, 0x00 });
                else
                    PS4.WriteMemory(processID, 0x71E7BD, new byte[] { 0xC4, 0xC1, 0x7A, 0x11, 0x84, 0x1F, 0x88, 0x00, 0x00, 0x00 });

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
                if (tglHealth.Checked == true)
                    PS4.WriteMemory(processID, 0x9CC779, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                else
                    PS4.WriteMemory(processID, 0x9CC779, new byte[] { 0xC5, 0xFA, 0x11, 0x57, 0x1C });

        }

        private void tglAmmo_CheckedChanged(object sender)
        {
            if (attached)
                if (tglAmmo.Checked == true)
                    PS4.WriteMemory(processID, 0x84B83F, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                else
                    PS4.WriteMemory(processID, 0x84B83F, new byte[] { 0x89, 0x83, 0x70, 0x03, 0x00, 0x00 });

        }

        private void tglVehicleHealth_CheckedChanged(object sender)
        {
            if (attached)
                if (tglVehicleHealth.Checked == true)
                    PS4.WriteMemory(processID, 0x9CC779, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                else
                    PS4.WriteMemory(processID, 0x9CC779, new byte[] { 0xC4, 0xC1, 0x7A, 0x11, 0x06 });

        }
    }
}
