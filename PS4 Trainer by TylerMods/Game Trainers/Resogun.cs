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
    public partial class Resogun : UserControl
    {
        PS4RPC PS4 = main.PS4;
        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public Resogun()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[0] == "CUSA00038" || Util.GameInfoArray()[1] == "1.00")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00");
            }

            Util.attachToGame("eboot.bin", "Resogun", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (tglHealth.Checked)
                tmrTurbo.Start();
            else
                tmrTurbo.Stop();

        }

        private void flatToggle1_CheckedChanged(object sender)
        {
            if (flatToggle1.Checked)
                tmrOverdrive.Start();
            else
                tmrOverdrive.Stop();

        }

        private void btnLives_Click(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@F41138_2_F9138+658+8+10+48+18+8+0+0+18+10+20+7D0+18+C4", processID);
                byte[] money = BitConverter.GetBytes((int)numLives.Value);
                if (adr > 0)
                {
                    PS4.WriteMemory(processID, adr, money);
                }
                else { }
            }

        }

        private void btnBombs_Click(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@F41138_2_F9138+4F8+8+10+48+18+8+0+0+18+10+20+7D0+18+C0", processID);
                byte[] money = BitConverter.GetBytes((int)numBombs.Value);
                if (adr > 0)
                {
                    PS4.WriteMemory(processID, adr, money);
                }
                else { }
            }

        }

        private void tmrTurbo_Tick(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@F41070_2_F9070+E8+8F8+8+10+48+18+8+0+0+18+10+20+6B0+18+60", processID);
                byte[] money = BitConverter.GetBytes(1065353216);
                if (adr > 0)
                {
                    PS4.WriteMemory(processID, adr, money);
                }
                else { }
            }

        }

        private void tmrOverdrive_Tick(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@F41070_2_F9070+E8+38+8+10+48+18+8+0+0+18+10+20+750+18+5C", processID);
                byte[] money = BitConverter.GetBytes(1065353216);
                if (adr > 0)
                {
                    PS4.WriteMemory(processID, adr, money);
                }
                else { }
            }

        }
    }
}
