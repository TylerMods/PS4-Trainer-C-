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
    public partial class bbgoty : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public bbgoty()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];
            if (Util.GameInfoArray()[0] == "CUSA03173" || Util.GameInfoArray()[1] == "01.00")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00");
            }

            Util.attachToGame("eboot.bin", "Bloodborne : Game of The Year Edition", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x1E0D894, new byte[] { 0x90, 0x90, 0x90});
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x1E0D894, new byte[] { 0x89, 0x77, 0x08 });
                }

            }
        }

        private void tglStamina_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglStamina.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x1CBDCBD, new byte[] { 0xE9, 0x51, 0xDB, 0x81, 0x03, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x54DB813, new byte[] { 0xB8, 0x5B, 0x00, 0x00, 0x00, 0x41, 0x89, 0x86, 0x34, 0x01, 0x00, 0x00, 0xE9, 0xA0, 0x24, 0x7E, 0xFC });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x1CBDCBD, new byte[] { 0x41, 0x89, 0x86, 0x34, 0x01, 0x00, 0x00 });
                    PS4.WriteMemory(processID, 0x54DB813, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tglItems_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglItems.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x18d9559, new byte[] { 0xE9, 0xA2, 0x22, 0xC0, 0x03, 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x54DB800, new byte[] { 0x41, 0xBC, 0x14, 0x00, 0x00, 0x00, 0x44, 0x89, 0x63, 0x08, 0x48, 0x8D, 0x7D, 0xB8, 0xE9, 0x4E, 0xDD, 0x3F, 0xFC });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x18d9559, new byte[] { 0x44, 0x89, 0x63, 0x08, 0x48, 0x8D, 0x7D, 0xB8 });
                    PS4.WriteMemory(processID, 0x54DB800, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }

            }


        }

        private void tglDeath_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglDeath.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x1D0029B, new byte[] { 0xE9, 0x60, 0xB5, 0x7D, 0x03, 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x54DB830, new byte[] { 0xB9, 0xFF, 0xFF, 0xFF, 0x5F, 0x89, 0x8A, 0x94, 0x00, 0x00, 0x00, 0x29, 0xC1, 0xE9, 0x91, 0x4A, 0x82, 0xFC });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x1D0029B, new byte[] { 0x89, 0x8A, 0x94, 0x00, 0x00, 0x00, 0x29, 0xC1 });
                    PS4.WriteMemory(processID, 0x54DB830, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }

            }

        }
    }
}
