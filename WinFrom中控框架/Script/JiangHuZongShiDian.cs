using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senke
{
    /// <summary>
    /// 江湖宗师殿
    /// </summary>
    public class JiangHuZongShiDian
    {
        public GameOperation gameOperation { get; set; }
        public UserItem user { get; set; }
        public dmsoft dm { get; set; }
        public Script script { get; set; }
        public JiangHuZongShiDian(dmsoft dm, UserItem user, Script script)
        {
            gameOperation = new GameOperation(dm);
            this.user = user;
            this.dm = dm;
            this.script = script;
        }
        public void DoWork() 
        {
            int count = 0;
            int 挑战次数 = 0;
            while (true)
            {
                dm.UseDict(3);
                script.MainDelay(dm, 1000);
                if (count >= 5)
                {
                    break;
                }
                script.MainDelay(dm, 1000);
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
                dm.FindPic(769, 82, 806, 121, "\\img\\活动.bmp", "000000", 0.9, 0, out 活动x, out 活动y);
                if (活动x > 0)
                {
                    dm.MoveToEx(活动x, 活动y, 10, 10);
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                }
                //帮会任务
                int 宗师殿堂x = 0, 宗师殿堂y = 0;
                dm.FindStrFast(109, 62, 834, 442, "宗师", "C9C6C5-36393A", 0.8, out 宗师殿堂x, out 宗师殿堂y);
                if (宗师殿堂x > 0)
                {
                    dm.MoveToEx(宗师殿堂x, 宗师殿堂y, 30, 20);
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 2000);
                    int 前往活动x = 0, 前往活动y = 0;
                    dm.FindStrFast(614, 409, 711, 436, "前往活动", "90857B-444541", 0.8, out 前往活动x, out 前往活动y);
                    if (前往活动x > 0)
                    {
                        dm.MoveToEx(前往活动x, 前往活动y, 30, 20);
                        script.MainDelay(dm, 1000);
                        dm.LeftClick();
                        script.MainDelay(dm, 1000);
                        
                        while (true)
                        {
                            //挑战
                            int 挑战x = 0, 挑战y = 0;
                            dm.FindPic(812, 437, 876, 495, "\\img\\宗师挑战.bmp", "000000", 0.8, 0, out 挑战x, out 挑战y);
                            if (挑战x>0)
                            {
                                dm.MoveToEx(挑战x, 挑战y, 0, 0);
                                script.MainDelay(dm, 1000);
                                dm.LeftClick();
                                script.MainDelay(dm, 1000);
                                挑战次数 += 1;
                            }
                            //继续挑战
                            int 继续挑战x = 0, 继续挑战y = 0;
                            dm.FindStrFast(497, 467, 600, 501, "继续挑战", "948170-454536", 0.8, out 继续挑战x, out 继续挑战y);
                            if (继续挑战x > 0)
                            {
                                dm.MoveToEx(继续挑战x, 继续挑战y, 20, 10);
                                script.MainDelay(dm, 1000);
                                dm.LeftClick();
                                script.MainDelay(dm, 1000);
                            }
                            //已用尽
                            int 已用尽x = 0, 已用尽y = 0;
                            dm.FindStrFast(495, 211, 568, 251, "已用尽", "C7A36D-13264C", 0.8, out 已用尽x, out 已用尽y);
                            if (已用尽x > 0)
                            {
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
                                break;
                            }
                        }
                    }
                }
                else
                {
                    count++;
                    script.MainDelay(dm, 1000);
                    continue;
                }
                if (挑战次数 >= 5)
                {
                    break;
                }
            }
        }
    }
}
