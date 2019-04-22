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
    public partial class GravityRush : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public GravityRush()
        {
            InitializeComponent();
        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, processEntry + 0x48169A, new byte[3] { 0x90, 0x90, 0x90 });
                }
                else
                {
                    PS4.WriteMemory(processID, processEntry + 0x48169A, new byte[3] { 0x89, 0x57, 0x20 });
                }
            }

        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[1] == "1.00")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00");
            }

            Util.attachToGame("eboot.bin", "Gravity Rush", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglGravity_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglGravity.Checked == true)
                {
                    PS4.WriteMemory(processID, processEntry + 0x48169A, new byte[8] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    PS4.WriteMemory(processID, processEntry + 0x48169A, new byte[8] { 0xC5, 0xFA, 0x11, 0x83, 0x78, 0x0A, 0x00, 0x00 });
                }
            }

        }

        private void tglGems_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglGems.Checked == true)
                {
                    PS4.WriteMemory(processID, processEntry + 0x504777, new byte[2] { 0x01, 0x17 });
                }
                else
                {
                    PS4.WriteMemory(processID, processEntry + 0x504777, new byte[2] { 0x29, 0x17 });
                }
            }

        }

        private void tglAttack_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglAttack.Checked == true)
                {
                    PS4.WriteMemory(processID, processEntry + 0x6E2030, new byte[8] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    PS4.WriteMemory(processID, processEntry + 0x6E2030, new byte[8] { 0x41, 0x8B, 0x84, 0x24, 0x28, 0x0A, 0x00, 0x00 });
                }
            }

        }
    }
}
