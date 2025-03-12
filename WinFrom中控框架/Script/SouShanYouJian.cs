using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senke
{
    /// <summary>
    /// 收删邮件
    /// </summary>
    public class SouShanYouJian
    {
        public GameOperation gameOperation { get; set; }
        public UserItem user { get; set; }
        public dmsoft dm { get; set; }
        public Script script { get; set; }
        public SouShanYouJian(dmsoft dm, UserItem user, Script script)
        {
            gameOperation = new GameOperation(dm);
            this.user = user;
            this.dm = dm;
            this.script = script;
        }
        public void DoWork() 
        {
            dm.UseDict(3);
            script.MainDelay(dm,1000);
            for (int i = 0; i < 3; i++)
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
                //点击邮件入口
                dm.MoveTo(gameOperation.RandomNum(285, 310), gameOperation.RandomNum(500, 525));
                dm.LeftClick();
                script.MainDelay(dm,1000);
                //点击信函
                dm.MoveTo(gameOperation.RandomNum(905, 930), gameOperation.RandomNum(145, 165));
                dm.LeftClick();
                script.MainDelay(dm,1000);
                //一键阅读并领取
                dm.MoveTo(gameOperation.RandomNum(180, 305), gameOperation.RandomNum(490, 515));
                dm.LeftClick();
                dm.delay(3000);
                //一键删除
                dm.MoveTo(gameOperation.RandomNum(60, 135), gameOperation.RandomNum(490, 515));
                dm.LeftClick();
                dm.delay(3000);
                //确定删除
                dm.MoveTo(gameOperation.RandomNum(505, 595), gameOperation.RandomNum(320, 340));
                dm.LeftClick();
                dm.delay(3000);
            }
        }
    }
}
