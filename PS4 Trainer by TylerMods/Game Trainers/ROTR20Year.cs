using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using librpc;

namespace PS4_Trainer_by_TylerMods.Game_Trainers
{
    public partial class ROTR20Year : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public ROTR20Year()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[1] == "01.06")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}");
            }

            Util.attachToGame("eboot.bin", "Rise of The Tomb Raider", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            if (attached)
            {
                ulong adr = Util.GetPointerAdress("@658E9490_3_1885490+8+8+8+8+8+8+20+3D0+0+10+40+0+280+18+44", processID);
                byte[] money = BitConverter.GetBytes((int)numSP.Value);
                if (adr > 0)
                {
                    PS4.WriteMemory(processID, adr, money);
                }
                else { }
            }
        }

        private void tglHealth_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (cmbVersion.Text == "CUSA05716")
                {
                    if (tglHealth.Checked == true)
                    {
                        PS4.WriteMemory(processID, 0x7a3789, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
                    }
                    else
                    {
                        //MessageBox.Show("Currently unable to turn this feature off.");
                        PS4.WriteMemory(processID, 0x7a3789, new byte[] { 0xc5, 0xfa, 0x11, 0x4f, 0x28 });
                    }
                }
                if (cmbVersion.Text == "CUSA00109")
                {
                    if (tglHealth.Checked)
                        tmrHealth.Start();
                    else
                        tmrHealth.Stop();

                }
            }

        }

        private void tglAmmo_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (cmbVersion.Text == "CUSA05716")
                {
                    if (tglAmmo.Checked == true)
                    {
                        PS4.WriteMemory(processID, 0xc8750c, new byte[] { 0x90, 0x90, 0x90, 0x90 });
                    }
                    else
                    {
                        //MessageBox.Show("Currently unable to turn this feature off.");
                        PS4.WriteMemory(processID, 0xc8750c, new byte[] { 0x66, 0x89, 0x58, 0x0c });
                    }
                }
                if (cmbVersion.Text == "CUSA00109")
                {
                    if (tglAmmo.Checked == true)
                    {
                        PS4.WriteMemory(processID, 0xc8750c, new byte[] { 0x90, 0x90, 0x90, 0x90 });
                    }
                    else
                    {
                        //MessageBox.Show("Currently unable to turn this feature off.");
                        PS4.WriteMemory(processID, 0xc8750c, new byte[] { 0x66, 0x89, 0x58, 0x0c });
                    }

                }
            }
        }

        private void tglNoReload_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (cmbVersion.Text == "CUSA05716")
                {
                    if (tglNoReload.Checked == true)
                    {
                        PS4.WriteMemory(processID, 0xceb253, new byte[] { 0x90, 0x90 });
                    }
                    else
                    {
                        //MessageBox.Show("Currently unable to turn this feature off.");
                        PS4.WriteMemory(processID, 0xceb253, new byte[] { 0x89, 0x08 });
                    }
                }
                if (cmbVersion.Text == "CUSA00109")
                {
                    if (tglNoReload.Checked == true)
                    {
                        PS4.WriteMemory(processID, 0xa32c52, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                    }
                    else
                    {
                        //MessageBox.Show("Currently unable to turn this feature off.");
                        PS4.WriteMemory(processID, 0xa32c52, new byte[] { 0x41, 0xff, 0x8d, 0xd0, 0x00, 0x00, 0x00 });
                    }

                }
            }
        }

        private void ROTR20Year_Load(object sender, EventArgs e)
        {

        }

        private void cmbVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVersion.Text == "CUSA05716")
            {
                lblVersion.Text = "Game Version : 1.06";
            }
            if (cmbVersion.Text == "CUSA00109")
            {
                lblVersion.Text = "Game Version : 1.00";
            }
        }

        private void tmrHealth_Tick(object sender, EventArgs e)
        {
            if (attached)
            {
                    PS4.WriteSingle(processID, 0x1EB449C, 300);
            }

        }

        private void tglSP_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (cmbVersion.Text == "CUSA05716")
                {
                    MessageBox.Show("This cheat is for v1.00 of the Definitive Edition.");
                }
                if (cmbVersion.Text == "CUSA00109")
                {
                    if (tglSP.Checked == true)
                    {
                        PS4.WriteMemory(processID, 0xb6c3ac, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                    }
                    else
                    {
                        //MessageBox.Show("Currently unable to turn this feature off.");
                        PS4.WriteMemory(processID, 0xb6c3ac, new byte[] { 0x41, 0x89, 0x86, 0x14, 0x25, 0x00, 0x00 });
                    }

                }
            }

        }

        private void tglDupeAmmo_CheckedChanged(object sender)
        {
            if (attached)
            {
                if (cmbVersion.Text == "CUSA05716")
                {
                    if (tglAmmo.Checked == true)
                    {
                        PS4.WriteMemory(processID, 0xc8750c, new byte[] { 0x66, 0x01, 0x58, 0x0c });
                    }
                    else
                    {
                        //MessageBox.Show("Currently unable to turn this feature off.");
                        PS4.WriteMemory(processID, 0xc8750c, new byte[] { 0x66, 0x89, 0x58, 0x0c });
                    }
                }
                if (cmbVersion.Text == "CUSA00109")
                {
                    if (tglAmmo.Checked == true)
                    {
                        PS4.WriteMemory(processID, 0xc8750c, new byte[] { 0x66, 0x01, 0x58, 0x0c });
                    }
                    else
                    {
                        //MessageBox.Show("Currently unable to turn this feature off.");
                        PS4.WriteMemory(processID, 0xc8750c, new byte[] { 0x66, 0x89, 0x58, 0x0c });
                    }

                }
            }

        }
    }
}
