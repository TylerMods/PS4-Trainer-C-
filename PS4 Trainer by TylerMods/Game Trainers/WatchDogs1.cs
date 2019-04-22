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
    public partial class WatchDogs1 : UserControl
    {
        PS4RPC PS4 = main.PS4;
        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public WatchDogs1()
        {
            InitializeComponent();
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

            Util.attachToGame("eboot.bin", "Watch Dogs 1", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglBattery_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglBattery.Checked == true)
                {
                    PS4.WriteMemory(processID, processEntry + 0x4BFF82, new byte[] { 0xC6, 0x83, 0xE8, 0x00, 0x00, 0x00, 0xFF, 0x90, 0x90 });
                }
                else
                {
                    PS4.WriteMemory(processID, processEntry + 0x4BFF82, new byte[] { 0x0F, 0x47, 0xC6, 0x89, 0x83, 0xE8, 0x00, 0x00, 0x00 });
                }
            }

        }

        private void flatToggle1_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (flatToggle1.Checked == true)
                {
                    PS4.WriteMemory(processID, processEntry + 0x7B3C06, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    PS4.WriteMemory(processID, processEntry + 0x7B3C06, new byte[] { 0x41, 0xFF, 0x8C, 0x24, 0x90, 0x00, 0x00, 0x00 });
                }
            }

        }
    }
}
