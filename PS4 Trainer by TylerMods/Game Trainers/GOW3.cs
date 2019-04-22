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
    public partial class GOW3 : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public GOW3()
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

            Util.attachToGame("eboot.bin", "God of War 3", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x45040E, new byte[] { 0xE9, 0xED, 0xAB, 0x29, 0x00, 0x90, 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x6EB000, new byte[] { 0x41, 0x83, 0xBD, 0x60, 0xF6, 0xFF, 0xFF, 0x00, 0x0F, 0x84, 0x09, 0x54, 0xD6, 0xFF, 0xC4, 0xC1, 0x7A, 0x11, 0x85, 0xCC, 0x01, 0x00, 0x00, 0xE9, 0xFB, 0x53, 0xD6, 0xFF });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x45040E, new byte[] { 0xC5, 0xFA, 0x11, 0x83, 0xD0, 0x01, 0x00, 0x00 });
                    PS4.WriteMemory(processID, 0x6EB000, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }

            }

            //if (tglHealth.Checked)
            //{
            //    tmrHealth.Start();
            //}
            //else
            //{
            //    tmrHealth.Stop();
            //}
        }

        private void tglRage_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglRage.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x472CDC, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x472CDC, new byte[] { 0xC5, 0xFA, 0x11, 0x83, 0xD0, 0x01, 0x00, 0x00 });
                }

            }

        }

        private void tglOrbs_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglOrbs.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x46A9FC, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x46A9FC, new byte[] { 0xC5, 0xFA, 0x11, 0x87, 0xE8, 0x01, 0x00, 0x00 });
                }

            }

        }

        private void tmrHealth_Tick(object sender, EventArgs e)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    if (PS4.ReadSingle(processID, 0x2298D4CC0) >= 80)
                    {
                        PS4.WriteSingle(processID, 0x2298D4CC0, 100);
                    }
                }
                else
                {

                }

            }

        }
    }
}
