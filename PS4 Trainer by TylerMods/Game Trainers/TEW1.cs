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
    public partial class TEW1 : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public TEW1()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];
            if (Util.GameInfoArray()[1] == "01.00")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00");
            }

            Util.attachToGame("eboot.bin", "The Evil Within 1", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglSemiHandgunAmmo_CheckedChanged(object sender)
        {
            if (attached)
                if (tglSemiHandgunAmmo.Checked == true)
                {
                    //PS4.WriteMemory(processID, 0x15c2dcb, new byte[] { 0x41, 0x01, 0xda });
                    PS4.WriteMemory(processID, 0xbd2828, new byte[] { 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0xbd2854, new byte[] { 0x90, 0x90, 0x90 });
                }
                else
                {
                    //PS4.WriteMemory(processID, 0x15c2dcb, new byte[] { 0x41, 0x29, 0xda });
                    PS4.WriteMemory(processID, 0xbd2828, new byte[] { 0x89, 0x48, 0x10 });
                    PS4.WriteMemory(processID, 0xbd2854, new byte[] { 0x89, 0x70, 0x10 });
                }

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x84EA11, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x84EA11, new byte[] { 0xc5, 0xfa, 0x11, 0x87, 0xc4, 0x08, 0x00, 0x00 });
                }

        }

        private void tglGel_CheckedChanged(object sender)
        {
            if (attached)
                if (tglGel.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xA38990, new byte[] { 0x81, 0xC6, 0xFF, 0xFF, 0xFF, 0x00 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0xA38990, new byte[] { 0x03, 0x77, 0x10, 0x89, 0x77, 0x10 });
                }

        }

        private void tglReload_CheckedChanged(object sender)
        {
            if (attached)
                if (tglReload.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xA3AFA8, new byte[] { 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0xA3AFD4, new byte[] { 0x90, 0x90, 0x90 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0xA3AFA8, new byte[] { 0x89, 0x48, 0x10 });
                    PS4.WriteMemory(processID, 0xA3AFD4, new byte[] { 0x89, 0x70, 0x10 });
                }

        }
    }
}
