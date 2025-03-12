using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static senke.Driver.DriverEntity;

namespace senke.Driver
{
    public class DriverBLL
    {

        //private const int IOCTL_GET_PROCESS_INFO = 2285572;   // IO控制码
        public static readonly UInt32 IOCTL_GET_PROCESS_INFO = 2236420;
        /// <summary>
        /// 启动驱动程序
        /// </summary>
        /// <param name="svcName"></param>
        /// <returns></returns>
        public bool StartDriver(String svcName)
        {
            IntPtr scManagerHandle;
            IntPtr schDriverService;

            //打开服务控制台管理器
            scManagerHandle = DriverDAL.OpenSCManager(null, null, DriverEntity.SC_MANAGER_CREATE_SERVICE);
            if (null == scManagerHandle || IntPtr.Zero == scManagerHandle)
            {
                return false;
            }

            //打开服务
            schDriverService = DriverDAL.OpenService(scManagerHandle, svcName, DriverEntity.SERVICE_ALL_ACCESS);
            if (null == schDriverService || IntPtr.Zero == schDriverService)
            {
                DriverDAL.CloseServiceHandle(scManagerHandle);
                return false;
            }

            if (false == DriverDAL.StartService(schDriverService, 0, null))
            {
                DriverDAL.CloseServiceHandle(schDriverService);
                DriverDAL.CloseServiceHandle(scManagerHandle);
                return false;
            }

            DriverDAL.CloseServiceHandle(schDriverService);
            DriverDAL.CloseServiceHandle(scManagerHandle);

            return true;
        }

       
        /// <summary>
        /// 停止驱动程序服务
        /// </summary>
        /// <param name="svcName"></param>
        /// <returns></returns>
        public bool StopDriver(String svcName)
        {
            IntPtr scManagerHandle;
            IntPtr schDriverService;

            DriverEntity.SERVICE_STATUS serviceStatus;

            //打开服务控制台管理器
            scManagerHandle = DriverDAL.OpenSCManager(null, null, DriverEntity.SC_MANAGER_CREATE_SERVICE);
            if (null == scManagerHandle || IntPtr.Zero == scManagerHandle)
            {
                return false;
            }

            //打开服务
            schDriverService = DriverDAL.OpenService(scManagerHandle, svcName, DriverEntity.SERVICE_ALL_ACCESS);
            if (null == schDriverService || IntPtr.Zero == schDriverService)
            {
                DriverDAL.CloseServiceHandle(scManagerHandle);
                return false;
            }

            serviceStatus = new DriverEntity.SERVICE_STATUS();

            //停止服务
            if (false == DriverDAL.ControlService(schDriverService, DriverEntity.SERVICE_CONTROL_STOP, ref serviceStatus))
            {
                DriverDAL.CloseServiceHandle(schDriverService);
                DriverDAL.CloseServiceHandle(scManagerHandle);

                return false;
            }
            else
            {
                DriverDAL.CloseServiceHandle(schDriverService);
                DriverDAL.CloseServiceHandle(scManagerHandle);

                return true;
            }
        }


        /// <summary>
        /// 判断驱动程序是否已经安装
        /// </summary>
        /// <param name="svcName"></param>
        /// <returns></returns>
        public bool DriverIsInstalled(string svcName)
        {
            IntPtr scManagerHandle;
            IntPtr schDriverService;

            //打开服务控制台管理器
            scManagerHandle = DriverDAL.OpenSCManager(null, null, DriverEntity.SC_MANAGER_ALL_ACCESS);
            if (null == scManagerHandle || IntPtr.Zero == scManagerHandle)
            {
                return false;
            }

            //打开驱动程序服务
            schDriverService = DriverDAL.OpenService(scManagerHandle, svcName, DriverEntity.SERVICE_ALL_ACCESS);
            if (null == schDriverService || IntPtr.Zero == schDriverService)
            {
                DriverDAL.CloseServiceHandle(scManagerHandle);
                return false;
            }
            else
            {
                if (false == DriverDAL.StartService(schDriverService, 0, null))
                {
                    Logger.Addlog("开始驱动服务失败！");
                    DriverDAL.CloseServiceHandle(schDriverService);
                    DriverDAL.CloseServiceHandle(scManagerHandle);
                    return false;
                }
                else
                {
                    DriverDAL.CloseServiceHandle(schDriverService);
                    DriverDAL.CloseServiceHandle(scManagerHandle);
                    Logger.Addlog("开始驱动服务成功！");
                }
            }
            DriverDAL.CloseServiceHandle(schDriverService);
            DriverDAL.CloseServiceHandle(scManagerHandle);

            return true;
        }


        /// <summary>
        /// 安装驱动程序服务
        /// </summary>
        /// <param name="svcDriverPath"></param>
        /// <param name="svcDriverName"></param>
        /// <param name="svcDisplayName"></param>
        /// <returns></returns>
        public bool DriverInstall(String svcDriverPath, String svcDriverName, String svcDisplayName)
        {
            IntPtr scManagerHandle;
            IntPtr schDriverService;

            //打开服务控制台管理器
            scManagerHandle = DriverDAL.OpenSCManager(null, null, DriverEntity.SC_MANAGER_ALL_ACCESS);
            if (null == scManagerHandle || IntPtr.Zero == scManagerHandle)
            {
                return false;
            }
            Logger.Addlog("打开服务控制台管理器成功！");
            if (DriverIsInstalled(svcDriverName) == false)
            {
                //创建服务
                schDriverService = DriverDAL.CreateService(
                    scManagerHandle, svcDriverName, svcDisplayName,
                    DriverEntity.SERVICE_ALL_ACCESS,
                    DriverEntity.SERVICE_KERNEL_DRIVER,
                    DriverEntity.SERVICE_DEMAND_START,
                    DriverEntity.SERVICE_ERROR_NORMAL,
                    svcDriverPath, null,
                    IntPtr.Zero,
                    null, null, null
                    );
                long errorCode = DriverDAL.GetLastError();
                DriverDAL.CloseServiceHandle(scManagerHandle);
                if (null == schDriverService || IntPtr.Zero == schDriverService)
                {
                    string xx = string.Format("创建驱动服务失败！参数：scManagerHandle：{0};svcDriverName:{1};svcDisplayName:{2};SERVICE_ALL_ACCESS:{3};SERVICE_KERNEL_DRIVER:{4};SERVICE_DEMAND_START:{5};SERVICE_ERROR_NORMAL:{6};svcDriverPath:{7};",
                       scManagerHandle, svcDriverName, svcDisplayName,
                    DriverEntity.SERVICE_ALL_ACCESS,
                    DriverEntity.SERVICE_KERNEL_DRIVER,
                    DriverEntity.SERVICE_DEMAND_START,
                    DriverEntity.SERVICE_ERROR_NORMAL,
                    svcDriverPath
                        );
                    Logger.Addlog(xx);
                    return false;
                }
                else
                {
                    Logger.Addlog("创建驱动服务成功！");
                    //启动驱动服务
                    if (false == DriverDAL.StartService(schDriverService, 0, null))
                    {
                        Logger.Addlog("开始驱动服务失败！");
                        DriverDAL.CloseServiceHandle(schDriverService);
                        DriverDAL.CloseServiceHandle(scManagerHandle);
                        return false;
                    }
                    Logger.Addlog("开始驱动服务成功！");
                    DriverDAL.CloseServiceHandle(schDriverService);
                    DriverDAL.CloseServiceHandle(scManagerHandle);
                    return true;
                }
            }
            else {
                //打开服务
                //schDriverService = DriverDAL.OpenService(scManagerHandle, svcDriverName, DriverEntity.SERVICE_ALL_ACCESS);
                //if (null == schDriverService || IntPtr.Zero == schDriverService)
                //{
                //    Logger.Addlog("打开驱动服务失败！");
                //    DriverDAL.CloseServiceHandle(scManagerHandle);
                //    return false;
                //}
                //else
                //{
                //    Logger.Addlog("打开驱动服务成功！");
                //}
                
               
            }
                    
            DriverDAL.CloseServiceHandle(scManagerHandle);
            return true;
            ////符号链接名
            //string openName = string.Format("\\\\.\\{0}", "MyDriver");
            //var hDriver = DriverDAL.CreateFile(openName, DriverEntity.GENERIC_READ | DriverEntity.GENERIC_WRITE, 0, IntPtr.Zero, DriverEntity.OPEN_EXISTING, 0, IntPtr.Zero);
            //// error = WinAPI.GetLastError();
            //if (hDriver == (IntPtr)(-1))
            //{
            //    Logger.Addlog("获取文件句柄失败！");
            //}
            //else
            //{
            //    uint dwRet2 = 0;
            //    var pid=System.Diagnostics.Process.GetCurrentProcess().Id;
            //    string pidstr = string.Format("获取pid={0}",pid.ToString());
            //    Logger.Addlog(pidstr);
            //    byte[] inpProcInfo = new byte[10];
            //    Helper.getULong(ref inpProcInfo, (uint)pid);
            //    bool bRet = DriverDAL.DeviceIoControl(hDriver, IOCTL_GET_PROCESS_INFO, inpProcInfo, (uint)Marshal.SizeOf(inpProcInfo), null, 0, ref dwRet2, IntPtr.Zero);
            //    if (bRet)
            //    {
            //        Logger.Addlog("向驱动传输pid成功！");
            //    }
            //    else
            //    {
            //        Logger.Addlog("向驱动传输pid失败！");
            //    }
            //}

        }

        /// <summary>
        /// 卸载驱动程序服务
        /// </summary>
        /// <param name="svcName"></param>
        public void DriverUnInstall(String svcName)
        {
            IntPtr scManagerHandle;
            IntPtr schDriverService;

            //打开服务控制台管理器
            scManagerHandle = DriverDAL.OpenSCManager(null, null, DriverEntity.SC_MANAGER_ALL_ACCESS);
            if (null == scManagerHandle || IntPtr.Zero == scManagerHandle)
            {
                return;
            }

            // 
            schDriverService = DriverDAL.OpenService(scManagerHandle, svcName, DriverEntity.SERVICE_ALL_ACCESS);
            if (IntPtr.Zero != schDriverService)
            {
                SERVICE_STATUS ss = new SERVICE_STATUS();
                //停止服务
                DriverDAL.ControlService(schDriverService, WinAPI.SERVICE_CONTROL_STOP, ref ss);
                Logger.Addlog("停止驱动服务成功！");
                //删除服务
                DriverDAL.DeleteService(schDriverService);
                Logger.Addlog("删除驱动服务成功！");
                //关闭服务句柄
                DriverDAL.CloseServiceHandle(schDriverService);
                Logger.Addlog("关闭驱动服务句柄成功！");
            }
            else
            {
                return;
            }
            //关闭服务管理器句柄
            WinAPI.CloseServiceHandle(scManagerHandle);
            Logger.Addlog("关闭服务管理器句柄成功！");
        }
        

    }
}
