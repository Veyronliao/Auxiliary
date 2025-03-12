using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace senke
{
    /// <summary>
    /// 问剑侠义
    /// </summary>
    public class WenJianXiaYi
    {
        public GameOperation gameOperation { get; set; }
        public UserItem user { get; set; }
        public dmsoft dm { get; set; }
        public Script script { get; set; }
        public WenJianXiaYi(dmsoft dm, UserItem user, Script script)
        {
            gameOperation = new GameOperation(dm);
            this.user = user;
            this.dm = dm;
            this.script = script;
        }
        public void DoWork() 
        {
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
            while (true)
            {
                dm.UseDict(3);
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
                //问剑侠义
                int 问剑侠义x = 0, 问剑侠义y = 0;
                dm.FindStrFast(102, 53, 846, 449, "问剑侠义", "826E5C-373224", 0.8, out 问剑侠义x, out 问剑侠义y);
                if (问剑侠义x > 0)
                {
                    dm.MoveToEx(问剑侠义x, 问剑侠义y, 50, 20);
                    script.MainDelay(dm,1000);
                    dm.LeftClick();
                    script.MainDelay(dm,1000);
                }
                //前往活动
                int 前往活动x = 0, 前往活动y = 0;
                dm.FindStrFast(609, 408, 713, 438, "前往活动", "90857B-444541", 0.8, out 前往活动x, out 前往活动y);
                if (前往活动x > 0)
                {
                    dm.MoveToEx(前往活动x, 前往活动y, 10, 10);
                    script.MainDelay(dm,1000);
                    dm.LeftClick();
                    script.MainDelay(dm,1000);
                    //扫荡
                    dm.MoveTo(gameOperation.RandomNum(805, 880), gameOperation.RandomNum(425, 450));
                    dm.LeftClick();
                    script.MainDelay(dm,1000);
                    dm.MoveTo(gameOperation.RandomNum(665, 675), gameOperation.RandomNum(45, 65));
                    dm.LeftClick();
                    script.MainDelay(dm,1000);
                }
                int 关闭x = 0, 关闭y = 0;
                dm.FindPic(863, 47, 929, 97, "\\img\\guanbi.bmp", "000000", 0.8, 0, out 关闭x, out 关闭y);
                if (关闭x > 0)
                {
                    dm.MoveToEx(关闭x, 关闭y, 10, 10);
                    script.MainDelay(dm,1000);
                    dm.LeftClick();
                    script.MainDelay(dm,1000);
                }
                //挑战
                int 挑战x = 0, 挑战y = 0;
                dm.FindStrFast(204, 420, 771, 492, "挑战", "CE8554-1A3932", 0.8, out 挑战x, out 挑战y);
                if (挑战x > 0)
                {
                    dm.MoveToEx(挑战x, 挑战y, 10, 10);
                    script.MainDelay(dm,1000);
                    dm.LeftClick();
                    script.MainDelay(dm,1000);
                    break;
                }
            }
            DateTime dt= DateTime.Now;
            while (true)
            {
                //我的功力(红色字体表示战力不足，退出任务)
                int 我的功力x = 0, 我的功力y = 0;
                dm.FindStrFast(653, 536, 926, 683, "我的功力", "CD2A2C-322B2D", 0.8, out 我的功力x, out 我的功力y);
                if (我的功力x > 0) 
                {
                    dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
                    dm.LeftClick();
                    script.MainDelay(dm,1000);
                    break;
                }   
                dm.delay(2000);
                DateTime dt2 = DateTime.Now;
                if ((dt2-dt).TotalMinutes>=8)
                {
                    break;
                }
                int 挑战x = 0, 挑战y = 0;
                dm.FindStrFast(722, 425, 919, 477, "挑战", "9a8d89-4B5150", 0.8, out 挑战x, out 挑战y);
                if (挑战x > 0)
                {
                    dm.MoveTo(挑战x + gameOperation.RandomNum(0, 30), 挑战y + gameOperation.RandomNum(0, 20));
                    script.MainDelay(dm,1000);
                    dm.LeftClick();
                    script.MainDelay(dm,1000);
                }
                //离开副本
                int 离开副本x = 0, 离开副本y = 0;
                dm.FindStrFast(508, 404, 602, 431, "离开副本", "968C86-484E4B", 0.8, out 离开副本x, out 离开副本y);
                if (离开副本x > 0)
                {
                    dm.MoveTo(离开副本x + gameOperation.RandomNum(0, 20), 离开副本y + gameOperation.RandomNum(0, 10));
                    dm.LeftClick();
                    dm.delay(user.Delays);
                    break;
                }
            }
        }

    }
}
