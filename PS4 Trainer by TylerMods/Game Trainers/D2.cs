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
    public partial class D2 : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public D2()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[1] == "1.02")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.02");
            }

            Util.attachToGame("eboot.bin", "Darksiders 2", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);


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
                ulong adr = Util.GetPointerAdress("@23F46F0_3_3FC6F0+30+1A0+80+750", processID);
                if (adr > 0)
                {
                    PS4.WriteSingle(processID, adr, 200);
                }
                else { }
            }

        }

        private void btnGold_Click(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@7892198_3_8E2198+D8+160+10+158+BE8+168+0+114", processID);
                byte[] money = BitConverter.GetBytes((int)numGold.Value);
                if (adr > 0)
                {
                    PS4.WriteMemory(processID, adr, money);
                }
                else { }
            }

        }

        private void tglSkillPoints_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglSkillPoints.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x6bacb3, new byte[] { 0x44, 0x89, 0x73, 0x00 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x6bacb3, new byte[] { 0x44, 0x89, 0x73, 0x44 });
                }

            }

        }

        private void tglReaper_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglReaper.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x647469, new byte[] { 0xc5, 0xfa, 0x11, 0x50, 0x08 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x647469, new byte[] { 0xc5, 0xfa, 0x11, 0x43, 0x08 });
                }

            }

        }

        private void tglGold_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglGold.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x6b5c64, new byte[] { 0x89, 0x43, 0x00 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x6b5c64, new byte[] { 0x89, 0x43, 0x30 });
                }

            }

        }

        private void tglHorseStamina_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglHorseStamina.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x79d52c, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x79d52c, new byte[] { 0x89, 0x87, 0x2c, 0x0e, 0x00, 0x00 });
                }

            }

        }

        private void tglPotion_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglPotion.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x7b0193, new byte[] { 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x7b0193, new byte[] { 0xff, 0x08 });
                }

            }

        }

        private void tglWrath_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglWrath.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x6473dd, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x6473e7, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                    PS4.WriteMemory(processID, 0x647436, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x6473dd, new byte[] { 0xc4, 0xc1, 0x7a, 0x11, 0x4e, 0x04 });
                    PS4.WriteMemory(processID, 0x6473e7, new byte[] { 0xc4, 0xc1, 0x7a, 0x11, 0x46, 0x04 });
                    PS4.WriteMemory(processID, 0x647436, new byte[] { 0xc5, 0xfa, 0x11, 0x50, 0x04 });
                }

            }

        }

        private void btnEXP_Click(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@23F3470_3_3FB470+20+10+10+20", processID);
                byte[] money = BitConverter.GetBytes(28753);
                if (adr > 0)
                {
                    PS4.WriteMemory(processID, adr, money);
                }
                else { }
            }

        }
    }
}
