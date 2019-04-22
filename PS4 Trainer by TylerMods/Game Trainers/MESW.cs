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
    public partial class MESW : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public MESW()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[1] == "1.11")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.11");
            }

            Util.attachToGame("eboot.bin", "Middle Earth Shadow of War", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglBulletTime_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglBulletTime.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x125ec2f, new byte[] { 0xc5, 0xfa, 0x11, 0x83, 0x8c, 0x02, 0x00, 0x00 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x125ec2f, new byte[] { 0xc5, 0xfa, 0x11, 0x83, 0x3c, 0x02, 0x00, 0x00 });
                }

            }

        }

        private void tglArrow_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglArrow.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x146975f, new byte[] { 0x41, 0x8b, 0xbe, 0x98, 0x00, 0x00, 0x00 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x146975f, new byte[] { 0x41, 0x89, 0x9e, 0x98, 0x00, 0x00, 0x00 });
                }

            }

        }

        private void tglSP_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglSP.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x1b12cb4, new byte[] { 0x89, 0x4b, 0x2c });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0x1b12cb4, new byte[] { 0x89, 0x43, 0x20 });
                }

            }

        }
    }
}
