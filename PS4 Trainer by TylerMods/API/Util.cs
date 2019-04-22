using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using librpc;
using System.Windows.Forms;
using System.Reflection;
using System.Text.RegularExpressions;

namespace PS4_Trainer_by_TylerMods
{
    class Util
    {
        static PS4RPC PS4 = main.PS4;

        int processID = 0;
        ulong processEntry = 0x00;
        List<ulong> entryList = new List<ulong>();
        bool attached = false;

        ulong stub = 0;
        ulong stringbuf;

        static ProcessInfo pi;
        static MemoryEntry vme;

        public static ulong PointerBase(string input, int pid)
        {
            PS4 = main.PS4;
            string temp = input;

            if (temp.StartsWith("@") && temp.Contains("_") && temp.Contains("+"))
            {

                temp = temp.TrimStart('@');
                string[] snip = temp.Split('_');
                int ID = Convert.ToInt32(snip[1]) + 1;
                string[] offset = snip[2].Split('+');

                ProcessInfo PI = PS4.GetProcessInfo(pid);

                ulong Val = Convert.ToUInt64(offset[0], 16);
                Val = Val + PI.entries[ID].start;
                /// MessageBox.Show("WTF "+Val.ToString("X"));
                return Val;

            }
            else
                return 0;
        }

        public static ulong[] PointerLevels(string input)
        {
            string temp = input;

            if (temp.StartsWith("@"))
            {
                string[] snip = temp.Split('+');
                ulong[] levels = new ulong[snip.Length - 1];

                for (int i = 1; i < snip.Length; i++)
                    levels[i - 1] = Convert.ToUInt64(snip[i], 16);

                return levels;
            }
            else
                return null;
        }

        public static ulong GetPointerAdress(string pointer, int pid)
        {
            PS4 = main.PS4;
            try
            {
                ulong currentAddress = 0;

                currentAddress = PS4.ReadUInt64(pid, PointerBase(pointer, pid));

                for (int i = 0; i < PointerLevels(pointer).Length - 1; i++)
                    currentAddress = PS4.ReadUInt64(pid, currentAddress + PointerLevels(pointer)[i]);

                currentAddress = currentAddress + PointerLevels(pointer)[PointerLevels(pointer).Length - 1];

                return currentAddress;
            }
            catch
            {
                return 0;
            }
        }

        public static void attachToGame(string processName, string gameName, ref bool att, ref int pid, ref ulong procEntry, ref List<ulong> _entryList, ref ulong stub, ref ulong stringbuf, bool initRpc = false)
        {
            var cusa = GameInfoArray()[0]; var version = GameInfoArray()[1];
        PS4 = main.PS4;
            try
            {
                PS4.Connect();

                ProcessList pl = PS4.GetProcessList();
                ProcessInfo pi;

                foreach (Process p in pl.processes)
                {
                    if (p.name == processName)
                    {
                        pid = p.pid;
                        pi = PS4.GetProcessInfo(p.pid);
                        _entryList.Clear();

                        for (int i = 0; i < pi.entries.Length; i++)
                        {
                            MemoryEntry me = pi.entries[i];
                            _entryList.Add(me.start);
                        }

                        for (int i = 0; i < pi.entries.Length; i++)
                        {
                            MemoryEntry me = pi.entries[i];
                            if (me.prot == 5)
                            {
                                procEntry = me.start;

                                if (initRpc)
                                {
                                    if (stub == 0)
                                    {
                                        stub = PS4.InstallRPC(pid);
                                        vme = pi.FindEntry("libSceLibcInternal.sprx");

                                        if (Calling.version == 405)
                                            stringbuf = PS4.Call(pid, stub, vme.start + 0x382F0, 0x1000);
                                        else if (Calling.version == 455)
                                            stringbuf = PS4.Call(pid, stub, vme.start + 0x2C2A0, 0x1000);
                                        else if (Calling.version == 505)
                                            stringbuf = PS4.Call(pid, stub, vme.start + 0x23D90, 0x1000);
                                        else
                                            stringbuf = PS4.Call(pid, stub, vme.start + 0x23D90, 0x1000);
                                    }
                                }

                                Calling.Notify("PS4 Trainer by TylerMods\n\nAttached to " + gameName + "!\n\n\n\n\n\n", 210);
                                Launching.main.lblAttached.Text = "Attached : True";
                                    var result = Regex.Replace(
                                    "Attached : True", // input
                                    @"Attached",                                        // word to match
                                    @"<b>$0</b>",                                  // "wrap match in bold tags"
                                    RegexOptions.IgnoreCase);                      // ignore case when matching
                                Launching.main.lblCUSA.Text = $"CUSA : {cusa}";
                                Launching.main.lblGameVersion.Text = $"Version : {version}";
                                Launching.main.lblGame.Text = $"Game : {gameName}";
                                break;
                            }
                        }
                        //MessageBox.Show("Successfully detected game process.\n\nAttached to process (" + p.name + ", " + pid + ")!", "Game Detected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        att = true;
                        return;
                    }
                }

                MessageBox.Show("Failed to detect game process.\nMake sure " + gameName + " is running!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                att = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Launching.main.lblAttached.Text = "Attached : False";
                Launching.main.lblCUSA.Text = "CUSA : Not Attached";
                Launching.main.lblGameVersion.Text = "Version : Not Attached";
                Launching.main.lblGame.Text = "Game : Not Attached";
            }
        }
        public static string[] GameInfoArray()
        {
            PS4 = main.PS4;
            string procName = "SceCdlgApp";
            string entryName = "libSceCdlgUtilServer.sprx";
            ulong titleId = 0xA0;
            ulong version = 0xC8;
            int prot = 3;

            string[] result = new string[2];

            try
            {
                PS4.Connect();
                ProcessList pl = PS4.GetProcessList();

                foreach (Process p in pl.processes)
                {
                    if (p.name == procName)
                    {
                        ProcessInfo pi = PS4.GetProcessInfo(p.pid);

                        for (int i = 0; i < pi.entries.Length; i++)
                        {
                            MemoryEntry me = pi.entries[i];

                            if (me.prot == prot && me.name == entryName)
                            {
                                result[0] = PS4.ReadString(p.pid, me.start + titleId);
                                result[1] = PS4.ReadString(p.pid, me.start + version);

                                return result;
                            }
                        }
                    }
                }

                return new string[] { null, null };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new string[] { null, null };
            }
        }
        //public static void attach()
        //{
        //    var cusa = GameInfoArray()[0]; var version = GameInfoArray()[1];
        //        MessageBox.Show("Your version =" + $"{version}" + "\nYour CUSA =" + $"{cusa}");
        //    attachToGame("eboot.bin", "Attached to" + $"{cusa}\n" + "Version : " + $"{version}", ref attached, ref processID, ref processEntry, ref entryList, ref stub, ref stringbuf);
        //}
    }
}