using senke.DmSoft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace senke
{
    public class PrincipalLine
    {
        public GameOperation gameOperation { get; set; }
        public UserItem user;
        public dmsoft dm;
        public PrincipalLine(dmsoft dm,UserItem user) 
        {
            gameOperation =new GameOperation(dm,user);
            this.user = user;
            this.dm = dm;
        }
        /// <summary>
        /// 主线任务
        /// </summary>
        /// <param name="dm"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool DoWork()
        {
            while (true)
            {
                //召唤灵兽
                int 灵兽x = 0, 灵兽y = 0;
                //var 灵兽 = dm.FindColor(69, 131, 169, 138, "101439|c81716|e13737", 0.95, 5, out 灵兽x, out 灵兽y);
                dm.FindStrFast(169, 123, 209, 159, "跟", "CFD5E1-302A1E", 0.9, out 灵兽x, out 灵兽y);
                dm.Delays(1000, 1200);
                if (灵兽x>0)
                {
                    break;
                }
                else
                {
                    //dm.KeyPressStr(ScriptData.keySetting.ZhaoHuanLingShou,50);
                    dm.Delays(800, 1000);
                    dm.KeyPressChar(ScriptData.keySetting.ZhaoHuanLingShou);
                    dm.Delays(1200, 1500);
                }
            }
            while (true)
            {
               
                //跳过对话动画
                dm.Delays(1000, 1200);
                int 继续1x = 0, 继续1y = 0;
                dm.FindStrFast(200, 700, 353, 764, "F继续", "c4a982", 0.9, out 继续1x, out 继续1y);
                if (继续1x > 0)
                {
                    while (true)
                    {
                        int w键2x = 0, w键2y = 0;
                        dm.FindStrFast(254, 639, 331, 684, "w", "ff5438", 0.9, out w键2x, out w键2y);
                        if (w键2x > 0)
                        {
                            dm.Delays(400, 500);
                            dm.KeyPress(87);
                            dm.Delays(400, 500);
                        }
                        //int q键2x = 0, q键2y = 0;
                        //dm.FindStrFast(254, 639, 331, 684, "Q", "ff5438", 0.9, out q键2x, out q键2y);
                        //if (q键2x > 0)
                        //{
                        //    dm.Delays(400, 500);
                        //    dm.KeyPress(81);
                        //    dm.Delays(400, 500);
                        //    dm.KeyPress(87);
                        //    dm.Delays(400, 500);
                        //    dm.KeyPress(68);
                        //    dm.Delays(400, 500);
                        //}
                        int 抵御冲击x = 0, 抵御冲击y = 0;
                        dm.FindStrFast(343, 638, 410, 672, "抵御冲击", "ffffff", 0.9, out 抵御冲击x, out 抵御冲击y);
                        if (抵御冲击x > 0)
                        {
                            dm.Delays(400, 500);
                            dm.KeyPress(81);
                            dm.Delays(400, 500);
                            dm.KeyPress(87);
                            dm.Delays(400, 500);
                            dm.KeyPress(68);
                            dm.Delays(400, 500);
                        }
                        //提示是否召唤灵兽获取经验
                        int 自动召唤x = 0, 自动召唤y = 0;
                        var 自动召唤 = dm.FindStrFast(471, 423, 556, 463, "自动召唤", "ffffff", 0.9, out 自动召唤x, out 自动召唤y);
                        if (自动召唤x > 0)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(自动召唤x + gameOperation.RandomNum(3, 45), 自动召唤y + gameOperation.RandomNum(3, 12));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1000, 1200);
                        }
                        //琵琶弦上
                        //复手
                        int 复手1x = 0, 复手1y = 0;
                        var 复手1 = dm.FindStrFast(188, 549, 230, 578, "复手", "91A5D0-14322F", 0.9, out 复手1x, out 复手1y);
                        if (复手1x > 0)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(复手1x + 125, 复手1y);
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(4000, 5000);
                            //琴轴
                            int 琴轴1x = 0, 琴轴1y = 0;
                            var 琴轴1 = dm.FindStrFast(324, 95, 367, 121, "琴轴", "91A5D0-14322F", 0.9, out 琴轴1x, out 琴轴1y);
                            if (琴轴1x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(琴轴1x + 82, 琴轴1y + 46);
                                dm.Delays(400, 500);
                                dm.LeftClick();
                                dm.Delays(4000, 5000);
                                int 琵琶弦上完成1x = 0, 琵琶弦上完成1y = 0;
                                var 琵琶弦上完成1 = dm.FindStrFast(731, 256, 794, 278, "完成", "ffffff", 0.9, out 琵琶弦上完成1x, out 琵琶弦上完成1y);
                                if (琵琶弦上完成1x > 0)
                                {
                                    dm.Delays(400, 500);
                                    dm.MoveTo(琵琶弦上完成1x + gameOperation.RandomNum(0, 30), 琵琶弦上完成1y + gameOperation.RandomNum(0, 15));
                                    dm.Delays(400, 500);
                                    dm.LeftClick();
                                    dm.Delays(4000, 5000);
                                }
                            }
                        }
                        int 继续退出x = 0, 继续退出y = 0;
                        dm.FindStrFast(830, 280, 982, 334, "下划线1|标准下划线", "00ff00|ffffff|ffbf6c", 0.9, out 继续退出x, out 继续退出y);
                        if (继续退出x > 0)
                        {
                            break;//退出按f键循环
                        }
                        dm.MoveTo(gameOperation.RandomNum(0, 200), gameOperation.RandomNum(0, 200));
                        dm.Delays(800, 1000);
                        dm.LeftClick();
                        dm.Delays(800, 1000);

                    }
                }
                //设置窗口大小
                dm.SetWindowSize(user.hwnd, 1030, 797);
                dm.Delays(800, 1000);
                int 营救行动x = 0, 营救行动y = 0;
                dm.FindStrFast(830, 280, 982, 334, "营救行动", "00ff00", 0.9, out 营救行动x, out 营救行动y);
                if (营救行动x > 0)
                {
                    gameOperation.UpDataRole();//升级后买37级木剑
                    while (true)
                    {
                        dm.KeyPress(27);
                        dm.Delays(800, 1000);
                        dm.KeyPress(27);
                        dm.Delays(800, 1000);
                        dm.MoveTo(营救行动x + gameOperation.RandomNum(10, 60), 营救行动y + gameOperation.RandomNum(3, 10));
                        dm.Delays(800, 1000);
                        dm.RightClick();
                        dm.Delays(800, 1000);
                        int 任务下划线x = 0, 任务下划线y = 0;
                        dm.FindStrFast(27, 223, 155, 256, "下划线1", "00ff00", 0.9, out 任务下划线x, out 任务下划线y);
                        if (任务下划线x > 0)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(任务下划线x + gameOperation.RandomNum(5, 45), 任务下划线y - gameOperation.RandomNum(3, 12));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1000, 1200);
                            int 杭州武器店x = 0, 杭州武器店y = 0;
                            dm.FindStrFast(389, 408, 505, 432, "杭州武器店", "ffffff", 0.9, out 杭州武器店x, out 杭州武器店y);
                            if (杭州武器店x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(杭州武器店x + gameOperation.RandomNum(5, 45), 杭州武器店y + gameOperation.RandomNum(3, 12));
                                dm.Delays(400, 500);
                                dm.LeftClick();
                                dm.Delays(1000, 1200);
                                dm.WheelDown();
                                dm.Delays(1000, 1200);
                                dm.WheelDown();
                                dm.Delays(1000, 1200);
                                dm.WheelDown();
                                dm.Delays(1000, 1200);
                                dm.WheelDown();
                                dm.Delays(1000, 1200);
                                dm.WheelDown();
                                dm.Delays(1000, 1200);
                                dm.WheelDown();
                                dm.Delays(1000, 1200);
                                dm.WheelDown();
                                dm.Delays(1000, 1200);
                                int 玄典剑x = 0, 玄典剑y = 0;
                                dm.FindStrFast(381, 414, 444, 436, "玄典剑", "808080", 0.9, out 玄典剑x, out 玄典剑y);
                                if (玄典剑x > 0)
                                {
                                    dm.MoveTo(玄典剑x + gameOperation.RandomNum(0, 40), 玄典剑y + gameOperation.RandomNum(0, 20));
                                    dm.Delays(1000, 1200);
                                    dm.LeftClick();
                                    dm.Delays(1000, 1200);
                                    dm.MoveTo(gameOperation.RandomNum(0, 200), gameOperation.RandomNum(0, 200));
                                    dm.Delays(1000, 1200);
                                    int 确定x = 0, 确定y = 0;
                                    dm.FindStrFast(435, 400, 498, 424, "确定", "ffffff", 0.9, out 确定x, out 确定y);
                                    if (确定x > 0)
                                    {
                                        dm.MoveTo(确定x + gameOperation.RandomNum(0, 35), 确定y + gameOperation.RandomNum(0, 15));
                                        dm.Delays(1000, 1200);
                                        dm.LeftClick();
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    while (true)
                    {
                        dm.Delays(800, 1000);
                        dm.MoveTo(营救行动x + gameOperation.RandomNum(10, 60), 营救行动y + gameOperation.RandomNum(3, 10));
                        dm.Delays(800, 1000);
                        dm.LeftClick();
                        dm.Delays(800, 1000);
                        int 正传x = 0, 正传y = 0;
                        var 正传 = dm.FindStrFast(160, 422, 851, 451, "[正传]|[剧情]", "ffffff", 0.9, out 正传x, out 正传y);
                        if (正传x > 0)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(正传x + gameOperation.RandomNum(5, 35), 正传y + gameOperation.RandomNum(3, 12));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1000, 2000);
                            int 鳄皮护手iconx = 0, 鳄皮护手icony = 0;
                            dm.FindPic(232, 225, 1010, 423, "\\package\\epihushou.bmp", "000000", 0.9, 0, out 鳄皮护手iconx, out 鳄皮护手icony);
                            if (鳄皮护手iconx > 0)
                            {
                                dm.Delays(800, 1000);
                                dm.MoveToEx(鳄皮护手iconx, 鳄皮护手icony, 10, 10);
                                dm.Delays(800, 1000);
                                dm.RightClick();
                                dm.Delays(800, 1000);
                                dm.MoveTo(gameOperation.RandomNum(0, 200), gameOperation.RandomNum(0, 200));
                                dm.Delays(800, 1000);
                            }
                            int 玄典剑iconx = 0, 玄典剑icony = 0;
                            dm.FindPic(232, 225, 1010, 423, "\\package\\xuandianjian.bmp", "000000", 0.9, 0, out 玄典剑iconx, out 玄典剑icony);
                            if (玄典剑iconx > 0)
                            {
                                dm.Delays(800, 1000);
                                dm.MoveToEx(玄典剑iconx, 玄典剑icony, 5, 5);
                                dm.Delays(800, 1000);
                                dm.RightClick();
                                dm.Delays(800, 1000);
                                dm.MoveTo(gameOperation.RandomNum(0, 200), gameOperation.RandomNum(0, 200));
                                dm.Delays(800, 1000);
                                int 完成x = 0, 完成y = 0;
                                dm.FindStrFast(436, 570, 502, 592, "完成", "ffffff", 0.9, out 完成x, out 完成y);
                                if (正传x > 0)
                                {
                                    dm.Delays(400, 500);
                                    dm.MoveTo(完成x + gameOperation.RandomNum(5, 35), 完成y + gameOperation.RandomNum(3, 12));
                                    dm.Delays(400, 500);
                                    dm.LeftClick();
                                    dm.Delays(1000, 2000);
                                    dm.KeyPress(27);
                                    break;
                                }
                            }
                        }
                    }
                }
                //如果有一键装备则点击
                int yijianzhuangbeix = 0, yijianzhuangbeiy = 0;
                var yijianzhuangbei = dm.FindStrFast(521, 333, 941, 679, "一键装备", "ffffff", 0.9, out yijianzhuangbeix, out yijianzhuangbeiy);
                if (yijianzhuangbeix > 0)
                {
                    dm.Delays(400, 500);
                    dm.MoveTo(yijianzhuangbeix + gameOperation.RandomNum(0, 45), yijianzhuangbeiy + gameOperation.RandomNum(0, 12));
                    dm.Delays(400, 500);
                    dm.LeftClick();
                    dm.Delays(400, 500);
                }
                //关闭弹出的提示框
                int 关闭x = 0, 关闭y = 0;
                var 关闭 = dm.FindStrFast(286, 260, 753, 503, "关闭", "ffffff", 0.9, out 关闭x, out 关闭y);
                if (关闭x > 0)
                {
                    dm.Delays(400, 500);
                    dm.MoveTo(关闭x + gameOperation.RandomNum(0, 18), 关闭y + gameOperation.RandomNum(0, 15));
                    dm.Delays(400, 500);
                    dm.LeftClick();
                    dm.Delays(1000, 1200);
                }
                
                //查找绿色下划线（交付任务）
                int 下划线x = 0, 下划线y = 0;
                var 绿色下划线 = dm.FindStrFast(830, 280, 982, 334, "下划线1|标准下划线|下划线1", "00ff00|ffbf6c", 0.9, out 下划线x, out 下划线y);
                //var 绿色下划线 = dm.FindStrFast(830, 280, 982, 334, "下划线1", "00ff00|ffffff|ffbf6c", 0.9, out 下划线x, out 下划线y);
                if (下划线x > 0)
                {
                    dm.KeyPress(27);
                    dm.Delays(800, 1000);
                    dm.Delays(400, 500);
                    dm.MoveTo(下划线x + gameOperation.RandomNum(10, 100), 下划线y - gameOperation.RandomNum(3, 10));
                    dm.Delays(400, 500);
                    dm.LeftClick();
                    dm.Delays(1000, 1500);
                    while (true)
                    {

                       
                        //点击弹框的完成
                        int 完成x = 0, 完成y = 0;
                        var 完成 = dm.FindStrFast(409, 425, 686, 465, "(已领)|(完成)", "ffffff", 0.9, out 完成x, out 完成y);
                        if (完成x > 0)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(完成x + gameOperation.RandomNum(5, 45), 完成y + gameOperation.RandomNum(3, 12));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1000, 1200);
                        }
                        
                        dm.Delays(1000, 1200);
                        int 正传x = 0, 正传y = 0;
                        var 正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 正传x, out 正传y);
                        if (正传x > 0)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(正传x + gameOperation.RandomNum(5, 35), 正传y + gameOperation.RandomNum(3, 12));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1000, 2000);
                            //升级经验
                            int 任务需要达到x = 0, 任务需要达到y = 0;
                            dm.FindStrFast(378, 364, 535, 392, "任务需要达到", "ffffff", 0.9, out 任务需要达到x, out 任务需要达到y);
                            if (任务需要达到x > 0)
                            {
                                gameOperation.UpDataRole();
                            }
                        }
                        //营救行动会改变[正传]的坐标
                        int 正传2x = 0, 正传2y = 0;
                        dm.FindStrFast(192, 423, 377, 453, "[正传]|[剧情]", "ffffff", 0.9, out 正传2x, out 正传2y);
                        if (正传x > 0)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(正传2x + gameOperation.RandomNum(5, 35), 正传2y + gameOperation.RandomNum(3, 12));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1000, 2000);
                            break;
                        }
                        
                        //14级崂山道人接受任务
                        dm.Delays(1000, 1200);
                        int 接受任务x = 0, 接受任务y = 0;
                        dm.FindStrFast(830, 280, 982, 334, "崂山接受任务", "ffffff", 0.9, out 接受任务x, out 接受任务y);
                        if (接受任务x > 0)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(接受任务x + gameOperation.RandomNum(3, 30), 接受任务y + gameOperation.RandomNum(3, 15));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                        }

                        //14级点击拜师入门任务后，再点击接受按钮
                        int 接受x = 0, 接受y = 0;
                        var 接受 = dm.FindStrFast(611, 575, 677, 596, "拜师入门接受 ", "ffffff", 0.9, out 接受x, out 接受y);
                        if (接受x > 0)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(接受x + gameOperation.RandomNum(0, 20), 接受y);
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1000, 1500);
                        }

                        //跳过对话动画
                        dm.Delays(1000, 1200);
                        //dm.KeyPress(70);//按F
                        int 继续x = 0, 继续y = 0;
                        int 蒲松龄x = 0, 蒲松龄y = 0;
                        dm.FindStrFast(124, 718, 397, 767, "F继续", "c4a982", 0.9, out 继续x, out 继续y);
                        dm.FindStrFast(307, 616, 355, 633, "蒲松龄", "ffffe3", 0.9, out 蒲松龄x, out 蒲松龄y);
                        if (继续x > 0|| 蒲松龄x>0)
                        {
                            while (true)
                            {
                                int w键x = 0, w键y = 0;
                                dm.FindStrFast(258, 644, 305, 695, "w", "ff5438", 0.9, out w键x, out w键y);
                                if (w键x>0)
                                {
                                    dm.Delays(400, 500);
                                    dm.KeyPress(87);
                                    dm.Delays(400, 500);
                                }
                                
                               
                                int 不去看了x = 0, 不去看了y = 0;
                                dm.FindStrFast(595, 555, 714, 614, "不去看了", "fff0b3", 0.9, out 不去看了x, out 不去看了y);
                                if (不去看了x > 0)
                                {
                                    dm.Delays(400, 500);
                                    dm.MoveTo(不去看了x + gameOperation.RandomNum(5, 40), 不去看了y + gameOperation.RandomNum(3, 10));
                                    dm.Delays(400, 500);
                                    dm.LeftClick();
                                    dm.Delays(1000, 1200);
                                }
                                //提示是否召唤灵兽获取经验
                                int 自动召唤x = 0, 自动召唤y = 0;
                                var 自动召唤 = dm.FindStrFast(471, 423, 556, 463, "自动召唤", "ffffff", 0.9, out 自动召唤x, out 自动召唤y);
                                if (自动召唤x > 0)
                                {
                                    dm.Delays(400, 500);
                                    dm.MoveTo(自动召唤x + gameOperation.RandomNum(3, 45), 自动召唤y + gameOperation.RandomNum(3, 12));
                                    dm.Delays(400, 500);
                                    dm.LeftClick();
                                    dm.Delays(1000, 1200);
                                }
                                dm.LeftClick();
                                //dm.Delays(600, 700);
                                int 继续退出x = 0, 继续退出y = 0;
                                dm.FindStrFast(830, 280, 982, 334, "下划线1|标准下划线", "00ff00|ffffff|ffbf6c", 0.9, out 继续退出x, out 继续退出y);
                                if (继续退出x > 0)
                                {
                                    break;//退出按f键循环
                                }
                                //琵琶弦上
                                //复手
                                int 复手1x = 0, 复手1y = 0;
                                var 复手1 = dm.FindStrFast(188, 549, 230, 578, "复手", "91A5D0-14322F", 0.9, out 复手1x, out 复手1y);
                                if (复手1x > 0)
                                {
                                    dm.Delays(400, 500);
                                    dm.MoveTo(复手1x + 125, 复手1y);
                                    dm.Delays(400, 500);
                                    dm.LeftClick();
                                    dm.Delays(4000, 5000);
                                    //琴轴
                                    int 琴轴1x = 0, 琴轴1y = 0;
                                    var 琴轴1 = dm.FindStrFast(324, 95, 367, 121, "琴轴", "91A5D0-14322F", 0.9, out 琴轴1x, out 琴轴1y);
                                    if (琴轴1x > 0)
                                    {
                                        dm.Delays(400, 500);
                                        dm.MoveTo(琴轴1x + 82, 琴轴1y + 46);
                                        dm.Delays(400, 500);
                                        dm.LeftClick();
                                        dm.Delays(4000, 5000);
                                        int 琵琶弦上完成1x = 0, 琵琶弦上完成1y = 0;
                                        var 琵琶弦上完成1 = dm.FindStrFast(731, 256, 794, 278, "完成", "ffffff", 0.9, out 琵琶弦上完成1x, out 琵琶弦上完成1y);
                                        if (琵琶弦上完成1x > 0)
                                        {
                                            dm.Delays(400, 500);
                                            dm.MoveTo(琵琶弦上完成1x + gameOperation.RandomNum(0, 30), 琵琶弦上完成1y + gameOperation.RandomNum(0, 15));
                                            dm.Delays(400, 500);
                                            dm.LeftClick();
                                            dm.Delays(4000, 5000);
                                        }
                                    }
                                }
                            }
                        }

                        int 下划线退出x = 0, 下划线退出y = 0;
                        dm.FindStrFast(830, 280, 982, 334, "下划线1|标准下划线", "00ff00|ffffff|ffbf6c", 0.9, out 下划线退出x, out 下划线退出y);
                        if (下划线退出x > 0)
                        {
                            dm.KeyPress(27);//按esc关闭所有对话框
                            dm.Delays(300, 400);
                            dm.KeyPress(27);
                            dm.Delays(300, 400);
                            dm.KeyPress(27);
                            break;
                        }
                    }

                }
                //白色战斗任务
                int 白色战斗任务下划线x = 0, 白色战斗任务下划线y = 0;
                var 白色战斗任务下划线 = dm.FindStrFast(830, 280, 982, 334, "下划线1|标准下划线|下划线1", "ffffff|ff0000", 0.9, out 白色战斗任务下划线x, out 白色战斗任务下划线y);
                if (白色战斗任务下划线x > 0)
                {
                    dm.KeyPress(27);
                    dm.Delays(800, 1000);
                    #region 燃犀之灯
                    int 燃犀之灯x = 0;
                    int 燃犀之灯y = 0;


                    var 燃犀之灯 = dm.FindStrFast(823, 274, 966, 335, "燃犀之灯", "ffffff", 0.9, out 燃犀之灯x, out 燃犀之灯y);
                    if (燃犀之灯x > 0)
                    {
                        dm.KeyPress(27);
                        dm.Delays(400, 500);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 100), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(400, 500);
                        dm.LeftClick();
                        dm.Delays(1000, 1200);
                        int 正传x = 0, 正传y = 0;
                        var 正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 正传x, out 正传y);
                        if (正传x > 0)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(正传x + gameOperation.RandomNum(5, 35), 正传y + gameOperation.RandomNum(3, 12));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1000, 2000);
                        }
                        continue;
                    }

                    #endregion

                    #region 掩藏秘密
                    int 掩藏秘密x = 0;
                    int 掩藏秘密y = 0;


                    var 掩藏秘密 = dm.FindStrFast(823, 274, 966, 335, "掩藏秘密", "ffffff", 0.9, out 掩藏秘密x, out 掩藏秘密y);
                    if (掩藏秘密x > 0)
                    {
                        dm.KeyPress(27);
                        dm.Delays(400, 500);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 100), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(400, 500);
                        dm.LeftClick();
                        dm.Delays(1000, 1200);
                        int 正传x = 0, 正传y = 0;
                        var 正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 正传x, out 正传y);
                        if (正传x > 0)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(正传x + gameOperation.RandomNum(5, 35), 正传y + gameOperation.RandomNum(3, 12));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1000, 2000);
                        }
                        continue;
                    } 
                    #endregion
                    #region 失控木人
                    int 失控木人x = 0;
                    int 失控木人y = 0;


                    var shikongmuren = dm.FindStrFast(823, 274, 966, 335, "失控木人", "ffffff", 0.9, out 失控木人x, out 失控木人y);
                    if (失控木人x > 0)
                    {
                        while (true)
                        {
                            dm.KeyPress(27);
                            dm.Delays(400, 500);
                            dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 100), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1000, 1500);
                            int 失控木人退出x = 0, 失控木人退出y = 0;
                            dm.FindStrFast(830, 280, 982, 334, "下划线1|标准下划线", "00ff00", 0.9, out 失控木人退出x, out 失控木人退出y);
                            if (失控木人退出x > 0)
                            {
                                break;
                            }
                            int 选中一个失控木人x = 0, 选中一个失控木人y = 0;

                            var 选中一个失控木人 = dm.FindStrFast(475, 179, 631, 221, "选中一个失", "e3ff89", 0.9, out 选中一个失控木人x, out 选中一个失控木人y);
                            if (选中一个失控木人x > 0)
                            {
                                //tab切换怪物
                                gameOperation.QieGuai();
                            }
                            gameOperation.ZhanDou();
                            //加血加蓝
                            gameOperation.JiaXueJiaLan();
                        }
                        continue;
                    }
                    #endregion
                    #region 丝洞探秘
                    dm.Delays(300, 500);
                    int 丝洞探秘x = 0, 丝洞探秘y = 0;
                    var 丝洞探秘 = dm.FindStrFast(823, 274, 966, 335, "丝洞探秘", "ffffff", 0.9, out 丝洞探秘x, out 丝洞探秘y);
                    if (丝洞探秘x > 0)
                    {

                        while (true)
                        {
                            dm.KeyPress(27);
                            dm.Delays(400, 500);
                            dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 100), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1000, 1500);
                            //绿色交付下划线
                            int 交付绿色下划线x = 0, 交付绿色下划线y = 0;
                            dm.FindStrFast(830, 280, 982, 334, "下划线1|标准下划线", "00ff00", 0.9, out 交付绿色下划线x, out 交付绿色下划线y);
                            if (交付绿色下划线x > 0)
                            {
                                break;
                            }
                            //9级红鳌蛛母、蜘蛛幽灵
                            int 红螯蛛母x = 0, 红螯蛛母y = 0;
                            var 红螯蛛母 = dm.FindStrFast(0, 0, 1000, 700, "红螯蛛母", "D768D7-282028", 0.9, out 红螯蛛母x, out 红螯蛛母y);
                            int 蜘蛛幽灵x = 0, 蜘蛛幽灵y = 0;

                            var 蜘蛛幽灵 = dm.FindStrFast(0, 0, 1000, 700, "蜘蛛幽灵", "C9C9C9-363636", 0.9, out 蜘蛛幽灵x, out 蜘蛛幽灵y);//游戏场景里寻找
                            if (蜘蛛幽灵x > 0)
                            {
                                //切怪
                                gameOperation.QieGuai();
                                //战斗循环，先循环杀小蜘蛛
                                while (true)
                                {
                                    int 死亡蜘蛛x = 0, 死亡蜘蛛y = 0;
                                    var 死亡蜘蛛 = dm.FindStrFast(420, 4, 580, 70, "[死亡]", "ffffff", 0.9, out 死亡蜘蛛x, out 死亡蜘蛛y);
                                    if (死亡蜘蛛x > 0)
                                    {
                                        break;//退出杀怪循环，继续寻路
                                    }
                                    gameOperation.ZhanDou();
                                    gameOperation.JiaXueJiaLan();
                                }

                            }
                            if (红螯蛛母x > 0)
                            {
                                while (true)
                                {
                                    //绿色交付下划线
                                    int 绿色下划线x = 0, 绿色下划线y = 0;
                                    dm.FindStrFast(820, 276, 912, 304, "标准下划线", "00ff00", 0.9, out 绿色下划线x, out 绿色下划线y);
                                    if (绿色下划线x > 0)
                                    {
                                        break;
                                    }
                                    //int 正传x = 0, 正传y = 0;
                                    //dm.FindStrFast(830, 280, 982, 334, "[正传]", "00ff00", 0.9, out 正传x, out 正传y);
                                    //if (正传x > 0)
                                    //{
                                    //    break;
                                    //}
                                    gameOperation.ZhanDou();
                                    gameOperation.WuNaoJiaXue();
                                    gameOperation.JiaLan();
                                    dm.KeyPress(27);//战斗结束后跳过动画
                                }
                            }
                            //宝箱
                            int 宝箱x = 0, 宝箱y = 0;
                            var 宝箱 = dm.FindStrFast(0, 0, 1000, 700, "宝箱", "D4D4D4-2B2B2B", 0.9, out 宝箱x, out 宝箱y);
                            if (宝箱x > 0)
                            {
                                gameOperation.QieGuai();
                                //判断是否选择了宝箱
                                int 选择宝箱x = 0, 选择宝箱y = 0;
                                var 选择宝箱 = dm.FindStrFast(883, 139, 993, 175, "宝箱ui", "ffffff", 0.9, out 选择宝箱x, out 选择宝箱y);
                                if (选择宝箱x < 0)
                                {
                                    continue;
                                }
                                else
                                {
                                    dm.Delays(800, 1000);
                                    dm.RightClick();
                                }
                            }
                            //绿色交付下划线
                            int 绿色下划线退出x = 0, 绿色下划线退出y = 0;
                            dm.FindStrFast(820, 276, 912, 304, "标准下划线", "00ff00", 0.9, out 绿色下划线退出x, out 绿色下划线退出y);
                            if (绿色下划线退出x > 0)
                            {
                                break;
                            }
                          
                        }
                        continue;
                    }
                    #endregion
                    
                    #region 小织娘收入册中
                    dm.Delays(1000, 1200);
                    int 小织娘收入册中x = 0, 小织娘收入册中y = 0;
                    var 小织娘收入册中 = dm.FindStrFast(827, 293, 974, 314, "-将小织女收", "ffffff", 0.9, out 小织娘收入册中x, out 小织娘收入册中y);
                    if (小织娘收入册中x > 0)
                    {
                        while (true)
                        {
                            int 下划线退出x = 0, 下划线退出y = 0;
                            dm.FindStrFast(830, 280, 982, 334, "下划线1|标准下划线", "00ff00|ffbf6c", 0.9, out 下划线退出x, out 下划线退出y);
                            if (下划线退出x > 0)
                            {
                                break;
                            }
                            dm.Delays(400, 500);
                            dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 100), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1000, 1500);
                            dm.Delays(1000, 1200);
                            int 正传x = 0, 正传y = 0;
                            var 正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 正传x, out 正传y);
                            if (正传x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(正传x + gameOperation.RandomNum(5, 35), 正传y + gameOperation.RandomNum(3, 12));
                                dm.Delays(400, 500);
                                dm.LeftClick();
                                dm.Delays(1000, 2000);
                            }
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(400, 500);
                            int fux = 0, fuy = 0;
                            var fu = dm.FindStrFast(0, 0, 1000, 700, "小织", "5F295F-1F2A1F", 0.9, out fux, out fuy);
                            if (fux > 0)
                            {
                                dm.MoveTo(fux + 30, fuy - gameOperation.RandomNum(35, 70));
                                dm.Delays(400, 500);
                                dm.LeftClick();
                                dm.Delays(400, 500);
                            }
                            //等待收入完成
                            while (true)
                            {
                                int 查看成就x = 0, 查看成就y = 0;
                                var 查看成就 = dm.FindStrFast(467, 430, 547, 454, "查看成就", "ffffff", 0.9, out 查看成就x, out 查看成就y);
                                if (查看成就x > 0)
                                {
                                    dm.Delays(400, 500);
                                    dm.MoveTo(查看成就x, 查看成就y);
                                    dm.LeftClick();
                                    break;
                                }
                                dm.delay(1000);
                            }
                        }
                        continue;
                    }
                    #endregion

                    #region 大隐于世(10级)
                    int 大隐于市x = 0, 大隐于市y = 0;
                    var 大隐于市 = dm.FindStrFast(823, 274, 966, 335, "大隐于市", "ffffff", 0.9, out 大隐于市x, out 大隐于市y);
                    if (大隐于市x > 0)
                    {
                        dm.KeyPress(27);
                        dm.Delays(400, 500);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 100), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(400, 500);
                        dm.LeftClick();
                        dm.Delays(1000, 1500);
                        int 大隐于世绿色下划线x = 0, 大隐于世绿色下划线y = 0;
                        var 大隐于世绿色下划线 = dm.FindStrFast(302, 217, 378, 247, "标准下划线", "00ff00", 0.9, out 大隐于世绿色下划线x, out 大隐于世绿色下划线y);
                        if (大隐于世绿色下划线x > 0)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(大隐于世绿色下划线x + gameOperation.RandomNum(10, 30), 大隐于世绿色下划线y - gameOperation.RandomNum(3, 10));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1000, 1500);
                        }
                        continue;
                    }
                    #endregion
                    //击败众妖灵，漏掉了。。。
                    //揪出来了，遗漏
                    #region 镜像新娘
                    int 镜像新娘x = 0, 镜像新娘y = 0;
                    var 镜像新娘 = dm.FindStrFast(823, 274, 966, 335, "镜像新娘", "ffffff", 0.9, out 镜像新娘x, out 镜像新娘y);
                    if (镜像新娘x > 0)
                    {
                        dm.KeyPress(27);
                        dm.Delays(400, 500);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 100), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(400, 500);
                        dm.LeftClick();
                        dm.Delays(1000, 1500);
                        int 两位新娘打招呼x = 0, 两位新娘打招呼y = 0;
                        var 两位新娘打招呼 = dm.FindColor(704, 505, 735, 534, "f7fbff", 0.95, 5, out 两位新娘打招呼x, out 两位新娘打招呼y);
                        if (两位新娘打招呼x > 0)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(两位新娘打招呼x + gameOperation.RandomNum(0, 30), 两位新娘打招呼y + gameOperation.RandomNum(0, 30));
                            dm.LeftClick();
                            dm.Delays(400, 500);
                        }
                        continue;
                    }
                    #endregion

                    #region 打后相识(12级)
                    int 打后相识x = 0, 打后相识y = 0;
                    var 打后相识 = dm.FindStrFast(823, 274, 966, 335, "打后相识", "ffffff", 0.9, out 打后相识x, out 打后相识y);
                    if (打后相识x > 0)
                    {
                        while (true)
                        {
                            dm.KeyPress(27);
                            dm.Delays(400, 500);
                            //绿色交付下划线
                            int 交付绿色下划线x = 0, 交付绿色下划线y = 0;
                            dm.FindStrFast(830, 280, 982, 334, "下划线1|标准下划线", "00ff00", 0.9, out 交付绿色下划线x, out 交付绿色下划线y);
                            if (交付绿色下划线x > 0)
                            {
                                break;
                            }
                            dm.Delays(400, 500);
                            dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 100), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                            dm.Delays(400, 500);
                            dm.RightClick();
                            dm.Delays(1000, 1500);
                            int 打后相识下划线x = 0, 打后相识下划线y = 0;
                            var 打后相识下划线 = dm.FindStrFast(32, 222, 388, 274, "下划线1|标准下划线", "00ff00", 0.9, out 打后相识下划线x, out 打后相识下划线y);
                            if (打后相识下划线x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(打后相识下划线x + gameOperation.RandomNum(10, 30), 打后相识下划线y - gameOperation.RandomNum(3, 10));
                                dm.Delays(400, 500);
                                dm.LeftClick();
                                dm.Delays(1000, 1500);
                                int 正传x = 0, 正传y = 0;
                                var 正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 正传x, out 正传y);
                                if (正传x > 0)
                                {
                                    dm.Delays(400, 500);
                                    dm.MoveTo(正传x + gameOperation.RandomNum(5, 35), 正传y + gameOperation.RandomNum(3, 12));
                                    dm.Delays(400, 500);
                                    dm.LeftClick();
                                    dm.Delays(1000, 2000);
                                    int 进入青丘一隅x = 0, 进入青丘一隅y = 0;
                                    var 进入青丘一隅 = dm.FindStrFast(345, 426, 685, 560, "进入青丘一隅", "ffffff", 0.9, out 进入青丘一隅x, out 进入青丘一隅y);
                                    if (进入青丘一隅x > 0)
                                    {
                                        dm.Delays(400, 500);
                                        dm.MoveTo(进入青丘一隅x + gameOperation.RandomNum(5, 35), 进入青丘一隅y + gameOperation.RandomNum(3, 12));
                                        dm.Delays(400, 500);
                                        dm.LeftClick();
                                        dm.Delays(1000, 2000);
                                        dm.KeyPress(27);
                                        dm.Delays(400, 500);
                                        dm.KeyPress(27);
                                        break;
                                    }
                                }
                            }
                        }
                        while (true)
                        {
                            //绿色交付下划线
                            int 交付绿色下划线x = 0, 交付绿色下划线y = 0;
                            dm.FindStrFast(830, 280, 982, 334, "下划线1|标准下划线", "00ff00", 0.9, out 交付绿色下划线x, out 交付绿色下划线y);
                            if (交付绿色下划线x > 0)
                            {
                                break;
                            }
                            dm.Delays(400, 500);
                            dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 100), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1000, 1500);
                            //切怪
                            gameOperation.QieGuai();
                            //进入战斗
                            gameOperation.ZhanDou();
                            //佳雪加蓝
                            gameOperation.JiaXueJiaLan();
                        }
                        continue;
                    }
                    #endregion

                    #region 阿秀入册
                    int 阿秀入册x = 0, 阿秀入册y = 0;
                    var 阿秀入册 = dm.FindStrFast(827, 276, 957, 296, "阿秀入册", "ffffff", 0.9, out 阿秀入册x, out 阿秀入册y);
                    if (阿秀入册x > 0)
                    {
                        while (true)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 100), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1000, 1200);
                            int 为了追逐美x = 0, 为了追逐美y = 0;
                            dm.FindStrFast(0, 0, 1000, 700, "为了追逐美", "ffd680", 0.9, out 为了追逐美x, out 为了追逐美y);
                            if (为了追逐美x>0)
                            {
                                dm.KeyPress(27);
                                dm.Delays(800, 1200);
                                int 假阿秀x = 0, 假阿秀y = 0;
                                dm.FindStrFast(0, 0, 1000, 700, "假阿秀", "643164-253125", 0.9, out 假阿秀x, out 假阿秀y);
                                if (假阿秀x > 0)
                                {
                                    dm.Delays(400, 500);
                                    dm.MoveTo(假阿秀x + 25, 假阿秀y - gameOperation.RandomNum(30, 55));
                                    dm.Delays(400, 500);
                                    dm.LeftClick();
                                    dm.Delays(1000, 1500);
                                    //循环等待操作完成后再退出
                                    while (true)
                                    {
                                        int 绿色下划线x = 0, 绿色下划线y = 0;
                                        dm.FindStrFast(830, 280, 982, 334, "下划线1|标准下划线", "00ff00", 0.9, out 绿色下划线x, out 绿色下划线y);
                                        if (绿色下划线x > 0)
                                        {
                                            break;
                                        }
                                        dm.delay(1000);
                                    }
                                }
                            }
                            //绿色交付下划线
                            int 交付绿色下划线x = 0, 交付绿色下划线y = 0;
                            dm.FindStrFast(830, 280, 982, 334, "下划线1|标准下划线", "00ff00", 0.9, out 交付绿色下划线x, out 交付绿色下划线y);
                            if (交付绿色下划线x > 0)
                            {
                                break;
                            }
                        }
                        continue;
                    }
                    #endregion

                    #region 花田扑蝶
                    int 花田扑蝶x = 0, 花田扑蝶y = 0;
                    var 花田扑 = dm.FindStrFast(823, 274, 966, 335, "花田扑蝶", "ffffff", 0.9, out 花田扑蝶x, out 花田扑蝶y);
                    if (花田扑蝶x > 0)
                    {
                        dm.KeyPress(27);
                        dm.Delays(400, 500);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 100), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(400, 500);
                        dm.LeftClick();
                        dm.Delays(1000, 1500);
                        //寻路
                        while (true)
                        {
                            var 变量1 = dm.FetchWord(932, 5, 984, 17, "ff2d2d", "(794,608)");
                            dm.Delays(500, 800);
                            var 变量2 = dm.FetchWord(932, 5, 984, 17, "ff2d2d", "(794,608)");
                            dm.Delays(500, 800);
                            if (变量1 == 变量2)
                            {
                                break;
                            }
                        }
                        dm.Delays(500, 800);
                        //
                        gameOperation.QieGuai();
                        while (true)
                        {
                            int 交付绿色下划线x = 0, 交付绿色下划线y = 0;
                            dm.FindStrFast(830, 280, 982, 334, "下划线1|标准下划线", "00ff00", 0.9, out 交付绿色下划线x, out 交付绿色下划线y);
                            if (交付绿色下划线x > 0)
                            {
                                break;
                            }
                            int 死亡凤蝶x = 0, 死亡凤蝶y = 0;
                            var 死亡凤蝶 = dm.FindStrFast(444, 9, 538, 46, "[死亡]凤蝶", "ffffff", 0.9, out 死亡凤蝶x, out 死亡凤蝶y);
                            if (死亡凤蝶x > 0)
                            {
                                gameOperation.QieGuai();
                            }
                            dm.Delays(1000, 1200);
                            dm.KeyPress(49);
                            dm.Delays(1000, 1200);
                            dm.KeyPress(50);
                            dm.Delays(1000, 1200);
                            dm.KeyPress(51);
                            gameOperation.JiaXueJiaLan();
                        }
                        continue;
                    }
                    #endregion
                    #region 猫儿偷鸡
                    int 猫儿偷鸡x = 0, 猫儿偷鸡y = 0;
                    var 猫儿偷鸡 = dm.FindStrFast(823, 274, 966, 335, "猫儿偷鸡", "ffffff", 0.9, out 猫儿偷鸡x, out 猫儿偷鸡y);
                    if (猫儿偷鸡x > 0)
                    {
                        dm.KeyPress(27);
                        dm.Delays(400, 500);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 100), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(400, 500);
                        dm.LeftClick();
                        dm.Delays(1000, 1500);
                        //寻路
                        while (true)
                        {
                            var 变量1 = dm.FetchWord(932, 5, 984, 17, "00ff00", "(765,655)");
                            dm.Delays(500, 800);
                            var 变量2 = dm.FetchWord(932, 5, 984, 17, "00ff00", "(765,655)");
                            dm.Delays(500, 800);
                            if (变量1 == 变量2)
                            {
                                break;
                            }
                        }
                        dm.Delays(500, 800);
                        //查找逗猫桃枝
                        dm.MoveTo(gameOperation.RandomNum(492, 523), gameOperation.RandomNum(200, 230));
                        dm.Delays(800, 1000);
                        dm.RightClick();
                        dm.Delays(800, 1000);
                        dm.KeyPress(50);
                        dm.Delays(800, 1000);
                        continue;
                    }
                    #endregion

                    #region 灵兽出战灵兽休息
                    int 灵兽出战x = 0, 灵兽出战y = 0;
                    var 灵兽出战 = dm.FindStrFast(833, 279, 965, 331, "灵兽出战", "ffffff", 0.9, out 灵兽出战x, out 灵兽出战y);
                    if (灵兽出战x > 0)
                    {
                        dm.Delays(400, 500);
                        dm.KeyPressStr(ScriptData.keySetting.ZhaoHuanLingShou, 10);
                        dm.Delays(400, 500);
                        continue;//继续循环 
                    }
                    int 灵兽休息x = 0, 灵兽休息y = 0;
                    var 灵兽休息 = dm.FindStrFast(833, 279, 965, 331, "灵兽休息", "ffffff", 0.9, out 灵兽休息x, out 灵兽休息y);
                    if (灵兽休息x > 0)
                    {
                        dm.Delays(400, 500);
                        dm.KeyPressStr(ScriptData.keySetting.ZhaoHuanLingShou, 10);
                        dm.Delays(400, 500);
                        continue;//继续循环 
                    }
                    #endregion
                    
                    #region 查探阿纤(7级)
                    int 查探阿纤x = 0, 查探阿纤y = 0;
                    var 查探阿纤 = dm.FindStrFast(829, 280, 981, 338, "查探阿纤", "ffffff", 0.9, out 查探阿纤x, out 查探阿纤y);
                    if (查探阿纤x > 0)
                    {
                        dm.Delays(400, 500);
                        dm.KeyPress(53);//按下5数字键
                        dm.Delays(400, 500);
                        continue;//继续循环 
                    }
                    #endregion
                    #region 意外失踪
                    int 意外失踪7级x = 0, 意外失踪7级y = 0;
                    var 意外失踪7级 = dm.FindStrFast(402, 421, 512, 461, "意外失踪", "ffffff", 0.9, out 意外失踪7级x, out 意外失踪7级y);
                    if (意外失踪7级x > 0)
                    {
                        dm.Delays(400, 500);
                        dm.MoveTo(意外失踪7级x + gameOperation.RandomNum(5, 45), 意外失踪7级y + gameOperation.RandomNum(3, 16));
                        dm.Delays(400, 500);
                        dm.LeftClick();
                        dm.Delays(400, 500);
                        continue;
                    }
                    #endregion
                    #region 小蜘蛛娘
                    int 小蜘蛛娘x = 0, 小蜘蛛娘y = 0;
                    dm.FindStrFast(823, 274, 966, 335, "小蜘蛛娘 ", "ffffff", 0.9, out 小蜘蛛娘x, out 小蜘蛛娘y);
                    if (小蜘蛛娘x > 0)
                    {
                        while (true)
                        {
                            dm.KeyPress(27);
                            dm.Delays(400, 500);
                            dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 100), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1000, 1500);
                            //寻路
                            while (true)
                            {
                                var 变量1 = dm.FetchWord(932, 5, 984, 17, "00ff00", "(722,599)");
                                dm.Delays(500, 800);
                                var 变量2 = dm.FetchWord(932, 5, 984, 17, "00ff00", "(722,599)");
                                dm.Delays(500, 800);
                                if (变量1 == 变量2)
                                {
                                    break;
                                }
                            }
                            int 正传x = 0, 正传y = 0;
                            var 正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 正传x, out 正传y);
                            if (正传x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(正传x + gameOperation.RandomNum(5, 35), 正传y + gameOperation.RandomNum(3, 12));
                                dm.Delays(400, 500);
                                dm.LeftClick();
                                dm.Delays(1000, 2000);
                                break;
                            }
                        }
                        continue;
                    }
                    #endregion
                    #region 蛛丝山洞
                    int 蛛丝山洞x = 0, 蛛丝山洞y = 0;
                    var 蛛丝山 = dm.FindStrFast(823, 274, 966, 335, "蛛丝山洞 ", "ffffff", 0.9, out 蛛丝山洞x, out 蛛丝山洞y);
                    if (蛛丝山洞x > 0)
                    {
                        while (true)
                        {
                            dm.KeyPress(27);
                            dm.Delays(400, 500);
                            dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 100), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1000, 1500);
                            //寻路
                            while (true)
                            {
                                int corX = 0, corY = 0;
                                var 变量1 = dm.FindColor(932, 5, 984, 17, "66ff00", 0.9, 5, out corX, out corY);
                                if (corX > 0)
                                {
                                    break;
                                }
                                dm.Delays(1000, 1200);

                            }
                            dm.Delays(1000, 1200);
                            int 正传x = 0, 正传y = 0;
                            var 正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 正传x, out 正传y);
                            if (正传x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(正传x + gameOperation.RandomNum(5, 35), 正传y + gameOperation.RandomNum(3, 12));
                                dm.Delays(400, 500);
                                dm.LeftClick();
                                dm.Delays(1000, 2000);
                                break;
                            }
                        }
                        continue;
                    }
                    #endregion
                    #region 独门秘籍
                    int 独门秘籍x = 0, 独门秘籍y = 0;
                    var 独门秘籍 = dm.FindStrFast(823, 274, 966, 335, "独门秘籍", "ffffff", 0.9, out 独门秘籍x, out 独门秘籍y);
                    if (独门秘籍x > 0)
                    {
                        while (true)
                        {
                            int 交付绿色下划线x = 0, 交付绿色下划线y = 0;
                            dm.FindStrFast(830, 280, 982, 334, "下划线1|标准下划线", "00ff00", 0.9, out 交付绿色下划线x, out 交付绿色下划线y);
                            if (交付绿色下划线x > 0)
                            {
                                break;
                            }
                            dm.KeyPress(27);
                            dm.Delays(400, 500);
                            dm.KeyPress(27);
                            dm.Delays(400, 500);
                            dm.KeyPress(27);
                            dm.Delays(400, 500);
                            dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 100), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1000, 1500);
                            int 崂山道士x = 0, 崂山道士y = 0;
                            var 崂山道士 = dm.FindStrFast(69, 204, 159, 228, "崂山道士", "00ff00", 0.9, out 崂山道士x, out 崂山道士y);
                            if (崂山道士x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(崂山道士x + gameOperation.RandomNum(10, 30), 崂山道士y + gameOperation.RandomNum(3, 10));
                                dm.Delays(400, 500);
                                dm.LeftClick();
                                dm.Delays(1000, 1500);
                                int 天狼方秘籍x = 0, 天狼方秘籍y = 0;
                                var 天狼方秘籍 = dm.FindStrFast(365, 425, 489, 594, "天狼方秘籍", "ffffff", 0.9, out 天狼方秘籍x, out 天狼方秘籍y);
                                if (天狼方秘籍x > 0)
                                {
                                    dm.Delays(400, 500);
                                    dm.MoveTo(天狼方秘籍x + gameOperation.RandomNum(5, 55), 天狼方秘籍y + gameOperation.RandomNum(3, 12));
                                    dm.Delays(400, 500);
                                    dm.LeftClick();
                                    dm.Delays(1000, 2000);
                                }
                                //先判断包裹里有没有秘籍
                                int mijix = 0, mijiy = 0;
                                var miji = dm.FindPic(545, 226, 870, 429, "\\img\\miji.bmp", "000000", 0.9, 0, out mijix, out mijiy);
                                if (mijix > 0)
                                {
                                    int 商店x = 0, 商店y = 0;
                                    dm.FindStrFast(310, 126, 361, 146, "商店", "D7D8E2-28271D", 0.9, out 商店x, out 商店y);
                                    if (商店x > 0)
                                    {
                                        //先关闭商店
                                        dm.MoveTo(商店x + gameOperation.RandomNum(204, 212), 商店y);
                                        dm.Delays(400, 500);
                                        dm.LeftClick();
                                        dm.Delays(1000, 1500);
                                    }
                                    dm.MoveTo(mijix, mijiy);
                                    dm.Delays(400, 500);
                                    dm.RightClick();
                                    dm.Delays(1000, 1500);
                                    continue;
                                }

                                //添加月满西楼(秘籍)
                                int 月满西楼秘籍x = 0, 月满西楼秘籍y = 0;
                                var 月满西楼 = dm.FindStrFast(202, 199, 313, 242, "月满西楼(秘", "ffffff", 0.9, out 月满西楼秘籍x, out 月满西楼秘籍y);
                                if (月满西楼秘籍x > 0)
                                {
                                    dm.Delays(400, 500);
                                    dm.MoveTo(月满西楼秘籍x + gameOperation.RandomNum(5, 55), 月满西楼秘籍y + gameOperation.RandomNum(3, 30));
                                    dm.Delays(400, 500);
                                    dm.LeftClick();
                                    dm.Delays(1000, 2000);
                                    dm.MoveTo(月满西楼秘籍x + gameOperation.RandomNum(235, 290), 月满西楼秘籍y + gameOperation.RandomNum(200, 216));//移动鼠标到确定按钮购买
                                    dm.Delays(400, 500);
                                    dm.LeftClick();
                                    dm.Delays(1000, 1500);
                                }
                                //添加九转天狼变(秘籍)
                                int 九转天狼变秘籍x = 0, 九转天狼变秘籍y = 0;
                                var 九转天狼变秘籍 = dm.FindStrFast(383, 200, 517, 248, "九转天狼变(", "ffffff", 0.9, out 九转天狼变秘籍x, out 九转天狼变秘籍y);
                                if (九转天狼变秘籍x > 0)
                                {
                                    dm.Delays(400, 500);
                                    dm.MoveTo(九转天狼变秘籍x + gameOperation.RandomNum(5, 55), 九转天狼变秘籍y + gameOperation.RandomNum(3, 30));
                                    dm.Delays(400, 500);
                                    dm.LeftClick();
                                    dm.Delays(1000, 2000);
                                    dm.MoveTo(九转天狼变秘籍x + gameOperation.RandomNum(60, 110), 九转天狼变秘籍y + gameOperation.RandomNum(202, 218));//移动鼠标到确定按钮购买
                                    dm.Delays(400, 500);
                                    dm.LeftClick();
                                    dm.Delays(1000, 1500);
                                    //int 包裹x = 0, 包裹y = 0;
                                    //var 包裹 = dm.FindStrFast(555, 202, 611, 223, "包裹", "ffffff", 0.9, out 包裹x, out 包裹y);

                                }
                                //正传
                                int 崂山道士正传x = 0, 崂山道士正传y = 0;
                                var 崂山道士正传 = dm.FindStrFast(366, 429, 557, 452, "[正传]", "ffffff", 0.9, out 崂山道士正传x, out 崂山道士正传y);
                                if (崂山道士正传x > 0)
                                {
                                    dm.Delays(400, 500);
                                    dm.MoveTo(崂山道士正传x + gameOperation.RandomNum(5, 35), 崂山道士正传y + gameOperation.RandomNum(3, 12));
                                    dm.Delays(400, 500);
                                    dm.LeftClick();
                                    dm.Delays(1000, 2000);
                                }
                            }
                        }
                        continue;
                    }
                    #endregion
                    
                    #region 功力大增
                    int 功力大增x = 0, 功力大增y = 0;
                    var 功力大增 = dm.FindStrFast(823, 274, 966, 335, "功力大增", "ffffff", 0.9, out 功力大增x, out 功力大增y);
                    if (功力大增x > 0)
                    {

                        //点击升级技能
                        while (true)
                        {
                            dm.KeyPress(27);
                            dm.Delays(400, 500);
                            dm.KeyPress(27);
                            dm.Delays(400, 500);
                            dm.Delays(400, 500);
                            dm.KeyPress(67);//按下快捷键c
                            dm.Delays(400, 500);
                            int 交付绿色下划线x = 0, 交付绿色下划线y = 0;
                            dm.FindStrFast(830, 280, 982, 334, "下划线1|标准下划线", "00ff00", 0.9, out 交付绿色下划线x, out 交付绿色下划线y);
                            if (交付绿色下划线x > 0)
                            {
                                break;
                            }
                            int 升级技能x = 0, 升级技能y = 0;
                            var 升级技能 = dm.FindStrFast(600, 138, 670, 161, "升级", "ffffff", 0.9, out 升级技能x, out 升级技能y);
                            if (升级技能x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(升级技能x + gameOperation.RandomNum(5, 35), 升级技能y + gameOperation.RandomNum(3, 14));
                                dm.Delays(400, 500);
                                dm.LeftClick();
                                dm.Delays(1000, 2000);
                                dm.MoveTo(gameOperation.RandomNum(0, 200), gameOperation.RandomNum(0, 200));
                                dm.Delays(400, 500);
                                //找图（月满西楼）
                                int 月满西楼iconX = 0, 月满西楼iconY = 0;
                                var 月满西楼icon = dm.FindPic(210, 141, 794, 560, "\\img\\yuemanxilou.bmp", "000000", 0.9, 0, out 月满西楼iconX, out 月满西楼iconY);
                                dm.Delays(1500, 2000);
                                if (月满西楼iconX > 0)
                                {
                                    dm.MoveTo(月满西楼iconX + gameOperation.RandomNum(0, 10), 月满西楼iconY + gameOperation.RandomNum(0, 10));
                                    dm.Delays(400, 500);
                                    dm.LeftClick();//点击技能
                                    dm.Delays(800, 1000);
                                    dm.MoveTo(gameOperation.RandomNum(0, 200), gameOperation.RandomNum(0, 200));
                                    dm.Delays(400, 600);
                                    //点击确定按钮
                                    while (true)
                                    {
                                        int 确定升级x = 0, 确定升级y = 0;
                                        var 确定升级 = dm.FindStrFast(769, 600, 880, 623, "升级", "ffffff", 0.9, out 确定升级x, out 确定升级y);
                                        if (确定升级x > 0)
                                        {
                                            dm.MoveTo(确定升级x + gameOperation.RandomNum(0, 40), 确定升级y + gameOperation.RandomNum(0, 15));
                                            dm.Delays(400, 500);
                                            dm.LeftClick();//点击升级
                                            dm.Delays(800, 1000);
                                            break;
                                        }
                                        dm.Delays(600, 800);
                                    }
                                    dm.KeyPress(27);
                                    dm.Delays(400, 500);
                                    dm.KeyPress(27);
                                    dm.Delays(400, 500);
                                    break;
                                }
                            }
                        }
                        continue;
                    }
                    #endregion

                    #region 不安异象
                    int 不安异象x = 0, 不安异象y = 0;
                    var 不安异象 = dm.FindStrFast(823, 274, 966, 335, "不安异象 ", "ffffff", 0.9, out 不安异象x, out 不安异象y);
                    if (不安异象x > 0)
                    {
                        while (true)
                        {
                            dm.KeyPress(27);
                            dm.Delays(400, 500);
                            dm.KeyPress(27);
                            dm.Delays(400, 500);
                            dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 100), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1000, 1500);
                            int 绿色下划线x = 0, 绿色下划线y = 0;
                            dm.FindStrFast(293, 198, 382, 229, "白色下划线|标准下划线", "00ff00", 0.9, out 绿色下划线x, out 绿色下划线y);
                            if (绿色下划线x > 0)
                            {
                                //按tab键打开地图
                                dm.KeyPress(9);
                                dm.Delays(400, 500);
                                int 寻路x = 0, 寻路y = 0;
                                dm.FindStrFast(300, 138, 340, 154, "寻路", "ffffff", 0.9, out 寻路x, out 寻路y);
                                if (寻路x > 0)
                                {
                                    dm.MoveTo(寻路x - gameOperation.RandomNum(55, 78), 寻路y);
                                    dm.LeftDoubleClick();
                                    dm.KeyPressStr("170", 50);
                                    dm.Delays(1000, 1200);
                                    dm.MoveTo(寻路x - gameOperation.RandomNum(18, 40), 寻路y);
                                    dm.LeftDoubleClick();
                                    dm.KeyPressStr("160", 50);
                                    dm.Delays(1000, 1200);
                                    dm.MoveTo(寻路x + gameOperation.RandomNum(0, 15), 寻路y);
                                    dm.LeftClick();
                                    dm.Delays(400, 500);
                                }
                                //寻路
                                while (true)
                                {
                                    int 寻路紫色x = 0, 寻路紫色y = 0;
                                    dm.FindColor(440, 350, 714, 503, "e700ff", 0.9, 5, out 寻路紫色x, out 寻路紫色y);
                                    if (寻路紫色x > 0)
                                    {
                                        dm.delay(1000);
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                dm.KeyPress(9);//关闭地图
                                gameOperation.QieGuai();
                                while (true)
                                {
                                    int 妖虎死亡x = 0, 妖虎死亡y = 0;
                                    var 妖虎死亡 = dm.FindStrFast(420, 4, 580, 70, "[死亡]", "ffffff", 0.9, out 妖虎死亡x, out 妖虎死亡y);
                                    if (妖虎死亡x > 0)
                                    {
                                        gameOperation.QieGuai();
                                    }
                                    gameOperation.ZhanDou();//战斗
                                    gameOperation.JiaXueJiaLan();//佳雪

                                    int 妖虎战斗退出下划线x = 0, 妖虎战斗退出下划线y = 0;
                                    dm.FindStrFast(830, 280, 982, 334, "下划线1|标准下划线", "00ff00", 0.9, out 妖虎战斗退出下划线x, out 妖虎战斗退出下划线y);
                                    if (妖虎战斗退出下划线x > 0)
                                    {
                                        break;
                                    }
                                }



                                //正传
                                int 正传x = 0, 正传y = 0;
                                var 正传 = dm.FindStrFast(366, 429, 557, 452, "[正传]", "ffffff", 0.9, out 正传x, out 正传y);
                                if (正传x > 0)
                                {
                                    dm.Delays(400, 500);
                                    dm.MoveTo(正传x + gameOperation.RandomNum(5, 35), 正传y + gameOperation.RandomNum(3, 12));
                                    dm.Delays(400, 500);
                                    dm.LeftClick();
                                    dm.Delays(1000, 2000);
                                }
                            }
                            //退出妖虎任务循环
                            int 不安异象交付x = 0, 不安异象交付y = 0;
                            dm.FindStrFast(830, 280, 982, 334, "下划线1|标准下划线", "00ff00", 0.9, out 不安异象交付x, out 不安异象交付y);
                            if (不安异象交付x > 0)
                            {
                                break;
                            }
                        }
                        continue;
                    }
                    #endregion

                    #region 崔家阿猛逢采臣
                    int 阿猛逢采臣x = 0, 阿猛逢采臣y = 0;
                    var 阿猛逢采臣 = dm.FindStrFast(865, 274, 974, 318, "阿猛逢采臣", "ffffff", 0.9, out 阿猛逢采臣x, out 阿猛逢采臣y);
                    if (阿猛逢采臣x > 0)
                    {
                        while (true)
                        {
                            dm.KeyPress(27);
                            dm.Delays(400, 500);
                            dm.KeyPress(27);
                            dm.Delays(400, 500);
                            dm.MoveTo(阿猛逢采臣x + gameOperation.RandomNum(0, 50), 阿猛逢采臣y + gameOperation.RandomNum(3, 12));
                            dm.Delays(400, 500);
                            dm.RightClick();//点击技能
                            dm.Delays(800, 1000);
                            //点击绿色坐标
                            int 阿猛逢采臣下划线x = 0, 阿猛逢采臣下划线y = 0;
                            var 阿猛逢采臣绿色下划线 = dm.FindStrFast(54, 192, 376, 283, "下划线1|标准下划线", "00ff00", 0.9, out 阿猛逢采臣下划线x, out 阿猛逢采臣下划线y);
                            if (阿猛逢采臣下划线x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(阿猛逢采臣下划线x + gameOperation.RandomNum(10, 30), 阿猛逢采臣下划线y - gameOperation.RandomNum(3, 10));
                                dm.Delays(400, 500);
                                dm.LeftClick();
                                dm.Delays(1000, 1500);
                                int 二级正传x = 0, 二级正传y = 0;
                                var 二级正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 二级正传x, out 二级正传y);
                                if (二级正传x > 0)
                                {
                                    dm.Delays(400, 500);
                                    dm.MoveTo(二级正传x + gameOperation.RandomNum(5, 35), 二级正传y + gameOperation.RandomNum(3, 12));
                                    dm.Delays(400, 500);
                                    dm.LeftClick();
                                    dm.Delays(1000, 2000);
                                    int 崔猛家x = 0, 崔猛家y = 0;
                                    var 崔猛家 = dm.FindStrFast(345, 426, 685, 560, "崔猛家", "ffffff", 0.9, out 崔猛家x, out 崔猛家y);
                                    if (崔猛家x > 0)
                                    {
                                        dm.Delays(400, 500);
                                        dm.MoveTo(崔猛家x + gameOperation.RandomNum(5, 35), 崔猛家y + gameOperation.RandomNum(3, 12));
                                        dm.Delays(400, 500);
                                        dm.LeftClick();
                                        dm.Delays(1000, 2000);
                                        break;
                                    }

                                }

                            }

                        }
                        //崔猛战斗
                        while (true)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(阿猛逢采臣x + gameOperation.RandomNum(0, 50), 阿猛逢采臣y + gameOperation.RandomNum(3, 12));
                            dm.Delays(400, 500);
                            dm.LeftClick();//点击技能
                            dm.Delays(800, 1000);
                            int 交付绿色下划线x = 0, 交付绿色下划线y = 0;
                            dm.FindStrFast(830, 280, 982, 334, "下划线1|标准下划线", "00ff00", 0.9, out 交付绿色下划线x, out 交付绿色下划线y);
                            if (交付绿色下划线x > 0)
                            {
                                break;
                            }
                            gameOperation.QieGuai();
                            gameOperation.ZhanDou();
                            gameOperation.JiaXueJiaLan();
                        }
                        continue;
                    }
                    #endregion
                    
                    #region 阿舒是鼠
                    int 阿舒是鼠x = 0, 阿舒是鼠y = 0;
                    var 阿舒是 = dm.FindStrFast(865, 274, 974, 318, "阿舒是鼠 ", "ffffff", 0.9, out 阿舒是鼠x, out 阿舒是鼠y);
                    if (阿舒是鼠x > 0)
                    {
                        dm.Delays(400, 500);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 100), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(400, 500);
                        dm.LeftClick();
                        dm.Delays(1000, 1500);
                        //找小鱼图片
                        int 小鱼x = 0, 小鱼y = 0;
                        var 小鱼 = dm.FindPic(497, 197, 528, 231, "\\img\\xiaoyu.bmp", "000000", 0.9, 0, out 小鱼x, out 小鱼y);
                        if (小鱼x > 0)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(小鱼x + gameOperation.RandomNum(5, 10), 小鱼y + gameOperation.RandomNum(3, 10));
                            dm.Delays(400, 500);
                            dm.RightClick();
                            dm.Delays(1000, 2000);
                        }
                        continue;
                    }
                    #endregion

                    #region 小小宅妖，坐标有误，要设置窗口大小
                    int 小小宅妖x = 0, 小小宅妖y = 0;
                    var 小小宅妖 = dm.FindStrFast(865, 274, 974, 318, "小小宅妖 ", "ffffff", 0.9, out 小小宅妖x, out 小小宅妖y);
                    if (小小宅妖x > 0)
                    {
                        dm.Delays(400, 500);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 100), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(400, 500);
                        dm.LeftClick();
                        dm.Delays(1000, 1500);
                        //找坐下表情图片
                        int 坐下表情x = 0, 坐下表情y = 0;
                        var 坐下表情 = dm.FindPic(694, 492, 730, 528, "\\img\\zuoxiabiaoqing.bmp", "000000", 0.9, 0, out 坐下表情x, out 坐下表情y);
                        if (坐下表情x > 0)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(坐下表情x, 坐下表情y + gameOperation.RandomNum(3, 15));
                            dm.Delays(400, 500);
                            dm.RightClick();
                            dm.Delays(1000, 2000);
                        }
                        continue;
                    }
                    #endregion

                    #region 身体缩小
                    int 身体缩小x = 0, 身体缩小y = 0;
                    var 身体缩小 = dm.FindStrFast(865, 274, 974, 318, "身体缩小 ", "ffffff", 0.9, out 身体缩小x, out 身体缩小y);
                    if (身体缩小x > 0)
                    {
                        dm.Delays(400, 500);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 100), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(400, 500);
                        dm.LeftClick();
                        dm.Delays(1000, 1500);
                        //找变小药水图片
                        int 变小药水x = 0, 变小药水y = 0;
                        var 变小药水 = dm.FindPic(496, 200, 529, 230, "\\img\\bianxiaoyaoshui.bmp", "000000", 0.9, 0, out 变小药水x, out 变小药水y);
                        if (变小药水x > 0)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(变小药水x, 变小药水y + gameOperation.RandomNum(3, 15));
                            dm.Delays(400, 500);
                            dm.RightClick();
                            dm.Delays(1000, 2000);
                        }
                        continue;
                    }
                    #endregion
                    
                    #region 宅妖斗瓢虫
                    int 宅妖斗瓢虫x = 0, 宅妖斗瓢虫y = 0;
                    var 宅妖斗瓢 = dm.FindStrFast(865, 274, 974, 318, "宅妖斗瓢虫", "ffffff", 0.9, out 宅妖斗瓢虫x, out 宅妖斗瓢虫y);
                    if (宅妖斗瓢虫x > 0)
                    {
                        dm.Delays(400, 500);
                        while (true)
                        {
                            //dm.KeyPress(9);//打开地图
                            //dm.Delays(1000, 1200);
                            //dm.MoveTo(gameOperation.RandomNum(364, 445), gameOperation.RandomNum(140, 145));
                            //dm.Delays(1000, 1200);
                            //dm.LeftDoubleClick();
                            //dm.Delays(1000, 1500);
                            //dm.SendString(user.hwnd, "十星瓢虫");
                            //dm.Delays(1000, 1200);
                            //dm.KeyPress(13);
                            gameOperation.FindNpc("十星瓢虫");
                            int 二级正传x = 0, 二级正传y = 0;
                            var 二级正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 二级正传x, out 二级正传y);
                            if (二级正传x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(二级正传x + gameOperation.RandomNum(5, 35), 二级正传y + gameOperation.RandomNum(3, 12));
                                dm.Delays(400, 500);
                                dm.LeftClick();
                                dm.Delays(1000, 2000);
                                int 镇中鼠洞x = 0, 镇中鼠洞y = 0;
                                var 镇中鼠洞 = dm.FindStrFast(345, 426, 685, 560, "镇中鼠洞", "ffffff", 0.9, out 镇中鼠洞x, out 镇中鼠洞y);
                                if (镇中鼠洞x > 0)
                                {
                                    dm.Delays(400, 500);
                                    dm.MoveTo(镇中鼠洞x + gameOperation.RandomNum(5, 35), 镇中鼠洞y + gameOperation.RandomNum(3, 12));
                                    dm.Delays(400, 500);
                                    dm.LeftClick();
                                    dm.Delays(1000,1200);
                                    break;
                                }
                            }
                        }
                        dm.KeyPress(27);
                        dm.Delays(1000, 1200);
                        dm.KeyPress(27);
                        dm.Delays(1000, 1200);
                        //战斗
                        while (true)
                        {
                            int 交付绿色下划线x = 0, 交付绿色下划线y = 0;
                            dm.FindStrFast(830, 280, 982, 334, "下划线1|标准下划线", "00ff00", 0.9, out 交付绿色下划线x, out 交付绿色下划线y);
                            if (交付绿色下划线x > 0)
                            {
                                break;
                            }
                            gameOperation.QieGuai();
                            gameOperation.ZhanDou();
                            gameOperation.JiaXueJiaLan();
                        }
                        continue;
                    }
                    #endregion
                    #region 睡鼠小弟
                    int 睡鼠小弟x = 0, 睡鼠小弟y = 0;
                    var 睡鼠小弟 = dm.FindStrFast(865, 274, 974, 318, "睡鼠小弟 ", "ffffff", 0.9, out 睡鼠小弟x, out 睡鼠小弟y);
                    if (睡鼠小弟x > 0)
                    {
                        dm.Delays(400, 500);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 100), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(400, 500);
                        dm.LeftClick();
                        dm.Delays(1000, 1500);
                        //寻路
                        dm.KeyPress(9);//打开地图
                        while (true)
                        {
                            int 寻路紫色x = 0, 寻路紫色y = 0;
                            dm.FindColor(146, 192, 899, 634, "e700ff", 0.9, 5, out 寻路紫色x, out 寻路紫色y);
                            if (寻路紫色x > 0)
                            {
                                dm.delay(1000);
                            }
                            else
                            {
                                break;
                            }
                        }
                        dm.KeyPress(9);//关闭地图
                        //捡起松果
                       
                        while (true)
                        {
                            int 交付绿色下划线x = 0, 交付绿色下划线y = 0;
                            dm.FindStrFast(830, 280, 982, 334, "下划线1|标准下划线", "00ff00", 0.9, out 交付绿色下划线x, out 交付绿色下划线y);
                            if (交付绿色下划线x > 0)
                            {
                                break;
                            }
                            //int 松果x = 0, 松果y = 0;
                            //var 松果 = dm.FindPic(0, 0, 1000, 700, "\\img\\songguo.bmp", "000000", 0.9, 0, out 松果x, out 松果y);
                            //if (松果x > 0)
                            //{
                            //    dm.Delays(400, 500);
                            //    dm.MoveTo(松果x, 松果y);
                            //    dm.Delays(400, 500);
                            //    dm.LeftClick();
                            //    dm.Delays(400, 500);
                            //}
                            //else
                            //{
                            //    dm.Delays(400, 500);
                            //}
                            //dm.Delays(800, 1000);
                            dm.Delays(800, 1000);
                            dm.MoveTo(gameOperation.RandomNum(519, 537), gameOperation.RandomNum(446, 462));
                            dm.Delays(800, 1000);
                            dm.LeftClick();
                            dm.Delays(2000, 3000);
                        }
                        continue;
                    }
                    #endregion

                    #region 花中田鼠
                    int 花中田鼠x = 0, 花中田鼠y = 0;
                    var 花中田鼠 = dm.FindStrFast(865, 274, 974, 318, "花中田鼠 ", "ffffff", 0.9, out 花中田鼠x, out 花中田鼠y);
                    if (花中田鼠x > 0)
                    {
                        dm.Delays(800, 1000);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 100), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(800, 1000);
                        dm.LeftClick();
                        dm.Delays(1000, 1200);
                        dm.KeyPress(53);
                        dm.Delays(800, 1000);
                        continue;
                        //int 燃犀烛照x = 0, 燃犀烛照y = 0;
                        //var 燃犀烛照 = dm.FindPic(695, 495, 729, 527, "\\img\\ranxizhuzhao.bmp", "000000", 0.9, 0, out 燃犀烛照x, out 燃犀烛照y);
                        //if (燃犀烛照x > 0)
                        //{
                        //    dm.Delays(400, 500);
                        //    dm.MoveTo(燃犀烛照x + gameOperation.RandomNum(0, 8), 燃犀烛照y + gameOperation.RandomNum(0, 8));
                        //    dm.Delays(400, 500);
                        //    dm.LeftClick();
                        //    dm.Delays(1000, 1500);
                        //}
                    }
                    #endregion

                    #region 苞米之恩
                    int 苞米之恩x = 0, 苞米之恩y = 0;
                    var 苞米之恩 = dm.FindStrFast(865, 274, 974, 318, "苞米之恩 ", "ffffff", 0.9, out 苞米之恩x, out 苞米之恩y);
                    if (苞米之恩x > 0)
                    {

                        while (true)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1000, 1500);
                            dm.KeyPress(53);
                            dm.Delays(1000, 1500);
                            int 琥珀苞米x = 0, 琥珀苞米y = 0;
                            dm.FindColor(508, 415, 670, 515, "fff1d1-101010|e9785e-101010", 1.0, 0, out 琥珀苞米x, out 琥珀苞米y);
                            if (琥珀苞米x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(琥珀苞米x, 琥珀苞米y + gameOperation.RandomNum(20, 30));
                                dm.Delays(400, 500);
                                dm.LeftClick();
                                dm.Delays(2500, 3000);
                            }
                            int 交付绿色下划线x = 0, 交付绿色下划线y = 0;
                            dm.FindStrFast(830, 280, 982, 334, "下划线1|标准下划线", "00ff00", 0.9, out 交付绿色下划线x, out 交付绿色下划线y);
                            if (交付绿色下划线x > 0)
                            {
                                break;
                            }
                            dm.Delays(800, 1000);
                        }
                        continue;
                    }
                    #endregion
                    #region 傅贵有悔
                    int 傅贵有悔x = 0, 傅贵有悔y = 0;
                    var 傅贵有悔 = dm.FindStrFast(865, 274, 974, 318, "傅贵有悔 ", "ffffff", 0.9, out 傅贵有悔x, out 傅贵有悔y);
                    if (傅贵有悔x > 0)
                    {
                        dm.Delays(400, 500);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(400, 500);
                        dm.LeftClick();
                        dm.Delays(1000, 1500);
                        dm.MoveTo(gameOperation.RandomNum(500, 525), gameOperation.RandomNum(200, 230));
                        dm.Delays(400, 500);
                        dm.RightClick();
                        dm.Delays(400, 500);
                        continue;
                    }
                    #endregion

                    #region 千金散尽
                    int 千金散尽x = 0, 千金散尽y = 0;
                    var 千金散尽 = dm.FindStrFast(865, 274, 974, 318, "千金散尽 ", "ffffff", 0.9, out 千金散尽x, out 千金散尽y);
                    if (千金散尽x > 0)
                    {
                        dm.Delays(400, 500);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(400, 500);
                        dm.LeftClick();
                        dm.Delays(1000, 1500);
                        int 符纸x = 0, 符纸y = 0;
                        dm.FindPic(0, 0, 1000, 768, "\\img\\fuzhi.bmp", "000000", 0.9, 0, out 符纸x, out 符纸y);
                        if (符纸x > 0)
                        {
                            dm.MoveToEx(符纸x,符纸y,5,5);
                            dm.Delays(800, 1000);
                            dm.LeftClick();
                            dm.Delays(1500, 2000);
                        }
                        //int 小小人x = 0, 小小人y = 0;
                        //var 小小人 = dm.FindStrFast(0, 0, 100, 768, " 小小人 ", "5F295F-1F2A1F", 0.9, out 小小人x, out 小小人y);
                        //if (小小人x > 0)
                        //{
                        //    dm.MoveTo(小小人x+gameOperation.RandomNum(26, 34), 小小人y-gameOperation.RandomNum(40, 69));
                        //    dm.Delays(400, 500);
                        //    dm.LeftClick();
                        //    dm.Delays(400, 500);
                        //}
                        continue;
                    }
                    #endregion
                    
                    #region 多番打听
                    int 多番打听x = 0, 多番打听y = 0;
                    var 多番打听 = dm.FindStrFast(865, 274, 974, 318, "多番打听 ", "ffffff", 0.9, out 多番打听x, out 多番打听y);
                    if (多番打听x > 0)
                    {
                        //任务1王夫人
                        while (true)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                            dm.Delays(400, 500);
                            dm.LeftClick();//点击可跳过对话
                            dm.Delays(1000, 1500);
                            int 正传x = 0, 正传y = 0;
                            var 正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 正传x, out 正传y);
                            if (正传x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(正传x + gameOperation.RandomNum(5, 35), 正传y + gameOperation.RandomNum(3, 12));
                                dm.Delays(400, 500);
                                dm.LeftClick();
                                dm.Delays(1000, 2000);
                                break;
                            }
                        }
                        //任务2抱月
                        while (true)
                        {
                            dm.Delays(400, 500);
                            dm.LeftClick();//点击可跳过对话
                            int 抱月白色下划线x = 0, 抱月白色下划线y = 0;
                            var 抱月白色下划线 = dm.FindStrFast(827, 277, 960, 345, "-抱月", "ffffff", 0.9, out 抱月白色下划线x, out 抱月白色下划线y);
                            if (抱月白色下划线x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(抱月白色下划线x + gameOperation.RandomNum(10, 40), 抱月白色下划线y + gameOperation.RandomNum(3, 10));
                                dm.Delays(400, 500);
                                dm.LeftClick();
                                dm.Delays(1000, 2000);
                                int 正传x = 0, 正传y = 0;
                                var 正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 正传x, out 正传y);
                                if (正传x > 0)
                                {
                                    dm.Delays(400, 500);
                                    dm.MoveTo(正传x + gameOperation.RandomNum(5, 35), 正传y + gameOperation.RandomNum(3, 12));
                                    dm.Delays(400, 500);
                                    dm.LeftClick();
                                    dm.Delays(1000, 2000);
                                    break;
                                }
                            }
                        }
                        continue;
                    }
                    #endregion

                    #region 琵琶弦上
                    int 琵琶弦上x = 0, 琵琶弦上y = 0;
                    var 琵琶弦上 = dm.FindStrFast(865, 274, 974, 318, "琵琶弦上", "ffffff", 0.9, out 琵琶弦上x, out 琵琶弦上y);
                    if (琵琶弦上x > 0)
                    {
                        while (true)
                        {
                            dm.KeyPress(27);
                            dm.Delays(800, 1000);
                            dm.KeyPress(27);
                            dm.Delays(800, 1000);
                            dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                            dm.Delays(1000, 1200);
                            dm.LeftClick();//点击可跳过对话
                            dm.Delays(1000, 1500);
                            int 绿色下划线x = 0, 绿色下划线y = 0;
                            var 任务下划线 = dm.FindStrFast(264, 225, 374, 270, "白色下划线", "00ff00", 0.9, out 绿色下划线x, out 绿色下划线y);
                            if (绿色下划线x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(绿色下划线x + gameOperation.RandomNum(10, 35), 绿色下划线y - gameOperation.RandomNum(3, 10));
                                dm.Delays(400, 500);
                                dm.LeftClick();//
                                dm.Delays(1000, 1500);
                                int 重新安装x = 0, 重新安装y = 0;
                                var 重新安装 = dm.FindStrFast(345, 426, 685, 560, "重新开始安", "ffffff", 0.9, out 重新安装x, out 重新安装y);
                                if (重新安装x > 0)
                                {
                                    dm.Delays(400, 500);
                                    dm.MoveTo(重新安装x + gameOperation.RandomNum(5, 35), 重新安装y + gameOperation.RandomNum(3, 12));
                                    dm.Delays(400, 500);
                                    dm.LeftClick();
                                    dm.Delays(1000, 2000);
                                    break;
                                }
                            }
                        }
                        //复手
                        while (true)
                        {
                            
                            int 复手1x = 0, 复手1y = 0;
                            dm.FindStrFast(188, 549, 230, 578, "复手", "91A5D0-14322F", 0.9, out 复手1x, out 复手1y);
                            if (复手1x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(复手1x + 125, 复手1y);
                                dm.Delays(400, 500);
                                dm.LeftClick();
                                dm.Delays(5000, 6000);
                            }
                            int 复手安装成功x = 0, 复手安装成功y = 0;
                            dm.FindStrFast(507, 312, 529, 332, "复手安装成功", "5ECD7B-1D2A22", 0.9, out 复手安装成功x, out 复手安装成功y);
                            if (复手安装成功x>0)
                            {
                                break;
                            }
                        }
                        //琴轴
                        while (true)
                        {
                            
                            int 琴轴1x = 0, 琴轴1y = 0;
                            dm.FindStrFast(324, 95, 367, 121, "琴轴", "91A5D0-14322F", 0.9, out 琴轴1x, out 琴轴1y);
                            if (琴轴1x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(琴轴1x + 82, 琴轴1y + 46);
                                dm.Delays(400, 500);
                                dm.LeftClick();
                                dm.Delays(5000, 6000);

                            }
                            int 琵琶弦上完成1x = 0, 琵琶弦上完成1y = 0;
                            dm.FindStrFast(731, 256, 794, 278, "完成", "ffffff", 0.9, out 琵琶弦上完成1x, out 琵琶弦上完成1y);
                            if (琵琶弦上完成1x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(琵琶弦上完成1x + gameOperation.RandomNum(0, 30), 琵琶弦上完成1y + gameOperation.RandomNum(0, 15));
                                dm.Delays(400, 500);
                                dm.LeftClick();
                                dm.Delays(4000, 5000);
                                break;
                            }
                        }
                        continue;
                    } 
                    #endregion
                    #region 何处哀弦
                    int 何处哀弦x = 0, 何处哀弦y = 0;
                    var 何处哀弦 = dm.FindStrFast(865, 274, 974, 318, "何处哀弦", "ffffff", 0.9, out 何处哀弦x, out 何处哀弦y);
                    if (何处哀弦x > 0)
                    {
                        dm.Delays(400, 500);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(400, 500);
                        dm.LeftClick();//点击可跳过对话
                        dm.Delays(1000, 1500);
                        int 正传x = 0, 正传y = 0;
                        var 正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 正传x, out 正传y);
                        if (正传x > 0)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(正传x + gameOperation.RandomNum(5, 35), 正传y + gameOperation.RandomNum(3, 12));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1000, 2000);
                        }
                        continue;
                    }
                    #endregion

                    #region 小小圆圆
                    int 小小圆圆x = 0, 小小圆圆y = 0;
                    var 小小圆圆 = dm.FindStrFast(865, 274, 974, 318, "小小圆圆 ", "ffffff", 0.9, out 小小圆圆x, out 小小圆圆y);
                    if (小小圆圆x > 0)
                    {
                        while (true)
                        {
                            dm.KeyPress(67);
                            dm.Delays(400, 500);
                            int 燃犀烛照x = 0, 燃犀烛照y = 0;
                            dm.FindPic(171, 486, 492, 626, "\\img\\ranxizhuzhao.bmp", "000000", 0.9, 0, out 燃犀烛照x, out 燃犀烛照y);
                            if (燃犀烛照x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(燃犀烛照x + gameOperation.RandomNum(0, 10), 燃犀烛照y + gameOperation.RandomNum(0, 10));
                                dm.Delays(400, 500);
                                dm.LeftClick();
                            }
                            else
                            {
                                int 额外技能x = 0, 额外技能y = 0;
                                var 额外技能 = dm.FindStrFast(231, 141, 297, 165, "额外技能 ", "90acda", 0.9, out 额外技能x, out 额外技能y);
                                if (额外技能x > 0)
                                {
                                    dm.Delays(400, 500);
                                    dm.MoveTo(额外技能x + gameOperation.RandomNum(5, 45), 额外技能y);
                                    dm.Delays(400, 500);
                                    dm.LeftClick();
                                    int 燃犀烛照1x = 0, 燃犀烛照1y = 0;
                                    var 燃犀烛照1 = dm.FindPic(171, 486, 492, 626, "\\img\\ranxizhuzhao.bmp", "000000", 0.9, 0, out 燃犀烛照1x, out 燃犀烛照1y);
                                    if (燃犀烛照1x > 0)
                                    {
                                        dm.Delays(400, 500);
                                        dm.MoveTo(燃犀烛照1x + gameOperation.RandomNum(0, 10), 燃犀烛照1y + gameOperation.RandomNum(0, 10));
                                        dm.Delays(400, 500);
                                        dm.RightClick();
                                        dm.Delays(800, 1000);

                                    }
                                }
                            }
                            dm.KeyPress(27);
                            dm.Delays(800, 1000);
                            dm.KeyPress(27);
                            dm.Delays(1500, 2000);
                            dm.MoveTo(gameOperation.RandomNum(704, 736), gameOperation.RandomNum(503, 538));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1500, 2000);
                            int 交付绿色下划线x = 0, 交付绿色下划线y = 0;
                            dm.FindStrFast(830, 280, 982, 334, "下划线1|标准下划线", "00ff00", 0.9, out 交付绿色下划线x, out 交付绿色下划线y);
                            if (交付绿色下划线x > 0)
                            {
                                break;
                            }
                            dm.Delays(1000, 1500);
                        }
                        continue;
                    }
                    #endregion

                    #region 事发推测
                    int 事发推测x = 0, 事发推测y = 0;
                    var 事发推测 = dm.FindStrFast(865, 274, 974, 318, "事发推测 ", "ffffff", 0.9, out 事发推测x, out 事发推测y);
                    if (事发推测x > 0)
                    {
                        while (true)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1000, 1500);
                            int 时间顺序x = 0, 时间顺序y = 0;
                            var 时间顺序 = dm.FindStrFast(0, 0, 1000, 768, "时间顺序 ", "E3D9CA-1C232D", 0.9, out 时间顺序x, out 时间顺序y);
                            if (时间顺序x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(时间顺序x + gameOperation.RandomNum(10, 50), 时间顺序y + gameOperation.RandomNum(3, 12));
                                dm.Delays(400, 500);
                                dm.LeftClick();
                            }
                            else
                            {
                                break;
                            }
                        }
                        while (true)
                        {
                            int 交付绿色下划线x = 0, 交付绿色下划线y = 0;
                            dm.FindStrFast(830, 280, 982, 334, "下划线1|标准下划线", "00ff00", 0.9, out 交付绿色下划线x, out 交付绿色下划线y);
                            if (交付绿色下划线x > 0)
                            {
                                break;
                            }
                            int yix = 0, yiy = 0;
                            var yi = dm.FindStrFast(0, 0, 1000, 768, "1换", "CEB093-314B43", 0.9, out yix, out yiy);
                            int erx = 0, ery = 0;
                            var er = dm.FindStrFast(0, 0, 1000, 768, "2换", "CEB093-314B43", 0.9, out erx, out ery);
                            int sanx = 0, sany = 0;
                            var san = dm.FindStrFast(0, 0, 1000, 768, "3换", "CEB093-314B43", 0.9, out sanx, out sany);
                            if (yix > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(yix + gameOperation.RandomNum(25, 35), yiy + gameOperation.RandomNum(5, 15));
                                dm.Delays(800, 1000);
                                dm.LeftClick();
                                dm.Delays(800, 1000);
                            }
                            if (erx > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(erx + gameOperation.RandomNum(25, 35), ery + gameOperation.RandomNum(5, 15));
                                dm.Delays(800, 1000);
                                dm.LeftClick();
                                dm.Delays(800, 1000);
                            }
                            if (sanx > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(sanx + gameOperation.RandomNum(25, 35), sany + gameOperation.RandomNum(5, 15));
                                dm.Delays(800, 1000);
                                dm.LeftClick();
                                dm.Delays(800, 1000);
                            }
                        }
                        continue;
                    } 
                    #endregion
                    #region 贾天师乃假天师
                    int 贾天师乃假天师x = 0, 贾天师乃假天师y = 0;
                    var 贾天师乃假天师 = dm.FindStrFast(865, 274, 974, 318, "贾天师乃假 ", "ffffff", 0.9, out 贾天师乃假天师x, out 贾天师乃假天师y);
                    if (贾天师乃假天师x > 0)
                    {
                        while (true)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                            dm.Delays(400, 500);
                            dm.RightClick();
                            dm.Delays(1000, 1500);
                            int 坐标绿色下划线x = 0, 坐标绿色下划线y = 0;
                            var 坐标绿色下划线 = dm.FindStrFast(73, 201, 298, 231, "下划线1", "00ff00", 0.9, out 坐标绿色下划线x, out 坐标绿色下划线y);
                            if (坐标绿色下划线x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(坐标绿色下划线x + gameOperation.RandomNum(10, 50), 坐标绿色下划线y-gameOperation.RandomNum(3, 10));
                                dm.Delays(400, 500);
                                dm.LeftClick();
                                dm.Delays(1000, 1500);
                                int 正传x = 0, 正传y = 0;
                                var 正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 正传x, out 正传y);
                                if (正传x > 0)
                                {
                                    dm.Delays(400, 500);
                                    dm.MoveTo(正传x + gameOperation.RandomNum(5, 35), 正传y + gameOperation.RandomNum(3, 12));
                                    dm.Delays(400, 500);
                                    dm.LeftClick();
                                    dm.Delays(1000, 2000);
                                    int 贾天师x = 0, 贾天师y = 0;
                                    var 贾天师 = dm.FindStrFast(345, 426, 685, 560, "贾天师", "ffffff", 0.9, out 贾天师x, out 贾天师y);
                                    if (贾天师x > 0)
                                    {
                                        dm.Delays(400, 500);
                                        dm.MoveTo(贾天师x + gameOperation.RandomNum(5, 35), 贾天师y + gameOperation.RandomNum(3, 12));
                                        dm.Delays(400, 500);
                                        dm.LeftClick();
                                        dm.Delays(1000, 1200);
                                        break;
                                    }

                                }
                            }
                        }
                        while (true)
                        {
                            int 交付绿色下划线x = 0, 交付绿色下划线y = 0;
                            dm.FindStrFast(830, 280, 982, 334, "下划线1|标准下划线", "00ff00", 0.9, out 交付绿色下划线x, out 交付绿色下划线y);
                            if (交付绿色下划线x > 0)
                            {
                                break;
                            }
                            dm.Delays(400, 500);
                            dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1000, 1500);
                            gameOperation.QieGuai();
                            gameOperation.ZhanDou();
                        }
                        continue;
                    } 
                    #endregion

                    #region 临别相赠
                    int 临别相赠x = 0, 临别相赠y = 0;
                    var 临别相赠 = dm.FindStrFast(865, 274, 974, 318, "临别相赠 ", "ffffff", 0.9, out 临别相赠x, out 临别相赠y);
                    if (临别相赠x > 0)
                    {
                        dm.Delays(1500, 2000);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(400, 500);
                        dm.LeftClick();
                        dm.Delays(1000, 1500);
                        dm.MoveTo(gameOperation.RandomNum(703, 734), gameOperation.RandomNum(505, 537));
                        dm.Delays(1000, 2000);
                        dm.RightClick();
                        dm.Delays(1000, 1200);
                        continue;
                    }
                    #endregion

                    #region 睡前故事
                    int 睡前故事x = 0, 睡前故事y = 0;
                    dm.FindStrFast(865, 274, 974, 318, "睡前故事 ", "ffffff", 0.9, out 睡前故事x, out 睡前故事y);
                    if (睡前故事x > 0)
                    {
                        dm.Delays(1000, 1500);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(600, 800);
                        dm.LeftClick();
                        dm.Delays(1000, 1500);
                        //选中砚台
                        dm.MoveTo(gameOperation.RandomNum(500, 525), gameOperation.RandomNum(400, 425));
                        dm.Delays(600, 800);
                        dm.RightClick();
                        dm.Delays(1000, 1500);
                        int 砚台x = 0, 砚台y = 0;
                        var 砚台 = dm.FindStrFast(467, 16, 512, 36, "砚台", "400040", 0.9, out 砚台x, out 砚台y);
                        if (砚台x > 0)
                        {
                            int 猫粮x = 0, 猫粮y = 0;
                            var miji = dm.FindPic(493, 201, 519, 229, "\\img\\maoliang.bmp", "000000", 0.9, 0, out 猫粮x, out 猫粮y);
                            if (猫粮x > 0)
                            {
                                dm.MoveTo(猫粮x + gameOperation.RandomNum(0, 10), 猫粮y + gameOperation.RandomNum(0, 10));
                                dm.Delays(1000, 1200);
                                dm.RightClick();
                                dm.Delays(1000, 2000);
                                int quedingX = 0, quedingY = 0;
                                var queding = dm.FindStrFast(418, 405, 483, 424, "确定", "ffffff", 0.9, out quedingX, out quedingY);
                                if (quedingX > 0)
                                {
                                    dm.MoveTo(quedingX + gameOperation.RandomNum(0, 30), quedingY + gameOperation.RandomNum(0, 15));
                                    dm.Delays(600, 800);
                                    dm.LeftClick();
                                    dm.Delays(600, 800);
                                }
                            }
                        }
                        continue;
                    }
                    #endregion

                    #region 交替守夜、孤女无援
                    int 交替守夜x = 0, 交替守夜y = 0;
                    var 交替守夜 = dm.FindStrFast(865, 274, 974, 318, "交替守夜 ", "ffffff", 0.9, out 交替守夜x, out 交替守夜y);
                    int 孤女无援x = 0, 孤女无援y = 0;
                    var 孤女无援 = dm.FindStrFast(865, 274, 974, 318, "孤女无援 ", "ffffff", 0.9, out 孤女无援x, out 孤女无援y);
                    if (交替守夜x > 0 || 孤女无援x > 0)
                    {
                        dm.Delays(1000, 1500);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(600, 800);
                        dm.LeftClick();
                        dm.Delays(1000, 1200);
                        int 正传1x = 0, 正传1y = 0;
                        var 正传1 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 正传1x, out 正传1y);
                        if (正传1x > 0)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(正传1x + gameOperation.RandomNum(5, 35), 正传1y + gameOperation.RandomNum(3, 12));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1000, 2000);
                        }
                        continue;
                    }
                    #endregion
                    #region 谋生之法
                    int 谋生之法x = 0, 谋生之法y = 0;
                    dm.FindStrFast(865, 274, 974, 318, "谋生之法", "ffffff", 0.9, out 谋生之法x, out 谋生之法y);
                    if (谋生之法x > 0)
                    {
                        //缝缝补补的旧衣服
                        int 缝缝补补的旧衣服x = 0, 缝缝补补的旧衣服y = 0;
                        var 缝缝补补的旧衣服 = dm.FindStrFast(835, 292, 976, 313, "旧衣服(0 ", "ffffff", 0.98, out 缝缝补补的旧衣服x, out 缝缝补补的旧衣服y);
                        if (缝缝补补的旧衣服x > 0)
                        {
                            while (true)
                            {
                                dm.Delays(1000, 1200);
                                dm.MoveTo(缝缝补补的旧衣服x + gameOperation.RandomNum(0, 30), 缝缝补补的旧衣服y + gameOperation.RandomNum(3, 10));
                                dm.Delays(600, 800);
                                dm.LeftClick();
                                dm.Delays(800, 1000);
                                int 缝缝补补正传1x = 0, 缝缝补补正传1y = 0;
                                var 缝缝补补正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 缝缝补补正传1x, out 缝缝补补正传1y);
                                if (缝缝补补正传1x > 0)
                                {
                                    dm.Delays(400, 500);
                                    dm.MoveTo(缝缝补补正传1x + gameOperation.RandomNum(5, 35), 缝缝补补正传1y + gameOperation.RandomNum(3, 12));
                                    dm.Delays(400, 500);
                                    dm.LeftClick();
                                    dm.Delays(1000, 2000);
                                }
                                int 缝缝补补的旧衣服退出x = 0, 缝缝补补的旧衣服退出y = 0;
                                var 缝缝补补的旧衣服退出 = dm.FindStrFast(834, 279, 989, 382, "旧衣服(1 ", "ffffff", 0.98, out 缝缝补补的旧衣服退出x, out 缝缝补补的旧衣服退出y);
                                if (缝缝补补的旧衣服退出x > 0)
                                {
                                    break;
                                }
                            }
                            continue;
                        }
                    }
                    //药草篮子
                    int 药草篮子x = 0, 药草篮子y = 0;
                    var 药草篮子 = dm.FindStrFast(834, 279, 989, 382, "药草篮子(0 ", "ffffff", 0.98, out 药草篮子x, out 药草篮子y);
                    if (药草篮子x > 0)
                    {
                        while (true)
                        {
                            dm.Delays(1000, 1500);
                            dm.MoveTo(药草篮子x + gameOperation.RandomNum(10, 50), 药草篮子y + gameOperation.RandomNum(3, 10));
                            dm.Delays(600, 800);
                            dm.LeftClick();
                            dm.Delays(800, 1000);
                            int 药草篮子正传x = 0, 药草篮子正传y = 0;
                            var 药草篮子正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 药草篮子正传x, out 药草篮子正传y);
                            if (药草篮子正传x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(药草篮子正传x + gameOperation.RandomNum(5, 35), 药草篮子正传y + gameOperation.RandomNum(3, 12));
                                dm.Delays(400, 500);
                                dm.LeftClick();
                                dm.Delays(1000, 2000);
                            }
                            int 药草篮子退出x = 0, 药草篮子退出y = 0;
                            var 药草篮子退出 = dm.FindStrFast(834, 279, 989, 382, "药草篮子(1 ", "ffffff", 0.98, out 药草篮子退出x, out 药草篮子退出y);
                            if (药草篮子退出x > 0)
                            {
                                break;
                            }
                        }

                    }
                    //医药书
                    int 医药书x = 0, 医药书y = 0;
                    var 医药书 = dm.FindStrFast(834, 279, 989, 382, "医药书(0 ", "ffffff", 0.98, out 医药书x, out 医药书y);
                    if (医药书x > 0)
                    {
                        while (true)
                        {
                            dm.Delays(1000, 1500);
                            dm.MoveTo(医药书x + gameOperation.RandomNum(10, 50), 医药书y + gameOperation.RandomNum(3, 10));
                            dm.Delays(600, 800);
                            dm.LeftClick();
                            dm.Delays(800, 1000);
                            int 医药书正传x = 0, 医药书正传y = 0;
                            var 医药书正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 医药书正传x, out 医药书正传y);
                            if (医药书正传x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(医药书正传x + gameOperation.RandomNum(5, 35), 医药书正传y + gameOperation.RandomNum(3, 12));
                                dm.Delays(400, 500);
                                dm.LeftClick();
                                dm.Delays(1000, 2000);
                            }
                            int 医药书退出x = 0, 医药书退出y = 0;
                            var 医药书退出 = dm.FindStrFast(834, 279, 989, 382, "医药书(1 ", "ffffff", 0.98, out 医药书退出x, out 医药书退出y);
                            if (医药书退出x > 0)
                            {
                                break;
                            }
                        }

                    }
                    //账本
                    int 账本x = 0, 账本y = 0;
                    var 账本 = dm.FindStrFast(834, 279, 989, 382, "账本(0 ", "ffffff", 0.98, out 账本x, out 账本y);
                    if (账本x > 0)
                    {
                        while (true)
                        {
                            dm.Delays(1000, 1500);
                            dm.MoveTo(账本x + gameOperation.RandomNum(10, 50), 账本y + gameOperation.RandomNum(3, 10));
                            dm.Delays(600, 800);
                            dm.LeftClick();
                            dm.Delays(800, 1000);
                            int 账本正传x = 0, 账本正传y = 0;
                            var 账本正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 账本正传x, out 账本正传y);
                            if (账本正传x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(账本正传x + gameOperation.RandomNum(5, 35), 账本正传y + gameOperation.RandomNum(3, 12));
                                dm.Delays(400, 500);
                                dm.LeftClick();
                                dm.Delays(1000, 2000);
                            }
                            int 账本退出x = 0, 账本退出y = 0;
                            dm.FindStrFast(830, 280, 982, 334, "下划线1|标准下划线", "00ff00", 0.9, out 账本退出x, out 账本退出y);
                            if (账本退出x > 0)
                            {
                                break;
                            }
                        }

                    }
                    #endregion
                    #region 兰若月下
                    int 兰若月下x = 0, 兰若月下y = 0;
                    var 兰若月下 = dm.FindStrFast(865, 274, 974, 318, "兰若月下 ", "ffffff", 0.9, out 兰若月下x, out 兰若月下y);
                    if (兰若月下x > 0)
                    {
                        //1、清理背包，穿戴高级装备
                        while (true)
                        {
                            dm.Delays(800, 1000);
                            dm.KeyPress(69);
                            dm.Delays(800, 1000);
                            int 莺歌燕舞iconx = 0, 莺歌燕舞icony = 0;
                            dm.FindPic(232, 225, 1010, 423, "\\package\\yinggeyanwu.bmp", "000000", 0.9, 0, out 莺歌燕舞iconx, out 莺歌燕舞icony);
                            if (莺歌燕舞iconx > 0)
                            {
                                dm.Delays(800, 1000);
                                dm.MoveToEx(莺歌燕舞iconx, 莺歌燕舞icony, 10, 10);
                                dm.Delays(800, 1000);
                                dm.RightClick();
                                dm.Delays(800, 1000);
                            }
                            int 银莲戒iconx = 0, 银莲戒icony = 0;
                            dm.FindPic(232, 225, 1010, 423, "\\package\\yinlianjie.bmp", "000000", 0.9, 0, out 银莲戒iconx, out 银莲戒icony);
                            if (银莲戒iconx > 0)
                            {
                                dm.Delays(800, 1000);
                                dm.MoveToEx(银莲戒iconx, 银莲戒icony, 10, 10);
                                dm.Delays(800, 1000);
                                dm.RightClick();
                                dm.Delays(800, 1000);
                            }
                            int 伦巾iconx = 0, 伦巾icony = 0;
                            dm.FindPic(232, 225, 1010, 423, "\\package\\lunjin.bmp", "000000", 0.9, 0, out 伦巾iconx, out 伦巾icony);
                            if (伦巾iconx > 0)
                            {
                                dm.Delays(800, 1000);
                                dm.MoveToEx(伦巾iconx, 伦巾icony, 10, 10);
                                dm.Delays(800, 1000);
                                dm.RightClick();
                                dm.Delays(800, 1000);
                            }
                            int 鳄皮护手iconx = 0, 鳄皮护手icony = 0;
                            dm.FindPic(232, 225, 1010, 423, "\\package\\epihushou.bmp", "000000", 0.9, 0, out 鳄皮护手iconx, out 鳄皮护手icony);
                            if (鳄皮护手iconx > 0)
                            {
                                dm.Delays(800, 1000);
                                dm.MoveToEx(鳄皮护手iconx, 鳄皮护手icony, 10, 10);
                                dm.Delays(800, 1000);
                                dm.RightClick();
                                dm.Delays(800, 1000);
                            }
                            int 步步升莲iconx = 0, 步步升莲icony = 0;
                            dm.FindPic(232, 225, 1010, 423, "\\package\\bubushenglian.bmp", "000000", 0.9, 0, out 步步升莲iconx, out 步步升莲icony);
                            if (步步升莲iconx > 0)
                            {
                                dm.Delays(800, 1000);
                                dm.MoveToEx(步步升莲iconx, 步步升莲icony, 10, 10);
                                dm.Delays(800, 1000);
                                dm.RightClick();
                                dm.Delays(800, 1000);
                            }
                            int 汉宫秋月iconx = 0, 汉宫秋月icony = 0;
                            dm.FindPic(232, 225, 1010, 423, "\\package\\hangongqiuyue.bmp", "000000", 0.9, 0, out 汉宫秋月iconx, out 汉宫秋月icony);
                            if (汉宫秋月iconx > 0)
                            {
                                dm.Delays(800, 1000);
                                dm.MoveToEx(汉宫秋月iconx, 汉宫秋月icony, 10, 10);
                                dm.Delays(800, 1000);
                                dm.RightClick();
                                dm.Delays(800, 1000);
                            }
                            int 秘籍iconx = 0, 秘籍icony = 0;
                            dm.FindPic(232, 225, 1010, 423, "\\package\\miji.bmp", "000000", 0.9, 0, out 秘籍iconx, out 秘籍icony);
                            if (秘籍iconx > 0)
                            {
                                dm.Delays(800, 1000);
                                dm.MoveToEx(秘籍iconx, 秘籍icony, 10, 10);
                                dm.Delays(800, 1000);
                                dm.RightClick();
                                dm.Delays(800, 1000);
                            }
                            int 细麻带iconx = 0, 细麻带icony = 0;
                            dm.FindPic(232, 225, 1010, 423, "\\package\\ximadai.bmp", "000000", 0.9, 0, out 细麻带iconx, out 细麻带icony);
                            if (细麻带iconx > 0)
                            {
                                dm.Delays(800, 1000);
                                dm.MoveToEx(细麻带iconx, 细麻带icony, 10, 10);
                                dm.Delays(800, 1000);
                                dm.RightClick();
                                dm.Delays(800, 1000);
                                dm.MoveToEx(0, 0, 200, 200);
                                dm.Delays(800, 1000);
                            }
                            int 雪貂袍iconx = 0, 雪貂袍icony = 0;
                            dm.FindPic(232, 225, 1010, 423, "\\package\\xuedianpao.bmp", "000000", 0.9, 3, out 雪貂袍iconx, out 雪貂袍icony);
                            if (雪貂袍iconx > 0)
                            {
                                dm.Delays(800, 1000);
                                dm.MoveToEx(雪貂袍iconx, 雪貂袍icony, 3, 3);
                                dm.Delays(1000, 1200);
                                int 雪貂袍x = 0, 雪貂袍y = 0;
                                dm.FindStrFast(366, 476, 413, 499, "雪貂袍", "ff5050", 0.9, out 雪貂袍x, out 雪貂袍y);
                                if (雪貂袍x>0)
                                {
                                    dm.Delays(800, 1000);
                                    dm.RightClick();
                                    dm.Delays(800, 1000);
                                }
                                break;
                            }
                        }
                        
                        //2、买药
                        while (true)
                        {
                            dm.KeyPress(27);
                            dm.Delays(800, 1000);
                            dm.KeyPress(27);
                            dm.Delays(800, 1000);
                            //买药
                            dm.MoveTo(gameOperation.RandomNum(927, 942), gameOperation.RandomNum(148, 165));
                            dm.Delays(800, 1000);
                            dm.LeftClick();
                            dm.Delays(800, 1000);
                            int 银票区x = 0, 银票区y = 0;
                            dm.FindStrFast(392, 180, 441, 199, "银票区", "7a89a6", 0.9, out 银票区x, out 银票区y);
                            if (银票区x > 0)
                            {
                                dm.Delays(800, 1000);
                                dm.MoveTo(银票区x + gameOperation.RandomNum(0, 35), 银票区y - gameOperation.RandomNum(0, 20));
                                dm.Delays(800, 1000);
                                dm.LeftClick();
                                dm.Delays(800, 1000);
                                int 药品tabx = 0, 药品taby = 0;
                                dm.FindStrFast(178, 210, 217, 229, "药品Tab", "90acda", 0.9, out 药品tabx, out 药品taby);
                                if (药品tabx > 0)
                                {
                                    dm.Delays(800, 1000);
                                    dm.MoveTo(药品tabx + gameOperation.RandomNum(0, 20), 药品taby + gameOperation.RandomNum(0, 15));
                                    dm.Delays(800, 1000);
                                    dm.LeftClick();
                                    dm.Delays(1000, 1200);
                                }
                                int 密蒙丸x = 0, 密蒙丸y = 0;
                                dm.FindStrFast(647, 240, 718, 264, "密蒙丸", "f6f6ce", 0.9, out 密蒙丸x, out 密蒙丸y);
                                if (密蒙丸x > 0)
                                {
                                    dm.Delays(800, 1000);
                                    dm.MoveTo(密蒙丸x + gameOperation.RandomNum(0, 80), 密蒙丸y + gameOperation.RandomNum(0, 25));
                                    dm.Delays(800, 1000);
                                    dm.LeftClick();
                                    dm.Delays(800, 1000);
                                    dm.KeyPressStr("1", 50);
                                    dm.Delays(800, 1000);
                                    int 确定x = 0, 确定y = 0;
                                    dm.FindStrFast(435, 401, 499, 424, "确定", "ffffff", 0.9, out 确定x, out 确定y);
                                    if (确定x > 0)
                                    {
                                        dm.Delays(800, 1000);
                                        dm.MoveTo(确定x + gameOperation.RandomNum(0, 20), 确定y + gameOperation.RandomNum(5, 15));
                                        dm.Delays(800, 1000);
                                        dm.LeftClick();
                                        dm.Delays(800, 1000);
                                        dm.MoveTo(gameOperation.RandomNum(0, 200), gameOperation.RandomNum(0, 200));
                                        dm.Delays(800, 1000);
                                        int 确定购买密蒙丸x = 0, 确定购买密蒙丸y = 0;
                                        dm.FindStrFast(413, 400, 477, 421, "确定", "ffffff", 0.9, out 确定购买密蒙丸x, out 确定购买密蒙丸y);
                                        if (确定购买密蒙丸x > 0)
                                        {
                                            dm.Delays(1200, 2000);
                                            dm.MoveTo(确定购买密蒙丸x + gameOperation.RandomNum(0, 30), 确定购买密蒙丸y + gameOperation.RandomNum(0, 12));
                                            dm.Delays(800, 1000);
                                            dm.LeftClick();
                                            dm.Delays(1000, 1500);
                                            //购买鹿衔散
                                            int 鹿衔散x = 0, 鹿衔散y = 0;
                                            dm.FindStrFast(643, 287, 699, 310, "鹿衔散", "f6f6ce", 0.9, out 鹿衔散x, out 鹿衔散y);
                                            if (鹿衔散x > 0)
                                            {
                                                dm.Delays(800, 1000);
                                                dm.MoveTo(鹿衔散x + gameOperation.RandomNum(0, 80), 鹿衔散y + gameOperation.RandomNum(0, 25));
                                                dm.Delays(800, 1000);
                                                dm.LeftClick();
                                                dm.Delays(800, 1000);
                                                dm.KeyPressStr("1", 50);
                                                dm.Delays(800, 1000);
                                                int 确定1x = 0, 确定1y = 0;
                                                dm.FindStrFast(435, 401, 499, 424, "确定", "ffffff", 0.9, out 确定1x, out 确定1y);
                                                if (确定1x > 0)
                                                {
                                                    dm.Delays(800, 1000);
                                                    dm.MoveTo(确定1x + gameOperation.RandomNum(0, 30), 确定1y + gameOperation.RandomNum(0, 12));
                                                    dm.Delays(800, 1000);
                                                    dm.LeftClick();
                                                    dm.Delays(800, 1000);
                                                    dm.MoveTo(gameOperation.RandomNum(0, 200), gameOperation.RandomNum(0, 200));
                                                    dm.Delays(800, 1000);
                                                    int 确定购买鹿衔散x = 0, 确定购买鹿衔散y = 0;
                                                    dm.FindStrFast(413, 400, 477, 421, "确定", "ffffff", 0.9, out 确定购买鹿衔散x, out 确定购买鹿衔散y);
                                                    if (确定购买鹿衔散x > 0)
                                                    {
                                                        dm.Delays(1200, 2000);
                                                        dm.MoveTo(确定购买鹿衔散x + gameOperation.RandomNum(0, 30), 确定购买鹿衔散y + gameOperation.RandomNum(5, 15));
                                                        dm.Delays(800, 1000);
                                                        dm.LeftClick();
                                                        dm.Delays(800, 1000);
                                                        //购买双麻火烧
                                                        int 双麻火烧x = 0, 双麻火烧y = 0;
                                                        dm.FindStrFast(644, 336, 730, 365, "双麻火烧", "f6f6ce", 0.9, out 双麻火烧x, out 双麻火烧y);
                                                        if (双麻火烧x > 0)
                                                        {
                                                            dm.Delays(800, 1000);
                                                            dm.MoveTo(双麻火烧x + gameOperation.RandomNum(0, 80), 双麻火烧y + gameOperation.RandomNum(0, 25));
                                                            dm.Delays(800, 1000);
                                                            dm.LeftClick();
                                                            dm.Delays(800, 1000);
                                                            dm.KeyPressStr("1", 50);
                                                            dm.Delays(800, 1000);
                                                            int 确定2x = 0, 确定2y = 0;
                                                            dm.FindStrFast(435, 401, 499, 424, "确定", "ffffff", 0.9, out 确定2x, out 确定2y);
                                                            if (确定2x > 0)
                                                            {
                                                                dm.Delays(800, 1000);
                                                                dm.MoveTo(确定2x + gameOperation.RandomNum(0, 30), 确定2y + gameOperation.RandomNum(0, 12));
                                                                dm.Delays(800, 1000);
                                                                dm.LeftClick();
                                                                dm.Delays(800, 1000);
                                                                dm.MoveTo(gameOperation.RandomNum(0, 200), gameOperation.RandomNum(0, 200));
                                                                dm.Delays(800, 1000);
                                                                int 确定购买双麻火烧x = 0, 确定购买双麻火烧y = 0;
                                                                dm.FindStrFast(413, 400, 477, 421, "确定", "ffffff", 0.9, out 确定购买双麻火烧x, out 确定购买双麻火烧y);
                                                                if (确定购买鹿衔散x > 0)
                                                                {
                                                                    dm.Delays(1200, 2000);
                                                                    dm.MoveTo(确定购买双麻火烧x + gameOperation.RandomNum(0, 30), 确定购买双麻火烧y + gameOperation.RandomNum(5, 15));
                                                                    dm.Delays(800, 1000);
                                                                    dm.LeftClick();
                                                                    dm.Delays(800, 1000);
                                                                    break;//买药成功退出买药循环
                                                                }

                                                            }
                                                        }
                                                    }

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        //3、设置药品按键
                        dm.KeyPress(27);
                        dm.Delays(600, 800);
                        dm.KeyPress(27);
                        dm.Delays(600, 800);

                        while (true)
                        {
                            int 循环退出x = 0, 循环退出y = 0;
                            dm.FindPic(578, 709, 612, 742, "\\package\\Fhuomashuangshao.bmp", "000000", 0.9, 0, out 循环退出x, out 循环退出y);
                            dm.Delays(1000, 1200);
                            int 循环退出1x = 0, 循环退出1y = 0;
                            dm.FindPic(508, 709, 541, 740, "\\package\\Fmimengwan.bmp", "000000", 0.9, 0, out 循环退出1x, out 循环退出1y);
                            if (循环退出x > 0 && 循环退出1x>0)
                            {
                                break;
                            }
                            dm.KeyPress(69);
                            dm.Delays(600, 800);
                            int 密蒙丸iconx = 0, 密蒙丸icony = 0;
                            dm.FindPic(232, 225, 1010, 423, "\\package\\mimengwan.bmp", "000000", 0.9, 0, out 密蒙丸iconx, out 密蒙丸icony);
                            if (密蒙丸iconx > 0)
                            {
                                dm.Delays(600, 800);
                                dm.MoveTo(密蒙丸iconx + gameOperation.RandomNum(0, 10), 密蒙丸icony + gameOperation.RandomNum(0, 6));
                                dm.Delays(600, 800);
                                dm.LeftClick();
                                dm.Delays(600, 800);
                                dm.MoveTo(gameOperation.RandomNum(508, 540), gameOperation.RandomNum(710, 740));//移动到F1
                                dm.Delays(600, 800);
                                dm.LeftClick();
                                dm.Delays(800, 1000);
                                dm.MoveTo(gameOperation.RandomNum(200, 200), gameOperation.RandomNum(200, 200));
                                dm.Delays(600, 800);
                            }
                            int 鹿衔散iconx = 0, 鹿衔散icony = 0;
                            dm.FindPic(232, 225, 1010, 423, "\\package\\luxiansan.bmp", "000000", 0.9, 0, out 鹿衔散iconx, out 鹿衔散icony);
                            if (鹿衔散iconx > 0)
                            {
                                dm.Delays(600, 800);
                                dm.MoveTo(鹿衔散iconx + gameOperation.RandomNum(0, 10), 鹿衔散icony + gameOperation.RandomNum(0, 6));
                                dm.Delays(600, 800);
                                dm.LeftClick();
                                dm.Delays(600, 800);
                                dm.MoveTo(gameOperation.RandomNum(544, 576), gameOperation.RandomNum(710, 740));//移动到F2 写死 544,711,576,740
                                dm.Delays(600, 800);
                                dm.LeftClick();
                                dm.Delays(800, 1000);
                                dm.MoveTo(gameOperation.RandomNum(200, 200), gameOperation.RandomNum(200, 200));
                                dm.Delays(600, 800);
                            }
                            int 火麻双烧iconx = 0, 火麻双烧icony = 0;
                            dm.FindPic(232, 225, 1010, 423, "\\package\\huomashuangshao.bmp", "000000", 0.9, 0, out 火麻双烧iconx, out 火麻双烧icony);
                            if (火麻双烧iconx > 0)
                            {
                                dm.Delays(600, 800);
                                dm.MoveTo(火麻双烧iconx + gameOperation.RandomNum(0, 10), 火麻双烧icony + gameOperation.RandomNum(0, 6));
                                dm.Delays(600, 800);
                                dm.LeftClick();
                                dm.Delays(600, 800);
                                dm.MoveTo(gameOperation.RandomNum(578, 610), gameOperation.RandomNum(710, 740));//移动到F3 写死 578,711,610,739
                                dm.Delays(600, 800);
                                dm.LeftClick();
                                dm.Delays(800, 1000);
                                dm.MoveTo(gameOperation.RandomNum(200, 200), gameOperation.RandomNum(200, 200));
                                dm.Delays(1000, 1200);
                            }
                        }
                        dm.Delays(1000, 1500);
                        dm.KeyPress(27);
                        dm.Delays(600, 800);
                        dm.KeyPress(27);
                        //4、接受任务
                        while (true)
                        {
                            dm.KeyPress(27);
                            dm.Delays(800, 1000);
                            dm.KeyPress(27);
                            dm.Delays(800, 1000);
                            dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                            dm.Delays(600, 800);
                            dm.LeftClick();
                            dm.Delays(1000, 1200);
                            int 绿色下划线x = 0, 绿色下划线y = 0;
                            dm.FindStrFast(136, 221, 308, 248, "标准下划线", "00ff00", 0.95, out 绿色下划线x, out 绿色下划线y);
                            if (绿色下划线x > 0)
                            {
                                dm.Delays(1000, 1500);
                                dm.MoveTo(绿色下划线x + gameOperation.RandomNum(10, 50), 绿色下划线y - gameOperation.RandomNum(3, 10));
                                dm.Delays(600, 800);
                                dm.LeftClick();
                                dm.Delays(1000, 1200);
                                int 检测到当前副x = 0, 检测到当前副y = 0;
                                dm.FindStrFast(350, 335, 513, 369, "检测到当前副", "ffffff", 0.9, out 检测到当前副x, out 检测到当前副y);
                                if (检测到当前副x > 0)
                                {
                                    dm.Delays(1000, 1200);
                                    int 取消x, 取消y = 0;
                                    dm.FindStrFast(531, 399, 596, 420, "取消", "ffffff", 0.9, out 取消x, out 取消y);
                                    if (取消x > 0)
                                    {
                                        dm.Delays(800, 1000);
                                        dm.MoveTo(取消x + gameOperation.RandomNum(5, 40), 取消y + gameOperation.RandomNum(3, 15));
                                        dm.Delays(800, 1000);
                                        dm.LeftClick();
                                        dm.Delays(800, 1000);
                                        break;
                                    }
                                }
                                int 正传x = 0, 正传y = 0;
                                var 正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 正传x, out 正传y);
                                if (正传x > 0)
                                {
                                    dm.Delays(800, 1000);
                                    dm.MoveTo(正传x + gameOperation.RandomNum(5, 35), 正传y + gameOperation.RandomNum(3, 12));
                                    dm.Delays(800, 1000);
                                    dm.LeftClick();
                                    dm.Delays(1000, 1200);
                                    int 迎战紫衣x = 0, 迎战紫衣y = 0;
                                    dm.FindStrFast(345, 426, 685, 560, "迎战紫衣", "ffffff", 0.9, out 迎战紫衣x, out 迎战紫衣y);
                                    if (迎战紫衣x > 0)
                                    {
                                        dm.Delays(800, 1000);
                                        dm.MoveTo(迎战紫衣x + gameOperation.RandomNum(5, 35), 迎战紫衣y + gameOperation.RandomNum(3, 12));
                                        dm.Delays(800, 1000);
                                        dm.LeftClick();
                                        dm.Delays(1000, 1200);
                                        break;
                                    }
                                }
                            }
                        }
                        //5、开始战斗
                        gameOperation.IsContinue = true;
                        dm.Delays(800, 1000);
                        Thread jiaxueThread = new Thread(gameOperation.WuNaoJiaXue);//创建加血线程
                        jiaxueThread.Start();
                        Thread jialanThread = new Thread(gameOperation.JiaLan);//创建加蓝线程
                        jialanThread.Start();
                        //开始战斗
                        while (true)
                        {
                            int 聂小倩x = 0, 聂小倩y = 0;
                            dm.FindStrFast(0, 0, 1024, 768, "聂小倩", "CA5ECA-352A35", 0.9, out 聂小倩x, out 聂小倩y);
                            if (聂小倩x > 0)
                            {
                                dm.MoveTo(聂小倩x + gameOperation.RandomNum(25, 35), 聂小倩y + gameOperation.RandomNum(10, 25));
                                dm.Delays(200, 300);
                                dm.RightClick();
                                dm.Delays(200, 300);
                            }
                            gameOperation.QieGuai();
                            gameOperation.ZhanDou();
                            int 兰若月下退出x = 0, 兰若月下退出y = 0;
                            dm.FindStrFast(830, 280, 982, 334, "下划线1|标准下划线", "00ff00", 0.9, out 兰若月下退出x, out 兰若月下退出y);
                            if (兰若月下退出x > 0)
                            {
                                gameOperation.IsContinue = false;//战斗结束，退出循环加血线程自动结束
                                break;
                            }
                            int 原地普通复活x = 0, 原地普通复活y = 0;
                            dm.FindStrFast(830, 280, 982, 334, "原地普通复活", "bac4d6", 0.9, out 原地普通复活x, out 原地普通复活y);
                            if (原地普通复活x > 0)
                            {
                                gameOperation.IsContinue = false;
                                break;
                            }
                        }
                        continue;
                    }
                    #endregion
                    
                    #region 遗留线索
                    int 遗留线索x = 0, 遗留线索y = 0;
                    dm.FindStrFast(865, 274, 974, 318, "遗留线索", "ffffff", 0.9, out 遗留线索x, out 遗留线索y);
                    if (遗留线索x > 0)
                    {
                        dm.Delays(1000, 1500);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(600, 800);
                        dm.LeftClick();
                        dm.Delays(1000, 1500);
                        int 绿色任务下划线x = 0, 绿色任务下划线y = 0;
                        dm.FindStrFast(34, 208, 139, 241, "下划线1", "00ff00", 0.9, out 绿色任务下划线x, out 绿色任务下划线y);
                        if (绿色任务下划线x > 0)
                        {
                            dm.MoveTo(绿色任务下划线x + gameOperation.RandomNum(10, 50), 绿色任务下划线y - gameOperation.RandomNum(3, 10));
                            dm.Delays(600, 800);
                            dm.LeftClick();
                            dm.Delays(600, 800);
                            int 拾取铃铛x = 0, 拾取铃铛y = 0;
                            dm.FindStrFast(345, 426, 685, 560, "拾取铃铛", "ffffff", 0.9, out 拾取铃铛x, out 拾取铃铛y);
                            if (拾取铃铛x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(拾取铃铛x + gameOperation.RandomNum(5, 35), 拾取铃铛y + gameOperation.RandomNum(3, 12));
                                dm.Delays(400, 500);
                                dm.LeftClick();
                                dm.Delays(1000, 2000);
                            }
                        }
                        continue;
                    }
                    #endregion
                    #region 初至寻踪
                    int 初至寻踪x = 0, 初至寻踪y = 0;
                    dm.FindStrFast(865, 274, 974, 318, "初至寻踪", "ffffff", 0.9, out 初至寻踪x, out 初至寻踪y);
                    if (初至寻踪x > 0)
                    {
                        dm.Delays(1000, 1500);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(600, 800);
                        dm.LeftClick();
                        dm.Delays(1000, 1500);
                        int 正传x = 0, 正传y = 0;
                        var 正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 正传x, out 正传y);
                        if (正传x > 0)
                        {
                            dm.Delays(800, 1000);
                            dm.MoveTo(正传x + gameOperation.RandomNum(5, 35), 正传y + gameOperation.RandomNum(3, 12));
                            dm.Delays(800, 1000);
                            dm.LeftClick();
                            dm.Delays(1000, 1200);
                        }
                        continue;
                    }
                    #endregion
                    
                    #region 再寻倩影
                    int 再寻倩影x = 0, 再寻倩影y = 0;
                    dm.FindStrFast(865, 274, 974, 318, "再寻倩影", "ffffff", 0.9, out 再寻倩影x, out 再寻倩影y);
                    if (再寻倩影x > 0)
                    {
                        dm.Delays(1000, 1500);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(600, 800);
                        dm.LeftClick();
                        dm.Delays(1000, 1500);
                        //寻路
                        for (int i = 0; i < 10; i++)
                        {
                            dm.Delays(1000, 1200);
                        }
                        //dm.MoveTo(gameOperation.RandomNum(696, 728), gameOperation.RandomNum(493, 529));
                        dm.KeyPress(53);
                        dm.Delays(600, 800);
                        dm.LeftClick();
                        dm.Delays(1000, 1500);
                        continue;
                    }
                    #endregion

                    #region 陡生变故
                    int 陡生变故x = 0, 陡生变故y = 0;
                    dm.FindStrFast(865, 274, 974, 318, "陡生变故", "ffffff", 0.9, out 陡生变故x, out 陡生变故y);
                    if (陡生变故x > 0)
                    {
                        //穿上新装备
                        while (true)
                        {
                            dm.KeyPress(69);
                            dm.Delays(800, 1000);
                            int 细麻带iconx = 0, 细麻带icony = 0;
                            dm.FindPic(232, 225, 1010, 423, "\\package\\ximadai.bmp", "000000", 0.9, 0, out 细麻带iconx, out 细麻带icony);
                            if (细麻带iconx > 0)
                            {
                                dm.Delays(800, 1000);
                                dm.MoveToEx(细麻带iconx, 细麻带icony, 10, 10);
                                dm.Delays(800, 1000);
                                dm.RightClick();
                                dm.Delays(800, 1000);
                                dm.MoveToEx(0, 0, 200, 200);
                                dm.Delays(800, 1000);
                            }
                            
                            int 山桃戒iconx = 0, 山桃戒icony = 0;
                            dm.FindPic(232, 225, 1010, 423, "\\package\\shantaojie.bmp", "000000", 0.9, 0, out 山桃戒iconx, out 山桃戒icony);
                            if (山桃戒iconx > 0)
                            {
                                dm.Delays(800, 1000);
                                dm.MoveToEx(山桃戒iconx, 山桃戒icony, 10, 10);
                                dm.Delays(800, 1000);
                                dm.RightClick();
                                dm.Delays(800, 1000);
                                dm.MoveToEx(0, 0, 200, 200);
                                dm.Delays(800, 1000);
                                
                            }
                            int 雪貂袍iconx = 0, 雪貂袍icony = 0;
                            dm.FindPic(232, 225, 1010, 423, "\\package\\xuedianpao.bmp", "000000", 0.9, 3, out 雪貂袍iconx, out 雪貂袍icony);
                            if (雪貂袍iconx > 0)
                            {
                                dm.Delays(800, 1000);
                                dm.MoveToEx(雪貂袍iconx, 雪貂袍icony, 3, 3);
                                dm.Delays(1000, 1200);
                                int 雪貂袍x = 0, 雪貂袍y = 0;
                                dm.FindStrFast(366, 476, 413, 499, "雪貂袍", "ff5050", 0.9, out 雪貂袍x, out 雪貂袍y);
                                if (雪貂袍x > 0)
                                {
                                    dm.Delays(800, 1000);
                                    dm.RightClick();
                                    dm.Delays(800, 1000);
                                }
                                dm.KeyPress(27);
                                break;
                            }
                        }
                        dm.Delays(1000, 1500);
                        while (true)
                        {
                            dm.KeyPress(27);
                            dm.Delays(600, 800);
                            dm.KeyPress(27);
                            dm.Delays(600, 800);
                            dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                            dm.Delays(600, 800);
                            dm.LeftClick();
                            dm.Delays(1000, 1500);
                            int 绿色任务下划线x = 0, 绿色任务下划线y = 0;
                            dm.FindStrFast(228, 213, 380, 249, "下划线1", "00ff00", 0.9, out 绿色任务下划线x, out 绿色任务下划线y);
                            if (绿色任务下划线x > 0)
                            {
                                dm.MoveTo(绿色任务下划线x + gameOperation.RandomNum(10, 50), 绿色任务下划线y - gameOperation.RandomNum(3, 10));
                                dm.Delays(600, 800);
                                dm.LeftClick();
                                dm.Delays(600, 800);
                                int 检测到当前副x = 0, 检测到当前副y = 0;
                                dm.FindStrFast(350, 335, 513, 369, "检测到当前副", "ffffff", 0.9, out 检测到当前副x, out 检测到当前副y);
                                if (检测到当前副x > 0)
                                {
                                    dm.Delays(1000, 1200);
                                    int 取消x, 取消y = 0;
                                    dm.FindStrFast(531, 399, 596, 420, "取消", "ffffff", 0.9, out 取消x, out 取消y);
                                    if (取消x > 0)
                                    {
                                        dm.Delays(800, 1000);
                                        dm.MoveTo(取消x + gameOperation.RandomNum(5, 40), 取消y + gameOperation.RandomNum(3, 15));
                                        dm.Delays(800, 1000);
                                        dm.LeftClick();
                                        dm.Delays(800, 1000);
                                        break;
                                    }
                                }
                                int 正传x = 0, 正传y = 0;
                                var 正传 = dm.FindStrFast(340, 422, 571, 450, "[正传]|[剧情]", "ffffff", 0.9, out 正传x, out 正传y);
                                if (正传x > 0)
                                {
                                    dm.Delays(800, 1000);
                                    dm.MoveTo(正传x + gameOperation.RandomNum(5, 35), 正传y + gameOperation.RandomNum(3, 12));
                                    dm.Delays(800, 1000);
                                    dm.LeftClick();
                                    dm.Delays(1000, 1200);
                                    int 迎战小雪x = 0, 迎战小雪y = 0;
                                    dm.FindStrFast(345, 426, 685, 560, "迎战小雪", "ffffff", 0.9, out 迎战小雪x, out 迎战小雪y);
                                    if (迎战小雪x > 0)
                                    {
                                        dm.Delays(800, 1000);
                                        dm.MoveTo(迎战小雪x + gameOperation.RandomNum(5, 35), 迎战小雪y + gameOperation.RandomNum(3, 12));
                                        dm.Delays(800, 1000);
                                        dm.LeftClick();
                                        dm.Delays(1000, 1200);
                                        break;
                                    }
                                }
                            }
                        }
                        dm.KeyPress(27);
                        dm.Delays(800, 1000);
                        //战斗
                        gameOperation.IsContinue = true;
                        Thread jiaxueThread = new Thread(gameOperation.WuNaoJiaXue);//创建加血线程
                        jiaxueThread.Start();
                        Thread jialanThread = new Thread(gameOperation.JiaLan);//创建加蓝线程
                        jialanThread.Start();
                        while (true)
                        {
                            gameOperation.QieGuai();
                            int 小雪x = 0, 小雪y = 0;
                            dm.FindStrFast(0, 0, 1024, 768, "小雪", "CA5ECA-352A35", 0.9, out 小雪x, out 小雪y);
                            if (小雪x > 0)
                            {
                                dm.MoveTo(小雪x + gameOperation.RandomNum(20, 30), 小雪y + gameOperation.RandomNum(10, 25));
                                dm.Delays(200, 300);
                                dm.RightClick();
                                dm.Delays(200, 300);
                                dm.LeftClick();
                                dm.Delays(200, 300);
                            }
                            gameOperation.ZhanDou();
                            int 退出x = 0, 退出y = 0;
                            dm.FindStrFast(830, 280, 982, 334, "下划线1|标准下划线", "00ff00", 0.9, out 退出x, out 退出y);
                            if (退出x > 0)
                            {
                                gameOperation.IsContinue = false;//战斗结束，退出循环加血线程自动结束
                                break;
                            }
                            int 原地普通复活x = 0, 原地普通复活y = 0;
                            dm.FindStrFast(830, 280, 982, 334, "原地普通复活", "bac4d6", 0.9, out 原地普通复活x, out 原地普通复活y);
                            if (原地普通复活x > 0)
                            {
                                gameOperation.IsContinue = false;
                                break;
                            }

                        }
                        continue;
                    }
                    #endregion
                    
                    #region 地牢探查
                    int 地牢探查x = 0, 地牢探查y = 0;
                    dm.FindStrFast(865, 274, 974, 318, "地牢探查", "ffffff", 0.9, out 地牢探查x, out 地牢探查y);
                    if (地牢探查x > 0)
                    {
                        //铁质长棍
                        while (true)
                        {
                            dm.Delays(1000, 1200);
                            dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                            dm.Delays(600, 800);
                            dm.LeftClick();
                            dm.Delays(1000, 1200);
                            int 铁质长棍x = 0, 铁质长棍y = 0;
                            dm.FindStrFast(269, 246, 369, 276, "铁质长棍", "00ff00", 0.9, out 铁质长棍x, out 铁质长棍y);
                            if (铁质长棍x > 0)
                            {
                                dm.Delays(800, 1000);
                                dm.MoveTo(铁质长棍x + gameOperation.RandomNum(5, 20), 铁质长棍y + gameOperation.RandomNum(3, 12));
                                dm.Delays(600, 800);
                                dm.LeftClick();
                                dm.Delays(800, 1000);
                                int 应该可以防身x = 0, 应该可以防身y = 0;
                                dm.FindStrFast(363, 423, 462, 446, "应该可以防身", "ffffff", 0.9, out 应该可以防身x, out 应该可以防身y);
                                if (应该可以防身x > 0)
                                {
                                    dm.Delays(800, 1000);
                                    dm.MoveTo(应该可以防身x + gameOperation.RandomNum(5, 40), 应该可以防身y + gameOperation.RandomNum(3, 12));
                                    dm.Delays(600, 800);
                                    dm.LeftClick();
                                    dm.Delays(800, 1000);
                                    dm.KeyPress(27);
                                    dm.Delays(800, 1000);
                                    dm.KeyPress(27);
                                    break;
                                }
                            }
                        }
                        //旧衣服
                        while (true)
                        {
                            dm.Delays(1000, 1200);
                            dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                            dm.Delays(600, 800);
                            dm.LeftClick();
                            dm.Delays(1000, 1200);
                            int 旧衣服x = 0, 旧衣服y = 0;
                            dm.FindStrFast(279, 265, 332, 287, "旧衣服", "00ff00", 0.9, out 旧衣服x, out 旧衣服y);
                            if (旧衣服x > 0)
                            {
                                dm.Delays(800, 1000);
                                dm.MoveTo(旧衣服x + gameOperation.RandomNum(5, 20), 旧衣服y + gameOperation.RandomNum(3, 12));
                                dm.Delays(600, 800);
                                dm.LeftClick();
                                dm.Delays(800, 1000);
                                int 总感觉可能会x = 0, 总感觉可能会y = 0;
                                dm.FindStrFast(362, 424, 534, 448, "总感觉可能会", "ffffff", 0.9, out 总感觉可能会x, out 总感觉可能会y);
                                if (总感觉可能会x > 0)
                                {
                                    dm.Delays(800, 1000);
                                    dm.MoveTo(总感觉可能会x + gameOperation.RandomNum(5, 40), 总感觉可能会y + gameOperation.RandomNum(3, 12));
                                    dm.Delays(600, 800);
                                    dm.LeftClick();
                                    dm.Delays(800, 1000);
                                    dm.KeyPress(27);
                                    dm.Delays(800, 1000);
                                    dm.KeyPress(27);
                                    break;
                                }
                            }
                        }
                        continue;
                    }
                    #endregion
                    
                    #region 逃脱地牢
                    int 逃脱地牢x = 0, 逃脱地牢y = 0;
                    dm.FindStrFast(865, 274, 974, 318, "逃脱地牢", "ffffff", 0.9, out 逃脱地牢x, out 逃脱地牢y);
                    if (逃脱地牢x > 0)
                    {
                        dm.Delays(1000, 1200);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(600, 800);
                        dm.LeftClick();
                        dm.Delays(1000, 1200);
                        dm.MoveTo(gameOperation.RandomNum(493, 520), gameOperation.RandomNum(202, 228));
                        dm.Delays(600, 800);

                        dm.RightClick();
                        dm.Delays(1000, 1200);
                        continue;
                    }
                    #endregion
                    
                    #region 坟地往事
                    int 坟地往事x = 0, 坟地往事y = 0;
                    dm.FindStrFast(865, 274, 974, 318, "坟地往事", "ffffff", 0.9, out 坟地往事x, out 坟地往事y);
                    if (坟地往事x > 0)
                    {
                        dm.Delays(1000, 1200);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(600, 800);
                        dm.LeftClick();
                        dm.Delays(1000, 1200);
                        int 正传x = 0, 正传y = 0;
                        var 正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 正传x, out 正传y);
                        if (正传x > 0)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(正传x + gameOperation.RandomNum(5, 35), 正传y + gameOperation.RandomNum(3, 12));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1000, 2000);
                        }
                        continue;
                    }
                    #endregion

                    #region 兰若永囚
                    int 兰若永囚x = 0, 兰若永囚y = 0;
                    dm.FindStrFast(865, 274, 974, 318, "兰若永囚", "ffffff", 0.9, out 兰若永囚x, out 兰若永囚y);
                    if (兰若永囚x > 0)
                    {
                        dm.Delays(1000, 1200);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(600, 800);
                        dm.LeftClick();
                        dm.Delays(1000, 1200);
                        int 正传x = 0, 正传y = 0;
                        var 正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 正传x, out 正传y);
                        if (正传x > 0)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(正传x + gameOperation.RandomNum(5, 35), 正传y + gameOperation.RandomNum(3, 12));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1000, 2000);
                        }
                        continue;
                    } 
                    #endregion

                    #region 心情记录
                    int 心情记录x = 0, 心情记录y = 0;
                    dm.FindStrFast(865, 274, 974, 318, "心情记录", "ffffff", 0.9, out 心情记录x, out 心情记录y);
                    if (心情记录x > 0)
                    {
                        dm.Delays(1000, 1200);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(600, 800);
                        dm.LeftClick();
                        dm.Delays(1000, 1200);
                        int 打开木匣x = 0, 打开木匣y = 0;
                        dm.FindStrFast(358, 424, 465, 451, "打开木匣", "ffffff", 0.9, out 打开木匣x, out 打开木匣y);
                        if (打开木匣x > 0)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(打开木匣x + gameOperation.RandomNum(5, 35), 打开木匣y + gameOperation.RandomNum(3, 12));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1000, 1200);
                            //1
                            while (true)
                            {
                                dm.MoveTo(gameOperation.RandomNum(195, 223), gameOperation.RandomNum(247, 290));
                                dm.Delays(800, 1000);
                                dm.LeftClick();
                                dm.Delays(1000, 1200);
                                int 完成阅读1x = 0, 完成阅读1y = 0;
                                dm.FindStrFast(457, 505, 545, 530, "完成阅读", "ffffff", 0.9, out 完成阅读1x, out 完成阅读1y);
                                if (完成阅读1x > 0)
                                {
                                    dm.MoveTo(完成阅读1x + gameOperation.RandomNum(0, 50), 完成阅读1y + gameOperation.RandomNum(0, 18));
                                    dm.Delays(400, 500);
                                    dm.LeftClick();
                                    dm.Delays(1000, 1200);
                                    break;
                                }
                            }

                            //2
                            while (true)
                            {
                                dm.MoveTo(gameOperation.RandomNum(270, 300), gameOperation.RandomNum(185, 253));
                                dm.Delays(800, 1000);
                                dm.LeftClick();
                                dm.Delays(800, 1000);
                                int 完成阅读2x = 0, 完成阅读2y = 0;
                                dm.FindStrFast(457, 505, 545, 530, "完成阅读", "ffffff", 0.9, out 完成阅读2x, out 完成阅读2y);
                                if (完成阅读2x > 0)
                                {
                                    dm.MoveTo(完成阅读2x + gameOperation.RandomNum(0, 50), 完成阅读2y + gameOperation.RandomNum(0, 18));
                                    dm.Delays(400, 500);
                                    dm.LeftClick();
                                    dm.Delays(1000, 1200);
                                    break;
                                }
                            }
                            //3
                            while (true)
                            {
                                dm.MoveTo(gameOperation.RandomNum(340, 364), gameOperation.RandomNum(324, 405));
                                dm.Delays(800, 1000);
                                dm.LeftClick();
                                dm.Delays(800, 1000);
                                int 完成阅读3x = 0, 完成阅读3y = 0;
                                dm.FindStrFast(457, 505, 545, 530, "完成阅读", "ffffff", 0.9, out 完成阅读3x, out 完成阅读3y);
                                if (完成阅读3x > 0)
                                {
                                    dm.MoveTo(完成阅读3x + gameOperation.RandomNum(0, 60), 完成阅读3y + gameOperation.RandomNum(0, 22));
                                    dm.Delays(400, 500);
                                    dm.LeftClick();
                                    dm.Delays(1000, 1200);
                                    break;
                                }
                                else
                                {
                                    dm.KeyPress(27);
                                    dm.Delays(800, 1000);
                                }
                            }
                            //4
                            while (true)
                            {
                                dm.MoveTo(gameOperation.RandomNum(395, 456), gameOperation.RandomNum(230, 430));
                                dm.Delays(800, 1000);
                                dm.LeftClick();
                                dm.Delays(800, 1000);
                                int 完成阅读4x = 0, 完成阅读4y = 0;
                                dm.FindStrFast(457, 505, 545, 530, "完成阅读", "ffffff", 0.9, out 完成阅读4x, out 完成阅读4y);
                                if (完成阅读4x > 0)
                                {
                                    dm.MoveTo(完成阅读4x + gameOperation.RandomNum(0, 60), 完成阅读4y + gameOperation.RandomNum(0, 22));
                                    dm.Delays(400, 500);
                                    dm.LeftClick();
                                    dm.Delays(1000, 1200);
                                    break;
                                }
                                else
                                {
                                    dm.KeyPress(27);
                                    dm.Delays(800, 1000);
                                }
                            }
                            //5
                            while (true)
                            {
                                dm.MoveTo(gameOperation.RandomNum(503, 519), gameOperation.RandomNum(300, 399));
                                dm.Delays(800, 1000);
                                dm.LeftClick();
                                dm.Delays(800, 1000);
                                int 完成阅读5x = 0, 完成阅读5y = 0;
                                dm.FindStrFast(457, 505, 545, 530, "完成阅读", "ffffff", 0.9, out 完成阅读5x, out 完成阅读5y);
                                if (完成阅读5x > 0)
                                {
                                    dm.MoveTo(完成阅读5x + gameOperation.RandomNum(0, 60), 完成阅读5y + gameOperation.RandomNum(0, 22));
                                    dm.Delays(400, 500);
                                    dm.LeftClick();
                                    dm.Delays(1000, 1200);
                                    break;
                                }
                                else
                                {
                                    dm.KeyPress(27);
                                    dm.Delays(800, 1000);
                                }
                            }
                            //6
                            while (true)
                            {
                                dm.MoveTo(gameOperation.RandomNum(589, 699), gameOperation.RandomNum(269, 405));
                                dm.Delays(800, 1000);
                                dm.LeftClick();
                                dm.Delays(800, 1000);
                                int 完成阅读6x = 0, 完成阅读6y = 0;
                                dm.FindStrFast(457, 505, 545, 530, "完成阅读", "ffffff", 0.9, out 完成阅读6x, out 完成阅读6y);
                                if (完成阅读6x > 0)
                                {
                                    dm.MoveTo(完成阅读6x + gameOperation.RandomNum(0, 60), 完成阅读6y + gameOperation.RandomNum(0, 22));
                                    dm.Delays(400, 500);
                                    dm.LeftClick();
                                    dm.Delays(1000, 1200);
                                    break;
                                }
                                else
                                {
                                    dm.KeyPress(27);
                                    dm.Delays(800, 1000);
                                    break;
                                }
                            }

                            int 放回木匣x = 0, 放回木匣y = 0;
                            dm.FindStrFast(764, 450, 838, 524, "放回木匣", "EABC94-152F3A", 0.9, out 放回木匣x, out 放回木匣y);
                            if (放回木匣x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(放回木匣x + gameOperation.RandomNum(5, 25), 放回木匣y + gameOperation.RandomNum(3, 20));
                                dm.Delays(400, 500);
                                dm.LeftClick();
                                dm.Delays(1000, 1200);

                            }
                        }
                        continue;
                    }
                    #endregion

                    #region 双生孩童
                    int 双生孩童x = 0, 双生孩童y = 0;
                    dm.FindStrFast(865, 274, 974, 318, "双生孩童", "ffffff", 0.9, out 双生孩童x, out 双生孩童y);
                    if (双生孩童x > 0)
                    {
                        dm.Delays(1000, 1200);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(600, 800);
                        dm.LeftClick();
                        dm.Delays(1000, 1200);
                        int 正传x = 0, 正传y = 0;
                        var 正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 正传x, out 正传y);
                        if (正传x > 0)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(正传x + gameOperation.RandomNum(5, 35), 正传y + gameOperation.RandomNum(3, 12));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1000, 2000);

                        }
                        continue;
                    }
                    #endregion

                    #region 食梦二妖
                    int 食梦二妖x = 0, 食梦二妖y = 0;
                    dm.FindStrFast(865, 274, 974, 318, "食梦二妖", "ffffff", 0.9, out 食梦二妖x, out 食梦二妖y);
                    if (食梦二妖x > 0)
                    {

                        dm.KeyPress(69);
                        dm.Delays(800, 1000);
                        int 昭明直袍iconx = 0, 昭明直袍icony = 0;
                        dm.FindPic(232, 225, 1010, 423, "\\package\\zhaomingzhipao.bmp", "000000", 0.9, 0, out 昭明直袍iconx, out 昭明直袍icony);
                        if (昭明直袍iconx > 0)
                        {
                            dm.Delays(800, 1000);
                            dm.MoveToEx(昭明直袍iconx, 昭明直袍icony, 10, 10);
                            dm.Delays(800, 1000);
                            dm.Delays(1000, 1500);
                            int 紫云罗衫x = 0, 紫云罗衫y = 0;
                            dm.FindStrFast(439, 479, 491, 496, "紫云罗衫", "ff5050", 0.9, out 紫云罗衫x, out 紫云罗衫y);
                            if (紫云罗衫x > 0)
                            {
                                dm.RightClick();
                                dm.Delays(800, 1000);
                            }
                            dm.KeyPress(27);
                            dm.Delays(800, 1000);
                        }
                        while (true)
                        {
                            dm.KeyPress(9);
                            dm.Delays(1000, 1200);
                            dm.MoveTo(gameOperation.RandomNum(364, 445), gameOperation.RandomNum(140, 145));
                            dm.Delays(1000, 1200);
                            dm.LeftDoubleClick();
                            dm.Delays(1000, 1500);
                            dm.SendString(user.hwnd, "聂小倩");
                            dm.Delays(1000, 1200);
                            dm.KeyPress(13);
                            dm.Delays(1000, 1200);
                            int 正传x = 0, 正传y = 0;
                            var 正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 正传x, out 正传y);
                            if (正传x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(正传x + gameOperation.RandomNum(5, 35), 正传y + gameOperation.RandomNum(3, 12));
                                dm.Delays(400, 500);
                                dm.LeftClick();
                                dm.Delays(1000, 1500);
                                int 与食梦双妖x = 0, 与食梦双妖y = 0;
                                dm.FindStrFast(345, 426, 685, 560, "与食梦双妖", "ffffff", 0.9, out 与食梦双妖x, out 与食梦双妖y);//363,425,488,445
                                if (与食梦双妖x > 0)
                                {
                                    dm.Delays(400, 500);
                                    dm.MoveTo(与食梦双妖x + gameOperation.RandomNum(5, 35), 与食梦双妖y + gameOperation.RandomNum(3, 12));
                                    dm.Delays(400, 500);
                                    dm.LeftClick();
                                    dm.Delays(1000, 1500);
                                    break;
                                }
                            }

                        }
                        dm.KeyPress(27);
                        dm.Delays(800, 1000);
                        dm.KeyPress(27);
                        dm.Delays(800, 1000);
                        //战斗
                        gameOperation.IsContinue = true;
                        Thread jiaxueThread = new Thread(gameOperation.WuNaoJiaXue);//创建加血线程
                        jiaxueThread.Start();
                        Thread jialanThread = new Thread(gameOperation.JiaLan);//创建加蓝线程
                        jialanThread.Start();
                        while (true)
                        {
                            int 哀妖uix = 0, 哀妖uiy = 0;
                            dm.FindStrFast(0, 0, 1024, 768, "食梦哀妖ui", "ff88ff", 0.9, out 哀妖uix, out 哀妖uiy);
                            if (哀妖uix > 0)
                            {
                                break;
                            }
                            else
                            {
                                gameOperation.QieGuai();
                            }
                            dm.Delays(1000, 1200);
                        }
                        while (true)
                        {
                            int 哀妖死亡x = 0, 哀妖死亡y = 0;
                            dm.FindStrFast(820, 274, 989, 341, "食梦哀妖(1", "ffffff", 0.98, out 哀妖死亡x, out 哀妖死亡y);
                            int 喜妖死亡x = 0, 喜妖死亡y = 0;
                            dm.FindStrFast(832, 291, 932, 308, "食梦喜妖(1", "ffffff", 0.98, out 喜妖死亡x, out 喜妖死亡y);
                            if (哀妖死亡x > 0 || 喜妖死亡x > 0)
                            {
                                break;
                            }
                            int 哀妖x = 0, 哀妖y = 0;
                            dm.FindStrFast(0, 0, 1024, 768, "食梦哀妖", "D96AD9-261E26", 0.9, out 哀妖x, out 哀妖y);
                            if (哀妖x > 0)
                            {
                                dm.MoveTo(哀妖x + gameOperation.RandomNum(25, 35), 哀妖y + gameOperation.RandomNum(45, 65));
                                dm.Delays(200, 300);
                                dm.LeftClick();
                                dm.Delays(200, 300);
                            }
                            int 喜妖x = 0, 喜妖y = 0;
                            dm.FindStrFast(0, 0, 1024, 768, "食梦喜妖", "D96AD9-261E26", 0.9, out 喜妖x, out 喜妖y);
                            if (喜妖x > 0)
                            {
                                dm.MoveTo(喜妖x + gameOperation.RandomNum(25, 35), 喜妖y + gameOperation.RandomNum(45, 65));
                                dm.Delays(200, 300);
                                dm.LeftClick();
                                dm.Delays(200, 300);
                            }
                            gameOperation.ZhanDou();
                            int 原地普通复活x = 0, 原地普通复活y = 0;
                            dm.FindStrFast(830, 280, 982, 334, "原地普通复活", "bac4d6", 0.9, out 原地普通复活x, out 原地普通复活y);
                            if (原地普通复活x > 0)
                            {
                                gameOperation.IsContinue = false;
                                break;
                            }
                        }
                        gameOperation.QieGuai();
                        while (true)
                        {
                            int 退出x = 0, 退出y = 0;
                            dm.FindStrFast(830, 280, 982, 334, "下划线1|标准下划线", "00ff00", 0.9, out 退出x, out 退出y);
                            if (退出x > 0)
                            {
                                gameOperation.IsContinue = false;//战斗结束，退出循环加血线程自动结束
                                break;
                            }
                            int 哀妖x = 0, 哀妖y = 0;
                            dm.FindStrFast(0, 0, 1024, 768, "食梦哀妖", "D96AD9-261E26", 0.9, out 哀妖x, out 哀妖y);
                            if (哀妖x > 0)
                            {
                                dm.MoveTo(哀妖x + gameOperation.RandomNum(25, 35), 哀妖y + gameOperation.RandomNum(45, 65));
                                dm.Delays(200, 300);
                                dm.LeftClick();
                                dm.Delays(200, 300);
                            }
                            int 喜妖x = 0, 喜妖y = 0;
                            dm.FindStrFast(0, 0, 1024, 768, "食梦喜妖", "D96AD9-261E26", 0.9, out 喜妖x, out 喜妖y);
                            if (喜妖x > 0)
                            {
                                dm.MoveTo(喜妖x + gameOperation.RandomNum(25, 35), 喜妖y + gameOperation.RandomNum(45, 65));
                                dm.Delays(200, 300);
                                dm.LeftClick();
                                dm.Delays(200, 300);
                            }
                            gameOperation.ZhanDou();
                            int 原地普通复活x = 0, 原地普通复活y = 0;
                            dm.FindStrFast(830, 280, 982, 334, "原地普通复活", "bac4d6", 0.9, out 原地普通复活x, out 原地普通复活y);
                            if (原地普通复活x > 0)
                            {
                                gameOperation.IsContinue = false;
                                break;
                            }
                        }
                        continue;
                    } 
                    #endregion

                    #region 迎战姥姥
                    int 迎战姥姥x = 0, 迎战姥姥y = 0;
                    dm.FindStrFast(865, 274, 974, 318, "迎战姥姥", "ffffff", 0.9, out 迎战姥姥x, out 迎战姥姥y);
                    if (迎战姥姥x > 0)
                    {
                        dm.Delays(1000, 1200);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(600, 800);
                        dm.LeftClick();
                        dm.Delays(1000, 1200);
                        int 任务下划线x = 0, 任务下划线y = 0;
                        dm.FindStrFast(74, 193, 273, 229, "下划线1|标准下划线", "00ff00", 0.9, out 任务下划线x, out 任务下划线y);
                        if (任务下划线x > 0)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(任务下划线x + gameOperation.RandomNum(10, 60), 任务下划线y - gameOperation.RandomNum(3, 10));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1000, 1500);
                            int 正传x = 0, 正传y = 0;
                            var 正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 正传x, out 正传y);
                            if (正传x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(正传x + gameOperation.RandomNum(5, 35), 正传y + gameOperation.RandomNum(3, 12));
                                dm.Delays(400, 500);
                                dm.LeftClick();
                                dm.Delays(1000, 2000);
                                int 迎战姥姥2x = 0, 迎战姥姥2y = 0;
                                dm.FindStrFast(359, 421, 426, 452, "迎战姥姥", "ffffff", 0.9, out 迎战姥姥2x, out 迎战姥姥2y);
                                if (正传x > 0)
                                {
                                    dm.Delays(400, 500);
                                    dm.MoveTo(迎战姥姥2x + gameOperation.RandomNum(5, 35), 迎战姥姥2y + gameOperation.RandomNum(3, 12));
                                    dm.Delays(400, 500);
                                    dm.LeftClick();
                                    dm.Delays(1000, 2000);
                                }
                            }
                        }
                        gameOperation.IsContinue = true;
                        Thread jiaxueThread = new Thread(gameOperation.WuNaoJiaXue);//创建加血线程
                        jiaxueThread.Start();
                        Thread jialanThread = new Thread(gameOperation.JiaLan);//创建加蓝线程
                        jialanThread.Start();
                        while (true)
                        {
                            gameOperation.QieGuai();
                            int 退出x = 0, 退出y = 0;
                            dm.FindStrFast(830, 280, 982, 334, "下划线1|标准下划线", "00ff00", 0.9, out 退出x, out 退出y);
                            if (退出x > 0)
                            {
                                gameOperation.IsContinue = false;//战斗结束，退出循环加血线程自动结束
                                break;
                            }
                            int 姥姥x = 0, 姥姥y = 0;
                            dm.FindStrFast(0, 0, 1024, 768, "姥姥", "D96AD9-261E26", 0.9, out 姥姥x, out 姥姥y);
                            if (姥姥x > 0)
                            {
                                dm.MoveTo(姥姥x + gameOperation.RandomNum(25, 35), 姥姥y + gameOperation.RandomNum(45, 65));
                                dm.Delays(200, 300);
                                dm.LeftClick();
                                dm.Delays(200, 300);
                            }
                            gameOperation.ZhanDou();
                            int 原地普通复活x = 0, 原地普通复活y = 0;
                            dm.FindStrFast(830, 280, 982, 334, "原地普通复活", "bac4d6", 0.9, out 原地普通复活x, out 原地普通复活y);
                            if (原地普通复活x > 0)
                            {
                                gameOperation.IsContinue = false;
                                break;
                            }
                        }
                        continue;
                    } 
                    #endregion

                    #region 决心救人
                    int 决心救人x = 0, 决心救人y = 0;
                    dm.FindStrFast(865, 274, 974, 318, "决心救人", "ffffff", 0.9, out 决心救人x, out 决心救人y);
                    if (决心救人x > 0)
                    {
                        dm.Delays(1000, 1200);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(600, 800);
                        dm.LeftClick();
                        dm.Delays(1000, 1200);
                        int 正传x = 0, 正传y = 0;
                        var 正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 正传x, out 正传y);
                        if (正传x > 0)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(正传x + gameOperation.RandomNum(5, 35), 正传y + gameOperation.RandomNum(3, 12));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1000, 2000);
                        }
                        continue;
                    } 
                    #endregion

                    #region 安眠之夜
                    int 安眠之夜x = 0, 安眠之夜y = 0;
                    dm.FindStrFast(865, 274, 974, 318, "安眠之夜", "ffffff", 0.9, out 安眠之夜x, out 安眠之夜y);
                    if (安眠之夜x > 0)
                    {
                        while (true)
                        {
                            dm.Delays(1000, 1200);
                            dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                            dm.Delays(600, 800);
                            dm.LeftClick();
                            dm.Delays(1000, 1200);
                            int 小蝶退出x = 0, 小蝶退出y = 0;
                            dm.FindStrFast(826, 294, 933, 329, "小蝶(1/1)", "ffffff", 0.9, out 小蝶退出x, out 小蝶退出y);
                            if (小蝶退出x > 0)
                            {
                                break;
                            }
                            int 小蝶x = 0, 小蝶y = 0;
                            dm.FindStrFast(826, 294, 933, 329, "小蝶", "ffffff", 0.9, out 小蝶x, out 小蝶y);
                            if (小蝶x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(小蝶x + gameOperation.RandomNum(5, 50), 小蝶y + gameOperation.RandomNum(3, 12));
                                dm.Delays(400, 500);
                                dm.LeftClick();
                                dm.Delays(1000, 2000);
                                int 正传x = 0, 正传y = 0;
                                var 正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 正传x, out 正传y);
                                if (正传x > 0)
                                {
                                    dm.Delays(400, 500);
                                    dm.MoveTo(正传x + gameOperation.RandomNum(5, 35), 正传y + gameOperation.RandomNum(3, 12));
                                    dm.Delays(400, 500);
                                    dm.LeftClick();
                                    dm.Delays(1000, 2000);

                                }
                            }
                        }
                        //燕赤霞
                        while (true)
                        {
                            int 燕赤霞x = 0, 燕赤霞y = 0;
                            dm.FindStrFast(826, 294, 933, 329, "燕赤霞", "ffffff", 0.9, out 燕赤霞x, out 燕赤霞y);
                            if (燕赤霞x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(燕赤霞x + gameOperation.RandomNum(5, 50), 燕赤霞y + gameOperation.RandomNum(3, 12));
                                dm.Delays(400, 500);
                                dm.LeftClick();
                                dm.Delays(1000, 2000);
                                int 正传x = 0, 正传y = 0;
                                var 正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 正传x, out 正传y);
                                if (正传x > 0)
                                {
                                    dm.Delays(400, 500);
                                    dm.MoveTo(正传x + gameOperation.RandomNum(5, 35), 正传y + gameOperation.RandomNum(3, 12));
                                    dm.Delays(400, 500);
                                    dm.LeftClick();
                                    dm.Delays(1000, 2000);
                                    break;
                                }
                            }
                        }
                        continue;
                    }
                    #endregion

                    #region 孤身犯险
                    int 孤身犯险x = 0, 孤身犯险y = 0;
                    dm.FindStrFast(865, 274, 974, 318, "孤身犯险", "ffffff", 0.9, out 孤身犯险x, out 孤身犯险y);
                    if (孤身犯险x > 0)
                    {
                        dm.Delays(1000, 1200);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(600, 800);
                        dm.LeftClick();
                        dm.Delays(1000, 1200);
                        int 正传x = 0, 正传y = 0;
                        var 正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 正传x, out 正传y);
                        if (正传x > 0)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(正传x + gameOperation.RandomNum(5, 35), 正传y + gameOperation.RandomNum(3, 12));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1000, 2000);
                        }
                        continue;
                    } 
                    #endregion

                    #region 再入兰若
                    int 再入兰若x = 0, 再入兰若y = 0;
                    dm.FindStrFast(865, 274, 974, 318, "再入兰若", "ffffff", 0.9, out 再入兰若x, out 再入兰若y);
                    if (再入兰若x > 0)
                    {
                        dm.LeftClick();
                        int 年纪很大的树妖x = 0, 年纪很大的树妖y = 0;
                        dm.FindStrFast(927, 292, 969, 313, "(0", "ffffff", 0.95, out 年纪很大的树妖x, out 年纪很大的树妖y);
                        if (年纪很大的树妖x > 0)
                        {
                            dm.Delays(1000, 1200);
                            dm.MoveTo(年纪很大的树妖x, 年纪很大的树妖y);
                            dm.Delays(600, 800);
                            dm.LeftClick();
                            dm.Delays(1000, 1200);
                            int 正传x = 0, 正传y = 0;
                            var 正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 正传x, out 正传y);
                            if (正传x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(正传x + gameOperation.RandomNum(5, 35), 正传y + gameOperation.RandomNum(3, 12));
                                dm.Delays(400, 500);
                                dm.LeftClick();
                                dm.Delays(1500, 2500);

                            }
                        }
                        int 还未修成人型的树x = 0, 还未修成人型的树y = 0;
                        dm.FindStrFast(934, 323, 978, 346, "(0", "ffffff", 0.95, out 还未修成人型的树x, out 还未修成人型的树y);
                        if (还未修成人型的树x > 0)
                        {
                            dm.Delays(1000, 1200);
                            dm.MoveTo(还未修成人型的树x, 还未修成人型的树y);
                            dm.Delays(600, 800);
                            dm.LeftClick();
                            dm.Delays(1000, 1200);
                            int 正传x = 0, 正传y = 0;
                            var 正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 正传x, out 正传y);
                            if (正传x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(正传x + gameOperation.RandomNum(5, 35), 正传y + gameOperation.RandomNum(3, 12));
                                dm.Delays(400, 500);
                                dm.LeftClick();
                                dm.Delays(1500, 2500);
                                for (int i = 0; i < 6; i++)
                                {
                                    dm.LeftClick();
                                    dm.Delays(800, 1000);
                                }
                            }
                        }
                        int 黑花x = 0, 黑花y = 0;
                        dm.FindStrFast(861, 354, 893, 378, "(0", "ffffff", 0.95, out 黑花x, out 黑花y);
                        if (黑花x > 0)
                        {
                            dm.Delays(1000, 1200);
                            dm.MoveTo(黑花x + gameOperation.RandomNum(10, 50), 黑花y);
                            dm.Delays(600, 800);
                            dm.LeftClick();
                            dm.Delays(1000, 1200);
                            int 正传x = 0, 正传y = 0;
                            var 正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 正传x, out 正传y);
                            if (正传x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(正传x + gameOperation.RandomNum(5, 35), 正传y + gameOperation.RandomNum(3, 12));
                                dm.Delays(400, 500);
                                dm.LeftClick();
                                dm.Delays(1500, 2500);
                                dm.KeyPress(27);
                            }
                        }
                        continue;
                    }
                    #endregion

                    #region 兰若盛事
                    int 兰若盛事x = 0, 兰若盛事y = 0;
                    dm.FindStrFast(865, 274, 974, 318, "兰若盛事", "ffffff", 0.95, out 兰若盛事x, out 兰若盛事y);
                    if (兰若盛事x > 0)
                    {
                        while (true)
                        {
                            dm.Delays(1000, 1500);
                            dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                            dm.Delays(600, 800);
                            dm.RightClick();
                            dm.Delays(1000, 1500);
                            int 任务下划线x = 0, 任务下划线y = 0;
                            dm.FindStrFast(134, 205, 336, 254, "下划线1", "00ff00", 0.95, out 任务下划线x, out 任务下划线y);
                            if (任务下划线x > 0)
                            {
                                dm.Delays(1000, 1500);
                                dm.MoveTo(任务下划线x + gameOperation.RandomNum(10, 50), 任务下划线y - gameOperation.RandomNum(3, 10));
                                dm.Delays(600, 800);
                                dm.LeftClick();
                                dm.Delays(1000, 1500);
                            }
                            int 兰若盛事继续x = 0, 兰若盛事继续y = 0;
                            dm.FindStrFast(621, 590, 683, 611, "F继续", "fff0b3", 0.9, out 兰若盛事继续x, out 兰若盛事继续y);
                            if (兰若盛事继续x > 0)
                            {
                                while (true)
                                {

                                    int 颜色x = 0, 颜色y = 0;
                                    dm.FindColor(620, 591, 788, 610, "fff0b3", 0.95, 5, out 颜色x, out 颜色y);
                                    if (颜色x > 0)
                                    {
                                        dm.MoveTo(gameOperation.RandomNum(622, 812), gameOperation.RandomNum(590, 610));
                                        dm.Delays(1000, 1500);
                                        dm.LeftClick();
                                        dm.Delays(1000, 1200);
                                    }
                                    int 大x = 0, 大y = 0;
                                    dm.FindStrFast(596, 305, 721, 438, "大", "745E4A-2B2E2A", 0.95, out 大x, out 大y);
                                    if (大x > 0)
                                    {
                                        dm.MoveTo(大x + gameOperation.RandomNum(0, 25), 大y + gameOperation.RandomNum(0, 25));
                                        dm.Delays(800, 1000);
                                        dm.LeftClick();
                                        dm.Delays(600, 800);
                                    }
                                    int 完成x = 0, 完成y = 0;
                                    dm.FindStrFast(559, 506, 612, 528, "完成|F继续", "ffffff", 0.95, out 完成x, out 完成y);
                                    if (完成x > 0)
                                    {
                                        dm.MoveTo(完成x + gameOperation.RandomNum(0, 30), 完成y + gameOperation.RandomNum(0, 12));
                                        dm.Delays(1000, 1500);
                                        dm.LeftClick();

                                    }

                                    int 退出x = 0, 退出y = 0;
                                    dm.FindStrFast(822, 283, 880, 302, "标准下划线", "00ff00", 0.95, out 退出x, out 退出y);
                                    if (退出x > 0)
                                    {
                                        break;
                                    }
                                }

                            }
                            int 退出2x = 0, 退出2y = 0;
                            dm.FindStrFast(822, 283, 880, 302, "标准下划线", "00ff00", 0.95, out 退出2x, out 退出2y);
                            if (退出2x > 0)
                            {
                                break;
                            }
                        }
                        continue;
                    } 
                    #endregion

                    #region 深入虎穴
                    int 深入虎穴x = 0, 深入虎穴y = 0;
                    dm.FindStrFast(865, 274, 974, 318, "深入虎穴", "ffffff", 0.95, out 深入虎穴x, out 深入虎穴y);
                    if (深入虎穴x > 0)
                    {
                        while (true)
                        {
                            dm.Delays(1000, 1500);
                            dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                            dm.Delays(600, 800);
                            dm.LeftClick();
                            dm.Delays(1000, 1200);
                            dm.KeyPress(53);
                            int 退出x = 0, 退出y = 0;
                            dm.FindStrFast(822, 283, 880, 302, "标准下划线", "00ff00", 0.95, out 退出x, out 退出y);
                            if (退出x > 0)
                            {
                                break;
                            }
                        }
                        continue;
                    }
                    #endregion

                    #region 危机四伏
                    int 危机四伏x = 0, 危机四伏y = 0;
                    dm.FindStrFast(865, 274, 974, 318, "危机四伏", "ffffff", 0.95, out 危机四伏x, out 危机四伏y);
                    if (危机四伏x > 0)
                    {
                        while (true)
                        {
                            dm.KeyPress(27);
                            dm.Delays(1000, 1200);
                            dm.KeyPress(67);
                            dm.Delays(1000, 1500);
                            int 驱邪符1iconx = 0, 驱邪符1icony = 0;
                            dm.FindPic(167, 485, 481, 623, "\\package\\quxiefu.bmp", "000000", 0.9, 0, out 驱邪符1iconx, out 驱邪符1icony);
                            if (驱邪符1iconx < 0)
                            {
                                int 额外技能x = 0, 额外技能y = 0;
                                dm.FindStrFast(228, 133, 293, 157, "额外技能", "90acda", 0.95, out 额外技能x, out 额外技能y);
                                if (额外技能x > 0)
                                {
                                    dm.MoveTo(额外技能x + gameOperation.RandomNum(10, 45), 额外技能y + gameOperation.RandomNum(3, 10));
                                    dm.Delays(1000, 1500);
                                    dm.LeftClick();
                                    dm.Delays(1000, 1500);
                                }
                            }
                            int 驱邪符iconx = 0, 驱邪符icony = 0;
                            dm.FindPic(167, 485, 481, 623, "\\package\\quxiefu.bmp", "000000", 0.9, 0, out 驱邪符iconx, out 驱邪符icony);
                            if (驱邪符iconx > 0)
                            {
                                dm.Delays(1000, 1500);
                                dm.MoveTo(驱邪符iconx + gameOperation.RandomNum(0, 10), 驱邪符icony + gameOperation.RandomNum(0, 10));
                                dm.Delays(600, 800);
                                dm.LeftClick();
                                dm.Delays(1000, 1200);
                                dm.MoveTo(gameOperation.RandomNum(440, 468), gameOperation.RandomNum(712, 738));
                                dm.Delays(1000, 1200);
                                dm.LeftClick();
                                dm.Delays(800, 1000);
                                dm.MoveTo(gameOperation.RandomNum(0, 200), gameOperation.RandomNum(0, 200));
                                dm.Delays(800, 1000);
                                dm.RightClick();
                                dm.KeyPress(27);
                                break;
                            }
                        }
                        while (true)
                        {
                            dm.KeyPress(27);
                            dm.Delays(1000, 1200);
                            dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                            dm.Delays(600, 800);
                            dm.LeftClick();
                            dm.Delays(1000, 1200);
                            int 任务下划线x = 0, 任务下划线y = 0;
                            dm.FindStrFast(112, 232, 251, 257, "下划线1", "00ff00", 0.95, out 任务下划线x, out 任务下划线y);
                            if (任务下划线x > 0)
                            {
                                dm.Delays(1000, 1200);
                                dm.MoveTo(任务下划线x + gameOperation.RandomNum(10, 50), 任务下划线y - gameOperation.RandomNum(3, 10));
                                dm.Delays(600, 800);
                                dm.LeftClick();
                                dm.Delays(1000, 1200);
                                int 迎战小鬼x = 0, 迎战小鬼y = 0;
                                dm.FindStrFast(360, 447, 454, 470, "迎战小鬼", "ffffff", 0.95, out 迎战小鬼x, out 迎战小鬼y);
                                if (迎战小鬼x > 0)
                                {
                                    dm.Delays(800, 1000);
                                    dm.MoveTo(迎战小鬼x + gameOperation.RandomNum(10, 50), 迎战小鬼y + gameOperation.RandomNum(3, 10));
                                    dm.Delays(600, 800);
                                    dm.LeftClick();
                                    dm.Delays(1000, 1200);
                                    dm.KeyPress(27);
                                    dm.Delays(800, 1000);
                                    dm.KeyPress(27);
                                    dm.Delays(800, 1000);
                                    break;
                                }
                            }
                        }
                        for (int i = 0; i < 10; i++)
                        {
                            dm.delay(1000);
                        }
                        while (true)
                        {
                            gameOperation.QieGuai();
                            dm.KeyPress(57);
                            dm.Delays(200, 300);

                        }
                        continue;
                    }
                    #endregion

                    #region 双目失辉
                    int 双目失辉x = 0, 双目失辉y = 0;
                    dm.FindStrFast(865, 274, 974, 318, "双目失辉", "ffffff", 0.95, out 双目失辉x, out 双目失辉y);
                    if (双目失辉x > 0)
                    {
                        dm.Delays(1000, 1500);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(600, 800);
                        dm.LeftClick();
                        dm.Delays(1000, 1200);
                        int 正传x = 0, 正传y = 0;
                        var 正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 正传x, out 正传y);
                        if (正传x > 0)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(正传x + gameOperation.RandomNum(5, 35), 正传y + gameOperation.RandomNum(3, 12));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1500, 2500);

                        }
                        continue;
                    }
                    #endregion

                    #region 三座佛像
                    int 三座佛像x = 0, 三座佛像y = 0;
                    dm.FindStrFast(865, 274, 974, 318, "三座佛像", "ffffff", 0.95, out 三座佛像x, out 三座佛像y);
                    if (三座佛像x > 0)
                    {
                        dm.Delays(1000, 1500);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(600, 800);
                        dm.LeftClick();
                        dm.Delays(1000, 1200);
                        int 正传x = 0, 正传y = 0;
                        var 正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 正传x, out 正传y);
                        if (正传x > 0)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(正传x + gameOperation.RandomNum(5, 35), 正传y + gameOperation.RandomNum(3, 12));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1500, 2500);

                        }
                        continue;
                    }
                    #endregion

                    #region 绝境述心
                    int 绝境述心x = 0, 绝境述心y = 0;
                    dm.FindStrFast(865, 274, 974, 318, "绝境述心", "ffffff", 0.95, out 绝境述心x, out 绝境述心y);
                    if (绝境述心x > 0)
                    {
                        while (true)
                        {
                            dm.KeyPress(27);
                            dm.Delays(1000, 1200);
                            dm.KeyPress(27);
                            dm.Delays(1000, 1500);
                            dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                            dm.Delays(600, 800);
                            dm.LeftClick();
                            dm.Delays(1000, 1200);
                            dm.KeyPress(9);
                            dm.Delays(1000, 1200);
                            dm.MoveTo(gameOperation.RandomNum(364, 445), gameOperation.RandomNum(140, 145));
                            dm.Delays(1000, 1200);
                            dm.LeftDoubleClick();
                            dm.Delays(1000, 1500);
                            //dm.KeyPressStr("聂小倩", 100);
                            dm.SendString(user.hwnd, "聂小倩");
                            dm.Delays(1000, 1200);
                            dm.KeyPress(13);
                            dm.Delays(1000, 1200);
                            int 正传x = 0, 正传y = 0;
                            var 正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 正传x, out 正传y);
                            if (正传x > 0)
                            {
                                dm.KeyPress(27);
                                dm.Delays(1000, 1200);
                                dm.KeyPress(27);
                                dm.Delays(1000, 1500);
                                break;
                            }
                        }
                        while (true)
                        {
                            dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                            dm.Delays(600, 800);
                            dm.LeftClick();
                            dm.Delays(1000, 1200);
                            dm.MoveTo(gameOperation.RandomNum(495, 520), gameOperation.RandomNum(204, 226));
                            dm.Delays(1000, 1200);
                            dm.RightClick();
                            int 退出x = 0, 退出y = 0;
                            dm.FindStrFast(822, 283, 880, 302, "标准下划线", "00ff00", 0.95, out 退出x, out 退出y);
                            if (退出x > 0)
                            {
                                break;
                            }
                        }
                        continue;
                    } 
                    #endregion

                    #region 往昔释怀
                    int 往昔释怀x = 0, 往昔释怀y = 0;
                    dm.FindStrFast(865, 274, 974, 318, "往昔释怀", "ffffff", 0.95, out 往昔释怀x, out 往昔释怀y);
                    if (往昔释怀x > 0)
                    {
                        dm.Delays(1000, 1500);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(600, 800);
                        dm.RightClick();
                        dm.Delays(1000, 1200);
                        int 任务下划线x = 0, 任务下划线y = 0;
                        dm.FindStrFast(57, 205, 109, 231, "标准下划线", "00ff00", 0.95, out 任务下划线x, out 任务下划线y);
                        if (任务下划线x > 0)
                        {
                            dm.Delays(1000, 1200);
                            dm.MoveTo(任务下划线x + gameOperation.RandomNum(10, 50), 任务下划线y - gameOperation.RandomNum(3, 10));
                            dm.Delays(600, 800);
                            dm.LeftClick();
                            dm.Delays(1000, 1200);
                            int 正传x = 0, 正传y = 0;
                            var 正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 正传x, out 正传y);
                            if (正传x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(正传x + gameOperation.RandomNum(5, 35), 正传y + gameOperation.RandomNum(3, 12));
                                dm.Delays(400, 500);
                                dm.LeftClick();
                                dm.Delays(1500, 2500);
                            }
                        }
                        continue;
                    } 
                    #endregion

                    #region 乾坤互换
                    int 乾坤互换x = 0, 乾坤互换y = 0;
                    dm.FindStrFast(865, 274, 974, 318, "乾坤互换", "ffffff", 0.95, out 乾坤互换x, out 乾坤互换y);
                    if (乾坤互换x > 0)
                    {
                        dm.Delays(1000, 1500);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(600, 800);
                        dm.LeftClick();
                        dm.Delays(1000, 1200);
                        dm.MoveTo(gameOperation.RandomNum(495, 520), gameOperation.RandomNum(204, 226));
                        dm.Delays(1000, 1200);
                        dm.RightClick();
                        dm.Delays(1000, 1200);
                        continue;
                    } 
                    #endregion

                    #region 血之抉择
                    int 血之抉择x = 0, 血之抉择y = 0;
                    dm.FindStrFast(865, 274, 974, 318, "血之抉择", "ffffff", 0.95, out 血之抉择x, out 血之抉择y);
                    if (血之抉择x > 0)
                    {
                        dm.Delays(1000, 1500);
                        dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                        dm.Delays(600, 800);
                        dm.LeftClick();
                        dm.Delays(1000, 1200);
                        int 任务下划线x = 0, 任务下划线y = 0;
                        dm.FindStrFast(60, 203, 118, 229, "标准下划线", "00ff00", 0.95, out 任务下划线x, out 任务下划线y);
                        if (任务下划线x > 0)
                        {
                            dm.Delays(1000, 1200);
                            dm.MoveTo(任务下划线x + gameOperation.RandomNum(10, 50), 任务下划线y - gameOperation.RandomNum(3, 10));
                            dm.Delays(600, 800);
                            dm.LeftClick();
                            dm.Delays(1000, 1200);
                            int 正传x = 0, 正传y = 0;
                            var 正传 = dm.FindStrFast(345, 426, 685, 560, "[正传]|[剧情]", "ffffff", 0.9, out 正传x, out 正传y);
                            if (正传x > 0)
                            {
                                dm.Delays(400, 500);
                                dm.MoveTo(正传x + gameOperation.RandomNum(5, 35), 正传y + gameOperation.RandomNum(3, 12));
                                dm.Delays(400, 500);
                                dm.LeftClick();
                                dm.Delays(1500, 2500);
                            }
                        }
                        continue;
                    } 
                    #endregion

                    #region 再别倩容
                    int 再别倩容x = 0, 再别倩容y = 0;
                    dm.FindStrFast(865, 274, 974, 318, "再别倩容", "ffffff", 0.95, out 再别倩容x, out 再别倩容y);
                    if (再别倩容x > 0)
                    {
                        while (true)
                        {
                            dm.Delays(1000, 1500);
                            dm.MoveTo(白色战斗任务下划线x + gameOperation.RandomNum(10, 50), 白色战斗任务下划线y - gameOperation.RandomNum(3, 10));
                            dm.Delays(600, 800);
                            dm.RightClick();
                            dm.Delays(1000, 1200);
                            int 任务下划线x = 0, 任务下划线y = 0;
                            dm.FindStrFast(156, 204, 220, 225, "标准下划线", "00ff00", 0.95, out 任务下划线x, out 任务下划线y);
                            if (任务下划线x > 0)
                            {
                                dm.Delays(1000, 1200);
                                dm.MoveTo(任务下划线x + gameOperation.RandomNum(10, 50), 任务下划线y - gameOperation.RandomNum(3, 10));
                                dm.Delays(600, 800);
                                dm.LeftClick();
                                dm.Delays(1000, 1200);
                                int 石头x = 0, 石头y = 0;
                                dm.FindStrFast(388, 241, 742, 483, "石头", "5B255B-1C251C", 0.9, out 石头x, out 石头y);
                                if (石头x > 0)
                                {
                                    dm.Delays(1000, 1200);
                                    dm.MoveTo(石头x + 18, 石头y + gameOperation.RandomNum(43, 73));
                                    dm.Delays(1000, 1200);
                                    dm.LeftClick();
                                    dm.Delays(1000, 1200);
                                    int 颜色x = 0, 颜色y = 0;
                                    dm.FindColor(620, 591, 788, 610, "fff0b3", 0.95, 5, out 颜色x, out 颜色y);
                                    if (颜色x > 0)
                                    {
                                        dm.MoveTo(gameOperation.RandomNum(622, 812), gameOperation.RandomNum(590, 610));
                                        dm.Delays(1000, 1500);
                                        dm.LeftClick();
                                        dm.Delays(1000, 1200);
                                        dm.KeyPress(27);
                                        break;
                                    }
                                }
                            }
                        }

                        //打开包裹
                        while (true)
                        {
                            dm.KeyPress(27);
                            dm.Delays(1000, 1200);
                            dm.KeyPress(69);
                            dm.Delays(1000, 1200);
                            int 锋利石头iconx = 0, 锋利石头icony = 0;
                            dm.FindPic(352, 220, 667, 421, "\\package\\fenglishitou.bmp", "000000", 0.9, 0, out 锋利石头iconx, out 锋利石头icony);
                            if (锋利石头iconx < 0)
                            {
                                int 任务x = 0, 任务y = 0;
                                dm.FindStrFast(570, 197, 620, 218, "任务", "90acda-1C251C", 0.95, out 任务x, out 任务y);
                                if (任务x > 0)
                                {
                                    dm.Delays(1000, 1200);
                                    dm.MoveTo(任务x + gameOperation.RandomNum(0, 35), 任务y + gameOperation.RandomNum(0, 15));
                                    dm.Delays(1000, 1200);
                                    dm.LeftClick();
                                    dm.Delays(1000, 1200);
                                }
                            }
                            int 锋利石头1iconx = 0, 锋利石头1icony = 0;
                            dm.FindPic(352, 220, 667, 421, "\\package\\fenglishitou.bmp", "000000", 0.9, 0, out 锋利石头1iconx, out 锋利石头1icony);
                            if (锋利石头1iconx > 0)
                            {
                                dm.MoveTo(锋利石头1iconx + gameOperation.RandomNum(0, 10), 锋利石头1icony + gameOperation.RandomNum(0, 10));
                                dm.Delays(1000, 1200);
                                dm.RightClick();
                                dm.Delays(1000, 1200);
                                while (true)
                                {
                                    dm.MoveTo(gameOperation.RandomNum(423, 600), gameOperation.RandomNum(394, 530));
                                    dm.Delays(600, 800);
                                    dm.LeftClick();
                                    int 以血易命x = 0, 以血易命y = 0;
                                    dm.FindStrFast(456, 122, 522, 147, "以血易命", "d7de40", 0.9, out 以血易命x, out 以血易命y);
                                    if (以血易命x > 0)
                                    {
                                        dm.KeyPress(27);
                                        dm.Delays(600, 800);
                                        dm.KeyPress(27);
                                        dm.Delays(600, 800);
                                        break;
                                    }
                                }
                                break;
                            }
                        }
                        continue;
                    } 
                    #endregion

                }
                //迷雾泛起
                int 不是x = 0, 不是y = 0;
                var 不是 = dm.FindStrFast(617, 560, 700, 611, "不是", "fff0b3", 0.9, out 不是x, out 不是y);
                if (不是x > 0)
                {
                    while (true)
                    {
                        //提示是否召唤灵兽获取经验
                        int 自动召唤x = 0, 自动召唤y = 0;
                        var 自动召唤 = dm.FindStrFast(471, 423, 556, 463, "自动召唤", "ffffff", 0.9, out 自动召唤x, out 自动召唤y);
                        if (自动召唤x > 0)
                        {
                            dm.Delays(400, 500);
                            dm.MoveTo(自动召唤x + gameOperation.RandomNum(3, 45), 自动召唤y + gameOperation.RandomNum(3, 12));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(1000, 1200);
                        }
                        dm.Delays(400, 500);
                        dm.MoveTo(不是x + gameOperation.RandomNum(5, 35), 不是y + gameOperation.RandomNum(0, 12));
                        dm.Delays(400, 500);
                        dm.LeftClick();
                        dm.Delays(1000, 1200);
                        int Fx = 0, Fy = 0;
                        dm.FindStrFast(300, 725, 353, 764, "F继续", "c4a982", 0.9, out Fx, out Fy);
                        if (Fx > 0)
                        {
                            dm.LeftClick();
                            dm.delay(1000);
                        }
                        else
                        {
                            break;
                        }
                    }

                }
                //14级崂山道人对话
                int 弟子明白x = 0, 弟子明白y = 0;
                var 弟子明白 = dm.FindStrFast(600, 557, 711, 615, "弟子明白", "fff0b3", 0.9, out 弟子明白x, out 弟子明白y);
                if (弟子明白x > 0)
                {
                    dm.Delays(400, 500);
                    dm.MoveTo(弟子明白x + gameOperation.RandomNum(3, 45), 弟子明白y + gameOperation.RandomNum(3, 10));
                    dm.Delays(400, 500);
                    dm.LeftClick();
                    dm.Delays(1000, 1200);
                }
                int 弟子愿意x = 0, 弟子愿意y = 0;
                dm.FindStrFast(618, 559, 699, 610, "弟子愿意", "fff0b3", 0.9, out 弟子愿意x, out 弟子愿意y);
                if (弟子愿意x > 0)
                {
                    dm.Delays(400, 500);
                    dm.MoveTo(弟子愿意x + gameOperation.RandomNum(3, 45), 弟子愿意y + gameOperation.RandomNum(3, 10));
                    dm.Delays(400, 500);
                    dm.LeftClick();
                    dm.Delays(1000, 1200);
                }
                int 弟子决心已定x = 0, 弟子决心已定y = 0;
                dm.FindStrFast(617, 559, 731, 613, "弟子决心已定", "fff0b3", 0.9, out 弟子决心已定x, out 弟子决心已定y);
                if (弟子决心已定x > 0)
                {
                    dm.Delays(400, 500);
                    dm.MoveTo(弟子决心已定x + gameOperation.RandomNum(3, 45), 弟子决心已定y + gameOperation.RandomNum(3, 10));
                    dm.Delays(400, 500);
                    dm.LeftClick();
                    dm.Delays(1000, 1200);
                }
                //五十五斤
                int 五十斤x = 0, 五十斤y = 0;
                var 五十斤 = dm.FindStrFast(603, 497, 715, 612, "五十斤", "fff0b3", 0.9, out 五十斤x, out 五十斤y);
                if (五十斤x > 0)
                {
                    dm.Delays(400, 500);
                    dm.MoveTo(五十斤x + gameOperation.RandomNum(5, 35), 五十斤y);
                    dm.Delays(400, 500);
                    dm.LeftClick();
                    dm.Delays(1000, 2000);
                    //F继续和绿色下划线判断冲突，先执行玩F继续后再判断绿色下划线
                    while (true)
                    {
                        int Fx = 0, Fy = 0;
                        dm.FindStrFast(300, 725, 353, 764, "F继续", "c4a982", 0.9, out Fx, out Fy);
                        if (Fx > 0)
                        {
                            dm.LeftClick();
                            dm.delay(1000);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                //捡银票
                int 银票x = 0, 银票y = 0;
                var 银票 = dm.FindStrFast(0, 0, 1000, 700, "银票 ", "ffffff", 0.9, out 银票x, out 银票y);
                if (银票x > 0)
                {
                    while (true)
                    {
                        int 银票2x = 0, 银票2y = 0;
                        var 银票2 = dm.FindStrFast(0, 0, 1000, 700, "银票 ", "ffffff-463847", 0.9, out 银票2x, out 银票2y);
                        if (银票2x > 0)
                        {
                            dm.MoveTo(银票2x + gameOperation.RandomNum(0, 5), 银票2y + gameOperation.RandomNum(0, 5));
                            dm.Delays(400, 500);
                            dm.LeftClick();
                            dm.Delays(400, 500);
                        }
                        else
                        {
                            break;
                        }
                    }

                }
            }
            return true;
        }
    }
    
}
