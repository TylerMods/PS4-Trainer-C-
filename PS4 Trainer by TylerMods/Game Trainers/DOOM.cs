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
    public partial class DOOM : UserControl
    {
        PS4RPC PS4 = main.PS4;
        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public DOOM()
        {
            InitializeComponent();
        }

        private void tglAmmo_CheckedChanged(object sender)
        {
            if (attached)
                if (tglAmmo.Checked == true)
                    PS4.WriteMemory(processID, 0xEB1699, new byte[] { 0x48, 0x89, 0x4B, 0x38 });
                else
                    PS4.WriteMemory(processID, 0xEB1699, new byte[] { 0x44, 0x89, 0x73, 0x38 });
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[0] == "CUSA02092" || Util.GameInfoArray()[1] == "1.00")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00");
            }

            Util.attachToGame("eboot.bin", "DOOM", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }
        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
                if (tglHealth.Checked == true)
                    PS4.WriteMemory(processID, 0x25BA038, new byte[] { 0x90, 0x90 });
                else
                    PS4.WriteMemory(processID, 0x25BA038, new byte[] { 0x00, 0x01 });

        }

        private void tglHit_CheckedChanged(object sender)
        {
            if (attached)
                if (tglHit.Checked == true)
                    PS4.WriteMemory(processID, 0x256D4C8, new byte[] { 0x00 });
                else
                    PS4.WriteMemory(processID, 0x256D4C8, new byte[] { 0x01 });
        }
    }
}
