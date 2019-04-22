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
    public partial class GodofWar4 : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public GodofWar4()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[0] == "CUSA07410" || Util.GameInfoArray()[1] == "1.00")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00");
            }

            Util.attachToGame("eboot.bin", "God of War 4", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void btnMaxHealth_Click(object sender, EventArgs e)
        {
            if (attached)
            PS4.WriteSingle(processID, 0x1148B473C8, 200);
        }

        private void tglGodMode_CheckedChanged(object sender)
        {
            if (tglGodMode.Checked)
                tmrHealth.Start();
            else
                tmrHealth.Stop();
        }

        private void tmrHealth_Tick(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteSingle(processID, 0x1146600000 + 0x5473C8, 101);
        }

        private void flatNumeric13_Click(object sender, EventArgs e)
        {

        }

        private void btnVita_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteSingle(processID, 0x1146600000 + 0x5473C8, (int)numVita.Value);
        }

        private void btnXP_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x1080200000 + 0x2FBD8E0, (int)numXP.Value);
        }

        private void btnRage_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteSingle(processID, 0x1146600000 + 0x547428, (int)numRage.Value);
        }

        private void btnHacksilver_Click(object sender, EventArgs e)
        {
            if (attached)
            PS4.WriteInt32(processID, 0x1080200000 + 0x2FBDAA0, (int)numHacksilver.Value);
        }

        private void btnCorruptRemnant_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x1080200000 + 0x2FC1760, (int)numCorruptRemnant.Value);
        }

        private void btnAegirGold_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x1080200000 + 0x2FBDE20, (int)numAegirGold.Value);
        }

        private void btnFrozenFlame_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x1080200000 + 0x2FBE4A0, (int)numFrozenFlame.Value);
        }

        private void btnApples_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x1080200000 + 0x2FC1F60, (int)numApples.Value);
        }

        private void btnHeatWave_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x1080200000 + 0x2FBF0E0, (int)numHeatWave.Value);
        }

        private void btnMistEcho_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x10831BF060, (int)numMistEcho.Value);
        }

        private void btnNiflheimAlloy_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x1080200000 + 0x2FBF0A0, (int)numNiflheimAlloy.Value);
        }

        private void btnSmoulderEmber_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x1080200000 + 0x2FBEE20, (int)numSmoulderEmber.Value);
        }

        private void btnAesirbane_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x1080200000 + 0x2FBF120, (int)numAesirbane.Value);
        }

        private void btnGreaterCrest_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x1080200000 + 0x2FBEEA0, (int)numGreaterCrest.Value);
        }

        private void btnAncientRubble_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x1080200000 + 0x2FBDDA0, (int)numAncientRubble.Value);
        }

        private void btnCrest_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x1080200000 + 0x2FBEE60, (int)numCrest.Value);
        }

        private void btnDustRealms_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x1080200000 + 0x2FBE7A0, (int)numDustRealms.Value);
        }

        private void btnAncientHeart_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x1080200000 + 0x2FBDDE0, (int)numAncientHeart.Value);
        }

        private void btnFAQ_Click(object sender, EventArgs e)
        {
                        MetroMessageBox.Show(this, 
                "Q1 : Why are there gaps?" +
                "\nA1 : There are cheats I made invisible due to them not working and didn't delete them for future use." +
                "\nMake sure God of War is running!", 
                "Help", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnChaosFlame_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x10831BE5E0, (int)numChaosFlame.Value);
        }

        private void btnAsenfluch_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x10831BF120, (int)numAsenfluch.Value);
        }

        private void btnRustyArmor_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x10831BF160, (int)numRustyArmor.Value);
        }

        private void btnNielRec_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x10831BF0A0, (int)numNielRec.Value);
        }

        private void tglArrows_CheckedChanged(object sender)
        {
            if (tglArrows.Checked)
                tmrArrows.Start();
            else
                tmrArrows.Stop();
        }

        private void tmrArrows_Tick(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteSingle(processID, 0x1183E74278, 40);
        }

        private void btnSurtr_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x10831BEEE0, (int)numSurtr.Value);

        }

        private void btnPerfectAsgardianSteel_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x10831BEC20, (int)numPerfectAsgardianSteel.Value);

        }

        private void btnPrisScales_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x10831BF3E0, (int)numPrisScales.Value);

        }

        private void btnPrisOre_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x10831BF3A0, (int)numPrisOre.Value);

        }

        private void btnDragonTear_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x10831C16E0, (int)numDragonTear.Value);

        }

        private void btnAOF_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, 0x10831BF1A0, (int)numAOF.Value);
        }

        private void tglRage_CheckedChanged(object sender)
        {
            if (tglRage.Checked)
                tmrRage.Start();
            else
                tmrRage.Stop();

        }

        private void tmrRage_Tick(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteSingle(processID, 0x1146600000 + 0x547428, (int)numRage.Value);
        }

        private void tglResources_CheckedChanged(object sender)
        {
            if (attached)
            {
                MessageBox.Show("Once your resource gets high.. don't use that resource anymore until you turn the cheat off or your resource may go negative.");

                if (tglResources.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xd07406, new byte[] { 0x01, 0x08 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0xd07406, new byte[] { 0x89, 0x08 });
                }

            }
        }

        private void tglResourceDecrease_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (tglResourceDecrease.Checked == true)
                {
                    PS4.WriteMemory(processID, 0xd07406, new byte[] { 0x90, 0x90 });
                }
                else
                {
                    //MessageBox.Show("Currently unable to turn this feature off.");
                    PS4.WriteMemory(processID, 0xd07406, new byte[] { 0x89, 0x08 });
                }

            }

        }
    }
}
