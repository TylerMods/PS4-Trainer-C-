using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using librpc;

namespace PS4_Trainer_by_TylerMods
{
    class Calling
    {
        public static int version = -1;

        public static PS4RPC PS4 = main.PS4;

        public static ulong notifyStub = 0;
        public static int notifyPid = -1;
        public static MemoryEntry libSceLibcInternal = null;

        public static ulong malloc(int size)
        {
            PS4 = main.PS4;
            if (version == 405)
                return PS4.Call(notifyPid, notifyStub, libSceLibcInternal.start + 0x382F0, size);
            else if (version == 455)
                return PS4.Call(notifyPid, notifyStub, libSceLibcInternal.start + 0x2C2A0, size);
            else if (version == 505)
                return PS4.Call(notifyPid, notifyStub, libSceLibcInternal.start + 0x23D90, size);
            else
                return PS4.Call(notifyPid, notifyStub, libSceLibcInternal.start + 0x23D90, size);
        }

        public static void free(ulong address)
        {
            PS4 = main.PS4;
            if (version == 405)
                PS4.Call(notifyPid, notifyStub, libSceLibcInternal.start + 0x38380, address);
            else if (version == 455)
                PS4.Call(notifyPid, notifyStub, libSceLibcInternal.start + 0x2C330, address);
            else if (version == 505)
                PS4.Call(notifyPid, notifyStub, libSceLibcInternal.start + 0x23E20, address);
            else
                PS4.Call(notifyPid, notifyStub, libSceLibcInternal.start + 0x23E20, address);
        }

        public static void Notify(string text, int type = 222)
        {
            PS4 = main.PS4;
            ulong diff;

            if (version == 405)
                diff = 0x300;
            else if (version == 455)
                diff = 0x350;
            else if (version == 505)
                diff = 0x330;
            else
                diff = 0x330;

            PS4.Connect();

            if (notifyPid == -1)
            {
                ProcessList pl = PS4.GetProcessList();

                foreach (Process p in pl.processes)
                {
                    if (p.name == "SceSysCore.elf")
                    {
                        notifyPid = p.pid;
                    }
                }
            }

            ProcessInfo pi = PS4.GetProcessInfo(notifyPid);

            if (notifyStub == 0)
            {
                notifyStub = PS4.InstallRPC(notifyPid);
                libSceLibcInternal = pi.FindEntry("libSceLibcInternal.sprx");
            }

            ulong stringbuf = malloc(text.Length + 1);

            PS4.WriteString(notifyPid, stringbuf, text);

            MemoryEntry libSceSysUtil = pi.FindEntry("libSceSysUtil.sprx");

            PS4.Call(notifyPid, notifyStub, libSceSysUtil.start + diff, type, stringbuf);

            free(stringbuf);
        }
    }
}