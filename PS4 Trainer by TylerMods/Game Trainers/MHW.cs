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
    public partial class MHW : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public MHW()
        {
            InitializeComponent();
            cmbVersion.SelectedIndex = 0;
        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, processEntry + 0x2A03F6C, new byte[5] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    PS4.WriteMemory(processID, processEntry + 0x2A03F6C, new byte[5] { 0xC5, 0xFA, 0x11, 0x48, 0x64 });
                }
            }
        }
            private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[0] == "CUSA07708" || Util.GameInfoArray()[0] == "CUSA07713" || Util.GameInfoArray()[1] == "1.00" || Util.GameInfoArray()[1] == "2.00")
            {
                
            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00 or v02.00");
            }
            Util.attachToGame("eboot.bin", "Monster Hunter World", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void LowHealthBooster()
        {
            float current, max = 500.0f;
            ulong adr = cmbVersion.Text == "CUSA07708" ? Util.GetPointerAdress("@523E5C8_3_F765C8+7A0+148+0+8F0+10+10+8+64", processID) : Util.GetPointerAdress("@53F0998_3_F7C998+C90+8B8+108+8+25C", processID);
            if (adr > 0)
            {
                current = PS4.ReadSingle(processID, adr);
                double per = (double)current / max;
                int _per = Convert.ToInt16(per * 100);
                if (_per <= 25)
                    PS4.WriteSingle(processID, adr, max);
            }
        }
        private void tmrHealth_Tick(object sender, EventArgs e)
        {
            if (attached)
            {
                //LowHealthBooster();
                if (cmbVersion.Text == "CUSA07708")
                {
                    ulong adr = Util.GetPointerAdress("@523E5C8_3_F765C8+7A0+148+0+8F0+10+10+8+64", processID);
                    if (adr > 0)
                    {
                        PS4.WriteSingle(processID, adr, 500);
                    }
                    else { }
                }
                if (cmbVersion.Text == "CUSA07713")
                {
                    ulong adr = Util.GetPointerAdress("@53F0998_3_F7C998+C90+8B8+108+8+25C", processID);
                    float adrget = PS4.ReadSingle(processID, adr);
                    if (adr > 0 && adrget <= 200)
                    {
                        PS4.WriteSingle(processID, adr, 500);
                    }
                    else { }
                }
            }
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            if (attached)
            {
                if (cmbVersion.Text == "v1.00")
                {
                    ulong adr = Util.GetPointerAdress("@4424C90_3_15CC90+10+10+10+10+10+40+60+6C", processID);
                    byte[] money = BitConverter.GetBytes((int)numMoney.Value);
                    if (adr > 0)
                    {
                        PS4.WriteMemory(processID, adr, money);
                    }
                    else {  }
                }
                if (cmbVersion.Text == "v2.00")
                {
                    ulong adr = Util.GetPointerAdress("@45D6C40_3_162C40+60+6C", processID);
                    byte[] money = BitConverter.GetBytes((int)numMoney.Value);
                    if (adr > 0)
                    {
                        PS4.WriteMemory(processID, adr, money);
                    }
                    else {  }
                }
            }
        }

        private void MHW_Load(object sender, EventArgs e)
        {

        }

        private void cmbCUSA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVersion.Text == "v1.00")
            {
                pnlHealth.Visible = false;
                pnlStamina.Visible = false;
                pnlRP.Visible = false;
                pnlDamage.Visible = false;
                pnlItems.Visible = false;
                pnlMoney200.Visible = false;
                pnlDupMaterials.Visible = false;
                pnlInfMaterials.Visible = false;
            }
            if (cmbVersion.Text == "v2.00")
            {
                pnlHealth.Visible = true;
                pnlStamina.Visible = true;
                pnlRP.Visible = true;
                pnlDamage.Visible = true;
                pnlItems.Visible = true;
                pnlMoney200.Visible = true;
                pnlDupMaterials.Visible = true;
                pnlInfMaterials.Visible = true;

            }
        }

        private void cmbVersion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRP_Click(object sender, EventArgs e)
        {
            if (attached)
            {            
                    ulong adr = Util.GetPointerAdress("@45D6C40_3_162C40+60+70", processID);
                    byte[] money = BitConverter.GetBytes((int)numRP.Value);
                    if (adr > 0)
                    {
                        PS4.WriteMemory(processID, adr, money);
                    }
                    else {  }
            }
        }

        private void tmrStamina_Tick(object sender, EventArgs e)
        {
            if (attached)
            {
                    ulong adr = Util.GetPointerAdress("@53F0998_3_F7C998+880+98+6C", processID);
                    if (adr > 0)
                    {
                        PS4.WriteSingle(processID, adr, 150);
                    }
                    else {  }
            }
        }

        private void tglStamina_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglStamina.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x2BB4E6F, new byte[5] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x2BB4E6F, new byte[5] { 0xC5, 0xFA, 0x11, 0x43, 0x6C });
                }
            }
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this,
    "1. PS4 Guru" +
    "\n2. Darkmage1991" +
    "\n3. inotcheese " +
    "\n4. TylerMods",
    "Credits", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void tglDamage_CheckedChanged(object sender)
        {
            if (tglDamage.Checked)
                tmrDamage.Start();
            else
                tmrDamage.Stop();
        }

        private void tmrDamage_Tick(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr1 = Util.GetPointerAdress("@4500EA0_3_8CEA0+28+19A8+58+1AC", processID);
                ulong adr2 = Util.GetPointerAdress("@4500EA0_3_8CEA0+28+19A8+58+37C", processID);
                ulong adr3 = Util.GetPointerAdress("@4500EA0_3_8CEA0+40+8+19A8+58+38C", processID);
                byte[] money = BitConverter.GetBytes(69);
                if (adr1 > 0)
                {
                    PS4.WriteMemory(processID, adr1, money);
                }
                if (adr2 > 0)
                {
                    PS4.WriteMemory(processID, adr2, money);
                }

                if (adr2 > 0)
                {
                    PS4.WriteMemory(processID, adr3, money);
                }

                else {  }
            }

        }

        private void tglMoney_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglMoney.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x1793AB6, new byte[1] { 0x01 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x1793AB6, new byte[1] { 0x89 });
                }
            }

        }

        private void flatToggle1_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (flatToggle1.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x20FFE49, new byte[3] { 0x90, 0x90, 0x90 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x20FFE49, new byte[3] { 0x89, 0x5E, 0x0C });
                }
            }

        }

        private void lblVersion_Click(object sender, EventArgs e)
        {

        }

        private void tglDuplicateItems_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglDuplicateItems.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x20FFE49, new byte[3] { 0x01, 0x5E, 0x0C });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x20FFE49, new byte[3] { 0x89, 0x5E, 0x0C });
                }
            }


        }

        private void tglInfMaterials_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglInfMaterials.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x20FFd24, new byte[] { 0x90, 0x90 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x20FFd24, new byte[] { 0x89, 0x1e });
                }
            }
        }

        private void tglDupMaterials_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglDupMaterials.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x20FFd24, new byte[] { 0x01, 0x1e });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x20FFd24, new byte[] { 0x89, 0x1E });
                }
            }
        }
    }
}
