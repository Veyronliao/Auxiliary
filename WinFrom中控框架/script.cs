using System;
using System.Configuration;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Web.UI;
using System.Windows.Forms;
using System.Windows.Input;
using senke.DmSoft;


//using senke.Script;

namespace senke
{
    public class Script
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
        public MainThread m_main_thread = null;
        public SubThread m_sub_thread = null;

        // 标记主绑定是否成功,副绑定必须等待主绑定成功才能继续
        private bool m_main_bind_ok = false;

        // 这里可以定义脚本所需要的变量
        public UserItem user = null;
        //设置账号信息
        //public void SetUser(UserItem useritemm)
        //{
        //    this.user = useritemm;
        //}

        public Script(UserItem item)
        {
            this.user = item;
            m_main_thread = new MainThread(this);
            m_sub_thread = new SubThread(this);
        }


        // 启动
        public void Start()
        {
            m_main_thread.Start();
            m_sub_thread.Start();
        }

        // 停止
        public void Stop()
        {
            m_main_thread.Stop();
            m_sub_thread.Stop();

            m_main_bind_ok = false;
        }

        // 暂停
        public void Pause()
        {
            m_main_thread.Pause();
            m_sub_thread.Pause();
        }

        // 恢复
        public void Resume()
        {
            m_main_thread.Resume();
            m_sub_thread.Resume();
        }

        // 我们做暂停和恢复操作,就主要靠这个延时函数,要求脚本所有用到延时的地方，全部用这个，这样我们可以有很多机会去暂停线程
        // 这个是给主线程调用
        public void MainDelay(dmsoft dm, int time)
        {
            if (m_main_thread.m_pause)
            {
                m_main_thread.m_state = ThreadState.State_Pause;
                AsyncNotify.Notify(m_main_thread.m_hwnd, AsyncNotify.Update);

                // 如果你想要在暂停时让用户可以操作,那么可以调用EnableBind,但是不要去调用LockInput,LockInput不是用来解除后台的,具体参考LockInput的说明
                dm.EnableBind(5);


                // 我们暂停的方法是死循环,然后延时,而不是调用系统的接口
                // 这样开销最小,并且效率也还不错
                while (true)
                {
                    if (m_main_thread.m_pause == false)
                    {
                        m_main_thread.m_state = ThreadState.State_Runing;
                        AsyncNotify.Notify(m_main_thread.m_hwnd, AsyncNotify.Update);

                        // 开启后台
                        dm.EnableBind(1);
                        break;
                    }

                    Thread.Sleep(1);
                }
            }

            // 可能暂停,恢复时会让状态错乱,这里再判断一次
            if (m_main_thread.m_state != ThreadState.State_Runing)
            {
                m_main_thread.m_state = ThreadState.State_Runing;
                AsyncNotify.Notify(m_main_thread.m_hwnd, AsyncNotify.Update);

                // 开启后台
                dm.EnableBind(1);
            }

            Thread.Sleep(time);
        }

        // 这个是给副线程调用
        private void SubDelay(dmsoft dm, int time)
        {
            if (m_sub_thread.m_pause)
            {
                m_sub_thread.m_state = ThreadState.State_Pause;
                AsyncNotify.Notify(m_sub_thread.m_hwnd, AsyncNotify.Update);

                // 如果你想要在暂停时让用户可以操作,那么可以调用EnableBind,但是不要去调用LockInput,LockInput不是用来解除后台的,具体参考LockInput的说明
                dm.EnableBind(5);


                // 我们暂停的方法是死循环,然后延时,而不是调用系统的接口
                // 这样开销最小,并且效率也还不错
                while (true)
                {
                    if (m_sub_thread.m_pause == false)
                    {
                        m_sub_thread.m_state = ThreadState.State_Runing;
                        AsyncNotify.Notify(m_sub_thread.m_hwnd, AsyncNotify.Update);

                        // 开启后台
                        dm.EnableBind(1);
                        break;
                    }

                    Thread.Sleep(1);
                }
            }

            // 可能暂停,恢复时会让状态错乱,这里再判断一次
            if (m_sub_thread.m_state != ThreadState.State_Runing)
            {
                m_sub_thread.m_state = ThreadState.State_Runing;
                AsyncNotify.Notify(m_sub_thread.m_hwnd, AsyncNotify.Update);

                // 开启后台
                dm.EnableBind(1);
            }

            Thread.Sleep(time);
        }

        private void SetTaskState(string state)
        {
            // 这里为何采用这样的字符串赋值方法，是考虑到自变量会在UI线程里访问，为了避免内存冲突，必须这样赋值.
            // 如果你有用到别的字符串，如果也要在别的线程里同时使用时，那么也得这样来使用.
            state.CopyTo(0, m_main_thread.m_task_state, 0, state.Length);
            m_main_thread.m_task_state[state.Length] = '\0';

            AsyncNotify.Notify(m_main_thread.m_hwnd, AsyncNotify.Update);
        }
        
        //创建角色
        private void CreateRole(dmsoft dm)
        {
            bool loginFlag = false;//登录标志
            bool loginVerificationFlag = false;//答题标志
            //dm.KeyPressChar("m");
            //MainDelay(dm, 500);
            if (!loginFlag)
            {
                while (true)
                {
                    int x = 0, y = 0;
                    int yanzhengmaX = 0, yanzhengmaY = 0;
                    dm.delay(1000);
                    var yanzhengmashurukuang = dm.FindStr(373, 318, 457, 336, "请输入图片中", "ffffff-62545A", 0.9, out yanzhengmaX, out yanzhengmaY);
                    if (yanzhengmaX > 0)
                    {
                        break;//找到验证码输入框表示输入密码和账号成功，跳出循环
                    }
                    /*var findtongxingzheng = dm.FindStr(0, 0, 2000, 2000, "网易通行证", "faf6fb-62545A", 0.9, out x, out y);*/
                    var findtongxingzheng = dm.FindStrFast(445, 349, 520, 370, "网易通行证", "ffffff", 0.9, out x, out y);
                    if (x > 0)
                    {
                        //32,80
                        dm.MoveTo(x + Helper.RandomNum(0, 90), y + Helper.RandomNum(32, 39));
                        dm.delay(1000);
                        dm.LeftDoubleClick();
                        //var accountArray = user.account.Split('@');
                        //dm.KeyPressStr(accountArray[0], 50);
                        dm.delay(500);
                        dm.KeyPress(8);
                        dm.delay(1000);
                        dm.SendString(user.hwnd, user.account);
                        dm.delay(500);
                        dm.MoveTo(Helper.RandomNum(0, 100), Helper.RandomNum(0, 100));
                        dm.delay(1000);
                        dm.LeftClick();
                        dm.delay(1500);
                        //输入密码
                        dm.MoveTo(x + Helper.RandomNum(0, 100), y + Helper.RandomNum(80, 86));
                        dm.delay(1000);
                        dm.LeftDoubleClick();
                        dm.delay(1000);
                        dm.KeyPress(8);
                        dm.delay(1000);
                        dm.SendString(user.hwnd, user.passWard);
                        dm.delay(1000);
                        dm.MoveTo(x + Helper.RandomNum(1, 75), y + Helper.RandomNum(127, 146));
                        dm.delay(1000);
                        dm.LeftClick();
                        dm.delay(1000);
                        //是否密码错误
                        int passwordErrorX = 0, passwordErrorY = 0;
                        var passwordError = dm.FindStrFast(355, 347, 417, 370, "密码错误", "ffffff", 0.9, out passwordErrorX, out passwordErrorY);
                        if (passwordErrorX > 0)
                        {
                            dm.MoveTo(passwordErrorX + Helper.RandomNum(123, 184), passwordErrorY + Helper.RandomNum(60, 72));
                            dm.delay(500);
                            dm.LeftClick();
                            dm.delay(500);
                            continue;
                        }
                        //账号没输进去的情况
                        int accountNullX = 0, accountNullY = 0;
                        var accountNull = dm.FindStrFast(355, 346, 457, 370, "请输入有效的通", "ffffff", 0.9, out accountNullX, out accountNullY);
                        if (accountNullX > 0)
                        {
                            dm.MoveTo(accountNullX + Helper.RandomNum(75, 135), accountNullY + Helper.RandomNum(60, 74));
                            dm.delay(500);
                            dm.LeftClick();
                            dm.delay(500);
                            continue;
                        }
                        //密码没输进去的情况
                        int passwardNullX = 0, passwardNullY = 0;
                        var passwardNull = dm.FindStrFast(357, 348, 428, 367, "请输入密码", "ffffff", 0.9, out passwardNullX, out passwardNullY);
                        if (passwardNullX > 0)
                        {
                            dm.MoveTo(passwardNullX + Helper.RandomNum(75, 135), passwardNullY + Helper.RandomNum(56, 72));
                            dm.delay(500);
                            dm.LeftClick();
                            dm.delay(500);
                            continue;
                        }
                        //账号错误的情况
                        int accountErrorX = 0, accountErrorY = 0;
                        var accountError = dm.FindStrFast(357, 347, 428, 367, "没有该用户", "ffffff", 0.9, out accountErrorX, out accountErrorY);
                        if (passwardNullX > 0)
                        {
                            dm.MoveTo(accountErrorX + Helper.RandomNum(75, 135), accountErrorY + Helper.RandomNum(56, 72));
                            dm.delay(500);
                            dm.LeftClick();
                            dm.delay(500);
                            continue;
                        }
                        loginFlag = true;
                        break;
                    }
                }
                if (!loginVerificationFlag)
                {
                    //输入验证码步骤
                    while (true)
                    {

                        //查找"请输入图片中的字符"
                        int xx = 0, yy = 0;
                        var shurutupianzhongde = dm.FindStrFast(373, 318, 457, 336, "请输入图片中", "B5B8C0-4A473F", 0.9, out xx, out yy);
                        if (xx > 0)
                        {
                            //截取验证码图片
                            var img = Helper.GetTimeSpan() + Helper.RandomNum(10000, 20000).ToString() + ".jpg";

                            var captureResult = dm.Capture(455, 330, 570, 391, img);
                            string result = string.Empty;
                            StringBuilder Reply = new StringBuilder(512);
                            StringBuilder sb = new StringBuilder(512);
                            //SetQuality(100);//如果发送动态GIF或者PNG 图片 需要调用本句
                            string file = System.Windows.Forms.Application.ExecutablePath;
                            Configuration config = ConfigurationManager.OpenExeConfiguration(file);
                            var cc = config.AppSettings.Settings["fengfengdati"].Value.ToString().Trim();
                            //var cc= txt_damapassword.Text;
                            //SetRebate(config.AppSettings.Settings["fengfengdati"].Value.ToString().Trim());//设置作者返利账号
                            string imgpath = System.AppDomain.CurrentDomain.BaseDirectory + DmConfig.DmGlobalPath + "\\" + img;
                            var ans = SendFile(cc, "3004", imgpath, 100, 0, "", sb);
                            var TID = sb.ToString();
                            if (IsRight(TID))
                            {
                                for (int i = 0; i < 999; i++)
                                {
                                    Thread.Sleep(1000);
                                    GetAnswer(TID.ToString(), Reply);
                                    if (Reply.ToString() != "")
                                    {
                                        break;
                                    }
                                }
                            }
                            //鼠标移动到输入框坐标
                            dm.MoveTo(xx + Helper.RandomNum(0, 95), yy + Helper.RandomNum(104, 119));
                            dm.delay(100);
                            dm.LeftDoubleClick();
                            dm.delay(50);
                            dm.SendString(user.hwnd, Reply.ToString());
                            dm.delay(100);
                            dm.MoveTo(xx + Helper.RandomNum(140, 200), yy + Helper.RandomNum(107, 119));
                            dm.delay(300);
                            dm.LeftDoubleClick();
                            //如果验证码错误
                            int verificationcodeErrorX = 0, verificationcodeErrorY = 0;
                            var verificationcodeError = dm.FindStrFast(355, 348, 457, 366, "验证码输入错误", "ffffff", 0.9, out verificationcodeErrorX, out verificationcodeErrorY);
                            if (verificationcodeErrorX > 0)
                            {
                                dm.MoveTo(verificationcodeErrorX + Helper.RandomNum(124, 183), verificationcodeErrorY + Helper.RandomNum(56, 72));
                                dm.delay(600);
                                dm.LeftDoubleClick();
                                dm.delay(1000);
                                continue;
                            }
                            loginVerificationFlag = true;
                            File.Delete(imgpath);
                            dm.delay(2000);
                            break;
                        }
                    }
                    dm.delay(2000);
                    //创建角色界面点击进入游戏，坐标 699,513,744,552 颜色5b6778-62545A
                    while (true)
                    {
                        int xxxx = 0, yyyy = 0;
                        var xuanfu = dm.FindPic(965, 20, 997, 51, @"\img\qiannvjingling.bmp", "000000", 0.9, 0, out xxxx, out yyyy);
                        if (xxxx > 0)
                        {
                            break;
                        }
                        else
                        {
                            int xxx = 0, yyy = 0;
                            var jinruyouxi = dm.FindStrFast(945, 682, 968, 721, "入戏", "ffffff-62545A", 0.9, out xxx, out yyy);
                            if (xxx > 0)
                            {
                                dm.delay(1000);
                                dm.MoveTo(xxx, yyy + Helper.RandomNum(8, 15));
                                //dm.delay(400);
                                //dm.MoveTo(Helper.RandomNum(150, 200), Helper.RandomNum(150, 200));
                                dm.delay(1000);
                                dm.LeftDoubleClick();
                                dm.delay(5000);
                                dm.LockInput(0);
                                break;
                            }
                            else
                            {
                                dm.delay(1000);
                            }
                        }

                    }
                    //bool wanjiaguoduoFlag = false, huodechenghaotishiFlag = false, gengxingonggaoFlag = false;
                    //输入将军令步骤
                    while (true)
                    {
                        int 将军令x = 0, 将军令y = 0;
                        var 将军令 = dm.FindStrFast(351, 436, 448, 452, "绑定大神将军令", "f6f6ce", 0.9, out 将军令x, out 将军令y);
                        if (将军令x>0)
                        {
                            dm.MoveTo(将军令x + Helper.RandomNum(107, 310), 将军令y + Helper.RandomNum(64, 81));
                            dm.delay(400);
                            dm.SendString(user.hwnd, "");
                        }
                    }


                }
            }
        }
        
        public static ReaderWriterLock readerwritelock = new ReaderWriterLock();
        public void MainEntry(dmsoft dm)
        {
            //Logger.Addlog("进入MainEntry方法");
            int hwnd = m_main_thread.m_hwnd;
            m_main_thread.m_state = ThreadState.State_Runing;
            AsyncNotify.Notify(m_main_thread.m_hwnd, AsyncNotify.Update);
            // 检测对象是否创建成功,虽然这个一般不会失败,但为了程序健壮性考虑还是加上,如果内存吃紧，还是可能会失败
            if (dm == null || dm.Ver().Length == 0)
            {
                Log.WriteStr("对象创建失败");
                AsyncNotify.Notify(m_main_thread.m_hwnd, AsyncNotify.Stop);
                return;
            }
            // 开启全局共享字库
            dm.EnableShareDict(1);
            dm.EnableRealKeypad(1);
            dm.EnableRealMouse(2,20,30);
            dm.SetPath(DmConfig.DmGlobalPath);
            dm.EnableShareDict(1);
            dm.SetDict(0, "1.txt");
            dm.SetDict(1, "number.txt");
            dm.SetDict(2, "sum9.txt");
            dm.SetDict(3, "tianlong2.txt");
            //dm.SetDict(4, "createRole.txt");
            dm.SetDict(5, "TeamUp.txt");
            //设置窗体大小
            //var xx=dm.SetWindowSize(user.hwnd, 1002, 575);
            //string str = string.Format("设置窗口大小成功:长：{0},宽:{1},结果：{2}", 1002, 575, xx);
            //Logger.Addlog(str);
            dm.Delays(800,1000);
            //dm.MoveWindow(user.hwnd, user.Index*200, 200);
            //dm.SetWindowSize(user.hwnd, 1040, 807);
            //测试用的临时窗口句柄..
            //var handle = dm.FindWindow(null, "雷电模拟器");
            //if (handle > 0)
            //{
            //    var childhwnd = dm.GetWindow(handle, 1);
            //    user.hwnd = childhwnd;
            //}
            //user.hwnd = 67088;
            //开始绑定窗口
            var dm_ret = dm.BindWindowEx(user.hwnd, "gdi", "windows", "windows", "", 101);
            dm.delay(Helper.RandomNum(1000,2000));
            if (dm_ret != 1)
            {
                Log.WriteStr(String.Format("主:绑定失败，错误码:{0}", dm.GetLastError()));
                // 通知主线程进行结束操作(释放资源)d
                AsyncNotify.Notify(m_main_thread.m_hwnd, AsyncNotify.Stop);
                //Logger.Addlog("绑定失败！");
                return;
            }
            string str = string.Format("绑定成功");
            //Logger.Addlog(str);
            //string str1 = string.Format("窗口句柄：{0},用户：{1},绑定成功！", user.hwnd, user.account);
            //Logger.Addlog(str);
            //// 禁止输入
            dm.LockInput(0);//关闭锁定
            m_main_bind_ok = true;
            while (true)
            {
                //自动登录
                if (user.AutoLogin)
                {
                    AutoLogin autoLogon = new AutoLogin(dm,user,this);
                    autoLogon.DoWork();
                }
                //主线任务(起号必须选择)
                if (user.MainLine)
                {
                    MainLineNew mainLine = new MainLineNew(dm, user,this);
                    mainLine.DoWork();
                }
                //添加好友
                if (user.AddFriend)
                {
                    AddFrends addFrends = new AddFrends(dm, user,this);
                    addFrends.DoWork();
                }
                //组队
                if (user.TeamUp)
                {
                    TeamUp team = new TeamUp(dm, user, this);
                    team.DoWork();
                }
                //江湖饭馆
                if (user.JiangHuFanGuan)
                {
                    JiangHuFanGuan jiangHuFanGuan = new JiangHuFanGuan(dm, user,this);
                    jiangHuFanGuan.DoWork();
                }
                //组队任务燕子坞、珍珑棋局、勇闯山寨
                if (user.YanZiWu)
                {
                    YanZiWu yanziwu = new YanZiWu(dm, user,this);
                    yanziwu.DoWork();
                }
                if (user.ZhenLongQiJu)
                {
                    ZhenLongQiJun zhenLongQiJun = new ZhenLongQiJun(dm, user, this);
                    zhenLongQiJun.DoWork();
                }
                if (user.YongChuangShanZhai)
                {
                    YongChuangShanZhai yongChuangShanZhai = new YongChuangShanZhai(dm, user, this);
                    yongChuangShanZhai.DoWork();
                }
                //宵小
                if (user.XiaoXiao)
                {
                    XiaoXiao xiaoXiao = new XiaoXiao(dm, user, this);
                    xiaoXiao.DoWork();
                }
                //问剑侠义
                if (user.WenJianXiaYi)
                {
                    WenJianXiaYi wenJianXiaYi = new WenJianXiaYi(dm, user,this);
                    wenJianXiaYi.DoWork();
                }
                //帮会任务
                if (user.BangHuiRenWu)
                {
                    BangHuiRenWu bangHuiRenWu = new BangHuiRenWu(dm, user,this);
                    bangHuiRenWu.DoWork();
                }
                //门派任务
                if (user.MenPaiRenWu)
                {
                    MenPaiRenWu menPaiRenWu = new MenPaiRenWu(dm, user,this);
                    menPaiRenWu.DoWork();
                }
                //门派任务
                if (user.ZongShiDianTang)
                {
                    JiangHuZongShiDian jiangHuZongShiDian = new JiangHuZongShiDian(dm, user, this);
                    jiangHuZongShiDian.DoWork();
                }
                //成就奖励
                if (user.ChengJiuJiangLi)
                {
                    ChengJiuJiangLi chengJiuJiangLi = new ChengJiuJiangLi(dm, user,this);
                    chengJiuJiangLi.DoWork();
                }
                //绝学参悟
                if (user.JueXueCanWu)
                {
                    JueXueCanWu jueXueCanWu = new JueXueCanWu(dm, user, this);
                    jueXueCanWu.DoWork();
                }
                //每日活跃
                if (user.HuoYueJiangLi)
                {
                    MeiRiHuoYue meiRiHuoYue = new MeiRiHuoYue(dm, user,this);
                    meiRiHuoYue.DoWork();
                }
                //收删邮件
                if (user.HuoYueJiangLi)
                {
                    SouShanYouJian souShanYouJian = new SouShanYouJian(dm, user,this);
                    souShanYouJian.DoWork();
                }
                //江湖记事
                if (user.JiShiJiangLi)
                {
                    JiShiJiangLi jiShiJiangLi = new JiShiJiangLi(dm, user,this);
                    jiShiJiangLi.DoWork();
                }
                //福利奖励
                if (user.FuLiJiangLi)
                {
                    FuLiJiangLi fuLiJiangLi = new FuLiJiangLi(dm, user,this);
                    fuLiJiangLi.DoWork();
                }
                MainDelay(dm, 1000);
                //切换角色
                if (user.AutoSwitch)
                {
                    user.Role += 1;
                    //切换角色操作
                }
            }
            //释放资源
            //dm.UnBindWindow();
        }

        private void SetExcepState(string state)
        {
            // 这里为何采用这样的字符串赋值方法，是考虑到自变量会在UI线程里访问，为了避免内存冲突，必须这样赋值.
            // 如果你有用到别的字符串，如果也要在别的线程里同时使用时，那么也得这样来使用.
            state.CopyTo(0, m_sub_thread.m_excep_state, 0, state.Length);
            m_sub_thread.m_excep_state[state.Length] = '\0';
            AsyncNotify.Notify(m_sub_thread.m_hwnd, AsyncNotify.Stop);
        }

        private void CheckException(dmsoft dm)
        {
            // 检测窗口是否存在
            if (dm.GetWindowState(m_sub_thread.m_hwnd, 0) == 0)
            {
                SetExcepState("窗口不见了");
            }

            // 检测窗口是否卡死



            // 检测是否掉线


            // 检测是否有弹出窗口



            // 其他检测
            //dm.KeyPressChar("s");
        }



        public void SubEntry(dmsoft dm)
        {
            m_sub_thread.m_state = ThreadState.State_Runing;
            AsyncNotify.Notify(m_sub_thread.m_hwnd, AsyncNotify.Update);

            // 检测对象是否创建成功,虽然这个一般不会失败,但为了程序健壮性考虑还是加上,如果内存吃紧，还是可能会失败
            if (dm == null || dm.Ver().Length == 0)
            {
                Log.WriteStr("对象创建失败");
                AsyncNotify.Notify(m_sub_thread.m_hwnd, AsyncNotify.Stop);
                return;
            }


            // 开启全局共享字库
            dm.EnableShareDict(1);

            // 其他设置,比如路径等等
            dm.SetPath("c:\test_game");

            // 绑定前等待主绑定成功
            while (m_main_bind_ok == false)
            {
                Thread.Sleep(1);
            }

            //int dm_ret = dm.BindWindowEx(m_sub_thread.m_hwnd, "normal", "normal", "dx", "dx.public.anti.api", 0);
            //if (dm_ret != 1)
            //{
            //    Log.WriteStr(String.Format("副:绑定失败，错误码:{0}", dm.GetLastError()));
            //    // 通知主线程进行结束操作(释放资源)
            //    AsyncNotify.Notify(m_sub_thread.m_hwnd, AsyncNotify.Stop);
            //    return;
            //}


            //while (true)
            //{
            //    // 检测一些异常,比如突然弹出的对话框，目标窗口被关闭或者掉线等突发情况
            //    // 比如检测到掉线，可考虑通知UI,然后重新运行
            //    CheckException(dm);
            //    SubDelay(dm, 3000);
            //}
        }
    }
}
