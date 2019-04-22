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
    public partial class WWE18 : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public WWE18()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[1] == "1.08")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}");
            }

            Util.attachToGame("eboot.bin", "WWE 2K18", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglX2Money_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglX2Money.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x1D79964, new byte[] { 0x01, 0x0d, 0x2e, 0x61, 0xbd, 0x01 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x1D79964, new byte[] { 0x89, 0x0d, 0x2e, 0x61, 0xbd, 0x01 });
                }

            }

        }

        private void tglInfMoney_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglInfMoney.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x1D79964, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x1D79964, new byte[] { 0x89, 0x0d, 0x2e, 0x61, 0xbd, 0x01 });
                }

            }

        }
    }
}
