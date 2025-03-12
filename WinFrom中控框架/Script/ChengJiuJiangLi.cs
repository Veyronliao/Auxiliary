using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senke
{
    /// <summary>
    /// 成就奖励
    /// </summary>
    public class ChengJiuJiangLi
    {
        public GameOperation gameOperation { get; set; }
        public UserItem user { get; set; }
        public dmsoft dm { get; set; }
        public Script script { get; set; }
        public ChengJiuJiangLi(dmsoft dm, UserItem user,Script script)
        {
            gameOperation = new GameOperation(dm);
            this.user = user;
            this.dm = dm;
            this.script = script;
        }
        public void DoWork()
        {
            int 成就查找次数 = 0;
            while (true)
            {
                if (成就查找次数>=3)
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
                int 成就x = 0, 成就y = 0;
                dm.FindPic(910, 424, 945, 458, "\\img\\成就奖励点击标志.bmp", "000000", 0.8, 0, out 成就x, out 成就y);
                if (成就x > 0)
                {
                    dm.MoveToEx(成就x, 成就y, -10, 10);
                    script.MainDelay(dm,1000);
                    dm.LeftClick();
                    dm.delay(2000);
                }
                else
                {
                    成就查找次数++;
                    script.MainDelay(dm,1000);
                    continue;
                }
                //成就面板
                int 成就面板x = 0, 成就面板y = 0;
                dm.FindPic(201, 48, 236, 81, "\\img\\成就奖励面板标志.bmp", "000000", 0.8, 0, out 成就面板x, out 成就面板y);
                if (成就面板x > 0)
                {
                    int 左侧查找失败次数 = 0;
                    while (true)
                    {
                        if (左侧查找失败次数>10)
                        {
                            break;
                        }
                        //左侧可点击的
                        int 左侧可点击的x = 0, 左侧可点击的y = 0;
                        dm.FindPic(276, 89, 305, 466, "\\img\\点击标志.bmp", "000000", 0.8, 1, out 左侧可点击的x, out 左侧可点击的y);
                        if (左侧可点击的x > 0)
                        {
                            dm.MoveTo(左侧可点击的x, 左侧可点击的y);
                            script.MainDelay(dm,1000);
                            dm.LeftClick();
                            script.MainDelay(dm,1000);
                            int 查找失败次数 = 0;
                            while (true)
                            {
                                if (查找失败次数 > 5)
                                {
                                    break;
                                }
                                //右侧可点击的领取
                                int 领取x = 0, 领取y = 0;
                                dm.FindStrFast(715, 86, 805, 388, "领取", "9C8C75-3F4232", 0.8, out 领取x, out 领取y);
                                if (领取x > 0)
                                {
                                    dm.MoveToEx(领取x, 领取y, 10, 10);
                                    script.MainDelay(dm,1000);
                                    dm.LeftClick();
                                    script.MainDelay(dm,1000);
                                    //按f键使用
                                    dm.KeyPress(70);
                                    dm.delay(500);
                                }
                                else
                                {
                                    查找失败次数++;
                                    script.MainDelay(dm,1000);
                                }
                            }
                        }
                        else
                        {
                            左侧查找失败次数++;
                            script.MainDelay(dm,1000);
                        }
                    }
                }
            }
        }
    }
}
