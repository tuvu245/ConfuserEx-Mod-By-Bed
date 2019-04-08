using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace Confuser.Runtime
{
    internal static class MD5
    {
        static void Initialize()
        {
                var thread = new Thread(Worker);
                thread.IsBackground = true;
                thread.Start(null);
               
        }
   
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
                IntegrityCheck();
                try
                {
                    var bas = new StreamReader(typeof(MD5).Assembly.Location).BaseStream;
                    var file = new BinaryReader(bas);
                    var file2 = File.ReadAllBytes(typeof(MD5).Assembly.Location);

                    byte[] byt = file.ReadBytes(file2.Length - 32);
                    var a = Hash(byt);
                    file.BaseStream.Position = file.BaseStream.Length - 32;
                    string b = Encoding.ASCII.GetString(file.ReadBytes(32));

                    if (a != b)
                    {
                        //uninstall();
                        //Environment.Exit(0);
                        //Environment.FailFast(null);
                        throw new BadImageFormatException();
                    }
                }
                catch
                {
                    //uninstall();
                    //Environment.Exit(0);
                    //Environment.FailFast(null);
                    throw new BadImageFormatException();
                }
                Thread.Sleep(1000);
            }
        }
        public static void IntegrityCheck()
        {
            try
            {
                var bas = new StreamReader(typeof(MD5).Assembly.Location).BaseStream;
                var file = new BinaryReader(bas);
                var file2 = File.ReadAllBytes(typeof(MD5).Assembly.Location);
                byte[] byt = file.ReadBytes(file2.Length - 32);
                var a = Hash(byt);
                file.BaseStream.Position = file.BaseStream.Length - 32;
                string b = Encoding.ASCII.GetString(file.ReadBytes(32));

                if (a != b)
                {
                    //uninstall();
                    //Environment.Exit(0);
                   // Environment.FailFast(null);
                    throw new BadImageFormatException();
                }
            }
            catch
            {
               // uninstall();
                Environment.Exit(0);
                Environment.FailFast(null);
                throw new BadImageFormatException();
            }
        }
        static string Hash(byte[] hash)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] btr = hash;
            btr = md5.ComputeHash(btr);
            StringBuilder sb = new StringBuilder();

            foreach (byte ba in btr)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }
            return sb.ToString();
        }
        /*   public static void uninstall()
           {
               string app_name = Process.GetCurrentProcess().MainModule.FileName;
               string bat_name = app_name + ".bat";
               string bat = "@echo off\n"
                   + ":loop\n"
                   + "del \"" + app_name + "\"\n"
                   + "if Exist \"" + app_name + "\" GOTO loop\n"
                   + "del %0";
               StreamWriter file = new StreamWriter(bat_name);
               file.Write(bat);
               file.Close();
               Process bat_call = new Process();
               bat_call.StartInfo.FileName = bat_name;
               bat_call.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
               bat_call.StartInfo.UseShellExecute = true;
               bat_call.Start();
               Environment.FailFast(null);
               Environment.Exit(0); 
           }
           */
    }
}