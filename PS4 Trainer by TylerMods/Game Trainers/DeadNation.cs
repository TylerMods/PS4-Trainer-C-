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
    public partial class DeadNation : UserControl
    {
        PS4RPC PS4 = main.PS4;
        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public DeadNation()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[0] == "CUSA00176" || Util.GameInfoArray()[1] == "1.03")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.03");
            }

            Util.attachToGame("eboot.bin", "Dead Nation", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

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
                PS4.WriteSingle(processID, 0x206AE3D5C, 150);
        }

        private void btnAmmo_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteMemory(processID, 0x490110, new byte[] { 0x90, 0x90 });
            PS4.WriteMemory(processID, 0x49009C, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });

        }

        private void btnThrowable_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteMemory(processID, 0x490754, new byte[] { 0x90, 0x90 });

        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteMemory(processID, 0x49DD12, new byte[] { 0x90, 0x90, 0x90, 0x90 });
            PS4.WriteMemory(processID, 0x49DE42, new byte[] { 0x90, 0x90, 0x90, 0x90 });
            PS4.WriteMemory(processID, 0x49E17D, new byte[] { 0x90, 0x90, 0x90, 0x90 });

        }

        private void btnStamina_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteMemory(processID, 0xDC7375, new byte[] { 0xC5, 0xFA, 0x11, 0x0F });

        }
    }
}
