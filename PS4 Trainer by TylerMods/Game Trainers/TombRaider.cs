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
    public partial class TombRaider : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public TombRaider()
        {
            InitializeComponent();
        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (tglHealth.Checked)
                tmrHealth.Start();
            else
                tmrHealth.Stop();

        }

        private void tmrHealth_Tick(object sender, EventArgs e)
        {
            if (attached)
            {
                PS4.WriteSingle(processID, 0x1EB449C, 300);
            }

        }

        private void tglSP_CheckedChanged(object sender)
        {
            if (attached)
            {
                    if (tglSP.Checked == true)
                    {
                        PS4.WriteMemory(processID, 0xb6c3ac, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                    }
                    else
                    {
                        //MessageBox.Show("Currently unable to turn this feature off.");
                        PS4.WriteMemory(processID, 0xb6c3ac, new byte[] { 0x41, 0x89, 0x86, 0x14, 0x25, 0x00, 0x00 });
                    }
            }

        }

        private void tglAmmo_CheckedChanged(object sender)
        {
            if (attached)
                if (tglAmmo.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xa34d34, new byte[] { 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0xa34d34, new byte[] { 0x66, 0x89, 0x58, 0x0c });
                }

        }

        private void tglNoReload_CheckedChanged(object sender)
        {
            if (attached)
            {
                    if (tglNoReload.Checked == true)
                    {
                        PS4.WriteMemory(processID, 0xa32c52, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                    }
                    else
                    {
                        //MessageBox.Show("Currently unable to turn this feature off.");
                        PS4.WriteMemory(processID, 0xa32c52, new byte[] { 0x41, 0xff, 0x8d, 0xd0, 0x00, 0x00, 0x00 });
                    }
            }

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

            Util.attachToGame("eboot.bin", "Tomb Raider Definitive Edition", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }
    }
}
