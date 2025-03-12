using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using static senke.Driver.WinAPI;
using System.Threading;

namespace senke.Driver
{
    /// <summary>
    /// C#加载驱动、创建服务、启动服务
    /// </summary>
    public class NtSysOperate
    {
        private const string EXE_DRIVER_NAME = "ProcessNotify";			//创建的驱动名
        private const string DISPLAY_NAME = "ProcessNotify Driver";	//显示的服务名
        private const string PROCESS_NOTIFY_NAME = "ProcessNotifyEvent";			//进程创建提示驱动名
        private const int IOCTL_GET_PROCESS_INFO = 2285572;    // IO控制码


        //关闭进程创建提示事件
        IntPtr g_hShutdownEvent;
        //加载返回的驱动句柄
        IntPtr hDriver;
        //全局进程创建提示事件
        IntPtr g_hProcessEvent;
        /// <summary>
        /// 进程事件
        /// </summary>
        public event Action<ProcessInfo> OnProcessEvent;

        #region 加载驱动
        /// <summary>
        /// 加载驱动
        /// </summary>
        /// <param name="lpFileName"></param>
        /// <returns></returns>
        public IntPtr LoadDriver(string lpFileName)
        {
            int error = 0;

            string openName = string.Format("\\\\.\\{0}", EXE_DRIVER_NAME);
            IntPtr hSCManager = WinAPI.OpenSCManager(null, null,
            WinAPI.SC_MANAGER_CREATE_SERVICE);

            if (IntPtr.Zero != hSCManager)
            {

                //创建服务
                IntPtr hService = WinAPI.CreateService(hSCManager, EXE_DRIVER_NAME,
                    DISPLAY_NAME, WinAPI.SERVICE_START,
                    WinAPI.SERVICE_KERNEL_DRIVER, WinAPI.SERVICE_DEMAND_START,
                    WinAPI.SERVICE_ERROR_IGNORE, lpFileName, null, IntPtr.Zero, null, null, null);

                if (WinAPI.ERROR_SERVICE_EXISTS == WinAPI.GetLastError())
                {
                    hService = WinAPI.OpenService(hSCManager, EXE_DRIVER_NAME, WinAPI.SERVICE_START);
                }
                error = WinAPI.GetLastError();

                int startflag = WinAPI.StartService(hService, 0, 0);
                if (startflag == 0)
                {
                    error = WinAPI.GetLastError();
                    if (error != WinAPI.ERROR_SERVICE_ALREADY_RUNNING)	//已经启动
                    {
                        //  MessageBox.Show("启动失败");
                    }
                    else
                    {
                        //  MessageBox.Show("服务已经启动");
                    }
                }

                WinAPI.CloseServiceHandle(hService);
                WinAPI.CloseServiceHandle(hSCManager);
                hDriver = WinAPI.CreateFileA(openName, WinAPI.GENERIC_READ | WinAPI.GENERIC_WRITE, 0, IntPtr.Zero, WinAPI.OPEN_EXISTING, 0, IntPtr.Zero);
                // error = WinAPI.GetLastError();
                if (hDriver == (IntPtr)(-1))
                {

                    // MessageBox.Show("获取文件句柄失败");
                }
                else
                {
                    this.OpenDriverEvent();
                }
            }
            return hDriver;
        }

        #endregion

        #region 打开驱动事件
        /// <summary>
        /// 打开驱动事件
        /// </summary>
        private void OpenDriverEvent()
        {
            //打开驱动事件
            g_hProcessEvent = WinAPI.OpenEvent(WinAPI.SYNCHRONIZE, false, PROCESS_NOTIFY_NAME);

            if (g_hProcessEvent != IntPtr.Zero)
            {
                //创建提示事件成功
                Thread th = new Thread(new ThreadStart(MonitorThread));
                th.IsBackground = true;
                th.Start();
            }

        }


        private void MonitorThread()
        {

            uint dwRet;
            //创建关闭事件
            g_hShutdownEvent = WinAPI.CreateEvent(IntPtr.Zero, false, false, null);

            //创建等待事件数组
            IntPtr[] hHandleArray = { g_hShutdownEvent, g_hProcessEvent };

            while (true)
            {

                dwRet = WinAPI.WaitForMultipleObjects(
                 (uint)hHandleArray.Length,
                 hHandleArray, //事件数组
                 false, //只要有事件发生,就返回
                 0xFFFFFFFF //一直等 -1
                 );

                if (hHandleArray[dwRet] == g_hShutdownEvent)
                {
                    //关闭事件产生
                    break;
                }
                else
                {

                    //获取创建的进程信息
                    uint dwRet2 = 0;
                    ProcessInfo pProcInfo = new ProcessInfo();
                    bool bRet = WinAPI.DeviceIoControl(hDriver, IOCTL_GET_PROCESS_INFO, 0, 0, ref pProcInfo, (uint)Marshal.SizeOf(pProcInfo), ref dwRet2, IntPtr.Zero);
                    if (bRet)
                    {

                        if (this.OnProcessEvent != null)
                        {
                            this.OnProcessEvent(pProcInfo);
                        }

                    }
                }

            }
        }
        #endregion

        #region 卸载驱动
        /// <summary>
        /// 卸载驱动
        /// </summary>
        /// <param name="hDriver"></param>
        public void UnloadDriver(IntPtr hDriver)
        {
            //关闭驱动句柄
            WinAPI.CloseHandle(hDriver);

            //打开服务管理器
            IntPtr hSCManager = WinAPI.OpenSCManager(null, null,
                WinAPI.SC_MANAGER_CREATE_SERVICE);

            if (IntPtr.Zero != hSCManager)
            {
                //打开服务
                IntPtr hService = WinAPI.OpenService(hSCManager, EXE_DRIVER_NAME, WinAPI.DELETE | WinAPI.SERVICE_STOP);

                if (IntPtr.Zero != hService)
                {
                    SERVICE_STATUS ss = new SERVICE_STATUS();
                    //停止服务
                    WinAPI.ControlService(hService, WinAPI.SERVICE_CONTROL_STOP, ref ss);
                    //删除服务
                    WinAPI.DeleteService(hService);
                    //关闭服务句柄
                    WinAPI.CloseServiceHandle(hService);
                }
                //关闭服务管理器句柄
                WinAPI.CloseServiceHandle(hSCManager);
            }
        }
        #endregion
    }
}
