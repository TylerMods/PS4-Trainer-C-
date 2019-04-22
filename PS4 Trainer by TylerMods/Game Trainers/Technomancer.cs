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
    public partial class Technomancer : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public Technomancer()
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
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}");
            }

            Util.attachToGame("eboot.bin", "The Technomancer", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x8ade38, new byte[] { 0xe9, 0x73, 0x7d, 0x4d, 0x00, 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0xd85bb0, new byte[] { 0x83, 0x7B, 0xD0, 0x00, 0x0F, 0x85, 0x86, 0x82, 0xB2, 0xFF, 0xC5, 0xFA, 0x11, 0x83, 0x48, 0x01, 0x00, 0x00, 0xE9, 0x76, 0x82, 0xB2, 0xFF });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x8ade38, new byte[] { 0xc5, 0xfa, 0x11, 0x83, 0x48, 0x01, 0x00, 0x00 });
                    PS4.WriteMemory(processID, 0xd85bb0, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }

            }

        }

        private void tglXPSP_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglXPSP.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x8af212, new byte[] { 0xe9, 0x99, 0x68, 0x4d, 0x00, 0x90, 0x90, 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0xd85ab0, new byte[] { 0x49, 0xC7, 0xC7, 0xFF, 0x11, 0x11, 0x01, 0xF3, 0x4D, 0x0F, 0x2A, 0xCF, 0xC4, 0x41, 0x7A, 0x11, 0x8C, 0x24, 0xF8, 0x01, 0x00, 0x00, 0xE9, 0x51, 0x97, 0xB2, 0xFF });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x8af212, new byte[] { 0xc4, 0xc1, 0x7a, 0x11, 0x84, 0x24, 0xf8, 0x01, 0x00, 0x00 });
                    PS4.WriteMemory(processID, 0xd85ab0, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }

            }

        }
    }
}
