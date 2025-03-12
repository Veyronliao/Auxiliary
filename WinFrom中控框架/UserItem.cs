using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace senke
{
    public class UserItem
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int Index { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        public string nickname { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string account { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string passWard { get; set; }
        public int rows { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public bool state { get; set; }
        public Thread thread { get; set; }
        /// <summary>
        /// 是否队长
        /// </summary>
        public bool isCaptain { get; set; }
        /// <summary>
        /// 窗口句柄
        /// </summary>
        public int hwnd { get; set; }
        //平台
        public string Platform { get; set; }
        /// <summary>
        /// 大区
        /// </summary>
        public string AreaName { get; set; }
        /// <summary>
        /// 游戏服务器
        /// </summary>
        public string ServerName { get; set; }
        /// <summary>
        /// 任务标志
        /// </summary>
        public int taskArrPos { get; set; }
        /// <summary>
        /// 队友
        /// </summary>
        public List<string> FriendsList { get; set; }
        /// 角色1、2、3、4
        /// </summary>
        public int Role { get; set; }
        /// <summary>
        /// 任务
        /// </summary>
        public List<string> Tasks { get; set; }
        /// <summary>
        /// 门派
        /// </summary>
        public string Sect { get; set; }
        /// <summary>
        /// 模拟器
        /// </summary>
        public string Emulator { get; set; }
        /// <summary>
        /// 自动登录
        /// </summary>
        public bool AutoLogin { get; set; }
        /// <summary>
        /// 自动切换角色
        /// </summary>
        public bool AutoSwitch { get; set; }
        
        /// <summary>
        /// 图色识别延迟时间
        /// </summary>
        public int Delays { get; set; }
        /// <summary>
        /// 主线任务
        /// </summary>
        public bool MainLine { get; set; }
        /// <summary>
        /// 主线任务限制时间
        /// </summary>
        public int MainLineLimitTime { get; set; }
        /// <summary>
        /// 添加好友
        /// </summary>
        public bool AddFriend { get; set; }
        /// <summary>
        /// 组队
        /// </summary>
        public bool TeamUp { get; set; }
        /// <summary>
        /// 宗师殿堂
        /// </summary>
        public bool ZongShiDianTang { get; set; }
        /// <summary>
        /// 门派任务
        /// </summary>
        public bool MenPaiRenWu { get; set; }
        /// <summary>
        /// 问剑侠义
        /// </summary>
        public bool WenJianXiaYi { get; set; }
        /// <summary>
        /// 纳贡祈祥
        /// </summary>
        public bool NaGongQiXiang { get; set; }
        /// <summary>
        /// 帮会任务
        /// </summary>
        public bool BangHuiRenWu { get; set; }
        /// <summary>
        ///帮会演武 
        /// </summary>
        public bool BangHuiYanWu { get; set; }
        /// <summary>
        /// 生活采集
        /// </summary>
        public bool ShengHuoCaiJi { get; set; }
        /// <summary>
        /// 生活采集选项
        /// </summary>
        public string ShengHuoCaiJiXuanXiang { get; set; }
        /// <summary>
        /// 生活采集选项级数
        /// </summary>
        public string ShengHuoCaiJiXuanXiangJiShu { get; set; }
        /// <summary>
        /// 生活制造
        /// </summary>
        public bool ShengHuoZhiZao { get; set; }
        /// <summary>
        /// 生活制造选项
        /// </summary>
        public string ShengHuoZhiZaoXuanXiang { get; set; }
        /// <summary>
        /// 生活采集选项级数
        /// </summary>
        public string ShengHuoZhiZaoXuanXiangJiShu { get; set; }
        /// <summary>
        /// 江湖饭馆
        /// </summary>
        public bool JiangHuFanGuan { get; set; }
        /// <summary>
        /// 燕子坞
        /// </summary>
        public bool YanZiWu { get; set; }
        /// <summary>
        /// 勇闯山寨
        /// </summary>
        public bool YongChuangShanZhai { get; set; }
        /// <summary>
        /// 珍珑棋局
        /// </summary>
        public bool ZhenLongQiJu { get; set; }
        /// <summary>
        /// 西夏王陵
        /// </summary>
        public bool XiXiaWangLing { get; set; }
        /// <summary>
        /// 西夏王陵层数
        /// </summary>
        public string XiXiaWangLingCengShu { get; set; }
        /// <summary>
        /// 西夏王陵任务执行时间
        /// </summary>
        public string XiXiaWangLingXianZhiShiJian { get; set; }
        /// <summary>
        /// 江湖缉凶
        /// </summary>
        public bool JiangHuJiXiong { get; set; }
        /// <summary>
        /// 寒玉练功
        /// </summary>
        public bool HanYuLianGong { get; set; }
        /// <summary>
        /// 神都论战
        /// </summary>
        public bool ShenDuLunJian { get; set; }
        /// <summary>
        /// 帮会运镖
        /// </summary>
        public bool BangHuiYunBiao { get; set; }
        /// <summary>
        /// 边关问战
        /// </summary>
        public bool BianGuanWenZhan { get; set; }
        /// <summary>
        /// 四大恶人
        /// </summary>
        public bool SiDaeRen { get; set; }
        /// <summary>
        /// 宵小
        /// </summary>
        public bool XiaoXiao { get; set; }
        /// <summary>
        /// 高倍棋局
        /// </summary>
        public bool GaoBeiQiJu { get; set; }
        /// <summary>
        /// 宝石盛宴
        /// </summary>
        public bool BaoShiShengYan { get; set; }
        /// <summary>
        /// 成就奖励
        /// </summary>
        public bool ChengJiuJiangLi { get; set; }
        /// <summary>
        /// 绝学参悟
        /// </summary>
        public bool JueXueCanWu { get; set; }
        /// <summary>
        /// 收删邮件
        /// </summary>
        public bool ShouShanYouJian { get; set; }
        /// <summary>
        /// 活跃奖励
        /// </summary>
        public bool HuoYueJiangLi { get; set; }
        /// <summary>
        /// 记事奖励
        /// </summary>
        public bool JiShiJiangLi { get; set; }
        /// <summary>
        /// 鸿富宝箱
        /// </summary>
        public bool HongFuBaoXiang { get; set; }
        /// <summary>
        /// 预约奖励
        /// </summary>
        public bool YuYueJiangLi { get; set; }
        /// <summary>
        /// 活动找回
        /// </summary>
        public bool HuoDongZhaoHui { get; set; }
        /// <summary>
        /// 福利奖励
        /// </summary>
        public bool FuLiJiangLi { get; set; }
        /// <summary>
        /// 分解装备
        /// </summary>
        public bool FenJieZhuangBei { get; set; }
        /// <summary>
        /// 穿戴装备
        /// </summary>
        public bool ChuanDaiZhuangBei { get; set; }
        /// <summary>
        /// 强化装备
        /// </summary>
        public bool QiangHuaZhuangBei { get; set; }
        /// <summary>
        /// 刻铭装备
        /// </summary>
        public bool KeMingZhuangBei { get; set; }
        /// <summary>
        /// 刻铭装备级数
        /// </summary>
        public string KeMingZhuangBeiJiShu { get; set; }
        /// <summary>
        /// 精通装备
        /// </summary>
        public bool JingTongZhuangBei { get; set; }
        /// <summary>
        /// 镶嵌装备
        /// </summary>
        public bool XiangQianZhuangBei { get; set; }
        /// <summary>
        /// 武学锻体
        /// </summary>
        public bool WuXueDuanTi { get; set; }
        /// <summary>
        /// 属性加点
        /// </summary>
        public bool ShuXingJiaDian { get; set; }
        /// <summary>
        /// 突破心境
        /// </summary>
        public bool TuPoXinJing { get; set; }
        /// <summary>
        /// 升级技能
        /// </summary>
        public bool ShengJiJiNeng { get; set; }
        /// <summary>
        /// 清理背包
        /// </summary>
        public bool QingLiBeiBao { get; set; }
        /// <summary>
        /// 宠物加点
        /// </summary>
        public bool ChongWuJiaDian { get; set; }
        /// <summary>
        /// 宠物出战
        /// </summary>
        public bool ChongWuChuZhan { get; set; }
        /// <summary>
        /// 添加药品
        /// </summary>
        public bool TianJiaYaoPin { get; set; }
        /// <summary>
        /// 背包解锁
        /// </summary>
        public bool BeiBaoJieSuo { get; set; }

    }

}
