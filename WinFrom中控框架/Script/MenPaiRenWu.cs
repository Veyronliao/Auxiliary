using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senke
{
    /// <summary>
    /// 门派任务
    /// </summary>
    public class MenPaiRenWu
    {
        public GameOperation gameOperation { get; set; }
        public UserItem user { get; set; }
        public dmsoft dm { get; set; }

        public Script script { get; set; }
        public MenPaiRenWu(dmsoft dm, UserItem user, Script script)
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
                if (count >= 5)
                {
                    break;
                }
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
                //门派任务
                int 门派任务x = 0, 门派任务y = 0;
                dm.FindStrFast(107, 60, 842, 444, "门派任务", "827261-39392B", 0.8, out 门派任务x, out 门派任务y);
                if (门派任务x > 0)
                {
                    dm.MoveToEx(门派任务x, 门派任务y, 30, 20);
                    script.MainDelay(dm,1000);
                    dm.LeftClick();
                    script.MainDelay(dm,1000);
                    int 前往活动x = 0, 前往活动y = 0;
                    dm.FindStrFast(537, 409, 646, 439, "前往活动", "90857B-444541", 0.8, out 前往活动x, out 前往活动y);
                    if (前往活动x > 0)
                    {
                        dm.MoveToEx(前往活动x, 前往活动y, 30, 20);
                        script.MainDelay(dm,1000);
                        dm.LeftClick();
                        script.MainDelay(dm, 1000);//挂起1分钟
                        while (true)
                        {
                            int 门派任务1x = 0, 门派任务1y = 0;
                            dm.FindStrFast(775, 440, 871, 467, "门派任务1", "F0D0BE-0E2F34", 0.8, out 门派任务1x, out 门派任务1y);
                            if (门派任务1x>0)
                            {
                                dm.MoveToEx(门派任务1x, 门派任务1y,20, 10);
                                script.MainDelay(dm, 1000);
                                dm.LeftClick();
                                script.MainDelay(dm, 1000);
                            }
                            dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                            DateTime time3 = DateTime.Now;
                            if ((time3 - time1).TotalMinutes >= 6)
                            {
                                break;
                            }
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
                if ((time2 - time1).TotalMinutes >= 6)
                {
                    break;
                }
            }
        }
    }
}
