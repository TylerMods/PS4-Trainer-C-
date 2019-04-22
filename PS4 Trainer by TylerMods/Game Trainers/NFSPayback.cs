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
    public partial class NFSPayback : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public NFSPayback()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[0] == "CUSA05986" || Util.GameInfoArray()[1] == "01.00" || Util.GameInfoArray()[1] == "01.08")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}");
            }

            Util.attachToGame("eboot.bin", "Need for Speed Payback", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr1 = Util.GetPointerAdress("@450AE58_1_25EE58+60+68+48+0+48+10+28+78+58+8", processID);
                ulong adr2 = Util.GetPointerAdress("@505BF80_3_967F80+28+28+10+0+A8+D0+10+10+30+58+20+8+8+38+FFFFFFFFFFFFFFE8", processID);
                byte[] money = BitConverter.GetBytes((int)numMoney.Value);
                if (adr1 > 0)
                {
                    PS4.WriteMemory(processID, adr1, money);
                }
                if (adr2 > 0)
                {
                    PS4.WriteMemory(processID, adr2, money);
                }
                else {  }
            }
        }

        private void btnEXP_Click(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr1 = Util.GetPointerAdress("@4EBA210_3_726210+10+98+0+40+388+58+28+98+70+8", processID);
                ulong adr2 = Util.GetPointerAdress("@4EFA290_3_806290+98+68+20+10+30+0+58+10+50+0+108+10+3C8+48+10+58+28+98+70+8", processID);
                byte[] money = BitConverter.GetBytes((int)numEXP.Value);
                if (adr1 > 0)
                {
                    PS4.WriteMemory(processID, adr1, money);
                }
                if (adr2 > 0)
                {
                    PS4.WriteMemory(processID, adr2, money);
                }
                else {  }
            }

        }

        private void btnTokens_Click(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr1 = Util.GetPointerAdress("@4F22208_3_78E208+30+0+C8+D0+10+10+70+68+0+18", processID);
                ulong adr2 = Util.GetPointerAdress("@505BF80_3_967F80+28+0+10+0+A8+D0+10+0+48+10+28+68+68+0+18", processID);
                byte[] money = BitConverter.GetBytes((int)numTokens.Value);
                if (adr1 > 0)
                {
                    PS4.WriteMemory(processID, adr1, money);
                }
                if (adr2 > 0)
                {
                    PS4.WriteMemory(processID, adr2, money);
                }

                else {  }
            }
        }

        private void NFSPayback_Load(object sender, EventArgs e)
        {
            pnlSetEXP.Visible = false;
            pnlSetMoney.Visible = false;
            pnlSetTokens.Visible = false;
            pnlMoney.Visible = false;
            pnlTokens.Visible = false;
            pnlEXP.Visible = false;
            pnlNitrous.Visible = false;
        }

        private void cmbVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVersion.Text == "v1.00")
            {
                pnlSetEXP.Visible = true;
                pnlSetMoney.Visible = true;
                pnlSetTokens.Visible = true;
                pnlMoney.Visible = false;
                pnlTokens.Visible = false;
                pnlEXP.Visible = false;
                pnlNitrous.Visible = false;
            }
            if (cmbVersion.Text == "v1.08")
            {
                pnlSetEXP.Visible = false;
                pnlSetMoney.Visible = false;
                pnlSetTokens.Visible = false;
                pnlMoney.Visible = true;
                pnlTokens.Visible = true;
                pnlEXP.Visible = true;
                pnlNitrous.Visible = true;
            }
        }

        private void tglMoney_CheckedChanged(object sender)
        {
            if (!attached)
                return;
            if (tglMoney.Checked)
            {

                switch (cmbVersion.Text)
                {
                    case "v1.00":
                        PS4.WriteMemory(processID, 0x2d013bf, new byte[] { 0x41, 0x01, 0x1f });
                        break;
                    case "v1.08":
                        PS4.WriteMemory(processID, 0x2D013BF, new byte[] { 0xE8, 0x47, 0x9C, 0x5A, 0x01, 0x90, 0x90, 0x90, 0x90, 0x90 });
                        PS4.WriteMemory(processID, 0x42AB00B, new byte[] { 0xBB, 0x7F, 0x96, 0x98, 0x00, 0x41, 0x89, 0x1F, 0x48, 0x89, 0x8D, 0x58, 0xFD, 0xFF, 0xFF, 0xC3 });
                        break;
                }

            }
            else
            {

                switch (cmbVersion.Text)
                {
                    case "v1.00":
                        PS4.WriteMemory(processID, 0x2d013bf, new byte[] { 0x41, 0x89, 0x1f });
                        break;
                    case "v1.08":
                        PS4.WriteMemory(processID, 0x2D013BF, new byte[] { 0x41, 0x89, 0x1F, 0x48, 0x89, 0x8D, 0x58, 0xFD, 0xFF, 0xFF });
                        PS4.WriteMemory(processID, 0x42AB00B, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                        break;
                }

            }
        }

        private void tglTokens_CheckedChanged(object sender)
        {
            if (attached)
                //MessageBox.Show("PAY ATTENTION to your Weapon Parts count. If it gets too high, it'll go negative. Just get it to about 1  million and turn the cheat off!");
                if (tglTokens.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x2D5F43B, new byte[] { 0xE8, 0xC0, 0xBB, 0x54, 0x01 });
                    PS4.WriteMemory(processID, 0x42AB000, new byte[] { 0xB9, 0x41, 0x89, 0x4C, 0x24, 0x18, 0xC3 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x2D5F43B, new byte[] { 0x41, 0x89, 0x4C, 0x24, 0x18 });
                    PS4.WriteMemory(processID, 0x42AB000, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00});
                }

        }

        private void tglEXP_CheckedChanged(object sender)
        {
            if (attached)
                //MessageBox.Show("PAY ATTENTION to your Weapon Parts count. If it gets too high, it'll go negative. Just get it to about 1  million and turn the cheat off!");
                if (tglEXP.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x2dac30a, new byte[] { 0x44, 0x01, 0x73, 0x08 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x2dac30a, new byte[] { 0x44, 0x89, 0x73, 0x08 });
                }

        }

        private void tglNitrous_CheckedChanged(object sender)
        {
            if (attached)
                if (tglNitrous.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x2805FF9, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x280582B, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x2805FF9, new byte[] { 0xC4, 0xC1, 0x7A, 0x11, 0x85, 0x14, 0x02, 0x00, 0x00 });
                    PS4.WriteMemory(processID, 0x280582B, new byte[] { 0xC4, 0xC1, 0x7A, 0x11, 0x85, 0x14, 0x02, 0x00, 0x00 });
                }

        }

        private void pnlTokens_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
