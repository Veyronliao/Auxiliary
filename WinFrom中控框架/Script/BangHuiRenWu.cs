using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senke
{
    /// <summary>
    /// 帮会任务
    /// </summary>
    public class BangHuiRenWu
    {
        public GameOperation gameOperation { get; set; }
        public UserItem user { get; set; }
        public dmsoft dm { get; set; }
        public Script script { get; set; }
        public BangHuiRenWu(dmsoft dm, UserItem user, Script script)
        {
            gameOperation = new GameOperation(dm);
            this.user = user;
            this.dm = dm;
            this.script = script;
        }
        public void DoWork()
        {
            int count = 0;
            DateTime time1 = DateTime.Now;
            while (true)
            {
                dm.UseDict(3);
                script.MainDelay(dm,1000);
                if (count>=5)
                {
                    break;
                }
                script.MainDelay(dm, 1000);
                dm.KeyPress(27);
                script.MainDelay(dm, 1000);
                //点击再玩会
                dm.MoveTo(gameOperation.RandomNum(495, 620), gameOperation.RandomNum(385, 410));
                script.MainDelay(dm,1000);
                dm.LeftClick();
                script.MainDelay(dm,1000);
                dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
                dm.LeftClick();
                script.MainDelay(dm,1000);
                //点击活动
                int 活动x = 0, 活动y = 0;
                dm.FindPic(769, 82, 806, 121, "\\img\\活动.bmp", "000000", 0.9, 0, out 活动x, out 活动y);
                if (活动x > 0)
                {
                    dm.MoveToEx(活动x, 活动y, 10, 10);
                    script.MainDelay(dm,1000);
                    dm.LeftClick();
                    script.MainDelay(dm,1000);
                }
                //帮会任务
                int 帮会任务x = 0, 帮会任务y = 0;
                dm.FindStrFast(110, 62, 835, 443, "帮会任务", "958475-4B4B3F", 0.8, out 帮会任务x, out 帮会任务y);
                if (帮会任务x > 0)
                {
                    dm.MoveToEx(帮会任务x, 帮会任务y, 30, 20);
                    script.MainDelay(dm,1000);
                    dm.LeftClick();
                    script.MainDelay(dm,1000);
                    int 前往活动x = 0, 前往活动y = 0;
                    dm.FindStrFast(545, 410, 639, 437, "前往活动", "90857B-444541", 0.8, out 前往活动x, out 前往活动y);
                    if (前往活动x > 0) 
                    {
                        dm.MoveToEx(前往活动x, 前往活动y, 30, 15);
                        script.MainDelay(dm,1000);
                        dm.LeftClick();
                        dm.delay(1000);
                        while (true)
                        {
                            dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                            DateTime time3= DateTime.Now;
                            if ((time3 - time1).TotalMinutes >= 8)
                            {
                                break;
                            }
                            script.MainDelay(dm, 3000);
                        }       
                    }
                }
                else
                {
                    count++;
                    script.MainDelay(dm,1000);
                    continue;
                }
                DateTime time2 = DateTime.Now;
                if ((time2 - time1).TotalMinutes >= 8)
                {
                    break;
                }
            }
        }
    }
}
