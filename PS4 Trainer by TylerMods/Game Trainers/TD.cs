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
    public partial class TD : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public TD()
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

            Util.attachToGame("eboot.bin", "Transformers Devastation", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHealth.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x488af0, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x488af0, new byte[] { 0x41, 0x89, 0x94, 0x24, 0x9C, 0x46, 0x00, 0x00 });
                }

            }

        }

        private void tglOptimus_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglOptimus.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x48068a, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x48068a, new byte[] { 0x41, 0xC7, 0x87, 0xFC, 0x46, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }

            }

        }

        private void tglAmmo_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglAmmo.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x515884, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x515884, new byte[] { 0xFF, 0x8B, 0x94, 0x20, 0x00, 0x00 });
                }

            }

        }

        private void tglBumble_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglBumble.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x48043c, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x48043c, new byte[] { 0xC4, 0xC1, 0x7A, 0x11, 0x87, 0xFC, 0x46, 0x00, 0x00 });
                }

            }

        }

        private void tglCredits_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglCredits.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x488e37, new byte[] { 0x41, 0x01, 0x8C, 0x24, 0x58, 0x06, 0x00, 0x00 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x488e37, new byte[] { 0x41, 0x89, 0x8C, 0x24, 0x58, 0x06, 0x00, 0x00 });
                }

            }

        }

        private void tglSideswipe_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglSideswipe.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x461163, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x461163, new byte[] { 0xC4, 0xC1, 0x7A, 0x11, 0x87, 0xFC, 0x46, 0x00, 0x00 });

                }
            }
        }

        private void tglUltimateAttack_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglUltimateAttack.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x45b89c, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x45b89c, new byte[] { 0xC7, 0x83, 0xF8, 0x46, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }

            }

        }

        private void tglWheel_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglWheel.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x43f345, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x43f345, new byte[] { 0xC5, 0xFA, 0x11, 0x83, 0xFC, 0x46, 0x00, 0x00 });
                }
            }
        }

        private void tglXP_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglXP.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x792097, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x792097, new byte[] { 0x89, 0xBC, 0x8A, 0xB0, 0x06, 0x00, 0x00 });
                }

            }

        }
    }
}
