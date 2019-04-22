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
    public partial class JustCause3 : UserControl
    {
        PS4RPC PS4 = main.PS4;
        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public JustCause3()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[0] == "CUSA02747" || Util.GameInfoArray()[1] == "1.05")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.05");
            }

            Util.attachToGame("eboot.bin", "Just Cause 3", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked)
                {
                    PS4.WriteMemory(processID, 0x1482ADE, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x1482ADE, new byte[] { 0xC7, 0x43, 0x40, 0x00, 0x00, 0x00, 0x00 });
                }
            }

        }

        private void tglAmmo_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglAmmo.Checked)
                {
                    PS4.WriteMemory(processID, 0x1105482, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x1105482, new byte[] { 0x46, 0x89, 0xA4, 0xAB, 0xA8, 0x01, 0x00, 0x00 });
                }
            }
    }

        private void tglReload_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglReload.Checked)
                {
                    PS4.WriteMemory(processID, 0x11dcc54, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x11dcc54, new byte[] { 0x44, 0x89, 0xb3, 0x28, 0x02, 0x00, 0x00 });
                }
            }

        }

        private void tglSpread_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglSpread.Checked)
                {
                    PS4.WriteMemory(processID, 0x11c70f9, new byte[] { 0xC4, 0xC1, 0x7A, 0x11, 0x8F, 0x68, 0x02, 0x00, 0x00 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x11c70f9, new byte[] { 0xc4, 0xc1, 0x7a, 0x11, 0x87, 0x68, 0x02, 0x00, 0x00 });
                }
            }
        }

        private void tglShoot_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglShoot.Checked)
                {
                    PS4.WriteMemory(processID, 0x11C7192, new byte[] { 0xc4, 0xc1, 0x7a, 0x11, 0x8f, 0x98, 0x01, 0x00, 0x00 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x11C7192, new byte[] { 0xc4, 0xc1, 0x7a, 0x11, 0x87, 0x98, 0x01, 0x00, 0x00 });
                }
            }

        }
    }
}
