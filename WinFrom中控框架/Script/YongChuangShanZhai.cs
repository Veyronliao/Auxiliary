using senke.DmSoft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace senke
{
    /// <summary>
    /// 勇创山寨
    /// </summary>
    public class YongChuangShanZhai
    {
        public GameOperation gameOperation { get; set; }
        public UserItem user { get; set; }
        public dmsoft dm { get; set; }
        public Script script { get; set; }
        public YongChuangShanZhai(dmsoft dm, UserItem user, Script script)
        {
            gameOperation = new GameOperation(dm);
            this.user = user;
            this.dm = dm;
            this.script = script;
        }
        public void DoWork()
        {
            while (true)
            {
                if (ScriptData.退出勇创山寨)
                {
                    break;
                }
                dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
                dm.LeftClick();
                script.MainDelay(dm, 1000);
                if (user.isCaptain)
                {
                    dm.UseDict(3);
                    script.MainDelay(dm, 1000);
                    //勇创山寨
                    int 勇创山寨 = 0;
                    DateTime dtyongchuangshanzhai1 = DateTime.Now;
                    while (true)
                    {
                        if (勇创山寨 > 10)
                        {
                            break;
                        }
                        dm.KeyPress(27);
                        script.MainDelay(dm, 1000);
                        //点击再玩会
                        dm.MoveTo(gameOperation.RandomNum(495, 620), gameOperation.RandomNum(385, 410));
                        script.MainDelay(dm, 1000);
                        dm.LeftClick();
                        script.MainDelay(dm, 1000);
                        dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
                        dm.LeftClick();
                        script.MainDelay(dm, 1000);
                        //点击活动
                        int 活动x = 0, 活动y = 0;
                        dm.FindPic(762, 79, 815, 134, "\\img\\活动.bmp", "000000", 0.9, 0, out 活动x, out 活动y);
                        if (活动x > 0)
                        {
                            dm.MoveToEx(活动x, 活动y, 10, 10);
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                        }
                        int 勇创山寨x = 0, 勇创山寨y = 0;
                        dm.FindStrFast(109, 59, 835, 438, "勇闯山寨", "645D53-645D53", 0.8, out 勇创山寨x, out 勇创山寨y);
                        if (勇创山寨x > 0)
                        {
                            dm.MoveToEx(勇创山寨x, 勇创山寨y, 50, 20);
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                        }
                        else
                        {
                            勇创山寨++;
                            script.MainDelay(dm, 1000);
                        }
                        int 前往活动x = 0, 前往活动y = 0;
                        dm.FindStrFast(599, 407, 721, 438, "前往活动", "90857B-444541", 0.8, out 前往活动x, out 前往活动y);
                        if (前往活动x > 0)
                        {
                            dm.MoveToEx(前往活动x, 前往活动y, 30, 15);
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                            //等待副本结束
                            while (true)
                            {
                                ////召集队友
                                //dm.MoveTo(gameOperation.RandomNum(75, 105), gameOperation.RandomNum(300, 320));
                                //script.MainDelay(dm,1000);
                                //dm.LeftClick();
                                //script.MainDelay(dm,1000);
                                //离开副本
                                int 离开副本2x = 0, 离开副本2y = 0;
                                dm.FindStrFast(507, 306, 601, 339, "离开副本", "968C86-484E4B", 0.8, out 离开副本2x, out 离开副本2y);
                                if (离开副本2x > 0)
                                {
                                    ScriptData.退出勇创山寨 = true;
                                    break;
                                }
                                dm.delay(1000);
                                DateTime dtyongchuangshanzhai2 = DateTime.Now;
                                if ((dtyongchuangshanzhai2 - dtyongchuangshanzhai1).TotalMinutes > 8)
                                {
                                    ScriptData.退出勇创山寨 = true;
                                    break;
                                }
                            }
                        }
                        DateTime dtyongchuangshanzhai3 = DateTime.Now;
                        if ((dtyongchuangshanzhai3 - dtyongchuangshanzhai1).TotalMinutes > 8)
                        {
                            ScriptData.退出勇创山寨 = true;
                            break;
                        }
                    }
                }
                else
                {
                    //队友
                    dm.UseDict(3);
                    script.MainDelay(dm, 1000);
                    //确定
                    int 跳过动画xx = 0, 跳过动画yy = 0;
                    dm.FindStrFast(694, 424, 780, 459, "确定跳过动画", "978A77-424739", 0.8, out 跳过动画xx, out 跳过动画yy);
                    if (跳过动画xx > 0)
                    {
                        dm.MoveTo(跳过动画xx + gameOperation.RandomNum(0, 30), 跳过动画yy + gameOperation.RandomNum(0, 20));
                        script.MainDelay(dm, 1000);
                        dm.LeftClick();
                        script.MainDelay(dm, 1000);
                    }
                    int 确定x = 0, 确定y = 0;
                    dm.FindStrFast(694, 424, 780, 459, "确定", "978A77-424739", 0.8, out 确定x, out 确定y);
                    if (确定x > 0)
                    {
                        dm.MoveTo(确定x + gameOperation.RandomNum(0, 30), 确定y + gameOperation.RandomNum(0, 20));
                        script.MainDelay(dm, 1000);
                        dm.LeftClick();
                        script.MainDelay(dm, 1000);
                    }
                    //接受副本
                    int 接受x = 0, 接受y = 0;
                    dm.FindStrFast(516, 449, 589, 476, "接受", "95877A-484C41", 0.8, out 接受x, out 接受y);
                    if (接受x > 0)
                    {
                        dm.MoveToEx(接受x, 接受y, 10, 10);
                        script.MainDelay(dm, 1000);
                        dm.LeftClick();
                        script.MainDelay(dm, 1000);
                    }
                }
            }
        }
    }
}
