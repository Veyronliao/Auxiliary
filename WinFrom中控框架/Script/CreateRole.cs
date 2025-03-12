using senke.DmSoft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace senke
{
    /// <summary>
    /// 创建角色
    /// </summary>
    public class CreateRole
    {
        public GameOperation gameOperation { get; set; }
        public UserItem user { get; set; }
        public dmsoft dm { get; set; }
        public CreateRole(dmsoft dm, UserItem user)
        {
            gameOperation = new GameOperation(dm);
            this.user = user;
            this.dm = dm;
        }

        public void DoWork()
        {
            dm.UseDict(3);
            dm.delay(1000);
            //打开游戏app
            while (true)
            {
                int 飞龙战天x = 0, 飞龙战天y = 0;
                dm.FindStrFast(555, 223, 617, 249, "飞龙战天", "F7F8F9-080706", 0.9, out 飞龙战天x, out 飞龙战天y);
                if (飞龙战天x > 0)
                {
                    dm.MoveTo(飞龙战天x, 飞龙战天y - Helper.RandomNum(15, 60));
                    dm.delay(1000);
                    dm.LeftClick();
                    break;
                }
                dm.delay(1000);
            }
            dm.delay(1000);
            dm.KeyPress(27);
            dm.delay(1000);
            dm.KeyPress(27);
            while (true)
            {
                dm.KeyPress(27);
                dm.delay(1000);
                //再玩会
                int 再玩会_x = 0, 再玩会_y = 0;
                dm.FindStrFast(716, 538, 787, 571, "再玩会", "39300C-39310C", 0.9, out 再玩会_x, out 再玩会_y);
                if (再玩会_x > 0)
                {
                    dm.MoveToEx(再玩会_x, 再玩会_y, 50, 20);
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //int 密码登录x = 0, 密码登录y = 0;
                //dm.FindStrFast(440, 172, 531, 203, "密码登录", "464646-474747", 0.9, out 密码登录x, out 密码登录y);
                dm.UseDict(4);
                //登录界面
                int 注册新用户x = 0, 注册新用户y = 0;
                dm.FindStrFast(463, 476, 547, 502, "注册新用户", "7CB8FF-331C00", 0.9, out 注册新用户x, out 注册新用户y);
                if (注册新用户x > 0)
                {
                    dm.MoveToEx(注册新用户x, 注册新用户y, 50, 10);
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);

                }
                int 新用户注册x = 0, 新用户注册y = 0;
                dm.FindStrFast(567, 162, 724, 208, "新用户注册", "9E9E9E-393939", 0.9, out 新用户注册x, out 新用户注册y);
                if (新用户注册x > 0)
                {
                    while (true)
                    {
                        dm.MoveTo(gameOperation.RandomNum(460, 490), gameOperation.RandomNum(230, 260));
                        dm.delay(1000);
                        dm.LeftDoubleClick();
                        //dm.delay(1000);
                        //dm.KeyDown(17);
                        //dm.delay(100);
                        //dm.KeyPress(65);
                        //dm.KeyUp(17);
                        dm.delay(1000);
                        dm.SendString(user.hwnd, user.account);
                        dm.delay(1200);
                        dm.MoveTo(gameOperation.RandomNum(470, 690), gameOperation.RandomNum(300, 325));
                        dm.delay(1000);
                        dm.LeftClick();
                        dm.delay(1000);
                        dm.KeyDown(17);
                        dm.delay(100);
                        dm.KeyPress(65);
                        dm.KeyUp(17);
                        dm.delay(1000);
                        dm.KeyPressStr(user.passWard, 50);
                        dm.delay(1200);
                        dm.MoveTo(gameOperation.RandomNum(470, 690), gameOperation.RandomNum(367, 393));
                        dm.delay(1000);
                        dm.LeftClick();
                        dm.delay(800);
                        dm.SendString(user.hwnd, user.passWard);
                        dm.delay(1200);
                        int 已阅读并同意x = 0, 已阅读并同意y = 0;
                        dm.FindStrFast(486, 433, 555, 459, "已阅读并同意", "A1A1A1-383838", 0.9, out 已阅读并同意x, out 已阅读并同意y);
                        if (已阅读并同意x > 0)
                        {
                            dm.MoveToEx(已阅读并同意x, 已阅读并同意y, 50, 10);
                            dm.delay(1000);
                            dm.LeftClick();
                            dm.delay(1000);
                        }
                        int 注册x = 0, 注册y = 0;
                        dm.FindStrFast(605, 480, 687, 517, "注册", "69550C-6A550C", 0.9, out 注册x, out 注册y);
                        if (注册x > 0)
                        {
                            dm.MoveToEx(注册x, 注册y, 100, 30);
                            dm.delay(1000);
                            dm.LeftClick();
                            dm.delay(1000);
                            break;
                        }
                    }
                }
                //输入手机号码界面，直接关闭
                int 关闭x = 0, 关闭y = 0;
                dm.FindStrFast(837, 152, 856, 170, "关闭x", "C3C3C3-2B2B2B", 0.9, out 关闭x, out 关闭y);
                if (关闭x > 0)
                {
                    dm.MoveToEx(关闭x, 关闭y, 10, 10);
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                //实名认证界面
                int 实名认证x = 0, 实名认证y = 0;
                dm.FindStrFast(563, 161, 725, 210, "实名认证", "767676-767676", 0.9, out 实名认证x, out 实名认证y);
                if (实名认证x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(466, 635), gameOperation.RandomNum(317, 341));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    string name = gameOperation.GetPerfileNodeValue("yanzhengxingming");
                    dm.delay(1000);
                    dm.SendString(user.hwnd, name);
                    dm.delay(1200);
                    //身份证
                    dm.MoveTo(gameOperation.RandomNum(466, 635), gameOperation.RandomNum(383, 409));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    string id = gameOperation.GetPerfileNodeValue("shenfenzhenghao");
                    dm.KeyPressStr(id, 50);
                    dm.delay(1000);
                    int 验证x = 0, 验证y = 0;
                    dm.FindStrFast(607, 468, 671, 499, "验证", "63500B-64510C", 0.9, out 验证x, out 验证y);
                    if (验证x > 0)
                    {
                        dm.MoveToEx(验证x, 验证y, 100, 20);
                        dm.delay(1000);
                        dm.LeftClick();
                        dm.delay(1000);
                        dm.KeyPress(27);
                        dm.delay(1000);
                        dm.KeyPress(27);
                        dm.delay(1000);
                    }
                }
                //公告
                dm.UseDict(3);
                dm.delay(1000);
                int 郑重提醒x = 0, 郑重提醒y = 0;
                dm.FindStrFast(247, 243, 337, 269, "郑重提醒", "9E928C-393E3B", 0.9, out 郑重提醒x, out 郑重提醒y);
                if (郑重提醒x > 0)
                {
                    dm.MoveTo(gameOperation.RandomNum(1107, 1128), gameOperation.RandomNum(87, 109));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                int 闯荡江湖x = 0, 闯荡江湖y = 0;
                dm.FindStrFast(804, 452, 962, 493, "闯荡江湖", "AB9D8D-545550", 0.9, out 闯荡江湖x, out 闯荡江湖y);
                if (闯荡江湖x > 0)
                {
                    //选择大区服务器
                    dm.MoveTo(gameOperation.RandomNum(775, 970), gameOperation.RandomNum(375, 400));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(2000);
                    string serverArea = gameOperation.GetPerfileNodeValue("Login/SelectServerArea");
                    string server = gameOperation.GetPerfileNodeValue("Login/SelectServer");
                    //先选择大区
                    var areaCoordinate = ScriptData.AreaCoordinate.Find(s=>s.CoordinateName==serverArea);
                    if (areaCoordinate!=null)
                    {
                        var coordinates = areaCoordinate.CoordinateValue.Split(',');
                        dm.MoveTo(gameOperation.RandomNum(int.Parse(coordinates[0]), int.Parse(coordinates[2])),gameOperation.RandomNum(int.Parse(coordinates[1]), int.Parse(coordinates[3])));
                        dm.delay(1000);
                        dm.LeftClick();
                        dm.delay(1000);
                    }
                    //选择服务器
                    var serverCoordinate = ScriptData.ServerCoordinate.Find(s => s.CoordinateName == server);
                    if (serverCoordinate != null)
                    {
                        var coordinates = serverCoordinate.CoordinateValue.Split(',');
                        dm.MoveTo(gameOperation.RandomNum(int.Parse(coordinates[0]), int.Parse(coordinates[2])), gameOperation.RandomNum(int.Parse(coordinates[1]), int.Parse(coordinates[3])));
                        dm.delay(1000);
                        dm.LeftClick();
                        dm.delay(1000);
                    }
                    dm.delay(1000);
                    dm.MoveTo(闯荡江湖x + gameOperation.RandomNum(0, 100), 闯荡江湖y + gameOperation.RandomNum(0, 30));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);

                }

                int 进入游戏x = 0, 进入游戏y = 0;
                dm.FindStrFast(1071, 625, 1232, 671, "进入游戏", "998C7E-484E44", 0.9, out 进入游戏x, out 进入游戏y);
                if (进入游戏x > 0)
                {
                    dm.MoveTo(进入游戏x + gameOperation.RandomNum(0, 100), 进入游戏y + gameOperation.RandomNum(0, 25));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                int 武当x = 0, 武当y = 0;
                dm.FindStrFast(614, 150, 671, 311, "武当", "D9CBBB-1E2531|f6eeed", 0.9, out 武当x, out 武当y);
                if (武当x > 0)
                {
                    break;
                }
                int xx = 0, xy = 0;
                dm.FindStrFast(818, 122, 855, 152, "x", "535353-212121", 0.9, out xx, out xy);
                if (xx > 0)
                {
                    dm.MoveToEx(xx, xy, 10, 10);
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
            }
            //创建角色
            while (true)
            {
                int 跳过剧情x = 0, 跳过剧情y = 0;
                dm.FindStrFast(1100, 25, 1215, 60, "跳过剧情", "eddcc6-122339", 0.9, out 跳过剧情x, out 跳过剧情y);
                if (跳过剧情x>0)
                {
                    break;
                }
                int 武当x = 0, 武当y = 0;
                dm.FindStrFast(740, 529, 770, 581, "武当", "EECFBE-112F3A", 0.9, out 武当x, out 武当y);
                if (武当x > 0)
                {
                    dm.MoveToEx(武当x, 武当y, 10, 10);
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    dm.MoveTo(gameOperation.RandomNum(464, 514), gameOperation.RandomNum(637, 684));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                int 切换门派x = 0, 切换门派y = 0;
                dm.FindStrFast(1122, 5, 1229, 29, "切换门派", "9B8D80-43483F", 0.9, out 切换门派x, out 切换门派y);
                if (切换门派x>0)
                {
                    //if (user.Role == "逍遥")
                    //{
                    //    dm.MoveTo(gameOperation.RandomNum(1115, 1150), gameOperation.RandomNum(80, 115));
                    //}
                    //else if (user.Role == "峨眉")
                    //{
                    //    dm.MoveTo(gameOperation.RandomNum(1200, 1240), gameOperation.RandomNum(80, 115));
                    //}
                    //else if (user.Role == "丐帮")
                    //{
                    //    dm.MoveTo(gameOperation.RandomNum(1115, 1150), gameOperation.RandomNum(180, 215));
                    //}
                    //else if (user.Role == "武当")
                    //{
                    //    dm.MoveTo(gameOperation.RandomNum(1200, 1240), gameOperation.RandomNum(180, 215));
                    //}
                    //else if (user.Role == "天山")
                    //{
                    //    dm.MoveTo(gameOperation.RandomNum(1115, 1150), gameOperation.RandomNum(280, 315));
                    //}
                    //else if (user.Role == "无尘")
                    //{
                    //    dm.MoveTo(gameOperation.RandomNum(1200, 1240), gameOperation.RandomNum(280, 315));
                    //}
                    //else if (user.Role == "明教")
                    //{
                    //    dm.MoveTo(gameOperation.RandomNum(1115, 1150), gameOperation.RandomNum(380, 415));
                    //}
                    //else
                    //{

                    //}
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    //选中男女
                    dm.MoveTo(gameOperation.RandomNum(1205, 1235), gameOperation.RandomNum(570, 600));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    //下一步（选择名字）
                    dm.MoveTo(gameOperation.RandomNum(1105, 1245), gameOperation.RandomNum(645, 685));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                }
                int 下一步x = 0, 下一步y = 0;
                dm.FindStrFast(1039, 643, 1172, 690, "下一步", "8E837F-404846", 0.9, out 下一步x, out 下一步y);
                if (下一步x>0)
                {
                    dm.MoveTo(下一步x+gameOperation.RandomNum(0, 50), 下一步y+gameOperation.RandomNum(0, 25));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    //下一步（选择名字）
                    dm.MoveTo(gameOperation.RandomNum(1025, 1180), gameOperation.RandomNum(645, 685));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    //确定名字后进入剧情
                    dm.MoveTo(gameOperation.RandomNum(666, 820), gameOperation.RandomNum(435, 480));
                    dm.delay(1000);
                    dm.LeftClick();
                    dm.delay(1000);
                    break;
                }
                
            }
        }
    }
}
