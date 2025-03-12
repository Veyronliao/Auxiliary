using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using static senke.Driver.DriverEntity;

namespace senke.Driver
{
    public class WinAPI
    {
        // 回调信息结构体
        public struct ProcessInfo
        {
            public int hParentId;       //父进程PID
            public int hProcessId;      //新创建进程的PID
            public bool bCreate;        //创建还是撤消 -> TRUE 创建; FALSE 撤消
        }

        public struct SERVICE_STATUS
        {
            uint dwServiceType;
            uint dwCurrentState;
            uint dwControlsAccepted;
            uint dwWin32ExitCode;
            uint dwServiceSpecificExitCode;
            uint dwCheckPoint;
            uint dwWaitHint;
        }

        #region <Const>
        public const int SC_MANAGER_CREATE_SERVICE = 0x0002;
        public const int SERVICE_START = 0x0010;
        public const int SERVICE_KERNEL_DRIVER = 0x00000001;
        public const int SERVICE_DEMAND_START = 0x00000003;
        public const int SERVICE_ERROR_IGNORE = 0x00000000;

        public const long ERROR_SERVICE_EXISTS = 1073L;

        public const long ERROR_SERVICE_ALREADY_RUNNING = 1056L;

        public const uint GENERIC_READ = 0x80000000;
        public const uint GENERIC_WRITE = 0x40000000;

        public const uint FILE_SHARE_READ = 0x00000001;
        public const uint FILE_SHARE_WRITE = 0x00000002;

        public const uint OPEN_EXISTING = 3;

        public const uint SYNCHRONIZE = (0x00100000);

        public const uint DELETE = (0x00010000);
        public const uint SERVICE_STOP = 0x0020;
        public const uint SERVICE_CONTROL_STOP = 0x00000001;

        #endregion


        #region <WinAPI>
        //打开服务管理器
        [DllImport("advapi32.dll", SetLastError = true)]
        public static extern System.IntPtr OpenSCManager(
          System.String lpMachineName,
          System.String lpDatabaseName,
          System.UInt32 dwDesiredAccess
         );


        [DllImport("advapi32.dll", EntryPoint = "CreateServiceA", SetLastError = true)]
        public static extern System.IntPtr CreateService(
          System.IntPtr hSCManager,
          System.String lpServiceName,
          System.String lpDisplayName,
          System.UInt32 dwDesiredAccess,
          System.UInt32 dwServiceType,
          System.UInt32 dwStartType,
          System.UInt32 dwErrorControl,
          System.String lpBinaryPathName,
          System.String lpLoadOrderGroup,
          System.IntPtr lpdwTagId,
          System.String lpDependencies,
          System.String lpServiceStartName,
          System.String lpPassword
         );


        [DllImport("advapi32.dll")]
        public static extern System.Boolean CloseServiceHandle(
          System.IntPtr hSCObject
         );

        [DllImport("advapi32.dll", SetLastError = true)]
        public static extern System.IntPtr OpenService(
          System.IntPtr hSCManager,
          System.String lpServiceName,
          System.UInt32 dwDesiredAccess
         );

        [DllImport("kernel32.dll", EntryPoint = "GetLastError")]
        public static extern int GetLastError();

        [DllImport("advapi32.dll", EntryPoint = "StartServiceA", SetLastError = true)]
        public static extern int StartService(IntPtr hService, int dwNumServiceArgs, int lpServiceArgVectors);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr CreateFileA(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

        [DllImport("Kernel32.dll", EntryPoint = "OpenEvent", SetLastError = true)]
        public static extern IntPtr OpenEvent(uint dwDesiredAccess, bool bInheritHandle, string lpName);

        [DllImport("kernel32.dll ")]
        public static extern IntPtr CreateEvent(IntPtr lpEventAttributes, bool bManualReset, bool bInitialState, string lpName);

        [DllImport("kernel32.dll ")]
        public static extern uint WaitForMultipleObjects(uint nCount, IntPtr[] lpHandles,
              bool bWaitAll, uint dwMilliseconds);



        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern bool DeviceIoControl(
           IntPtr hDevice,
           uint dwIoControlCode,
           uint lpInBuffer,
           uint nInBufferSize,
           ref ProcessInfo lpOutBuffer,
           uint nOutBufferSize,
           ref uint lpBytesReturned,
           [Out] IntPtr lpOverlapped);

        [DllImport("kernel32.dll")]
        public static extern int CloseHandle(IntPtr hObject);

        [DllImport("advapi32.dll", CharSet = CharSet.Auto)]
        public static extern bool ControlService(IntPtr hService, UInt32 dwControl, ref SERVICE_STATUS lpServiceStatus);
        [DllImport("advapi32.dll", CharSet = CharSet.Auto)]
        public static extern bool DeleteService(IntPtr hService);

        #endregion

    }
}
