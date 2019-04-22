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
    public partial class DragonQH2 : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public DragonQH2()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];
            if (Util.GameInfoArray()[0] == "CUSA06740" || Util.GameInfoArray()[1] == "1.06")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}");
            }

            Util.attachToGame("eboot.bin", "Dragon Quest Heroes 2", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x62F52D, new byte[] { 0xE9, 0xE8, 0xC8, 0xA1, 0x00, 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x104be1a, new byte[] { 0x83, 0xBF, 0x38, 0x01, 0x00, 0x00, 0x00, 0x0F, 0x84, 0x0E, 0x37, 0x5E, 0xFF, 0xC5, 0xFA, 0x11, 0x87, 0x0C, 0x02, 0x00, 0x00, 0xE9, 0x01, 0x37, 0x5E, 0xFF });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x62F52D, new byte[] { 0xc5, 0xfa, 0x11, 0x87, 0x0c, 0x02, 0x00, 0x00 });
                    PS4.WriteMemory(processID, 0x104be1a, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }

            }
        }

        private void tglMP_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglMP.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x6B4BE9, new byte[] { 0xc5, 0xfa, 0x11, 0x08 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x6B4BE9, new byte[] { 0xc5, 0xfa, 0x11, 0x00 });
                }

            }

        }

        private void tglMoney_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglMoney.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x663176, new byte[] { 0xE9, 0x5E, 0x88, 0xB1, 0x00, 0x90 });
                    PS4.WriteMemory(processID, 0x117b9d9, new byte[] { 0xC7, 0x80, 0x04, 0x2B, 0x02, 0x00, 0x60, 0xB7, 0x47, 0x00, 0xE9, 0x93, 0x77, 0x4E, 0xFF });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x663176, new byte[] { 0x89, 0xb8, 0x04, 0x2b, 0x02, 0x00, 0x29, 0xf2 });
                    PS4.WriteMemory(processID, 0x117b9d9, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }

            }

        }
    }
}
