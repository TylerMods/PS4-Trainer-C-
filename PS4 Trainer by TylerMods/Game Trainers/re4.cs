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

namespace PS4_Trainer_by_TylerMods
{
    public partial class re4 : UserControl
    {
        PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        public re4()
        {
            InitializeComponent();
        }

        private void re4_Load(object sender, EventArgs e)
        {
        }

        private void btnMaxHealth_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteMemory(processID, processEntry + 0x1031C88, new byte[] { 0x5A, 0x09, 0xB0, 0x04 });
        }

        private void tglGodMode_CheckedChanged(object sender)
        {
            if (attached)
                if (tglGodMode.Checked == true)
                    PS4.WriteMemory(processID, 0x608A26, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
                else
                    PS4.WriteMemory(processID, 0x608A26, new byte[] { 0x66, 0x89, 0x88, 0x18, 0x50, 0x00, 0x00});
        }

        private void btnSetAmmo_Click(object sender, EventArgs e)
        {
            byte[] ammo = { 0xFF, 0xF9 };

            if (attached)
            {
                if (cmb999Ammo.Text == "Handgun")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D6, ammo); 
                }
            }
        }

        private void btnSetCurrency_Click(object sender, EventArgs e)
        {
            if (attached)
                PS4.WriteInt32(processID, processEntry + 0x1031C7C, (int)numCurrency.Value);
        }

        private void btnFAQ_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, 
                "Q1 : If you change your handgun to certain weapons or items, they may not show up after you leave the case. So, 1)Open inventory. 2)Change handgun from tool. 3)Equip gun, then exit inventory. Before going back to inventory, click the Reset button." +
                "\nA1 : In order for 999 Handgun ammo to work, you need to have never sold the gun from where you started with it in the beginning. " +
                "\n!!! Using (Key Item)s... Change your gun to a key item you need, use the item like normal, then click Reset." +
                "\nMake sure Resident Evil 4 is running!", 
                "Help", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnChangeHandgun_Click(object sender, EventArgs e)
        {
            if (attached)
            {
                if (cmbChangeHandgun.Text == "Activation Key (blue) (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x31 });
                }
                if (cmbChangeHandgun.Text == "Activation Key (red) (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x33 });
                }
                if (cmbChangeHandgun.Text == "Attach Case (L) (Case)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x7E });
                }
                if (cmbChangeHandgun.Text == "Attach Case (M) (Case)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x7D });
                }
                if (cmbChangeHandgun.Text == "Attach Case (S) (Case)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x7C });
                }
                if (cmbChangeHandgun.Text == "Attach Case (XL) (Case)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x7F });
                }
                if (cmbChangeHandgun.Text == "Black Bass (Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x95 });
                }
                if (cmbChangeHandgun.Text == "Black Bass (L) (Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x97 });
                }
                if (cmbChangeHandgun.Text == "Blacktail (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x27 });
                }
                if (cmbChangeHandgun.Text == "Blacktail w/Silencer (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x28 });
                }
                if (cmbChangeHandgun.Text == "Bow Gun (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x10 });
                }
                if (cmbChangeHandgun.Text == "Broken Butterfly (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x29 });
                }
                if (cmbChangeHandgun.Text == "Brown Chicken Egg (Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x09 });
                }
                if (cmbChangeHandgun.Text == "Camp Key (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x8C });
                }
                if (cmbChangeHandgun.Text == "Castle Gate Key (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0xA7 });
                }
                if (cmbChangeHandgun.Text == "Chicago Typewriter (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x06, 0x02 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x34 });
                }
                if (cmbChangeHandgun.Text == "Chicago Typewriter Ammo (Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x6A });
                }
                if (cmbChangeHandgun.Text == "Chicken Egg (Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x08 });
                }
                if (cmbChangeHandgun.Text == "Combat Knife (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x38 });
                }
                if (cmbChangeHandgun.Text == "Custom TMP (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x3E });
                }
                if (cmbChangeHandgun.Text == "Dynamite (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x8D });
                }
                if (cmbChangeHandgun.Text == "Emblem (Left half) (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0xA5 });
                }
                if (cmbChangeHandgun.Text == "Emblem (Right half) (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0xA4 });
                }
                if (cmbChangeHandgun.Text == "Emergency Lock Card Key (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x74 });
                }
                if (cmbChangeHandgun.Text == "False Eye (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x3D });
                }
                if (cmbChangeHandgun.Text == "First Aid Spray (Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x05 });
                }
                if (cmbChangeHandgun.Text == "Flash Grenade (Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x0E });
                }
                if (cmbChangeHandgun.Text == "Freezer Card Key (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x84 });
                }
                if (cmbChangeHandgun.Text == "Gallery Key (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0xA3 });
                }
                if (cmbChangeHandgun.Text == "Goat Ornament (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x1F });
                }
                if (cmbChangeHandgun.Text == "Gold Chicken Egg (Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x0A });
                }
                if (cmbChangeHandgun.Text == "Golden Sword (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x80 });
                }
                if (cmbChangeHandgun.Text == "Green Herb (Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x06 });
                }
                if (cmbChangeHandgun.Text == "Green Herb(2x) (Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x12 });
                }
                if (cmbChangeHandgun.Text == "Green Herb(3x) (Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x13 });
                }
                if (cmbChangeHandgun.Text == "Hand Grenade (Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x01 });
                }
                if (cmbChangeHandgun.Text == "Handcannon (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x37 });
                }
                if (cmbChangeHandgun.Text == "Handcannon Ammo (Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x1A });
                }
                if (cmbChangeHandgun.Text == "Handgun (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x23 });
                }
                if (cmbChangeHandgun.Text == "Handgun Ammo (Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x04 });
                }
                if (cmbChangeHandgun.Text == "Handgun w/Silencer (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x24 });
                }
                if (cmbChangeHandgun.Text == "Hexagonal Emblem (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0xA6 });
                }
                if (cmbChangeHandgun.Text == "Incendiary Grenade (Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x02 });
                }
                if (cmbChangeHandgun.Text == "Infinite Launcher (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x07, 0x02 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x6D });
                }
                if (cmbChangeHandgun.Text == "Infrared Scope (Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0xC5 });
                }
                if (cmbChangeHandgun.Text == "Insignia Key (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x3B });
                }
                if (cmbChangeHandgun.Text == "Iron Key (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x81 });
                }
                if (cmbChangeHandgun.Text == "Jet-ski Key (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x88 });
                }
                if (cmbChangeHandgun.Text == "Key to the Mine (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x7B });
                }
                if (cmbChangeHandgun.Text == "Killer7 (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x2A });
                }
                if (cmbChangeHandgun.Text == "Killer7 w/Silencer (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x2B });
                }
                if (cmbChangeHandgun.Text == "King's Grail (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x6E });
                }
                if (cmbChangeHandgun.Text == "Krauser's Bow (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x06, 0x02 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x52 });
                }
                if (cmbChangeHandgun.Text == "Krauser's Knife (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x0D });
                }
                if (cmbChangeHandgun.Text == "Lift Activation Key (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x8E });
                }
                if (cmbChangeHandgun.Text == "Lion Ornament (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x1E });
                }
                if (cmbChangeHandgun.Text == "Matilda (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x03 });
                }
                if (cmbChangeHandgun.Text == "Mine Thrower (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x36 });
                }
                if (cmbChangeHandgun.Text == "Mine Thrower + Scope (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0xAB });
                }
                if (cmbChangeHandgun.Text == "Mine-Darts (Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x46 });
                }
                if (cmbChangeHandgun.Text == "Mixed Herb (G+R) (Item")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x14 });
                }
                if (cmbChangeHandgun.Text == "Mixed Herb (G+R+Y) (Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x15 });
                }
                if (cmbChangeHandgun.Text == "Mixed Herb (G+Y) (Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x16 });
                }
                if (cmbChangeHandgun.Text == "Mixed Herbs (R+Y) (Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0xA8 });
                }
                if (cmbChangeHandgun.Text == "Moonstone (Left half) (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x69 });
                }
                if (cmbChangeHandgun.Text == "Moonstone (Right half) (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x3A });
                }
                if (cmbChangeHandgun.Text == "Old Key (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x8B });
                }
                if (cmbChangeHandgun.Text == "P.R.L. 412 (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x06, 0x02 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x41 });
                }
                if (cmbChangeHandgun.Text == "Piece of the Holy Beast, Eagle (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x87 });
                }
                if (cmbChangeHandgun.Text == "Piece of the Holy Beast, Panther (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x85 });
                }
                if (cmbChangeHandgun.Text == "Piece of the Holy Beast, Serpent (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x86 });
                }
                if (cmbChangeHandgun.Text == "Plaga Sample (Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x0C });
                }
                if (cmbChangeHandgun.Text == "Platinum Sword (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0xC4 });
                }
                if (cmbChangeHandgun.Text == "Prison Key (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0xC3 });
                }
                if (cmbChangeHandgun.Text == "Punisher (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x21 });
                }
                if (cmbChangeHandgun.Text == "Punisher w/Silencer (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x22 });
                }
                if (cmbChangeHandgun.Text == "Queen's Grail (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x6F });
                }
                if (cmbChangeHandgun.Text == "Red Herb (Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x19 });
                }
                if (cmbChangeHandgun.Text == "Red9 (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x25 });
                }
                if (cmbChangeHandgun.Text == "Red9 w/Stock (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x26 });
                }
                if (cmbChangeHandgun.Text == "Rifle Ammo (Infrared) (Unsure)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0xA0 });
                }
                if (cmbChangeHandgun.Text == "Rifle (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x2E });
                }
                if (cmbChangeHandgun.Text == "Rifle (semi-auto) (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x2F });
                }
                if (cmbChangeHandgun.Text == "Rifle (semi-auto) w/Infrared Scope (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x51 });
                }
                if (cmbChangeHandgun.Text == "Rifle (semi-auto) w/Scope (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x6C });
                }
                if (cmbChangeHandgun.Text == "Rifle + Scope (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x6B });
                }
                if (cmbChangeHandgun.Text == "Rifle Ammo (Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x07 });
                }
                if (cmbChangeHandgun.Text == "Rifle w/Infrared Scope (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x99 });
                }
                if (cmbChangeHandgun.Text == "Riot Gun (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x94 });
                }
                if (cmbChangeHandgun.Text == "Rocket Launcher (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x07, 0x02 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x35 });
                }
                if (cmbChangeHandgun.Text == "Rocket Launcher(Special) (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x07, 0x02 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x17 });
                }
                if (cmbChangeHandgun.Text == "Round Insignia (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x3C });
                }
                if (cmbChangeHandgun.Text == "Salazar Family Insignia (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x9F });
                }
                if (cmbChangeHandgun.Text == "Scope (Mine Thrower) (Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0xAA });
                }
                if (cmbChangeHandgun.Text == "Scope (Rifle) (Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x44 });
                }
                if (cmbChangeHandgun.Text == "Scope(semi - auto rifle)(Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x45 });
                }
                if (cmbChangeHandgun.Text == "Serpent Ornament (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x39 });
                }
                if (cmbChangeHandgun.Text == "Shotgun (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x47 });
                }
                if (cmbChangeHandgun.Text == "Shotgun Ammo (Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x18 });
                }
                if (cmbChangeHandgun.Text == "Silencer (Hangun) (Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x3F });
                }
                if (cmbChangeHandgun.Text == "Stock (Red9) (Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x42 });
                }
                if (cmbChangeHandgun.Text == "Stock (TMP) (Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x43 });
                }
                if (cmbChangeHandgun.Text == "Stone Tablet(Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x1D });
                }
                if (cmbChangeHandgun.Text == "Stone of Sacrifice (Unsure)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x82 });
                }
                if (cmbChangeHandgun.Text == "Storage Room Card Key (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x83 });
                }
                if (cmbChangeHandgun.Text == "Striker (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x2D });
                }
                if (cmbChangeHandgun.Text == "TMP (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x30 });
                }
                if (cmbChangeHandgun.Text == "TMP Ammo (Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x20 });
                }
                if (cmbChangeHandgun.Text == "TMP w/Stock (Weapon)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x32 });
                }
                if (cmbChangeHandgun.Text == "Tactical Vest (Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0xFE });
                }
                if (cmbChangeHandgun.Text == "Waste Disposal Card Key (Key Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x92 });
                }
                if (cmbChangeHandgun.Text == "Yellow Herb (Item)")
                {
                    PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
                    PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x1C });
                }
            }
        }

        private void btnResetGun_Click(object sender, EventArgs e)
        {
            PS4.WriteMemory(processID, entryList[22] + 0x7407D8, new byte[] { 0x02, 0x01 });
            PS4.WriteMemory(processID, entryList[22] + 0x7407CE, new byte[] { 0x23 });
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            var cusa = Util.GameInfoArray()[0]; var version = Util.GameInfoArray()[1];

            if (Util.GameInfoArray()[0] == "CUSA04885" || Util.GameInfoArray()[1] == "1.00")
            {

            }
            else
            {
                MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}" + "\n You need v01.00");
            }

            Util.attachToGame("eboot.bin", "Resident Evil 4", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void flatLabel3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numCurrency_Click(object sender, EventArgs e)
        {

        }

        private void flatLabel2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmb999Ammo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flatLabel1_Click(object sender, EventArgs e)
        {

        }

        private void cmbChangeHandgun_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flatLabel4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tglAmmo_CheckedChanged(object sender)
        {
            if (attached)
                if (tglAmmo.Checked == true)
                {
                    PS4.WriteMemory(processID, 0x6e208e, new byte[] { 0x90, 0x90, 0x90 });
                }
                else
                {
                    PS4.WriteMemory(processID, 0x6e208e, new byte[] { 0x89, 0x43, 0x06 });
                }
        }

        private void tglMatrix_CheckedChanged(object sender)
        {
            if (attached)
                if (tglMatrix.Checked == true)
                    PS4.WriteMemory(processID, 0x6B5C73, new byte[] { 0xc5, 0xfa, 0x10, 0x4f, 0x01 });
                else
                    PS4.WriteMemory(processID, 0x6B5C73, new byte[] { 0xc5, 0xfa, 0x10, 0x4f, 0x04 });

        }

        private void tglInvAmmo_CheckedChanged(object sender)
        {
            if (attached)
                if (tglInvAmmo.Checked == true)
                    PS4.WriteMemory(processID, 0x6e0dee, new byte[] { 0x66, 0x41, 0x01, 0x4f, 0x02 });
                else
                    PS4.WriteMemory(processID, 0x6e0dee, new byte[] { 0x66, 0x41, 0x89, 0x4f, 0x02 });

        }

        private void flatToggle1_CheckedChanged(object sender)
        {
            MessageBox.Show("If you haven't saved, disable this cheat and save");
            if (attached)
            {
                if (tglElevation.Checked == true)
                {
                    if (cmbElevation.Text == "Walk and elevate")
                    {
                        PS4.WriteMemory(processID, 0x6cbf12, new byte[] { 0xC5, 0x7A, 0x11, 0x49, 0x04 });
                    }
                    if (cmbElevation.Text == "No elevation or de-elevation")
                    {
                        PS4.WriteMemory(processID, 0x6cbf12, new byte[] { 0xC5, 0x7A, 0x11, 0x51, 0x04 });
                    }
                }
                else
                {
                    PS4.WriteMemory(processID, 0x6cbf12, new byte[] { 0xC5, 0xFA, 0x11, 0x41, 0x04 });
                }
            }
        }

        private void cmbElevation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
