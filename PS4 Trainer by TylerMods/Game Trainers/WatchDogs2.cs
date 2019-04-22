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
    public partial class WatchDogs2 : UserControl
    {
        PS4RPC PS4 = main.PS4;
        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public WatchDogs2()
        {
            InitializeComponent();
        }
        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[0] == "CUSA04294" || Util.GameInfoArray()[1] == "01.00")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00");
            }

            Util.attachToGame("eboot.bin", "Watch Dogs 2", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }


        private void btnFollowers_Click(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong pointer = PS4.ReadUInt64(processID, processEntry + 0x5F45460);
                byte[] followers = BitConverter.GetBytes((int)numFollowers.Value);
                if (pointer > 0)
                {
                    PS4.WriteMemory(processID, pointer+0x6E0, followers);
                }
                else { }
            }
        }
        private void ButtonMoney_Click(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong pointer = PS4.ReadUInt64(processID, processEntry + 0x5F45460);
                byte[] money = BitConverter.GetBytes((int)numMoney.Value);
                if (pointer > 0)
                {
                    PS4.WriteMemory(processID, pointer+0x690, money);
                }
                else {  }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tglAmmo_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglAmmo.Checked)
                {
                    PS4.WriteMemory(processID, processEntry + 0x1292BF3, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    PS4.WriteMemory(processID, processEntry + 0x1292BF3, new byte[] { 0xFF, 0x8B, 0xA0, 0x00, 0x00, 0x00 });
                }
            }
        }
        private void tglBotnet_CheckedChanged(object sender)
        {

            if (attached)
            {
                if (tglBotnet.Checked == true)
                {
                    PS4.WriteMemory(processID, processEntry + 0xE4CBDC, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                }
                else
                {
                    PS4.WriteMemory(processID, processEntry + 0xE4CBDC, new byte[] { 0xC5, 0xFA, 0x11, 0x47, 0x74 });
                }
            }
        }
    }
}
