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
    public partial class Prey : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public Prey()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[1] == "1.04")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}");
            }

            Util.attachToGame("eboot.bin", "Prey", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x1E34B01, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x1E34B01, new byte[] { 0xC5, 0xFA, 0x11, 0x43, 0x40 });
                }

            }

        }

        private void tglInfItems_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglInfItems.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x1818970, new byte[] { 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x1818970, new byte[] { 0x41, 0x89, 0x5E, 0x54 });
                }

            }

        }

        private void tglAmmo_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglAmmo.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x1F94599, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x1F94599, new byte[] { 0xc5, 0xfa, 0x11, 0x43, 0x08 });
                }

            }

        }

        private void tgl2xItems_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tgl2xItems.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x1818970, new byte[] { 0x41, 0x01, 0x5E, 0x54 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x1818970, new byte[] { 0x41, 0x89, 0x5E, 0x54 });
                }

            }

        }
    }
}
