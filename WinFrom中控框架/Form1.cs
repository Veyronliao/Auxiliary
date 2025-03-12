using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
//using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using senke.Configs;
using senke.DmSoft;
using senke.Driver;
using MessageBoxView;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace senke
{
    public partial class Form1 : Form
    {

        [DllImport(DmConfig.HaoiRegDllPath)] //字符串写的是 DLL 所在目录，支持相对路径，默认是程序的跟目录（文件夹）
        public static extern int SendFileEx(string MyUserStr, string GameID, string FilePath, int TimeOut, int LostPoint, string BeiZhu, StringBuilder retTid, StringBuilder retStr);
        [DllImport(DmConfig.HaoiRegDllPath)] //字符串写的是 DLL 所在目录，支持相对路径，默认是程序的跟目录（文件夹）
        public static extern int SendFile(string MyUserStr, string GameID, string FilePath, int TimeOut, int LostPoint, string BeiZhu, StringBuilder retStr);
        //[DllImport("DmConfig.HaoiRegDllPath")] //字符串写的是 DLL 所在目录，支持相对路径，默认是程序的跟目录（文件夹）
        //public static extern int SendByteEx(string MyUserStr, string GameID, byte* PicBytes, int lenBytes, int TimeOut, int LostPoint, string BeiZhu, StringBuilder retTid, StringBuilder retStr);
        //[DllImport("DmConfig.HaoiRegDllPath")] //字符串写的是 DLL 所在目录，支持相对路径，默认是程序的跟目录（文件夹）
        //public static extern int SendByte(string MyUserStr, string GameID, byte* PicBytes, int lenBytes, int TimeOut, int LostPoint, string BeiZhu, StringBuilder retStr);
        [DllImport(DmConfig.HaoiRegDllPath)] //字符串写的是 DLL 所在目录，支持相对路径，默认是程序的跟目录（文件夹）
        public static extern bool IsRight(string Response);
        [DllImport(DmConfig.HaoiRegDllPath)] //字符串写的是 DLL 所在目录，支持相对路径，默认是程序的跟目录（文件夹）
        public static extern void SetRebate(string partnerID);
        [DllImport(DmConfig.HaoiRegDllPath)] //字符串写的是 DLL 所在目录，支持相对路径，默认是程序的跟目录（文件夹）
        public static extern int SetQuality(int Quality);
        [DllImport(DmConfig.HaoiRegDllPath)] //字符串写的是 DLL 所在目录，支持相对路径，默认是程序的跟目录（文件夹）
        public static extern int SendError(string ID, StringBuilder retStr);
        [DllImport(DmConfig.HaoiRegDllPath)] //字符串写的是 DLL 所在目录，支持相对路径，默认是程序的跟目录（文件夹）
        public static extern int GetAnswer(string id, StringBuilder retStr);

        [DllImport(DmConfig.HaoiRegDllPath)]
        public static extern int GetPoint(string MyUserStr, StringBuilder retStr);
        [DllImport(DmConfig.HaoiRegDllPath)]
        public static extern int RegID(string MyId, string MyPass, string MyEmail, string MyQQ, string From, int IsSon, StringBuilder retStr);
        [DllImport(DmConfig.HaoiRegDllPath)]
        public static extern int Login(string Id, string Pass, StringBuilder retStr);
        [DllImport(DmConfig.HaoiRegDllPath)]
        public static extern int Pay(string Id, string Card, StringBuilder retStr);
        [DllImport(DmConfig.HaoiRegDllPath)]
        public static extern int UseKey(string Id, string Keys, int Point, StringBuilder retStr);
        [DllImport(DmConfig.HaoiRegDllPath)]
        public static extern int CheckKey(string Id, string Keys, StringBuilder retStr);
        [DllImport(DmConfig.HaoiRegDllPath)]
        public static extern int KeyEndDate(string Id, string Keys, StringBuilder retStr);
        [DllImport(DmConfig.HaoiRegDllPath)]
        public static extern int WriteWordtoJPG(string FilePath, string PicWH, string XYWrods, int Size, string RGBcolor);
        public static ReaderWriterLock readerwritelock = new ReaderWriterLock();
        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        public extern static IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern int ShowWindow(IntPtr hwnd, int nCmdShow);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(int hWnd, int msg, int wParam, int lparam);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int PostMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);


        [System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential)]
        public class SECURITY_ATTRIBUTES
        {
            public int nLength;
            public string lpSecurityDescriptor;
            public bool bInheritHandle;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct STARTUPINFO
        {
            public int cb;
            public string lpReserved;
            public string lpDesktop;
            public int lpTitle;
            public int dwX;
            public int dwY;
            public int dwXSize;
            public int dwYSize;
            public int dwXCountChars;
            public int dwYCountChars;
            public int dwFillAttribute;
            public int dwFlags;
            public int wShowWindow;
            public int cbReserved2;
            public byte lpReserved2;
            public IntPtr hStdInput;
            public IntPtr hStdOutput;
            public IntPtr hStdError;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct PROCESS_INFORMATION
        {
            public IntPtr hProcess;
            public IntPtr hThread;
            public int dwProcessId;
            public int dwThreadId;
        }
        [DllImport("Kernel32.dll", CharSet = CharSet.Ansi)]
        public static extern bool CreateProcess(
            StringBuilder lpApplicationName, StringBuilder lpCommandLine,
            SECURITY_ATTRIBUTES lpProcessAttributes,
            SECURITY_ATTRIBUTES lpThreadAttributes,
            bool bInheritHandles,
            int dwCreationFlags,
            StringBuilder lpEnvironment,
            StringBuilder lpCurrentDirectory,
            ref STARTUPINFO lpStartupInfo,
            ref PROCESS_INFORMATION lpProcessInformation
            );


        public string RootPath = System.AppDomain.CurrentDomain.BaseDirectory;
        // 定义一个全局dm对象保持
        private dmsoft m_dm;
        // 多线程控制
        private MultiThread m_multi_thread;
        public string serverName = string.Empty;
        public string bigServerName = string.Empty;
        public static List<string> TaskArray;
        //xml配置文件路径
        string path = System.AppDomain.CurrentDomain.BaseDirectory + "configfile.xml";
        //创建xml实例对象
        XmlDocument xmldoc = new XmlDocument();
        KeyboardHook key = new KeyboardHook();
        GameOperation gameOperation;
        public Form1()
        {
            InitializeComponent();
            Logger.InitListView(listView_log);
            //加载驱动
            DriverBLL dbll = new DriverBLL();
            string sysPath = System.AppDomain.CurrentDomain.BaseDirectory + "Resources\\MyDriver.sys";
            //dbll.DriverUnInstall("MyDriver001");
            //dbll.DriverInstall(sysPath, "MyDriver001", "MyDriver001");
            string file = System.Windows.Forms.Application.ExecutablePath;
            Configuration config = ConfigurationManager.OpenExeConfiguration(file);
            var appSettingServerName = config.AppSettings.Settings["serverName"].Value.ToString();
            //加载账号信息
            LooadUserInfo();
            //从xml文件加载数据
            LoadFromXML();
            CheckForIllegalCrossThreadCalls = false;
            // 初始化,这里保存主窗口句柄
            AsyncNotify.m_main_hwnd = this.Handle;
            SyncNotify.m_main_hwnd = this.Handle;
            Log.WriteStr("main_hwnd = {0}", AsyncNotify.m_main_hwnd);
            // 免注册调用大漠插件
            var registerDmSoftDllResult = RegisterDmSoft.RegisterDmSoftDll();
            if (!registerDmSoftDllResult)
            {
                Logger.Addlog("免注册调用大漠插件失败");
                return;
            }
            // 创建全局对象，此对象必须全程保持，不可释放.
            m_dm = new dmsoft();
            m_multi_thread = new MultiThread(m_dm);
            // 收费注册
            var regResult = m_dm.Reg(ConfigurationManager.AppSettings["regCode"].ToString(), ConfigurationManager.AppSettings["additionCode"].ToString());
            if (regResult != 1)
            {
                //throw new Exception("收费注册失败");
                Logger.Addlog("收费注册失败");
                return;
            }
            // 判断 Resources 是否存在，不存在就创建
            if (!Directory.Exists(DmConfig.DmGlobalPath))
            {
                Directory.CreateDirectory(DmConfig.DmGlobalPath);
            }
            //加盾
            //m_dm.DmGuard(1, "memory");
            //m_dm.DmGuard(1, "block ");
            //m_dm.DmGuard(1, "phide");
            //m_dm.DmGuard(1, "f1");
            //m_dm.DmGuard(1, "hm 0 1");蓝屏
            //m_dm.DmGuard(1, "memory2");
            // 设置全局路径,设置了此路径后,所有接口调用中,相关的文件都相对于此路径. 比如图片,字库等
            Logger.Addlog("设置全局路径成功");
            m_dm.SetPath(DmConfig.DmGlobalPath);
            m_dm.EnableShareDict(1);
            Logger.Addlog("开启真实键盘成功");
            m_dm.EnableRealKeypad(1);
            Logger.Addlog("开启真实鼠标成功");
            m_dm.EnableRealMouse(2, 20, 30);
            m_dm.SetPath(DmConfig.DmGlobalPath);
            Logger.Addlog("设置字库成功");
            m_dm.EnableShareDict(0);
            //m_dm.SetDict(0, "login.txt");
            m_dm.EnableShareDict(1);
            //m_dm.EnableRealKeypad(1);
            //m_dm.EnableRealMouse(2, 20, 30);
            m_dm.SetPath(DmConfig.DmGlobalPath);
            m_dm.EnableShareDict(1);
            //m_dm.SetDict(0, "login.txt");
            m_dm.SetDict(1, "number.txt");
            m_dm.SetDict(2, "sum9.txt");
            //timer_tips.Start();
            gameOperation = new GameOperation(m_dm);
            //Log.WriteStr(m_dm.Ver());
            //设置日志列表滚动
            listView_log.EnsureVisible(listView_log.Items.Count - 1);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //调用键盘钩子函数,隐藏或者显示窗体
            //key.OnKeyDownEvent += key_OnKeyDownEvent;
            //key.Start();
            this.FormClosing += Form1_FormClosing;
            //this.FormClosed += Form1_FormClosed;
            //DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            //headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            //this.dataGridView1.ColumnHeadersDefaultCellStyle = headerStyle;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            单人任务全选框勾选();
            组队任务全选框勾选();
            限时任务全选框勾选();
            领取全选全选框勾选();
            提升全选全选框勾选();
        }
        void key_OnKeyDownEvent(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyData.ToString() == "F7")
            {
                this.Show();
                this.ShowInTaskbar = true;//显示在任务栏
                this.Opacity = 1;
            }
            if (e.KeyData.ToString() == "F8")
            {
                this.Hide();

                this.ShowInTaskbar = false;//不显示在任务栏
                this.Opacity = 0;
            }
        }

        private void LoadFromXML()
        {
            xmldoc.Load(path);
            //获取portConfigure配置节点
            XmlNode paraConfigure = xmldoc.SelectSingleNode("Configure/Login");
            string customerPath = paraConfigure.SelectSingleNode("Customerpath").InnerText;
            txt_gamepath.Text = customerPath.Trim();

            XmlNode serverDataConfigure = xmldoc.SelectSingleNode("Configure");
            //验证姓名
            string 验证姓名 = serverDataConfigure.SelectSingleNode("yanzhengxingming").InnerText.Trim();
            txt_yanzhengxingming.Text = 验证姓名;
            //身份证号
            string 身份证号 = serverDataConfigure.SelectSingleNode("shenfenzhenghao").InnerText.Trim();
            txt_shenfenzhenghao.Text = 身份证号;
            //服务大区坐标
            List<Coordinate> areacoorlist = new List<Coordinate>();
            string areacoordinate = serverDataConfigure.SelectSingleNode("areacoordinate").InnerText.Trim();
            if (!string.IsNullOrEmpty(areacoordinate))
            {
                var areacoors=areacoordinate.Split('|');
                for (int i = 0; i < areacoors.Length; i++)
                {
                    Coordinate coordinate = new Coordinate();
                    var item = areacoors[i].Split(':');
                    coordinate.CoordinateName = item[0];
                    coordinate.CoordinateValue = item[1];
                    areacoorlist.Add(coordinate);
                }
            }
            ScriptData.AreaCoordinate=new List<Coordinate>() {  };
            ScriptData.AreaCoordinate.AddRange(areacoorlist);
            //抖音服
            List<Coordinate> douyinareacoorlist = new List<Coordinate>();
            string douyinareacoordinate = serverDataConfigure.SelectSingleNode("douyinareacoordinate").InnerText.Trim();
            if (!string.IsNullOrEmpty(douyinareacoordinate))
            {
                var areacoors = douyinareacoordinate.Split('|');
                for (int i = 0; i < areacoors.Length; i++)
                {
                    Coordinate coordinate = new Coordinate();
                    var item = areacoors[i].Split(':');
                    coordinate.CoordinateName = item[0];
                    coordinate.CoordinateValue = item[1];
                    douyinareacoorlist.Add(coordinate);
                }
            }
            ScriptData.DouYinAreaCoordinate=new List<Coordinate>() {  };
            ScriptData.DouYinAreaCoordinate.AddRange(douyinareacoorlist);
            areacoorlist.Clear();
            douyinareacoorlist.Clear();
            //服务器对应坐标
            string servercoordinate = serverDataConfigure.SelectSingleNode("servercoordinate").InnerText.Trim();
            if (!string.IsNullOrEmpty(servercoordinate))
            {
                var servercoors = servercoordinate.Split('|');
                for (int i = 0; i < servercoors.Length; i++)
                {
                    Coordinate coordinate = new Coordinate();
                    var item = servercoors[i].Split(':');
                    coordinate.CoordinateName = item[0];
                    coordinate.CoordinateValue = item[1];
                    areacoorlist.Add(coordinate);
                }
            }
            ScriptData.ServerCoordinate = new List<Coordinate>() {  };
            ScriptData.ServerCoordinate.AddRange(areacoorlist);
            areacoorlist.Clear();
            string douyinservercoordinate = serverDataConfigure.SelectSingleNode("douyinservercoordinate").InnerText.Trim();
            if (!string.IsNullOrEmpty(douyinservercoordinate))
            {
                var servercoors = douyinservercoordinate.Split('|');
                for (int i = 0; i < servercoors.Length; i++)
                {
                    Coordinate coordinate = new Coordinate();
                    var item = servercoors[i].Split(':');
                    coordinate.CoordinateName = item[0];
                    coordinate.CoordinateValue = item[1];
                    areacoorlist.Add(coordinate);
                }
            }
            ScriptData.DouYinServerCoordinate = new List<Coordinate>() { };
            ScriptData.DouYinServerCoordinate.AddRange(areacoorlist);
            areacoorlist.Clear();
            //生活采集
            this.check_shenghuocaiji.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("shenghuocaiji").InnerText);
            this.cob_shenghuocaijixuanxiang.SelectedItem = serverDataConfigure.SelectSingleNode("shenghuocaijixuanxiang").InnerText.Trim();
            this.cob_shenghuocaijixuanxiangjishu.SelectedItem = serverDataConfigure.SelectSingleNode("shenghuocaijixuanxiangjishu").InnerText.Trim();
            //生活制造
            this.check_shenghuozhizao.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("shenghuozhizao").InnerText);
            this.cob_shenghuozhizaoxuanxiang.SelectedItem = serverDataConfigure.SelectSingleNode("shenghuozhizaoxuanxiang").InnerText.Trim();
            this.cob_shenghuozhizaoxuanxiangjishu.SelectedItem = serverDataConfigure.SelectSingleNode("shenghuozhizaoxuanxiangjishu").InnerText.Trim();
            //身份验证
            this.check_autologin.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("autologin").InnerText);
            this.check_regroupteam.Checked= bool.Parse(serverDataConfigure.SelectSingleNode("teamup").InnerText);
            this.chk_qiehuanjuese.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("autoswitch").InnerText);
            this.check_mainLine.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("mainline").InnerText);
            this.txt_mainlinelimittime.Text = serverDataConfigure.SelectSingleNode("mainlinelimittime").InnerText.Trim();
            this.check_zongshidiantang.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("zongshidiantang").InnerText);
            this.check_menpairenwu.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("menpairenwu").InnerText);
            this.check_wenjianxiayi.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("wenjianxiayi").InnerText);
            this.check_nagongqixiang.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("nagongqixiang").InnerText);
            this.check_banghuirenwu.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("banghuirenwu").InnerText);
            this.check_banghuiyanwu.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("banghuiyanwu").InnerText);
            this.check_jianghufanguan.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("jianghufanguan").InnerText);
            this.check_yanziwu.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("yanziwu").InnerText);
            this.check_yongchuangshanzhai.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("yongchuangshanzhai").InnerText);
            this.check_zhenlongqiju.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("zhenlongqiju").InnerText);
            this.check_xixiawangling.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("xixiawangling").InnerText);
            this.cob_xixiawanglingcengshu.SelectedItem = serverDataConfigure.SelectSingleNode("xixiawanglingcengshu").InnerText.Trim();
            this.txt_xixiawanglingxianzhishijian.Text= serverDataConfigure.SelectSingleNode("xixiawanglingxianzhishijian").InnerText.Trim();
            this.check_jianghujixiong.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("jianghujixiong").InnerText);
            this.check_hanyuliangong.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("hanyuliangong").InnerText);
            this.checkshendulunjian.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("shendulunjian").InnerText);
            this.check_banghuiyunbiao.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("banghuiyunbiao").InnerText);
            this.check_bianguanwenzhan.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("bianguanwenzhan").InnerText);
            this.check_sidaeren.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("sidaeren").InnerText);
            this.check_xiaoxiao.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("xiaoxiao").InnerText);
            this.check_gaobeiqiju.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("gaobeiqiju").InnerText);
            this.check_baoshishengyan.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("baoshishengyan").InnerText);
            this.check_chengjiujiangli.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("chengjiujiangli").InnerText);
            this.check_juexuechanwu.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("juexuecanwu").InnerText);
            this.check_shoushanyoujian.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("shoushanyoujian").InnerText);
            this.check_huoyuejiangli.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("huoyuejiangli").InnerText);
            this.check_jishijiangli.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("jishijiangli").InnerText);
            this.check_hongfubaoxiang.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("hongfubaoxiang").InnerText);
            this.check_yuyuejiangli.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("yuyuejiangli").InnerText);
            this.check_huodongzhaohui.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("huodongzhaohui").InnerText);
            this.check_fulijiangli.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("fulijiangli").InnerText);
            this.check_fenjiezhuangbei.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("fenjiezhuangbei").InnerText);
            this.check_chuandaizhuangbei.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("chuandaizhuangbei").InnerText);
            this.check_qianghuazhuangbei.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("qianghuazhuangbei").InnerText);
            this.check_kemingzhuangbei.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("kemingzhuangbei").InnerText);
            this.cob_kemingjishu.SelectedItem = serverDataConfigure.SelectSingleNode("kemingzhuangbeijishu").InnerText.Trim();
            this.check_jingtongzhuangbei.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("jingtongzhuangbei").InnerText);
            this.check_xiangqianzhuangbei.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("xiangqianzhuangbei").InnerText);
            this.check_wuxueduanti.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("wuxueduanti").InnerText);
            this.check_shuxingjiadian.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("shuxingjiadian").InnerText);
            this.check_tupoxinjing.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("tupoxinjing").InnerText);
            this.check_shengjijineng.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("shengjijineng").InnerText);
            this.check_qinglibeibao.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("qinglibeibao").InnerText);
            this.check_chongwujiadian.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("chongwujiadian").InnerText);
            this.check_chongwuchuzhan.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("chongwuchuzhan").InnerText);
            this.check_tianjiayaopin.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("tianjiayaopin").InnerText);
            this.check_beibaojiesuo.Checked = bool.Parse(serverDataConfigure.SelectSingleNode("beibaojiesuo").InnerText);
        }
        /// <summary>
        /// 加载账号信息
        /// </summary>
        public void LooadUserInfo()
        {
            string accountStr = Helper.ReadPerfile(RootPath + "\\UserAccount.txt");
            accountStr = accountStr.Replace("\r", "");
            if (!string.IsNullOrEmpty(accountStr))
            {
                var lineArray = accountStr.Split('\n');
                if (lineArray.Length > 0)
                {
                    for (int i = 0; i < lineArray.Length; i++)
                    {
                        var accountitemArray = lineArray[i].Split('|');
                        bool iscapt = accountitemArray[7] == "1" ? true : false;
                        dataGridView1.Rows.Add(true, accountitemArray[0], accountitemArray[1], accountitemArray[2], accountitemArray[3], accountitemArray[4], accountitemArray[5], accountitemArray[6], iscapt, "未开始", accountitemArray[8], accountitemArray[9]);
                    }
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                DataGridViewCheckBoxCell dgvCheck = (DataGridViewCheckBoxCell)(this.dataGridView1.Rows[i].Cells["isSelect"]);
                if (Convert.ToBoolean(dgvCheck.EditedFormattedValue) == false)
                {
                    dgvCheck.Value = true;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                DataGridViewCheckBoxCell dgvCheck = (DataGridViewCheckBoxCell)(this.dataGridView1.Rows[i].Cells["isSelect"]);
                if (Convert.ToBoolean(dgvCheck.EditedFormattedValue) == true)
                {
                    dgvCheck.Value = false;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                DataGridViewCheckBoxCell dgvCheck = (DataGridViewCheckBoxCell)(this.dataGridView1.Rows[i].Cells["isSelect"]);
                if (Convert.ToBoolean(dgvCheck.EditedFormattedValue) == true)
                {
                    dgvCheck.Value = false;
                }
                else
                {
                    dgvCheck.Value = true;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                DataGridViewCheckBoxCell dgvCheck = (DataGridViewCheckBoxCell)(this.dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells["isSelect"]);
                if (Convert.ToBoolean(dgvCheck.EditedFormattedValue) == false)
                {
                    dgvCheck.Value = true;
                }
                else
                {
                    dgvCheck.Value = false;
                }
            }
        }


        /// <summary>
        /// 一键启动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception"></exception>
       
        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Win32.RegistryKey cKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", true);
            this.button1.Enabled = false;
            if (string.IsNullOrEmpty(txt_gamepath.Text))
            {
                MessageBoxMidle.Show(this, "请选择游戏启动程序", "提示");
                this.button1.Enabled = true;
                return;
            }
            m_dm.delay(2000);
            m_dm.delay(2000);
            m_dm.UseDict(0);
            m_dm.delay(1000);
            //好友列表
            List<string> frends = new List<string>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell dgvCheck = (DataGridViewCheckBoxCell)(this.dataGridView1.Rows[i].Cells["isSelect"]);
                if (Convert.ToBoolean(dgvCheck.EditedFormattedValue) == true) {
                    frends.Add(dataGridView1.Rows[i].Cells["nickname"].Value.ToString());
                }
            }
            //启动模拟器
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                //启动游戏
                DataGridViewCheckBoxCell dgvCheck = (DataGridViewCheckBoxCell)(this.dataGridView1.Rows[i].Cells["isSelect"]);
                if (Convert.ToBoolean(dgvCheck.EditedFormattedValue) == true)
                {
                    dataGridView1.Rows[i].Cells["status"].Value = "运行中...";
                    UserItem user = new UserItem();
                    user.Index = i;
                    user.account = this.dataGridView1.Rows[i].Cells["account"].Value.ToString();
                    user.isCaptain = bool.Parse(this.dataGridView1.Rows[i].Cells["isCaptain"].Value.ToString());
                    user.passWard = this.dataGridView1.Rows[i].Cells["password"].Value.ToString();
                    user.ServerName = this.dataGridView1.Rows[i].Cells["server"].Value.ToString();
                    user.AreaName = this.dataGridView1.Rows[i].Cells["area"].Value.ToString();
                    user.Role = int.Parse(this.dataGridView1.Rows[i].Cells["role"].Value.ToString());
                    user.nickname = this.dataGridView1.Rows[i].Cells["nickname"].Value.ToString();
                    //var itemList = listBox_Tasking.Items.Cast<String>().ToList();
                    //user.Tasks = itemList;
                    user.Sect = this.dataGridView1.Rows[i].Cells["sect"].Value.ToString();
                    user.Emulator = this.dataGridView1.Rows[i].Cells["emulator"].Value.ToString();
                    user.Platform = this.dataGridView1.Rows[i].Cells["platform"].Value.ToString();
                    user.Delays = 600;
                    user.FriendsList = frends;
                    
                    //初始化任务信息
                    InitUserInfo(user);
                    //测试用代码
                    //m_multi_thread.ThreadStart(user);
                    //break;
                    //开启雷电模拟器
                    var exist_hwnd_str = m_dm.EnumWindow(0, user.Emulator, "LDPlayerMainFrame", 1 + 2 + 4 + 16);
                    if (!string.IsNullOrEmpty(exist_hwnd_str))
                    {
                       var exist_hwnd = int.Parse(exist_hwnd_str);
                        //绑定子窗口
                        var childhwnd = m_dm.GetWindow(exist_hwnd, 1);
                        if (childhwnd != 0)
                        {
                            var script = m_multi_thread.m_scripts.Find(s => s.user.hwnd == childhwnd);
                            if (script == null)
                            {
                                user.hwnd= childhwnd;
                            }
                        }

                    }
                    else
                    {
                        STARTUPINFO sInfo = new STARTUPINFO();
                        PROCESS_INFORMATION pInfo = new PROCESS_INFORMATION();
                        int index = i + 1;//官服从第七个开始
                        //int index = i;
                        string commandline = string.Format(txt_gamepath.Text + " index=" + index + "|");
                        if (!CreateProcess(null, new StringBuilder(commandline), null, null, false, 0, null, null, ref sInfo, ref pInfo))
                        {
                            throw new Exception("调用失败");
                        }
                        while (true)
                        {
                            //定义窗口句柄变量
                            int hwnd = 0;
                            m_dm.delay(1000);
                            //在游戏登录界面查找窗口句柄（窗口类名会变，根据窗口标题来查找）
                            //枚举窗口
                            //新倩女幽魂Online 版本[827234] 服务器[未知] 次世代
                            int titleIndex = i + 1;
                            //int titleIndex = i;
                            //string title = "雷电模拟器-" + index;
                            string title = user.Emulator.ToString();
                            var hwnds = m_dm.EnumWindow(0, title, "LDPlayerMainFrame", 1 + 2 + 4 + 16);
                            if (!string.IsNullOrEmpty(hwnds))
                            {
                                var hwndsArray = hwnds.Split(',');
                                if (hwndsArray.Length > 0)
                                {
                                    foreach (var item in hwndsArray)
                                    {
                                        //找第一个子窗体句柄
                                        var childhwnd = m_dm.GetWindow(int.Parse(item), 1);
                                        if (childhwnd != 0)
                                        {
                                            var script = m_multi_thread.m_scripts.Find(s => s.user.hwnd == childhwnd);
                                            if (script == null)
                                            {
                                                //var xx = m_dm.SetWindowSize(int.Parse(item), 1002, 575);
                                                hwnd = childhwnd;
                                                break;
                                            }
                                        }

                                    }
                                    if (hwnd != 0)
                                    {
                                        user.hwnd = hwnd;
                                        break;//找到窗口句柄则跳出当前循环
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    m_dm.Delays(1000, 1200);
                    //开启线程
                    m_multi_thread.ThreadStart(user);
                    //等待m_multi_thread.m_scripts列表成功添加script，必须确保添加进list后再开启下一个线程，因为上面的代码要判断窗口句柄是否已经绑定过
                    while (true)
                    {
                        var script = m_multi_thread.m_scripts.Find(s => s.user.hwnd == user.hwnd);
                        if (script != null)
                        {
                            break;
                        }
                        m_dm.delay(1000);
                    }
                    //readerwritelock.ReleaseReaderLock();
                    m_dm.delay(5000);
                }
                
            }
            this.button1.Enabled = true;
        }
        private void start(object msg)
        {
            //user u = (user)msg;
            //showmsg("状态", "RUN", u);
            //int count = 0;
            //while (u.state)
            //{
            //    showmsg("金币", count.ToString(), u);
            //    showmsg("任务", count.ToString(), u);
            //    showmsg("提示", count.ToString(), u);
            //    Thread.Sleep(ran.Next(500,1500));
            //    count++;
            //}
            //showmsg("状态", "STOP", u);
            //list.Remove(u);
        }
        private void showmsg(string columnname, string message, UserItem u)
        {
            //if (columnname == "提示信息")
            //{
            //    message = DateTime.Now.ToString("HH:mm:ss") + " " + message;
            //}
            //dataGridView1.Rows[u.rows].Cells[columnname].Value = message;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < m_multi_thread.m_scripts.Count; i++)
            {
                m_multi_thread.m_scripts[i].Stop();
            }
        }
        /// <summary>
        /// 暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (m_multi_thread.m_scripts.Count<=0)
            {
                MessageBoxMidle.Show(this, "当前没有正在运行的角色！", "提示");
                return;
            }
            if (dataGridView1.Rows.Count<=0)
            {
                MessageBoxMidle.Show(this, "请选择要暂停的角色！", "提示");
                return;
            }
            DialogResult dr = MessageBoxMidle.Show(this, "确定要暂停选择的角色吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell dgvCheck = (DataGridViewCheckBoxCell)(this.dataGridView1.Rows[i].Cells["isSelect"]);
                    if (Convert.ToBoolean(dgvCheck.EditedFormattedValue) == true)
                    {
                        var script = m_multi_thread.m_scripts.Find(s => s.user.Index == i);
                        if (script != null)
                        {
                            script.Pause();
                        }
                    }
                }
            }
            MessageBoxMidle.Show(this, "已暂停", "提示");
        }
        /// <summary>
        /// 恢复
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (m_multi_thread.m_scripts.Count <= 0)
            {
                MessageBoxMidle.Show(this, "当前没有暂停的角色！", "提示");
                return;
            }
            if (dataGridView1.Rows.Count <= 0)
            {
                MessageBoxMidle.Show(this, "请选择要恢复的角色！", "提示");
                return;
            }
            DialogResult dr = MessageBoxMidle.Show(this, "确定要恢复选中的角色吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell dgvCheck = (DataGridViewCheckBoxCell)(this.dataGridView1.Rows[i].Cells["isSelect"]);
                    if (Convert.ToBoolean(dgvCheck.EditedFormattedValue) == true)
                    {
                        var script = m_multi_thread.m_scripts.Find(s => s.user.Index == i);
                        if (script != null)
                        {
                            script.Resume();
                        }
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //key.Stop();
            //卸载驱动程序
            //DriverBLL dbll = new DriverBLL();
            //dbll.DriverUnInstall("MyDriver001");
            //System.Environment.Exit(System.Environment.ExitCode);
            DialogResult dr = MessageBoxMidle.Show(this, "确定要退出程序吗", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                //this.Dispose();
                e.Cancel = false;
                System.Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
            //Application.ExitThread();
            //强制结束进程并退出
            //System.Diagnostics.Process.GetCurrentProcess().Kill();
            System.Environment.Exit(0);
        }
        private void btn_opengame_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 加载可选任务
        /// </summary>
        public void LoadTasks()
        {
            //listBox_Tasking.Items.Clear();
            //string taskpath = RootPath + "\\tasks.txt";
            //using (FileStream fs = new FileStream(taskpath, FileMode.Open, FileAccess.Read))
            //{
            //    using (StreamReader sr = new StreamReader(fs))
            //    {
            //        string taskcontent = sr.ReadToEnd();
            //        if (string.IsNullOrEmpty(taskcontent))
            //        {
            //            return;
            //        }
            //        var taskarray = taskcontent.Split(new char[] { '|' });
            //        if (taskarray.Length > 0)
            //        {
            //            for (int i = 0; i < taskarray.Length; i++)
            //            {
            //                if (!string.IsNullOrEmpty(taskarray[i]))
            //                {
            //                    listbox_task.Items.Add(taskarray[i]);
            //                }
            //            }
            //        }
            //    }
            //}

        }
        /// <summary>
        /// 加载已选任务
        /// </summary>
        public void LoadTasking()
        {
            //string taskpath = RootPath + "\\tasking.txt";
            //using (FileStream fs = new FileStream(taskpath, FileMode.Open, FileAccess.Read))
            //{
            //    using (StreamReader sr = new StreamReader(fs))
            //    {
            //        string taskcontent = sr.ReadToEnd();
            //        if (string.IsNullOrEmpty(taskcontent))
            //        {
            //            return;
            //        }
            //        var taskarray = taskcontent.Split(new char[] { '|' });
            //        if (taskarray.Length > 0)
            //        {
            //            for (int i = 0; i < taskarray.Length; i++)
            //            {
            //                listBox_Tasking.Items.Add(taskarray[i]);
            //            }
            //        }
            //    }
            //}
            //listBox_Tasking.SelectedIndex = 0;
        }

        private void listbox_task_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int index = this.listbox_task.SelectedIndex;
            //if (index != -1)
            //{
            //    string taskvalue = listbox_task.Items[index].ToString();
            //    if (listBox_Tasking.Items.Contains(taskvalue))
            //    {
            //        return;
            //    }
            //    if (string.IsNullOrEmpty(taskvalue))
            //    {
            //        listbox_task.Items.Remove(taskvalue);
            //        return;
            //    }
            //    if (taskvalue == "起号")
            //    {
            //        string creatrolestr = Helper.GetPerfileNodeValue("Configure/CreatRoleTasks");
            //        if (!string.IsNullOrEmpty(creatrolestr))
            //        {
            //            listBox_Tasking.Items.Clear();
            //            var array = creatrolestr.Trim().Split('|');
            //            foreach (var item in array)
            //            {
            //                listBox_Tasking.Items.Add(item);
            //            }
            //        }
            //        return;
            //    }
            //    //listbox_task.Items.Remove(taskvalue);
            //    listBox_Tasking.Items.Add(taskvalue);
            //    //保存到配置文件
            //}
        }

        private void listBox_Tasking_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int index = this.listBox_Tasking.SelectedIndex;
            //if (index != -1)
            //{
            //    string taskvalue = listBox_Tasking.Items[index].ToString();
            //    if (string.IsNullOrEmpty(taskvalue))
            //    {
            //        listBox_Tasking.Items.Remove(taskvalue);
            //        return;
            //    }
            //    listBox_Tasking.Items.Remove(taskvalue);
            //    //保存到配置文件
            //    //string taskStr = string.Empty;
            //    //string taskingStr = string.Empty;
            //    //foreach (var item in listbox_task.Items)
            //    //{
            //    //    taskStr += item.ToString() + "|";
            //    //}
            //    //if (taskStr.Length > 0)
            //    //{
            //    //    taskStr = taskStr.Substring(0, taskStr.Length - 1);
            //    //}
            //    //Helper.WriteToPerfile(taskStr, RootPath + "\\tasks.txt");
            //    //foreach (var item in listBox_Tasking.Items)
            //    //{
            //    //    taskingStr += item.ToString() + "|";
            //    //}
            //    //if (taskingStr.Length > 0)
            //    //{
            //    //    taskingStr = taskingStr.Substring(0, taskingStr.Length - 1);
            //    //}

            //    //Helper.WriteToPerfile(taskingStr, RootPath + "\\tasking.txt");
            //}
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_gamepath_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 一键任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            //listBox_Tasking.Items.AddRange(listbox_task.Items);
            //listbox_task.Items.Clear();
            //清空任务配置文件
            String appDir = RootPath + @"tasks.txt";
            FileStream stream = File.Open(appDir, FileMode.OpenOrCreate, FileAccess.Write);
            stream.Seek(0, SeekOrigin.Begin);
            stream.SetLength(0);
            stream.Close();
            //写入任务中配置文件
            //string taskingStr = string.Empty;
            //foreach (var item in listBox_Tasking.Items)
            //{
            //    taskingStr += item.ToString() + "|";
            //}
            //if (taskingStr.Length > 0)
            //{
            //    taskingStr = taskingStr.Substring(0, taskingStr.Length - 1);
            //}
            //using (StreamWriter sw = new StreamWriter(RootPath + "\\tasking.txt", true))
            //{
            //    sw.WriteLine(taskingStr);
            //}
            //Helper.WriteToPerfile(taskingStr, RootPath + "\\tasking.txt");
        }
        /// <summary>
        /// 一键清空任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clearAllTask_Click(object sender, EventArgs e)
        {
            ///listBox_Tasking.Items.Clear();

        }

        /// <summary>
        /// 保存游戏设置按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_saveperfile_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(com_serverlist.SelectedValue.ToString()))
            //{
            //    MessageBox.Show("请填写服务器名称！");
            //    return;
            //}
            //Helper.SaveAppSettings(gameversion, "gameVersion");
            //Helper.SaveAppSettings(txt_serverName.Text, "serverName");
            MessageBox.Show("保存成功！");
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
            e.RowBounds.Location.Y,
            dataGridView1.RowHeadersWidth - 4,
            e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics,
                  (e.RowIndex + 1).ToString(),
                   dataGridView1.RowHeadersDefaultCellStyle.Font,
                   rectangle,
                   dataGridView1.RowHeadersDefaultCellStyle.ForeColor,
                   TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
        /// <summary>
        /// 保存配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument xmldoc2 = new XmlDocument();
                string xmlpath = System.AppDomain.CurrentDomain.BaseDirectory + "configfile.xml";
                xmldoc2.Load(xmlpath);
                foreach (XmlNode node in xmldoc2.LastChild.ChildNodes)
                {
                    if (node.NodeType == XmlNodeType.Comment)
                    {
                        continue;
                    }
                    XmlElement xmlElement = (XmlElement)node;
                    
                    var nodeName = xmlElement.Name.ToLower();
                    if (nodeName == "login")
                    {
                        var loginNodes = node.ChildNodes;
                        foreach (var item in loginNodes)
                        {
                            XmlElement loginElement = (XmlElement)item;
                            var loginnodeName = loginElement.Name.ToLower();
                            //if (loginnodeName == "damachuan")
                            //{
                            //    loginElement.InnerText = txt_damapassword.Text.Trim();
                            //}
                            if (loginnodeName == "customerpath")
                            {
                                loginElement.InnerText = txt_gamepath.Text.Trim();
                            }
                            if (loginnodeName == "selectserverarea")
                            {
                                //loginElement.InnerText = com_serverarealist.SelectedItem.ToString();
                            }
                            if (loginnodeName == "selectserver")
                            {
                                //loginElement.InnerText = com_serverlist.SelectedItem.ToString();
                            }
                        }

                    }
                    //验证姓名
                    if (nodeName == "yanzhengxingming")
                    {
                        xmlElement.InnerText = txt_yanzhengxingming.Text.Trim();
                    }
                    //验证姓名
                    if (nodeName == "shenfenzhenghao")
                    {
                        xmlElement.InnerText = txt_shenfenzhenghao.Text.Trim();
                    }
                    if (nodeName == "autologin")
                    {
                        xmlElement.InnerText = check_autologin.Checked.ToString();
                    }
                    if (nodeName == "mainline")
                    {
                        xmlElement.InnerText = check_autologin.Checked.ToString();
                    }
                    if (nodeName == "mainlinelimittime")
                    {
                        xmlElement.InnerText = txt_mainlinelimittime.Text.ToString();
                    }
                    if (nodeName == "zongshidiantang")
                    {
                        xmlElement.InnerText = check_zongshidiantang.Checked.ToString();
                    }
                    if (nodeName == "menpairenwu")
                    {
                        xmlElement.InnerText = check_menpairenwu.Checked.ToString();
                    }
                    if (nodeName == "wenjianxiayi")
                    {
                        xmlElement.InnerText = check_wenjianxiayi.Checked.ToString();
                    }
                    if (nodeName == "nagongqixiang")
                    {
                        xmlElement.InnerText = check_nagongqixiang.Checked.ToString();
                    }
                    if (nodeName == "banghuirenwu")
                    {
                        xmlElement.InnerText = check_banghuirenwu.Checked.ToString();
                    }
                    if (nodeName == "banghuiyanwu")
                    {
                        xmlElement.InnerText = check_banghuiyanwu.Checked.ToString();
                    }
                    if (nodeName == "shenghuocaiji")
                    {
                        xmlElement.InnerText = check_shenghuocaiji.Checked.ToString();
                    }
                    if (nodeName == "shenghuocaijixuanxiang")
                    {
                        xmlElement.InnerText = cob_shenghuocaijixuanxiang.SelectedItem.ToString();
                    }
                    if (nodeName == "shenghuocaijixuanxiangjishu")
                    {
                        xmlElement.InnerText = cob_shenghuocaijixuanxiangjishu.SelectedItem.ToString();
                    }
                    if (nodeName == "shenghuozhizao")
                    {
                        xmlElement.InnerText = check_shenghuozhizao.Checked.ToString();
                    }
                    if (nodeName == "shenghuozhizaoxuanxiang")
                    {
                        xmlElement.InnerText = cob_shenghuocaijixuanxiang.SelectedItem.ToString();
                    }
                    if (nodeName == "shenghuozhizaoxuanxiangjishu")
                    {
                        xmlElement.InnerText = cob_shenghuozhizaoxuanxiangjishu.SelectedItem.ToString();
                    }
                    if (nodeName == "chongwujiadian")
                    {
                        xmlElement.InnerText = check_chongwujiadian.Checked.ToString();
                    }
                    if (nodeName == "jianghufanguan")
                    {
                        xmlElement.InnerText = check_jianghufanguan.Checked.ToString();
                    }
                    if (nodeName == "yanziwu")
                    {
                        xmlElement.InnerText = check_yanziwu.Checked.ToString();
                    }
                    if (nodeName == "yongchuangshanzhai")
                    {
                        xmlElement.InnerText = check_yongchuangshanzhai.Checked.ToString();
                    }
                    if (nodeName == "zhenlongqiju")
                    {
                        xmlElement.InnerText = check_zhenlongqiju.Checked.ToString();
                    }
                    if (nodeName == "xixiawangling")
                    {
                        xmlElement.InnerText = check_xixiawangling.Checked.ToString();
                    }
                    if (nodeName == "xixiawanglingcengshu")
                    {
                        xmlElement.InnerText = cob_xixiawanglingcengshu.Text.ToString();
                    }
                    if (nodeName == "xixiawanglingxianzhishijian")
                    {
                        xmlElement.InnerText = txt_xixiawanglingxianzhishijian.Text.ToString();
                    }
                    if (nodeName == "jianghujixiong")
                    {
                        xmlElement.InnerText = check_jianghujixiong.Checked.ToString();
                    }
                    if (nodeName == "hanyuliangong")
                    {
                        xmlElement.InnerText = check_hanyuliangong.Checked.ToString();
                    }
                    if (nodeName == "shendulunjian")
                    {
                        xmlElement.InnerText = checkshendulunjian.Checked.ToString();
                    }
                    if (nodeName == "banghuiyunbiao")
                    {
                        xmlElement.InnerText = check_banghuiyunbiao.Checked.ToString();
                    }
                    if (nodeName == "bianguanwenzhan")
                    {
                        xmlElement.InnerText = check_bianguanwenzhan.Checked.ToString();
                    }
                    if (nodeName == "sidaeren")
                    {
                        xmlElement.InnerText = check_sidaeren.Checked.ToString();
                    }
                    if (nodeName == "xiaoxiao")
                    {
                        xmlElement.InnerText = check_xiaoxiao.Checked.ToString();
                    }
                    if (nodeName == "gaobeiqiju")
                    {
                        xmlElement.InnerText = check_gaobeiqiju.Checked.ToString();
                    }
                    if (nodeName == "baoshishengyan")
                    {
                        xmlElement.InnerText = check_baoshishengyan.Checked.ToString();
                    }
                    if (nodeName == "chengjiujiangli")
                    {
                        xmlElement.InnerText = check_chengjiujiangli.Checked.ToString();
                    }
                    if (nodeName == "juexuecanwu")
                    {
                        xmlElement.InnerText = check_juexuechanwu.Checked.ToString();
                    }
                    if (nodeName == "shoushanyoujian")
                    {
                        xmlElement.InnerText = check_shoushanyoujian.Checked.ToString();
                    }
                    if (nodeName == "huoyuejiangli")
                    {
                        xmlElement.InnerText = check_huoyuejiangli.Checked.ToString();
                    }
                    if (nodeName == "jishijiangli")
                    {
                        xmlElement.InnerText = check_jishijiangli.Checked.ToString();
                    }
                    if (nodeName == "hongfubaoxiang")
                    {
                        xmlElement.InnerText = check_hongfubaoxiang.Checked.ToString();
                    }
                    if (nodeName == "yuyuejiangli")
                    {
                        xmlElement.InnerText = check_yuyuejiangli.Checked.ToString();
                    }
                    if (nodeName == "huodongzhaohui")
                    {
                        xmlElement.InnerText = check_huodongzhaohui.Checked.ToString();
                    }
                    if (nodeName == "fulijiangli")
                    {
                        xmlElement.InnerText = check_fulijiangli.Checked.ToString();
                    }
                    if (nodeName == "fenjiezhuangbei")
                    {
                        xmlElement.InnerText = check_fenjiezhuangbei.Checked.ToString();
                    }
                    if (nodeName == "qianghuazhuangbei")
                    {
                        xmlElement.InnerText = check_qianghuazhuangbei.Checked.ToString();
                    }
                    if (nodeName == "chuandaizhuangbei")
                    {
                        xmlElement.InnerText = check_chuandaizhuangbei.Checked.ToString();
                    }
                    if (nodeName == "kemingzhuangbei")
                    {
                        xmlElement.InnerText = check_kemingzhuangbei.Checked.ToString();
                    }
                    if (nodeName == "kemingzhuangbeijishu")
                    {
                        xmlElement.InnerText = cob_kemingjishu.Text.ToString();
                    }
                    if (nodeName == "jingtongzhuangbei")
                    {
                        xmlElement.InnerText = check_jingtongzhuangbei.Checked.ToString();
                    }
                    if (nodeName == "xiangqianzhuangbei")
                    {
                        xmlElement.InnerText = check_xiangqianzhuangbei.Checked.ToString();
                    }
                    if (nodeName == "wuxueduanti")
                    {
                        xmlElement.InnerText = check_wuxueduanti.Checked.ToString();
                    }
                    if (nodeName == "shuxingjiadian")
                    {
                        xmlElement.InnerText = check_shuxingjiadian.Checked.ToString();
                    }
                    if (nodeName == "tupoxinjing")
                    {
                        xmlElement.InnerText = check_tupoxinjing.Checked.ToString();
                    }
                    if (nodeName == "shengjijineng")
                    {
                        xmlElement.InnerText = check_shengjijineng.Checked.ToString();
                    }
                    if (nodeName == "qinglibeibao")
                    {
                        xmlElement.InnerText = check_qinglibeibao.Checked.ToString();
                    }
                    if (nodeName == "chongwuchuzhan")
                    {
                        xmlElement.InnerText = check_chongwuchuzhan.Checked.ToString();
                    }
                    if (nodeName == "tianjiayaopin")
                    {
                        xmlElement.InnerText = check_tianjiayaopin.Checked.ToString();
                    }
                    if (nodeName == "beibaojiesuo")
                    {
                        xmlElement.InnerText = check_beibaojiesuo.Checked.ToString();
                    }
                    if (nodeName == "autoswitch")
                    {
                        xmlElement.InnerText = chk_qiehuanjuese.Checked.ToString();
                    }
                    if (nodeName == "teamup")
                    {
                        xmlElement.InnerText = check_regroupteam.Checked.ToString();
                    }
                }
                xmldoc2.Save(xmlpath);
                Logger.Addlog("保存配置成功！");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        /// <summary>
        /// 选择游戏路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button11_Click(object sender, EventArgs e)
        {
            //定义一个文件打开控件
            OpenFileDialog ofd = new OpenFileDialog();
            //设置打开对话框的初始目录，默认目录为exe运行文件所在的路径
            ofd.InitialDirectory = Application.StartupPath;
            //设置打开对话框的标题
            ofd.Title = "请选择要打开的文件";
            //设置打开对话框可以多选
            ofd.Multiselect = true;
            //设置对话框打开的文件类型
            ofd.Filter = "文本文件|*.exe";
            //设置文件对话框当前选定的筛选器的索引
            ofd.FilterIndex = 2;
            //设置对话框是否记忆之前打开的目录
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //获取用户选择的文件完整路径
                string filePath = ofd.FileName;
                txt_gamepath.Text = filePath;
                //写入配置文件
                string file = System.Windows.Forms.Application.ExecutablePath;
                Configuration config = ConfigurationManager.OpenExeConfiguration(file);

                bool exist = false;//记录这个com端口值是否存在
                if (config.AppSettings.Settings["gamepath"] != null)
                {
                    exist = true;
                }
                if (exist)
                {
                    config.AppSettings.Settings.Remove("gamepath");
                }
                config.AppSettings.Settings.Add("gamepath", filePath);
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
        }
        /// <summary>
        /// 停止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBoxMidle.Show(this, "确定要停止吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                foreach (var item in m_multi_thread.m_scripts)
                {
                    item.m_main_thread.Stop();
                }
                m_multi_thread.m_scripts.Clear();
            }
            MessageBoxMidle.Show(this, "停止成功", "提示");
        }
        /// <summary>
        /// 关闭全部游戏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBoxMidle.Show(this, "确定要关闭全部窗口吗", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                foreach (var item in m_multi_thread.m_scripts)
                {
                    item.m_main_thread.Stop();
                    m_dm.delay(2000);
                }
                string title = "-";
                var hwnds = m_dm.EnumWindow(0, title, "LDPlayerMainFrame", 1 + 2 + 4 + 16);
                if (!string.IsNullOrEmpty(hwnds))
                {
                    var hwndsArray = hwnds.Split(',');
                    if (hwndsArray.Length > 0)
                    {
                        foreach (var item1 in hwndsArray)
                        {
                            SendMessage(int.Parse(item1), 0x0010, 0, 0);
                        }
                    }
                }
            }
            MessageBoxMidle.Show(this, "全部关闭成功", "提示");
        }
        /// <summary>
        /// 初始化user任务信息
        /// </summary>
        /// <param name="user"></param>
        private void InitUserInfo(UserItem user) 
        {
            user.AutoLogin = this.check_autologin.Checked;
            user.TeamUp=check_regroupteam.Checked;
            user.AutoSwitch=this.chk_qiehuanjuese.Checked;
            user.MainLine = this.check_mainLine.Checked;
            user.AddFriend=this.check_addfriends.Checked;
            user.MainLineLimitTime = int.Parse(txt_mainlinelimittime.Text);
            user.ZongShiDianTang = this.check_zongshidiantang.Checked;
            user.MenPaiRenWu = this.check_menpairenwu.Checked;
            user.WenJianXiaYi = this.check_wenjianxiayi.Checked;
            user.NaGongQiXiang = this.check_nagongqixiang.Checked;
            user.BangHuiRenWu = this.check_banghuirenwu.Checked;
            user.BangHuiYanWu = this.check_banghuiyanwu.Checked;
            user.BangHuiYanWu = this.check_banghuiyanwu.Checked;
            user.ShengHuoCaiJi = this.check_shenghuocaiji.Checked;
            user.ShengHuoCaiJiXuanXiang= cob_shenghuocaijixuanxiang.SelectedItem.ToString();
            user.ShengHuoCaiJiXuanXiangJiShu= cob_shenghuocaijixuanxiangjishu.SelectedItem.ToString();
            user.ShengHuoZhiZao = this.check_shenghuozhizao.Checked;
            user.ShengHuoZhiZaoXuanXiang = cob_shenghuozhizaoxuanxiang.SelectedItem.ToString();
            user.ShengHuoZhiZaoXuanXiangJiShu = cob_shenghuocaijixuanxiangjishu.SelectedItem.ToString();
            user.JiangHuFanGuan = this.check_jianghufanguan.Checked;
            user.YanZiWu = this.check_yanziwu.Checked;
            user.YongChuangShanZhai = this.check_yongchuangshanzhai.Checked;
            user.ZhenLongQiJu = this.check_zhenlongqiju.Checked;
            user.XiXiaWangLing = this.check_xixiawangling.Checked;
            user.XiXiaWangLingCengShu=cob_xixiawanglingcengshu.SelectedItem.ToString();
            user.XiXiaWangLingXianZhiShiJian=txt_xixiawanglingxianzhishijian.Text.Trim();
            user.JiangHuJiXiong = this.check_jianghujixiong.Checked;
            user.HanYuLianGong = this.check_hanyuliangong.Checked;
            user.ShenDuLunJian = this.checkshendulunjian.Checked;
            user.BangHuiYunBiao = this.check_banghuiyunbiao.Checked;
            user.BianGuanWenZhan = this.check_bianguanwenzhan.Checked;
            user.SiDaeRen = this.check_sidaeren.Checked;
            user.XiaoXiao = this.check_xiaoxiao.Checked;
            user.GaoBeiQiJu = this.check_gaobeiqiju.Checked;
            user.BaoShiShengYan = this.check_baoshishengyan.Checked;
            //领取功能
            user.ChengJiuJiangLi = this.check_chengjiujiangli.Checked;
            user.JueXueCanWu = this.check_juexuechanwu.Checked;
            user.ShouShanYouJian = this.check_shoushanyoujian.Checked;
            user.HuoYueJiangLi = this.check_huoyuejiangli.Checked;
            user.JiShiJiangLi = this.check_jishijiangli.Checked;
            user.HongFuBaoXiang = this.check_hongfubaoxiang.Checked;
            user.YuYueJiangLi = this.check_yuyuejiangli.Checked;
            user.HuoDongZhaoHui = this.check_huodongzhaohui.Checked;
            user.FuLiJiangLi = this.check_fulijiangli.Checked;
            //提升功能
            user.FenJieZhuangBei = this.check_fenjiezhuangbei.Checked;
            user.ChuanDaiZhuangBei = this.check_chuandaizhuangbei.Checked;
            user.QiangHuaZhuangBei = this.check_qianghuazhuangbei.Checked;
            user.KeMingZhuangBei = this.check_kemingzhuangbei.Checked;
            user.KeMingZhuangBeiJiShu=cob_kemingjishu.SelectedItem.ToString();
            user.JingTongZhuangBei = this.check_jingtongzhuangbei.Checked;
            user.XiangQianZhuangBei = this.check_xiangqianzhuangbei.Checked;
            user.WuXueDuanTi = this.check_wuxueduanti.Checked;
            user.ShuXingJiaDian = this.check_shuxingjiadian.Checked;
            user.TuPoXinJing = this.check_tupoxinjing.Checked;
            user.ShengJiJiNeng = this.check_shengjijineng.Checked;
            user.QingLiBeiBao = this.check_qinglibeibao.Checked;
            user.ChongWuJiaDian = this.check_chongwujiadian.Checked;
            user.ChongWuChuZhan = this.check_chongwuchuzhan.Checked;
            user.TianJiaYaoPin = this.check_tianjiayaopin.Checked;
            user.BeiBaoJieSuo = this.check_beibaojiesuo.Checked;
        }
        /// <summary>
        /// 单人任务全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void check_selectalltask_CheckedChanged(object sender, EventArgs e)
        {
            bool flag = this.check_selectalltask.Checked;
            foreach (Control control in groupBox_singletask.Controls)
            {
                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = flag;
                }

            }
        }
        /// <summary>
        /// 组队任务全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void check_teamtaskallselect_CheckedChanged(object sender, EventArgs e)
        {
            bool flag = this.check_teamtaskallselect.Checked;
            foreach (Control control in groupbox_teamworktask.Controls)
            {
                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = flag;
                }
            }
        }
        /// <summary>
        /// 限时任务全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void check_timelimittaskallselect_CheckedChanged(object sender, EventArgs e)
        {
            bool flag = this.check_timelimittaskallselect.Checked;
            foreach (Control control in group_timelimittask.Controls)
            {
                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = flag;
                }
            }
        }
        /// <summary>
        /// 领取功能全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void check_lingqushezhiallselect_CheckedChanged(object sender, EventArgs e)
        {
            bool flag = this.check_lingqushezhiallselect.Checked;
            foreach (Control control in groupBox_lingqushezhi.Controls)
            {
                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = flag;
                }
            }
        }
        /// <summary>
        /// 提升全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void check_tishengallselect_CheckedChanged(object sender, EventArgs e)
        {
            bool flag = this.check_tishengallselect.Checked;
            foreach (Control control in groupBox_tisheng.Controls)
            {
                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = flag;
                }
            }
        }
        /// <summary>
        /// 设置全选框是否打勾
        /// </summary>
        private void 单人任务全选框勾选()
        {
            //单人任务全选
            foreach (Control control in groupBox_singletask.Controls)
            {
                if (control.Text=="全选")
                {
                    continue;
                }
                if (control is CheckBox)
                {
                    if (!((CheckBox)control).Checked)
                    {
                        return;
                    }
                }

            }
        }
        public void 组队任务全选框勾选() 
        {
            this.check_selectalltask.Checked = true;
            //组队任务全选
            foreach (Control control in groupbox_teamworktask.Controls)
            {
                if (control.Text == "全选")
                {
                    continue;
                }
                if (control is CheckBox)
                {
                    if (!((CheckBox)control).Checked)
                    {
                        return;
                    }
                }
            }
            this.check_teamtaskallselect.Checked = true;
        }
        public void 限时任务全选框勾选() 
        {
            //限时任务
            foreach (Control control in group_timelimittask.Controls)
            {
                if (control.Text == "全选")
                {
                    continue;
                }
                if (control is CheckBox)
                {
                    if (!((CheckBox)control).Checked)
                    {
                        return;
                    }
                }
            }
            this.check_timelimittaskallselect.Checked = true;
        }
        public void 领取全选全选框勾选()
        {
            //领取全选
            foreach (Control control in groupBox_lingqushezhi.Controls)
            {
                if (control.Text == "全选")
                {
                    continue;
                }
                if (control is CheckBox)
                {
                    if (!((CheckBox)control).Checked)
                    {
                        return;
                    }
                }
            }
            this.check_lingqushezhiallselect.Checked = true;
        }

        public void 提升全选全选框勾选()
        {
            foreach (Control control in groupBox_tisheng.Controls)
            {
                if (control.Text == "全选")
                {
                    continue;
                }
                if (control is CheckBox)
                {
                    if (!((CheckBox)control).Checked)
                    {
                        return;
                    }
                }
            }
            this.check_tishengallselect.Checked = true;
        }

        private void check_jianghufanguan_CheckedChanged(object sender, EventArgs e)
        {
            if (check_jianghufanguan.Checked)
            {
                check_regroupteam.Checked = true;
            }
            else
            {
                if (!check_yanziwu.Checked&&!check_zhenlongqiju.Checked&&!check_yongchuangshanzhai.Checked&&!check_xiaoxiao.Checked&&!check_xixiawangling.Checked)
                {
                    check_regroupteam.Checked = false;
                }
            }
        }

        private void check_yanziwu_CheckedChanged(object sender, EventArgs e)
        {
            if (check_yanziwu.Checked)
            {
                check_regroupteam.Checked = true;
            }
            else
            {
                if (!check_jianghufanguan.Checked && !check_zhenlongqiju.Checked && !check_yongchuangshanzhai.Checked && !check_xiaoxiao.Checked&&!check_xixiawangling.Checked)
                {
                    check_regroupteam.Checked = false;
                }
            }
        }

        private void check_yongchuangshanzhai_CheckedChanged(object sender, EventArgs e)
        {
            if (check_yongchuangshanzhai.Checked)
            {
                check_regroupteam.Checked = true;
            }
            else
            {
                if (!check_yanziwu.Checked && !check_jianghufanguan.Checked && !check_zhenlongqiju.Checked  && !check_xiaoxiao.Checked && !check_xixiawangling.Checked)
                {
                    check_regroupteam.Checked = false;
                }
            }
        }

        private void check_xixiawangling_CheckedChanged(object sender, EventArgs e)
        {
            if (check_xixiawangling.Checked)
            {
                check_regroupteam.Checked = true;
            }
            else
            {
                if (!check_yanziwu.Checked && !check_jianghufanguan.Checked && !check_zhenlongqiju.Checked && !check_xiaoxiao.Checked && !check_yongchuangshanzhai.Checked)
                {
                    check_regroupteam.Checked = false;
                }
            }
        }

        private void check_zhenlongqiju_CheckedChanged(object sender, EventArgs e)
        {
            if (check_zhenlongqiju.Checked)
            {
                check_regroupteam.Checked = true;
            }
            else
            {
                if (!check_yanziwu.Checked && !check_jianghufanguan.Checked && !check_xiaoxiao.Checked && !check_xixiawangling.Checked && !check_yongchuangshanzhai.Checked)
                {
                    check_regroupteam.Checked = false;
                }
            }
        }

        private void check_xiaoxiao_CheckedChanged(object sender, EventArgs e)
        {
            if (check_xiaoxiao.Checked)
            {
                check_regroupteam.Checked = true;
            }
            else
            {
                if (!check_yanziwu.Checked && !check_jianghufanguan.Checked && !check_zhenlongqiju.Checked && !check_xixiawangling.Checked && !check_yongchuangshanzhai.Checked)
                {
                    check_regroupteam.Checked = false;
                }
            }
        }
        /// <summary>
        /// 关闭选择的角色游戏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count <= 0)
            {
                MessageBoxMidle.Show(this, "请选择要关闭的角色！", "提示");
                return;
            }
            DialogResult dr = MessageBoxMidle.Show(this, "确定要关闭选中的角色吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewCheckBoxCell dgvCheck = (DataGridViewCheckBoxCell)(this.dataGridView1.Rows[i].Cells["isSelect"]);
                    if (Convert.ToBoolean(dgvCheck.EditedFormattedValue) == true)
                    {
                        string title = this.dataGridView1.Rows[i].Cells["emulator"].Value.ToString();
                        var hwnds = m_dm.EnumWindow(0, title, "LDPlayerMainFrame", 1 + 2 + 4 + 16);

                        if (!string.IsNullOrEmpty(hwnds))
                        {
                            var hwndsArray = hwnds.Split(',');
                            if (hwndsArray.Length > 0)
                            {
                                foreach (var item1 in hwndsArray)
                                {
                                    var script= m_multi_thread.m_scripts.Find(s => s.user.hwnd == int.Parse(item1));
                                    if (script!=null)
                                    {
                                        script.Stop();
                                        m_dm.delay(3000);
                                        m_multi_thread.m_scripts.Remove(script);
                                    }
                                    SendMessage(int.Parse(item1), 0x0010, 0, 0);
                                }
                            }
                        }
                    }
                }
            }
            MessageBoxMidle.Show(this, "关闭成功！", "提示");
            
        }

       
    }
}
