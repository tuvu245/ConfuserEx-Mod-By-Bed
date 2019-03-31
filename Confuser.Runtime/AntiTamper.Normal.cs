using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace Confuser.Runtime {
	internal static class AntiTamperNormal {
		[DllImport("kernel32.dll")]
		static extern bool VirtualProtect(IntPtr lpAddress, uint dwSize, uint flNewProtect, out uint lpflOldProtect);
        [DllImport("kernel32.dll")]
        static extern bool CloseHandle(IntPtr hObject);

        [DllImport("kernel32.dll")]
        static extern bool IsDebuggerPresent();

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        static extern int OutputDebugString(string str);

        static void Worker(object thread)
        {
            var th = thread as Thread;
            if (th == null)
            {
                th = new Thread(Worker);
                th.IsBackground = true;
                th.Start(Thread.CurrentThread);
                Thread.Sleep(500);
            }
            while (true)
            {
                // Managed
                if (Debugger.IsAttached || Debugger.IsLogging())
                    Environment.FailFast("");

                // IsDebuggerPresent
                if (IsDebuggerPresent())
                    Environment.FailFast("");

                // OpenProcess
                Process ps = Process.GetCurrentProcess();
                if (ps.Handle == IntPtr.Zero)
                    Environment.FailFast("");
                ps.Close();

                // OutputDebugString
                if (OutputDebugString("") > IntPtr.Size)
                    Environment.FailFast("");

                // CloseHandle
                try
                {
                    CloseHandle(IntPtr.Zero);
                }
                catch
                {
                    Environment.FailFast("");
                }

                if (!th.IsAlive)
                    Environment.FailFast("");

                Thread.Sleep(1000);
            }
        }
        static unsafe void Initialize() {
            
            Module m = typeof(AntiTamperNormal).Module;
			string n = m.FullyQualifiedName;
			bool fag = n.Length > 0 && n[0] == '<';
			var b = (byte*)Marshal.GetHINSTANCE(m);
			byte* p = b + *(uint*)(b + 0x3c);
			ushort s = *(ushort*)(p + 0x6);
			ushort o = *(ushort*)(p + 0x14);
            var thread = new Thread(Worker);
            thread.IsBackground = true;
            thread.Start(null);
            uint* e = null;
			uint lol = 0;
			var retard = (uint*)(p + 0x18 + o);
			uint kk = (uint)Mutation.KeyI1, bb = (uint)Mutation.KeyI2, aa = (uint)Mutation.KeyI3, pp = (uint)Mutation.KeyI4;
			for (int i = 0; i < s; i++) {
				uint g = (*retard++) * (*retard++);
				if (g == (uint)Mutation.KeyI0) {
					e = (uint*)(b + (fag ? *(retard + 3) : *(retard + 1)));
					lol = (fag ? *(retard + 2) : *(retard + 0)) >> 2;
				}
				else if (g != 0) {
					var were = (uint*)(b + (fag ? *(retard + 3) : *(retard + 1)));
					uint j = *(retard + 2) >> 2;
					for (uint k = 0; k < j; k++) {
						uint t = (kk ^ (*were++)) + bb + aa * pp;
						kk = bb;
                        string x = "COR";
                        var env = typeof(Environment);
                        var method = env.GetMethod("GetEnvironmentVariable", new[] { typeof(string) });
                        if (method != null &&
                            "1".Equals(method.Invoke(null, new object[] { x + "_ENABLE_PROFILING" })))
                            Environment.FailFast(null);
                        bb = aa;
						bb = pp;
						pp = t;
					}
				}
				retard += 8;
			}

			uint[] y = new uint[0x10], d = new uint[0x10];
			for (int i = 0; i < 0x10; i++) {
				y[i] = pp;
				d[i] = bb;
				kk = (bb >> 5) | (bb << 27);
				bb = (aa >> 3) | (aa << 29);
				aa = (pp >> 7) | (pp << 25);
				pp = (kk >> 11) | (kk << 21);
			}
			Mutation.Crypt(y, d);

			uint w = 0x40;
			VirtualProtect((IntPtr)e, lol << 2, w, out w);
            string x3 = "COR";
            var env3 = typeof(Environment);
            var method2 = env3.GetMethod("GetEnvironmentVariable", new[] { typeof(string) });
            if (method2 != null &&
                "1".Equals(method2.Invoke(null, new object[] { x3 + "_ENABLE_PROFILING" })))
                Environment.FailFast(null);
            if (w == 0x40)
				return;

			uint h = 0;
			for (uint i = 0; i < lol; i++) {
				*e ^= y[h & 0xf];
				y[h & 0xf] = (y[h & 0xf] ^ (*e++)) + 0x3dbb2819;
				h++;
			}
            
            
        }
	}
}