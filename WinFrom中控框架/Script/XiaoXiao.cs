using senke.DmSoft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senke
{
    /// <summary>
    /// 宵小
    /// </summary>
    public class XiaoXiao
    {
       
        public GameOperation gameOperation { get; set; }
        public UserItem user { get; set; }
        public dmsoft dm { get; set; }
        public Script script { get; set; }
        public XiaoXiao(dmsoft dm, UserItem user, Script script)
        {
            gameOperation = new GameOperation(dm);
            this.user = user;
            this.dm = dm;
            this.script = script;
        }
        public void DoWork()
        {
            dm.UseDict(3);
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
            DateTime dt = new DateTime();
            if (user.isCaptain)
            {
                int times = 0;
                //等待宵小开始
                while (true)
                {
                    dm.MoveTo(gameOperation.RandomNum(865, 950), gameOperation.RandomNum(150, 170));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                    //宵小
                    int 宵小x = 0, 宵小y = 0;
                    dm.FindStrFast(572, 138, 789, 339, "宵小", "BFA783-2D2820", 0.8, out 宵小x, out 宵小y);
                    if (宵小x > 0)
                    {
                        //快速传送
                        int 快速传送x = 0, 快速传送y = 0;
                        dm.FindStrFast(572, 137, 789, 368, "快速传送", "C1B0A9-303132", 0.8, out 快速传送x, out 快速传送y);
                        if (快速传送x>0)
                        {
                            dm.MoveTo(快速传送x+gameOperation.RandomNum(0, 30), 快速传送y+gameOperation.RandomNum(0, 20));
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                            dt = DateTime.Now;
                            break;
                        }
                    }
                }
                while (true)
                {
                    //交互
                    int 宵小交互x = 0, 宵小交互y = 0;
                    dm.FindPic(658, 273, 721, 328, "\\img\\宵小交互.bmp", "000000", 0.8, 0, out 宵小交互x, out 宵小交互y);
                    if (宵小交互x > 0)
                    {
                        dm.MoveTo(宵小交互x + gameOperation.RandomNum(0, 10), 宵小交互y + gameOperation.RandomNum(0, 10));
                        script.MainDelay(dm, 1000);
                        dm.LeftClick();
                        script.MainDelay(dm, 1000);
                    }
                    //击退宵小
                    int 击退宵小x = 0, 击退宵小y = 0;
                    dm.FindStrFast(775, 384, 871, 409, "击退宵小", "998981-464C47", 0.8, out 击退宵小x, out 击退宵小y);
                    if (击退宵小x > 0)
                    {
                        dm.MoveTo(击退宵小x + gameOperation.RandomNum(0, 20), 击退宵小y + gameOperation.RandomNum(0, 10));
                        script.MainDelay(dm, 1000);
                        dm.LeftClick();
                        script.MainDelay(dm, 1000);
                    }
                    //继续击退
                    int 继续击退x = 0, 继续击退y = 0;
                    dm.FindStrFast(566, 422, 681, 454, "继续击退", "958781-414844", 0.8, out 继续击退x, out 继续击退y);
                    if (继续击退x > 0)
                    {
                        dm.MoveTo(继续击退x + gameOperation.RandomNum(0, 20), 继续击退y + gameOperation.RandomNum(0, 10));
                        script.MainDelay(dm, 1000);
                        dm.LeftClick();
                        script.MainDelay(dm, 1000);
                    }
                    //退出副本
                    int 离开副本x = 0, 离开副本y = 0;
                    dm.FindStrFast(507, 306, 601, 339, "离开副本", "968C86-484E4B", 0.8, out 离开副本x, out 离开副本y);
                    if (离开副本x > 0)
                    {
                        dm.MoveTo(离开副本x + gameOperation.RandomNum(0, 20), 离开副本y + gameOperation.RandomNum(0, 10));
                        dm.LeftClick();
                        script.MainDelay(dm, 1000);
                        break;
                    }
                    DateTime dt1=DateTime.Now;
                    if ((dt1-dt).TotalMinutes>=30)
                    {
                        ScriptData.退出宵小 = true;
                        break;
                    }
                }
            }
            else
            {
                while (true)
                {
                    if (ScriptData.退出宵小)
                    {
                        break;
                    }
                    script.MainDelay(dm, 3000);
                }
            }
        }
    }
}
