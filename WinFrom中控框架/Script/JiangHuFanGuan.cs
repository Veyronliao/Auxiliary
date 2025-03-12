using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senke
{
    /// <summary>
    /// 组队任务
    /// </summary>
    public class JiangHuFanGuan
    {
        public GameOperation gameOperation { get; set; }
        public UserItem user { get; set; }
        public dmsoft dm { get; set; }
        public Script script { get; set; }
        public JiangHuFanGuan(dmsoft dm, UserItem user, Script script)
        {
            gameOperation = new GameOperation(dm);
            this.user = user;
            this.dm = dm;
            this.script = script;
        }
        public void DoWork()
        {
            DmSoft.ScriptData.退出江湖饭馆 = false;
            DateTime now = DateTime.Now;
            int tryCount = 0;
            //关闭窗体
            dm.KeyPress(27);
            script.MainDelay(dm,1000);
            script.MainDelay(dm,1000);
            //点击再玩会
            dm.MoveTo(gameOperation.RandomNum(495, 620), gameOperation.RandomNum(385, 410));
            script.MainDelay(dm,1000);
            dm.LeftClick();
            script.MainDelay(dm,1000);
            dm.KeyPress(27);
            script.MainDelay(dm,1000);
            dm.MoveTo(gameOperation.RandomNum(495, 620), gameOperation.RandomNum(385, 410));
            script.MainDelay(dm,1000);
            dm.LeftClick();
            script.MainDelay(dm,1000);
            dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
            dm.LeftClick();
            script.MainDelay(dm,1000);
            while (true)
            {
                dm.UseDict(3);
                script.MainDelay(dm,1000);
                //江湖饭馆
                if (DmSoft.ScriptData.退出江湖饭馆)
                {
                    break;
                }
                if (user.isCaptain)
                {
                    if (DmSoft.ScriptData.退出江湖饭馆)
                    {
                        break;
                    }
                    while (true)
                    {
                        dm.KeyPress(27);
                        script.MainDelay(dm,1000);
                        dm.MoveTo(gameOperation.RandomNum(495, 620), gameOperation.RandomNum(385, 410));
                        script.MainDelay(dm,1000);
                        dm.LeftClick();
                        script.MainDelay(dm,1000);
                        dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
                        dm.LeftClick();
                        script.MainDelay(dm,1000);
                        if (tryCount >= 10)
                        {
                            DmSoft.ScriptData.退出江湖饭馆 = true;
                            break;
                        }
                        //点击活动
                        int 活动x = 0, 活动y = 0;
                        dm.FindPic(767, 83, 805, 124, "\\img\\活动.bmp", "000000", 0.9, 0, out 活动x, out 活动y);
                        if (活动x > 0)
                        {
                            dm.MoveToEx(活动x, 活动y, 10, 10);
                            script.MainDelay(dm,1000);
                            dm.LeftClick();
                            script.MainDelay(dm,1000);
                        }
                        script.MainDelay(dm,1000);
                        //江湖饭馆
                        int 江湖饭馆x = 0, 江湖饭馆y = 0;
                        dm.FindPic(117, 68, 839, 442, "\\img\\江湖饭馆标志.bmp", "000000", 0.9, 0, out 江湖饭馆x, out 江湖饭馆y);
                        if (江湖饭馆x > 0)
                        {
                            dm.MoveToEx(江湖饭馆x, 江湖饭馆y,50, 20);
                            script.MainDelay(dm,1000);
                            dm.LeftClick();
                            script.MainDelay(dm,1000);
                        }
                        else
                        {
                            tryCount++;
                            script.MainDelay(dm,1000);
                            continue;
                        }
                        //前往活动
                        int 前往活动x = 0, 前往活动y = 0;
                        dm.FindStrFast(542, 409, 639, 436, "前往活动", "90857B-444541", 0.8, out 前往活动x, out 前往活动y);
                        if (前往活动x > 0)
                        {
                            dm.MoveToEx(前往活动x, 前往活动y, 30, 20);
                            script.MainDelay(dm,1000);
                            dm.LeftClick();
                            script.MainDelay(dm,1000);
                            while (true)
                            {
                                int 前往二楼x = 0, 前往二楼y = 0;
                                dm.FindStrFast(776, 329, 869, 353, "前往二楼", "9E8D84-484C48", 0.8, out 前往二楼x, out 前往二楼y);
                                if (前往二楼x > 0)
                                {
                                    dm.MoveTo(前往二楼x + gameOperation.RandomNum(0, 30), 前往二楼y + gameOperation.RandomNum(0, 20));
                                    script.MainDelay(dm,1000);
                                    dm.LeftClick();
                                    dm.delay(3000);
                                    break;
                                }
                                script.MainDelay(dm,1000);
                            }
                            break;
                        }
                    }
                    while (true)
                    {
                        if (DmSoft.ScriptData.退出江湖饭馆)
                        {
                            break;
                        }
                        //清空对话框框
                        dm.KeyPress(27);
                        script.MainDelay(dm,1000);
                        dm.MoveTo(gameOperation.RandomNum(495, 620), gameOperation.RandomNum(385, 410));
                        script.MainDelay(dm,1000);
                        dm.LeftClick();
                        script.MainDelay(dm,1000);
                        dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
                        dm.LeftClick();
                        script.MainDelay(dm,1000);
                        //召集
                        //dm.MoveTo(gameOperation.RandomNum(75, 100), gameOperation.RandomNum(300, 320));
                        //script.MainDelay(dm,1000);
                        //dm.LeftClick();
                        //script.MainDelay(dm,1000);
                        //手动控制队长走到桌边，出现坐下提示
                        //坐下
                        int 坐下x = 0, 坐下y = 0;
                        dm.FindPic(604, 301, 654, 347, "\\img\\坐下.bmp", "000000", 0.8, 0, out 坐下x, out 坐下y);
                        if (坐下x > 0)
                        {
                            dm.MoveToEx(坐下x, 坐下y, 10, 10);
                            script.MainDelay(dm,1000);
                            dm.LeftClick();
                            script.MainDelay(dm,1000);
                            
                        }
                        //点餐
                        int 点餐x = 0, 点餐y = 0;
                        dm.FindPic(827, 14, 887, 69, "\\img\\点餐.bmp", "000000", 0.8, 0, out 点餐x, out 点餐y);
                        if (点餐x > 0)
                        {
                            dm.MoveTo(点餐x + gameOperation.RandomNum(0, 10), 点餐y + gameOperation.RandomNum(0, 10));
                            script.MainDelay(dm,1000);
                            dm.LeftClick();
                            script.MainDelay(dm,1000);
                        }
                        //判断食量是否满足
                        int 满足标志x = 0, 满足标志y = 0;
                        dm.FindPic(435, 483, 466, 508, "\\img\\饭量满足标志.bmp", "000000", 0.8, 0, out 满足标志x, out 满足标志y);
                        if (满足标志x > 0)
                        {
                            //关闭窗口，离座、退出饭馆
                            dm.KeyPress(27);
                            script.MainDelay(dm,1000);
                            dm.MoveTo(gameOperation.RandomNum(495, 620), gameOperation.RandomNum(385, 410));
                            script.MainDelay(dm,1000);
                            dm.LeftClick();
                            script.MainDelay(dm,1000);
                            dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
                            dm.LeftClick();
                            script.MainDelay(dm,2000);
                            //离座
                            dm.MoveTo(gameOperation.RandomNum(775, 790), gameOperation.RandomNum(105, 125));
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 2000);
                            //离开饭馆
                            dm.MoveTo(gameOperation.RandomNum(600, 690),gameOperation.RandomNum(370, 400));
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 2000);
                            dm.MoveTo(gameOperation.RandomNum(500, 604), gameOperation.RandomNum(315, 345));
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                            DmSoft.ScriptData.退出江湖饭馆 = true;
                            break; 
                        }
                        //加菜
                        int 加菜x = 0, 加菜y = 0;
                        dm.FindPic(893, 72, 936, 110, "\\img\\加菜标志.bmp", "000000", 0.8, 0, out 加菜x, out 加菜y);
                        if (加菜x > 0)
                        {
                            dm.MoveTo(加菜x, 加菜y);
                            script.MainDelay(dm,1000);
                            dm.LeftClick();
                            script.MainDelay(dm,2000);
                            dm.MoveTo(gameOperation.RandomNum(905, 920), gameOperation.RandomNum(160, 175));
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                        }
                        //下单
                        int 下单x = 0, 下单y = 0;
                        dm.FindStrFast(784, 456, 854, 482, "下单", "9A8D89-4B5150", 0.8, out 下单x, out 下单y);
                        if (下单x > 0)
                        {
                            dm.MoveTo(下单x + gameOperation.RandomNum(0, 30), 下单y + gameOperation.RandomNum(0, 20));
                            script.MainDelay(dm,1000);
                            dm.LeftClick();
                            script.MainDelay(dm,1000);
                            dm.MoveTo(gameOperation.RandomNum(415, 515), gameOperation.RandomNum(370, 395));
                            script.MainDelay(dm,1000);
                            dm.LeftClick();
                            dm.delay(3000);
                        }
                        dm.delay(10000);
                    }
                }
                else
                {
                    //队友
                    int 关闭点菜窗口x = 0, 关闭点菜窗口y = 0;
                    dm.FindPic(912, 1, 959, 39, "\\img\\关闭.bmp", "000000", 0.8, 0, out 关闭点菜窗口x, out 关闭点菜窗口y);
                    if (关闭点菜窗口x > 0)
                    {
                        dm.MoveToEx(关闭点菜窗口x, 关闭点菜窗口y, 10, 10);
                        script.MainDelay(dm,1000);
                        dm.LeftClick();
                        script.MainDelay(dm,1000);
                    }
                    int 关闭点菜窗口1x = 0, 关闭点菜窗口1y = 0;
                    dm.FindPic(912, 1, 959, 39, "\\img\\关闭1.bmp", "000000", 0.8, 0, out 关闭点菜窗口1x, out 关闭点菜窗口1y);
                    if (关闭点菜窗口1x > 0)
                    {
                        dm.MoveToEx(关闭点菜窗口1x, 关闭点菜窗口1y, 10, 10);
                        script.MainDelay(dm,1000);
                        dm.LeftClick();
                        script.MainDelay(dm,1000);
                    }
                    //确定
                    int 跳过动画xx = 0, 跳过动画yy = 0;
                    dm.FindStrFast(694, 424, 780, 459, "确定跳过动画", "978A77-424739", 0.8, out 跳过动画xx, out 跳过动画yy);
                    if (跳过动画xx > 0)
                    {
                        dm.MoveTo(跳过动画xx + gameOperation.RandomNum(0, 30), 跳过动画yy + gameOperation.RandomNum(0, 20));
                        script.MainDelay(dm,1000);
                        dm.LeftClick();
                        script.MainDelay(dm,1000);
                    }
                    //int 确定x = 0, 确定y = 0;
                    //dm.FindStrFast(694, 424, 780, 459, "确定", "978A77-424739", 0.8, out 确定x, out 确定y);
                    //if (确定x > 0)
                    //{
                    //    dm.MoveTo(确定x + gameOperation.RandomNum(0, 30), 确定y + gameOperation.RandomNum(0, 20));
                    //    script.MainDelay(dm,1000);
                    //    dm.LeftClick();
                    //    script.MainDelay(dm,1000);
                    //}
                    //下单
                    int 下单x = 0, 下单y = 0;
                    dm.FindStrFast(784, 456, 854, 482, "下单", "9A8D89-4B5150", 0.8, out 下单x, out 下单y);
                    if (下单x > 0)
                    {
                        dm.KeyPress(27);
                        script.MainDelay(dm,1000);
                        dm.MoveTo(gameOperation.RandomNum(495, 620), gameOperation.RandomNum(385, 410));
                        script.MainDelay(dm,1000);
                        dm.LeftClick();
                        script.MainDelay(dm,1000);
                        dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
                        dm.LeftClick();
                        script.MainDelay(dm,1000);
                    }
                    if (DmSoft.ScriptData.退出江湖饭馆)
                    {
                        while (true)
                        {
                            if (DmSoft.ScriptData.退出江湖饭馆)
                            {
                                break;
                            }
                            //关闭窗口，离座、退出饭馆
                            dm.KeyPress(27);
                            script.MainDelay(dm,1000);
                            dm.MoveTo(gameOperation.RandomNum(495, 620), gameOperation.RandomNum(385, 410));
                            script.MainDelay(dm,1000);
                            dm.LeftClick();
                            script.MainDelay(dm,1000);
                            dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
                            dm.LeftClick();
                            script.MainDelay(dm,1000);
                            //离座
                            int 队长离座x = 0, 队长离座y = 0;
                            dm.FindPic(756, 89, 816, 144, "\\img\\离座.bmp", "000000", 0.8, 0, out 队长离座x, out 队长离座y);
                            if (队长离座x > 0)
                            {
                                dm.MoveTo(队长离座x + gameOperation.RandomNum(0, 10), 队长离座y + gameOperation.RandomNum(0, 10));
                                script.MainDelay(dm,1000);
                                dm.LeftClick();
                                script.MainDelay(dm,1000);
                            }
                            //离开饭馆
                            int 离开饭馆x = 0, 离开饭馆y = 0;
                            dm.FindStrFast(594, 367, 690, 398, "离开饭馆", "9A8D89-4B5150", 0.8, out 离开饭馆x, out 离开饭馆y);
                            if (离开饭馆x > 0)
                            {
                                dm.MoveTo(离开饭馆x + gameOperation.RandomNum(0, 30), 离开饭馆y + gameOperation.RandomNum(0, 20));
                                script.MainDelay(dm,1000);
                                dm.LeftClick();
                                script.MainDelay(dm,1000);
                                dm.MoveTo(gameOperation.RandomNum(670, 800), gameOperation.RandomNum(425, 460));
                                script.MainDelay(dm,1000);
                                dm.LeftClick();
                                script.MainDelay(dm,1000);
                                break;
                            }
                        }
                        break;
                    }
                    script.MainDelay(dm,1000);
                }
                script.MainDelay(dm,1000);
                DateTime dateTime = DateTime.Now;
                if ((dateTime-now).TotalMinutes>=6)
                {
                    break;
                }
            }
        }
    }
}
