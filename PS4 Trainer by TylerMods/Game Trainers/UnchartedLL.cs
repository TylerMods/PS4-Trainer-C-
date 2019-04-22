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
using MetroFramework;

namespace PS4_Trainer_by_TylerMods.Game_Trainers
{
    public partial class UnchartedLL : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public UnchartedLL()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            if (Util.GameInfoArray()[0] == "CUSA07875" || Util.GameInfoArray()[1] == "1.00" || Util.GameInfoArray()[1] == "1.08")
            {

            }
            else
            {
                MessageBox.Show("Wrong CUSA or game version! Cheats may not work!");
            }
            Util.attachToGame("eboot.bin", "Uncharted : Lost Legacy", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteMemory(processID, 0x1104B1AEF9, new byte[] { 0x01 });
            MetroMessageBox.Show(this, "L3 + Left Pad Opens 1 menu then L3 + Right Pad opens another. L3 + R3 = noclip.", "Controls", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void UnchartedLL_Load(object sender, EventArgs e)
        {

        }
    }
}
