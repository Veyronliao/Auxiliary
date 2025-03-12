using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace senke
{
    public class MainLine
    {
        public GameOperation gameOperation { get; set; }
        public UserItem user { get; set; }
        public dmsoft dm { get; set; }
        public MainLine(dmsoft dm, UserItem user)
        {
            gameOperation = new GameOperation(dm);
            this.user = user;
            this.dm = dm;
        }
        public void DoWork()
        {
            DateTime strartTime= DateTime.Now;
            while (true)
            {
                dm.UseDict(3);
                dm.delay(1000);
                dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
                dm.delay(2000);
                dm.LeftClick();
                dm.delay(1000);
                //清空对话框
                int 主x = 0, 主y = 0;
                dm.FindStrFast(40, 79, 63, 102, "主", "B7A568-483E24", 0.8, out 主x, out 主y);
                if (主x < 0)
                {
                    dm.KeyPress(77);
                    dm.delay(500);
                }
                //点击主线任务
                dm.KeyPress(192);
                dm.delay(3000);
                //跳过剧情
                int 跳过剧情x = 0, 跳过剧情y = 0;
                dm.FindStrFast(1100, 25, 1215, 60, "跳过剧情", "eddcc6-122339", 0.8, out 跳过剧情x, out 跳过剧情y);
                if (跳过剧情x > 0)
                {
                    dm.KeyPress(77);
                    dm.delay(1000);
                    //确定
                    dm.MoveTo(gameOperation.RandomNum(670, 800),gameOperation.RandomNum(420, 460));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //完成今日任务，跳出主线任务
                int 完成今日x = 0, 完成今日y = 0;
                dm.FindStrFast(72, 130, 143, 155, "完成今日", "CECECE-313131", 0.8, out 完成今日x, out 完成今日y);
                if (完成今日x > 0)
                {
                    break;
                }
                int 确定x = 0, 确定y = 0;
                dm.FindStrFast(591, 288, 1052, 509, "确定", "978A77-424739", 0.8, out 确定x, out 确定y);
                if (确定x > 0)
                {
                    dm.MoveTo(确定x + gameOperation.RandomNum(0, 30), 确定y + gameOperation.RandomNum(0, 25));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //自动（打斗场景开启）
                int 自动战斗x = 0, 自动战斗y = 0;
                dm.FindPic(437, 584, 467, 611, "\\img\\zidongzhandou.bmp", "000000", 0.8, 0, out 自动战斗x, out 自动战斗y);
                if (自动战斗x > 0)
                {
                    dm.KeyPress(90);//按下z键
                    dm.delay(1000);
                }
                //触发事件
                int 触发事件x = 0, 触发事件y = 0;
                dm.FindStrFast(718, 283, 838, 329, "触发事件", "D5CCB6-29292E", 0.8, out 触发事件x, out 触发事件y);
                if (触发事件x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(900, 950), gameOperation.RandomNum(380, 430));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                int 二五Dx = 0, 二五Dy = 0;
                dm.FindStrFast(665, 129, 954, 181, "2.5D模式", "fffdf7-414247", 0.8, out 二五Dx, out 二五Dy);
                if (二五Dx > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(666, 1200), gameOperation.RandomNum(130, 580));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    int 确定选择x = 0, 确定选择y = 0;
                    dm.FindStrFast(550, 660, 684, 710, "确定选择", "948474-424537", 0.8, out 确定选择x, out 确定选择y);
                    if (确定选择x > 0)
                    {
                        dm.MoveTo(确定选择x + gameOperation.RandomNum(0, 50), 确定选择y + gameOperation.RandomNum(0, 25));
                        dm.delay(1000);
                        dm.LeftClick();
                        dm.delay(1000);
                    }
                }
                //退出循环有问题  todo
                int 破坏金刚大阵x = 0, 破坏金刚大阵y = 0;
                dm.FindStrFast(71, 132, 181, 158, "破坏金刚大阵", "CCCCCB-333334", 0.8, out 破坏金刚大阵x, out 破坏金刚大阵y);
                if (破坏金刚大阵x > 0)
                {
                    int count = 0;
                    while (true)
                    {
                        if (count>=60)
                        {
                            break;
                        }
                        dm.MoveTo(破坏金刚大阵x + gameOperation.RandomNum(0, 30), 破坏金刚大阵y + gameOperation.RandomNum(0, 20));
                        dm.delay(1000);
                        dm.LeftClick();
                        dm.delay(1000);
                        dm.KeyPress(66);
                        dm.delay(500);
                        dm.KeyPress(49);
                        dm.delay(500);
                        dm.KeyPress(50);
                        dm.delay(500);
                        dm.KeyPress(51);
                        dm.delay(500);
                        dm.KeyPress(52);
                        dm.delay(500);
                        dm.KeyPress(9);
                        dm.delay(500);
                        int 退出x = 0, 退出y = 0;
                        dm.FindPic(39, 112, 109, 193, "\\img\\tuichu.bmp", "000000", 0.8, 0, out 退出x, out 退出y);
                        if (退出x > 0)
                        {
                            break;
                        }
                        int 退出1x = 0, 退出1y = 0;
                        dm.FindStrFast(1100, 25, 1215, 60, "跳过剧情", "eddcc6-122339", 0.8, out 退出1x, out 退出1y);
                        if (退出1x > 0)
                        {
                            break;
                        }
                        count++;
                    }
                }
                //点击普通攻击
                int 点击普通攻击x = 0, 点击普通攻击y = 0;
                dm.FindStrFast(870, 558, 1052, 609, "点击普通攻击", "D0C6B1-2E2F33|CDC4AF-313135", 0.8, out 点击普通攻击x, out 点击普通攻击y);
                if (点击普通攻击x > 0)
                {
                    dm.KeyPress(66);
                    dm.delay(500);
                }
                //切换攻击目标
                int 切换攻击目标x = 0, 切换攻击目标y = 0;
                dm.FindStrFast(959, 459, 1125, 506, "切换攻击目标", "CCCCCB-333334", 0.8, out 切换攻击目标x, out 切换攻击目标y);
                if (切换攻击目标x > 0)
                {
                    dm.KeyPress(9);
                    dm.delay(500);
                }
                //装备
                int 装备x = 0, 装备y = 0;
                dm.FindStrFast(906, 410, 1030, 457, "装备", "ECD9D6-132629|EBD7D4-14282B", 0.8, out 装备x, out 装备y);
                if (装备x > 0)
                {
                    dm.KeyPress(70);
                    dm.delay(500);
                }
                //手指轮转
                int 手指轮转x = 0, 手指轮转y = 0;
                dm.FindStrFast(230, 208, 309, 289, "轮转", "C7C1B8-232831", 0.8, out 手指轮转x, out 手指轮转y);
                if (手指轮转x > 0)
                {
                    //转轮
                    dm.MoveTo(gameOperation.RandomNum(797, 806), gameOperation.RandomNum(355, 365));
                    dm.delay(100);
                    dm.LeftDown();
                    dm.delay(100);
                    dm.MoveTo(gameOperation.RandomNum(764, 772), gameOperation.RandomNum(410, 420));
                    dm.delay(100);
                    dm.MoveTo(gameOperation.RandomNum(720, 730), gameOperation.RandomNum(444, 454));
                    dm.delay(100);
                    dm.MoveTo(gameOperation.RandomNum(676, 686), gameOperation.RandomNum(456, 466));
                    dm.delay(100);
                    dm.MoveTo(gameOperation.RandomNum(576, 586), gameOperation.RandomNum(450, 460));
                    dm.delay(100);
                    dm.MoveTo(gameOperation.RandomNum(525, 535), gameOperation.RandomNum(414, 424));
                    dm.delay(2000);

                }
                // 五蕰皆空
                int 五蕰皆空_x = 0, 五蕰皆空_y = 0;
                dm.FindStrFast(51, 116, 413, 197, "五", "CB7778-34302E", 0.8, out 五蕰皆空_x, out 五蕰皆空_y);
                if (五蕰皆空_x > 0)
                {
                    //点击五蕰皆空
                    dm.MoveTo(gameOperation.RandomNum(790, 860), gameOperation.RandomNum(425, 485));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    dm.MoveTo(gameOperation.RandomNum(815, 870), gameOperation.RandomNum(260, 315));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    dm.MoveTo(gameOperation.RandomNum(510, 570), gameOperation.RandomNum(190, 240));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    dm.MoveTo(gameOperation.RandomNum(350, 410), gameOperation.RandomNum(350, 400));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //翻阅藏书
                int 翻阅藏书_x = 0, 翻阅藏书_y = 0;
                dm.FindStrFast(48, 106, 289, 162, "翻阅藏书", "C8C8C8-333333", 0.8, out 翻阅藏书_x, out 翻阅藏书_y);
                if (翻阅藏书_x > 0)
                {

                    while (true)
                    {
                        dm.MoveToEx(翻阅藏书_x, 翻阅藏书_y, 20, 10);
                        dm.delay(1000);
                        dm.LeftClick();
                        dm.delay(1000);
                        int 翻阅_x = 0, 翻阅_y = 0;
                        dm.FindStrFast(898, 430, 959, 473, "翻阅", "D2D2D2-2A2A2A", 0.8, out 翻阅_x, out 翻阅_y);
                        if (翻阅_x > 0)
                        {
                            dm.MoveTo(翻阅_x, 翻阅_y);
                            dm.delay(1000);
                            dm.LeftClick();
                            dm.delay(4000);
                        }
                        int 跳过剧情1x = 0, 跳过剧情1y = 0;
                        dm.FindStrFast(1100, 25, 1215, 60, "跳过剧情", "eddcc6-122339", 0.8, out 跳过剧情1x, out 跳过剧情1y);
                        if (跳过剧情1x > 0)
                        {
                            dm.KeyPress(77);//跳过动画
                            dm.delay(1000);
                            //确定
                            dm.MoveTo(gameOperation.RandomNum(670, 800), gameOperation.RandomNum(420, 460));
                            dm.delay(1000);
                            dm.LeftClick();
                            dm.delay(1000);
                            break;
                        }
                    }
                }
                //和不速之客战
                int 和不速之客战_x = 0, 和不速之客战_y = 0;
                dm.FindStrFast(48, 106, 289, 162, "和不速之客战", "D2D2D2-2D2D2D", 0.8, out 和不速之客战_x, out 和不速之客战_y);
                if (和不速之客战_x > 0)
                {
                    //战斗
                    while (true)
                    {
                        dm.MoveToEx(和不速之客战_x, 和不速之客战_y, 20, 10);
                        dm.delay(1000);
                        dm.LeftClick();
                        dm.delay(1000);
                        dm.KeyPress(49);
                        dm.delay(500);
                        dm.KeyPress(50);
                        dm.delay(500);
                        dm.KeyPress(51);
                        dm.delay(500);
                        dm.KeyPress(52);
                        dm.delay(500);
                        dm.KeyPress(66);
                        dm.delay(500);
                        int 点击这里x = 0, 点击这里y = 0;
                        dm.FindStrFast(585, 373, 721, 434, "点击这里", "8C8178-40423D", 0.8, out 点击这里x, out 点击这里y);
                        if (点击这里x > 0)
                        {
                            dm.MoveTo(gameOperation.RandomNum(895, 955), gameOperation.RandomNum(375, 435));
                            dm.delay(1000);
                            dm.LeftClick();
                            dm.delay(3000);
                        }
                        int 跳过剧情1x = 0, 跳过剧情1y = 0;
                        dm.FindStrFast(1100, 25, 1215, 60, "跳过剧情", "eddcc6-122339", 0.8, out 跳过剧情1x, out 跳过剧情1y);
                        if (跳过剧情1x > 0)
                        {
                            dm.KeyPress(77);//跳过动画
                            dm.delay(1000);
                            //确定
                            dm.MoveTo(gameOperation.RandomNum(670, 800), gameOperation.RandomNum(420, 460));
                            dm.delay(1000);
                            dm.LeftClick();
                            dm.delay(1000);
                        }
                    }

                }
                //击败猴群
                int 击败猴群_x = 0, 击败猴群_y = 0;
                dm.FindStrFast(47, 107, 237, 161, "击败猴群", "B0B1B1-4D4C4C", 0.8, out 击败猴群_x, out 击败猴群_y);
                if (击败猴群_x > 0)
                {
                    int count = 0;
                    while (true)
                    {
                        count++;
                        dm.MoveToEx(击败猴群_x, 击败猴群_y, 30, 10);
                        dm.LeftClick();
                        dm.delay(1000);
                        dm.KeyPress(66);
                        dm.delay(500);
                        dm.KeyPress(49);
                        dm.delay(500);
                        dm.KeyPress(50);
                        dm.delay(500);
                        dm.KeyPress(51);
                        dm.delay(500);
                        dm.KeyPress(52);
                        dm.delay(500);
                        int 跳过剧情1x = 0, 跳过剧情1y = 0;
                        dm.FindStrFast(1100, 25, 1215, 60, "跳过剧情", "eddcc6-122339", 0.8, out 跳过剧情1x, out 跳过剧情1y);
                        if (跳过剧情1x > 0)
                        {
                            dm.KeyPress(77);//跳过动画
                            dm.delay(1000);
                            //确定
                            dm.MoveTo(gameOperation.RandomNum(670, 800), gameOperation.RandomNum(420, 460));
                            dm.delay(1000);
                            dm.LeftClick();
                            dm.delay(1000);
                        }
                        int 展开选单1_x = 0, 展开选单1_y = 0;
                        dm.FindStrFast(1021, 275, 1123, 313, "展开选单", "8A7F76-3E403C", 0.8, out 展开选单1_x, out 展开选单1_y);
                        if (展开选单1_x > 0)
                        {
                            break;
                        }
                        if (count>80)
                        {
                            break;
                        }
                    }
                }
                int 展开选单_x = 0, 展开选单_y = 0;
                dm.FindStrFast(1021, 275, 1123, 313, "展开选单", "8A7F76-3E403C", 0.8, out 展开选单_x, out 展开选单_y);
                if (展开选单_x > 0)
                {
                    dm.KeyPress(112);//跳过动画
                    dm.delay(1000);
                    //宠物操作
                    int 宠物操作_x = 0, 宠物操作_y = 0;
                    dm.FindStrFast(1043, 403, 1141, 449, "宠物操作", "8A7F76-3E403C", 0.8, out 宠物操作_x, out 宠物操作_y);
                    if (宠物操作_x > 0)
                    {
                        dm.MoveTo(gameOperation.RandomNum(1200, 1250), gameOperation.RandomNum(420, 460));
                        dm.delay(1000);
                        dm.LeftClick();
                        dm.delay(1000);
                    }
                    //宠物出战
                    int 宠物出战_x = 0, 宠物出战_y = 0;
                    dm.FindStrFast(443, 660, 526, 696, "出战", "8A7F76-3E403C", 0.8, out 宠物出战_x, out 宠物出战_y);
                    if (宠物出战_x > 0)
                    {
                        dm.MoveTo(宠物出战_x + gameOperation.RandomNum(0, 40), 宠物出战_y + gameOperation.RandomNum(0, 20));
                        dm.delay(1000);
                        dm.LeftClick();
                        dm.delay(4000);
                    }
                }
                
                //召唤你的萌宠
                int 召唤你的萌宠x = 0, 召唤你的萌宠y = 0;
                dm.FindStrFast(29, 92, 293, 184, "召唤你的萌宠", "B5B7B5-4A484A", 0.8, out 召唤你的萌宠x, out 召唤你的萌宠y);
                if (召唤你的萌宠x>0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1187, 1210), gameOperation.RandomNum(285, 305));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    dm.MoveTo(gameOperation.RandomNum(1185, 1215), gameOperation.RandomNum(430, 455));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    dm.MoveTo(gameOperation.RandomNum(410, 550), gameOperation.RandomNum(660, 695));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //快上马
                int 快上马_x = 0, 快上马_y = 0;
                dm.FindStrFast(303, 519, 395, 552, "快上马", "8A7F76-3E403C", 0.8, out 快上马_x, out 快上马_y);
                if (快上马_x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(165, 230), gameOperation.RandomNum(510, 570));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //点击轻功按钮
                int 点击轻功按钮_x = 0, 点击轻功按钮_y = 0;
                dm.FindStrFast(811, 625, 963, 664, "点击轻功按钮", "D1C8B3-2D2D32", 0.8, out 点击轻功按钮_x, out 点击轻功按钮_y);
                if (点击轻功按钮_x > 0)
                {
                    dm.KeyPress(32);
                    dm.delay(1000);
                }
                //按住摇杆右
                int 按住摇杆右x = 0, 按住摇杆右y = 0;
                dm.FindStrFast(324, 484, 564, 570, "按住摇杆右推", "82786F-373834", 0.8, out 按住摇杆右x, out 按住摇杆右y);
                if (按住摇杆右x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(180, 215), gameOperation.RandomNum(525, 555));
                    dm.LeftDown();
                    while (true)
                    {
                        dm.MoveTo(gameOperation.RandomNum(330, 390), gameOperation.RandomNum(520, 560));
                        int 退出x = 0, 退出y = 0;
                        dm.FindStrFast(334, 505, 491, 571, "向上推摇杆", "FFFFE7-393E3B", 0.8, out 退出x, out 退出y);
                        if (退出x > 0)
                        {
                            dm.LeftUp();
                            break;
                        }
                        dm.delay(1000);
                    }

                }
                //向上推摇杆
                int 向上推摇杆x = 0, 向上推摇杆y = 0;
                dm.FindStrFast(350, 512, 468, 565, "向上推摇杆", "FFFFE7-393E3B", 0.8, out 向上推摇杆x, out 向上推摇杆y);
                if (向上推摇杆x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(180, 215), gameOperation.RandomNum(525, 555));
                    dm.LeftDown();
                    while (true)
                    {
                        dm.MoveTo(gameOperation.RandomNum(180, 220), gameOperation.RandomNum(400, 438));
                        int 退出x = 0, 退出y = 0;
                        dm.FindStrFast(1100, 25, 1215, 60, "跳过剧情", "eddcc6-122339", 0.8, out 退出x, out 退出y);
                        if (退出x > 0)
                        {
                            dm.LeftUp();
                            break;
                        }
                    }
                    dm.delay(1000);
                }
                //轻功一段跳
                int 轻功一段跳_x = 0, 轻功一段跳_y = 0;
                dm.FindStrFast(976, 624, 1121, 669, "轻功一段跳", "D1C8B3-2D2D32", 0.8, out 轻功一段跳_x, out 轻功一段跳_y);
                if (轻功一段跳_x > 0)
                {
                    dm.KeyPress(32);//空格
                    dm.delay(1000);
                    int 轻功二段跳x = 0, 轻功二段跳y = 0;
                    dm.FindStrFast(982, 629, 1115, 661, "轻功二段跳", "D1C8B3-2D2D32", 0.8, out 轻功二段跳x, out 轻功二段跳y);
                    if (轻功二段跳x > 0)
                    {
                        dm.KeyPress(32);
                        dm.delay(1000);
                    }
                }
                int 轻功落下x = 0, 轻功落下y = 0;
                dm.FindStrFast(640, 447, 744, 484, "轻功落下", "D1C8B3-2D2D32", 0.8, out 轻功落下x, out 轻功落下y);
                if (轻功落下x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(820, 865), gameOperation.RandomNum(445, 485));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                int 突破心境x = 0, 突破心境y = 0;
                dm.FindStrFast(1130, 599, 1240, 683, "突破心境", "F3DFD6-0C2029", 0.8, out 突破心境x, out 突破心境y);
                if (突破心境x > 0)
                {
                    dm.MoveTo(突破心境x + gameOperation.RandomNum(5, 50), 突破心境y - gameOperation.RandomNum(5, 40));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(3000);
                }
                //突破完成
                int 突破完成x = 0, 突破完成y = 0;
                dm.FindStrFast(1130, 599, 1240, 683, "突破完成", "FFFFE7-393E3B", 0.8, out 突破完成x, out 突破完成y);
                if (突破完成x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1215, 1235), gameOperation.RandomNum(15, 35));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //加入门派
                int 加入门派x = 0, 加入门派y = 0;
                dm.FindStrFast(1046, 499, 1219, 539, "加入门派", "F2CDB9-0C3239", 0.8, out 加入门派x, out 加入门派y);
                if (加入门派x > 0)
                {
                    dm.MoveTo(加入门派x + gameOperation.RandomNum(0, 60), 加入门派y + gameOperation.RandomNum(0, 25));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    //确定加入门派
                    int 确定加入x = 0, 确定加入y = 0;
                    dm.FindStrFast(652, 433, 813, 476, "确定加入", "8C7E6F-3D4335", 0.8, out 确定加入x, out 确定加入y);
                    if (确定加入x > 0)
                    {
                        dm.MoveTo(确定加入x + gameOperation.RandomNum(0, 60), 确定加入y + gameOperation.RandomNum(0, 25));
                        dm.delay(1000);
                        dm.LeftClick();
                        dm.delay(1000);
                    }
                }
                //进行宝石镶嵌
                int 进行宝石镶嵌x = 0, 进行宝石镶嵌y = 0;
                dm.FindStrFast(979, 283, 1151, 333, "进行宝石镶嵌", "D5D5D6-2A2A29", 0.8, out 进行宝石镶嵌x, out 进行宝石镶嵌y);
                if (进行宝石镶嵌x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1200, 1250), gameOperation.RandomNum(275, 315));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    dm.MoveTo(gameOperation.RandomNum(1365, 1410), gameOperation.RandomNum(520, 565));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    dm.MoveTo(gameOperation.RandomNum(1200, 1245), gameOperation.RandomNum(90, 130));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    dm.MoveTo(gameOperation.RandomNum(425, 485), gameOperation.RandomNum(512, 568));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //镶嵌宝石
                int 镶嵌宝石x = 0, 镶嵌宝石y = 0;
                dm.FindStrFast(72, 132, 145, 159, "镶嵌宝石", "CCCCCD-333332", 0.8, out 镶嵌宝石x, out 镶嵌宝石y);
                if (镶嵌宝石x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1200, 1250), gameOperation.RandomNum(275, 315));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    dm.MoveTo(gameOperation.RandomNum(1365, 1410), gameOperation.RandomNum(520, 565));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    dm.MoveTo(gameOperation.RandomNum(150, 320), gameOperation.RandomNum(235, 295));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    dm.MoveTo(gameOperation.RandomNum(917, 970), gameOperation.RandomNum(305, 360));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    dm.MoveTo(gameOperation.RandomNum(815, 900), gameOperation.RandomNum(455, 480));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    dm.MoveTo(gameOperation.RandomNum(430, 480), gameOperation.RandomNum(515, 565));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //展开功能菜单
                int 展开功能菜单x = 0, 展开功能菜单y = 0;
                dm.FindStrFast(883, 255, 1151, 335, "展开功能菜单", "81766E-353733", 0.8, out 展开功能菜单x, out 展开功能菜单y);
                if (展开功能菜单x > 0)
                {
                    dm.KeyPress(112);
                    dm.delay(1000);
                }
                //点击强化按钮
                int 点击强化按钮2x = 0, 点击强化按钮2y = 0;
                dm.FindStrFast(786, 343, 929, 383, "强化按钮1", "827870-373935", 0.8, out 点击强化按钮2x, out 点击强化按钮2y);
                if (点击强化按钮2x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1045, 1090), gameOperation.RandomNum(345, 385));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(2000);
                }
                //指定的装备
                int 指定的装备x = 0, 指定的装备y = 0;
                dm.FindStrFast(495, 215, 620, 248, "指定的装备", "8F857C-434641", 0.8, out 指定的装备x, out 指定的装备y);
                if (指定的装备x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(135, 315), gameOperation.RandomNum(205, 260));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //升级的宝石
                int 升级的宝石x = 0, 升级的宝石y = 0;
                dm.FindStrFast(530, 208, 665, 248, "升级的宝石", "8F857C-434641", 0.8, out 升级的宝石x, out 升级的宝石y);
                if (升级的宝石x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(560, 610), gameOperation.RandomNum(100, 145));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //点击升级
                int 点击升级x = 0, 点击升级y = 0;
                dm.FindStrFast(840, 527, 945, 560, "点击升级", "8F857C-434641", 0.8, out 点击升级x, out 点击升级y);
                if (点击升级x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(895, 1000), gameOperation.RandomNum(660, 695));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    //关闭打开的窗口
                    dm.KeyPress(77);
                    dm.delay(1000);
                }                
                //选择要镶嵌
                int 选择要镶嵌x = 0, 选择要镶嵌y = 0;
                dm.FindStrFast(406, 226, 546, 290, "选择要镶嵌", "FFFFE7-393E3B", 0.8, out 选择要镶嵌x, out 选择要镶嵌y);
                if (选择要镶嵌x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(55, 340), gameOperation.RandomNum(225, 305));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //选择对应属性
                int 选择对应属性x = 0, 选择对应属性y = 0;
                dm.FindStrFast(808, 413, 971, 467, "选择对应属性", "FFFFE7-393E3B", 0.8, out 选择对应属性x, out 选择对应属性y);
                if (选择对应属性x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(915, 975), gameOperation.RandomNum(305, 360));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //选择不同的宝
                int 选择不同的宝x = 0, 选择不同的宝y = 0;
                dm.FindStrFast(763, 339, 926, 396, "选择不同的宝", "FFFFE7-393E3B", 0.8, out 选择不同的宝x, out 选择不同的宝y);
                if (选择不同的宝x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(808, 908), gameOperation.RandomNum(450, 490));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //点击宝石即可
                int 点击宝石即可x = 0, 点击宝石即可y = 0;
                dm.FindStrFast(374, 383, 484, 438, "点击宝石", "8E867C-434642", 0.8, out 点击宝石即可x, out 点击宝石即可y);
                if (点击宝石即可x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(430, 480), gameOperation.RandomNum(515, 565));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //选择宝石
                int 选择宝石x = 0, 选择宝石y = 0;
                dm.FindStrFast(347, 381, 441, 414, "选择宝石", "FFFFE7-393E3B", 0.8, out 选择宝石x, out 选择宝石y);
                if (选择宝石x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(420, 500), gameOperation.RandomNum(500, 580));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(2000);
                    //关闭镶嵌面板
                    dm.KeyPress(77);
                    dm.delay(1000);
                }
                //打开武学界面
                int 打开武学界面x = 0, 打开武学界面y = 0;
                dm.FindStrFast(857, 420, 1014, 459, "打开武学界面", "81786F-363835", 0.8, out 打开武学界面x, out 打开武学界面y);
                if (打开武学界面x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1125, 1170), gameOperation.RandomNum(425, 460));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //一键升级
                int 一键升级x = 0, 一键升级y = 0;
                dm.FindStrFast(176, 621, 327, 665, "一键升级", "FFFFE7-393E3B", 0.8, out 一键升级x, out 一键升级y);
                if (一键升级x > 0)
                {
                    dm.MoveTo(一键升级x + gameOperation.RandomNum(0, 50), 一键升级y + gameOperation.RandomNum(0, 30));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    int 确定1x = 0, 确定1y = 0;
                    dm.FindStrFast(663, 421, 806, 461, "确定", "FFFFE7-393E3B", 0.8, out 确定1x, out 确定1y);
                    if (确定1x > 0)
                    {
                        dm.MoveTo(确定1x + gameOperation.RandomNum(0, 50), 确定1y + gameOperation.RandomNum(0, 30));
                        dm.delay(1000);
                        dm.LeftClick();
                        dm.delay(1000);
                        dm.KeyPress(77);
                        dm.delay(1000);
                    }
                }
                //打开功能菜单
                int 打开功能菜单x = 0, 打开功能菜单y = 0;
                dm.FindStrFast(979, 283, 1151, 333, "打开功能菜单", "898079-3E403F", 0.8, out 打开功能菜单x, out 打开功能菜单y);
                if (打开功能菜单x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1200, 1250), gameOperation.RandomNum(275, 315));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }

                //怨念棋魂
                //int 怨念棋魂x = 0, 怨念棋魂y = 0;
                //dm.FindStrFast(838, 633, 955, 689, "怨念棋魂", "FFFFE7-393E3B", 0.8, out 怨念棋魂x, out 怨念棋魂y);
                //if (怨念棋魂x > 0)
                //{
                //    dm.KeyPress(49);
                //}
                //前往充值
                int 前往充值x = 0, 前往充值y = 0;
                dm.FindStrFast(1003, 604, 1108, 634, "前往充值", "978C7B-474D40", 0.8, out 前往充值x, out 前往充值y);
                if (前往充值x > 0)
                {
                    dm.KeyPress(27);
                    dm.delay(1000);
                    //再玩会
                    int 再玩会_x = 0, 再玩会_y = 0;
                    dm.FindStrFast(716, 538, 787, 571, "再玩会", "39300C-39310C", 0.8, out 再玩会_x, out 再玩会_y);
                    if (再玩会_x > 0)
                    {
                        dm.MoveToEx(再玩会_x, 再玩会_y, 50, 20);
                        dm.delay(1000);
                        dm.LeftClick();
                        dm.delay(1000);
                    }
                    dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
                    dm.LeftClick();
                    dm.delay(1000);
                    dm.KeyPress(27);
                    dm.delay(1000);
                    //再玩会
                    int 再玩会1_x = 0, 再玩会1_y = 0;
                    dm.FindStrFast(716, 538, 787, 571, "再玩会", "39300C-39310C", 0.8, out 再玩会1_x, out 再玩会1_y);
                    if (再玩会1_x > 0)
                    {
                        dm.MoveToEx(再玩会1_x, 再玩会1_y, 50, 20);
                        dm.delay(1000);
                        dm.LeftClick();
                        dm.delay(1000);
                    }
                    dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //召唤雕儿
                int 召唤雕儿x = 0, 召唤雕儿y = 0;
                dm.FindStrFast(1036, 587, 1172, 617, "召唤雕儿", "FFFFE7-393E3B", 0.8, out 召唤雕儿x, out 召唤雕儿y);
                if (召唤雕儿x > 0)
                {
                    dm.MoveTo(召唤雕儿x + gameOperation.RandomNum(0, 60), 召唤雕儿y + gameOperation.RandomNum(0, 20));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //召唤
                int 召唤x = 0, 召唤y = 0;
                dm.FindStrFast(1025, 581, 1168, 624, "召唤", "5F5954-605A55", 0.8, out 召唤x, out 召唤y);
                if (召唤x > 0)
                {
                    dm.MoveTo(召唤x + gameOperation.RandomNum(0, 60), 召唤y + gameOperation.RandomNum(0, 20));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
              
                int 第一个装备x = 0, 第一个装备y = 0;
                dm.FindStrFast(984, 111, 1107, 144, "第一个装备", "FFFFE7-393E3B", 0.8, out 第一个装备x, out 第一个装备y);
                if (第一个装备x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1200, 1260), gameOperation.RandomNum(80, 125));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                
                //天龙首礼
                int 天龙首礼x = 0, 天龙首礼y = 0;
                dm.FindStrFast(1102, 203, 1201, 305, "天龙首礼", "EFD3C6-102B32", 0.8, out 天龙首礼x, out 天龙首礼y);
                if (天龙首礼x > 0)
                {
                    dm.KeyPress(77);
                    dm.delay(500);
                }
                //打开活动主界
                int 打开活动主界x = 0, 打开活动主界y = 0;
                dm.FindStrFast(1011, 215, 1157, 253, "打开活动主界", "81786F-363835", 0.8, out 打开活动主界x, out 打开活动主界y);
                if (打开活动主界x > 0)
                {
                    dm.KeyPress(72);
                    dm.delay(500);
                    while (true)
                    {
                        //打开问剑侠义
                        int 打开问剑侠义x = 0, 打开问剑侠义y = 0;
                        dm.FindStrFast(345, 260, 514, 309, "打开问剑侠义", "FFFFE7-393E3B", 0.8, out 打开问剑侠义x, out 打开问剑侠义y);
                        if (打开问剑侠义x > 0)
                        {
                            dm.MoveTo(gameOperation.RandomNum(175, 465), gameOperation.RandomNum(105, 205));
                            dm.delay(1000);
                            dm.LeftClick();
                            dm.delay(1000);
                        }
                        //前往活动
                        int 前往活动x = 0, 前往活动y = 0;
                        dm.FindStrFast(819, 543, 943, 582, "前往活动", "948171-434538", 0.8, out 前往活动x, out 前往活动y);
                        if (前往活动x > 0)
                        {
                            dm.MoveTo(前往活动x + gameOperation.RandomNum(0, 50), 前往活动y + gameOperation.RandomNum(0, 20));
                            dm.delay(1000);
                            dm.LeftClick();
                            dm.delay(1000);
                           
                        }
                        //点击挑战按钮
                        int 点击挑战按钮x = 0, 点击挑战按钮y = 0;
                        dm.FindStrFast(416, 564, 574, 614, "点击挑战按钮", "FFFFE7-393E3B", 0.8, out 点击挑战按钮x, out 点击挑战按钮y);
                        if (点击挑战按钮x > 0)
                        {
                            dm.MoveTo(gameOperation.RandomNum(305, 340), gameOperation.RandomNum(587, 626));
                            dm.delay(1000);
                            dm.LeftClick();
                            dm.delay(1000);
                        }
                        //挑战
                        int 挑战x = 0, 挑战y = 0;
                        dm.FindStrFast(1050, 585, 1148, 622, "挑战", "9A8A82-454C47", 0.8, out 挑战x, out 挑战y);
                        if (挑战x > 0)
                        {
                            dm.MoveTo(挑战x + gameOperation.RandomNum(0, 50), 挑战y + gameOperation.RandomNum(0, 25));
                            dm.delay(1000);
                            dm.LeftClick();
                            dm.delay(1000);
                            break;
                        }
                    }
                   
                }
                int 挑战1x = 0, 挑战1y = 0;
                dm.FindStrFast(1050, 585, 1148, 622, "挑战", "9A8A82-454C47", 0.8, out 挑战1x, out 挑战1y);
                if (挑战1x > 0)
                {
                    dm.MoveTo(挑战1x + gameOperation.RandomNum(0, 50), 挑战1y + gameOperation.RandomNum(0, 25));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //打开刻铭todo
                int 打开刻铭x = 0, 打开刻铭y = 0;
                dm.FindStrFast(1025, 161, 1141, 213, "打开刻铭", "FFFFE7-393E3B", 0.8, out 打开刻铭x, out 打开刻铭y);
                if (打开刻铭x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1208, 1250), gameOperation.RandomNum(170, 205));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //选择需要刻铭
                int 选择需要刻铭x = 0, 选择需要刻铭y = 0;
                dm.FindStrFast(418, 203, 579, 259, "选择需要刻铭", "FFFFE7-393E3B", 0.8, out 选择需要刻铭x, out 选择需要刻铭y);
                if (打开刻铭x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(60, 340), gameOperation.RandomNum(205, 260));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //刻铭
                int 刻铭x = 0, 刻铭y = 0;
                dm.FindStrFast(1013, 650, 1086, 686, "刻铭", "FFFFE7-393E3B", 0.8, out 刻铭x, out 刻铭y);
                if (刻铭x > 0)
                {
                    dm.MoveTo(刻铭x + gameOperation.RandomNum(0, 50), 刻铭y + gameOperation.RandomNum(0, 20));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    dm.MoveTo(gameOperation.RandomNum(1215, 1235), gameOperation.RandomNum(15, 35));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //进入主界面
                int 进入主界面x = 0, 进入主界面y = 0;
                dm.FindStrFast(876, 321, 996, 378, "进入主界面", "FFFFE7-393E3B", 0.8, out 进入主界面x, out 进入主界面y);
                if (进入主界面x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1045, 1090), gameOperation.RandomNum(340, 385));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                ////前往二楼
                int 前往二楼x = 0, 前往二楼y = 0;
                dm.FindStrFast(1026, 578, 1174, 631, "前往二楼", "FFFFE7-393E3B", 0.9, out 前往二楼x, out 前往二楼y);
                if (前往二楼x > 0)
                {
                    dm.MoveTo(前往二楼x + gameOperation.RandomNum(0, 50), 前往二楼y + gameOperation.RandomNum(0, 25));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //前往二楼1
                int 前往二楼1x = 0, 前往二楼1y = 0;
                dm.FindStrFast(1036, 584, 1161, 624, "前往二楼", "94817A-3C413E", 0.8, out 前往二楼1x, out 前往二楼1y);
                if (前往二楼1x > 0)
                {
                    dm.MoveTo(前往二楼1x + gameOperation.RandomNum(0, 50), 前往二楼1y + gameOperation.RandomNum(0, 25));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //坐下
                int 坐下x = 0, 坐下y = 0;
                dm.FindStrFast(817, 458, 863, 486, "坐下", "D0CFCE-28292A", 0.8, out 坐下x, out 坐下y);
                if (坐下x > 0)
                {
                    dm.MoveTo(坐下x + gameOperation.RandomNum(0, 30), 坐下y - gameOperation.RandomNum(0, 20));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                int 点菜x = 0, 点菜y = 0;
                //dm.FindStrFast(980, 21, 1051, 83, "点菜", "FFFFE7-393E3B", 0.8, out 点菜x, out 点菜y);
                dm.FindStrFast(938, 29, 1044, 72, "开始点菜", "CAC2AE-343336", 0.8, out 点菜x, out 点菜y);
                if (点菜x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1110, 1170), gameOperation.RandomNum(25, 75));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //选择菜品
                int 选择菜品x = 0, 选择菜品y = 0;
                dm.FindStrFast(914, 94, 1130, 142, "选择菜品", "FFFFE7-393E3B", 0.8, out 选择菜品x, out 选择菜品y);
                if (选择菜品x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1190, 1240), gameOperation.RandomNum(100, 145));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    dm.MoveTo(gameOperation.RandomNum(1190, 1240), gameOperation.RandomNum(195, 235));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    dm.MoveTo(gameOperation.RandomNum(1190, 1240), gameOperation.RandomNum(295, 345));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    //下单
                    dm.MoveTo(gameOperation.RandomNum(1035, 1155), gameOperation.RandomNum(605, 645));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                   
                }

                //下单
                int 下单x = 0, 下单y = 0;
                dm.FindStrFast(1056, 606, 1137, 646, "下单", "908270-3D4233", 0.8, out 下单x, out 下单y);
                if (下单x > 0)
                {
                    dm.MoveTo(下单x + gameOperation.RandomNum(0, 60), 下单y + gameOperation.RandomNum(0, 20));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //点击确认下单
                int 点击确认下单x = 0, 点击确认下单y = 0;
                dm.FindStrFast(357, 483, 524, 534, "点击确认下单", "CBC1AD-333436", 0.8, out 点击确认下单x, out 点击确认下单y);
                if (点击确认下单x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(550, 690), gameOperation.RandomNum(490, 530));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //上菜
                int 上菜x = 0, 上菜y = 0;
                dm.FindStrFast(585, 492, 656, 528, "上菜", "887A67-373C2D", 0.8, out 上菜x, out 上菜y);
                if (上菜x > 0)
                {
                    dm.MoveTo(上菜x + gameOperation.RandomNum(0, 60), 上菜y + gameOperation.RandomNum(0, 25));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    while (true)
                    {
                        dm.KeyPress(27);
                        dm.delay(1000);
                        //再玩会
                        int 再玩会_x = 0, 再玩会_y = 0;
                        dm.FindStrFast(716, 538, 787, 571, "再玩会", "39300C-39310C", 0.8, out 再玩会_x, out 再玩会_y);
                        if (再玩会_x > 0)
                        {
                            dm.MoveToEx(再玩会_x, 再玩会_y, 50, 20);
                            dm.delay(1000);
                            dm.LeftClick();
                            dm.delay(1000);
                        }
                        dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
                        dm.LeftClick();
                        dm.delay(1000);
                        dm.LeftClick();
                        dm.delay(1000);
                        //吃对应的菜品
                        int 吃对应的菜品x = 0, 吃对应的菜品y = 0;
                        dm.FindStrFast(357, 483, 524, 534, "吃对应的菜品", "CBC1AD-333436", 0.8, out 吃对应的菜品x, out 吃对应的菜品y);
                        if (吃对应的菜品x > 0)
                        {
                            dm.MoveTo(gameOperation.RandomNum(1045, 1095), gameOperation.RandomNum(540, 590));
                            dm.delay(1000);
                            dm.LeftClick();
                            dm.delay(1000);
                        }
                        //点餐
                        int 点餐x = 0, 点餐y = 0;
                        dm.FindPic(1112, 28, 1167, 75, "\\img\\diancan.bmp", "000000", 0.8, 0, out 点餐x, out 点餐y);
                        if (点餐x > 0)
                        {
                            dm.MoveTo(点餐x + gameOperation.RandomNum(0, 10), 点餐y + gameOperation.RandomNum(0, 10));
                            dm.delay(1000);
                            dm.LeftClick();
                            dm.delay(1000);
                        }
                        //判断食量是否满足
                        int 满足标志x = 0, 满足标志y = 0;
                        dm.FindPic(576, 646, 622, 678, "\\img\\zhuxianmanzu.bmp", "000000", 0.8, 0, out 满足标志x, out 满足标志y);
                        if (满足标志x>0)
                        {
                            dm.KeyPress(27);
                            dm.delay(1000);
                            //再玩会
                            int 再玩会1_x = 0, 再玩会1_y = 0;
                            dm.FindStrFast(716, 538, 787, 571, "再玩会", "39300C-39310C", 0.8, out 再玩会1_x, out 再玩会1_y);
                            if (再玩会1_x > 0)
                            {
                                dm.MoveToEx(再玩会_x, 再玩会_y, 50, 20);
                                dm.delay(1000);
                                dm.LeftClick();
                                dm.delay(1000);
                            }
                            dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
                            dm.LeftClick();
                            dm.delay(1000);
                            dm.LeftClick();
                            dm.delay(1000);
                            dm.MoveTo(gameOperation.RandomNum(1030, 1065), gameOperation.RandomNum(135, 168));
                            dm.LeftClick();
                            dm.delay(1000);
                            dm.LeftClick();
                            dm.delay(1000);
                            break;
                        }
                        dm.delay(1000);
                    }
                }
                //离开饭桌
                int 离开饭桌x = 0, 离开饭桌y = 0;
                dm.FindStrFast(834, 112, 960, 180, "离开饭桌", "CBC1AD-333436", 0.8, out 离开饭桌x, out 离开饭桌y);
                if (离开饭桌x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1020, 1075), gameOperation.RandomNum(125, 170));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }                
                //离开饭馆
                int 离开饭馆x = 0, 离开饭馆y = 0;
                dm.FindStrFast(786, 486, 929, 537, "离开饭馆", "AD9388-4F4D49", 0.8, out 离开饭馆x, out 离开饭馆y);
                if (离开饭馆x > 0)
                {
                    dm.MoveTo(离开饭馆x + gameOperation.RandomNum(0, 50), 离开饭馆y + gameOperation.RandomNum(0, 20));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    dm.MoveTo(gameOperation.RandomNum(670, 800), gameOperation.RandomNum(425, 460));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //打开背包界面
                int 打开背包界面x = 0, 打开背包界面y = 0;
                dm.FindStrFast(956, 337, 1118, 388, "打开背包界面", "887D74-3C3E3A", 0.8, out 打开背包界面x, out 打开背包界面y);
                if (打开背包界面x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1200, 1250), gameOperation.RandomNum(340, 380));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //分解（坐标需要重新定位）
                int 分解x = 0, 分解y = 0;
                dm.FindStrFast(875, 642, 998, 688, "分解", "887D74-3C3E3A", 0.8, out 分解x, out 分解y);
                if (分解x > 0)
                {
                    dm.MoveTo(分解x + gameOperation.RandomNum(0, 50), 分解y + gameOperation.RandomNum(0, 20));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //一键分解
                int 一键分解x = 0, 一键分解y = 0;
                dm.FindStrFast(321, 542, 463, 585, "分解", "857C6C-4F5344", 0.8, out 一键分解x, out 一键分解y);
                if (一键分解x > 0)
                {
                    dm.MoveTo(一键分解x + gameOperation.RandomNum(0, 50), 一键分解y + gameOperation.RandomNum(0, 20));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    //关闭打开的窗口
                    dm.KeyPress(27);
                    dm.delay(1000);
                    //再玩会
                    int 再玩会_x = 0, 再玩会_y = 0;
                    dm.FindStrFast(716, 538, 787, 571, "再玩会", "39300C-39310C", 0.8, out 再玩会_x, out 再玩会_y);
                    if (再玩会_x > 0)
                    {
                        dm.MoveToEx(再玩会_x, 再玩会_y, 50, 20);
                        dm.delay(1000);
                        dm.LeftClick();
                        dm.delay(1000);
                    }
                    dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
                    dm.LeftClick();
                    dm.delay(1000);
                    //关闭打开的窗口
                    dm.KeyPress(77);
                    dm.delay(600);
                }
                //强烈推荐
                int 强烈推荐x = 0, 强烈推荐y = 0;
                dm.FindStrFast(285, 100, 383, 137, "强烈推荐", "E4C8C7-1B3738", 0.8, out 强烈推荐x, out 强烈推荐y);
                if (强烈推荐x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(175, 470), gameOperation.RandomNum(130, 215));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                int 关闭x = 0, 关闭y = 0;
                dm.FindPic(974, 5, 1274, 220, "\\img\\guanbi.bmp", "000000", 0.8, 0, out 关闭x, out 关闭y);
                if (关闭x > 0)
                {
                    dm.KeyPress(77);
                    dm.delay(600);
                }
                //批量使用
                int 批量使用x = 0, 批量使用y = 0;
                dm.FindStrFast(905, 410, 1032, 459, "批量使用", "EAD4D0-152B2F", 0.8, out 批量使用x, out 批量使用y);
                if (批量使用x > 0)
                {
                    dm.MoveTo(批量使用x + gameOperation.RandomNum(0, 60), 批量使用y + gameOperation.RandomNum(0, 30));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //进入副本
                int 进入副本x = 0, 进入副本y = 0;
                dm.FindStrFast(1037, 584, 1155, 621, "进入副本", "988780-424944", 0.8, out 进入副本x, out 进入副本y);
                if (进入副本x > 0)
                {
                    dm.MoveTo(进入副本x + gameOperation.RandomNum(0, 30), 进入副本y + gameOperation.RandomNum(0, 20));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //背包界面
                int 背包界面x = 0, 背包界面y = 0;
                dm.FindStrFast(1012, 340, 1116, 386, "背包界面", "8E847B-424441", 0.8, out 背包界面x, out 背包界面y);
                if (背包界面x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1208, 1243), gameOperation.RandomNum(345, 380));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //捕捉灵宠
                int 捕捉灵宠x = 0, 捕捉灵宠y = 0;
                dm.FindStrFast(717, 388, 820, 420, "捕捉灵宠", "877D74-3C3D39", 0.8, out 捕捉灵宠x, out 捕捉灵宠y);
                if (捕捉灵宠x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(905, 945), gameOperation.RandomNum(390, 425));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(4000);
                }
                //饲育小猴王
                int 饲育小猴王x = 0, 饲育小猴王y = 0;
                dm.FindStrFast(1021, 586, 1173, 624, "饲育小猴王", "95847D-3F4541", 0.8, out 饲育小猴王x, out 饲育小猴王y);
                if (饲育小猴王x > 0)
                {
                    dm.MoveTo(饲育小猴王x + gameOperation.RandomNum(0, 30), 饲育小猴王y + gameOperation.RandomNum(0, 20));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }

                //放入小猴王
                int 放入小猴王x = 0, 放入小猴王y = 0;
                dm.FindStrFast(530, 199, 653, 230, "放入小猴王", "998F86-4E504B", 0.8, out 放入小猴王x, out 放入小猴王y);
                if (放入小猴王x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(200, 430), gameOperation.RandomNum(180, 250));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //锁定
                int 锁定x = 0, 锁定y = 0;
                dm.FindPic(715, 502, 762, 545, "\\img\\suoding.bmp", "000000", 0.8, 0, out 锁定x, out 锁定y);
                if (锁定x > 0)
                {
                    dm.MoveTo(锁定x + gameOperation.RandomNum(0, 10), 锁定y + gameOperation.RandomNum(0, 10));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //繁殖
                int 繁殖x = 0, 繁殖y = 0;
                dm.FindStrFast(770, 601, 849, 633, "繁殖", "968975-494E3D", 0.8, out 繁殖x, out 繁殖y);
                if (繁殖x > 0)
                {
                    dm.MoveTo(繁殖x + gameOperation.RandomNum(0, 10), 繁殖y + gameOperation.RandomNum(0, 10));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(3000);
                }
                //领取繁殖宠物
                int 领取繁殖宠物x = 0, 领取繁殖宠物y = 0;
                dm.FindPic(565, 449, 619, 504, "\\img\\lingqufanzhicongwu.bmp", "000000", 0.8, 0, out 领取繁殖宠物x, out 领取繁殖宠物y);
                if (领取繁殖宠物x > 0)
                {
                    dm.MoveTo(领取繁殖宠物x + gameOperation.RandomNum(0, 50), 领取繁殖宠物y + gameOperation.RandomNum(0, 20));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //获得
                int 获得x = 0, 获得y = 0;
                dm.FindStrFast(589, 92, 687, 130, "获得", "E6D1CA-192D31", 0.8, out 获得x, out 获得y);
                if (获得x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1110, 1130), gameOperation.RandomNum(60, 80));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //打开
                int 打开x = 0, 打开y = 0;
                dm.FindPic(891, 388, 963, 447, "\\img\\dakai.bmp", "000000", 0.8, 0, out 打开x, out 打开y);
                if (打开x > 0)
                {
                    dm.MoveTo(打开x + gameOperation.RandomNum(0, 20), 打开y + gameOperation.RandomNum(0, 10));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(5000);
                }
                
                //打开功能界面
                int 打开功能界面x = 0, 打开功能界面y = 0;
                dm.FindStrFast(978, 274, 1120, 310, "打开功能界面", "867D75-3A3D3A", 0.8, out 打开功能界面x, out 打开功能界面y);
                if (打开功能界面x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1205, 1245), gameOperation.RandomNum(277, 315));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    dm.MoveTo(gameOperation.RandomNum(1130, 1170), gameOperation.RandomNum(500, 545));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //打开绝学界面
                int 打开绝学界面x = 0, 打开绝学界面y = 0;
                dm.FindStrFast(899, 503, 1048, 538, "打开绝学界面", "90867E-444643", 0.8, out 打开绝学界面x, out 打开绝学界面y);
                if (打开绝学界面x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1125, 1170), gameOperation.RandomNum(500, 540));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //前往获取
                int 前往获取x = 0, 前往获取y = 0;
                dm.FindStrFast(832, 653, 963, 695, "前往获取", "88715C-3C3625", 0.8, out 前往获取x, out 前往获取y);
                if (前往获取x > 0)
                {
                    dm.MoveTo(前往获取x + gameOperation.RandomNum(0, 50), 前往获取y + gameOperation.RandomNum(0, 20));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //参悟一次
                int 参悟一次x = 0, 参悟一次y = 0;
                dm.FindStrFast(357, 599, 486, 639, "参悟一次", "8F7662-3E3927", 0.8, out 参悟一次x, out 参悟一次y);
                if (参悟一次x > 0)
                {
                    dm.MoveTo(参悟一次x + gameOperation.RandomNum(0, 50), 参悟一次y + gameOperation.RandomNum(0, 20));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //道具不足
                int 道具不足x = 0, 道具不足y = 0;
                dm.FindStrFast(493, 276, 617, 308, "道具不足", "857C75-393C3B", 0.8, out 道具不足x, out 道具不足y);
                if (道具不足x > 0)
                {
                    //关闭打开的窗口
                    gameOperation.CloseDialog();
                    gameOperation.CloseDialog();
                }
                
                //姿态切换
                int 姿态切换x = 0, 姿态切换y = 0;
                dm.FindStrFast(575, 95, 705, 135, "姿态切换", "9D927B-322E27", 0.8, out 姿态切换x, out 姿态切换y);
                if (姿态切换x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1117, 1135), gameOperation.RandomNum(148, 168));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);

                }
                //进行疗伤
                int 进行疗伤x = 0, 进行疗伤y = 0;
                dm.FindStrFast(850, 430, 958, 475, "进行疗伤", "90867E-444643", 0.8, out 进行疗伤x, out 进行疗伤y);
                if (进行疗伤x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1030, 1070), gameOperation.RandomNum(435, 475));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(200);
                    dm.LeftClick();
                    dm.delay(200);
                    dm.LeftClick();
                    dm.delay(200);
                    dm.LeftClick();
                    dm.delay(200);
                    dm.LeftClick();
                    dm.delay(200);
                    dm.LeftClick();
                    dm.delay(200);
                    dm.LeftClick();
                    dm.delay(200);
                    dm.LeftClick();
                    dm.delay(200);
                    dm.LeftClick();
                    dm.delay(200);
                    dm.LeftClick();
                    dm.delay(200);
                    dm.LeftClick();
                    dm.delay(200);
                    dm.LeftClick();
                    dm.delay(200);
                    dm.LeftClick();
                    dm.delay(200);
                }
                //释放绝招
                int 释放绝招x = 0, 释放绝招y = 0;
                dm.FindStrFast(830, 336, 938, 370, "释放绝招", "90867E-444643", 0.8, out 释放绝招x, out 释放绝招y);
                if (释放绝招x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1000, 1040), gameOperation.RandomNum(340, 370));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //升级
                int 升级x = 0, 升级y = 0;
                dm.FindStrFast(898, 653, 996, 696, "升级", "6b6350-6C6351", 0.8, out 升级x, out 升级y);
                if (升级x > 0)
                {
                    dm.MoveTo(升级x + gameOperation.RandomNum(0, 30), 升级y + gameOperation.RandomNum(0, 20));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    dm.MoveTo(gameOperation.RandomNum(550, 680), gameOperation.RandomNum(630, 665));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    dm.delay(1000);
                    //关闭打开的窗口
                    dm.KeyPress(77);
                    dm.delay(500);
                }
                //假装同意
                int 假装同意x = 0, 假装同意y = 0;
                dm.FindStrFast(915, 283, 1047, 320, "假装同意", "656057-666158", 0.8, out 假装同意x, out 假装同意y);
                if (假装同意x > 0)
                {
                    dm.MoveToEx(假装同意x, 假装同意y, 50, 10);
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //姑娘聪慧
                int 姑娘聪慧x = 0, 姑娘聪慧y = 0;
                dm.FindStrFast(918, 351, 1040, 388, "姑娘聪慧", "8F8079-3E423E", 0.8, out 姑娘聪慧x, out 姑娘聪慧y);
                if (姑娘聪慧x > 0)
                {
                    dm.MoveToEx(姑娘聪慧x, 姑娘聪慧y, 50, 10);
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //听说王夫人
                int 听说王夫人x = 0, 听说王夫人y = 0;
                dm.FindStrFast(922, 349, 1058, 388, "听说王夫人", "8F8079-3E423E", 0.8, out 听说王夫人x, out 听说王夫人y);
                if (听说王夫人x > 0)
                {
                    dm.MoveToEx(听说王夫人x, 听说王夫人y, 50, 10);
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //反击
                int 反击x = 0, 反击y = 0;
                dm.FindStrFast(923, 217, 985, 252, "反击", "88734D-363A4C", 0.8, out 反击x, out 反击y);
                if (反击x > 0)
                {
                    dm.MoveToEx(反击x, 反击y, 10, 10);
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //讥讽李延宗
                int 讥讽李延宗x = 0, 讥讽李延宗y = 0;
                dm.FindStrFast(919, 352, 1059, 382, "讥讽李延宗", "897A73-383D38", 0.8, out 讥讽李延宗x, out 讥讽李延宗y);
                if (讥讽李延宗x > 0)
                {
                    dm.MoveToEx(讥讽李延宗x, 讥讽李延宗y, 10, 10);
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //燕子坞
                int 燕子坞x = 0, 燕子坞y = 0;
                dm.FindStrFast(199, 119, 263, 159, "子坞", "7E695F-312E26", 0.8, out 燕子坞x, out 燕子坞y); 
                if (燕子坞x > 0)
                {
                    dm.MoveToEx(燕子坞x, 燕子坞y, 80, 50);
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    while (true)
                    {
                        int 前往活动x = 0, 前往活动y = 0;
                        dm.FindStrFast(807, 542, 958, 584, "前往活动", "9C8C89-4A504F", 0.8, out 前往活动x, out 前往活动y);
                        if (前往活动x > 0)
                        {
                            dm.MoveToEx(前往活动x, 前往活动y, 30, 20);
                            dm.delay(1000);
                            dm.LeftClick();
                            dm.delay(2000);
                            //创建队伍
                            dm.MoveTo(gameOperation.RandomNum(480, 605), gameOperation.RandomNum(425, 455));
                            dm.delay(1000);
                            dm.LeftClick();
                            dm.delay(2000);
                            //我的队伍
                            dm.MoveTo(gameOperation.RandomNum(1175, 1275), gameOperation.RandomNum(350, 415));
                            dm.delay(1000);
                            dm.LeftClick();
                            dm.delay(2000);
                            //自动匹配
                            dm.MoveTo(gameOperation.RandomNum(975, 1120), gameOperation.RandomNum(645, 680));
                            dm.delay(1000);
                            dm.LeftClick();
                            dm.delay(2000);
                            while (true)
                            {
                                //确定雇佣系统侠士
                                int 确定雇佣x = 0, 确定雇佣y = 0;
                                dm.FindStrFast(699, 426, 796, 459, "确定", "978A77-424739", 0.8, out 确定雇佣x, out 确定雇佣y);
                                if (确定雇佣x > 0)
                                {
                                    dm.MoveTo(确定雇佣x + gameOperation.RandomNum(0, 30), 确定雇佣y + gameOperation.RandomNum(0, 20));
                                    dm.delay(1000);
                                    dm.LeftClick();
                                    dm.delay(1000);

                                }
                                int 离开副本x = 0, 离开副本y = 0;
                                dm.FindStrFast(771, 567, 894, 600, "离开副本", "6B6A68-6C6A68", 0.8, out 离开副本x, out 离开副本y);
                                if (离开副本x > 0)
                                {
                                    break;
                                }
                            }
                            break;
                        }
                    }
                    
                }
                //计算任务运行时间
                DateTime now= DateTime.Now;
                var span = (now - strartTime).TotalMinutes;
                double limitimes = double.Parse(user.MainLineLimitTime.ToString());
                if (span>= limitimes)
                {
                    break;
                }
            }
        }
    }
}
