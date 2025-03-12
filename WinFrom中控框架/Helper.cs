using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using static senke.Form1;

namespace senke
{
    public static class Helper
    {
        
        /// <summary>
        /// 写txt文件
        /// </summary>
        public static void WriteToPerfile(string val, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Truncate, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(val);
                }
            }
        }
        /// <summary>
        /// 读取txt配置文件
        /// </summary>
        /// <param name="val"></param>
        /// <param name="path"></param>
        public static string ReadPerfile(string path)
        {
            string result = string.Empty;
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    result = sr.ReadToEnd();

                }
            }
            return result;
        }

        /// <summary>
        /// 产生随机数
        /// </summary>
        public static int RandomNum(int x, int y)
        {
            Random r = new Random();
            return r.Next(x, y);
        }
        /// <summary>
        /// 保存config appsetting
        /// </summary>
        /// <param name="settingvalue"></param>
        /// <param name="keyname"></param>
        /// <returns></returns>
        public static bool SaveAppSettings(string settingvalue, string keyname)
        {
            bool result = false;
            try
            {
                //写入配置文件
                string file = System.Windows.Forms.Application.ExecutablePath;
                Configuration config = ConfigurationManager.OpenExeConfiguration(file);

                bool exist = false;//记录这个com端口值是否存在
                if (config.AppSettings.Settings[keyname] != null)
                {
                    exist = true;
                }
                if (exist)
                {
                    config.AppSettings.Settings.Remove(keyname);
                }
                config.AppSettings.Settings.Add(keyname, settingvalue);
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                result = true;
            }
            catch (Exception)
            {

            }
            return result;
        }
        /// <summary>
        /// 获取当前时间戳
        /// </summary>
        /// <returns></returns>
        public static string GetTimeSpan() {

            DateTime time = DateTime.Now;
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));//当地时区
            TimeSpan ts = time - startTime;
            var timestamp = Convert.ToInt64(ts.TotalSeconds).ToString();
            return timestamp;
        }

        /// <summary>
        /// 处理pid
        /// </summary>
        /// <param name="buff"></param>
        /// <param name="pid"></param>
        public static void getULong(ref byte[] buff, uint pid)
        {

            char[] tmp = pid.ToString().ToCharArray();
            if (tmp.Length > buff.Length)
                return;
            for (int i = 0; i < tmp.Length; i++)
            {
                buff[i] = (byte)tmp[i];
            }

        }


        //获取配置文件节点内容
        public static string GetPerfileNodeValue(string nodename) 
        {
            string returnValue=string.Empty;
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load("configfile.xml");
            //获取portConfigure配置节点
            XmlNode paraConfigure = xmldoc.SelectSingleNode(nodename);
            if (paraConfigure != null)
            {
                returnValue = paraConfigure.InnerText;

            }
            return returnValue;
        }
    }
}
