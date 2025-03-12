using senke.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace senke.DmSoft
{
    public static class ScriptData
    {
        /// <summary>
        /// 任务
        /// </summary>
        public static List<string> TaskList { get; set; }
        /// <summary>
        /// 按键设置
        /// </summary>
        public static KeySetting keySetting { get; set; }
        /// <summary>
        /// 服务大区对应坐标值
        /// </summary>
        public static List<Coordinate> AreaCoordinate { get; set; }
        public static List<Coordinate> DouYinAreaCoordinate { get; set; }
        /// <summary>
        /// 服务区对应坐标值
        /// </summary>
        public static List<Coordinate> ServerCoordinate { get; set; }
        public static List<Coordinate> DouYinServerCoordinate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 
        public static bool 退出组队任务 { get; set; }
        public static bool 组队完成 { get; set; }
        public static bool 退出江湖饭馆{get; set;}
        public static bool 退出燕子坞 { get; set; }
        public static bool 退出勇创山寨 { get; set; }
        public static bool 退出珍珑棋局 { get; set; }
        public static bool 退出宵小 { get; set; }
    }
    public class Coordinate 
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string CoordinateName { get; set; }
        /// <summary>
        /// 坐标值
        /// </summary>
        public string CoordinateValue { get; set; }
    }
}
