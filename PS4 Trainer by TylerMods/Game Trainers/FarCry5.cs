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
    public partial class FarCry5 : UserControl
    {
        PS4RPC PS4 = main.PS4;
        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public FarCry5()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[0] == "CUSA05847" || Util.GameInfoArray()[1] == "1.00")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00");
            }

            Util.attachToGame("eboot.bin", "FarCry 5", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@6A9E958_3_302958+70+38+10+18+58+18+78+30", processID);
                byte[] money = BitConverter.GetBytes((int)numSP.Value);
                if (adr > 0)
                {
                    PS4.WriteMemory(processID, adr, money);
                }
                else { }
            }
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@67DA3F8_3_3E3F8+40+0+318+20+0+58+4C", processID);
                byte[] money = BitConverter.GetBytes((int)numMoney.Value);
                if (adr > 0)
                {
                    PS4.WriteMemory(processID, adr, money);
                }
                else {  }
            }
        }

        private void flatToggle1_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (flatToggle1.Checked == true)
                {
                    //PS4.WriteMemory(processID, 0x2A157F7, new byte[] { 0xC5, 0xFA, 0x10, 0x47, 0x1C, 0xC5, 0xFA, 0x11, 0x47, 0x18, 0x41, 0xB6, 0x00, 0x48, 0x8B, 0x7B, 0x50, 0x90, 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x2A157F7, new byte[] { 0xE9, 0x24, 0xEA, 0x7B, 0x02, 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x51D4220, new byte[] { 0x0F, 0x84, 0xB4, 0x17, 0x84, 0xFD, 0x84, 0xD2, 0xBE, 0xFF, 0xFF, 0xFF, 0xFF, 0x39, 0xB3, 0xB4, 0x01, 0x00, 0x00, 0x0F, 0x85, 0xC6, 0x15, 0x84, 0xFD, 0xE9, 0xC6, 0x15, 0x84, 0xFD });
                }
                else
                {
                    //PS4.WriteMemory(processID, 0x2A157F7, new byte[] { 0xE8, 0xB9, 0x42, 0xB4, 0xFD, 0xC5, 0xF8, 0x2E, 0x05, 0x59, 0xED, 0x92, 0x02, 0x48, 0x8B, 0x7B, 0x50, 0x41, 0x0F, 0x96, 0xC6 });
                    PS4.WriteMemory(processID, 0x2A157F7, new byte[] { 0x0F, 0x84, 0xD7, 0x01, 0x00, 0x00, 0x84, 0xD2 });
                    PS4.WriteMemory(processID, 0x51D4220, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }
            }

        }

        private void tglAmmo_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglAmmo.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x3a02297, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x180e7e5, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x3a02297, new byte[] { 0x44, 0x89, 0xbb, 0x88, 0x01, 0x00, 0x00 });
                    PS4.WriteMemory(processID, 0x180e7e5, new byte[] { 0x41, 0x89, 0x84, 0x24, 0x78, 0x03, 0x00, 0x00 });
                }
            }

        }

        private void tmrAmmo_Tick(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@69C25C0_3_2265C0+1D8+60+8+30+F20+BB8+98+188", processID);
                if (adr > 0)
                {
                    PS4.WriteInt32(processID, adr, 99);
                }
                else { }
            }

        }

        private void tglMoney_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglMoney.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x1515B20, new byte[] { 0xB8, 0xFF, 0xC9, 0x9A, 0x3B, 0x90, 0x90 });
                }
                else
                {
                    MessageBox.Show("Currently unable to turn this cheat off.");
                }
            }

        }

        private void tglPerk_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglPerk.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x35CAB9C, new byte[] { 0x44, 0x01, 0xBB, 0xD8, 0x00, 0x00, 0x00 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this cheat off.");
                    PS4.WriteMemory(processID, 0x35CAB9C, new byte[] { 0x44, 0x29, 0xBB, 0xD8, 0x00, 0x00, 0x00 });

                }
            }
        }

        private void tglRecoil_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglRecoil.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x3624B59, new byte[] { 0x90, 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x39FDFB0, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x3624B59, new byte[] { 0x44, 0x89, 0x68, 0x38 });
                    PS4.WriteMemory(processID, 0x39FDFB0, new byte[] { 0xC4, 0xC1, 0x7A, 0x11, 0x87, 0x1C, 0x01, 0x00, 0x00 });
                }
            }

        }
    }
}
