using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senke
{
    //江湖记事
    public class JiShiJiangLi
    {
        public GameOperation gameOperation { get; set; }
        public UserItem user { get; set; }
        public dmsoft dm { get; set; }
        public Script script { get; set; }
        public JiShiJiangLi(dmsoft dm, UserItem user, Script script)
        {
            gameOperation = new GameOperation(dm);
            this.user = user;
            this.dm = dm;
            this.script = script;
        }
        public void DoWork() 
        {
            int 右侧点击次数 = 0;
            dm.UseDict(3);
            script.MainDelay(dm,1000);
            while (true)
            {
                if (右侧点击次数>=5)
                {
                    break;
                }
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
                int 江湖记事x = 0, 江湖记事y = 0;
                dm.FindPic(712, 71, 761, 116, "\\img\\江湖记事点击标志.bmp", "000000", 0.8, 0, out 江湖记事x, out 江湖记事y);
                if (江湖记事x>0)
                {
                    dm.MoveTo(江湖记事x, 江湖记事y);
                    dm.LeftClick();
                    script.MainDelay(dm,1000);
                    //
                    dm.MoveTo(gameOperation.RandomNum(70, 105),gameOperation.RandomNum(385, 420));
                    dm.LeftClick();
                    script.MainDelay(dm,1000);
                    //确定
                    dm.MoveTo(gameOperation.RandomNum(435, 525),gameOperation.RandomNum(360, 385));
                    script.MainDelay(dm,1000);
                    dm.LeftClick();
                    script.MainDelay(dm,1000);
                    //领取
                    int 可领取x = 0, 可领取y = 0;
                    dm.FindStrFast(313, 81, 858, 116, "可领取", "DCCBC8-233437", 0.8, out 可领取x, out 可领取y);
                    if (可领取x > 0)
                    {
                        dm.MoveTo(可领取x, 可领取y + gameOperation.RandomNum(5, 10));
                        script.MainDelay(dm, 1000);
                        dm.LeftClick();
                        script.MainDelay(dm, 1000);
                        int count = 0;
                        while (true)
                        {
                            if (count >= 5)
                            {
                                break;
                            }
                            int 领取x = 0, 领取y = 0;
                            dm.FindStrFast(713, 93, 841, 461, "领取", "968161-3F423B", 0.8, out 领取x, out 领取y);
                            if (领取x > 0)
                            {
                                dm.MoveToEx(领取x, 领取y, 20, -10);
                                script.MainDelay(dm, 1000);
                                dm.LeftClick();
                                script.MainDelay(dm, 1000);
                            }
                            else
                            {
                                count++;
                            }
                            script.MainDelay(dm, 1000);
                        }
                    }
                    else
                    {
                        右侧点击次数++;
                        script.MainDelay(dm,1000);
                    }
                }
            }
        }
    }
}
