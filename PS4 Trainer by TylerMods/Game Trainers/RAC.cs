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
    public partial class RAC : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public RAC()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[0] == "CUSA01047" || Util.GameInfoArray()[1] == "01.00")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}");
            }

            Util.attachToGame("eboot.bin", "Ratchet and Clank", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void tglBolts_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglBolts.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x145DC74, new byte[] { 0xe9, 0x2b, 0xc6, 0xc2, 0x01 });
                    PS4.WriteMemory(processID, 0x308a2a4, new byte[] { 0x41, 0xC7, 0x44, 0x24, 0x18, 0xC0, 0x29, 0xCD, 0x02, 0xE9, 0xC7, 0x39, 0x3D, 0xFE });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x145DC74, new byte[] { 0x45, 0x01, 0x7C, 0x24, 0x18 });
                    PS4.WriteMemory(processID, 0x308a2a4, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00});
                }
            }
        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x1423F9a, new byte[] { 0xc5, 0xfa, 0x11, 0x83, 0xc0, 0x03, 0x00, 0x00 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x1423F9a, new byte[] { 0xc5, 0xfa, 0x11, 0x93, 0xc0, 0x03, 0x00, 0x00 });
                }
            }

        }

        private void tglRaritanium_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglRaritanium.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x145DD5E, new byte[] { 0x41, 0x03, 0x1C, 0x24 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x145DD5E, new byte[] { 0x41, 0x2b, 0x1c, 0x24 });
                }
            }

        }

        private void tglAmmo_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglAmmo.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x8D2177, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x8D2177, new byte[] { 0xc5, 0xfa, 0x11, 0x8b, 0x50, 0x04, 0x00, 0x00 });                }
            }

        }
    }
}
