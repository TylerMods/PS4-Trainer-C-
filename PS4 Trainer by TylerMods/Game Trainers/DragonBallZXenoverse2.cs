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

namespace PS4_Trainer_by_TylerMods
{
    public partial class DragonBallZXenoverse2 : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;
        
        public DragonBallZXenoverse2()
        {
            InitializeComponent();
        }

        private void DragonBallZXenoverse2_Load(object sender, EventArgs e)
        {
        }

        private void btnZeni_Click(object sender, EventArgs e)
        {
            if (attached)
                
                PS4.WriteInt32(processID, 0x2019691A4, (int)numZeni.Value);
        }

        private void btnEXP_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x20196C200, (int)numEXP.Value);
        }

        private void btnSkillPoints_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x20196C204, (int)numSkillPoints.Value);
        }

        private void btnTPZP_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x2019691A8, (int)numTPZP.Value);
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];
            if (Util.GameInfoArray()[0] == "CUSA05088" || Util.GameInfoArray()[1] == "1.00")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00");
            }

            Util.attachToGame("eboot.bin", "Dragon Ball Z : Xenoverse 2", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }
    }
}
