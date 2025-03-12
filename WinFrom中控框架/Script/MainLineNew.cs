using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senke
{
    public class MainLineNew
    {
        public GameOperation gameOperation { get; set; }
        public UserItem user { get; set; }
        public dmsoft dm { get; set; }

        public Script script { get; set; }
        public MainLineNew(dmsoft dm, UserItem user, Script script)
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
            DateTime strartTime=DateTime.Now;
            while (true)
            {
                ////按下~
                dm.KeyPress(192);
                script.MainDelay(dm, 1000);
                //突破心境
                int 突破心境x = 0, 突破心境y = 0;
                dm.FindStrFast(859, 448, 917, 509, "突破心境", "ECD5C8-132A37", 0.8, out 突破心境x, out 突破心境y);
                if (突破心境x > 0)
                {
                    dm.MoveTo(突破心境x + gameOperation.RandomNum(5, 50), 突破心境y - gameOperation.RandomNum(5, 40));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                int 跳过剧情x = 0, 跳过剧情y = 0;
                dm.FindStrFast(826, 19, 909, 44, "跳过剧情", "E9DCC5-16233A", 0.8, out 跳过剧情x, out 跳过剧情y);
                if (跳过剧情x > 0)
                {
                    //按下m键
                    dm.KeyPress(77);
                    script.MainDelay(dm, 1000);
                    dm.MoveTo(gameOperation.RandomNum(505, 595), gameOperation.RandomNum(320, 340));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                }
                //引导自动关闭
                int 引导自动关闭x = 0, 引导自动关闭y = 0;
                dm.FindStrFast(327, 16, 708, 117, "引导自动关闭", "C1BAAD-3E3C38", 0.8, out 引导自动关闭x, out 引导自动关闭y);
                if (引导自动关闭x>0)
                {
                    DateTime dt= DateTime.Now;
                    while (true)
                    {
                        
                        dm.KeyPress(192);
                        script.MainDelay(dm, 2000);
                        //按下f键
                        dm.KeyPress(70);
                        script.MainDelay(dm, 200);
                        //按下c键
                        dm.KeyPress(67);
                        script.MainDelay(dm, 200);
                        //按下b键
                        dm.KeyPress(66);
                        script.MainDelay(dm, 200);
                        //按下1键
                        dm.KeyPress(49);
                        script.MainDelay(dm, 200);
                        //按下2键
                        dm.KeyPress(50);
                        script.MainDelay(dm, 200);
                        //按下3键
                        dm.KeyPress(51);
                        script.MainDelay(dm, 200);
                        //按下4键
                        dm.KeyPress(52);
                        script.MainDelay(dm, 200);
                        dm.KeyPress(66);
                        script.MainDelay(dm, 200);
                        dm.KeyPress(66);
                        script.MainDelay(dm, 200);
                        dm.KeyPress(66);
                        script.MainDelay(dm, 200);
                        dm.KeyPress(66);
                        script.MainDelay(dm, 200);
                        dm.KeyPress(67);
                        script.MainDelay(dm, 200);
                        //按下b键
                        dm.KeyPress(66);
                        script.MainDelay(dm, 200);
                        //按下1键
                        dm.KeyPress(49);
                        script.MainDelay(dm, 200);
                        //按下2键
                        dm.KeyPress(50);
                        script.MainDelay(dm, 200);
                        //按下3键
                        dm.KeyPress(51);
                        script.MainDelay(dm, 200);
                        //按下4键
                        dm.KeyPress(52);
                        script.MainDelay(dm, 200);
                        dm.KeyPress(66);
                        script.MainDelay(dm, 200);
                        dm.KeyPress(66);
                        script.MainDelay(dm, 200);
                        dm.KeyPress(66);
                        script.MainDelay(dm, 200);
                        dm.KeyPress(66);
                        script.MainDelay(dm, 200);
                        //手指轮转
                        int 手指轮转x = 0, 手指轮转y = 0;
                        dm.FindPic(182, 53, 218, 84, "\\img\\手指轮转图标.bmp", "000000", 0.8, 0, out 手指轮转x, out 手指轮转y);
                        if (手指轮转x > 0)
                        {
                            //转轮
                            dm.MoveTo(gameOperation.RandomNum(797, 806), gameOperation.RandomNum(355, 365));
                            script.MainDelay(dm, 1000);
                            dm.LeftDown();
                            script.MainDelay(dm, 1000);
                            dm.MoveTo(gameOperation.RandomNum(764, 772), gameOperation.RandomNum(410, 420));
                            script.MainDelay(dm, 1000);
                            dm.MoveTo(gameOperation.RandomNum(720, 730), gameOperation.RandomNum(444, 454));
                            script.MainDelay(dm, 1000);
                            dm.MoveTo(gameOperation.RandomNum(676, 686), gameOperation.RandomNum(456, 466));
                            script.MainDelay(dm, 1000);
                            dm.MoveTo(gameOperation.RandomNum(576, 586), gameOperation.RandomNum(450, 460));
                            script.MainDelay(dm, 1000);
                            dm.MoveTo(gameOperation.RandomNum(525, 535), gameOperation.RandomNum(414, 424));
                            script.MainDelay(dm, 1000);
                        }
                        // 五蕰皆空
                        //int 五蕰皆空_x = 0, 五蕰皆空_y = 0;
                        var finred = dm.FindMulColor(38, 89, 309, 148, "f3626e-232323|e15e67-222222|ed616b-202020", 0.8);
                        if (finred == 1)
                        {
                            dm.MoveTo(gameOperation.RandomNum(600, 640), gameOperation.RandomNum(315, 360));
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                            dm.MoveTo(gameOperation.RandomNum(608, 655), gameOperation.RandomNum(195, 235));
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                            dm.MoveTo(gameOperation.RandomNum(385, 425), gameOperation.RandomNum(140, 180));
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                            dm.MoveTo(gameOperation.RandomNum(265, 305), gameOperation.RandomNum(260, 300));
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                        }
                        DateTime dt2 = DateTime.Now;
                        if ((dt2 - dt).TotalMinutes >= 12)
                        {
                            break;
                        }
                        int 跳过剧情1x = 0, 跳过剧情1y = 0;
                        dm.FindStrFast(826, 19, 909, 44, "跳过剧情", "E9DCC5-16233A", 0.8, out 跳过剧情1x, out 跳过剧情1y);
                        if (跳过剧情1x > 0)
                        {
                            //按下m键
                            dm.KeyPress(77);
                            script.MainDelay(dm, 1000);
                            dm.MoveTo(gameOperation.RandomNum(505, 595), gameOperation.RandomNum(320, 340));
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                        }
                        ////开启自动战斗
                        //int 开启自动战斗x = 0, 开启自动战斗y = 0;
                        //dm.FindStrFast(362, 363, 475, 388, "开启自动战斗", "8D8279-41433F", 0.8, out 开启自动战斗x, out 开启自动战斗y);
                        //if (开启自动战斗x > 0)
                        //{
                        //    break;
                        //}
                    }
                }
               
                //点击轻功
                int 点击轻功x = 0, 点击轻功y = 0;
                dm.FindStrFast(608, 470, 685, 498, "点击轻功", "C3BBA5-41433F", 0.8, out 点击轻功x, out 点击轻功y);
                if (点击轻功x > 0)
                {
                    bool 退出轻功点击 = false;
                    while (true)
                    {
                        dm.KeyPress(32);
                        script.MainDelay(dm, 1000);
                        //按住摇杆右
                        int 按住摇杆右x = 0, 按住摇杆右y = 0;
                        dm.FindStrFast(253, 379, 362, 407, "按住摇杆右推", "8C8278-41423E", 0.8, out 按住摇杆右x, out 按住摇杆右y);
                        if (按住摇杆右x > 0)
                        {
                            dm.MoveTo(gameOperation.RandomNum(125, 165), gameOperation.RandomNum(370, 400));
                            dm.LeftDown();
                            while (true)
                            {
                                dm.MoveTo(gameOperation.RandomNum(210, 250), gameOperation.RandomNum(365, 400));
                                int 退出x = 0, 退出y = 0;
                                dm.FindStrFast(260, 391, 352, 414, "向上推摇杆", "8C8279-3E403B", 0.8, out 退出x, out 退出y);
                                if (退出x > 0)
                                {
                                    dm.LeftUp();
                                    break;
                                }
                                script.MainDelay(dm, 1000);
                            }

                        }
                        script.MainDelay(dm, 1000);
                        //向上推摇杆
                        int 向上推摇杆x = 0, 向上推摇杆y = 0;
                        dm.FindStrFast(260, 391, 352, 414, "向上推摇杆", "8C8279-3E403B", 0.8, out 向上推摇杆x, out 向上推摇杆y);
                        if (向上推摇杆x>0)
                        {
                            dm.MoveTo(gameOperation.RandomNum(125, 155), gameOperation.RandomNum(370, 400));
                            dm.LeftDown();
                            while (true)
                            {
                                dm.MoveTo(gameOperation.RandomNum(125, 160), gameOperation.RandomNum(305, 330));
                                int 退出x = 0, 退出y = 0;
                                dm.FindStrFast(734, 470, 838, 499, "轻功一段跳", "CAC1AD-343336", 0.8, out 退出x, out 退出y);
                                if (退出x > 0)
                                {
                                    dm.LeftUp();
                                    退出轻功点击 = true;
                                    break;
                                }
                            }
                        }
                        if (退出轻功点击)
                        {
                            break;
                        }
                    }
                }
                //轻功一段跳
                int 轻功一段跳x = 0, 轻功一段跳y = 0;
                dm.FindStrFast(734, 470, 838, 499, "轻功一段跳", "CAC1AD-343336", 0.8, out 轻功一段跳x, out 轻功一段跳y);
                if (轻功一段跳x > 0)
                {
                    dm.KeyPress(32);
                    script.MainDelay(dm, 1000);
                    dm.KeyPress(32);
                    script.MainDelay(dm, 1000);
                }
                //点击此按钮
                int 点击此按钮x = 0, 点击此按钮y = 0;
                dm.FindStrFast(139, 81, 228, 105, "点击此按钮", "877D74-3C3D39", 0.8, out 点击此按钮x, out 点击此按钮y);
                if (点击此按钮x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(238, 266), gameOperation.RandomNum(17, 46));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 2000);
                    dm.MoveTo(gameOperation.RandomNum(619, 660), gameOperation.RandomNum(170, 190));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                    dm.KeyPress(27);
                    script.MainDelay(dm, 1000);
                    dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                }
                //燕子坞活动
                int 燕子坞活动x = 0, 燕子坞活动y = 0;
                dm.FindStr(181, 211, 270, 233, "此活动经验", "90857B-444541", 0.8, out 燕子坞活动x, out 燕子坞活动y);
                if (燕子坞活动x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(145, 425), gameOperation.RandomNum(105, 150));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                    //前往活动
                    int 前往活动x = 0, 前往活动y = 0;
                    dm.FindStrFast(610, 409, 713, 439, "前往活动", "90857B-444541", 0.8, out 前往活动x, out 前往活动y);
                    if (前往活动x > 0)
                    {
                        dm.MoveTo(前往活动x + gameOperation.RandomNum(0, 30), 前往活动y + gameOperation.RandomNum(0, 20));
                        script.MainDelay(dm, 1000);
                        dm.LeftClick();
                        script.MainDelay(dm, 1000);
                        DateTime  燕子坞时间1= DateTime.Now;
                        while (true)
                        {
                            //创建队伍
                            int 创建队伍x = 0, 创建队伍y = 0;
                            dm.FindStrFast(370, 319, 445, 344, "创建队伍", "9A8C76-464B39", 0.8, out 创建队伍x, out 创建队伍y);
                            if (创建队伍x > 0)
                            {
                                dm.MoveTo(创建队伍x + gameOperation.RandomNum(0, 30), 创建队伍y + gameOperation.RandomNum(0, 20));
                                script.MainDelay(dm, 1000);
                                dm.LeftClick();
                                script.MainDelay(dm, 1000);
                            }
                            //自动匹配
                            int 自动匹配x = 0, 自动匹配y = 0;
                            dm.FindStrFast(741, 486, 839, 514, "自动匹配", "6E6D56-6E6D56", 0.8, out 自动匹配x, out 自动匹配y);
                            if (自动匹配x > 0)
                            {
                                dm.MoveTo(自动匹配x + gameOperation.RandomNum(0, 30), 自动匹配y + gameOperation.RandomNum(0, 15));
                                script.MainDelay(dm, 1000);
                                dm.LeftClick();
                                script.MainDelay(dm, 1000);
                            }
                            //确定雇佣系统侠士
                            int 确定雇佣x = 0, 确定雇佣y = 0;
                            dm.FindStr(514, 319, 605, 342, "确定", "90857B-444541", 0.8, out 确定雇佣x, out 确定雇佣y);
                            if (确定雇佣x>0)
                            {
                                dm.MoveTo(确定雇佣x+gameOperation.RandomNum(0, 30), 确定雇佣y+gameOperation.RandomNum(0, 15));
                                script.MainDelay(dm, 1000);
                                dm.LeftClick();
                                script.MainDelay(dm, 1000);
                            }
                            //离开副本
                            int 离开副本2x = 0, 离开副本2y = 0;
                            dm.FindStrFast(507, 306, 601, 339, "离开副本", "968C86-484E4B", 0.8, out 离开副本2x, out 离开副本2y);
                            if (离开副本2x > 0)
                            {
                                dm.MoveTo(离开副本2x + gameOperation.RandomNum(0, 20), 离开副本2y + gameOperation.RandomNum(0, 10));
                                dm.LeftClick();
                                script.MainDelay(dm, 1000);
                                break;
                            }
                            script.MainDelay(dm, 1000);
                            DateTime 燕子坞时间2 = DateTime.Now;
                            if ((燕子坞时间2- 燕子坞时间1).TotalMinutes>=8)
                            {
                                break;
                            }
                        }
                    }
                }
                //召唤雕儿
                int 召唤雕儿1x = 0, 召唤雕儿1y = 0;
                dm.FindStrFast(775, 440, 875, 463, "召唤雕儿", "9A8D89-4B5150", 0.8, out 召唤雕儿1x, out 召唤雕儿1y);
                if (召唤雕儿1x > 0)
                {
                    dm.MoveTo(召唤雕儿1x + gameOperation.RandomNum(0, 30), 召唤雕儿1y + gameOperation.RandomNum(0, 20));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                }
                //确定下载
                int 确定下载x = 0, 确定下载y = 0;
                dm.FindStr(509, 317, 592, 344, "确定下载", "968975-414637|98887C-494B42", 0.8, out 确定下载x, out 确定下载y);
                if (确定下载x > 0)
                {
                    dm.MoveToEx(确定下载x, 确定下载y, 10, 10);
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                }
                int 确定提示x = 0, 确定提示y = 0;
                dm.FindPic(382, 114, 441, 164, "\\img\\确定提示.bmp", "000000", 0.8, 0, out 确定提示x, out 确定提示y);
                if (确定提示x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(435, 525), gameOperation.RandomNum(320, 340));//点击闯荡江湖
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                }
                int 确定提示1x = 0, 确定提示1y = 0;
                dm.FindStr(505, 316, 597, 346, "确定", "9E8F7B-464B3B", 0.8, out 确定提示1x, out 确定提示1y);
                if (确定提示1x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(435, 525), gameOperation.RandomNum(320, 340));//点击闯荡江湖
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                }
                
                int 上指引标1x = 0, 上指引标1y = 0;
                dm.FindStrFast(0, 0, 960, 400, "上引导标志", "C9C2AD-363D43", 0.8, out 上指引标1x, out 上指引标1y);
                if (上指引标1x > 0) 
                {
                    dm.MoveTo(上指引标1x, 上指引标1y - gameOperation.RandomNum(5, 10));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                    for (int i = 0; i < 10; i++)
                    {
                        //左指引标
                        int 左指引标x = 0, 左指引标y = 0;
                        dm.FindStrFast(0, 0, 580, 540, "左指引标", "C2BCA4-3D433F", 0.8, out 左指引标x, out 左指引标y);
                        if (左指引标x > 0)
                        {
                            dm.MoveTo(左指引标x - gameOperation.RandomNum(5, 15), 左指引标y);
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                            continue;
                        }
                        //下指引标
                        int 下指引标x = 0, 下指引标y = 0;
                        dm.FindStrFast(0, 270, 960, 540, "向下引导标", "f4f2d3-18160C|C2BCA4-3D433F", 0.8, out 下指引标x, out 下指引标y);
                        if (下指引标x > 0)
                        {
                            dm.MoveTo(下指引标x, 下指引标y + gameOperation.RandomNum(5, 15));
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                            continue;
                        }
                        //右指引标
                        int 右指引标2x = 0, 右指引标2y = 0;
                        dm.FindStrFast(380, 0, 960, 540, "右指引标", "B6B1A1-494E4F", 0.8, out 右指引标2x, out 右指引标2y);
                        if (右指引标2x > 0)
                        {
                            dm.MoveTo(右指引标2x + gameOperation.RandomNum(30, 45), 右指引标2y + gameOperation.RandomNum(3, 8));
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                            continue;
                        }
                        //上指引标
                        int 上指引标x = 0, 上指引标y = 0;
                        dm.FindStrFast(0, 0, 960, 400, "上引导标志", "C9C2AD-363D43", 0.8, out 上指引标x, out 上指引标y);
                        if (上指引标x > 0)
                        {
                            dm.MoveTo(上指引标x, 上指引标y-gameOperation.RandomNum(5, 10));
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                            continue;
                        }
                        //创建队伍
                        int 创建队伍x = 0, 创建队伍y = 0;
                        dm.FindStrFast(365, 319, 453, 342, "创建队伍", "978A76-424739", 0.8, out 创建队伍x, out 创建队伍y);
                        if (创建队伍x > 0)
                        {
                            dm.MoveTo(创建队伍x + gameOperation.RandomNum(0, 30), 创建队伍y + gameOperation.RandomNum(0, 20));
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                            //我的队伍
                            dm.MoveTo(gameOperation.RandomNum(900, 935), gameOperation.RandomNum(260, 295));
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                            int count = 0;
                            while (true)
                            {
                                count++;
                                if (count >= 500)
                                    break;
                                script.MainDelay(dm, 1000);
                                //离开副本
                                int 退出x = 0, 退出y = 0;
                                dm.FindStrFast(507, 306, 601, 339, "离开副本", "968C86-484E4B", 0.8, out 退出x, out 退出y);
                                if (退出x > 0)
                                {
                                    break;
                                }
                                //自动匹配
                                int 自动匹配x = 0, 自动匹配y = 0;
                                dm.FindStrFast(744, 485, 835, 512, "自动匹配", "988C76-484C3C", 0.8, out 自动匹配x, out 自动匹配y);
                                if (自动匹配x > 0)
                                {
                                    dm.MoveTo(自动匹配x + gameOperation.RandomNum(0, 30), 自动匹配y + gameOperation.RandomNum(0, 20));
                                    script.MainDelay(dm, 1000);
                                    dm.LeftClick();
                                    script.MainDelay(dm, 1000);
                                }
                                int 确定雇佣x = 0, 确定雇佣y = 0;
                                dm.FindStr(505, 316, 597, 346, "确定", "9E8F7B-464B3B", 0.8, out 确定雇佣x, out 确定雇佣y);
                                if (确定雇佣x > 0)
                                {
                                    dm.MoveTo(确定雇佣x+gameOperation.RandomNum(0, 30), 确定雇佣y+gameOperation.RandomNum(0, 20));//点击闯荡江湖
                                    script.MainDelay(dm, 1000);
                                    dm.LeftClick();
                                    script.MainDelay(dm, 1000);
                                }
                            }
                        }
                       
                        //挑战
                        int 挑战2x = 0, 挑战2y = 0;
                        dm.FindPic(202, 411, 766, 516, "\\img\\挑战.bmp", "000000", 0.8, 0, out 挑战2x, out 挑战2y);
                        if (挑战2x > 0)
                        {
                            dm.MoveTo(挑战2x + gameOperation.RandomNum(0, 10), 挑战2y + gameOperation.RandomNum(0, 10));
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                        }
                    }
                }
                script.MainDelay(dm, 1000);

                //右指引标
                int 右指引标x = 0, 右指引标y = 0;
                dm.FindStrFast(480, 0, 960, 540, "右指引标", "B6B1A1-494E4F", 0.8, out 右指引标x, out 右指引标y);
                if (右指引标x > 0)
                {
                    dm.MoveTo(右指引标x + gameOperation.RandomNum(30, 45), 右指引标y + gameOperation.RandomNum(3, 8));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                    for (int i = 0; i < 10; i++)
                    {
                        //左指引标
                        int 左指引标1x = 0, 左指引标1y = 0;
                        dm.FindStrFast(0, 0, 480, 540, "左指引标", "C2BCA4-3D433F", 0.8, out 左指引标1x, out 左指引标1y);
                        if (左指引标1x > 0)
                        {
                            script.MainDelay(dm, 1000);
                            dm.MoveTo(左指引标1x - gameOperation.RandomNum(10, 20), 左指引标1y-5);
                            script.MainDelay(dm, 1000);
                            dm.RightClick();
                            script.MainDelay(dm, 1000);
                            continue;
                        }
                        //下指引标
                        int 下指引标x = 0, 下指引标y = 0;
                        dm.FindStrFast(0, 270, 960, 540, "向下引导标", "f4f2d3-18160C|C2BCA4-3D433F", 0.8, out 下指引标x, out 下指引标y);
                        if (下指引标x > 0)
                        {
                            dm.MoveTo(下指引标x, 下指引标y + gameOperation.RandomNum(40, 60));
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                            continue;
                        }
                        
                        //上指引标
                        int 上指引标x = 0, 上指引标y = 0;
                        dm.FindStrFast(0, 0, 960, 400, "上引导标志", "C9C2AD-363D43", 0.8, out 上指引标x, out 上指引标y);
                        if (上指引标x > 0)
                        {
                            dm.MoveTo(上指引标x, 上指引标y- gameOperation.RandomNum(0, 15));
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                            continue;
                        }
                        //右指引标
                        int 右指引标2x = 0, 右指引标2y = 0;
                        dm.FindStrFast(480, 0, 960, 540, "右指引标", "B6B1A1-494E4F", 0.8, out 右指引标2x, out 右指引标2y);
                        if (右指引标2x>0)
                        {
                            dm.MoveTo(右指引标2x + gameOperation.RandomNum(30, 45), 右指引标2y + gameOperation.RandomNum(3, 8));
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                            continue;
                        }
                        //一键升级
                        int 一键升级x = 0, 一键升级y = 0;
                        dm.FindStrFast(138, 469, 238, 496, "一键升级", "897B6A-383D2F", 0.8, out 一键升级x, out 一键升级y);
                        if (一键升级x > 0)
                        {
                            dm.MoveTo(一键升级x + gameOperation.RandomNum(0, 20), 一键升级y + gameOperation.RandomNum(0, 10));
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                        }
                        int 确定提示2x = 0, 确定提示2y = 0;
                        dm.FindStr(505, 316, 597, 346, "确定", "9E8F7B-464B3B", 0.8, out 确定提示2x, out 确定提示2y);
                        if (确定提示2x > 0)
                        {
                            dm.MoveTo(确定提示2x+gameOperation.RandomNum(0, 30), 确定提示2y+gameOperation.RandomNum(0, 20));//点击闯荡江湖
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                        }
                    }
                    //continue;
                }
                //展开功能菜单
                int 展开功能菜单x = 0, 展开功能菜单y = 0;
                dm.FindStrFast(749, 204, 856, 235, "展开功能菜单", "8B8077-3F413D", 0.8, out 展开功能菜单x, out 展开功能菜单y);
                if (展开功能菜单x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(905, 930), gameOperation.RandomNum(210, 235));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                    //打开武学界面
                    int 打开武学界面x = 0, 打开武学界面y = 0;
                    dm.FindStrFast(642, 317, 762, 346, "打开武学界面", "8B8077-3F413D", 0.8, out 打开武学界面x, out 打开武学界面y);
                    if (打开武学界面x > 0)
                    {
                        dm.MoveTo(gameOperation.RandomNum(850, 875), gameOperation.RandomNum(320, 345));
                        script.MainDelay(dm, 1000);
                        dm.LeftClick();
                        script.MainDelay(dm, 1000);
                    }
                }
                //挑战
                int 挑战x = 0, 挑战y = 0;
                dm.FindStrFast(798, 437, 848, 463, "挑战", "9a8d89-4B5150", 0.8, out 挑战x, out 挑战y);
                if (挑战x>0)
                {
                    dm.MoveTo(挑战x+gameOperation.RandomNum(0, 30), 挑战y+gameOperation.RandomNum(0, 20));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                }
                
                //繁殖
                int 繁殖x = 0, 繁殖y = 0;
                dm.FindStrFast(578, 449, 633, 477, "繁殖", "9A8D89-4B5150", 0.8, out 繁殖x, out 繁殖y);
                if (繁殖x > 0)
                {
                    //猴子1
                    dm.MoveTo(gameOperation.RandomNum(205, 295),  gameOperation.RandomNum(145, 175));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                    //锁定
                    dm.MoveTo(gameOperation.RandomNum(540, 565), gameOperation.RandomNum(380, 400));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                    ////猴子2
                    //dm.MoveTo(gameOperation.RandomNum(215, 310), gameOperation.RandomNum(220, 255));
                    //dm.delay(1000);
                    //dm.LeftClick();
                    //dm.delay(1000);
                    ////锁定
                    //dm.MoveTo(gameOperation.RandomNum(540, 565), gameOperation.RandomNum(380, 400));
                    //dm.delay(1000);
                    //dm.LeftClick();
                    //dm.delay(1000);
                    dm.MoveTo(繁殖x, 繁殖y);
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                }
                int 自动战斗x = 0, 自动战斗y = 0;
                dm.FindPic(323, 431, 353, 464, "\\img\\自动战斗标志.bmp", "000000", 0.8, 0, out 自动战斗x, out 自动战斗y);
                if (自动战斗x > 0)
                {
                    dm.MoveTo(自动战斗x, 自动战斗y);
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                }
                
                //宠物出战+,优化成使用快捷键
                int 宠物出战x = 0, 宠物出战y = 0;
                dm.FindStrFast(277, 3, 328, 47, "宠物出战+", "FBF7E2-040719", 0.8, out 宠物出战x, out 宠物出战y);
                if (宠物出战x > 0)
                {
                    dm.MoveToEx(宠物出战x, 宠物出战y, 10, 10);
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 2000);
                    dm.MoveTo(gameOperation.RandomNum(315, 410), gameOperation.RandomNum(497, 521));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 3000);
                }
                
                //离开副本
                int 离开副本x = 0, 离开副本y = 0;
                dm.FindStrFast(507, 306, 601, 339, "离开副本", "968C86-484E4B", 0.8, out 离开副本x, out 离开副本y);
                if (离开副本x > 0)
                {
                    dm.MoveTo(离开副本x+gameOperation.RandomNum(0, 20), 离开副本y+gameOperation.RandomNum(0, 10));
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                }
                //加入门派
                int 加入门派x = 0, 加入门派y = 0;
                dm.FindStrFast(802, 374, 901, 405, "加入门派", "F2D1BE-0C2E34", 0.8, out 加入门派x, out 加入门派y);
                if (加入门派x > 0)
                {
                    dm.MoveTo(加入门派x + gameOperation.RandomNum(0, 20), 加入门派y + gameOperation.RandomNum(0, 10));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                    //确定加入
                    dm.MoveTo(gameOperation.RandomNum(500, 595), gameOperation.RandomNum(325, 355));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                }

                //打开活动主界
                int 打开活动主界x = 0, 打开活动主界y = 0;
                dm.FindStrFast(758, 164, 868, 187, "打开活动主界", "8E837A-42443F", 0.8, out 打开活动主界x, out 打开活动主界y);
                if (打开活动主界x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(775, 795), gameOperation.RandomNum(90, 110));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                    //打开问剑侠义
                    int 打开问剑侠义x = 0, 打开问剑侠义y = 0;
                    dm.FindStrFast(266, 201, 375, 225, "打开问剑侠义", "8E837A-42443F", 0.8, out 打开问剑侠义x, out 打开问剑侠义y);
                    if (打开问剑侠义x > 0)
                    {
                        dm.MoveTo(打开问剑侠义x + gameOperation.RandomNum(0, 30), 打开问剑侠义y + gameOperation.RandomNum(0, 20));
                        script.MainDelay(dm, 1000);
                        dm.LeftClick();
                        script.MainDelay(dm, 1000);
                    }
                    //前往活动
                    int 前往活动x = 0, 前往活动y = 0;
                    dm.FindStrFast(615, 409, 709, 436, "前往活动", "897E75-3D3F3B", 0.8, out 前往活动x, out 前往活动y);
                    if (前往活动x > 0)
                    {
                        dm.MoveTo(前往活动x + gameOperation.RandomNum(0, 30), 前往活动y + gameOperation.RandomNum(0, 20));
                        script.MainDelay(dm, 1000);
                        dm.LeftClick();
                        script.MainDelay(dm, 1000);
                    }
                    //挑战
                    int 挑战3x = 0, 挑战3y = 0;
                    dm.FindPic(202, 411, 766, 516, "\\img\\挑战.bmp", "000000", 0.8, 0, out 挑战3x, out 挑战3y);
                    if (挑战x > 0)
                    {
                        dm.MoveTo(挑战3x + gameOperation.RandomNum(0, 10), 挑战3y + gameOperation.RandomNum(0, 10));
                        script.MainDelay(dm, 1000);
                        dm.LeftClick();
                        script.MainDelay(dm, 1000);
                    }
                    script.MainDelay(dm, 1000);
                }
                int 挑战1x = 0, 挑战1y = 0;
                dm.FindStrFast(796, 436, 850, 470, "挑战", "967E68-403F2D", 0.8, out 挑战1x, out 挑战1y);
                if (挑战1x > 0)
                {
                    dm.MoveTo(挑战1x + gameOperation.RandomNum(0, 10), 挑战1y + gameOperation.RandomNum(0, 10));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                }
                //突破心境
                int 突破心境1x = 0, 突破心境1y = 0;
                dm.FindStrFast(859, 448, 917, 509, "突破心境", "ECD5C8-132A37", 0.8, out 突破心境1x, out 突破心境1y);
                if (突破心境1x > 0)
                {
                    dm.MoveTo(突破心境1x + gameOperation.RandomNum(5, 50), 突破心境1y - gameOperation.RandomNum(5, 40));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                ////前往二楼
                int 前往二楼x = 0, 前往二楼y = 0;
                dm.FindStrFast(781, 439, 867, 466, "前往二楼", "9E8D84-484C48", 0.8, out 前往二楼x, out 前往二楼y);
                if (前往二楼x > 0)
                {
                    dm.MoveTo(前往二楼x + gameOperation.RandomNum(0, 30), 前往二楼y + gameOperation.RandomNum(0, 20));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                }
                int 前往二楼1x = 0, 前往二楼1y = 0;
                dm.FindStrFast(746, 409, 913, 484, "前往二楼", "EEC6B2-103940", 0.8, out 前往二楼1x, out 前往二楼1y);
                if (前往二楼1x > 0)
                {
                    dm.MoveTo(前往二楼1x + gameOperation.RandomNum(0, 30), 前往二楼1y + gameOperation.RandomNum(0, 20));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                }
                int 点菜x = 0, 点菜y = 0;
                dm.FindStrFast(704, 25, 783, 52, "开始点菜", "C9C1AD-343437", 0.8, out 点菜x, out 点菜y);
                if (点菜x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(840, 870), gameOperation.RandomNum(25, 50));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                    //+
                    dm.MoveTo(gameOperation.RandomNum(905, 920), gameOperation.RandomNum(85, 100));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                    dm.MoveTo(gameOperation.RandomNum(900, 920), gameOperation.RandomNum(155, 175));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                    dm.MoveTo(gameOperation.RandomNum(900, 920), gameOperation.RandomNum(230, 250));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                    //下单
                    dm.MoveTo(gameOperation.RandomNum(760, 870), gameOperation.RandomNum(455, 485));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                    //上菜
                    dm.MoveTo(gameOperation.RandomNum(415, 510), gameOperation.RandomNum(365, 395));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                    int count = 0;
                    while (true)
                    {
                        if (count>=20)
                        {
                            dm.MoveTo(gameOperation.RandomNum(775, 800), gameOperation.RandomNum(105, 125));
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                            break;
                        }
                        //离开饭桌
                        int 离开饭桌x = 0, 离开饭桌y = 0;
                        dm.FindStrFast(630, 96, 710, 124, "离开饭桌", "C9C1AD-343437", 0.8, out 离开饭桌x, out 离开饭桌y);
                        if (离开饭桌x > 0)
                        {
                            dm.MoveTo(gameOperation.RandomNum(775, 800), gameOperation.RandomNum(105, 125));
                            script.MainDelay(dm, 1000);
                            dm.LeftClick();
                            script.MainDelay(dm, 1000);
                            break;
                        }
                        count++;
                        script.MainDelay(dm, 3000);
                    }
                }
                //离开饭馆
                int 离开饭馆x = 0, 离开饭馆y = 0;
                dm.FindStrFast(594, 367, 690, 398, "离开饭馆", "9A8D89-4B5150", 0.8, out 离开饭馆x, out 离开饭馆y);
                if (离开饭馆x>0)
                {
                    dm.MoveTo(离开饭馆x+gameOperation.RandomNum(0, 30), 离开饭馆y+gameOperation.RandomNum(0, 20));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                    //确定离开饭馆
                    dm.MoveTo(gameOperation.RandomNum(510, 595), gameOperation.RandomNum(320, 340));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                }
                
                
                //繁殖领取
                int 繁殖领取x = 0, 繁殖领取y = 0;
                dm.FindPic(427, 338, 456, 363, "\\img\\繁殖领取.bmp", "000000", 0.8, 0, out 繁殖领取x, out 繁殖领取y);
                if (繁殖领取x > 0)
                {
                    dm.MoveTo(繁殖领取x + gameOperation.RandomNum(5, 20), 繁殖领取y + gameOperation.RandomNum(5, 15));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                }
                //召唤雕儿
                int 召唤雕儿x = 0, 召唤雕儿y = 0;
                dm.FindStrFast(756, 433, 888, 471, "召唤雕儿", "F0D1C0-0E2E32", 0.8, out 召唤雕儿x, out 召唤雕儿y);
                if (召唤雕儿x > 0)
                {
                    dm.MoveTo(召唤雕儿x + gameOperation.RandomNum(0, 30), 召唤雕儿y + gameOperation.RandomNum(0, 20));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                }
                int 疗伤x = 0, 疗伤y = 0;
                dm.FindStrFast(310, 371, 345, 398, "疗伤", "C9CBCB-353333", 0.8, out 疗伤x, out 疗伤y);
                if (疗伤x > 0)
                {
                    DateTime dateTime1 = DateTime.Now;
                    while (true)
                    {
                        dm.MoveTo(疗伤x + gameOperation.RandomNum(0, 10), 疗伤y + gameOperation.RandomNum(0, 10));
                        script.MainDelay(dm, 200);
                        dm.LeftClick();
                        script.MainDelay(dm, 200);
                        DateTime dateTime2 = DateTime.Now;
                        if ((dateTime2 - dateTime1).TotalSeconds >= 30)
                        {
                            break;
                        }
                    }
                }
                //反击去位
                int 反击去位x = 0, 反击去位y = 0;
                dm.FindPic(640, 151, 696, 200, "\\img\\反击去位.bmp", "000000", 0.8, 0, out 反击去位x, out 反击去位y);
                if (反击去位x>0)
                {
                    dm.MoveTo(反击去位x + gameOperation.RandomNum(0, 30), 反击去位y + gameOperation.RandomNum(0, 15));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                }
                //姑娘聪慧
                int 姑娘聪慧x = 0, 姑娘聪慧y = 0;
                dm.FindPic(640, 253, 686, 299, "\\img\\姑娘聪慧.bmp", "000000", 0.8, 0, out 姑娘聪慧x, out 姑娘聪慧y);
                if (姑娘聪慧x>0)
                {
                    dm.MoveTo(姑娘聪慧x + gameOperation.RandomNum(0, 30), 姑娘聪慧y + gameOperation.RandomNum(0, 10));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                }
                int 参悟一次x = 0, 参悟一次y = 0;
                dm.FindStrFast(263, 450, 367, 484, "参悟一次", "A3896B-514A31", 0.8, out 参悟一次x, out 参悟一次y);
                if (参悟一次x > 0)
                {
                    dm.MoveTo(参悟一次x + gameOperation.RandomNum(0, 30), 参悟一次y + gameOperation.RandomNum(0, 20));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    dm.delay(3000);
                    dm.KeyPress(27);
                    script.MainDelay(dm, 1000);
                    dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                   
                }
                //
                int xx = 0, xy = 0;
                dm.FindStrFast(691, 2, 961, 238, "x", "EFBF9F-100D0B|C7B295-384D4F|F3E8D9-0C0F0E", 0.8, out xx, out xy);
                if (xx > 0)
                {
                    dm.MoveTo(xx + gameOperation.RandomNum(0, 5), xy + gameOperation.RandomNum(0, 5));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    dm.delay(3000);
                }
                //完成今日
                int 完成今日x = 0, 完成今日y = 0;
                dm.FindStrFast(47, 95, 122, 122, "完成今日", "C7C4C5-363938", 0.8, out 完成今日x, out 完成今日y);
                if (完成今日x > 0)
                {
                    break;
                }
                int 关闭1x = 0, 关闭1y = 0;
                dm.FindPic(480, 0, 960, 270, "\\img\\关闭1.bmp", "000000", 0.8, 0, out 关闭1x, out 关闭1y);
                if (关闭1x > 0)
                {
                    dm.MoveTo(关闭1x + gameOperation.RandomNum(0, 10), 关闭1y + gameOperation.RandomNum(0, 10));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                }
                int 关闭x = 0, 关闭y = 0;
                dm.FindPic(480, 0, 960, 270, "\\img\\关闭.bmp", "000000", 0.8, 0, out 关闭x, out 关闭y);
                if (关闭x > 0)
                {
                    dm.MoveTo(关闭x + gameOperation.RandomNum(0,10), 关闭y + gameOperation.RandomNum(0, 10));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                }
                int 广告关闭x = 0, 广告关闭y = 0;
                dm.FindPic(480, 0, 960, 270, "\\img\\广告关闭.bmp", "000000", 0.8, 0, out 广告关闭x, out 广告关闭y);
                if (广告关闭x > 0)
                {
                    dm.MoveTo(广告关闭x + gameOperation.RandomNum(0, 10), 广告关闭y + gameOperation.RandomNum(0, 10));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                }
                int 关闭3x = 0, 关闭3y = 0;
                dm.FindPic(600, 1, 960, 280, "\\img\\关闭3.bmp", "000000", 0.8, 0, out 关闭3x, out 关闭3y);
                if (关闭3x > 0)
                {
                    dm.MoveTo(关闭3x + gameOperation.RandomNum(0, 5), 关闭3y + gameOperation.RandomNum(0, 5));
                    script.MainDelay(dm, 1000);
                    dm.LeftClick();
                    script.MainDelay(dm, 1000);
                }
                //地图标志
                int 世界x = 0, 世界y = 0;
                dm.FindPic(887, 69, 918, 98, "\\img\\世界.bmp", "000000", 0.8, 0, out 世界x, out 世界y);
                if (世界x > 0)
                {
                    dm.KeyPress(77);
                    script.MainDelay(dm, 1000);
                }
                //按下f键
                dm.KeyPress(70);
                script.MainDelay(dm, 1000);
                //按下c键
                dm.KeyPress(67);
                script.MainDelay(dm, 1000);
                //计算任务运行时间
                DateTime now = DateTime.Now;
                var span = (now - strartTime).TotalMinutes;
                double limitimes = double.Parse(user.MainLineLimitTime.ToString());
                if (span >= limitimes)
                {
                    break;
                }
                //重出江湖
                int 重出江湖x = 0, 重出江湖y = 0;
                dm.FindStrFast(39, 72, 156, 109, "重出江湖", "C3AD6B-39331F", 0.8, out 重出江湖x, out 重出江湖y);
                if (重出江湖x > 0)
                {
                    break;
                }
                //dm.KeyPress(27);
                //script.MainDelay(dm, 1000);
                //dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
                //dm.LeftClick();
                //script.MainDelay(dm, 1000);
            }
        }
    }
}
