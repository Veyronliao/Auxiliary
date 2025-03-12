using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace senke
{
    /// <summary>
    /// 30级
    /// </summary>
    public class MainLineThirty
    {
        public GameOperation gameOperation { get; set; }
        public UserItem user { get; set; }
        public dmsoft dm { get; set; }
        public MainLineThirty(dmsoft dm, UserItem user)
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
                dm.MoveTo(gameOperation.RandomNum(0, 10), gameOperation.RandomNum(0, 10));
                dm.delay(1000);
                dm.LeftClick();
                dm.delay(600);
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
                    dm.delay(4000);
                }
                int 黄色下划线x = 0, 黄色下划线y = 0;
                dm.FindStrFast(42, 154, 165, 177, "黄色下划线", "FFFFE7-393E3B", 0.8, out 黄色下划线x, out 黄色下划线y);
                if (黄色下划线x > 0)
                {
                    dm.MoveTo(黄色下划线x + gameOperation.RandomNum(0, 100), 黄色下划线y - gameOperation.RandomNum(5, 40));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(4000);
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
                //分解
                int 分解x = 0, 分解y = 0;
                dm.FindStrFast(900, 650, 968, 688, "分解", "8E847B-424441", 0.8, out 分解x, out 分解y);
                if (分解x > 0)
                {
                    dm.MoveTo(分解x+gameOperation.RandomNum(0, 40), 分解y+gameOperation.RandomNum(0, 20));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //一键分解
                int 一键分解x = 0, 一键分解y = 0;
                dm.FindStrFast(316, 497, 492, 596, "一键分解", "6b6350-6C6351", 0.8, out 一键分解x, out 一键分解y);
                if (一键分解x > 0)
                {
                    dm.MoveTo(一键分解x + gameOperation.RandomNum(0, 40), 一键分解y + gameOperation.RandomNum(0, 20));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
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
                dm.FindStrFast(1023, 584, 1172, 620, "饲育小猴王", "988881-424845", 0.8, out 饲育小猴王x, out 饲育小猴王y);
                if (饲育小猴王x > 0)
                {
                    dm.MoveTo(饲育小猴王x+gameOperation.RandomNum(0, 60), 饲育小猴王y+gameOperation.RandomNum(0, 25));
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
                if (锁定x>0)
                {
                    dm.MoveTo(锁定x+gameOperation.RandomNum(0, 10), 锁定y+gameOperation.RandomNum(0, 10));
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
                    dm.MoveTo( gameOperation.RandomNum(1110, 1130), gameOperation.RandomNum(60, 80));
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
                //点击强化按钮
                int 点击强化按钮x = 0, 点击强化按钮y = 0;
                dm.FindStrFast(786, 343, 929, 383, "强化按钮1", "827870-373935", 0.8, out 点击强化按钮x, out 点击强化按钮y);
                if (点击强化按钮x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1045, 1090), gameOperation.RandomNum(345, 385));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(2000);
                    dm.MoveTo(gameOperation.RandomNum(110, 300), gameOperation.RandomNum(200, 265));
                    dm.delay(2000);
                    dm.LeftClick();
                    dm.delay(2000);
                    dm.MoveTo(gameOperation.RandomNum(565, 600), gameOperation.RandomNum(105, 135));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(2000);
                    dm.MoveTo(gameOperation.RandomNum(890, 100), gameOperation.RandomNum(655, 695));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(2000);
                    dm.MoveTo(gameOperation.RandomNum(545, 680), gameOperation.RandomNum(625, 665));
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
                    dm.MoveTo(前往获取x+gameOperation.RandomNum(0, 50), 前往获取y+gameOperation.RandomNum(0, 20));
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
                //确定
                int 确定x = 0, 确定y = 0;
                dm.FindStrFast(689, 424, 781, 457, "确定跳过动画", "968975-494E3D", 0.8, out 确定x, out 确定y);
                if (确定x > 0)
                {
                    dm.MoveTo(确定x+gameOperation.RandomNum(0, 50), 确定y+gameOperation.RandomNum(0, 20));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                  
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
                //前往充值
                int 前往充值x = 0, 前往充值y = 0;
                dm.FindStrFast(1000, 598, 1103, 635, "前往充值", "978677-46483C", 0.8, out 前往充值x, out 前往充值y);
                if (前往充值x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1215, 1239),gameOperation.RandomNum(350, 370));
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
                    dm.MoveTo(升级x+gameOperation.RandomNum(0, 30), 升级y+gameOperation.RandomNum(0, 20));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    dm.MoveTo(gameOperation.RandomNum(550, 680), gameOperation.RandomNum(630, 665));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    //dm.MoveTo(gameOperation.RandomNum(1215, 1239), gameOperation.RandomNum(17, 35));
                    //dm.delay(1000);
                    //dm.LeftClick();
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
                int 关闭x = 0, 关闭y = 0;
                dm.FindPic(928, 8, 1270, 304, "\\img\\guanbi.bmp", "000000", 0.9, 0, out 关闭x, out 关闭y);
                if (关闭x > 0)
                {
                    dm.MoveToEx(关闭x, 关闭y, 10, 10);
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
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
                //每日选做
                int 每日选做x = 0, 每日选做y = 0;
                dm.FindStrFast(37, 172, 127, 252, "每日选做", "8C7F6F-414538", 0.8, out 每日选做x, out 每日选做y);
                if (每日选做x > 0)
                {
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
                    break;
                }
            }
        }
    }
}
