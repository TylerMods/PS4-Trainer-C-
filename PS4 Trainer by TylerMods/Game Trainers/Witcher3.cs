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
    public partial class Witcher3 : UserControl
    {
        PS4RPC PS4 = main.PS4;
        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public Witcher3()
        {
            InitializeComponent();
            pnl100EXP.Visible = false;
            pnl100Health.Visible = false;
            pnl100SkillPoints.Visible = false;
            pnlx2Items100.Visible = false;
            pnlMaster.Visible = false;
            pnlEasyKill150.Visible = false;
            pnlAdrenaline150.Visible = false;
            pnlHealth150.Visible = false;
            pnlHorsePanic150.Visible = false;
            pnlHorseRun150.Visible = false;
            pnlMoney150.Visible = false;
            pnlOxygen150.Visible = false;
            pnlStamina150.Visible = false;
            pnlToxic150.Visible = false;
            pnlWeight150.Visible = false;

        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[0] == "CUSA05725" || Util.GameInfoArray()[1] == "1.00" || Util.GameInfoArray()[1] == "1.50" || Util.GameInfoArray()[0] == "CUSA05574")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00");
            }

            Util.attachToGame("eboot.bin", "The Witcher 3 : Game of The Year", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void btnHealth_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Infinite Health. \n Infinite Stamina. \n Infinite Roach Stamina. \n Infinite Breath Under Water. \n Unlimited IGNI, QUEN, AXII, AARD.");
        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
                if (tglHealth.Checked == true)
                    PS4.WriteMemory(processID, 0x10294ED, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x83, 0xFB, 0x06 });
                else
                    MessageBox.Show("Currently unable to turn this feature off.");

            //    PS4.WriteMemory(processID, 0x10294ED, new byte[] { 0x89, 0x43, 0x06 });

        }

        private void tglItems_CheckedChanged(object sender)
        {
            if (attached)
                if (tglItems.Checked == true)
                    PS4.WriteMemory(processID, 0xA66912, new byte[] { 0x03, 0x55, 0xAC, 0x76, 0x16, 0x48, 0x8D, 0x44 });
                else
                    MessageBox.Show("Currently unable to turn this feature off.");

            //    PS4.WriteMemory(processID, 0xA66912, new byte[] { 0x89, 0x43, 0x06 });

        }

        private void btnEXP_Click(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@32A53E8_3_4893E8+30+98+48+110+70+110+90+40+20+FFFFFFFFFFFFFFF8", processID);
                byte[] money = BitConverter.GetBytes((int)numEXP.Value);
                if (adr > 0)
                {
                    PS4.WriteMemory(processID, adr, money);
                }
                else { }
            }

        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@32A9530_3_48D530+110+90+40+20+FFFFFFFFFFFFFFF0", processID);
                byte[] money = BitConverter.GetBytes((int)numSP.Value);
                if (adr > 0)
                {
                    PS4.WriteMemory(processID, adr, money);
                }
                else { }
            }

        }

        private void cmbVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVersion.Text == "v1.00")
            {
                lblCUSA.Text = "CUSA05725";
                pnl100EXP.Visible = true;
                pnl100Health.Visible = true;
                pnl100SkillPoints.Visible = true;
                pnlx2Items100.Visible = true;
                pnlMaster.Visible = false;
                pnlEasyKill150.Visible = false;
                pnlAdrenaline150.Visible = false;
                pnlHealth150.Visible = false;
                pnlHorsePanic150.Visible = false;
                pnlHorseRun150.Visible = false;
                pnlMoney150.Visible = false;
                pnlOxygen150.Visible = false;
                pnlStamina150.Visible = false;
                pnlToxic150.Visible = false;
                pnlWeight150.Visible = false;
            }
            if (cmbVersion.Text == "v1.50")
            {
                lblCUSA.Text = "CUSA05574";
                pnl100EXP.Visible = false;
                pnl100Health.Visible = false;
                pnl100SkillPoints.Visible = false;
                pnlx2Items100.Visible = false;
                pnlMaster.Visible = true;
                pnlEasyKill150.Visible = true;
                pnlAdrenaline150.Visible = true;
                pnlHealth150.Visible = true;
                pnlHorsePanic150.Visible = true;
                pnlHorseRun150.Visible = true;
                pnlMoney150.Visible = true;
                pnlOxygen150.Visible = true;
                pnlStamina150.Visible = true;
                pnlToxic150.Visible = true;
                pnlWeight150.Visible = true;
            }
        }

        private void tglMaster_CheckedChanged(object sender)
        {
            if (attached)
                //MessageBox.Show("PAY ATTENTION to your Weapon Parts count. If it gets too high, it'll go negative. Just get it to about 1  million and turn the cheat off!");
                if (tglMaster.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x28F3800, new byte[] { 0x83, 0x79, 0x20, 0x03, 0x74, 0x0E, 0x83, 0x79, 0x20, 0x07, 0x74, 0x23, 0x83, 0x79, 0x20, 0x05, 0x74, 0x29, 0xEB, 0x41, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0xEB, 0x26, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0xEB, 0x1A, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0xEB, 0x06, 0xC5, 0xFA, 0x10, 0x44, 0x81, 0x04, 0xC5, 0xFA, 0x11, 0x04, 0x81, 0x83, 0xFB, 0x06, 0x0F, 0x85, 0xD3, 0xAB, 0xC0, 0xFE, 0xE9, 0xB9, 0xAB, 0xC0, 0xFE });
                    PS4.WriteMemory(processID, 0x14FE41A, new byte[] { 0xE9, 0xE1, 0x53, 0x3F, 0x01 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x28F3800, new byte[] { 0x83, 0x79, 0x20, 0x03, 0x74, 0x0E, 0x83, 0x79, 0x20, 0x07, 0x74, 0x23, 0x83, 0x79, 0x20, 0x05, 0x74, 0x29, 0xEB, 0x41, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0xEB, 0x26, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0xEB, 0x1A, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0xEB, 0x06, 0xC5, 0xFA, 0x10, 0x44, 0x81, 0x04, 0xC5, 0xFA, 0x11, 0x04, 0x81, 0x83, 0xFB, 0x06, 0x0F, 0x85, 0xD3, 0xAB, 0xC0, 0xFE, 0xE9, 0xB9, 0xAB, 0xC0, 0xFE });
                    PS4.WriteMemory(processID, 0x14FE41A, new byte[] { 0xC5, 0xFA, 0x11, 0x04, 0x81 });
                }

        }

        private void tglHealth150_CheckedChanged(object sender)
        {
            if (attached)
                //MessageBox.Show("PAY ATTENTION to your Weapon Parts count. If it gets too high, it'll go negative. Just get it to about 1  million and turn the cheat off!");
                if (tglHealth150.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x28F3814, new byte[] { 0x83, 0xF8, 0x00, 0x74, 0x36 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x28F3814, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
        }

        private void tglEasyKill150_CheckedChanged(object sender)
        {
            if (attached)
                //MessageBox.Show("PAY ATTENTION to your Weapon Parts count. If it gets too high, it'll go negative. Just get it to about 1  million and turn the cheat off!");
                if (tglEasyKill150.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x28F383B, new byte[] { 0x81, 0x3C, 0x81, 0x00, 0x00, 0xF0, 0x38, 0x74, 0x11, 0xC7, 0x04, 0x81, 0x00, 0x00, 0xF0, 0x38, 0xEB, 0x0D });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x28F383B, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
        }

        private void tglStamina150_CheckedChanged(object sender)
        {
            if (attached)
                //MessageBox.Show("PAY ATTENTION to your Weapon Parts count. If it gets too high, it'll go negative. Just get it to about 1  million and turn the cheat off!");
                if (tglStamina150.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x28F3819, new byte[] { 0x83, 0xF8, 0x03, 0x74, 0x31 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x28F3819, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                }

        }

        private void tglToxic150_CheckedChanged(object sender)
        {
            if (attached)
                //MessageBox.Show("PAY ATTENTION to your Weapon Parts count. If it gets too high, it'll go negative. Just get it to about 1  million and turn the cheat off!");
                if (tglToxic150.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x28F381E, new byte[] { 0x83, 0xF8, 0x05, 0x74, 0x37 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x28F381E, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
        }

        private void tglAdrenaline150_CheckedChanged(object sender)
        {
            if (attached)
                //MessageBox.Show("PAY ATTENTION to your Weapon Parts count. If it gets too high, it'll go negative. Just get it to about 1  million and turn the cheat off!");
                if (tglAdrenaline150.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x28F3823, new byte[] { 0x83, 0xF8, 0x09, 0x74, 0x27 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x28F3823, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
        }

        private void tglOxygen150_CheckedChanged(object sender)
        {
            if (attached)
                //MessageBox.Show("PAY ATTENTION to your Weapon Parts count. If it gets too high, it'll go negative. Just get it to about 1  million and turn the cheat off!");
                if (tglOxygen150.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x28F3828, new byte[] { 0x83, 0xF8, 0x0C, 0x74, 0x22 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x28F3828, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
        }

        private void tglHorseRun150_CheckedChanged(object sender)
        {
            if (attached)
                //MessageBox.Show("PAY ATTENTION to your Weapon Parts count. If it gets too high, it'll go negative. Just get it to about 1  million and turn the cheat off!");
                if (tglHorseRun150.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x28F382F, new byte[] { 0x83, 0xF8, 0x03, 0x74, 0x1B });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x28F382F, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
        }

        private void tglHorsePanic150_CheckedChanged(object sender)
        {
            if (attached)
                //MessageBox.Show("PAY ATTENTION to your Weapon Parts count. If it gets too high, it'll go negative. Just get it to about 1  million and turn the cheat off!");
                if (tglHorsePanic150.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x28F3834, new byte[] { 0x83, 0xF8, 0x06, 0x74, 0x16 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x28F3834, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
        }

        private void tglMoney150_CheckedChanged(object sender)
        {
            if (attached)
                //MessageBox.Show("PAY ATTENTION to your Weapon Parts count. If it gets too high, it'll go negative. Just get it to about 1  million and turn the cheat off!");
                if (tglMoney150.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x28F3868, new byte[] { 0x48, 0x83, 0xFA, 0x2D, 0x74, 0x0A, 0x44, 0x01, 0xE0, 0x89, 0x01, 0xE9, 0xFA, 0xAB, 0x3B, 0xFE, 0xC7, 0x01, 0x3F, 0x42, 0x0F, 0x00, 0xE9, 0xEF, 0xAB, 0x3B, 0xFE });
                    PS4.WriteMemory(processID, 0xCAE46D, new byte[] { 0xE9, 0xF6, 0x53, 0xC4, 0x01 });
                    PS4.WriteMemory(processID, 0x28F3883, new byte[] { 0x41, 0x83, 0xFC, 0x2D, 0x74, 0x05, 0xE9, 0x66, 0xB3, 0x3B, 0xFE, 0xC7, 0x00, 0x3F, 0x42, 0x0F, 0x00, 0xE9, 0x5B, 0xB3, 0x3B, 0xFE });
                    PS4.WriteMemory(processID, 0xCAEB5C, new byte[] { 0xE9, 0x22, 0x4D, 0xC4, 0x01 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x28F3868, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                    PS4.WriteMemory(processID, 0xCAE46D, new byte[] { 0x44, 0x01, 0xE0, 0x89, 0x01 });
                    PS4.WriteMemory(processID, 0x28F3883, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                    PS4.WriteMemory(processID, 0xCAEB5C, new byte[] { 0xE9, 0x93, 0x00, 0x00, 0x00 });
                }

        }

        private void tglWeight150_CheckedChanged(object sender)
        {
            if (attached)
                //MessageBox.Show("PAY ATTENTION to your Weapon Parts count. If it gets too high, it'll go negative. Just get it to about 1  million and turn the cheat off!");
                if (tglWeight150.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x28F3899, new byte[] { 0x48, 0x83, 0xFB, 0x00, 0x74, 0x0C, 0xC4, 0x81, 0x7A, 0x10, 0x4C, 0xE7, 0x0C, 0xE9, 0x03, 0x70, 0x75, 0xFE, 0x43, 0xC7, 0x44, 0xE7, 0x0C, 0xF0, 0x23, 0x74, 0x49, 0x43, 0xC7, 0x44, 0xE7, 0x10, 0xF0, 0x23, 0x74, 0x49, 0xE9, 0xEC, 0x6F, 0x75, 0xFE });
                    PS4.WriteMemory(processID, 0x104A8A7, new byte[] { 0xE9, 0xED, 0x8F, 0x8A, 0x01, 0x90, 0x90 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x28F3899, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                    PS4.WriteMemory(processID, 0x104A8A7, new byte[] { 0xC4, 0x81, 0x7A, 0x10, 0x4C, 0xE7, 0x0C });
                }
        }
    }
}
