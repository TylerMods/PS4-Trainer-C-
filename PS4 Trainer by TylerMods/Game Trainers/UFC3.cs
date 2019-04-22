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
using System.Threading;

namespace PS4_Trainer_by_TylerMods.Game_Trainers
{
    public partial class UFC3 : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public UFC3()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[0] == "CUSA06534" || Util.GameInfoArray()[1] == "1.00")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}");
            }
            Util.attachToGame("eboot.bin", "UFC3", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            if (attached)
            PS4.WriteInt32(processID, 0x7002A32CC0, (int)numMoney.Value);
            Thread.Sleep(1000);
            PS4.WriteInt32(processID, 0x701A15F018, (int)numMoney.Value);
            Thread.Sleep(1000);
            PS4.WriteInt32(processID, 0x703A5709B8, (int)numMoney.Value);
        }

        private void btnFans_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x7004BDCA08, (int)numFans.Value);
            Thread.Sleep(1000);
            PS4.WriteInt32(processID, 0x70073E4990, (int)numFans.Value);
            Thread.Sleep(1000);
            PS4.WriteInt32(processID, 0x70073EE0F0, (int)numFans.Value);
            Thread.Sleep(1000);
            PS4.WriteInt32(processID, 0x7024195B84, (int)numFans.Value);
        }
    }
}
