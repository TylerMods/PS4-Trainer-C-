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
    public partial class DAX3 : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public DAX3()
        {
            InitializeComponent();
            pnlInfMoney.Visible = false;
            pnlMoney.Visible = false;
            pnlx2Money.Visible = false;
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[0] == "CUSA04555" || Util.GameInfoArray()[1] == "1.00")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00");
            }

            Util.attachToGame("eboot.bin", "Dead or Alive : Xtreme 3", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x20226ED88, (int)numMoney.Value);
        }

        private void flatComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVersion.Text == "v1.00")
            {
                pnlInfMoney.Visible = false;
                pnlMoney.Visible = true;
                pnlx2Money.Visible = false;
            }
            if (cmbVersion.Text == "v1.16")
            {
                pnlInfMoney.Visible = true;
                pnlMoney.Visible = false;
                pnlx2Money.Visible = true;
            }
        }

        private void tglStamina_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglStamina.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x7d6d7f, new byte[] { 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x7d6d7f, new byte[] { 0x89, 0x51, 0x58 });
                }

            }

        }

        private void flatToggle1_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (flatToggle1.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x7d6d7f, new byte[] { 0x01, 0x51, 0x58 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x7d6d7f, new byte[] { 0x89, 0x51, 0x58 });
                }

            }

        }
    }
}
