using senke.DmSoft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace senke
{
    /// <summary>
    /// 珍珑棋局
    /// </summary>
    public class ZhenLongQiJun
    {
        public GameOperation gameOperation { get; set; }
        public UserItem user { get; set; }
        public dmsoft dm { get; set; }
        public Script script { get; set; }
        public ZhenLongQiJun(dmsoft dm, UserItem user, Script script)
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
                if (ScriptData.退出组队任务)
                {
                    break;
                }
                dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
                dm.LeftClick();
                script.MainDelay(dm, 1000);
                if (ScriptData.退出珍珑棋局)
                {
                    break;
                }
                if (user.isCaptain)
                {
                    dm.UseDict(3);
                    script.MainDelay(dm, 1000);
                    //珍珑棋局
                    int 珍珑棋局 = 0;
                    DateTime dtzhenlongqiju1 = DateTime.Now;
                    while (true)
                    {
                        if (珍珑棋局 > 10)
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
                        int 珍珑棋局x = 0, 珍珑棋局y = 0;
                        dm.FindStrFast(100, 54, 847, 449, "珍珑棋局", "95877A-484C41", 0.8, out 珍珑棋局x, out 珍珑棋局y);
                        //dm.FindPic(603,409,721,439, "\\img\\珍珑棋局.bmp", "000000", 0.9, 0, out 珍珑棋局x, out 珍珑棋局y);
                        if (珍珑棋局x > 0)
                        {
                            dm.MoveToEx(珍珑棋局x, 珍珑棋局y, 50, 20);
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                        }
                        else
                        {
                            珍珑棋局++;
                            script.MainDelay(dm, 1000);
                        }

                        int 前往活动2x = 0, 前往活动2y = 0;
                        dm.FindStrFast(603, 409, 721, 439, "前往活动", "90857B-444541", 0.8, out 前往活动2x, out 前往活动2y);
                        if (前往活动2x > 0)
                        {
                            dm.MoveToEx(前往活动2x, 前往活动2y, 30, 20);
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
                                    ScriptData.退出珍珑棋局 = true;
                                    break;
                                }
                                DateTime dtzhenlongqiju2 = DateTime.Now;
                                if ((dtzhenlongqiju2 - dtzhenlongqiju1).TotalMinutes > 8)
                                {
                                    ScriptData.退出珍珑棋局 = true;
                                    break;
                                }
                                dm.delay(1000);
                            }
                        }
                        DateTime dtzhenlongqiju3 = DateTime.Now;
                        if ((dtzhenlongqiju3 - dtzhenlongqiju1).TotalMinutes > 6)
                        {
                            ScriptData.退出珍珑棋局 = true;
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
