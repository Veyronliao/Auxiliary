using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senke
{
    /// <summary>
    /// 绝学参悟
    /// </summary>
    public class JueXueCanWu
    {
        public GameOperation gameOperation { get; set; }
        public UserItem user { get; set; }
        public dmsoft dm { get; set; }
        public Script script { get; set; }
        public JueXueCanWu(dmsoft dm, UserItem user, Script script)
        {
            gameOperation = new GameOperation(dm);
            this.user = user;
            this.dm = dm;
            this.script = script;
        }
        public void DoWork()
        {
            int 成就查找次数 = 0;
            bool 退出 = false;
            while (true)
            {
                if (退出)
                {
                    break;
                }
                dm.UseDict(3);
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
                dm.MoveTo(gameOperation.RandomNum(910, 930), gameOperation.RandomNum(210, 230));
                dm.LeftClick();
                script.MainDelay(dm,1000);
                int 绝学x = 0, 绝学y = 0;
                dm.FindPic(851, 363, 889, 398, "\\img\\绝学.bmp", "000000", 0.8, 0, out 绝学x, out 绝学y);
                if (绝学x > 0)
                {
                    dm.MoveTo(绝学x, 绝学y);
                    script.MainDelay(dm,1000);
                    dm.LeftClick();
                    dm.delay(2000);
                    while (true)
                    {
                        dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
                        dm.LeftClick();
                        script.MainDelay(dm,1000);
                        int 前往获取x = 0, 前往获取y = 0;
                        dm.FindStrFast(630, 491, 720, 520, "前往获取", "A4896C-504A30", 0.8, out 前往获取x, out 前往获取y);
                        if (前往获取x > 0)
                        {
                            dm.MoveTo(前往获取x + gameOperation.RandomNum(0, 30), 前往获取y + gameOperation.RandomNum(0, 20));
                            script.MainDelay(dm,1000);
                            dm.LeftClick();
                            dm.delay(2000);
                        }
                        //参悟一次
                        int 参悟一次x = 0, 参悟一次y = 0;
                        dm.FindStrFast(271, 451, 364, 482, "参悟一次", "A3896B-514A31", 0.8, out 参悟一次x, out 参悟一次y);
                        if (参悟一次x > 0)
                        {
                            dm.MoveTo(参悟一次x + gameOperation.RandomNum(0, 30), 参悟一次y + gameOperation.RandomNum(0, 20));
                            script.MainDelay(dm,1000);
                            dm.LeftClick();
                            dm.delay(3000);
                        }
                        //取消
                        int 取消x = 0, 取消y = 0;
                        dm.FindStrFast(384, 319, 430, 342, "取消", "998C77-434A39", 0.8, out 取消x, out 取消y);
                        if (取消x > 0)
                        {
                            dm.MoveTo(取消x + gameOperation.RandomNum(0, 30), 取消y + gameOperation.RandomNum(0, 15));
                            script.MainDelay(dm,1000);
                            dm.LeftClick();
                            script.MainDelay(dm,3000);
                            退出 = true;
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
                            
                }
                else
                {
                    成就查找次数++;
                    script.MainDelay(dm,1000);
                    continue;
                }
            }
        }
    }
}
