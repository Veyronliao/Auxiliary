using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace senke
{
    public class MainLineTwenty
    {
        public GameOperation gameOperation { get; set; }
        public UserItem user { get; set; }
        public dmsoft dm { get; set; }
        public MainLineTwenty(dmsoft dm, UserItem user)
        {
            gameOperation = new GameOperation(dm);
            this.user = user;
            this.dm = dm;
        }
        public void DoWork() 
        {
            
            
            while (true)
            {
                dm.UseDict(3);
                dm.delay(1000);
                dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
                dm.LeftClick();
                dm.delay(1000);
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
                //跳过剧情
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
                dm.FindStrFast(46, 106, 94, 137, "[主]", "CDB36D-323032", 0.8, out 主x, out 主y);
                if (主x > 0)
                {
                    dm.MoveToEx(主y, 主y, 100, 30);
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(3000);
                }
                int 黄色下划线x = 0, 黄色下划线y = 0;
                dm.FindStrFast(42, 154, 165, 177, "黄色下划线", "FFFFE7-393E3B", 0.8, out 黄色下划线x, out 黄色下划线y);
                if (黄色下划线x > 0)
                {
                    dm.MoveTo(黄色下划线x + gameOperation.RandomNum(0, 100), 黄色下划线y - gameOperation.RandomNum(5, 40));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(3000);
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
                int 前往突破x = 0, 前往突破y = 0;
                dm.FindStrFast(1145, 602, 1215, 673, "前往突破", "F3DFD6-0C2029", 0.8, out 前往突破x, out 前往突破y);
                if (前往突破x > 0)
                {
                    dm.MoveTo(前往突破x + gameOperation.RandomNum(5, 50), 前往突破y - gameOperation.RandomNum(5, 40));
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
               
                //展开功能菜单
                int 展开功能菜单x = 0, 展开功能菜单y = 0;
                dm.FindStrFast(883, 255, 1151, 335, "展开功能菜单", "81766E-353733", 0.8, out 展开功能菜单x, out 展开功能菜单y);
                if (展开功能菜单x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1200, 1250), gameOperation.RandomNum(275, 315));
                    dm.delay(1000);
                    dm.LeftClick();
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
                    dm.MoveTo(一键升级x+gameOperation.RandomNum(0, 50), 一键升级y+gameOperation.RandomNum(0, 30));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    int 确定x = 0, 确定y = 0;
                    dm.FindStrFast(663, 421, 806, 461, "确定", "FFFFE7-393E3B", 0.8, out 确定x, out 确定y);
                    if (确定x>0)
                    {
                        dm.MoveTo(确定x + gameOperation.RandomNum(0, 50), 确定y + gameOperation.RandomNum(0, 30));
                        dm.delay(1000);
                        dm.LeftClick();
                        dm.delay(1000);
                        dm.MoveTo(gameOperation.RandomNum(1215, 1245), gameOperation.RandomNum(10, 40));
                        dm.delay(1000);
                        dm.LeftClick();
                        dm.delay(1000);
                    }
                }
                //打开功能菜单
                int 展开功能菜单1x = 0, 展开功能菜单1y = 0;
                dm.FindStrFast(1000, 270, 1144, 318, "展开功能菜单", "867B73-3A3C38", 0.8, out 展开功能菜单1x, out 展开功能菜单1y);
                if (展开功能菜单1x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1200, 1250), gameOperation.RandomNum(275, 315));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
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
                int 怨念棋魂x = 0, 怨念棋魂y = 0;
                dm.FindStrFast(838, 633, 955, 689, "怨念棋魂", "FFFFE7-393E3B", 0.8, out 怨念棋魂x, out 怨念棋魂y);
                if (怨念棋魂x > 0)
                {
                    dm.KeyPress(49);
                }
                //召唤雕儿
                int 召唤雕儿x = 0, 召唤雕儿y = 0;
                dm.FindStrFast(1036, 587, 1172, 617, "召唤雕儿", "FFFFE7-393E3B", 0.8, out 召唤雕儿x, out 召唤雕儿y);
                if (召唤雕儿x > 0)
                {
                    dm.MoveTo(召唤雕儿x+gameOperation.RandomNum(0, 60), 召唤雕儿y+gameOperation.RandomNum(0, 20));
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
                //点击强化按钮
                int 点击强化按钮x = 0, 点击强化按钮y = 0;
                dm.FindStrFast(843, 345, 984, 380, "点击强化按钮", "827870-373935", 0.8, out 点击强化按钮x, out 点击强化按钮y);
                if (点击强化按钮x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1045, 1090), gameOperation.RandomNum(345, 385));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //强化按钮1
                int 点击强化按钮1x = 0, 点击强化按钮1y = 0;
                dm.FindStrFast(749, 327, 973, 405, "强化按钮1", "827870-373935", 0.8, out 点击强化按钮1x, out 点击强化按钮1y);
                if (点击强化按钮1x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1045, 1090), gameOperation.RandomNum(345, 385));
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
                    dm.MoveTo(gameOperation.RandomNum(1215, 1240), gameOperation.RandomNum(15, 40));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //天龙首礼
                int 天龙首礼x = 0, 天龙首礼y = 0;
                dm.FindStrFast(1102, 203, 1201, 305, "天龙首礼", "EFD3C6-102B32", 0.8, out 天龙首礼x, out 天龙首礼y);
                if (天龙首礼x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1185, 1215), gameOperation.RandomNum(60, 90));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    
                }
                //打开活动主界
                int 打开活动主界x = 0, 打开活动主界y = 0;
                dm.FindStrFast(1011, 215, 1157, 253, "打开活动主界", "81786F-363835", 0.8, out 打开活动主界x, out 打开活动主界y);
                if (打开活动主界x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1025, 1075), gameOperation.RandomNum(110, 160));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    //打开问剑侠义
                    int 打开问剑侠义x = 0, 打开问剑侠义y = 0;
                    dm.FindStrFast(345, 260, 514, 309, "打开问剑侠义", "FFFFE7-393E3B", 0.8, out 打开问剑侠义x, out 打开问剑侠义y);
                    if (打开问剑侠义x > 0)
                    {
                        dm.MoveTo(gameOperation.RandomNum(175, 465), gameOperation.RandomNum(105, 205));
                        dm.delay(1000);
                        dm.LeftClick();
                        dm.delay(1000);
                        //前往活动
                        int 前往活动x = 0, 前往活动y = 0;
                        dm.FindStrFast(819, 543, 943, 582, "前往活动", "948171-434538", 0.8, out 前往活动x, out 前往活动y);
                        if (前往活动x > 0)
                        {
                            dm.MoveTo(前往活动x + gameOperation.RandomNum(0, 50), 前往活动y + gameOperation.RandomNum(0, 20));
                            dm.delay(1000);
                            dm.LeftClick();
                            dm.delay(1000);
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
                        }
                    }
                }
                //挑战
                int 挑战x = 0, 挑战y = 0;
                dm.FindStrFast(1052, 585, 1143, 631, "挑战", "917964-3B3928", 0.8, out 挑战x, out 挑战y);
                if (挑战x > 0)
                {
                    dm.MoveTo(挑战x+gameOperation.RandomNum(0, 50), 挑战y+gameOperation.RandomNum(0, 25));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                int 挑战1x = 0, 挑战1y = 0;
                dm.FindStrFast(1062, 584, 1139, 621, "挑战", "FFFFE7-393E3B", 0.8, out 挑战1x, out 挑战1y);
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
                    dm.MoveTo(刻铭x+gameOperation.RandomNum(0, 50), 刻铭y+gameOperation.RandomNum(0, 20));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    dm.MoveTo( gameOperation.RandomNum(1215, 1235), gameOperation.RandomNum(15, 35));
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

                        //自动吃饭
                        int 自动吃饭x = 0, 自动吃饭y = 0;
                        dm.FindStrFast(1190, 479, 1265, 521, "自动吃饭", "C0B6B5-3F494A", 0.8, out 自动吃饭x, out 自动吃饭y);
                        if (自动吃饭x > 0)
                        {
                            dm.MoveTo(自动吃饭x + gameOperation.RandomNum(0, 30), 自动吃饭y - gameOperation.RandomNum(0, 20));
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
                //手动吃饭
                int 手动吃饭x = 0, 手动吃饭y = 0;
                dm.FindPic(1194, 438, 1257, 496, "\\img\\shoudongchifan.bmp", "000000", 0.8, 0, out 手动吃饭x, out 手动吃饭y);
                if (手动吃饭x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1035, 1055), gameOperation.RandomNum(140, 165));
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
                    dm.MoveTo( gameOperation.RandomNum(1200, 1250),  gameOperation.RandomNum(340, 380));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //分解（坐标需要重新定位）
                int 分解x = 0, 分解y = 0;
                dm.FindStrFast(875, 642, 998, 688, "分解", "887D74-3C3E3A", 0.8, out 分解x, out 分解y);
                if (分解x > 0)
                {
                    dm.MoveTo(分解x+gameOperation.RandomNum(0, 50), 分解y+gameOperation.RandomNum(0, 20));
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
                    dm.MoveTo(关闭x, 关闭y);
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //批量使用
                int 批量使用x = 0, 批量使用y = 0;
                dm.FindStrFast(905, 410, 1032, 459, "批量使用", "EAD4D0-152B2F", 0.8, out 批量使用x, out 批量使用y);
                if (批量使用x > 0)
                {
                    dm.MoveTo(批量使用x+gameOperation.RandomNum(0, 60), 批量使用y+gameOperation.RandomNum(0, 30));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //每日选做 bug  找到燕子坞才退出
                //int 每日选做x = 0, 每日选做y = 0;
                //dm.FindStrFast(37, 172, 127, 252, "每日选做", "8C7F6F-414538", 0.8, out 每日选做x, out 每日选做y);
                //if (每日选做x > 0)
                //{
                //    //关闭打开的窗口
                //    dm.KeyPress(27);
                //    dm.delay(1000);
                //    //再玩会
                //    int 再玩会_x = 0, 再玩会_y = 0;
                //    dm.FindStrFast(716, 538, 787, 571, "再玩会", "39300C-39310C", 0.8, out 再玩会_x, out 再玩会_y);
                //    if (再玩会_x > 0)
                //    {
                //        dm.MoveToEx(再玩会_x, 再玩会_y, 50, 20);
                //        dm.delay(1000);
                //        dm.LeftClick();
                //        dm.delay(1000);
                //    }
                //    break;
                //}
                //燕子坞
                dm.UseDict(5);
                dm.delay(1000);
                int 燕子坞x = 0, 燕子坞y = 0;
                dm.FindStrFast(142, 72, 1114, 527, "燕子坞", "7E695F-312E26", 0.8, out 燕子坞x, out 燕子坞y);
                if (燕子坞x > 0)
                {
                    dm.MoveToEx(燕子坞x, 燕子坞y, 120, 50);
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
            }
        }
    }
}
