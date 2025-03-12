using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace senke
{
    /// <summary>
    /// 主线1-10级
    /// </summary>
    public class MainLineTen
    {
        public GameOperation gameOperation { get; set; }
        public UserItem user { get; set; }
        public dmsoft dm { get; set; }
        public MainLineTen(dmsoft dm, UserItem user)
        {
            gameOperation = new GameOperation(dm);
            this.user = user;
            this.dm = dm;
        }
        public void DoWork() 
        {
            dm.UseDict(3);
            dm.delay(1000);
            while (true)
            {
                dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(10, 10));
                dm.delay(1000);
                dm.LeftClick();
                dm.delay(600);
                int 跳过剧情x = 0, 跳过剧情y = 0;
                dm.FindStrFast(1100, 25, 1215, 60, "跳过剧情", "eddcc6-122339", 0.8, out 跳过剧情x, out 跳过剧情y);
                if (跳过剧情x > 0)
                {
                    dm.KeyPress(77);//跳过动画
                    dm.delay(1000);
                    int 跳过动画x = 0, 跳过动画y = 0;
                    dm.FindStrFast(664, 422, 804, 461, "确定跳过动画", "978A77-424739", 0.8, out 跳过动画x, out 跳过动画y);
                    if (跳过动画x > 0)
                    {
                        dm.MoveTo(跳过动画x + gameOperation.RandomNum(0, 50), 跳过动画y + gameOperation.RandomNum(0, 25));
                        dm.delay(1000);
                        dm.LeftClick();
                        dm.delay(1000);
                    }
                }
                dm.delay(1000);
                int 主x = 0, 主y = 0;
                dm.FindStrFast(41, 101, 282, 166, "[主]", "CDB36D-323032", 0.8, out 主x, out 主y);
                if (主x > 0)
                {
                    dm.MoveToEx(主y, 主y, 100, 30);
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(3000);
                }
                int 主1x = 0, 主1y = 0;
                dm.FindStrFast(41, 101, 282, 166, "主", "CDB772-322C1A", 0.8, out 主1x, out 主1y);
                if (主1x > 0)
                {
                    dm.MoveToEx(主1y, 主1y, 100, 30);
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(3000);
                }
                int 黄色下划线x = 0, 黄色下划线y = 0;
                dm.FindStrFast(44, 114, 318, 225, "黄色下划线1", "FFFFE7-393E3B", 0.8, out 黄色下划线x, out 黄色下划线y);
                if (黄色下划线x > 0)
                {
                    dm.MoveTo(黄色下划线x+ gameOperation.RandomNum(0, 100), 黄色下划线y- gameOperation.RandomNum(5, 40));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(3000);
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
                    continue;
                }
                int 确定跳过动画x = 0, 确定跳过动画y = 0;
                dm.FindStrFast(664, 422, 804, 461, "确定跳过动画", "978A77-424739", 0.8, out 确定跳过动画x, out 确定跳过动画y);
                if (确定跳过动画x > 0)
                {
                    dm.MoveTo(确定跳过动画x + gameOperation.RandomNum(0, 50), 确定跳过动画y + gameOperation.RandomNum(0, 25));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    continue;
                }
                int 二五Dx=0, 二五Dy = 0;
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
                        dm.MoveTo(确定选择x+gameOperation.RandomNum(0, 50), 确定选择y+gameOperation.RandomNum(0, 25));
                        dm.delay(1000);
                        dm.LeftClick();
                        dm.delay(1000);
                        continue;
                    }
                }
                //退出循环有问题  todo
                int 破坏金刚大阵x = 0, 破坏金刚大阵y = 0;
                dm.FindStrFast(71, 132, 181, 158, "破坏金刚大阵", "CCCCCB-333334", 0.8, out 破坏金刚大阵x, out 破坏金刚大阵y);
                //int 点击普通攻击x = 0, 点击普通攻击y = 0;
                //dm.FindStrFast(887, 565, 1045, 600, "点击普通攻击", "CDC4AF-313135", 0.8, out 点击普通攻击x, out 点击普通攻击y);
                if (破坏金刚大阵x > 0)
                {
                    
                    while (true)
                    {
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
                    }
                    continue;
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
                    dm.MoveTo(装备x + gameOperation.RandomNum(0, 30), 装备y + gameOperation.RandomNum(0, 20));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
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
                    dm.MoveTo(gameOperation.RandomNum(764, 772), gameOperation.RandomNum(410,420));
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
                        if (翻阅_x>0)
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
                            int 跳过动画x = 0, 跳过动画y = 0;
                            dm.FindStrFast(664, 422, 804, 461, "确定跳过动画", "978A77-424739", 0.8, out 跳过动画x, out 跳过动画y);
                            if (跳过动画x > 0)
                            {
                                dm.MoveTo(跳过动画x + gameOperation.RandomNum(0, 50), 跳过动画y + gameOperation.RandomNum(0, 25));
                                dm.delay(1000);
                                dm.LeftClick();
                                dm.delay(1000);
                            }
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
                        if (点击这里x>0)
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
                            int 跳过动画x = 0, 跳过动画y = 0;
                            dm.FindStrFast(664, 422, 804, 461, "确定跳过动画", "978A77-424739", 0.8, out 跳过动画x, out 跳过动画y);
                            if (跳过动画x > 0)
                            {
                                dm.MoveTo(跳过动画x + gameOperation.RandomNum(0, 50), 跳过动画y + gameOperation.RandomNum(0, 25));
                                dm.delay(1000);
                                dm.LeftClick();
                                dm.delay(1000);
                                break;
                            }
                            
                        }
                    }
                    
                }
                //搜身
                //int 搜身_x = 0, 搜身_y = 0;
                //dm.FindStrFast(900, 434, 951, 460, "搜身", "D0D0D0-2F2F2F", 0.9, out 搜身_x, out 搜身_y);
                //if (搜身_x > 0)
                //{
                //    dm.MoveTo(搜身_x, 搜身_y - gameOperation.RandomNum(0, 20));
                //    dm.delay(1000);
                //    dm.LeftClick();
                //    dm.delay(1000);

                //}
                //自动（打斗场景开启）
                int 自动_x = 0, 自动_y = 0;
                dm.FindStrFast(458, 582, 513, 612, "自动", "BBBBBB-424242", 0.8, out 自动_x, out 自动_y);
                if (自动_x > 0)
                {
                    dm.MoveToEx(自动_x, 自动_y, 10, 10);
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //击败猴群
                int 击败猴群_x = 0, 击败猴群_y = 0;
                dm.FindStrFast(47, 107, 237, 161, "击败猴群", "B0B1B1-4D4C4C", 0.8, out 击败猴群_x, out 击败猴群_y);
                if (击败猴群_x > 0) 
                {
                    while (true)
                    {
                        dm.MoveToEx(击败猴群_x, 击败猴群_y,30,10);
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
                            int 跳过动画x = 0, 跳过动画y = 0;
                            dm.FindStrFast(664, 422, 804, 461, "确定跳过动画", "978A77-424739", 0.8, out 跳过动画x, out 跳过动画y);
                            if (跳过动画x > 0)
                            {
                                dm.MoveTo(跳过动画x + gameOperation.RandomNum(0, 50), 跳过动画y + gameOperation.RandomNum(0, 25));
                                dm.delay(1000);
                                dm.LeftClick();
                                dm.delay(1000);
                                
                            }

                        }
                        int 展开选单1_x = 0, 展开选单1_y = 0;
                        dm.FindStrFast(1021, 275, 1123, 313, "展开选单", "8A7F76-3E403C", 0.8, out 展开选单1_x, out 展开选单1_y);
                        if (展开选单1_x > 0)
                        {
                            break;
                        }
                    }
                }
                //和猴王一起击败霍洞主 todo（打开自动攻击） 
                //int 与霍洞主交手_x = 0, 与霍洞主交手_y = 0;
                //dm.FindStrFast(458, 582, 513, 612, "与霍洞主交手", "BBBBBB-424242", 0.9, out 与霍洞主交手_x, out 与霍洞主交手_y);
                //if (与霍洞主交手_x > 0)
                //{
                //    dm.MoveToEx(与霍洞主交手_x, 与霍洞主交手_y, 50, 20);
                //    dm.delay(1000);
                //    dm.LeftClick();
                //    dm.delay(1000);
                //    //自动（打斗场景开启）
                //    int 自动_x = 0, 自动_y = 0;
                //    dm.FindStrFast(458, 582, 513, 612, "自动", "BBBBBB-424242", 0.9, out 自动_x, out 自动_y);
                //    if (自动_x > 0)
                //    {
                //        dm.MoveToEx(自动_x, 自动_y, 10, 10);
                //        dm.delay(1000);
                //        dm.LeftClick();
                //        dm.delay(1000);
                //    }
                //}
                
                int 展开选单_x = 0, 展开选单_y = 0;
                dm.FindStrFast(1021, 275, 1123, 313, "展开选单", "8A7F76-3E403C", 0.8, out 展开选单_x, out 展开选单_y);
                if (展开选单_x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1209, 1244),  gameOperation.RandomNum(275, 310));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //展开功能菜单
                int 展开功能菜单x = 0, 展开功能菜单y = 0;
                dm.FindStrFast(995, 264, 1143, 325, "展开功能菜单", "968C82-4A4C48", 0.8, out 展开功能菜单x, out 展开功能菜单y);
                if (展开功能菜单x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1200, 1250), gameOperation.RandomNum(275, 315));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
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
                //快上马
                int 快上马_x = 0, 快上马_y = 0;
                dm.FindStrFast(303, 519, 395, 552, "快上马", "8A7F76-3E403C", 0.8, out 快上马_x, out 快上马_y);
                if (快上马_x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(165, 230),  gameOperation.RandomNum(510, 570));
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
                    dm.MoveTo(加入门派x+gameOperation.RandomNum(0, 60), 加入门派y+ gameOperation.RandomNum(0, 25));
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
                        break;
                    }
                }
            }
        }
    }
}
