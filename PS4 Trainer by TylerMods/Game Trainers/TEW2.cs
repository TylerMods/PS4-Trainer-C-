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
    public partial class TEW2 : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public TEW2()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];
            if (Util.GameInfoArray()[1] == "01.00")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00");
            }

            Util.attachToGame("eboot.bin", "The Evil Within 2", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void tglSemiHandgunAmmo_CheckedChanged(object sender)
        {
            if (attached)
                if (tglSemiHandgunAmmo.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x15c2dcb, new byte[] { 0x41, 0x01, 0xda });
                    PS4.WriteMemory(processID, 0x15c3503, new byte[] { 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x15c352e, new byte[] { 0x90, 0x90, 0x90 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x15c2dcb, new byte[] { 0x41, 0x29, 0xda });
                    PS4.WriteMemory(processID, 0x15c3503, new byte[] { 0x89, 0x48, 0x10 });
                    PS4.WriteMemory(processID, 0x15c352e, new byte[] { 0x89, 0x70, 0x10 });
                }

        }


        private void btnHealth_Click(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@4A480D8_3_19D80D8+58C", processID);
                if (adr > 0)
                {
                    PS4.WriteSingle(processID, adr, 250);
                }

                else { }
            }
        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                //    if (tglHealth.Checked == true)
                //        PS4.WriteMemory(processID, 0x132af36, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                //    else
                //        PS4.WriteMemory(processID, 0x132af36, new byte[] { 0xc5, 0xfa, 0x11, 0x8f, 0xc4, 0x0b, 0x00, 0x00 });
                if (tglHealth.Checked)
                    if (cmbVersion.Text == "v1.00")
                    {
                        tmrHealth.Start();
                    }
                    else
                    {
                        tmrHealth.Stop();
                    }
            }
            if (cmbVersion.Text == "v1.04")
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x13284F6, new byte[8] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x13284F6, new byte[8] { 0xC5, 0xFA, 0x11, 0x8F, 0xCC, 0x0B, 0x00, 0x00 });
                }

            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numSyringe_Click(object sender, EventArgs e)
        {

        }

        private void flatLabel7_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numHerbs_Click(object sender, EventArgs e)
        {

        }

        private void flatLabel6_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flatLabel5_Click(object sender, EventArgs e)
        {

        }

        private void flatLabel4_Click(object sender, EventArgs e)
        {

        }

        private void btnSemiHandgunAmmo_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numGunpowder_Click(object sender, EventArgs e)
        {

        }

        private void flatLabel2_Click(object sender, EventArgs e)
        {

        }

        private void numWeaponParts_Click(object sender, EventArgs e)
        {

        }

        private void flatLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numGreenGel_Click(object sender, EventArgs e)
        {

        }

        private void flatLabel3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numKeys_Click(object sender, EventArgs e)
        {

        }

        private void flatLabel8_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flatLabel9_Click(object sender, EventArgs e)
        {

        }

        private void flatLabel10_Click(object sender, EventArgs e)
        {

        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this,
    "This does not max your item. What this does is, instead of subtracting item when using them, it adds instead. If you try to use 3, it will give 3 instead of taking 3.",
    "Help", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void tglHerbs_CheckedChanged(object sender)
        {
            if (attached)
                if (tglHealth.Checked == true)
                    PS4.WriteMemory(processID, 0x15c117d, new byte[] { 0x41, 0x01, 0x46, 0x10 });
                else
                    PS4.WriteMemory(processID, 0x15c117d, new byte[] { 0x41, 0x89, 0x46, 0x10 });
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this,
"This does not max your item. What this does is, instead of subtracting item when using them, it adds instead. If you try to use 3, it will give 3 instead of taking 3.",
"Help", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void tglGunpowder_CheckedChanged(object sender)
        {
            if (attached)
                if (cmbVersion.Text == "v1.00")
                {
                    if (tglGunpowder.Checked == true)
                    {
                        PS4.WriteMemory(processID, 0x15c117d, new byte[] { 0x41, 0x01, 0x4e, 0x10 });
                        PS4.WriteMemory(processID, 0x15C11AE, new byte[] { 0x41, 0x01, 0x46, 0x10 });
                    }
                    else
                    {
                        PS4.WriteMemory(processID, 0x15c117d, new byte[] { 0x41, 0x89, 0x46, 0x10 });
                        PS4.WriteMemory(processID, 0x15C11AE, new byte[] { 0x41, 0x89, 0x4E, 0x10 });
                    }
                }
            if (cmbVersion.Text == "v1.04")
            {
                    if (tglGunpowder.Checked == true)
                    {
                        PS4.WriteMemory(processID, 0x159F72D, new byte[8] { 0x66, 0x41, 0xC7, 0x44, 0x1C, 0x2C, 0xFF, 0xFF });
                    }
                    else
                    {
                        PS4.WriteMemory(processID, 0x159F72D, new byte[8] { 0x4C, 0x89, 0x30, 0x4D, 0x89, 0x6C, 0x1C, 0x2C });
                    }
            }
        }

        private void tmrHealth_Tick(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@4A480D8_3_19D80D8+58C", processID);
                if (adr > 0)
                {
                    PS4.WriteSingle(processID, adr, 250);
                }

                else { }
            }

        }

        private void tglWeaponParts_CheckedChanged(object sender)
        {
            if (attached)
                MessageBox.Show("PAY ATTENTION to your Weapon Parts count. If it gets too high, it'll go negative. Just get it to about 1  million and turn the cheat off!");
                if (tglWeaponParts.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x15bffe1, new byte[] { 0x01, 0x53, 0x10 });
                    PS4.WriteMemory(processID, 0x15c000f, new byte[] { 0x01, 0x43, 0x10 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x15bffe1, new byte[] { 0x89, 0x43, 0x10 });
                    PS4.WriteMemory(processID, 0x15c000f, new byte[] { 0x89, 0x53, 0x10 });
                }

        }

        private void tglGel_CheckedChanged(object sender)
        {

        }

        private void cmbVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVersion.Text == "v1.00")
            {
                pnlAmmo.Visible = true;
                pnlHealth.Visible = true;
                pnlComponents.Visible = true;
                pnlWeaponParts.Visible = true;
                pnlResistance.Visible = false;
            }
            if (cmbVersion.Text == "v1.04")
            {
                pnlAmmo.Visible = false;
                pnlHealth.Visible = true;
                pnlComponents.Visible = true;
                pnlWeaponParts.Visible = false;
                pnlResistance.Visible = true;
            }
        }

        private void tglResistance_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglResistance.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x14648DA, new byte[9] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x14648DA, new byte[9] { 0xC4, 0xCA, 0x7A, 0x11, 0x85, 0xE0, 0x17, 0x00, 0x00 });
                }
            }

        }

        private void TEW2_Load(object sender, EventArgs e)
        {
            pnlAmmo.Visible = false;
            pnlHealth.Visible = false;
            pnlComponents.Visible = false;
            pnlWeaponParts.Visible = false;
            pnlResistance.Visible = false;
        }
    }
}
