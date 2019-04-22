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
    public partial class MKX : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public MKX()
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
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00");
            }

            Util.attachToGame("eboot.bin", "Mortal Kombat X", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void btnKoin_Click(object sender, EventArgs e)
        {
            PS4.WriteInt32(processID, 0x3723840, (int)numKoin.Value);
        }

        private void tglKoin_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglKoin.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x7b9696, new byte[] { 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x7b9696, new byte[] { 0x44, 0x89, 0x62, 0x30 });
                }

            }

        }
    }
}
