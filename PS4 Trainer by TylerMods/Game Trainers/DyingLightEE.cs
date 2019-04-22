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
    public partial class DyingLightEE : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public DyingLightEE()
        {
            InitializeComponent();
            pnlAmmo.Visible = false;
            pnlBuyToEarn.Visible = false;
            pnlGrappling.Visible = false;
            pnlHealth.Visible = false;
            pnlNoItemDecrease.Visible = false;
            pnlScramble.Visible = false;
            pnlSkills.Visible = false;
            pnlWallHack.Visible = false;
            pnlWeaponDur.Visible = false;
            pnlWeather.Visible = false;
            pnlFuel.Visible = false;
            pnlNitrous.Visible = false;
            pnlUV.Visible = false;
            pnlVehicleUpgrade.Visible = false;
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];
            if (Util.GameInfoArray()[1] == "01.00" || Util.GameInfoArray()[1] == "01.06")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00");
            }

            Util.attachToGame("eboot.bin", "Dying Light : Enhanced Edition", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void btnSkills_Click(object sender, EventArgs e)
        {
            if (attached)
            {
                //ulong survivor = Util.GetPointerAdress("@2893BA8_1_4D3BA8+0+40+98", processID);
                //ulong agility = Util.GetPointerAdress("@2893BA8_1_4D3BA8+0+40+38", processID);
                //ulong power = Util.GetPointerAdress("@2893BA8_1_4D3BA8+0+40+68", processID);
                //ulong legend = Util.GetPointerAdress("@2893BA8_1_4D3BA8+0+40+F8", processID);
                PS4.WriteMemory(processID, 0xEE36BA, new byte[] { 0x4C, 0x01, 0xF9 });
                //if (survivor > 0)
                //{
                //    PS4.WriteInt32(processID, survivor, 2000000);
                //}
                //if (agility > 0)
                //{
                //    PS4.WriteInt32(processID, survivor, 259800);
                //}
                //if (power > 0)
                //{
                //    PS4.WriteInt32(processID, survivor, 856050);
                //}
                //if (legend > 0)
                //{
                //    PS4.WriteInt32(processID, survivor, 789230000);
                //}
                //else { }
            }
        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (cmbVersion.Text == "v1.00")
                    {
                    if (tglHealth.Checked == true)
                    {
                        PS4.WriteMemory(processID, 0xf86dc9, new byte[] { 0x44, 0x01, 0xF8 });
                    }
                    else
                    {
                        PS4.WriteMemory(processID, 0xf86dc9, new byte[] { 0x44, 0x29, 0xF8 });
                    }
                }
                 if (cmbVersion.Text == "v1.06")
                    {
                    if (tglHealth.Checked == true)
                    {
                        PS4.WriteMemory(processID, 0xFCE7E2, new byte[] { 0xE9, 0x9E, 0x3C, 0xFD, 0x00, 0x90, 0x90, 0x90, 0x90 });
                        PS4.WriteMemory(processID, 0x1fa2485, new byte[] { 0x41, 0xC7, 0x45, 0x3C, 0x60, 0xB7, 0x47, 0x00, 0xE8, 0x9E, 0x04, 0x7C, 0xFE, 0xE9, 0x54, 0xC3, 0x02, 0xFF });
                    }
                    else
                    {
                        PS4.WriteMemory(processID, 0xFCE7E2, new byte[] { 0x41, 0x89, 0x4D, 0x3C, 0xE8, 0x45, 0x41, 0x79, 0xFF });
                        PS4.WriteMemory(processID, 0x1fa2485, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                    }
                }
            }
        }


        private void flatToggle3_CheckedChanged(object sender)
        {
            var cusa = Util.GameInfoArray()[0];
            if (attached)
            {
                if (cmbVersion.Text == "v1.00")
                {
                    if (cusa == "CUSA03991")
                    {
                        if (flatToggle3.Checked == true)
                            PS4.WriteMemory(processID, 0xE659DE, new byte[] { 0xc5, 0xfa, 0x11, 0x93, 0xf4, 0x11, 0x00, 0x00 });
                        else
                            PS4.WriteMemory(processID, 0xE659DE, new byte[] { 0xc5, 0xfa, 0x11, 0x83, 0xf4, 0x11, 0x00, 0x00 });
                    }
                    if (cusa == "CUSA00078")
                    {
                        if (flatToggle3.Checked == true)
                            PS4.WriteMemory(processID, 0xcfecee, new byte[] { 0xc5, 0xfa, 0x11, 0x93, 0x60, 0x11, 0x00, 0x00 });
                        else
                            PS4.WriteMemory(processID, 0xcfecee, new byte[] { 0xc5, 0xfa, 0x11, 0x83, 0x60, 0x11, 0x00, 0x00 });
                    }
                }
                if (cmbVersion.Text == "v1.06")
                {
                    if (flatToggle3.Checked == true)
                        PS4.WriteMemory(processID, 0xEA54D6, new byte[] { 0xC5, 0xFA, 0x11, 0x93, 0x04, 0x12, 0x00, 0x00 });
                    else
                        PS4.WriteMemory(processID, 0xEA54D6, new byte[] { 0xC5, 0xFA, 0x11, 0x83, 0x04, 0x12, 0x00, 0x00 });

                }
            }
        }

        private void flatToggle2_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (cmbVersion.Text == "v1.00")
                {
                    if (flatToggle2.Checked == true)
                        {
                        PS4.WriteMemory(processID, 0x9FCF76, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                    }
                    else
                    {
                        PS4.WriteMemory(processID, 0x9FCF76, new byte[] { 0xc5, 0xfa, 0x11, 0x43, 0x04 });
                    }
                }
                if (cmbVersion.Text == "v1.06") 
                {
                    if (flatToggle2.Checked == true)
                    {
                        PS4.WriteMemory(processID, 0xA16F46, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                    }
                    else
                    {
                        PS4.WriteMemory(processID, 0xA16F46, new byte[] { 0xC5, 0xFA, 0x11, 0x43, 0x04 });
                    }
                }
            }
        }

        private void flatToggle4_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (cmbVersion.Text == "v1.00") 
                {
                    if (flatToggle4.Checked == true)
                    {
                        PS4.WriteMemory(processID, 0x9FCB31, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                    }
                    else
                    {
                        PS4.WriteMemory(processID, 0x9FCB31, new byte[] { 0xE8, 0x7A, 0xD2, 0xEB, 0x00 });
                    }
                }
                if (cmbVersion.Text == "v1.06")
                {
                    if (flatToggle4.Checked == true)
                    {
                        PS4.WriteMemory(processID, 0xA16B06, new byte[] { 0x90, 0x90, 0x90 });
                    }
                    else
                    {
                        PS4.WriteMemory(processID, 0xA16B06, new byte[] { 0x41, 0x89, 0x07 });
                    }
                }
            }
        }

        private void tglItems_CheckedChanged(object sender)
        {
            if (attached)
            {
                 if (cmbVersion.Text == "v1.00")
                    {
                    if (tglItems.Checked == true)
                    {
                        PS4.WriteMemory(processID, 0x9FCB3B, new byte[] { 0x90, 0x90, 0x90 });
                    }
                    else
                    {
                        PS4.WriteMemory(processID, 0x9FCB3B, new byte[] { 0x45, 0x89, 0x37 });
                    }
                }
                 if (cmbVersion.Text == "v1.06")
                    {
                    if (tglItems.Checked == true)
                    {
                        PS4.WriteMemory(processID, 0xFCF252, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                    }
                    else
                    {
                        PS4.WriteMemory(processID, 0xFCF252, new byte[] { 0x44, 0x89, 0x7C, 0x08, 0x04 });
                    }
                }
            }
        }

        private void tglGrappling_CheckedChanged(object sender)
        {
            if (!attached)
                return;
            if (tglGrappling.Checked)
            {

                switch (cmbVersion.Text)
                {
                    case "v1.00":
                        PS4.WriteMemory(processID, 0x1036FD8, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                        break;
                    case "v1.06":
                        PS4.WriteMemory(processID, 0x10815FA, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                        break;
                }

            }
            else
            {

                switch (cmbVersion.Text)
                {
                    case "v1.00":
                        PS4.WriteMemory(processID, 0x1036FD8, new byte[] { 0xC5, 0xFA, 0x11, 0x43, 0x40 });
                        break;
                    case "v1.06":
                        PS4.WriteMemory(processID, 0x10815FA, new byte[] { 0xC4, 0xC1, 0x7A, 0x11, 0x46, 0x40 });
                        break;
                }

            }
        }

        private void tglWeather_CheckedChanged(object sender)
        {
                if (attached)
                    if (tglWeather.Checked == true)
                        PS4.WriteMemory(processID, 0x14EC12D, new byte[] { 0xc5, 0xfa, 0x11, 0x08 });
                    else
                        PS4.WriteMemory(processID, 0x14EC12D, new byte[] { 0xc5, 0xfa, 0x11, 0x00 });
            }

        private void tglText_CheckedChanged(object sender)
        {
            if (attached)
                if (tglText.Checked == true)
                    PS4.WriteMemory(processID, 0x801769A3, new byte[] { 0x90, 0x90, 0x90 });
                else
                    PS4.WriteMemory(processID, 0x801769A3, new byte[] { 0x66, 0x89, 0x32 });

        }

        private void tglWallhack_CheckedChanged(object sender)
        {
            if (attached)
                if (tglWallhack.Checked == true)
                    PS4.WriteMemory(processID, 0x1E65703, new byte[] { 0xc5, 0xf8, 0x29, 0x12 });
                else
                    PS4.WriteMemory(processID, 0x1E65703, new byte[] { 0xc5, 0xf8, 0x29, 0x02 });

        }

        private void cmbVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVersion.Text == "v1.00")
            {
                pnlAmmo.Visible = true;
                pnlBuyToEarn.Visible = true;
                pnlGrappling.Visible = true;
                pnlHealth.Visible = true;
                pnlNoItemDecrease.Visible = true;
                pnlScramble.Visible = true;
                pnlSkills.Visible = true;
                pnlWallHack.Visible = true;
                pnlWeaponDur.Visible = true;
                pnlWeather.Visible = true;
                pnlFuel.Visible = false;
                pnlNitrous.Visible = false;
                pnlUV.Visible = false;
                pnlVehicleUpgrade.Visible = false;
            }
            if (cmbVersion.Text == "v1.06")
            {
                pnlAmmo.Visible = true;
                pnlBuyToEarn.Visible = true;
                pnlGrappling.Visible = true;
                pnlHealth.Visible = true;
                pnlNoItemDecrease.Visible = true;
                pnlScramble.Visible = false;
                pnlSkills.Visible = false;
                pnlWallHack.Visible = false;
                pnlWeaponDur.Visible = true;
                pnlWeather.Visible = false;
                pnlFuel.Visible = true;
                pnlNitrous.Visible = true;
                pnlUV.Visible = true;
                pnlVehicleUpgrade.Visible = true;
            }
        }

        private void DyingLightEE_Load(object sender, EventArgs e)
        {

        }

        private void tglUV_CheckedChanged(object sender)
        {
            if (!attached)
                return;
            if (tglUV.Checked)
            {

                switch (cmbVersion.Text)
                {
                    //case "v1.00":
                    //    PS4.WriteMemory(processID, 0x1036FD8, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                    //    break;
                    case "v1.06":
                        PS4.WriteMemory(processID, 0xF87A41, new byte[] { 0x90, 0x90, 0x90, 0x90 });
                        break;
                }

            }
            else
            {

                switch (cmbVersion.Text)
                {
                    //case "v1.00":
                    //    PS4.WriteMemory(processID, 0x1036FD8, new byte[] { 0xC5, 0xFA, 0x11, 0x43, 0x40 });
                    //    break;
                    case "v1.06":
                        PS4.WriteMemory(processID, 0xF87A41, new byte[] { 0xC5, 0xFA, 0x11, 0x07 });
                        break;
                }

            }

        }

        private void tglNitrous_CheckedChanged(object sender)
        {
            if (!attached)
                return;
            if (tglNitrous.Checked)
            {

                switch (cmbVersion.Text)
                {
                    //case "v1.00":
                    //    PS4.WriteMemory(processID, 0x1036FD8, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                    //    break;
                    case "v1.06":
                        PS4.WriteMemory(processID, 0x1382D70, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                        PS4.WriteMemory(processID, 0x1382DB1, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                        break;
                }

            }
            else
            {

                switch (cmbVersion.Text)
                {
                    //case "v1.00":
                    //    PS4.WriteMemory(processID, 0x1036FD8, new byte[] { 0xC5, 0xFA, 0x11, 0x43, 0x40 });
                    //    break;
                    case "v1.06":
                        PS4.WriteMemory(processID, 0x1382D70, new byte[] { 0xC5, 0xFA, 0x11, 0x4B, 0x10 });
                        PS4.WriteMemory(processID, 0x1382DB1, new byte[] { 0xC5, 0xFA, 0x11, 0x43, 0x10 });
                        break;
                }

            }

        }

        private void tglVehicleUpgrade_CheckedChanged(object sender)
        {
            if (!attached)
                return;
            if (tglVehicleUpgrade.Checked)
            {

                switch (cmbVersion.Text)
                {
                    //case "v1.00":
                    //    PS4.WriteMemory(processID, 0x1036FD8, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                    //    break;
                    case "v1.06":
                        PS4.WriteMemory(processID, 0x138BE44, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                        break;
                }

            }
            else
            {

                switch (cmbVersion.Text)
                {
                    //case "v1.00":
                    //    PS4.WriteMemory(processID, 0x1036FD8, new byte[] { 0xC5, 0xFA, 0x11, 0x43, 0x40 });
                    //    break;
                    case "v1.06":
                        PS4.WriteMemory(processID, 0x138BE44, new byte[] { 0xC5, 0xFA, 0x11, 0x53, 0x18 });
                        break;
                }

            }

        }

        private void tglFuel_CheckedChanged(object sender)
        {
            if (!attached)
                return;
            if (tglFuel.Checked)
            {

                switch (cmbVersion.Text)
                {
                    //case "v1.00":
                    //    PS4.WriteMemory(processID, 0x1036FD8, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                    //    break;
                    case "v1.06":
                        PS4.WriteMemory(processID, 0x136E3E1, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                        break;
                }

            }
            else
            {

                switch (cmbVersion.Text)
                {
                    //case "v1.00":
                    //    PS4.WriteMemory(processID, 0x1036FD8, new byte[] { 0xC5, 0xFA, 0x11, 0x43, 0x40 });
                    //    break;
                    case "v1.06":
                        PS4.WriteMemory(processID, 0x136E3E1, new byte[] { 0xC5, 0xFA, 0x11, 0x83, 0x20, 0x03, 0x00, 0x00 });
                        break;
                }

            }

        }
    }
}
