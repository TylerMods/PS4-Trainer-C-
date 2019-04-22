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
    public partial class ACOrigins : UserControl
    {
        PS4RPC PS4 = main.PS4;
        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public ACOrigins()
        {
            InitializeComponent();
        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
                if (tglHealth.Checked == true)
                    PS4.WriteMemory(processID, 0x3950c06, new byte[] { 0x01, 0x8F, 0xD4 });
                else
                    PS4.WriteMemory(processID, 0x3950c06, new byte[] { 0x89, 0x8F, 0xD4 });

            //if (tglHealth.Checked)
            //    tmrHealth.Start();
            //else
            //    tmrHealth.Stop();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];
            if (Util.GameInfoArray()[1] == "01.00" || Util.GameInfoArray()[1] == "01.41")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00 or v01.41");
            }
            Util.attachToGame("eboot.bin", "Assassins Creed Origins", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void tmrHealth_Tick(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@7997068_3_9E7068+18+8+5D8+18+30+8+48+10+18+D4", processID);
                byte[] money = BitConverter.GetBytes(999);
                if (adr > 0)
                {
                    PS4.WriteMemory(processID, adr, money);
                }
                else {  }
            }
        }

        private void btnEXP_Click(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@7892198_3_8E2198+D8+160+10+158+BE8+168+0+114", processID);
                byte[] money = BitConverter.GetBytes((int)numEXP.Value);
                if (adr > 0)
                {
                    PS4.WriteMemory(processID, adr, money);
                }
                else {  }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCheaters_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this,
    "1. Weysincha" +
    "\n2. ChendoChap" +
    "\n3. TylerMods",
    "Credits", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void tglAmmo_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (cmbVersion.Text == "v1.00")
                {
                    if (tglAmmo.Checked)
                    {
                        PS4.WriteMemory(processID, 0x37659C3, new byte[] { 0x90, 0x90, 0x90, 0x90 });
                    }
                    else
                    {
                        PS4.WriteMemory(processID, 0x37659C3, new byte[] { 0x43, 0x89, 0x04, 0x37 });
                    }
                }
                if (cmbVersion.Text == "v1.41")
                {
                    if (tglAmmo.Checked)
                    {
                        PS4.WriteMemory(processID, 0x25b933b, new byte[] { 0x90, 0X90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                    }
                    else
                    {
                        PS4.WriteMemory(processID, 0x25b933b, new byte[] { 0x45, 0x89, 0xb5, 0xc8, 0x00, 0x00, 0x00 });
                    }

                }
            }

        }

        private void cmbVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVersion.Text == "v1.00")
            {
                pnlHealth.Visible = false;
                pnlAmmo.Visible = true;
                pnlEXP.Visible = false;
                pnlMoney.Visible = false;
                pnlAbilityPoints.Visible = false;
            }
            if (cmbVersion.Text == "v1.41")
            {
                pnlHealth.Visible = true;
                pnlAmmo.Visible = false;
                pnlEXP.Visible = true;
                pnlMoney.Visible = true;
                pnlAbilityPoints.Visible = true;
            }

        }

        private void ACOrigins_Load(object sender, EventArgs e)
        {
            if (cmbVersion.Text == "")
            {
                pnlHealth.Visible = false;
                pnlAmmo.Visible = false;
                pnlEXP.Visible = false;
                pnlMoney.Visible = false;
                pnlAbilityPoints.Visible = false;
            }
        }

        private void tglMoney_CheckedChanged(object sender)
        {
            if (attached)
                if (tglMoney.Checked == true)
                    PS4.WriteMemory(processID, 0x3e3c991, new byte[] { 0x01, 0x08 });
                else
                    PS4.WriteMemory(processID, 0x3e3c991, new byte[] { 0x89, 0x08 });

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tglAbilityPoints_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglAbilityPoints.Checked)
                {
                    PS4.WriteMemory(processID, 0x37ADABE, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x37ADABE, new byte[] { 0x41, 0x01, 0x8D, 0x90, 0x02, 0x00, 0x00 });
                }
            }

        }
    }
}
