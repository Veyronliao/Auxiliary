using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace senke
{
    /// <summary>
    /// 添加好友
    /// </summary>
    public  class AddFrends
    {
        public GameOperation gameOperation { get; set; }
        public UserItem user { get; set; }
        public Script script { get; set; }
        public dmsoft dm { get; set; }
        public AddFrends(dmsoft dm, UserItem user, Script script)
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
            dm.KeyPress(27);
            script.MainDelay(dm,1000);
            dm.MoveTo(gameOperation.RandomNum(495, 620), gameOperation.RandomNum(385, 410));
            script.MainDelay(dm,1000);
            dm.LeftClick();
            script.MainDelay(dm,1000);
            //添加好友,执行三次
            for (int j = 0; j < 2; j++)
            {
                dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
                script.MainDelay(dm,1000);
                dm.LeftClick();
                script.MainDelay(dm,1000);
                dm.MoveTo(gameOperation.RandomNum(285, 310), gameOperation.RandomNum(500, 520));
                script.MainDelay(dm,1000);
                dm.LeftClick();
                script.MainDelay(dm,1000);
                //点击好友
                dm.MoveTo(gameOperation.RandomNum(905, 930), gameOperation.RandomNum(65, 90));
                script.MainDelay(dm,1000);
                dm.LeftClick();
                script.MainDelay(dm,1000);
                //点击添加好友按钮
                dm.MoveTo(gameOperation.RandomNum(40, 130), gameOperation.RandomNum(485, 510));
                script.MainDelay(dm,1000);
                dm.LeftClick();
                script.MainDelay(dm,1000);
                //输入好友昵称
                int 输入好友昵称x = 0, 输入好友昵称y = 0;
                dm.FindStrFast(353, 410, 462, 434, "输入好友昵称", "8D8379-42433F", 0.8, out 输入好友昵称x, out 输入好友昵称y);
                if (输入好友昵称x > 0)
                {
                    for (int i = 0; i < user.FriendsList.Count; i++)
                    {
                        int count = 0;
                        while (true)
                        {
                            count++;
                            if (count >= 3)
                            {
                                break;
                            }
                            dm.MoveToEx(输入好友昵称x, 输入好友昵称y, 30, 15);
                            script.MainDelay(dm,1000);
                            dm.LeftClick();
                            script.MainDelay(dm,1000);
                            //全选
                            script.MainDelay(dm,1000);
                            dm.KeyDown(17);
                            dm.delay(100);
                            dm.KeyPress(65);
                            dm.KeyUp(17);
                            script.MainDelay(dm,1000);
                            dm.SendString(user.hwnd, user.FriendsList[i]);
                            script.MainDelay(dm,1000);
                            //点击搜索
                            script.MainDelay(dm,1000);
                            dm.MoveTo(gameOperation.RandomNum(650, 745), gameOperation.RandomNum(410, 435));
                            script.MainDelay(dm,1000);
                            dm.LeftClick();
                            script.MainDelay(dm,1000);
                            dm.LeftClick();
                            script.MainDelay(dm,1000);
                            int 添加x = 0, 添加y = 0;
                            dm.FindStrFast(664, 181, 747, 208, "添加", "998C6F-44493C", 0.8, out 添加x, out 添加y);
                            if (添加x > 0)
                            {
                                //点击添加按钮
                                dm.MoveTo(添加x + gameOperation.RandomNum(0, 20), 添加y + gameOperation.RandomNum(0, 10));
                                script.MainDelay(dm,1000);
                                dm.LeftClick();
                                script.MainDelay(dm,1000);
                                break;
                            }
                            dm.delay(2000);
                        }
                    }
                }
                dm.delay(60000);
                //关闭全部对话框
                dm.KeyPress(27);
                script.MainDelay(dm,1000);
                //再玩会
                dm.MoveTo(gameOperation.RandomNum(495, 620), gameOperation.RandomNum(385, 410));
                script.MainDelay(dm,1000);
                dm.LeftClick();
                script.MainDelay(dm,1000);
                dm.KeyPress(27);
                script.MainDelay(dm,1000);
                dm.MoveTo(gameOperation.RandomNum(495, 620), gameOperation.RandomNum(385, 410));
                script.MainDelay(dm,1000);
                dm.LeftClick();
                script.MainDelay(dm,1000);
                dm.MoveTo(gameOperation.RandomNum(285, 310), gameOperation.RandomNum(500, 520));
                script.MainDelay(dm,1000);
                dm.LeftClick();
                script.MainDelay(dm,1000);
                //点击好友
                dm.MoveTo(gameOperation.RandomNum(905, 930), gameOperation.RandomNum(65, 90));
                script.MainDelay(dm,1000);
                dm.LeftClick();
                script.MainDelay(dm,1000);
                //点击添加好友按钮
                dm.MoveTo(gameOperation.RandomNum(40, 130), gameOperation.RandomNum(485, 510));
                script.MainDelay(dm,1000);
                dm.LeftClick();
                script.MainDelay(dm,1000);
                //点击全部添加按钮
                dm.MoveTo(gameOperation.RandomNum(650, 740), gameOperation.RandomNum(410, 435));
                script.MainDelay(dm,1000);
                dm.LeftClick();
                script.MainDelay(dm,1000);
            }
        }
    }
}
