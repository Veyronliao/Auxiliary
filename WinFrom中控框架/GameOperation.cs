using senke.DmSoft;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml;

namespace senke
{
    /// <summary>
    /// 游戏操作
    /// </summary>
    public class GameOperation
    {
        private dmsoft dm;
        private UserItem user;
        /// <summary>
        /// 标志是否继续
        /// </summary>
        private bool _isContinue = true;
        public bool IsContinue
        {
            get
            {
                return _isContinue;
            }
            set
            {
                _isContinue = value;
            }
        }
        public GameOperation(dmsoft dm, UserItem user = null)
        {
            this.dm = dm;
            this.user = user;
        }
        /// <summary>
        /// 加血加蓝
        /// </summary>
        /// <param name="dm"></param>
        public void JiaXueJiaLan()
        {
            //判断角色血量
            int 血量减少x = 0, 血量减少y = 0;
            var 血量减少 = dm.FindColor(74, 37, 187, 46, "edb206", 0.95, 5, out 血量减少x, out 血量减少y);
            //计算血量百分比
            var 血量百分比 = (((double)血量减少x - 74) / (187 - 74)) * 100;
            var 加血值 = int.Parse(ScriptData.keySetting.XueLiangBiLi);
            if (血量减少x > 0 & 血量百分比 < 加血值)
            {
                dm.KeyPressChar(ScriptData.keySetting.JiaXue1);
                dm.Delays(50, 100);
                dm.KeyPressChar(ScriptData.keySetting.JiaXue2);
                dm.Delays(50, 100);
            }
            //判断角色蓝量
            int 蓝量减少x = 0, 蓝量减少y = 0;
            var 蓝量减少 = dm.FindColor(74, 47, 187, 56, "edb206", 0.95, 5, out 蓝量减少x, out 蓝量减少y);
            //计算血量百分比
            var 蓝量百分比 = (((double)蓝量减少x - 74) / (187 - 74)) * 100;
            var 加蓝值 = int.Parse(ScriptData.keySetting.LanLiangBiLi);
            if (蓝量减少x > 0 & 蓝量百分比 < 加蓝值)
            {
                dm.KeyPressChar(ScriptData.keySetting.JiaLan);
                dm.Delays(100, 120);
                dm.KeyPressChar(ScriptData.keySetting.JiaLan);
                dm.Delays(100, 120);
            }
        }
        /// <summary>
        /// 加血
        /// </summary>
        public void JiaXue()
        {
            while (IsContinue)
            {
                //判断角色血量
                int 血量减少x = 0, 血量减少y = 0;
                var 血量减少 = dm.FindColor(74, 37, 187, 46, "edb206", 0.95, 5, out 血量减少x, out 血量减少y);
                //计算血量百分比
                var 血量百分比 = (((double)血量减少x - 74) / (187 - 74)) * 100;
                var 加血值 = int.Parse(ScriptData.keySetting.XueLiangBiLi);
                if (血量减少x > 0 )
                {
                    if (血量百分比 < 加血值)
                    {
                        dm.KeyPressChar(ScriptData.keySetting.JiaXue2);
                        dm.Delays(50, 100);
                    }
                    else
                    {
                        dm.KeyPressChar(ScriptData.keySetting.JiaXue1);
                        dm.Delays(50, 100);
                    }
                }
                Thread.Sleep(1000);
            }
            
        }
        /// <summary>
        /// 无脑加血
        /// </summary>
        public void WuNaoJiaXue()
        {
            while (IsContinue)
            {
                dm.KeyPressChar(ScriptData.keySetting.JiaXue2);
                Thread.Sleep(100);
                dm.KeyPressChar(ScriptData.keySetting.JiaXue1);
                Thread.Sleep(900);
            }
        }
        /// <summary>
        /// 加蓝
        /// </summary>
        public void JiaLan()
        {
            while (IsContinue) 
            {
                //判断角色蓝量
                int 蓝量减少x = 0, 蓝量减少y = 0;
                var 蓝量减少 = dm.FindColor(74, 47, 187, 56, "edb206", 0.95, 5, out 蓝量减少x, out 蓝量减少y);
                //计算血量百分比
                var 蓝量百分比 = (((double)蓝量减少x - 74) / (187 - 74)) * 100;
                var 加蓝值 = int.Parse(ScriptData.keySetting.LanLiangBiLi);
                if (蓝量减少x > 0 & 蓝量百分比 < 加蓝值)
                {
                    dm.KeyPressChar(ScriptData.keySetting.JiaLan);
                    //dm.Delays(100, 120);
                    Thread.Sleep(100);
                    dm.KeyPressChar(ScriptData.keySetting.JiaLan);
                    //dm.Delays(100, 120);
                    Thread.Sleep(100);
                }
            }
            
        }
        /// <summary>
        /// 切怪
        /// </summary>
        /// <param name="dm"></param>
        public void QieGuai()
        {
            dm.KeyDown(17);
            dm.delay(50);
            dm.KeyPress(9);
            dm.delay(50);
            dm.KeyUp(17);
        }
        /// <summary>
        ///点击鼠标跳过对话
        /// </summary>
        /// <param name="dm"></param>
        public void TiaoGuoDuiHua()
        {
            int 继续x = 0, 继续y = 0;
            dm.FindStrFast(300, 725, 353, 764, "F继续", "c4a982", 0.9, out 继续x, out 继续y);
            if (继续x > 0)
            {
                while (true)
                {
                    int 继续退出x = 0, 继续退出y = 0;
                    dm.FindStrFast(830, 280, 982, 334, "下划线1|标准下划线", "00ff00|ffffff|ffbf6c", 0.9, out 继续退出x, out 继续退出y);
                    if (继续退出x > 0)
                    {
                        break;//退出按f键循环
                    }
                    dm.LeftClick();
                    dm.Delays(1000, 1200);
                }
            }

        }
        /// <summary>
        /// 战斗
        /// </summary>
        /// <param name="dm"></param>
        public void ZhanDou()
        {
            dm.Delays(400, 600);
            dm.KeyPress(54);
            dm.Delays(400, 600);
            dm.KeyPress(49);
            dm.Delays(400, 600);
            dm.KeyPress(50);
            dm.Delays(400, 600);
            dm.KeyPress(51);
            dm.Delays(400, 600);
          
            //dm.KeyPress(55);
            //dm.Delays(800, 1000);
        }

        /// <summary>
        /// 寻路
        /// </summary>
        /// <param name="dm"></param>
        public void XunLu(int x, int y)
        {
            dm.KeyPress(9);
            dm.Delays(1000, 1500);
            int 寻路x = 0, 寻路y = 0;
            dm.FindStrFast(300, 138, 340, 154, "寻路", "ffffff", 0.9, out 寻路x, out 寻路y);
            if (寻路x > 0)
            {
                dm.MoveTo(寻路x - RandomNum(55, 78), 寻路y);
                dm.Delays(1000, 1200);
                dm.LeftDoubleClick();
                dm.KeyPressStr(x.ToString(), 50);
                dm.Delays(1000, 1200);
                dm.MoveTo(寻路x - RandomNum(18, 40), 寻路y);
                dm.Delays(1000, 1200);
                dm.LeftDoubleClick();
                dm.KeyPressStr(y.ToString(), 50);
                dm.Delays(1000, 1200);
                dm.MoveTo(寻路x + RandomNum(0, 15), 寻路y);
                dm.Delays(1000, 1200);
                dm.LeftClick();
                dm.Delays(1000, 1200);
            }
            //dm.KeyPress(9);
        }
        /// <summary>
        /// 产生随机数
        /// </summary>
        public int RandomNum(int x, int y)
        {
            Random r = new Random();
            return r.Next(x, y);
        }
        /// <summary>
        /// 召唤灵兽
        /// </summary>
        public void ZhaoHuanLingShou() 
        {
            int 灵兽x = 0, 灵兽y = 0;
            var 灵兽 = dm.FindColor(40, 110, 62, 120, "101439", 0.95, 5, out 灵兽x, out 灵兽y);
            if (灵兽x <= 0)
            {
                dm.KeyPressChar(ScriptData.keySetting.ZhaoHuanLingShou);
            }
        }
        /// <summary>
        /// 角色升级
        /// </summary>
        public void UpDataRole() 
        {
            dm.KeyPress(87);
            dm.Delays(800,1000);
            int 升级x = 0, 升级y = 0;
            dm.FindStrFast(759, 597, 836, 616, "升级", "ffffff", 0.9, out 升级x, out 升级y);
            if (升级x>0)
            {
                dm.MoveTo(升级x +RandomNum(0, 40), 升级y+ RandomNum(0, 15));
                dm.Delays(800, 1000);
                dm.LeftClick();
                dm.Delays(800, 1000);
                dm.KeyPress(27);
                dm.Delays(800, 1000);
            }
        }
        /// <summary>
        /// 查找npc
        /// </summary>
        public void FindNpc(string npcName) 
        {
            dm.KeyPress(9);//打开地图
            dm.Delays(1000, 1200);
            dm.MoveTo(RandomNum(364, 445),RandomNum(140, 145));
            dm.Delays(1000, 1200);
            dm.LeftDoubleClick();
            dm.Delays(1000, 1500);
            dm.SendString(this.user.hwnd, npcName);
            dm.Delays(1000, 1200);
            dm.KeyPress(13);
            dm.Delays(1000, 1200);
        }
        /// <summary>
        /// 获取配置文件节点内容
        /// </summary>
        /// <param name="nodename"></param>
        /// <returns></returns>
        public string GetPerfileNodeValue(string nodename)
        {
            string returnValue = string.Empty;
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load("configfile.xml");
            XmlNode serverDataConfigure = xmldoc.SelectSingleNode("Configure");
            //获取portConfigure配置节点
            XmlNode paraConfigure = serverDataConfigure.SelectSingleNode(nodename);
            if (paraConfigure != null)
            {
                returnValue = paraConfigure.InnerText;
            }
            return returnValue;
        }
        //关闭打开的窗口
        public void CloseDialog() 
        {
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
        }
    }
}
