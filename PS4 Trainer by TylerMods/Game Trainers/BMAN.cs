﻿using System;
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
    public partial class BMAN : UserControl
    {
        PS4RPC PS4 = main.PS4;
        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public BMAN()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];
            if (Util.GameInfoArray()[0] == "CUSA00135" || Util.GameInfoArray()[1] == "01.14")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.14");
            }
            Util.attachToGame("eboot.bin", "Batman Arkham Knight", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xB507DF, new byte[] { 0xE9, 0x1D, 0xF4, 0xFF, 0x01, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x2B4FC01, new byte[] { 0x66, 0x41, 0x81, 0x7F, 0x64, 0x2B, 0x02, 0x0F, 0x85, 0x09, 0x00, 0x00, 0x00, 0x48, 0x8B, 0x4D, 0xC0, 0xE9, 0xCF, 0x0B, 0x00, 0xFE, 0x41, 0x89, 0x07, 0x90, 0x48, 0x8B, 0x4D, 0xC0, 0xE9, 0xC2, 0x0B, 0x00, 0xFE });
                }
                else
                {
                    PS4.WriteMemory(processID, 0xB507DF, new byte[] { 0x41, 0x89, 0x07, 0x48, 0x8B, 0x4D, 0xC0 });
                    PS4.WriteMemory(processID, 0x2B4FC01, new byte[] { 0x66, 0x41, 0x81, 0x7F, 0x64, 0x2B, 0x02, 0x0F, 0x85, 0x09, 0x00, 0x00, 0x00, 0x48, 0x8B, 0x4D, 0xC0, 0xE9, 0xCF, 0x0B, 0x00, 0xFE, 0x41, 0x89, 0x07, 0x90, 0x48, 0x8B, 0x4D, 0xC0, 0xE9, 0xC2, 0x0B, 0x00, 0xFE });
                }
            }

        }

        private void btnWeynetech_Click(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@7F780760_2_A5C760+10+618+38+2A8+2A8+38+58+A0+608+3F8", processID);
                byte[] money = BitConverter.GetBytes((int)numWaynetech.Value);
                if (adr > 0)
                {
                    PS4.WriteMemory(processID, adr, money);
                }
                else { }
            }

        }

        private void tgl1Hit_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tgl1Hit.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xB507DF, new byte[] { 0xE9, 0x1D, 0xF4, 0xFF, 0x01, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x2B4FC01, new byte[] { 0x66, 0x41, 0x81, 0x7F, 0x64, 0x2B, 0x02, 0x0F, 0x85, 0x09, 0x00, 0x00, 0x00, 0x48, 0x8B, 0x4D, 0xC0, 0xE9, 0xCF, 0x0B, 0x00, 0xFE, 0x41, 0xC6, 0x07, 0x00, 0x48, 0x8B, 0x4D, 0xC0, 0xE9, 0xC2, 0x0B, 0x00, 0xFE });
                }
                else
                {
                    PS4.WriteMemory(processID, 0xB507DF, new byte[] { 0xE9, 0x1D, 0xF4, 0xFF, 0x01, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x2B4FC01, new byte[] { 0x66, 0x41, 0x81, 0x7F, 0x64, 0x2B, 0x02, 0x0F, 0x85, 0x09, 0x00, 0x00, 0x00, 0x48, 0x8B, 0x4D, 0xC0, 0xE9, 0xCF, 0x0B, 0x00, 0xFE, 0x41, 0x89, 0x07, 0x90, 0x48, 0x8B, 0x4D, 0xC0, 0xE9, 0xC2, 0x0B, 0x00, 0xFE });
                }
            }

        }

        private void tglSkills_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglSkills.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xB507DF, new byte[] { 0xE9, 0x1D, 0xF4, 0xFF, 0x01, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x2B4FC01, new byte[] { 0x66, 0x41, 0x81, 0x7F, 0x64, 0x2B, 0x02, 0xF8, 0x50, 0x90, 0x00, 0x00, 0x00, 0x48, 0x8B, 0x4D, 0xC0, 0xE9, 0xCF, 0x0B, 0x00, 0xFE, 0x66, 0x41, 0x81, 0x7F, 0x64, 0x02, 0x00, 0x0F, 0x85, 0x0D, 0x00, 0x00, 0x00, 0x48, 0x8B, 0x4D, 0xC0, 0x41, 0xC6, 0x07, 0xFF, 0xE9, 0xB5, 0x0B, 0x00, 0xFE, 0x41, 0x89, 0x07, 0x48, 0x8B, 0x4D, 0xC0, 0xE9, 0xA9, 0x0B, 0x00, 0xFE });
                }
                else
                {
                    PS4.WriteMemory(processID, 0xB507DF, new byte[] { 0xE9, 0x1D, 0xF4, 0xFF, 0x01, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x2B4FC01, new byte[] { 0x66, 0x41, 0x81, 0x7F, 0x64, 0x2B, 0x02, 0x0F, 0x85, 0x09, 0x00, 0x00, 0x00, 0x48, 0x8B, 0x4D, 0xC0, 0xE9, 0xCF, 0x0B, 0x00, 0xFE, 0x41, 0x89, 0x07, 0x90, 0x48, 0x8B, 0x4D, 0xC0, 0xE9, 0xC2, 0x0B, 0x00, 0xFE, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }
            }
        }
    }
}
