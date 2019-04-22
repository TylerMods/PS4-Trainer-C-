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
    public partial class re5 : UserControl
    {
        PS4RPC PS4 = main.PS4;
        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public re5()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[0] == "CUSA04437" || Util.GameInfoArray()[1] == "1.00")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00");
            }

            Util.attachToGame("eboot.bin", "Resident Evil 5", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, entryList[17] + 0x3AB0264, (int)numMoney.Value);
                PS4.WriteInt32(processID, entryList[19] + 0x3AB0264, (int)numMoney.Value);
            PS4.WriteInt32(processID, entryList[16] + 0x3AB0264, (int)numMoney.Value);

        }

        private void btnChris9999_Click(object sender, EventArgs e)
        {
            if (cmbChris9999.Text == "Slot 1")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD7444, new byte[] { 0x0F, 0x27 });
               PS4.WriteMemory(processID, entryList[16] + 0x3AD7444, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD7444, new byte[] { 0x0F, 0x27 });
            }
            if (cmbChris9999.Text == "Slot 2")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD7444 + 0x30, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD7444 + 0x30, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD7444 + 0x30, new byte[] { 0x0F, 0x27 });

            }
            if (cmbChris9999.Text == "Slot 3")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD7444 + 0x60, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD7444 + 0x60, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD7444 + 0x60, new byte[] { 0x0F, 0x27 });

            }
            if (cmbChris9999.Text == "Slot 4")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD7444 + 0x90, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD7444 + 0x90, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD7444 + 0x90, new byte[] { 0x0F, 0x27 });

            }
            if (cmbChris9999.Text == "Slot 5")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD7444 + 0xC0, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD7444 + 0xC0, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD7444 + 0xC0, new byte[] { 0x0F, 0x27 });

            }
            if (cmbChris9999.Text == "Slot 6")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD7444 + 0xF0, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD7444 + 0xF0, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD7444 + 0xF0, new byte[] { 0x0F, 0x27 });

            }
            if (cmbChris9999.Text == "Slot 7")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD7444 + 0x120, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD7444 + 0x120, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD7444 + 0x120, new byte[] { 0x0F, 0x27 });

            }
            if (cmbChris9999.Text == "Slot 8")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD7444 + 0x150, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD7444 + 0x150, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD7444 + 0x150, new byte[] { 0x0F, 0x27 });

            }
            if (cmbChris9999.Text == "Slot 9")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD7444 + 0x180, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD7444 + 0x180, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD7444 + 0x180, new byte[] { 0x0F, 0x27 });

            }
            if (cmbChris9999.Text == "All Slots")
            {
                PS4.WriteMemory(processID, entryList[17] + 0x3AD7444, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD7444, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD7444, new byte[] { 0x0F, 0x27 });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD7444 + 0x30, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD7444 + 0x30, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD7444 + 0x30, new byte[] { 0x0F, 0x27 });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD7444 + 0x60, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD7444 + 0x60, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD7444 + 0x60, new byte[] { 0x0F, 0x27 });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD7444 + 0x90, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD7444 + 0x90, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD7444 + 0x90, new byte[] { 0x0F, 0x27 });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD7444 + 0xC0, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD7444 + 0xC0, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD7444 + 0xC0, new byte[] { 0x0F, 0x27 });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD7444 + 0xF0, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD7444 + 0xF0, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD7444 + 0xF0, new byte[] { 0x0F, 0x27 });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD7444 + 0x120, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD7444 + 0x120, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD7444 + 0x120, new byte[] { 0x0F, 0x27 });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD7444 + 0x150, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD7444 + 0x150, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD7444 + 0x150, new byte[] { 0x0F, 0x27 });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD7444 + 0x180, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD7444 + 0x180, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD7444 + 0x180, new byte[] { 0x0F, 0x27 });

            }
        }

        private void btnFAQ_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, 
                "Q1 : Why won't my ammo change?" +
                "\nA1 : You need to pick up an item/weapon by pressing square, then put it back down with square while in the Organize menu before game.", 
                "Help", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnChrisRapidFireOn_Click(object sender, EventArgs e)
        {
            if (cmbChrisRapidFire.Text == "Slot 1")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD745D, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D, new byte[] { 0xFF });

            }
            if (cmbChrisRapidFire.Text == "Slot 2")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD745D + 0x30, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D + 0x30, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D + 0x30, new byte[] { 0xFF });

            }
            if (cmbChrisRapidFire.Text == "Slot 3")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD745D + 0x60, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D + 0x60, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D + 0x60, new byte[] { 0xFF });

            }
            if (cmbChrisRapidFire.Text == "Slot 4")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD745D + 0x90, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D + 0x90, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D + 0x90, new byte[] { 0xFF });

            }
            if (cmbChrisRapidFire.Text == "Slot 5")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD745D + 0xC0, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D + 0xC0, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D + 0xC0, new byte[] { 0xFF });

            }
            if (cmbChrisRapidFire.Text == "Slot 6")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD745D + 0xF0, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D + 0xF0, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D + 0xF0, new byte[] { 0xFF });

            }
            if (cmbChrisRapidFire.Text == "Slot 7")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD745D + 0x120, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D + 0x120, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D + 0x120, new byte[] { 0xFF });

            }
            if (cmbChrisRapidFire.Text == "Slot 8")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD745D + 0x150, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D + 0x150, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D + 0x150, new byte[] { 0xFF });

            }
            if (cmbChrisRapidFire.Text == "Slot 9")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD745D + 0x180, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D + 0x180, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D + 0x180, new byte[] { 0xFF });

            }
            if (cmbChrisRapidFire.Text == "All Slots")
            {
                PS4.WriteMemory(processID, entryList[17] + 0x3AD745D, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D, new byte[] { 0xFF });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD745D + 0x30, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D + 0x30, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D + 0x30, new byte[] { 0xFF });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD745D + 0x60, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D + 0x60, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D + 0x60, new byte[] { 0xFF });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD745D + 0x90, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D + 0x90, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D + 0x90, new byte[] { 0xFF });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD745D + 0xC0, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D + 0xC0, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D + 0xC0, new byte[] { 0xFF });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD745D + 0xF0, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D + 0xF0, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D + 0xF0, new byte[] { 0xFF });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD745D + 0x120, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D + 0x120, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D + 0x120, new byte[] { 0xFF });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD745D + 0x150, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D + 0x150, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D + 0x150, new byte[] { 0xFF });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD745D + 0x180, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D + 0x180, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D + 0x180, new byte[] { 0xFF });

            }
        }

        private void btnChrisRapidFireOff_Click(object sender, EventArgs e)
        {
            if (cmbChrisRapidFire.Text == "Slot 1")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD745D, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D, new byte[] { 0x00 });

            }
            if (cmbChrisRapidFire.Text == "Slot 2")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD745D + 0x30, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D + 0x30, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D + 0x30, new byte[] { 0x00 });

            }
            if (cmbChrisRapidFire.Text == "Slot 3")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD745D + 0x60, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D + 0x60, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D + 0x60, new byte[] { 0x00 });

            }
            if (cmbChrisRapidFire.Text == "Slot 4")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD745D + 0x90, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D + 0x90, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D + 0x90, new byte[] { 0x00 });

            }
            if (cmbChrisRapidFire.Text == "Slot 5")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD745D + 0xC0, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D + 0xC0, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D + 0xC0, new byte[] { 0x00 });

            }
            if (cmbChrisRapidFire.Text == "Slot 6")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD745D + 0xF0, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D + 0xF0, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D + 0xF0, new byte[] { 0x00 });

            }
            if (cmbChrisRapidFire.Text == "Slot 7")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD745D + 0x120, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D + 0x120, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D + 0x120, new byte[] { 0x00 });

            }
            if (cmbChrisRapidFire.Text == "Slot 8")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD745D + 0x150, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D + 0x150, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D + 0x150, new byte[] { 0x00 });

            }
            if (cmbChrisRapidFire.Text == "Slot 9")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD745D + 0x180, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D + 0x180, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D + 0x180, new byte[] { 0x00 });

            }
            if (cmbChrisRapidFire.Text == "All Slots")
            {
                PS4.WriteMemory(processID, entryList[17] + 0x3AD745D, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D, new byte[] { 0x00 });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD745D + 0x30, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D + 0x30, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D + 0x30, new byte[] { 0x00 });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD745D + 0x60, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D + 0x60, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D + 0x60, new byte[] { 0x00 });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD745D + 0x90, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D + 0x90, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D + 0x90, new byte[] { 0x00 });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD745D + 0xC0, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D + 0xC0, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D + 0xC0, new byte[] { 0x00 });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD745D + 0xF0, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D + 0xF0, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D + 0xF0, new byte[] { 0x00 });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD745D + 0x120, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D + 0x120, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D + 0x120, new byte[] { 0x00 });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD745D + 0x150, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D + 0x150, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D + 0x150, new byte[] { 0x00 });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD745D + 0x180, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD745D + 0x180, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD745D + 0x180, new byte[] { 0x00 });

            }
        }

        private void btnSheva9999_Click(object sender, EventArgs e)
        {
            if (cmbSheva9999.Text == "Slot 1")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD78C4, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78C4, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78C4, new byte[] { 0x0F, 0x27 });
            }
            if (cmbSheva9999.Text == "Slot 2")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD78C4 + 0x30, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78C4 + 0x30, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78C4 + 0x30, new byte[] { 0x0F, 0x27 });

            }
            if (cmbSheva9999.Text == "Slot 3")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD78C4 + 0x60, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78C4 + 0x60, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78C4 + 0x60, new byte[] { 0x0F, 0x27 });

            }
            if (cmbSheva9999.Text == "Slot 4")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD78C4 + 0x90, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78C4 + 0x90, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78C4 + 0x90, new byte[] { 0x0F, 0x27 });

            }
            if (cmbSheva9999.Text == "Slot 5")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD78C4 + 0xC0, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78C4 + 0xC0, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78C4 + 0xC0, new byte[] { 0x0F, 0x27 });

            }
            if (cmbSheva9999.Text == "Slot 6")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD78C4 + 0xF0, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78C4 + 0xF0, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78C4 + 0xF0, new byte[] { 0x0F, 0x27 });

            }
            if (cmbSheva9999.Text == "Slot 7")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD78C4 + 0x120, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78C4 + 0x120, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78C4 + 0x120, new byte[] { 0x0F, 0x27 });

            }
            if (cmbSheva9999.Text == "Slot 8")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD78C4 + 0x150, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78C4 + 0x150, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78C4 + 0x150, new byte[] { 0x0F, 0x27 });

            }
            if (cmbSheva9999.Text == "Slot 9")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD78C4 + 0x180, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78C4 + 0x180, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78C4 + 0x180, new byte[] { 0x0F, 0x27 });

            }
            if (cmbSheva9999.Text == "All Slots")
            {
                PS4.WriteMemory(processID, entryList[17] + 0x3AD78C4, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78C4, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78C4, new byte[] { 0x0F, 0x27 });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD78C4 + 0x30, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78C4 + 0x30, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78C4 + 0x30, new byte[] { 0x0F, 0x27 });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD78C4 + 0x60, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78C4 + 0x60, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78C4 + 0x60, new byte[] { 0x0F, 0x27 });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD78C4 + 0x90, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78C4 + 0x90, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78C4 + 0x90, new byte[] { 0x0F, 0x27 });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD78C4 + 0xC0, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78C4 + 0xC0, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78C4 + 0xC0, new byte[] { 0x0F, 0x27 });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD78C4 + 0xF0, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78C4 + 0xF0, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78C4 + 0xF0, new byte[] { 0x0F, 0x27 });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD78C4 + 0x120, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78C4 + 0x120, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78C4 + 0x120, new byte[] { 0x0F, 0x27 });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD78C4 + 0x150, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78C4 + 0x150, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78C4 + 0x150, new byte[] { 0x0F, 0x27 });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD78C4 + 0x180, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78C4 + 0x180, new byte[] { 0x0F, 0x27 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78C4 + 0x180, new byte[] { 0x0F, 0x27 });

            }
        }

        private void btnShevaRapidFireOn_Click(object sender, EventArgs e)
        {
            if (cmbShevaRapidFire.Text == "Slot 1")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD, new byte[] { 0xFF });

            }
            if (cmbShevaRapidFire.Text == "Slot 2")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD + 0x30, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD + 0x30, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD + 0x30, new byte[] { 0xFF });

            }
            if (cmbShevaRapidFire.Text == "Slot 3")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD + 0x60, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD + 0x60, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD + 0x60, new byte[] { 0xFF });

            }
            if (cmbShevaRapidFire.Text == "Slot 4")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD + 0x90, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD + 0x90, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD + 0x90, new byte[] { 0xFF });

            }
            if (cmbShevaRapidFire.Text == "Slot 5")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD + 0xC0, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD + 0xC0, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD + 0xC0, new byte[] { 0xFF });

            }
            if (cmbShevaRapidFire.Text == "Slot 6")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD + 0xF0, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD + 0xF0, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD + 0xF0, new byte[] { 0xFF });

            }
            if (cmbShevaRapidFire.Text == "Slot 7")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD + 0x120, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD + 0x120, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD + 0x120, new byte[] { 0xFF });

            }
            if (cmbShevaRapidFire.Text == "Slot 8")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD + 0x150, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD + 0x150, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD + 0x150, new byte[] { 0xFF });

            }
            if (cmbShevaRapidFire.Text == "Slot 9")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD + 0x180, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD + 0x180, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD + 0x180, new byte[] { 0xFF });

            }
            if (cmbShevaRapidFire.Text == "All Slots")
            {
                PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD, new byte[] { 0xFF });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD + 0x30, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD + 0x30, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD + 0x30, new byte[] { 0xFF });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD + 0x60, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD + 0x60, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD + 0x60, new byte[] { 0xFF });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD + 0x90, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD + 0x90, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD + 0x90, new byte[] { 0xFF });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD + 0xC0, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD + 0xC0, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD + 0xC0, new byte[] { 0xFF });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD + 0xF0, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD + 0xF0, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD + 0xF0, new byte[] { 0xFF });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD + 0x120, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD + 0x120, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD + 0x120, new byte[] { 0xFF });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD + 0x150, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD + 0x150, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD + 0x150, new byte[] { 0xFF });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD + 0x180, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD + 0x180, new byte[] { 0xFF });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD + 0x180, new byte[] { 0xFF });

            }

        }

        private void btnShevaRapidFireOff_Click(object sender, EventArgs e)
        {
            if (cmbShevaRapidFire.Text == "Slot 1")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD, new byte[] { 0x00 });

            }
            if (cmbShevaRapidFire.Text == "Slot 2")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD + 0x30, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD + 0x30, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD + 0x30, new byte[] { 0x00 });

            }
            if (cmbShevaRapidFire.Text == "Slot 3")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD + 0x60, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD + 0x60, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD + 0x60, new byte[] { 0x00 });

            }
            if (cmbShevaRapidFire.Text == "Slot 4")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD + 0x90, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD + 0x90, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD + 0x90, new byte[] { 0x00 });

            }
            if (cmbShevaRapidFire.Text == "Slot 5")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD + 0xC0, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD + 0xC0, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD + 0xC0, new byte[] { 0x00 });

            }
            if (cmbShevaRapidFire.Text == "Slot 6")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD + 0xF0, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD + 0xF0, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD + 0xF0, new byte[] { 0x00 });

            }
            if (cmbShevaRapidFire.Text == "Slot 7")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD + 0x120, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD + 0x120, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD + 0x120, new byte[] { 0x00 });

            }
            if (cmbShevaRapidFire.Text == "Slot 8")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD + 0x150, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD + 0x150, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD + 0x150, new byte[] { 0x00 });

            }
            if (cmbShevaRapidFire.Text == "Slot 9")
            {
                if (attached)
                    PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD + 0x180, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD + 0x180, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD + 0x180, new byte[] { 0x00 });

            }
            if (cmbShevaRapidFire.Text == "All Slots")
            {
                PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD, new byte[] { 0 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD, new byte[] { 0x00 });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD + 0x30, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD + 0x30, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD + 0x30, new byte[] { 0x00 });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD + 0x60, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD + 0x60, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD + 0x60, new byte[] { 0x00 });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD + 0x90, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD + 0x90, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD + 0x90, new byte[] { 0x00 });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD + 0xC0, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD + 0xC0, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD + 0xC0, new byte[] { 0x00 });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD + 0xF0, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD + 0xF0, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD + 0xF0, new byte[] { 0x00 });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD + 0x120, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD + 0x120, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD + 0x120, new byte[] { 0x00 });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD + 0x150, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD + 0x150, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD + 0x150, new byte[] { 0x00 });

                PS4.WriteMemory(processID, entryList[17] + 0x3AD78DD + 0x180, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[16] + 0x3AD78DD + 0x180, new byte[] { 0x00 });
                PS4.WriteMemory(processID, entryList[19] + 0x3AD78DD + 0x180, new byte[] { 0x00 });

            }
        }

        private void btnPoints_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, entryList[17] + 0x3AB0268, (int)numPoints.Value);
            PS4.WriteInt32(processID, entryList[16] + 0x3AB0268, (int)numPoints.Value);
            PS4.WriteInt32(processID, entryList[19] + 0x3AB0268, (int)numPoints.Value);
        }

        private void tglTime_CheckedChanged(object sender)
        {
            if (attached)
                if (tglTime.Checked == true)
                    PS4.WriteMemory(processID, 0x44621F, new byte[] { 0xC5, 0xFA, 0x11, 0xAB, 0xA0, 0x07, 0x00, 0x00 });
                else
                    PS4.WriteMemory(processID, 0x44621F, new byte[] { 0xC5, 0xFA, 0x11, 0x83, 0xA0, 0x07, 0x00, 0x00 });
        }

        private void tglAmmo_CheckedChanged(object sender)
        {
            if (attached)
                if (tglAmmo.Checked == true)
                    PS4.WriteMemory(processID, 0xB381E5, new byte[] { 0x90, 0x90, 0x90 });
                else
                    PS4.WriteMemory(processID, 0xB381E5, new byte[] { 0x29, 0x56, 0x0c });

        }

        private void tglMoney_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglMoney.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xC0B21D, new byte[] { 0xE9, 0x5E, 0x5B, 0x6D, 0x00, 0x90 });
                    PS4.WriteMemory(processID, 0x12E0D80, new byte[] { 0xC7, 0x87, 0x94, 0x01, 0x00, 0x00, 0x60, 0xB7, 0x47, 0x00 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0xC0B21D, new byte[] { 0x89, 0x87, 0x94, 0x01, 0x00, 0x00 });
                    PS4.WriteMemory(processID, 0x12E0D80, new byte[] { 0xC7, 0x87, 0x94, 0x01, 0x00, 0x00, 0x60, 0xB7, 0x47, 0x00 });
                }
            }
        }
    }
}
