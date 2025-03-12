using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace senke
{
    public static class Logger
    {
        public static System.Windows.Forms.ListView _listView=null;
        public static void InitListView(ListView listView)
        {
            _listView = listView;
            
            ColumnHeader columnHeader1 = new ColumnHeader() { Name = "dateTime", Text = "日志时间", Width = 200 };
            ColumnHeader columnHeader2 = new ColumnHeader() { Name = "infoString", Text = "日志信息", Width = 2200 };
            listView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });

            listView.HeaderStyle = ColumnHeaderStyle.None;
            listView.View = View.Details;
            listView.HideSelection = false;
        }

        public static void Addlog(string info)
        {
            Addlog(info, 20);
        }

        public static void Addlog(string info, int maxDisplayItems)
        {
            if (_listView==null)
            {
                ListViewItem lstItem = new ListViewItem("初始化日志控件出错！ " + DateTime.Now.ToString());
                lstItem.SubItems.Add(info);
                _listView.Items.Insert(0, lstItem);
                return;
            }
            if (_listView.InvokeRequired)
            {
                _listView.Invoke(new Action(() =>
                {
                    if (_listView.Items.Count > maxDisplayItems)
                    {
                        _listView.Items.RemoveAt(maxDisplayItems);
                    }

                    ListViewItem lstItem = new ListViewItem(" " + DateTime.Now.ToString());
                    lstItem.SubItems.Add(info);
                    _listView.Items.Insert(0, lstItem);
                }));
            }
            else
            {
                if (_listView.Items.Count > maxDisplayItems)
                {
                    _listView.Items.RemoveAt(maxDisplayItems);
                }

                ListViewItem lstItem = new ListViewItem(" " + DateTime.Now.ToString());
                lstItem.SubItems.Add(info);
                _listView.Items.Insert(0, lstItem);
            }
        }
    }
}
