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
    public partial class Fallout4 : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public Fallout4()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[1] == "01.20")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.20");
            }

            Util.attachToGame("eboot.bin", "Fallout 4", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglAmmo_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglAmmo.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xEB7D26, new byte[] { 0x01, 0xD3 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0xEB7D26, new byte[] { 0x89, 0xD3 });
                }

            }

        }

        private void tglItems_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglItems.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x509491, new byte[] { 0x01, 0x4A, 0x20 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x509491, new byte[] { 0x89, 0x4A, 0x20 });
                }

            }

        }

        private void tglSP_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglSP.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xEF5D21, new byte[] { 0xC6, 0x87, 0xC1, 0x0B, 0x00, 0x00, 0xFF });
                }
                else
                {
                    MessageBox.Show("Currently unable to turn this feature off.");
                    //PS4.WriteMemory(processID, 0xEF5D21, new byte[] { 0x89, 0xD3 });
                }

            }

        }

        private void tglWeight_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglWeight.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x4e8abc, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x4e8a70, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x4e8abc, new byte[] { 0xc7, 0x47, 0x58, 0x00, 0x00, 0x80, 0xbf });
                    PS4.WriteMemory(processID, 0x4e8a70, new byte[] { 0x41, 0xc7, 0x47, 0x58, 0x00, 0x00, 0x80, 0xbf });
                }

            }

        }
    }
}
