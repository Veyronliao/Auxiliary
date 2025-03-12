using System;
using System.Runtime.InteropServices;
using System.Diagnostics;


public class Log
{
    [DllImport("kernel32.dll")]
    public static extern int OutputDebugStringW(string str);

    private static Object thisLock = new Object();

    public static void WriteStr(string format,params object[] args)
    {
        lock (thisLock)
        {
            string str = String.Format(format, args);
            OutputDebugStringW(str);
            Console.WriteLine(str);
        }
    }
}