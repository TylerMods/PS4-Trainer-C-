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
    public partial class Diablo3 : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public Diablo3()
        {
            InitializeComponent();
        }

        private void tglMana_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglMana.Checked == true)
                {
                    PS4.WriteMemory(processID, processEntry + 0x922741, new byte[4] { 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    PS4.WriteMemory(processID, processEntry + 0x922741, new byte[4] { 0x44, 0x89, 0x60, 0x0C });
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

            Util.attachToGame("eboot.bin", "Diablo 3 Ultimate Evil Edition", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void tmrMana_Tick(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, entryList[19] + 0x66752BC, 344);
        }

        private void flatToggle2_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (flatToggle2.Checked == true)
                {
                    PS4.WriteMemory(processID, processEntry + 0x9227E1, new byte[4] { 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    PS4.WriteMemory(processID, processEntry + 0x9227E1, new byte[4] { 0x44, 0x89, 0x78, 0x0C });
                }
            }


        }

        private void tglKill_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglKill.Checked == true)
                {
                    PS4.WriteMemory(processID, processEntry + 0xB9C486, new byte[9] { 0xB9, 0x0F, 0x27, 0x00, 0x00, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    PS4.WriteMemory(processID, processEntry + 0xB9C486, new byte[9] { 0x81, 0xF9, 0xFF, 0xFF, 0xFF, 0x00, 0x0F, 0x43, 0xC8 });
                }
            }
        }
    }
}
