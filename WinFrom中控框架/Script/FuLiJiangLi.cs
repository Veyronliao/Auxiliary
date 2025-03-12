using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senke
{
    //福利奖励
    public class FuLiJiangLi
    {
        public GameOperation gameOperation { get; set; }
        public UserItem user { get; set; }
        public dmsoft dm { get; set; }
        public Script script { get; set; }
        public FuLiJiangLi(dmsoft dm, UserItem user, Script script)
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
            for (int i = 0; i < 2; i++)
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
                //江湖首礼
                dm.MoveTo(gameOperation.RandomNum(320, 390), gameOperation.RandomNum(435, 460));
                dm.LeftClick();
                script.MainDelay(dm,1000);
                dm.MoveTo(gameOperation.RandomNum(420, 500), gameOperation.RandomNum(435, 460));
                dm.LeftClick();
                script.MainDelay(dm,1000);
                dm.MoveTo(gameOperation.RandomNum(525, 605), gameOperation.RandomNum(435, 460));
                dm.LeftClick();
                script.MainDelay(dm,1000);
                dm.MoveTo(gameOperation.RandomNum(630, 705), gameOperation.RandomNum(435, 460));
                dm.LeftClick();
                script.MainDelay(dm,1000);
                dm.MoveTo(gameOperation.RandomNum(740, 810), gameOperation.RandomNum(435, 460));
                dm.LeftClick();
                script.MainDelay(dm,1000);
                dm.MoveTo(gameOperation.RandomNum(845, 915), gameOperation.RandomNum(435, 460));
                dm.LeftClick();
                script.MainDelay(dm,1000);
                //在线奖励
                dm.MoveTo(gameOperation.RandomNum(60, 170), gameOperation.RandomNum(155, 180));
                dm.LeftClick();
                script.MainDelay(dm,1000);
                dm.MoveTo(gameOperation.RandomNum(635, 708), gameOperation.RandomNum(80, 100));
                dm.LeftClick();
                script.MainDelay(dm,1000);
                dm.MoveTo(gameOperation.RandomNum(635, 708), gameOperation.RandomNum(175, 195));
                dm.LeftClick();
                script.MainDelay(dm,1000);
                dm.MoveTo(gameOperation.RandomNum(635, 708), gameOperation.RandomNum(270, 290));
                dm.LeftClick();
                script.MainDelay(dm,1000);
                dm.MoveTo(gameOperation.RandomNum(635, 708), gameOperation.RandomNum(370, 390));
                dm.LeftClick();
                script.MainDelay(dm,1000);
                dm.MoveTo(gameOperation.RandomNum(635, 708), gameOperation.RandomNum(465, 480));
                dm.LeftClick();
                script.MainDelay(dm,1000);
                //升级礼包
                dm.MoveTo(gameOperation.RandomNum(60, 175), gameOperation.RandomNum(245, 275));
                dm.LeftClick();
                script.MainDelay(dm,1000);
                dm.MoveTo(gameOperation.RandomNum(640, 710), gameOperation.RandomNum(90, 110));
                dm.LeftClick();
                script.MainDelay(dm,1000);
                dm.MoveTo(gameOperation.RandomNum(640, 710), gameOperation.RandomNum(200, 220));
                dm.LeftClick();
                script.MainDelay(dm,1000);
                dm.MoveTo(gameOperation.RandomNum(640, 710), gameOperation.RandomNum(305, 325));
                dm.LeftClick();
                script.MainDelay(dm,1000);
                dm.MoveTo(gameOperation.RandomNum(640, 710), gameOperation.RandomNum(410, 435));
                dm.LeftClick();
                script.MainDelay(dm,1000);
            }
            //每日特惠
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
            //每日特惠
            dm.MoveTo(gameOperation.RandomNum(610, 635), gameOperation.RandomNum(20, 45));
            dm.LeftClick();
            dm.delay(2000);
            //每日限购
            dm.MoveTo(gameOperation.RandomNum(50, 160), gameOperation.RandomNum(105, 130));
            dm.LeftClick();
            script.MainDelay(dm,1000);
            //领取
            dm.MoveTo(gameOperation.RandomNum(250, 355), gameOperation.RandomNum(325, 350));
            dm.LeftClick();
            script.MainDelay(dm,1000);
            //免费领取
            dm.MoveTo(gameOperation.RandomNum(340, 440), gameOperation.RandomNum(440, 460));
            dm.LeftClick();
            script.MainDelay(dm,1000);
            //江山绘卷
            dm.MoveTo(gameOperation.RandomNum(55, 155), gameOperation.RandomNum(270, 290));
            dm.LeftClick();
            dm.delay(2000);
            //领取
            dm.MoveTo(gameOperation.RandomNum(845, 910), gameOperation.RandomNum(380, 400));
            dm.LeftClick();
            dm.delay(2000);
        }
    }
}
