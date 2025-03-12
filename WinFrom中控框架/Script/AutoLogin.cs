using senke.DmSoft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace senke
{
    public class AutoLogin
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
        public Script script { get; set; }
        public AutoLogin(dmsoft dm, UserItem user,Script script)
        {
            gameOperation = new GameOperation(dm);
            this.user = user;
            this.dm = dm;
            this.script=script;
        }
        public void DoWork() 
        {
            dm.UseDict(3);
            script.MainDelay(dm,1000);
            //打开游戏
            while (true)
            {
                int 飞龙战天x = 0, 飞龙战天y = 0;
                dm.FindPic(0, 0, 960, 540, "\\img\\appicon.bmp", "000000", 0.8, 0, out 飞龙战天x, out 飞龙战天y);
                if (飞龙战天x > 0)
                {
                    dm.MoveTo(飞龙战天x, 飞龙战天y);
                    script.MainDelay(dm,1000);
                    dm.LeftClick();//点击同意用户协议，进入游戏登录界面
                    script.MainDelay(dm, 1000);
                }
                int 关闭x = 0, 关闭y = 0;
                dm.FindPic(808, 44, 865, 99, "\\img\\guanbi.bmp", "000000", 0.8, 0, out 关闭x, out 关闭y);
                if (关闭x > 0)
                {
                    dm.MoveTo(关闭x, 关闭y);
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                }
                int 选择服务器圆点x = 0, 选择服务器圆点y = 0;
                dm.FindPic(576, 274, 612, 308, "\\img\\选择服务器圆点.bmp", "000000", 0.8, 0, out 选择服务器圆点x, out 选择服务器圆点y);
                if (选择服务器圆点x > 0)
                {
                    dm.MoveTo(选择服务器圆点x, 选择服务器圆点y);
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 2000);
                    //先选择大区
                    Coordinate areaCoordinate = null;
                    Coordinate serverCoordinate = null;
                    if (user.Platform == "官服")
                    {
                        areaCoordinate = ScriptData.AreaCoordinate.Find(s => s.CoordinateName == user.AreaName);
                        if (areaCoordinate != null)
                        {
                            var coordinates = areaCoordinate.CoordinateValue.Split(',');
                            dm.MoveTo(gameOperation.RandomNum(int.Parse(coordinates[0]), int.Parse(coordinates[2])), gameOperation.RandomNum(int.Parse(coordinates[1]), int.Parse(coordinates[3])));
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                        }
                        //选择服务器
                        serverCoordinate = ScriptData.ServerCoordinate.Find(s => s.CoordinateName == user.ServerName);
                        if (serverCoordinate != null)
                        {
                            var coordinates = serverCoordinate.CoordinateValue.Split(',');
                            dm.MoveTo(gameOperation.RandomNum(int.Parse(coordinates[0]), int.Parse(coordinates[2])), gameOperation.RandomNum(int.Parse(coordinates[1]), int.Parse(coordinates[3])));
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                        }
                    }
                    if (user.Platform == "抖音")
                    {
                        areaCoordinate = ScriptData.DouYinAreaCoordinate.Find(s => s.CoordinateName == user.AreaName);
                        if (areaCoordinate != null)
                        {
                            var coordinates = areaCoordinate.CoordinateValue.Split(',');
                            dm.MoveTo(gameOperation.RandomNum(int.Parse(coordinates[0]), int.Parse(coordinates[2])), gameOperation.RandomNum(int.Parse(coordinates[1]), int.Parse(coordinates[3])));
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                        }
                        //选择服务器
                        serverCoordinate = ScriptData.DouYinServerCoordinate.Find(s => s.CoordinateName == user.ServerName);
                        if (serverCoordinate != null)
                        {
                            var coordinates = serverCoordinate.CoordinateValue.Split(',');
                            dm.MoveTo(gameOperation.RandomNum(int.Parse(coordinates[0]), int.Parse(coordinates[2])), gameOperation.RandomNum(int.Parse(coordinates[1]), int.Parse(coordinates[3])));
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                        }
                    }
                    dm.MoveTo(gameOperation.RandomNum(610, 710),gameOperation.RandomNum(340, 365));//点击闯荡江湖
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                }
                int 确定提示x = 0, 确定提示y = 0;
                dm.FindPic(382, 114, 441, 164, "\\img\\确定提示.bmp", "000000", 0.8, 0, out 确定提示x, out 确定提示y);
                if (确定提示x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(435, 525), gameOperation.RandomNum(320, 340));//点击闯荡江湖
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                }
                //进入创建角色界面
                int 武当x = 0, 武当y = 0;
                dm.FindPic(16, 279, 955, 559, "\\img\\武当图标.bmp", "000000", 0.8, 0, out 武当x, out 武当y);
                if (武当x > 0)
                {
                    dm.MoveToEx(武当x, 武当y, 10, 10);
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                    dm.MoveTo(gameOperation.RandomNum(355, 380), gameOperation.RandomNum(485, 508));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                }
                int 武当1x = 0, 武当1y = 0;
                dm.FindStrFast(355, 398, 379, 439, "武当", "EED0C0-112D37", 0.8, out 武当1x, out 武当1y);
                if (武当1x>0)
                {
                    dm.MoveToEx(武当1x, 武当1y, 10, 10);
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                }
                int 武当图标2x = 0, 武当图标2y = 0;
                dm.FindPic(896, 129, 942, 169, "\\img\\武当图标2.bmp", "000000", 0.8, 0, out 武当图标2x, out 武当图标2y);
                if (武当图标2x > 0)
                {
                    if (user.Sect == "逍遥")
                    {
                        dm.MoveTo(gameOperation.RandomNum(835, 865), gameOperation.RandomNum(60, 85));
                    }
                    else if (user.Sect == "峨眉")
                    {
                        dm.MoveTo(gameOperation.RandomNum(900, 930), gameOperation.RandomNum(60, 85));
                    }
                    else if (user.Sect == "丐帮")
                    {
                        dm.MoveTo(gameOperation.RandomNum(835, 865), gameOperation.RandomNum(130, 160));
                    }
                    else if (user.Sect == "武当")
                    {
                        dm.MoveTo(gameOperation.RandomNum(900, 930), gameOperation.RandomNum(130, 160));
                    }
                    else if (user.Sect == "天山")
                    {
                        dm.MoveTo(gameOperation.RandomNum(835, 865), gameOperation.RandomNum(210, 240));
                    }
                    else if (user.Sect == "无尘")
                    {
                        dm.MoveTo(gameOperation.RandomNum(900, 930), gameOperation.RandomNum(210, 240));
                    }
                    else if (user.Sect == "明教")
                    {
                        dm.MoveTo(gameOperation.RandomNum(900, 930), gameOperation.RandomNum(285, 310));
                    }
                    else
                    {

                    }
                    script.MainDelay(dm,1000);
                    dm.LeftClick();
                    script.MainDelay(dm,1000);
                    //选中男女
                    if (user.Index % 2 == 0)
                    {
                        dm.MoveTo(gameOperation.RandomNum(840, 862), gameOperation.RandomNum(430, 450));
                        script.MainDelay(dm,1000);
                        dm.LeftClick();
                        script.MainDelay(dm,1000);
                    }
                    else
                    {
                        dm.MoveTo(gameOperation.RandomNum(905, 930), gameOperation.RandomNum(430, 450));
                        script.MainDelay(dm,1000);
                        dm.LeftClick();
                        script.MainDelay(dm,1000);
                    }
                    //下一步
                    dm.MoveTo(gameOperation.RandomNum(830, 940), gameOperation.RandomNum(485, 510));
                    script.MainDelay(dm,1000);
                    dm.LeftClick();
                    script.MainDelay(dm,1000);
                    //下一步（选择名字）
                    dm.MoveTo(gameOperation.RandomNum(785, 875), gameOperation.RandomNum(485, 515));
                    script.MainDelay(dm,1000);
                    dm.LeftClick();
                    script.MainDelay(dm,1000);
                    //确认
                    dm.MoveTo(gameOperation.RandomNum(520, 595), gameOperation.RandomNum(330, 355));
                    script.MainDelay(dm,1000);
                    dm.LeftClick();
                    script.MainDelay(dm,1000);
                    dm.LeftClick();
                    script.MainDelay(dm,1000);
                    break;
                }
                //进入游戏，先选择角色
                int 进入游戏x = 0, 进入游戏y = 0;
                dm.FindStrFast(819, 473, 910, 498, "进入游戏", "98887C-494B42", 0.8, out 进入游戏x, out 进入游戏y);
                if (进入游戏x > 0)
                {
                    if (user.Role == 1)
                    {
                        dm.MoveTo(gameOperation.RandomNum(95, 125), gameOperation.RandomNum(90, 125));
                    }
                    if (user.Role == 2)
                    {
                        dm.MoveTo(gameOperation.RandomNum(95, 125), gameOperation.RandomNum(190, 223));
                    }
                    if (user.Role == 3)
                    {
                        dm.MoveTo(gameOperation.RandomNum(95, 125), gameOperation.RandomNum(285, 315));
                    }
                    if (user.Role == 4)
                    {
                        dm.MoveTo(gameOperation.RandomNum(95, 125), gameOperation.RandomNum(380, 405));
                    }
                    script.MainDelay(dm,1000);
                    dm.LeftClick();
                    script.MainDelay(dm,1000);
                }
                //点击进入游戏
                int 进入游戏1x = 0, 进入游戏1y = 0;
                dm.FindStrFast(819, 473, 910, 498, "进入游戏", "98887C-494B42", 0.8, out 进入游戏1x, out 进入游戏1y);
                if (进入游戏1x > 0)
                {
                    dm.MoveTo(进入游戏x + gameOperation.RandomNum(0, 30), 进入游戏y + gameOperation.RandomNum(0, 20));
                    script.MainDelay(dm,1000);
                    dm.LeftClick();
                    script.MainDelay(dm,1000);
                    int waittimes= 0;
                    while (true)
                    {
                        waittimes++;
                        dm.delay(2000);
                        if (waittimes>=15)
                        {
                            //清空广告弹窗
                            dm.KeyPress(27);
                            script.MainDelay(dm,1000);
                            //点击再玩会
                            dm.MoveTo(gameOperation.RandomNum(495, 620), gameOperation.RandomNum(385, 410));
                            script.MainDelay(dm,1000);
                            dm.LeftClick();
                            script.MainDelay(dm,1000);
                            dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
                            dm.LeftClick();
                            script.MainDelay(dm,1000);
                            dm.KeyPress(27);
                            script.MainDelay(dm,1000);
                            //点击再玩会
                            dm.MoveTo(gameOperation.RandomNum(495, 620), gameOperation.RandomNum(385, 410));
                            script.MainDelay(dm,1000);
                            dm.LeftClick();
                            script.MainDelay(dm,1000);
                            dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
                            dm.LeftClick();
                            script.MainDelay(dm,1000);
                            break;
                        }
                    }
                    break;
                }
                //确定
                int 确定x = 0, 确定y = 0;
                dm.FindStrFast(256, 217, 685, 412, "确定", "968975-414637|98887C-494B42", 0.8, out 确定x, out 确定y);
                if (确定x > 0)
                {
                    dm.MoveToEx(确定x, 确定y, 10, 10);
                    script.MainDelay(dm,1000);
                    dm.LeftClick();
                    script.MainDelay(dm,1000);
                }
                //确定下载
                int 确定下载x = 0, 确定下载y = 0;
                dm.FindStrFast(246, 281, 705, 372, "确定下载", "968975-414637|98887C-494B42", 0.8, out 确定下载x, out 确定下载y);
                if (确定下载x > 0)
                {
                    dm.MoveToEx(确定下载x, 确定下载y, 10, 10);
                    script.MainDelay(dm,1000);
                    dm.LeftClick();
                    script.MainDelay(dm,1000);
                }
            }
        }
    }
}
