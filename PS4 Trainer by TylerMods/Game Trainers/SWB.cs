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
    public partial class SWB : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public SWB()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[1] == "1.07")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.07");
            }

            Util.attachToGame("eboot.bin", "Star Wars Battlefront II", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x2584d35, new byte[8] { 0xe9, 0xf6, 0xe2, 0x84, 0x01, 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x3DD3030, new byte[30] { 0xc5, 0xfa, 0x10, 0x45, 0xc0, 0x48, 0x89, 0xdf, 0xbe, 0x10, 0x28, 0xbe, 0x04, 0x39, 0xb3, 0x30, 0x01, 0x00, 0x00, 0x0f, 0x85, 0xf4, 0x1c, 0x7b, 0xfe, 0xe9, 0xf4, 0x1c, 0x7b, 0xfe });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x2584d35, new byte[8] { 0xc5, 0xfa, 0x10, 0x45, 0xc0, 0x48, 0x89, 0xdf });
                    PS4.WriteMemory(processID, 0x3DD3030, new byte[31] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }
            }

        }

        private void tglAmmo_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglAmmo.Checked == true)
                {
                    PS4.WriteMemory(processID, processEntry + 0x27beaa5, new byte[8] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    PS4.WriteMemory(processID, processEntry + 0x27beaa5, new byte[8] { 0xc5, 0xfa, 0x11, 0x83, 0xcc, 0x01, 0x00, 0x00 });
                }
            }
        }

    }
}
