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
    public partial class PES18 : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public PES18()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[1] == "1.05")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}");
            }

            Util.attachToGame("eboot.bin", "PES 18", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglSalary_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglSalary.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x1afda65, new byte[] { 0xe9, 0xa6, 0x62, 0x22, 0x02, 0x90 });
                    PS4.WriteMemory(processID, 0x3d23d10, new byte[] { 0xC7, 0x80, 0x47, 0x53, 0xF0, 0x00, 0xFF, 0xFF, 0xFF, 0xFF, 0xE9, 0x4B, 0x9D, 0xDD, 0xFD });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x1afda65, new byte[] { 0x89, 0x90, 0x4C, 0x53, 0xF0, 0x00  });
                    PS4.WriteMemory(processID, 0x3d23d10, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }

            }

        }

        private void tglTransfer_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglTransfer.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x1afc6a3, new byte[] { 0xe9, 0x98, 0x76, 0x22, 0x02, 0x90 });
                    PS4.WriteMemory(processID, 0x3d23d40, new byte[] { 0xC7, 0x80, 0x38, 0x53, 0xF0, 0x00, 0xFF, 0xFF, 0xFF, 0x1F, 0xE9, 0x59, 0x89, 0xDD, 0xFD });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x1afc6a3, new byte[] { 0x89, 0x88, 0x38, 0x53, 0xf0, 0x00  });
                    PS4.WriteMemory(processID, 0x3d23d40, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }

            }

        }

        private void tglLegend_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglLegend.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xe56084, new byte[] { 0xc6, 0x04, 0x10, 0x32 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0xe56084, new byte[] { 0x40, 0x88, 0x34, 0x10 });
                }

            }

        }
    }
}
