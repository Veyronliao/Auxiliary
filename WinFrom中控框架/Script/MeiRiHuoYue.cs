using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senke
{
    /// <summary>
    /// 每日活跃
    /// </summary>
    public class MeiRiHuoYue
    {
        public GameOperation gameOperation { get; set; }
        public UserItem user { get; set; }
        public dmsoft dm { get; set; }
        public Script script { get; set; }
        public MeiRiHuoYue(dmsoft dm, UserItem user, Script script)
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
            for (int i = 0; i < 2; i++)
            {
                dm.MoveTo(gameOperation.RandomNum(395, 425), gameOperation.RandomNum(465, 495));
                script.MainDelay(dm,1000);
                dm.LeftClick();
                script.MainDelay(dm,1000);
                dm.MoveTo(gameOperation.RandomNum(475, 505), gameOperation.RandomNum(465, 495));
                script.MainDelay(dm,1000);
                dm.LeftClick();
                script.MainDelay(dm,1000);
                dm.MoveTo(gameOperation.RandomNum(555, 590), gameOperation.RandomNum(465, 495));
                script.MainDelay(dm,1000);
                dm.LeftClick();
                script.MainDelay(dm,1000);
                dm.MoveTo(gameOperation.RandomNum(640, 665), gameOperation.RandomNum(465, 495));
                script.MainDelay(dm,1000);
                dm.LeftClick();
                script.MainDelay(dm,1000);
                dm.MoveTo(gameOperation.RandomNum(720, 750), gameOperation.RandomNum(465, 495));
                script.MainDelay(dm,1000);
                dm.LeftClick();
                script.MainDelay(dm,1000);
            }
        }
    }
}
