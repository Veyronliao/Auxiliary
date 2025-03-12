using senke.DmSoft;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace senke
{
    public class AutoLogon
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

        public GameOperation gameOperation { get; set; }
        public UserItem user { get; set; }
        public dmsoft dm { get; set; }
        public AutoLogon(dmsoft dm, UserItem user) 
        {
            gameOperation = new GameOperation(dm);
            this.user = user;
            this.dm = dm;
        }
        public void DoWork()
        {
            dm.UseDict(3);
            dm.delay(1000);
            //打开游戏
            while (true)
            {
                int 飞龙战天x = 0, 飞龙战天y = 0;
                dm.FindStrFast(555, 223, 617, 249, "飞龙战天", "F7F8F9-080706|D7D7D9-282826", 0.9, out 飞龙战天x, out 飞龙战天y);
                if (飞龙战天x > 0)
                {
                    dm.MoveTo(飞龙战天x , 飞龙战天y -Helper.RandomNum(20, 50));
                    dm.delay(1000);
                    dm.LeftClick();//点击同意用户协议，进入游戏登录界面
                    break;
                }
            }
            //dm.delay(1000);
            //dm.KeyPress(27);
            //dm.delay(1000);
            //dm.KeyPress(27);
            while (true)
            {
                dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
                dm.LeftClick();
                dm.delay(1000);
                //dm.KeyPress(27);
                //dm.delay(1000);
                ////再玩会
                //int 再玩会_x = 0, 再玩会_y = 0;
                //dm.FindStrFast(716, 538, 787, 571, "再玩会", "39300C-39310C", 0.9, out 再玩会_x, out 再玩会_y);
                //if (再玩会_x > 0)
                //{
                //    dm.MoveToEx(再玩会_x, 再玩会_y, 50, 20);
                //    dm.delay(1000);
                //    dm.LeftClick();
                //    dm.delay(1000);
                //}
                //下载确定
                int 下载确定x = 0, 下载确定y = 0;
                dm.FindStrFast(753, 417, 843, 469, "确定", "938171-383D2F", 0.9, out 下载确定x, out 下载确定y);
                if (下载确定x > 0)
                {
                    dm.MoveTo(下载确定x + gameOperation.RandomNum(0, 50), 下载确定y + gameOperation.RandomNum(0, 20));
                    dm.delay(1000);
                    dm.LeftDoubleClick();
                    dm.delay(1000);
                }
                int 密码登录x = 0, 密码登录y = 0;
                dm.FindStrFast(440, 172, 531, 203, "密码登录", "464646-474747", 0.9, out 密码登录x, out 密码登录y);
                if (密码登录x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(464, 484), gameOperation.RandomNum(244, 266));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    dm.KeyDown(17);
                    dm.delay(100);
                    dm.KeyPress(65);
                    dm.KeyUp(17);
                    dm.delay(1000);
                    dm.KeyPressStr(user.account, 50);
                    dm.delay(1000);
                    //密码
                    dm.MoveTo(gameOperation.RandomNum(464, 484), gameOperation.RandomNum(313, 333));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    dm.KeyDown(17);
                    dm.delay(100);
                    dm.KeyPress(65);
                    dm.KeyUp(17);
                    dm.delay(1000);
                    dm.KeyPressStr(user.passWard, 50);
                    dm.delay(1000);
                    int 已阅读并同意x = 0, 已阅读并同意y = 0;
                    dm.FindStrFast(480, 365, 559, 389, "已阅读并同意", "969696-2D2D2D", 0.9, out 已阅读并同意x, out 已阅读并同意y);
                    if (已阅读并同意x > 0)
                    {
                        dm.MoveTo(已阅读并同意x + gameOperation.RandomNum(0, 50), 已阅读并同意y + gameOperation.RandomNum(0, 10));
                        dm.delay(1000);
                        dm.LeftDoubleClick();
                        dm.delay(1000);
                    }
                    int 登录x = 0, 登录y = 0;
                    dm.FindStrFast(593, 414, 694, 448, "登录", "443708-443708", 0.9, out 登录x, out 登录y);
                    if (登录x > 0)
                    {
                        dm.MoveTo(登录x + gameOperation.RandomNum(0, 80), 登录y + gameOperation.RandomNum(0, 20));
                        dm.delay(1000);
                        dm.LeftDoubleClick();
                        dm.delay(1000);
                    }
                    int 同意x = 0, 同意y = 0;
                    dm.FindStrFast(674, 408, 795, 446, "同意", "635216-504003", 0.9, out 同意x, out 同意y);
                    if (同意x > 0)
                    {
                        dm.MoveTo(同意x + gameOperation.RandomNum(0, 50), 同意y + gameOperation.RandomNum(0, 20));
                        dm.delay(1000);
                        dm.LeftDoubleClick();
                        dm.delay(1000);
                    }
                }
                //兼容官服
                //下一步
                int 下一步x = 0, 下一步y = 0;
                dm.FindStrFast(591, 357, 693, 399, "下一步", "f3f7fc-4A504F", 0.9, out 下一步x, out 下一步y);
                if (下一步x > 0)
                {
                    //输入账号
                    dm.MoveTo(gameOperation.RandomNum(545, 805), gameOperation.RandomNum(280, 315));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    dm.KeyDown(17);
                    dm.delay(100);
                    dm.KeyPress(65);
                    dm.KeyUp(17);
                    dm.delay(1000);
                    dm.KeyPressStr(user.account, 50);
                    dm.delay(2000);
                    //勾选同意协议
                    int 官服已阅读并同意x = 0, 官服已阅读并同意y = 0;
                    dm.FindStrFast(460, 425, 571, 453, "已阅读并同意", "595959-4A504F", 0.8, out 官服已阅读并同意x, out 官服已阅读并同意y);
                    if (官服已阅读并同意x > 0)
                    {
                        dm.MoveTo(gameOperation.RandomNum(440, 452), gameOperation.RandomNum(432, 444));
                        dm.delay(1000);
                        dm.LeftClick();
                        dm.delay(1000);
                    }
                    dm.MoveTo(下一步x + gameOperation.RandomNum(0, 30), 下一步y + gameOperation.RandomNum(0, 20));
                    dm.delay(1000);
                    dm.LeftDoubleClick();
                    dm.delay(1000);
                    //输入密码
                    int 即将登录账号x = 0, 即将登录账号y = 0;
                    dm.FindStrFast(419, 225, 564, 265, "即将登录账号", "333333-4A504F", 0.9, out 即将登录账号x, out 即将登录账号y);
                    if (即将登录账号x > 0)
                    {
                        dm.MoveTo(gameOperation.RandomNum(450, 795), gameOperation.RandomNum(285, 320));
                        dm.delay(1000);
                        dm.LeftClick();
                        dm.delay(1000);
                        dm.KeyDown(17);
                        dm.delay(100);
                        dm.KeyPress(65);
                        dm.KeyUp(17);
                        dm.delay(1000);
                        dm.KeyPressStr(user.passWard, 50);
                        dm.delay(1000);
                        dm.MoveTo(gameOperation.RandomNum(455, 835), gameOperation.RandomNum(360, 400));
                        dm.delay(1000);
                        dm.LeftClick();
                        dm.delay(1000);
                    }
                }
                int 关闭x = 0, 关闭y = 0;
                dm.FindPic(974, 5, 1274, 220, "\\img\\guanbi.bmp", "000000", 0.8, 0, out 关闭x, out 关闭y);
                if (关闭x > 0)
                {
                    dm.MoveTo(关闭x, 关闭y);
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                int 推荐x = 0, 推荐y = 0;
                dm.FindPic(102, 162, 317, 662, "\\img\\tuijian.bmp", "000000", 0.8, 0, out 推荐x, out 推荐y);
                if (推荐y > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1108, 1125), gameOperation.RandomNum(90, 105));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //确定下载更新
                int 确定下载更新x = 0, 确定下载更新y = 0;
                dm.FindStrFast(674, 408, 795, 446, "确定下载更新", "635216-504003", 0.9, out 确定下载更新x, out 确定下载更新y);
                if (确定下载更新x > 0)
                {
                    dm.MoveTo(确定下载更新x + gameOperation.RandomNum(0, 50), 确定下载更新y + gameOperation.RandomNum(0, 20));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                int 闯荡江湖x = 0, 闯荡江湖y = 0;
                dm.FindStrFast(804, 452, 962, 493, "闯荡江湖", "AB9D8D-545550", 0.8, out 闯荡江湖x, out 闯荡江湖y);
                if (闯荡江湖x > 0)
                {
                    break;
                }
                int xx = 0, xy = 0;
                dm.FindStrFast(811, 114, 861, 160, "x", "535353-212121", 0.8, out xx, out xy);
                if (xx > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1107, 1128), gameOperation.RandomNum(87, 109));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                dm.delay(1000);
            }
            while (true)
            {
                int 关闭x = 0, 关闭y = 0;
                dm.FindPic(974, 5, 1274, 220, "\\img\\guanbi.bmp", "000000", 0.8, 0, out 关闭x, out 关闭y);
                if (关闭x > 0)
                {
                    dm.MoveTo(关闭x, 关闭y);
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                int 闯荡江湖x = 0, 闯荡江湖y = 0;
                dm.FindStrFast(804, 452, 962, 493, "闯荡江湖", "AB9D8D-545550", 0.8, out 闯荡江湖x, out 闯荡江湖y);
                if (闯荡江湖x > 0)
                {
                    //选择大区服务器
                    dm.MoveTo(gameOperation.RandomNum(775, 970), gameOperation.RandomNum(375, 400));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(2000);
                    //先选择大区
                    Coordinate areaCoordinate = null;
                    Coordinate serverCoordinate = null;
                    if (user.Platform== "官服")
                    {
                        areaCoordinate = ScriptData.AreaCoordinate.Find(s => s.CoordinateName == user.AreaName);
                        if (areaCoordinate != null)
                        {
                            var coordinates = areaCoordinate.CoordinateValue.Split(',');
                            dm.MoveTo(gameOperation.RandomNum(int.Parse(coordinates[0]), int.Parse(coordinates[2])), gameOperation.RandomNum(int.Parse(coordinates[1]), int.Parse(coordinates[3])));
                            dm.delay(1000);
                            dm.LeftClick();
                            dm.delay(1000);
                        }
                        //选择服务器
                        serverCoordinate = ScriptData.ServerCoordinate.Find(s => s.CoordinateName == user.ServerName);
                        if (serverCoordinate != null)
                        {
                            var coordinates = serverCoordinate.CoordinateValue.Split(',');
                            dm.MoveTo(gameOperation.RandomNum(int.Parse(coordinates[0]), int.Parse(coordinates[2])), gameOperation.RandomNum(int.Parse(coordinates[1]), int.Parse(coordinates[3])));
                            dm.delay(1000);
                            dm.LeftClick();
                            dm.delay(1000);
                        }
                    }
                    if (user.Platform == "抖音") 
                    {
                        areaCoordinate = ScriptData.DouYinAreaCoordinate.Find(s => s.CoordinateName == user.AreaName);
                        if (areaCoordinate != null)
                        {
                            var coordinates = areaCoordinate.CoordinateValue.Split(',');
                            dm.MoveTo(gameOperation.RandomNum(int.Parse(coordinates[0]), int.Parse(coordinates[2])), gameOperation.RandomNum(int.Parse(coordinates[1]), int.Parse(coordinates[3])));
                            dm.delay(1000);
                            dm.LeftClick();
                            dm.delay(1000);
                        }
                        //选择服务器
                        serverCoordinate = ScriptData.DouYinServerCoordinate.Find(s => s.CoordinateName == user.ServerName);
                        if (serverCoordinate != null)
                        {
                            var coordinates = serverCoordinate.CoordinateValue.Split(',');
                            dm.MoveTo(gameOperation.RandomNum(int.Parse(coordinates[0]), int.Parse(coordinates[2])), gameOperation.RandomNum(int.Parse(coordinates[1]), int.Parse(coordinates[3])));
                            dm.delay(1000);
                            dm.LeftClick();
                            dm.delay(1000);
                        }
                    }
                    dm.MoveTo(闯荡江湖x + gameOperation.RandomNum(0, 100), 闯荡江湖y + gameOperation.RandomNum(0, 30));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //创建角色
                int 武当x = 0, 武当y = 0;
                dm.FindStrFast(740, 529, 770, 581, "武当", "EECFBE-112F3A", 0.8, out 武当x, out 武当y);
                if (武当x > 0)
                {
                    dm.MoveToEx(武当x, 武当y, 10, 10);
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    dm.MoveTo(gameOperation.RandomNum(464, 514), gameOperation.RandomNum(637, 684));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                int 切换门派x = 0, 切换门派y = 0;
                dm.FindStrFast(1122, 5, 1229, 29, "切换门派", "9B8D80-43483F", 0.8, out 切换门派x, out 切换门派y);
                if (切换门派x > 0)
                {
                    if (user.Sect == "逍遥")
                    {
                        dm.MoveTo(gameOperation.RandomNum(1115, 1150), gameOperation.RandomNum(80, 115));
                    }
                    else if (user.Sect == "峨眉")
                    {
                        dm.MoveTo(gameOperation.RandomNum(1200, 1240), gameOperation.RandomNum(80, 115));
                    }
                    else if (user.Sect == "丐帮")
                    {
                        dm.MoveTo(gameOperation.RandomNum(1115, 1150), gameOperation.RandomNum(180, 215));
                    }
                    else if (user.Sect == "武当")
                    {
                        dm.MoveTo(gameOperation.RandomNum(1200, 1240), gameOperation.RandomNum(180, 215));
                    }
                    else if (user.Sect == "天山")
                    {
                        dm.MoveTo(gameOperation.RandomNum(1115, 1150), gameOperation.RandomNum(280, 315));
                    }
                    else if (user.Sect == "无尘")
                    {
                        dm.MoveTo(gameOperation.RandomNum(1200, 1240), gameOperation.RandomNum(280, 315));
                    }
                    else if (user.Sect == "明教")
                    {
                        dm.MoveTo(gameOperation.RandomNum(1200, 1240), gameOperation.RandomNum(380, 415));
                    }
                    else
                    {

                    }
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(2000);
                    int 女x = 0,女y = 0;
                    dm.FindStrFast(1207, 568, 1238, 601, "女", "C5BF98-3A3E3B", 0.8, out 女x, out 女y);
                    if (女x>0)
                    {
                        //选中男女
                        if (user.Index % 2 == 0)
                        {
                            dm.MoveTo(gameOperation.RandomNum(1120, 1150), gameOperation.RandomNum(570, 600));
                            dm.delay(1000);
                            dm.LeftClick();
                            dm.delay(1000);
                        }
                        else
                        {
                            dm.MoveTo(gameOperation.RandomNum(1210, 1235), gameOperation.RandomNum(570, 600));
                            dm.delay(1000);
                            dm.LeftClick();
                            dm.delay(1000);
                        }
                    }
                    //下一步（选择名字）
                    dm.MoveTo(gameOperation.RandomNum(1105, 1245), gameOperation.RandomNum(645, 685));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                int 下一步x = 0, 下一步y = 0;
                dm.FindStrFast(1039, 643, 1172, 690, "下一步", "8E837F-404846", 0.8, out 下一步x, out 下一步y);
                if (下一步x > 0)
                {
                    dm.MoveTo(下一步x + gameOperation.RandomNum(0, 50), 下一步y + gameOperation.RandomNum(0, 25));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    //int 您的名字x = 0, 您的名字y = 0;
                    //dm.FindStrFast(585, 293, 693, 330, "您的名字", "AFA594-46453E", 0.9, out 您的名字x, out 您的名字y);
                    //if (您的名字x>0)
                    //{
                    //    dm.MoveTo(gameOperation.RandomNum(515, 722), gameOperation.RandomNum(353, 385));
                    //    dm.delay(1000);
                    //    dm.LeftDoubleClick();
                    //    dm.delay(1000);
                    //    dm.KeyDown(17);
                    //    dm.delay(100);
                    //    dm.KeyPress(65);
                    //    dm.KeyUp(17);
                    //    dm.delay(1000);
                    //    dm.SendString(user.hwnd, user.nickname);
                    //    dm.delay(1000);
                    //}
                    //下一步（生产随机名字）
                    dm.MoveTo(gameOperation.RandomNum(1025, 1180), gameOperation.RandomNum(645, 685));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    //确定名字后进入剧情
                    int 确认x = 0, 确认y = 0;
                    dm.FindStrFast(669, 437, 821, 480, "确认", "A19483-515749", 0.8, out 确认x, out 确认y);
                    if (确认x>0)
                    {
                        dm.MoveTo(确认x + gameOperation.RandomNum(0, 50), 确认y + gameOperation.RandomNum(0, 20));
                        dm.delay(1000);
                        dm.LeftClick();
                        dm.delay(500);
                        dm.LeftClick();
                        dm.delay(1000);
                        break;//跳出自动登录脚本，开始下一个脚本
                    }
                }
                int xx = 0, xy = 0;
                dm.FindStrFast(811, 114, 861, 160, "x", "535353-212121", 0.8, out xx, out xy);
                if (xx > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1107, 1128), gameOperation.RandomNum(87, 109));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    break;
                }
                //选择角色
                
                int 进入游戏x = 0, 进入游戏y = 0;
                dm.FindStrFast(1071, 625, 1232, 671, "进入游戏", "998C7E-484E44", 0.8, out 进入游戏x, out 进入游戏y);
                if (进入游戏x > 0)
                {
                    if (user.Role==1)
                    {
                        dm.MoveTo(gameOperation.RandomNum(115, 175), gameOperation.RandomNum(130, 180));
                    }
                    if (user.Role == 2)
                    {
                        dm.MoveTo(gameOperation.RandomNum(125, 175), gameOperation.RandomNum(250, 300));
                    }
                    if (user.Role == 3)
                    {
                        dm.MoveTo(gameOperation.RandomNum(125, 175), gameOperation.RandomNum(375, 425));
                    }
                    if (user.Role == 4)
                    {
                        dm.MoveTo(gameOperation.RandomNum(125, 175), gameOperation.RandomNum(500, 550));
                    }
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    dm.MoveTo(进入游戏x + gameOperation.RandomNum(0, 100), 进入游戏y + gameOperation.RandomNum(0, 25));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    break;
                }

                dm.delay(1000);
            }
        }
    }
}
