using senke.DmSoft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace senke
{
    public class KeyConfiguration
    {
        public GameOperation gameOperation { get; set; }
        public UserItem user { get; set; }
        public dmsoft dm { get; set; }
        public KeyConfiguration(dmsoft dm, UserItem user) 
        {
            gameOperation = new GameOperation(dm);
            this.user = user;
            this.dm = dm;
        }
        public void DoWork()
        {

            while (true)
            {
                //关闭弹出的提示框
                int 关闭x = 0, 关闭y = 0;
                var 关闭 = dm.FindStrFast(195, 292, 836, 527, "关闭", "ffffff", 0.9, out 关闭x, out 关闭y);
                if (关闭x > 0)
                {
                    dm.Delays(400, 500);
                    dm.MoveTo(关闭x + gameOperation.RandomNum(0, 18), 关闭y + gameOperation.RandomNum(0, 15));
                    dm.Delays(400, 500);
                    dm.LeftClick();
                    dm.Delays(1000, 1200);
                }
                dm.KeyPress(27);
                dm.Delays(800,1000);
                dm.KeyPress(27);
                dm.Delays(800, 1000);
                dm.KeyPress(191);//第一次进入游戏默认的打开系统设置的快捷键是"/"
                dm.Delays(800, 1000);
                dm.KeyPress(83);//按下s快捷键打开系统设置
                dm.Delays(800, 1000);
                bool settinglingshoukongzhi = false, settingbaobaokongzhi = false, settinglingshouzhaohuan = false;

                dm.Delays(1000, 1500);
                int 键位设置x = 0, 键位设置y = 0;
                dm.FindStrFast(415, 343, 494, 367, "键位设置", "ffffff", 0.9, out 键位设置x, out 键位设置y);
                if (键位设置x > 0)
                {
                    dm.MoveTo(键位设置x + gameOperation.RandomNum(0, 47), 键位设置y + gameOperation.RandomNum(0, 15));
                    dm.Delays(1000, 1500);
                    dm.LeftClick();
                    dm.Delays(1000, 1500);
                    int 梦幻西游风格x = 0, 梦幻西游风格y = 0;
                    var 梦幻西游风格 = dm.FindStrFast(561, 586, 686, 609, "梦幻西游风格", "ffffff", 0.9, out 梦幻西游风格x, out 梦幻西游风格y);
                    if (梦幻西游风格x > 0)
                    {
                        dm.MoveTo(梦幻西游风格x + gameOperation.RandomNum(0, 66), 梦幻西游风格y + gameOperation.RandomNum(0, 13));
                        dm.Delays(1000, 1500);
                        dm.LeftClick();
                        dm.Delays(1000, 1500);
                        //查找宝宝控制
                        int 宝宝控制x = 0, 宝宝控制y = 0;
                        var 宝宝控制 = dm.FindStrFast(344, 481, 408, 500, "宝宝控制", "b1ddff", 0.9, out 宝宝控制x, out 宝宝控制y);
                        dm.delay(gameOperation.RandomNum(1000, 1200));
                        if (宝宝控制x > 0)
                        {
                            dm.MoveTo(宝宝控制x + gameOperation.RandomNum(225, 300), 宝宝控制y + gameOperation.RandomNum(3, 9));
                            dm.Delays(1000, 1200);
                            dm.LeftDoubleClick();
                            dm.Delays(1000, 1200);
                            dm.KeyPressStr(ScriptData.keySetting.BaoBaoKongZhi, 20);
                            //dm.SendString(user.hwnd, ScriptData.keySetting.BaoBaoKongZhi);
                            dm.Delays(1000, 1200);
                            settingbaobaokongzhi = true;
                        }
                        //查找灵兽控制
                        int 灵兽控制x = 0, 灵兽控制y = 0;
                        dm.FindStrFast(343, 502, 410, 521, "灵兽控制", "b1ddff", 0.9, out 灵兽控制x, out 灵兽控制y);
                        dm.Delays(1000, 1200);
                        if (灵兽控制x > 0)
                        {
                            dm.MoveTo(灵兽控制x + gameOperation.RandomNum(225, 300), 灵兽控制y + gameOperation.RandomNum(3, 9));
                            dm.Delays(1000, 1200);
                            dm.LeftDoubleClick();
                            dm.Delays(1000, 1200);
                            dm.KeyPressStr(ScriptData.keySetting.LingShouKongZhi, 20);
                            //dm.SendString(user.hwnd, ScriptData.keySetting.LingShouKongZhi);
                            dm.Delays(1000, 1200);
                            settinglingshoukongzhi = true;
                        }
                        //鼠标滑轮向下滑动，
                        dm.WheelDown();
                        dm.Delays(1000, 1200);
                        //查找灵兽出战
                        int 灵兽出战x = 0, 灵兽出战y = 0;
                        var 灵兽出战 = dm.FindStrFast(341, 528, 413, 549, "灵兽出战", "b1ddff", 0.9, out 灵兽出战x, out 灵兽出战y);
                        if (灵兽出战x > 0)
                        {
                            dm.MoveTo(灵兽出战x + gameOperation.RandomNum(225, 300), 灵兽出战y + gameOperation.RandomNum(3, 9));
                            dm.Delays(1000, 1200);
                            dm.LeftDoubleClick();
                            dm.Delays(1000, 1200);
                            dm.KeyPressStr(ScriptData.keySetting.ZhaoHuanLingShou, 20);
                            //dm.SendString(user.hwnd, ScriptData.keySetting.ZhaoHuanLingShou);
                            dm.Delays(1000, 1200);
                            settinglingshouzhaohuan = true;
                        }
                        else
                        {
                            dm.WheelUp();

                            continue;
                        }
                        //查找组队跟随

                        int 组队跟随x = 0, 组队跟随y = 0;
                        var 组队跟随 = dm.FindStrFast(342, 505, 412, 529, "组队跟随", "b1ddff", 0.9, out 组队跟随x, out 组队跟随y);
                        dm.Delays(1000, 1200);
                        if (组队跟随x > 0)
                        {
                            dm.MoveTo(组队跟随x + gameOperation.RandomNum(225, 300), 组队跟随y + gameOperation.RandomNum(3, 9));
                            dm.Delays(1000, 1200);
                            dm.LeftDoubleClick(); dm.Delays(1000, 1200); dm.delay(gameOperation.RandomNum(1000, 1200));
                            dm.KeyPressStr(ScriptData.keySetting.GenSui, 20);
                            dm.Delays(1000, 1200);
                            settinglingshouzhaohuan = true;
                        }
                        else
                        {
                            dm.WheelUp();

                            continue;
                        }
                        int 确定x = 0, 确定y = 0;
                        var 确定 = dm.FindStrFast(422, 618, 501, 642, "确定", "ffffff", 0.9, out 确定x, out 确定y);
                        if (确定x > 0 & settinglingshouzhaohuan & settinglingshoukongzhi & settingbaobaokongzhi)
                        {
                            dm.MoveTo(确定x + gameOperation.RandomNum(0, 35), 确定y + gameOperation.RandomNum(3, 12));
                            dm.Delays(1000, 1200);
                            dm.LeftClick();
                            dm.Delays(1000, 1200);
                            //按esc快捷键退出设置框
                            break;
                        }
                    }
                }
                
            }
            dm.KeyPress(27);
            dm.KeyPress(27);
            //灵兽自动佳雪设置
            while (true)
            {
                //关闭弹出的提示框
                int 关闭x = 0, 关闭y = 0;
                var 关闭 = dm.FindStrFast(195, 292, 836, 527, "关闭", "ffffff", 0.9, out 关闭x, out 关闭y);
                if (关闭x > 0)
                {
                    dm.Delays(400, 500);
                    dm.MoveTo(关闭x + gameOperation.RandomNum(0, 18), 关闭y + gameOperation.RandomNum(0, 15));
                    dm.Delays(400, 500);
                    dm.LeftClick();
                    dm.Delays(1000, 1200);
                }
                dm.KeyPress(68);
                dm.Delays(1000, 1200);              
                int 自动喂食x = 0, 自动喂食y = 0;
                dm.FindColor(536, 494, 598, 515, "ffffff", 0.95, 5, out 自动喂食x, out 自动喂食y);
                if (自动喂食x > 0)
                {
                    dm.Delays(1000, 1200);
                    dm.MoveToEx(自动喂食x, 自动喂食y, 30, 15);
                    dm.Delays(800, 1000);
                    dm.LeftClick();
                    dm.Delays(1000, 1200);
                    int 勾选x = 0, 勾选y = 0;
                    dm.FindStrFast(354, 323, 372, 368, "勾选", "D0D3D7-2F2C28", 0.9, out 勾选x, out 勾选y);
                    if (勾选x>0)
                    {
                        break;
                    }
                    dm.MoveTo(gameOperation.RandomNum(355, 375), gameOperation.RandomNum(325, 341));
                    dm.Delays(800, 1000);
                    dm.LeftClick();
                    dm.MoveTo(gameOperation.RandomNum(441, 461), gameOperation.RandomNum(325, 341));
                    dm.Delays(800, 1000);
                    dm.LeftDoubleClick();
                    dm.Delays(800, 1000);
                    //输入数字
                    dm.KeyPressStr(ScriptData.keySetting.LingShouXueQi1,50);
                    dm.Delays(800, 1000);
                    int 第一个下拉框按钮x = 0, 第一个下拉框按钮y = 0;
                    dm.FindStrFast(642, 321, 664, 344, "下拉框展开", "DFE6F0-20190F", 0.9, out 第一个下拉框按钮x, out 第一个下拉框按钮y);
                    if (第一个下拉框按钮x>0)
                    {
                        dm.Delays(800, 1000);
                        dm.MoveToEx(第一个下拉框按钮x, 第一个下拉框按钮y, 6, 6);
                        dm.Delays(800, 1000);
                        dm.LeftClick();
                        dm.Delays(800, 1000);
                        int 智能选择1x = 0, 智能选择1y = 0;
                        dm.FindStrFast(529, 339, 661, 365, "智能选择", "ffffff", 0.9, out 智能选择1x, out 智能选择1y);
                        if (智能选择1x>0)
                        {
                            dm.Delays(800, 1000);
                            dm.MoveToEx(智能选择1x, 智能选择1y, 20, 12);
                            dm.Delays(800, 1000);
                            dm.LeftClick();
                            dm.Delays(800, 1000);
                        }
                    }
                    //灵兽血气2设置
                    dm.Delays(1000, 1200);
                    dm.MoveTo(gameOperation.RandomNum(355, 370), gameOperation.RandomNum(353, 365));
                    dm.Delays(800, 1000);
                    dm.LeftClick();
                    dm.MoveTo(gameOperation.RandomNum(441, 461), gameOperation.RandomNum(351, 367));
                    dm.Delays(800, 1000);
                    dm.LeftDoubleClick();
                    dm.Delays(800, 1000);
                    //输入数字
                    dm.KeyPressStr(ScriptData.keySetting.LingShouXueQi2, 50);
                    dm.Delays(800, 1000);
                    int 第二个下拉框按钮x = 0, 第二个下拉框按钮y = 0;
                    dm.FindStrFast(643, 347, 665, 372, "下拉框展开", "DFE6F0-20190F", 0.9, out 第二个下拉框按钮x, out 第二个下拉框按钮y);
                    if (第二个下拉框按钮x > 0)
                    {
                        dm.Delays(800, 1000);
                        dm.MoveToEx(第二个下拉框按钮x, 第二个下拉框按钮y, 6, 6);
                        dm.Delays(800, 1000);
                        dm.LeftClick();
                        dm.Delays(800, 1000);
                        int 智能选择2x = 0, 智能选择2y = 0;
                        dm.FindStrFast(532, 364, 651, 394, "智能选择", "ffffff", 0.9, out 智能选择2x, out 智能选择2y);
                        if (智能选择2x > 0)
                        {
                            dm.Delays(800, 1000);
                            dm.MoveToEx(智能选择2x, 智能选择2y, 20, 12);
                            dm.Delays(800, 1000);
                            dm.LeftClick();
                            dm.Delays(800, 1000);
                        }
                    }
                    int 确定x = 0, 确定y = 0;
                    dm.FindStrFast(424, 472, 503, 495, "确定", "ffffff", 0.9, out 确定x, out 确定y);
                    if (确定x>0)
                    {
                        dm.Delays(800, 1000);
                        dm.MoveTo(确定x+ gameOperation.RandomNum(0, 40), 确定y+ gameOperation.RandomNum(0, 15));
                        dm.Delays(800, 1000);
                        dm.LeftClick();
                        dm.Delays(800, 1000);
                        dm.KeyPress(27);
                        break;
                    }
                }
                //int 退出循环条件1x = 0, 退出循环条件1y = 0;
                //dm.FindStrFast(539, 323, 604, 343, "智能选择", "ffffc5", 0.9, out 退出循环条件1x, out 退出循环条件1y);
                //int 退出循环条件2x = 0, 退出循环条件2y = 0;
                //dm.FindStrFast(536, 349, 642, 368, "智能选择", "ffffc5", 0.9, out 退出循环条件2x, out 退出循环条件2y);
                //if (退出循环条件1x>0|| 退出循环条件2x>0)
                //{
                //    dm.KeyPress(27);
                //    dm.Delays(800, 1000);
                //    break;
                //}
            }
        }
    }
}
