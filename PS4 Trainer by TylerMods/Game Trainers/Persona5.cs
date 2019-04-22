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
    public partial class Persona5 : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public Persona5()
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
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}");
            }

            Util.attachToGame("eboot.bin", "Persona 5", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);


        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xca157f, new byte[] { 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0xca157f, new byte[] { 0x41, 0x89, 0x5e, 0x0c });
                }

            }

        }

        private void tglSP_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglSP.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xca15af, new byte[] { 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0xca15af, new byte[] { 0x41, 0x89, 0x5e, 0x10 });
                }

            }

        }

        private void tglInfMoney_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglInfMoney.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xc86a48, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0xc86a48, new byte[] { 0x89, 0x05, 0x26, 0x7c, 0xcd, 0x00 });
                }

            }

        }

        private void tgl2xMoney_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tgl2xMoney.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xc86a48, new byte[] { 0x01, 0x05, 0x26, 0x7c, 0xcd, 0x00 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0xc86a48, new byte[] { 0x89, 0x05, 0x26, 0x7c, 0xcd, 0x00 });
                }

            }

        }

        private void tglEXP_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglEXP.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xc94a17, new byte[] { 0x01, 0x58, 0x1c });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0xc94a17, new byte[] { 0x89, 0x58, 0x1c });
                }

            }

        }
    }
}
