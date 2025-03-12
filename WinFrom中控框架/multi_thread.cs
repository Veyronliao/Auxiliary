using System;
using System.Threading;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace senke
{

    // 线程状态
    public enum ThreadState
    {
        State_Inactive = -1,           // 未启动
        State_Starting = 0,            // 正在启动
        State_Runing,                  // 正在运行
        State_Pausing,                 // 正在暂停
        State_Pause,                   // 暂停
        State_Resuming,                // 正在恢复
        State_Stoping,                 // 正在停止
    }

    // 异步通知(用于线程通知UI)
    public class AsyncNotify
    {
        [DllImport("user32.dll")]
        public static extern bool PostMessageW(IntPtr hwnd, int message, int wparam, int lparam);

        // 消息ID
        public static int WM_NOTIFY_ID = 0x400 + 0x555;

        // 消息Code
        public static int Update = 0;
        public static int Stop = 1;
        public static int Restart = 2;

        // 主窗口句柄
        public static IntPtr m_main_hwnd;

        public static void Notify(int hwnd, int code)
        {
            PostMessageW(m_main_hwnd, WM_NOTIFY_ID, hwnd, code);
        }
    }

    // 同步通知(用于UI更新)
    public class SyncNotify
    {
        [DllImport("user32.dll")]
        public static extern bool SendMessageW(IntPtr hwnd, int message, int wparam, int lparam);

        // 消息ID
        public static int WM_NOTIFY_ID = 0x400 + 0x556;

        // 消息Code
        public static int Update = 0;
        public static int Add = 1;
        public static int Delete = 2;

        // 主窗口句柄
        public static IntPtr m_main_hwnd;

        public static void Notify(int hwnd, int code)
        {
            SendMessageW(m_main_hwnd, WM_NOTIFY_ID, hwnd, code);
        }
    }
    /// <summary>
    /// 线程基类
    /// </summary>
    public class BaseThread
    {
        // 仅允许子类访问
        protected Thread m_thread;


        public bool m_pause = false;
        public ThreadState m_state = ThreadState.State_Inactive;

        // 此线程用到的对象,必须在线程函数内部创建
        protected dmsoft m_dm = null;

        public int m_hwnd = 0;
        public int m_pid = 0;


        // 初始化,设置必须的数据
        public void Init(int hwnd, int pid)
        {
            m_hwnd = hwnd;
            m_pid = pid;

            ReInit();
        }

        public virtual void ReInit()
        {
            m_pause = false;
            m_state = ThreadState.State_Inactive;
        }

        // 启动
        public bool Start()
        {
            if (m_thread.IsAlive == false)
            {
                m_state = ThreadState.State_Starting;
                SyncNotify.Notify(m_hwnd, SyncNotify.Update);

                // 这里设置com线程模型为mta
                m_thread.SetApartmentState(ApartmentState.STA);
                m_thread.Start();
            }

            return true;
        }

        // 停止
        public bool Stop()
        {
            if (m_thread.IsAlive)
            {
                m_state = ThreadState.State_Stoping;
                SyncNotify.Notify(m_hwnd, SyncNotify.Update);

                Log.WriteStr("abort : {0}", m_hwnd);

                m_thread.Abort();
                // 等待线程结束
                m_thread.Join();

                ReInit();
                SyncNotify.Notify(m_hwnd, SyncNotify.Update);
            }

            return true;
        }

        // 暂停
        public bool Pause()
        {
            if (m_thread.IsAlive)
            {
                if (m_state == ThreadState.State_Runing || m_state == ThreadState.State_Resuming)
                {
                    m_pause = true;
                    m_state = ThreadState.State_Pausing;
                    SyncNotify.Notify(m_hwnd, SyncNotify.Update);
                }
            }

            return true;
        }

        // 恢复
        public bool Resume()
        {
            if (m_thread.IsAlive)
            {
                if (m_state == ThreadState.State_Pause || m_state == ThreadState.State_Pausing)
                {
                    m_pause = false;
                    m_state = ThreadState.State_Resuming;
                    SyncNotify.Notify(m_hwnd, SyncNotify.Update);
                }
            }

            return true;
        }
    }

    // 主线程
    public class MainThread : BaseThread
    {
        // 任务状态
        // 这里必须使用char[]类型，并且预先要分配好内存,否则后面多个线程访问此数据会造成内存访问异常
        public char[] m_task_state = new char[100];

        public Script m_script = null;

        public MainThread(Script script)
            : base()
        {
            ReInit();
            m_script = script;
        }

        public override void ReInit()
        {
            base.ReInit();

            m_thread = new Thread(MainEntry);
            // 这里不要用background线程,如果UI结束时，可能会导致无法解绑等问题
            m_thread.IsBackground = false;
            m_task_state[0] = '\0';
        }

        // 主线程入口
        private void MainEntry()
        {
            // 创建对象
            m_dm = new dmsoft();

            try
            {
                m_script.MainEntry(m_dm);
            }
            catch (Exception)
            {
                // 必须在这里进行对象释放的操作
                m_dm.ReleaseObj();
                Log.WriteStr("excep main");
            }

            m_dm.ReleaseObj();
        }
    }

    //副线程
    public class SubThread : BaseThread
    {
        // 异常状态状态
        // 这里必须使用char[]类型，并且预先要分配好内存,否则后面多个线程访问此数据会造成内存访问异常
        public char[] m_excep_state = new char[100];

        public Script m_script;

        public SubThread(Script script)
            : base()
        {
            ReInit();

            m_script = script;
        }


        public override void ReInit()
        {
            base.ReInit();

            m_thread = new Thread(SubEntry);
            // 这里不要用background线程,如果UI结束时，可能会导致无法解绑等问题
            m_thread.IsBackground = false;
            string temp = "无异常";
            temp.CopyTo(0, m_excep_state, 0, temp.Length);
            m_excep_state[temp.Length] = '\0';
        }

        // 副线程入口
        private void SubEntry()
        {
            // 创建对象
            m_dm = new dmsoft();

            try
            {
                m_script.SubEntry(m_dm);
            }
            catch (Exception)
            {
                // 必须在这里进行对象释放的操作
                m_dm.ReleaseObj();
                Log.WriteStr("excep sub");
            }

            m_dm.ReleaseObj();
        }
    }



    public class MultiThread
    {
        public List<Script> m_scripts;
        public dmsoft m_dm;


        public MultiThread(dmsoft dm)
        {
            m_scripts = new List<Script>();
            m_dm = dm;
        }

        public Script GetScript(int hwnd)
        {
            foreach (Script script in m_scripts)
            {
                if (script.m_main_thread.m_hwnd == hwnd)
                {
                    return script;
                }
            }

            return null;
        }

        private bool ThreadIsStart(int hwnd)
        {
            if (GetScript(hwnd) != null)
            {
                return true;
            }

            return false;
        }


        //public bool ThreadStart_bak(int hwnd)
        //{
        //    if (hwnd == 0)
        //    {
        //        Log.WriteStr("无效的窗口句柄");
        //        return false;
        //    }

        //    if (ThreadIsStart(hwnd))
        //    {
        //        Log.WriteStr("已经启动了");
        //        return true;
        //    }


        //    // 创建script
        //    Script script = new Script();
        //    int pid = m_dm.GetWindowProcessId(hwnd);

        //    // 初始化
        //    script.m_main_thread.Init(hwnd, pid);
        //    script.m_sub_thread.Init(hwnd, pid);

        //    // 添加到链表
        //    m_scripts.Add(script);

        //    Log.WriteStr("{0}", hwnd);
        //    // 通知UI更新
        //    SyncNotify.Notify(hwnd, SyncNotify.Add);

        //    // 启动
        //    script.Start();

        //    Log.WriteStr(String.Format("启动 hwnd = {0}", hwnd));

        //    return true;
        //}

        public bool ThreadStart(UserItem useritem)
        {
            if (ThreadIsStart(useritem.hwnd))
            {
                Log.WriteStr("已经启动了");
                return true;
            }
            // 创建script
            Script script = new Script(useritem);
            //script.SetUser(useritem);
            //int pid = m_dm.GetWindowProcessId(hwnd);

            // 初始化
            //script.m_main_thread.Init(hwnd, pid);
            script.m_sub_thread.ReInit();
            script.m_main_thread.ReInit();

            // 添加到链表
            m_scripts.Add(script);

            // 通知UI更新
            SyncNotify.Notify(useritem.hwnd, SyncNotify.Add);

            // 启动
            script.Start();

            Log.WriteStr(String.Format("启动 hwnd = {0}", useritem.hwnd));

            return true;
        }

        public void ThreadPause(int hwnd)
        {
            Script script = GetScript(hwnd);

            if (script == null)
            {
                return;
            }

            script.Pause();

            Log.WriteStr(String.Format("暂停 hwnd = {0}", hwnd));
        }

        public void ThreadResume(int hwnd)
        {
            Script script = GetScript(hwnd);

            if (script == null)
            {
                return;
            }

            script.Resume();

            Log.WriteStr(String.Format("恢复 hwnd = {0}", hwnd));
        }

        public void ThreadStop(int hwnd)
        {
            Script script = GetScript(hwnd);

            if (script == null)
            {
                return;
            }

            script.Stop();

            // 通知UI删除
            SyncNotify.Notify(hwnd, SyncNotify.Delete);

            // 从链表删除
            m_scripts.Remove(script);


            Log.WriteStr(String.Format("结束成功 hwnd = {0}", hwnd));
        }

        public void ThreadRestart(int hwnd)
        {
            Script script = GetScript(hwnd);

            if (script == null)
            {
                return;
            }

            script.Stop();
            script.Start();

            Log.WriteStr(String.Format("重新运行 hwnd = {0}", hwnd));
        }
    }
}