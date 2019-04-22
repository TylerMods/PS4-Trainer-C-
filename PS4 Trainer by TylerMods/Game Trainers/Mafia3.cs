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
    public partial class Mafia3 : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public Mafia3()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];
            if (Util.GameInfoArray()[1] == "01.00" || Util.GameInfoArray()[1] == "01.09")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}");
            }

            Util.attachToGame("eboot.bin", "Mafia III", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);

        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
                if (cmbVersion.Text == "1.00")
                {
                    if (tglHealth.Checked == true)
                        PS4.WriteMemory(processID, 0x307823B, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                    else
                        PS4.WriteMemory(processID, 0x307823B, new byte[] { 0xC4, 0xC1, 0x7A, 0x10, 0x45, 0x10, 0xC5, 0xF8, 0x2E, 0xD0, 0x73, 0x3F, 0xC5, 0xFA, 0x5C, 0xC2, 0xC5, 0xF8, 0x2E, 0x05, 0x25, 0xF9, 0x9E, 0x01, 0xC4, 0xC1, 0x7A, 0x11, 0x45, 0x10 });
                }
            if (cmbVersion.Text == "v1.09")
            {
                if (tglHealth.Checked == true)
                    PS4.WriteMemory(processID, 0x318862D, new byte[] { 0xc4, 0xc1, 0x7a, 0x11, 0x56, 0x10 });
                else
                    PS4.WriteMemory(processID, 0x318862D, new byte[] { 0xc4, 0xc1, 0x7a, 0x11, 0x46, 0x10 });

            }
        }

        private void tglReload_CheckedChanged(object sender)
        {
            if (attached)
                if (cmbVersion.Text == "v1.00")
                {
                    if (tglReload.Checked == true)
                        PS4.WriteMemory(processID, 0x2A1E30B, new byte[] { 0x90, 0x90, 0x90 });
                    else
                        PS4.WriteMemory(processID, 0x2A1E30B, new byte[] { 0x89, 0x41, 0x18 });
                }
            if (cmbVersion.Text == "v1.09")
            {
                if (tglReload.Checked == true)
                    PS4.WriteMemory(processID, 0x2B1DDAB, new byte[] { 0x90, 0x90, 0x90 });
                else
                    PS4.WriteMemory(processID, 0x2B1DDAB, new byte[] { 0x89, 0x41, 0x18 });
            }

        }

        private void tglAmmo_CheckedChanged(object sender)
        {
            if (attached)
                {
                    if (tglAmmo.Checked == true)
                        PS4.WriteMemory(processID, 0x2A1C54D, new byte[] { 0x90, 0x90, 0x90 });
                    else
                        PS4.WriteMemory(processID, 0x2A1C54D, new byte[] { 0x89, 0x70, 0x04 });
                }
        }

        private void tglMoney_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglMoney.Checked == true)
                    PS4.WriteMemory(processID, 0x1CD9BE7, new byte[] { 0x90, 0x90 });
                else
                    PS4.WriteMemory(processID, 0x1CD9BE7, new byte[] { 0x89, 0x08 });
            }

        }

        private void cmbVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVersion.Text == "v1.00")
            {
                pnlAmmo.Visible = true;
                pnlHealth.Visible = true;
                pnlMed.Visible = false;
                pnlMoney.Visible = false;
                pnlReload.Visible = true;
                pnlThrowables.Visible = false;
            }
            if (cmbVersion.Text == "v1.09")
            {
                pnlAmmo.Visible = false;
                pnlHealth.Visible = true;
                pnlMed.Visible = true;
                pnlMoney.Visible = true;
                pnlReload.Visible = true;
                pnlThrowables.Visible = true;
            }
        }

        private void Mafia3_Load(object sender, EventArgs e)
        {
            pnlAmmo.Visible = false;
            pnlHealth.Visible = false;
            pnlMed.Visible = false;
            pnlMoney.Visible = false;
            pnlReload.Visible = false;
            pnlThrowables.Visible = false;
        }

        private void tglMed_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglMed.Checked == true)
                    PS4.WriteMemory(processID, 0x2B1D386, new byte[] { 0x90, 0x90, 0x90 });
                else
                    PS4.WriteMemory(processID, 0x2B1D386, new byte[] { 0x89, 0x47, 0x14 });
            }

        }

        private void tglThrowables_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglThrowables.Checked == true)
                    PS4.WriteMemory(processID, 0x2B1C05B, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                else
                    PS4.WriteMemory(processID, 0x2B1C05B, new byte[] { 0xc7, 0x41, 0x04, 0x00, 0x00, 0x00, 0x00 });
            }

        }
    }
}
