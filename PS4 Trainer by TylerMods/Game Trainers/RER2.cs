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
    public partial class RER2 : UserControl
    {
        PS4RPC PS4 = main.PS4;
        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public RER2()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[0] == "CUSA01133" || Util.GameInfoArray()[1] == "1.00")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00");
            }

            Util.attachToGame("eboot.bin", "Resident Evil Revelations 2", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglAmmo_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglAmmo.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x7F46A8, new byte[] { 0xE9, 0x03, 0xE7, 0xD2, 0x00, 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x1522db0, new byte[] { 0x41, 0xC7, 0x46, 0x10, 0xD6, 0x01, 0x00, 0x00, 0x48, 0x83, 0xC4, 0x08, 0xE9, 0xEF, 0x18, 0x2D, 0xFF });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x7F46A8, new byte[] { 0x41, 0x89, 0x46, 0x10, 0x48, 0x83, 0xc4, 0x08 });
                    PS4.WriteMemory(processID, 0x1522db0, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }
            }


        }

        private void tglMoney_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglMoney.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xc34ca2, new byte[] { 0xE9, 0xF9, 0xE0, 0x8E, 0x00, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x1522DA0, new byte[] { 0xC7, 0x83, 0xC8, 0xC4, 0x00, 0x00, 0xC0, 0x29, 0xCD, 0x02, 0xE9, 0xFA, 0x1E, 0x71, 0xFF });
                }
                else
                {
                    PS4.WriteMemory(processID, 0xc34ca2, new byte[] { 0x4c, 0x89, 0xa3, 0xc8, 0xc4, 0x00, 0x00 });
                    PS4.WriteMemory(processID, 0x1522DA0, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }
            }

        }

        private void tglCrystals_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglCrystals.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xB9C548, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0xB9C548, new byte[] { 0x44, 0x01, 0xab, 0x6c, 0x5f, 0x01, 0x00 });
                }
            }

        }

        private void tglSP_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglSP.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xC309F2, new byte[] { 0xE9, 0xCB, 0x23, 0x8F, 0x00, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x1522dc2, new byte[] { 0xC7, 0x80, 0xEC, 0x00, 0x00, 0x00, 0xD6, 0x01, 0x00, 0x00, 0xE9, 0x28, 0xDC, 0x70, 0xFF });
                }
                else
                {
                    PS4.WriteMemory(processID, 0xC309F2, new byte[] { 0x44, 0x89, 0xb8, 0xec, 0x00, 0x00, 0x00 });
                    PS4.WriteMemory(processID, 0x1522dc2, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }
            }

        }

        private void tglHeatlh_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHeatlh.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x7FD4FB, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x7FD4FB, new byte[] { 0x89, 0x83, 0x38, 0x1f, 0x00, 0x00 });
                }
            }

        }
    }
}
