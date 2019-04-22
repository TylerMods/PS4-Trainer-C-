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

namespace PS4_Trainer_by_TylerMods
{
    public partial class MGSV : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public MGSV()
        {
            InitializeComponent();
        }

        private void MGSV_Load(object sender, EventArgs e)
        {
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

            Util.attachToGame("eboot.bin", "Metal Gear Solid V : Defintive Edition", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void tglHealth_CheckedChanged_1(object sender)
        {
            if (attached)
                if (tglHealth.Checked == true)
                    PS4.WriteMemory(processID, 0x14F305F, new byte[] { 0x90, 0x90, 0x90, 0x90 });
                else
                    PS4.WriteMemory(processID, 0x14F305F, new byte[] { 0xC5, 0xFA, 0x11, 0x08 });

        }

        private void tglAmmo_CheckedChanged(object sender)
        {
            if (attached)
                if (tglAmmo.Checked == true)
                    PS4.WriteMemory(processID, 0x2DC09C1, new byte[] { 0x90, 0x90, 0x90, 0x90 });
                else
                    PS4.WriteMemory(processID, 0x2DC09C1, new byte[] { 0x66, 0x89, 0x0C, 0x72 });

        }

        private void tglGMP_CheckedChanged(object sender)
        {
            if (attached)
                if (tglGMP.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x2B3A660, new byte[] { 0xE9, 0xFB, 0x2E, 0x3E, 0x00, 0x90, 0x90, 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x2f1d560, new byte[] { 0x41, 0xC7, 0x06, 0x80, 0xA1, 0x03, 0x1C, 0xE9, 0xF9, 0xD0, 0xC1, 0xFF });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x2B3A660, new byte[] { 0x41, 0x89, 0x16, 0x80, 0x8b, 0x68, 0x0e, 0x00, 0x00, 0x05 });
                    PS4.WriteMemory(processID, 0x2f1d560, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }
        }

        private void tglHip_CheckedChanged(object sender)
        {
            if (attached)
                //MessageBox.Show("Once your GMP gets high.. turn the cheat off or your GMP may go negative.");
            if (tglHip.Checked == true)
                PS4.WriteMemory(processID, 0x2CF89A3, new byte[] { 0xc5, 0xfa, 0x11, 0x7f, 0x34 });
            else
                PS4.WriteMemory(processID, 0x2CF89A3, new byte[] { 0xc5, 0xfa, 0x11, 0x47, 0x34 });
        }

        private void tglSuppressor_CheckedChanged(object sender)
        {
            if (attached)
                //MessageBox.Show("Once your GMP gets high.. turn the cheat off or your GMP may go negative.");
                if (tglSuppressor.Checked == true)
                    PS4.WriteMemory(processID, 0x2DC0A17, new byte[] { 0x90, 0x90, 0x90, 0x90 });
                else
                    PS4.WriteMemory(processID, 0x2DC0A17, new byte[] { 0x88, 0x4C, 0x42, 0x04 });

        }
    }
}