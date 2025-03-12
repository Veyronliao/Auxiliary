using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace senke
{
    /// <summary>
    /// 添加好友组队
    /// </summary>
    public class TeamUp
    {
        public GameOperation gameOperation { get; set; }
        public UserItem user { get; set; }
        public dmsoft dm { get; set; }
        public Script script { get; set; }
        public TeamUp(dmsoft dm, UserItem user, Script script)
        {
            gameOperation = new GameOperation(dm);
            this.user = user;
            this.dm = dm;
            this.script = script;
        }


        public void DoWork()
        {
            //组队
            dm.KeyPress(27);
            //script.MainDelay(dm,1000);
            //再玩会
            //dm.MoveTo(gameOperation.RandomNum(495, 620), gameOperation.RandomNum(385, 410));
            dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
            script.MainDelay(dm,1000);
            dm.LeftClick();
            script.MainDelay(dm,1000);
            dm.KeyPress(27);
            //script.MainDelay(dm,1000);
            //dm.MoveTo(gameOperation.RandomNum(495, 620), gameOperation.RandomNum(385, 410));
            dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
            script.MainDelay(dm,1000);
            dm.LeftClick();
            script.MainDelay(dm,1000);
            while (true)
            {
                dm.UseDict(3);
                script.MainDelay(dm,1000);
                //判断任务是否完成
                if (DmSoft.ScriptData.组队完成)
                {
                    break;
                }
                dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
                dm.LeftClick();
                script.MainDelay(dm,1000);
                if (user.isCaptain)
                {
                    dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
                    dm.LeftClick();
                    script.MainDelay(dm,1000);
                    //点击组队标志
                    dm.MoveTo(gameOperation.RandomNum(4, 23), gameOperation.RandomNum(190, 205));
                    script.MainDelay(dm,1000);
                    dm.LeftClick();
                    script.MainDelay(dm,1000);
                    //查找“创建队伍”
                    dm.MoveTo(gameOperation.RandomNum(65, 180), gameOperation.RandomNum(85, 105));
                    script.MainDelay(dm,1000);
                    dm.LeftClick();
                    script.MainDelay(dm,1000);
                    //队长标志
                    int 队长标志x = 0, 队长标志y = 0;
                    dm.FindPic(105, 163, 154, 205, "\\img\\组队队长标志.bmp", "000000", 0.8, 0, out 队长标志x, out 队长标志y);
                    if (队长标志x > 0)
                    {
                        while (true)
                        {
                            //拒绝
                            //int 拒绝1x = 0, 拒绝1y = 0;
                            //dm.FindStrFast(810, 596, 884, 630, "拒绝", "635F50-645F51", 0.8, out 拒绝1x, out 拒绝1y);
                            //if (拒绝1x > 0)
                            //{
                            //    dm.MoveToEx(拒绝1x, 拒绝1y, 30, 20);
                            //    script.MainDelay(dm,1000);
                            //    dm.LeftClick();
                            //    script.MainDelay(dm,1000);
                            //}
                            //加号
                            int 加号x = 0, 加号y = 0;
                            dm.FindPic(191, 207, 838, 275, "\\img\\邀请加号.bmp", "000000", 0.9, 0, out 加号x, out 加号y);
                            if (加号x > 0)
                            {
                                dm.MoveToEx(加号x, 加号y, 20, 20);
                                script.MainDelay(dm,1000);
                                dm.LeftClick();
                                script.MainDelay(dm,1000);
                            }
                            //邀请好友
                            int 邀请x = 0, 邀请y = 0;
                            dm.FindStrFast(648, 203, 718, 231, "邀请", "95877F-3F433F", 0.9, out 邀请x, out 邀请y);
                            if (邀请x > 0)
                            {
                                dm.MoveToEx(邀请x, 邀请y, 20, 15);
                                script.MainDelay(dm,1000);
                                dm.LeftClick();
                                script.MainDelay(dm,1000);
                            }
                            //关闭好友列表
                            dm.MoveTo(gameOperation.RandomNum(760, 780), gameOperation.RandomNum(97, 117));
                            script.MainDelay(dm,1000);
                            dm.LeftClick();
                            dm.delay(2000);
                            int 组队完成标志x = 0, 组队完成标志y = 0;
                            dm.FindPic(729, 410, 788, 453, "\\img\\组队完成标志.bmp", "000000", 0.8, 0, out 组队完成标志x, out 组队完成标志y);
                            if (组队完成标志x > 0)
                            {
                                DmSoft.ScriptData.组队完成 = true;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    //队友
                    dm.UseDict(3);
                    script.MainDelay(dm,1000);
           
                    //同意
                    int 同意x = 0, 同意y = 0;
                    dm.FindStrFast(469, 298, 650, 395, "同意", "9F9280-4F5546", 0.8, out 同意x, out 同意y);
                    if (同意x > 0)
                    {
                        //关闭弹窗
                        dm.MoveTo(同意x + gameOperation.RandomNum(0, 30), 同意y + gameOperation.RandomNum(0, 20));
                        script.MainDelay(dm,1000);
                        dm.LeftClick();
                        script.MainDelay(dm,1000);
                        //跟随队长
                        dm.MoveTo(gameOperation.RandomNum(70, 105), gameOperation.RandomNum(295, 320));
                        script.MainDelay(dm,1000);
                        dm.LeftClick();
                        script.MainDelay(dm,1000);
                    }
                    ////确定
                    //int 跳过动画xx = 0, 跳过动画yy = 0;
                    //dm.FindStrFast(694, 424, 780, 459, "确定跳过动画", "978A77-424739", 0.8, out 跳过动画xx, out 跳过动画yy);
                    //if (跳过动画xx > 0)
                    //{
                    //    dm.MoveTo(跳过动画xx + gameOperation.RandomNum(0, 30), 跳过动画yy + gameOperation.RandomNum(0, 20));
                    //    script.MainDelay(dm,1000);
                    //    dm.LeftClick();
                    //    script.MainDelay(dm,1000);
                    //}
                    //int 确定x = 0, 确定y = 0;
                    //dm.FindStrFast(694, 424, 780, 459, "确定", "978A77-424739", 0.8, out 确定x, out 确定y);
                    //if (确定x > 0)
                    //{
                    //    dm.MoveTo(确定x + gameOperation.RandomNum(0, 30), 确定y + gameOperation.RandomNum(0, 20));
                    //    script.MainDelay(dm,1000);
                    //    dm.LeftClick();
                    //    script.MainDelay(dm,1000);
                    //} 
                }
            }
        }
    }
}
