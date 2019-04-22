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
    public partial class FC4 : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public FC4()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[1] == "01.00" || Util.GameInfoArray()[1] == "01.07")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}");
            }

            Util.attachToGame("eboot.bin", "FarCry 4", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglAmmo_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglAmmo.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x185B4AA, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x185B4AA, new byte[] { 0x89, 0xB0, 0x04, 0x01, 0x00, 0x00 });
                }

            }

        }

        private void tglSkill_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglSkill.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x10DCDF2, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x10DCDF2, new byte[] { 0x41, 0x29, 0x44, 0x24, 0x70 });
                }

            }

        }

        private void tglXP_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglSkill.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x10DC2CB, new byte[] { 0x01, 0x4B, 0x64 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x10DC2CB, new byte[] { 0x89, 0x4B, 0x64 });
                }

            }

        }
    }
}
