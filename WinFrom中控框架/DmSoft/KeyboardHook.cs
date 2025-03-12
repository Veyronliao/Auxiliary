using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;

namespace senke
{
    public class KeyboardHook
    {
        private const int WM_KEYDOWN = 0x100;
        private const int WM_KEYUP = 0x101;
        private const int WM_SYSKEYDOWN = 0x104;
        private const int WM_SYSKEYUP = 0x105;

        //全局事件  
        public event KeyEventHandler OnKeyDownEvent;
        public event KeyEventHandler OnKeyUpEvent;
        public event KeyPressEventHandler OnKeyPressEvent;

        static int hKeyboardHook = 0;

        //鼠标常量  
        public const int WH_KEYBOARD_LL = 13;

        public delegate int HookProc(int nCode, Int32 wParam, IntPtr lParam);

        //声明键盘钩子事件类型  
        HookProc KeyboardHookProcedure;

        /// <summary>  
        /// 声明键盘钩子的封送结构类型  
        /// </summary>  
        [StructLayout(LayoutKind.Sequential)]
        public class KeyboardHookStruct
        {
            public int vkCode;//表示一个1到254间的虚拟键盘码  
            public int scanCode;//表示硬件扫描码  
            public int flags;
            public int time;
            public int dwExtraInfo;
        }
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        //安装钩子  
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);
        //下一个钩子  
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int CallNextHookEx(int idHook, int nCode, Int32 wParam, IntPtr lParam);
        //卸载钩子  
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern bool UnhookWindowsHookEx(int idHook);

        private int KeyboardHookProc(int nCode, Int32 wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                KeyboardHookStruct MyKBHookStruct = (KeyboardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyboardHookStruct));

                //引发OnKeyDownEvent  
                if (OnKeyDownEvent != null && (wParam == WM_KEYDOWN || wParam == WM_SYSKEYDOWN))
                {
                    Keys keyData = (Keys)MyKBHookStruct.vkCode;
                    KeyEventArgs e = new KeyEventArgs(keyData);
                    OnKeyDownEvent(this, e);
                }
            }
            //KeyboardHookStruct v = (KeyboardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyboardHookStruct));//将捕获的键盘信息存储到存储键盘信息的结构体中
            //Key key = KeyInterop.KeyFromVirtualKey(v.vkCode);//将键盘信息转换成C#中可用的键
            //if (nCode >= 0)//如果code的值大于0说明获取到了按键输入
            //{
            //    if (wParam == WM_KEYDOWN)//检测到键盘按下
            //    {
            //        if (key.ToString() == "Q")
            //        {
            //            MessageBox.Show("按下");
            //        }//要执行的代码段
            //    }
            //    if (wParam == WM_KEYUP)//检测到键盘抬起
            //    {
            //        if (key.ToString() == "Q")
            //        {
            //            MessageBox.Show("抬起");
            //        }//要执行的代码段
            //    }
            //}
            return CallNextHookEx(hKeyboardHook, nCode, wParam, lParam);
        }

        public void Start()
        {
            if (hKeyboardHook == 0)
            {
                KeyboardHookProcedure = new HookProc(KeyboardHookProc);
                using (System.Diagnostics.Process curProcess = System.Diagnostics.Process.GetCurrentProcess())
                using (System.Diagnostics.ProcessModule curModule = curProcess.MainModule)
                    hKeyboardHook = SetWindowsHookEx(WH_KEYBOARD_LL, KeyboardHookProcedure, GetModuleHandle(curModule.ModuleName), 0);

                if (hKeyboardHook == 0)
                {
                    Stop();
                    throw new Exception("Set GlobalKeyboardHook failed!");
                }
            }
        }

        public void Stop()
        {
            bool retKeyboard = true;
            if (hKeyboardHook != 0)
            {
                retKeyboard = UnhookWindowsHookEx(hKeyboardHook);
                hKeyboardHook = 0;
            }
            if (!retKeyboard)
                throw new Exception("Unload GlobalKeyboardHook failed!");
        }

        //构造函数中安装钩子  
        public KeyboardHook()
        {
        }
        //析构函数中卸载钩子  
        ~KeyboardHook()
        {
            Stop();
        }
    }
}
