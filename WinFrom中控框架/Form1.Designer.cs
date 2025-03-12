
using System.IO;

namespace senke
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.isSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.server = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCaptain = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emulator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer_tips = new System.Windows.Forms.Timer(this.components);
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tab_login = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_qiehuanjuese = new System.Windows.Forms.CheckBox();
            this.check_autologin = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_shenfenzhenghao = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_yanzhengxingming = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.txt_gamepath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tab_basc = new System.Windows.Forms.TabPage();
            this.group_timelimittask = new System.Windows.Forms.GroupBox();
            this.check_baoshishengyan = new System.Windows.Forms.CheckBox();
            this.check_timelimittaskallselect = new System.Windows.Forms.CheckBox();
            this.check_gaobeiqiju = new System.Windows.Forms.CheckBox();
            this.check_sidaeren = new System.Windows.Forms.CheckBox();
            this.checkshendulunjian = new System.Windows.Forms.CheckBox();
            this.check_bianguanwenzhan = new System.Windows.Forms.CheckBox();
            this.check_banghuiyunbiao = new System.Windows.Forms.CheckBox();
            this.check_hanyuliangong = new System.Windows.Forms.CheckBox();
            this.check_jianghujixiong = new System.Windows.Forms.CheckBox();
            this.groupbox_teamworktask = new System.Windows.Forms.GroupBox();
            this.check_regroupteam = new System.Windows.Forms.CheckBox();
            this.check_addfriends = new System.Windows.Forms.CheckBox();
            this.txt_xixiawanglingxianzhishijian = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.check_xiaoxiao = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cob_xixiawanglingcengshu = new System.Windows.Forms.ComboBox();
            this.check_teamtaskallselect = new System.Windows.Forms.CheckBox();
            this.check_zhenlongqiju = new System.Windows.Forms.CheckBox();
            this.check_yongchuangshanzhai = new System.Windows.Forms.CheckBox();
            this.check_xixiawangling = new System.Windows.Forms.CheckBox();
            this.check_yanziwu = new System.Windows.Forms.CheckBox();
            this.check_jianghufanguan = new System.Windows.Forms.CheckBox();
            this.groupBox_singletask = new System.Windows.Forms.GroupBox();
            this.check_banghuiyanwu = new System.Windows.Forms.CheckBox();
            this.check_selectalltask = new System.Windows.Forms.CheckBox();
            this.cob_shenghuozhizaoxuanxiangjishu = new System.Windows.Forms.ComboBox();
            this.cob_shenghuozhizaoxuanxiang = new System.Windows.Forms.ComboBox();
            this.check_shenghuozhizao = new System.Windows.Forms.CheckBox();
            this.cob_shenghuocaijixuanxiangjishu = new System.Windows.Forms.ComboBox();
            this.cob_shenghuocaijixuanxiang = new System.Windows.Forms.ComboBox();
            this.check_shenghuocaiji = new System.Windows.Forms.CheckBox();
            this.label = new System.Windows.Forms.Label();
            this.txt_mainlinelimittime = new System.Windows.Forms.TextBox();
            this.check_wenjianxiayi = new System.Windows.Forms.CheckBox();
            this.check_menpairenwu = new System.Windows.Forms.CheckBox();
            this.check_banghuirenwu = new System.Windows.Forms.CheckBox();
            this.check_nagongqixiang = new System.Windows.Forms.CheckBox();
            this.check_zongshidiantang = new System.Windows.Forms.CheckBox();
            this.check_mainLine = new System.Windows.Forms.CheckBox();
            this.tab_lingqu = new System.Windows.Forms.TabPage();
            this.groupBox_tisheng = new System.Windows.Forms.GroupBox();
            this.cob_kemingjishu = new System.Windows.Forms.ComboBox();
            this.check_fenjiezhuangbei = new System.Windows.Forms.CheckBox();
            this.check_tishengallselect = new System.Windows.Forms.CheckBox();
            this.check_chuandaizhuangbei = new System.Windows.Forms.CheckBox();
            this.check_beibaojiesuo = new System.Windows.Forms.CheckBox();
            this.check_wuxueduanti = new System.Windows.Forms.CheckBox();
            this.check_tianjiayaopin = new System.Windows.Forms.CheckBox();
            this.check_qianghuazhuangbei = new System.Windows.Forms.CheckBox();
            this.check_chongwuchuzhan = new System.Windows.Forms.CheckBox();
            this.check_shuxingjiadian = new System.Windows.Forms.CheckBox();
            this.check_chongwujiadian = new System.Windows.Forms.CheckBox();
            this.check_xiangqianzhuangbei = new System.Windows.Forms.CheckBox();
            this.check_tupoxinjing = new System.Windows.Forms.CheckBox();
            this.check_jingtongzhuangbei = new System.Windows.Forms.CheckBox();
            this.check_shengjijineng = new System.Windows.Forms.CheckBox();
            this.check_kemingzhuangbei = new System.Windows.Forms.CheckBox();
            this.check_qinglibeibao = new System.Windows.Forms.CheckBox();
            this.groupBox_lingqushezhi = new System.Windows.Forms.GroupBox();
            this.check_lingqushezhiallselect = new System.Windows.Forms.CheckBox();
            this.check_hongfubaoxiang = new System.Windows.Forms.CheckBox();
            this.check_chengjiujiangli = new System.Windows.Forms.CheckBox();
            this.check_huodongzhaohui = new System.Windows.Forms.CheckBox();
            this.check_juexuechanwu = new System.Windows.Forms.CheckBox();
            this.check_yuyuejiangli = new System.Windows.Forms.CheckBox();
            this.check_shoushanyoujian = new System.Windows.Forms.CheckBox();
            this.check_fulijiangli = new System.Windows.Forms.CheckBox();
            this.check_jishijiangli = new System.Windows.Forms.CheckBox();
            this.check_huoyuejiangli = new System.Windows.Forms.CheckBox();
            this.check_lingquallselect = new System.Windows.Forms.CheckBox();
            this.button10 = new System.Windows.Forms.Button();
            this.listView_log = new System.Windows.Forms.ListView();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tab_login.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tab_basc.SuspendLayout();
            this.group_timelimittask.SuspendLayout();
            this.groupbox_teamworktask.SuspendLayout();
            this.groupBox_singletask.SuspendLayout();
            this.tab_lingqu.SuspendLayout();
            this.groupBox_tisheng.SuspendLayout();
            this.groupBox_lingqushezhi.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isSelect,
            this.nickname,
            this.account,
            this.password,
            this.area,
            this.server,
            this.sect,
            this.role,
            this.isCaptain,
            this.status,
            this.emulator,
            this.platform});
            this.dataGridView1.Location = new System.Drawing.Point(2, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(943, 363);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // isSelect
            // 
            this.isSelect.HeaderText = "选中";
            this.isSelect.MinimumWidth = 8;
            this.isSelect.Name = "isSelect";
            this.isSelect.ReadOnly = true;
            this.isSelect.Width = 50;
            // 
            // nickname
            // 
            this.nickname.HeaderText = "昵称";
            this.nickname.Name = "nickname";
            this.nickname.ReadOnly = true;
            this.nickname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nickname.Width = 70;
            // 
            // account
            // 
            this.account.HeaderText = "账号";
            this.account.MinimumWidth = 8;
            this.account.Name = "account";
            this.account.ReadOnly = true;
            this.account.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // password
            // 
            this.password.HeaderText = "密码";
            this.password.MinimumWidth = 8;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // area
            // 
            this.area.HeaderText = "大区";
            this.area.Name = "area";
            this.area.ReadOnly = true;
            this.area.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.area.Width = 90;
            // 
            // server
            // 
            this.server.HeaderText = "服务器";
            this.server.Name = "server";
            this.server.ReadOnly = true;
            this.server.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.server.Width = 80;
            // 
            // sect
            // 
            this.sect.HeaderText = "门派";
            this.sect.MinimumWidth = 8;
            this.sect.Name = "sect";
            this.sect.ReadOnly = true;
            this.sect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sect.Width = 50;
            // 
            // role
            // 
            this.role.HeaderText = "角色";
            this.role.Name = "role";
            this.role.ReadOnly = true;
            this.role.Width = 60;
            // 
            // isCaptain
            // 
            this.isCaptain.HeaderText = "队长";
            this.isCaptain.MinimumWidth = 8;
            this.isCaptain.Name = "isCaptain";
            this.isCaptain.ReadOnly = true;
            this.isCaptain.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isCaptain.Width = 50;
            // 
            // status
            // 
            this.status.HeaderText = "线程状态";
            this.status.MinimumWidth = 8;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.status.Width = 80;
            // 
            // emulator
            // 
            this.emulator.HeaderText = "模拟器";
            this.emulator.Name = "emulator";
            this.emulator.ReadOnly = true;
            this.emulator.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.emulator.Width = 80;
            // 
            // platform
            // 
            this.platform.HeaderText = "平台";
            this.platform.Name = "platform";
            this.platform.ReadOnly = true;
            this.platform.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.platform.Width = 70;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Location = new System.Drawing.Point(636, 426);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "启动";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PowderBlue;
            this.button3.Location = new System.Drawing.Point(426, 426);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "继续";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCoral;
            this.button4.Location = new System.Drawing.Point(321, 426);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 30);
            this.button4.TabIndex = 4;
            this.button4.Text = "暂停";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gainsboro;
            this.button5.Location = new System.Drawing.Point(200, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 27);
            this.button5.TabIndex = 5;
            this.button5.Text = "反选";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gainsboro;
            this.button6.Location = new System.Drawing.Point(2, 0);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 27);
            this.button6.TabIndex = 6;
            this.button6.Text = "全不选";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gainsboro;
            this.button7.Location = new System.Drawing.Point(101, 0);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 27);
            this.button7.TabIndex = 7;
            this.button7.Text = "全选";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tab_login);
            this.tabControl2.Controls.Add(this.tab_basc);
            this.tabControl2.Controls.Add(this.tab_lingqu);
            this.tabControl2.Location = new System.Drawing.Point(8, 7);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(942, 386);
            this.tabControl2.TabIndex = 20;
            // 
            // tab_login
            // 
            this.tab_login.Controls.Add(this.groupBox1);
            this.tab_login.Location = new System.Drawing.Point(4, 24);
            this.tab_login.Margin = new System.Windows.Forms.Padding(4);
            this.tab_login.Name = "tab_login";
            this.tab_login.Padding = new System.Windows.Forms.Padding(4);
            this.tab_login.Size = new System.Drawing.Size(934, 358);
            this.tab_login.TabIndex = 0;
            this.tab_login.Text = "登录";
            this.tab_login.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_qiehuanjuese);
            this.groupBox1.Controls.Add(this.check_autologin);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txt_shenfenzhenghao);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txt_yanzhengxingming);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.txt_gamepath);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(223, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(499, 185);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登录设置";
            // 
            // chk_qiehuanjuese
            // 
            this.chk_qiehuanjuese.AutoSize = true;
            this.chk_qiehuanjuese.Location = new System.Drawing.Point(177, 86);
            this.chk_qiehuanjuese.Name = "chk_qiehuanjuese";
            this.chk_qiehuanjuese.Size = new System.Drawing.Size(110, 18);
            this.chk_qiehuanjuese.TabIndex = 30;
            this.chk_qiehuanjuese.Text = "自动切换角色";
            this.chk_qiehuanjuese.UseVisualStyleBackColor = true;
            // 
            // check_autologin
            // 
            this.check_autologin.AutoSize = true;
            this.check_autologin.Location = new System.Drawing.Point(74, 86);
            this.check_autologin.Name = "check_autologin";
            this.check_autologin.Size = new System.Drawing.Size(82, 18);
            this.check_autologin.TabIndex = 29;
            this.check_autologin.Text = "自动登录";
            this.check_autologin.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(412, 88);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 14);
            this.label19.TabIndex = 27;
            this.label19.Text = "显示：F8";
            // 
            // txt_shenfenzhenghao
            // 
            this.txt_shenfenzhenghao.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_shenfenzhenghao.Location = new System.Drawing.Point(74, 146);
            this.txt_shenfenzhenghao.Margin = new System.Windows.Forms.Padding(4);
            this.txt_shenfenzhenghao.Name = "txt_shenfenzhenghao";
            this.txt_shenfenzhenghao.Size = new System.Drawing.Size(409, 23);
            this.txt_shenfenzhenghao.TabIndex = 27;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(328, 88);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 14);
            this.label18.TabIndex = 26;
            this.label18.Text = "隐藏：F7";
            // 
            // txt_yanzhengxingming
            // 
            this.txt_yanzhengxingming.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_yanzhengxingming.Location = new System.Drawing.Point(74, 116);
            this.txt_yanzhengxingming.Margin = new System.Windows.Forms.Padding(4);
            this.txt_yanzhengxingming.Name = "txt_yanzhengxingming";
            this.txt_yanzhengxingming.Size = new System.Drawing.Size(155, 23);
            this.txt_yanzhengxingming.TabIndex = 26;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(8, 149);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(63, 14);
            this.label26.TabIndex = 25;
            this.label26.Text = "身份证号";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(8, 119);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 14);
            this.label25.TabIndex = 24;
            this.label25.Text = "验证姓名";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 59);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 14);
            this.label20.TabIndex = 23;
            this.label20.Text = "选择路径";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Gainsboro;
            this.button11.Location = new System.Drawing.Point(74, 55);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(409, 23);
            this.button11.TabIndex = 22;
            this.button11.Text = "选择游戏路径";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // txt_gamepath
            // 
            this.txt_gamepath.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_gamepath.Location = new System.Drawing.Point(74, 23);
            this.txt_gamepath.Margin = new System.Windows.Forms.Padding(4);
            this.txt_gamepath.Name = "txt_gamepath";
            this.txt_gamepath.Size = new System.Drawing.Size(409, 23);
            this.txt_gamepath.TabIndex = 15;
            this.txt_gamepath.TextChanged += new System.EventHandler(this.txt_gamepath_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 17;
            this.label3.Text = "游戏路径";
            // 
            // tab_basc
            // 
            this.tab_basc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tab_basc.Controls.Add(this.group_timelimittask);
            this.tab_basc.Controls.Add(this.groupbox_teamworktask);
            this.tab_basc.Controls.Add(this.groupBox_singletask);
            this.tab_basc.Location = new System.Drawing.Point(4, 24);
            this.tab_basc.Margin = new System.Windows.Forms.Padding(4);
            this.tab_basc.Name = "tab_basc";
            this.tab_basc.Padding = new System.Windows.Forms.Padding(4);
            this.tab_basc.Size = new System.Drawing.Size(934, 358);
            this.tab_basc.TabIndex = 1;
            this.tab_basc.Text = "任务选项";
            this.tab_basc.UseVisualStyleBackColor = true;
            // 
            // group_timelimittask
            // 
            this.group_timelimittask.Controls.Add(this.check_baoshishengyan);
            this.group_timelimittask.Controls.Add(this.check_timelimittaskallselect);
            this.group_timelimittask.Controls.Add(this.check_gaobeiqiju);
            this.group_timelimittask.Controls.Add(this.check_sidaeren);
            this.group_timelimittask.Controls.Add(this.checkshendulunjian);
            this.group_timelimittask.Controls.Add(this.check_bianguanwenzhan);
            this.group_timelimittask.Controls.Add(this.check_banghuiyunbiao);
            this.group_timelimittask.Controls.Add(this.check_hanyuliangong);
            this.group_timelimittask.Controls.Add(this.check_jianghujixiong);
            this.group_timelimittask.Location = new System.Drawing.Point(3, 252);
            this.group_timelimittask.Name = "group_timelimittask";
            this.group_timelimittask.Size = new System.Drawing.Size(927, 102);
            this.group_timelimittask.TabIndex = 16;
            this.group_timelimittask.TabStop = false;
            this.group_timelimittask.Text = "限时任务";
            // 
            // check_baoshishengyan
            // 
            this.check_baoshishengyan.AutoSize = true;
            this.check_baoshishengyan.Location = new System.Drawing.Point(588, 58);
            this.check_baoshishengyan.Name = "check_baoshishengyan";
            this.check_baoshishengyan.Size = new System.Drawing.Size(82, 18);
            this.check_baoshishengyan.TabIndex = 18;
            this.check_baoshishengyan.Text = "宝石盛宴";
            this.check_baoshishengyan.UseVisualStyleBackColor = true;
            // 
            // check_timelimittaskallselect
            // 
            this.check_timelimittaskallselect.AutoSize = true;
            this.check_timelimittaskallselect.BackColor = System.Drawing.Color.LightGray;
            this.check_timelimittaskallselect.Location = new System.Drawing.Point(870, 9);
            this.check_timelimittaskallselect.Name = "check_timelimittaskallselect";
            this.check_timelimittaskallselect.Size = new System.Drawing.Size(54, 18);
            this.check_timelimittaskallselect.TabIndex = 17;
            this.check_timelimittaskallselect.Text = "全选";
            this.check_timelimittaskallselect.UseVisualStyleBackColor = false;
            this.check_timelimittaskallselect.CheckedChanged += new System.EventHandler(this.check_timelimittaskallselect_CheckedChanged);
            // 
            // check_gaobeiqiju
            // 
            this.check_gaobeiqiju.AutoSize = true;
            this.check_gaobeiqiju.Location = new System.Drawing.Point(257, 58);
            this.check_gaobeiqiju.Name = "check_gaobeiqiju";
            this.check_gaobeiqiju.Size = new System.Drawing.Size(82, 18);
            this.check_gaobeiqiju.TabIndex = 8;
            this.check_gaobeiqiju.Text = "高倍棋局";
            this.check_gaobeiqiju.UseVisualStyleBackColor = true;
            // 
            // check_sidaeren
            // 
            this.check_sidaeren.AutoSize = true;
            this.check_sidaeren.Location = new System.Drawing.Point(408, 58);
            this.check_sidaeren.Name = "check_sidaeren";
            this.check_sidaeren.Size = new System.Drawing.Size(82, 18);
            this.check_sidaeren.TabIndex = 15;
            this.check_sidaeren.Text = "四大恶人";
            this.check_sidaeren.UseVisualStyleBackColor = true;
            // 
            // checkshendulunjian
            // 
            this.checkshendulunjian.AutoSize = true;
            this.checkshendulunjian.Location = new System.Drawing.Point(408, 31);
            this.checkshendulunjian.Name = "checkshendulunjian";
            this.checkshendulunjian.Size = new System.Drawing.Size(82, 18);
            this.checkshendulunjian.TabIndex = 13;
            this.checkshendulunjian.Text = "神都论剑";
            this.checkshendulunjian.UseVisualStyleBackColor = true;
            // 
            // check_bianguanwenzhan
            // 
            this.check_bianguanwenzhan.AutoSize = true;
            this.check_bianguanwenzhan.Location = new System.Drawing.Point(84, 58);
            this.check_bianguanwenzhan.Name = "check_bianguanwenzhan";
            this.check_bianguanwenzhan.Size = new System.Drawing.Size(82, 18);
            this.check_bianguanwenzhan.TabIndex = 12;
            this.check_bianguanwenzhan.Text = "边关问战";
            this.check_bianguanwenzhan.UseVisualStyleBackColor = true;
            // 
            // check_banghuiyunbiao
            // 
            this.check_banghuiyunbiao.AutoSize = true;
            this.check_banghuiyunbiao.Location = new System.Drawing.Point(588, 31);
            this.check_banghuiyunbiao.Name = "check_banghuiyunbiao";
            this.check_banghuiyunbiao.Size = new System.Drawing.Size(82, 18);
            this.check_banghuiyunbiao.TabIndex = 11;
            this.check_banghuiyunbiao.Text = "帮会运镖";
            this.check_banghuiyunbiao.UseVisualStyleBackColor = true;
            // 
            // check_hanyuliangong
            // 
            this.check_hanyuliangong.AutoSize = true;
            this.check_hanyuliangong.Location = new System.Drawing.Point(257, 31);
            this.check_hanyuliangong.Name = "check_hanyuliangong";
            this.check_hanyuliangong.Size = new System.Drawing.Size(82, 18);
            this.check_hanyuliangong.TabIndex = 10;
            this.check_hanyuliangong.Text = "寒玉练功";
            this.check_hanyuliangong.UseVisualStyleBackColor = true;
            // 
            // check_jianghujixiong
            // 
            this.check_jianghujixiong.AutoSize = true;
            this.check_jianghujixiong.Location = new System.Drawing.Point(84, 31);
            this.check_jianghujixiong.Name = "check_jianghujixiong";
            this.check_jianghujixiong.Size = new System.Drawing.Size(82, 18);
            this.check_jianghujixiong.TabIndex = 9;
            this.check_jianghujixiong.Text = "江湖缉凶";
            this.check_jianghujixiong.UseVisualStyleBackColor = true;
            // 
            // groupbox_teamworktask
            // 
            this.groupbox_teamworktask.Controls.Add(this.check_regroupteam);
            this.groupbox_teamworktask.Controls.Add(this.check_addfriends);
            this.groupbox_teamworktask.Controls.Add(this.txt_xixiawanglingxianzhishijian);
            this.groupbox_teamworktask.Controls.Add(this.label5);
            this.groupbox_teamworktask.Controls.Add(this.check_xiaoxiao);
            this.groupbox_teamworktask.Controls.Add(this.label4);
            this.groupbox_teamworktask.Controls.Add(this.cob_xixiawanglingcengshu);
            this.groupbox_teamworktask.Controls.Add(this.check_teamtaskallselect);
            this.groupbox_teamworktask.Controls.Add(this.check_zhenlongqiju);
            this.groupbox_teamworktask.Controls.Add(this.check_yongchuangshanzhai);
            this.groupbox_teamworktask.Controls.Add(this.check_xixiawangling);
            this.groupbox_teamworktask.Controls.Add(this.check_yanziwu);
            this.groupbox_teamworktask.Controls.Add(this.check_jianghufanguan);
            this.groupbox_teamworktask.Location = new System.Drawing.Point(2, 2);
            this.groupbox_teamworktask.Name = "groupbox_teamworktask";
            this.groupbox_teamworktask.Size = new System.Drawing.Size(931, 92);
            this.groupbox_teamworktask.TabIndex = 15;
            this.groupbox_teamworktask.TabStop = false;
            this.groupbox_teamworktask.Text = "组队任务";
            // 
            // check_regroupteam
            // 
            this.check_regroupteam.AutoSize = true;
            this.check_regroupteam.Location = new System.Drawing.Point(409, 56);
            this.check_regroupteam.Name = "check_regroupteam";
            this.check_regroupteam.Size = new System.Drawing.Size(54, 18);
            this.check_regroupteam.TabIndex = 20;
            this.check_regroupteam.Text = "组队";
            this.check_regroupteam.UseVisualStyleBackColor = true;
            // 
            // check_addfriends
            // 
            this.check_addfriends.AutoSize = true;
            this.check_addfriends.Location = new System.Drawing.Point(589, 56);
            this.check_addfriends.Name = "check_addfriends";
            this.check_addfriends.Size = new System.Drawing.Size(264, 18);
            this.check_addfriends.TabIndex = 19;
            this.check_addfriends.Text = "添加好友(第一次做组队任务必须勾上)";
            this.check_addfriends.UseVisualStyleBackColor = true;
            // 
            // txt_xixiawanglingxianzhishijian
            // 
            this.txt_xixiawanglingxianzhishijian.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_xixiawanglingxianzhishijian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_xixiawanglingxianzhishijian.Location = new System.Drawing.Point(769, 20);
            this.txt_xixiawanglingxianzhishijian.Name = "txt_xixiawanglingxianzhishijian";
            this.txt_xixiawanglingxianzhishijian.Size = new System.Drawing.Size(30, 23);
            this.txt_xixiawanglingxianzhishijian.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(735, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 14);
            this.label5.TabIndex = 18;
            this.label5.Text = "限制";
            // 
            // check_xiaoxiao
            // 
            this.check_xiaoxiao.AutoSize = true;
            this.check_xiaoxiao.Location = new System.Drawing.Point(259, 56);
            this.check_xiaoxiao.Name = "check_xiaoxiao";
            this.check_xiaoxiao.Size = new System.Drawing.Size(54, 18);
            this.check_xiaoxiao.TabIndex = 14;
            this.check_xiaoxiao.Text = "宵小";
            this.check_xiaoxiao.UseVisualStyleBackColor = true;
            this.check_xiaoxiao.CheckedChanged += new System.EventHandler(this.check_xiaoxiao_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(805, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 14);
            this.label4.TabIndex = 17;
            this.label4.Text = "分钟";
            // 
            // cob_xixiawanglingcengshu
            // 
            this.cob_xixiawanglingcengshu.AutoCompleteCustomSource.AddRange(new string[] {
            "1层",
            "2层",
            "3层",
            "4层",
            "5层"});
            this.cob_xixiawanglingcengshu.FormattingEnabled = true;
            this.cob_xixiawanglingcengshu.Items.AddRange(new object[] {
            "1层",
            "2层",
            "3层",
            "4层",
            "5层",
            "6层"});
            this.cob_xixiawanglingcengshu.Location = new System.Drawing.Point(674, 21);
            this.cob_xixiawanglingcengshu.Name = "cob_xixiawanglingcengshu";
            this.cob_xixiawanglingcengshu.Size = new System.Drawing.Size(55, 22);
            this.cob_xixiawanglingcengshu.TabIndex = 17;
            // 
            // check_teamtaskallselect
            // 
            this.check_teamtaskallselect.AutoSize = true;
            this.check_teamtaskallselect.BackColor = System.Drawing.Color.LightGray;
            this.check_teamtaskallselect.Location = new System.Drawing.Point(874, 9);
            this.check_teamtaskallselect.Name = "check_teamtaskallselect";
            this.check_teamtaskallselect.Size = new System.Drawing.Size(54, 18);
            this.check_teamtaskallselect.TabIndex = 16;
            this.check_teamtaskallselect.Text = "全选";
            this.check_teamtaskallselect.UseVisualStyleBackColor = false;
            this.check_teamtaskallselect.CheckedChanged += new System.EventHandler(this.check_teamtaskallselect_CheckedChanged);
            // 
            // check_zhenlongqiju
            // 
            this.check_zhenlongqiju.AutoSize = true;
            this.check_zhenlongqiju.Location = new System.Drawing.Point(85, 56);
            this.check_zhenlongqiju.Name = "check_zhenlongqiju";
            this.check_zhenlongqiju.Size = new System.Drawing.Size(82, 18);
            this.check_zhenlongqiju.TabIndex = 7;
            this.check_zhenlongqiju.Text = "珍珑棋局";
            this.check_zhenlongqiju.UseVisualStyleBackColor = true;
            this.check_zhenlongqiju.CheckedChanged += new System.EventHandler(this.check_zhenlongqiju_CheckedChanged);
            // 
            // check_yongchuangshanzhai
            // 
            this.check_yongchuangshanzhai.AutoSize = true;
            this.check_yongchuangshanzhai.Location = new System.Drawing.Point(409, 25);
            this.check_yongchuangshanzhai.Name = "check_yongchuangshanzhai";
            this.check_yongchuangshanzhai.Size = new System.Drawing.Size(82, 18);
            this.check_yongchuangshanzhai.TabIndex = 6;
            this.check_yongchuangshanzhai.Text = "勇闯山寨";
            this.check_yongchuangshanzhai.UseVisualStyleBackColor = true;
            this.check_yongchuangshanzhai.CheckedChanged += new System.EventHandler(this.check_yongchuangshanzhai_CheckedChanged);
            // 
            // check_xixiawangling
            // 
            this.check_xixiawangling.AutoSize = true;
            this.check_xixiawangling.Location = new System.Drawing.Point(589, 25);
            this.check_xixiawangling.Name = "check_xixiawangling";
            this.check_xixiawangling.Size = new System.Drawing.Size(89, 18);
            this.check_xixiawangling.TabIndex = 3;
            this.check_xixiawangling.Text = "西夏王陵:";
            this.check_xixiawangling.UseVisualStyleBackColor = true;
            this.check_xixiawangling.CheckedChanged += new System.EventHandler(this.check_xixiawangling_CheckedChanged);
            // 
            // check_yanziwu
            // 
            this.check_yanziwu.AutoSize = true;
            this.check_yanziwu.Location = new System.Drawing.Point(259, 25);
            this.check_yanziwu.Name = "check_yanziwu";
            this.check_yanziwu.Size = new System.Drawing.Size(68, 18);
            this.check_yanziwu.TabIndex = 2;
            this.check_yanziwu.Text = "燕子坞";
            this.check_yanziwu.UseVisualStyleBackColor = true;
            this.check_yanziwu.CheckedChanged += new System.EventHandler(this.check_yanziwu_CheckedChanged);
            // 
            // check_jianghufanguan
            // 
            this.check_jianghufanguan.AutoSize = true;
            this.check_jianghufanguan.Location = new System.Drawing.Point(85, 25);
            this.check_jianghufanguan.Name = "check_jianghufanguan";
            this.check_jianghufanguan.Size = new System.Drawing.Size(82, 18);
            this.check_jianghufanguan.TabIndex = 0;
            this.check_jianghufanguan.Text = "江湖饭馆";
            this.check_jianghufanguan.UseVisualStyleBackColor = true;
            this.check_jianghufanguan.CheckedChanged += new System.EventHandler(this.check_jianghufanguan_CheckedChanged);
            // 
            // groupBox_singletask
            // 
            this.groupBox_singletask.Controls.Add(this.check_banghuiyanwu);
            this.groupBox_singletask.Controls.Add(this.check_selectalltask);
            this.groupBox_singletask.Controls.Add(this.cob_shenghuozhizaoxuanxiangjishu);
            this.groupBox_singletask.Controls.Add(this.cob_shenghuozhizaoxuanxiang);
            this.groupBox_singletask.Controls.Add(this.check_shenghuozhizao);
            this.groupBox_singletask.Controls.Add(this.cob_shenghuocaijixuanxiangjishu);
            this.groupBox_singletask.Controls.Add(this.cob_shenghuocaijixuanxiang);
            this.groupBox_singletask.Controls.Add(this.check_shenghuocaiji);
            this.groupBox_singletask.Controls.Add(this.label);
            this.groupBox_singletask.Controls.Add(this.txt_mainlinelimittime);
            this.groupBox_singletask.Controls.Add(this.check_wenjianxiayi);
            this.groupBox_singletask.Controls.Add(this.check_menpairenwu);
            this.groupBox_singletask.Controls.Add(this.check_banghuirenwu);
            this.groupBox_singletask.Controls.Add(this.check_nagongqixiang);
            this.groupBox_singletask.Controls.Add(this.check_zongshidiantang);
            this.groupBox_singletask.Controls.Add(this.check_mainLine);
            this.groupBox_singletask.Location = new System.Drawing.Point(2, 100);
            this.groupBox_singletask.Name = "groupBox_singletask";
            this.groupBox_singletask.Size = new System.Drawing.Size(931, 141);
            this.groupBox_singletask.TabIndex = 0;
            this.groupBox_singletask.TabStop = false;
            this.groupBox_singletask.Text = "单人任务";
            // 
            // check_banghuiyanwu
            // 
            this.check_banghuiyanwu.AutoSize = true;
            this.check_banghuiyanwu.Location = new System.Drawing.Point(687, 63);
            this.check_banghuiyanwu.Name = "check_banghuiyanwu";
            this.check_banghuiyanwu.Size = new System.Drawing.Size(82, 18);
            this.check_banghuiyanwu.TabIndex = 16;
            this.check_banghuiyanwu.Text = "帮会演武";
            this.check_banghuiyanwu.UseVisualStyleBackColor = true;
            // 
            // check_selectalltask
            // 
            this.check_selectalltask.AutoSize = true;
            this.check_selectalltask.BackColor = System.Drawing.Color.LightGray;
            this.check_selectalltask.Location = new System.Drawing.Point(872, 11);
            this.check_selectalltask.Name = "check_selectalltask";
            this.check_selectalltask.Size = new System.Drawing.Size(54, 18);
            this.check_selectalltask.TabIndex = 15;
            this.check_selectalltask.Text = "全选";
            this.check_selectalltask.UseVisualStyleBackColor = false;
            this.check_selectalltask.CheckedChanged += new System.EventHandler(this.check_selectalltask_CheckedChanged);
            // 
            // cob_shenghuozhizaoxuanxiangjishu
            // 
            this.cob_shenghuozhizaoxuanxiangjishu.FormattingEnabled = true;
            this.cob_shenghuozhizaoxuanxiangjishu.IntegralHeight = false;
            this.cob_shenghuozhizaoxuanxiangjishu.Items.AddRange(new object[] {
            "1级",
            "2级",
            "3级"});
            this.cob_shenghuozhizaoxuanxiangjishu.Location = new System.Drawing.Point(516, 87);
            this.cob_shenghuozhizaoxuanxiangjishu.Name = "cob_shenghuozhizaoxuanxiangjishu";
            this.cob_shenghuozhizaoxuanxiangjishu.Size = new System.Drawing.Size(50, 22);
            this.cob_shenghuozhizaoxuanxiangjishu.TabIndex = 14;
            // 
            // cob_shenghuozhizaoxuanxiang
            // 
            this.cob_shenghuozhizaoxuanxiang.FormattingEnabled = true;
            this.cob_shenghuozhizaoxuanxiang.IntegralHeight = false;
            this.cob_shenghuozhizaoxuanxiang.Items.AddRange(new object[] {
            "打猎"});
            this.cob_shenghuozhizaoxuanxiang.Location = new System.Drawing.Point(466, 87);
            this.cob_shenghuozhizaoxuanxiang.Name = "cob_shenghuozhizaoxuanxiang";
            this.cob_shenghuozhizaoxuanxiang.Size = new System.Drawing.Size(50, 22);
            this.cob_shenghuozhizaoxuanxiang.TabIndex = 13;
            // 
            // check_shenghuozhizao
            // 
            this.check_shenghuozhizao.AutoSize = true;
            this.check_shenghuozhizao.Location = new System.Drawing.Point(389, 89);
            this.check_shenghuozhizao.Name = "check_shenghuozhizao";
            this.check_shenghuozhizao.Size = new System.Drawing.Size(82, 18);
            this.check_shenghuozhizao.TabIndex = 12;
            this.check_shenghuozhizao.Text = "生活制造";
            this.check_shenghuozhizao.UseVisualStyleBackColor = true;
            // 
            // cob_shenghuocaijixuanxiangjishu
            // 
            this.cob_shenghuocaijixuanxiangjishu.FormattingEnabled = true;
            this.cob_shenghuocaijixuanxiangjishu.IntegralHeight = false;
            this.cob_shenghuocaijixuanxiangjishu.Items.AddRange(new object[] {
            "1级",
            "2级",
            "3级"});
            this.cob_shenghuocaijixuanxiangjishu.Location = new System.Drawing.Point(209, 85);
            this.cob_shenghuocaijixuanxiangjishu.Name = "cob_shenghuocaijixuanxiangjishu";
            this.cob_shenghuocaijixuanxiangjishu.Size = new System.Drawing.Size(50, 22);
            this.cob_shenghuocaijixuanxiangjishu.TabIndex = 11;
            // 
            // cob_shenghuocaijixuanxiang
            // 
            this.cob_shenghuocaijixuanxiang.FormattingEnabled = true;
            this.cob_shenghuocaijixuanxiang.IntegralHeight = false;
            this.cob_shenghuocaijixuanxiang.Items.AddRange(new object[] {
            "采集"});
            this.cob_shenghuocaijixuanxiang.Location = new System.Drawing.Point(159, 85);
            this.cob_shenghuocaijixuanxiang.Name = "cob_shenghuocaijixuanxiang";
            this.cob_shenghuocaijixuanxiang.Size = new System.Drawing.Size(50, 22);
            this.cob_shenghuocaijixuanxiang.TabIndex = 10;
            // 
            // check_shenghuocaiji
            // 
            this.check_shenghuocaiji.AutoSize = true;
            this.check_shenghuocaiji.Location = new System.Drawing.Point(83, 87);
            this.check_shenghuocaiji.Name = "check_shenghuocaiji";
            this.check_shenghuocaiji.Size = new System.Drawing.Size(82, 18);
            this.check_shenghuocaiji.TabIndex = 9;
            this.check_shenghuocaiji.Text = "生活采集";
            this.check_shenghuocaiji.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(222, 39);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(35, 14);
            this.label.TabIndex = 8;
            this.label.Text = "分钟";
            // 
            // txt_mainlinelimittime
            // 
            this.txt_mainlinelimittime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_mainlinelimittime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mainlinelimittime.Location = new System.Drawing.Point(192, 34);
            this.txt_mainlinelimittime.Name = "txt_mainlinelimittime";
            this.txt_mainlinelimittime.Size = new System.Drawing.Size(27, 23);
            this.txt_mainlinelimittime.TabIndex = 7;
            // 
            // check_wenjianxiayi
            // 
            this.check_wenjianxiayi.AutoSize = true;
            this.check_wenjianxiayi.Location = new System.Drawing.Point(84, 63);
            this.check_wenjianxiayi.Name = "check_wenjianxiayi";
            this.check_wenjianxiayi.Size = new System.Drawing.Size(82, 18);
            this.check_wenjianxiayi.TabIndex = 6;
            this.check_wenjianxiayi.Text = "问剑侠义";
            this.check_wenjianxiayi.UseVisualStyleBackColor = true;
            // 
            // check_menpairenwu
            // 
            this.check_menpairenwu.AutoSize = true;
            this.check_menpairenwu.Location = new System.Drawing.Point(687, 39);
            this.check_menpairenwu.Name = "check_menpairenwu";
            this.check_menpairenwu.Size = new System.Drawing.Size(82, 18);
            this.check_menpairenwu.TabIndex = 5;
            this.check_menpairenwu.Text = "门派任务";
            this.check_menpairenwu.UseVisualStyleBackColor = true;
            // 
            // check_banghuirenwu
            // 
            this.check_banghuirenwu.AutoSize = true;
            this.check_banghuirenwu.Location = new System.Drawing.Point(389, 63);
            this.check_banghuirenwu.Name = "check_banghuirenwu";
            this.check_banghuirenwu.Size = new System.Drawing.Size(82, 18);
            this.check_banghuirenwu.TabIndex = 4;
            this.check_banghuirenwu.Text = "帮会任务";
            this.check_banghuirenwu.UseVisualStyleBackColor = true;
            // 
            // check_nagongqixiang
            // 
            this.check_nagongqixiang.AutoSize = true;
            this.check_nagongqixiang.Location = new System.Drawing.Point(687, 92);
            this.check_nagongqixiang.Name = "check_nagongqixiang";
            this.check_nagongqixiang.Size = new System.Drawing.Size(82, 18);
            this.check_nagongqixiang.TabIndex = 3;
            this.check_nagongqixiang.Text = "纳贡祈祥";
            this.check_nagongqixiang.UseVisualStyleBackColor = true;
            // 
            // check_zongshidiantang
            // 
            this.check_zongshidiantang.AutoSize = true;
            this.check_zongshidiantang.Location = new System.Drawing.Point(389, 39);
            this.check_zongshidiantang.Name = "check_zongshidiantang";
            this.check_zongshidiantang.Size = new System.Drawing.Size(82, 18);
            this.check_zongshidiantang.TabIndex = 2;
            this.check_zongshidiantang.Text = "宗师殿堂";
            this.check_zongshidiantang.UseVisualStyleBackColor = true;
            // 
            // check_mainLine
            // 
            this.check_mainLine.AutoSize = true;
            this.check_mainLine.Location = new System.Drawing.Point(84, 39);
            this.check_mainLine.Name = "check_mainLine";
            this.check_mainLine.Size = new System.Drawing.Size(117, 18);
            this.check_mainLine.TabIndex = 0;
            this.check_mainLine.Text = "主线任务-执行";
            this.check_mainLine.UseVisualStyleBackColor = true;
            // 
            // tab_lingqu
            // 
            this.tab_lingqu.Controls.Add(this.groupBox_tisheng);
            this.tab_lingqu.Controls.Add(this.groupBox_lingqushezhi);
            this.tab_lingqu.Controls.Add(this.check_lingquallselect);
            this.tab_lingqu.Location = new System.Drawing.Point(4, 24);
            this.tab_lingqu.Margin = new System.Windows.Forms.Padding(4);
            this.tab_lingqu.Name = "tab_lingqu";
            this.tab_lingqu.Size = new System.Drawing.Size(934, 358);
            this.tab_lingqu.TabIndex = 2;
            this.tab_lingqu.Text = "领取提升";
            this.tab_lingqu.UseVisualStyleBackColor = true;
            // 
            // groupBox_tisheng
            // 
            this.groupBox_tisheng.Controls.Add(this.cob_kemingjishu);
            this.groupBox_tisheng.Controls.Add(this.check_fenjiezhuangbei);
            this.groupBox_tisheng.Controls.Add(this.check_tishengallselect);
            this.groupBox_tisheng.Controls.Add(this.check_chuandaizhuangbei);
            this.groupBox_tisheng.Controls.Add(this.check_beibaojiesuo);
            this.groupBox_tisheng.Controls.Add(this.check_wuxueduanti);
            this.groupBox_tisheng.Controls.Add(this.check_tianjiayaopin);
            this.groupBox_tisheng.Controls.Add(this.check_qianghuazhuangbei);
            this.groupBox_tisheng.Controls.Add(this.check_chongwuchuzhan);
            this.groupBox_tisheng.Controls.Add(this.check_shuxingjiadian);
            this.groupBox_tisheng.Controls.Add(this.check_chongwujiadian);
            this.groupBox_tisheng.Controls.Add(this.check_xiangqianzhuangbei);
            this.groupBox_tisheng.Controls.Add(this.check_tupoxinjing);
            this.groupBox_tisheng.Controls.Add(this.check_jingtongzhuangbei);
            this.groupBox_tisheng.Controls.Add(this.check_shengjijineng);
            this.groupBox_tisheng.Controls.Add(this.check_kemingzhuangbei);
            this.groupBox_tisheng.Controls.Add(this.check_qinglibeibao);
            this.groupBox_tisheng.Location = new System.Drawing.Point(4, 138);
            this.groupBox_tisheng.Name = "groupBox_tisheng";
            this.groupBox_tisheng.Size = new System.Drawing.Size(924, 205);
            this.groupBox_tisheng.TabIndex = 18;
            this.groupBox_tisheng.TabStop = false;
            this.groupBox_tisheng.Text = "提升";
            // 
            // cob_kemingjishu
            // 
            this.cob_kemingjishu.FormattingEnabled = true;
            this.cob_kemingjishu.Items.AddRange(new object[] {
            "1级",
            "2级",
            "3级",
            "4级"});
            this.cob_kemingjishu.Location = new System.Drawing.Point(531, 29);
            this.cob_kemingjishu.Name = "cob_kemingjishu";
            this.cob_kemingjishu.Size = new System.Drawing.Size(50, 22);
            this.cob_kemingjishu.TabIndex = 17;
            // 
            // check_fenjiezhuangbei
            // 
            this.check_fenjiezhuangbei.AutoSize = true;
            this.check_fenjiezhuangbei.Location = new System.Drawing.Point(69, 31);
            this.check_fenjiezhuangbei.Name = "check_fenjiezhuangbei";
            this.check_fenjiezhuangbei.Size = new System.Drawing.Size(82, 18);
            this.check_fenjiezhuangbei.TabIndex = 0;
            this.check_fenjiezhuangbei.Text = "分解装备";
            this.check_fenjiezhuangbei.UseVisualStyleBackColor = true;
            // 
            // check_tishengallselect
            // 
            this.check_tishengallselect.AutoSize = true;
            this.check_tishengallselect.BackColor = System.Drawing.Color.LightGray;
            this.check_tishengallselect.Location = new System.Drawing.Point(870, 10);
            this.check_tishengallselect.Name = "check_tishengallselect";
            this.check_tishengallselect.Size = new System.Drawing.Size(54, 18);
            this.check_tishengallselect.TabIndex = 16;
            this.check_tishengallselect.Text = "全选";
            this.check_tishengallselect.UseVisualStyleBackColor = false;
            // 
            // check_chuandaizhuangbei
            // 
            this.check_chuandaizhuangbei.AutoSize = true;
            this.check_chuandaizhuangbei.Location = new System.Drawing.Point(198, 31);
            this.check_chuandaizhuangbei.Name = "check_chuandaizhuangbei";
            this.check_chuandaizhuangbei.Size = new System.Drawing.Size(82, 18);
            this.check_chuandaizhuangbei.TabIndex = 1;
            this.check_chuandaizhuangbei.Text = "穿戴装备";
            this.check_chuandaizhuangbei.UseVisualStyleBackColor = true;
            // 
            // check_beibaojiesuo
            // 
            this.check_beibaojiesuo.AutoSize = true;
            this.check_beibaojiesuo.Location = new System.Drawing.Point(318, 105);
            this.check_beibaojiesuo.Name = "check_beibaojiesuo";
            this.check_beibaojiesuo.Size = new System.Drawing.Size(82, 18);
            this.check_beibaojiesuo.TabIndex = 15;
            this.check_beibaojiesuo.Text = "背包解锁";
            this.check_beibaojiesuo.UseVisualStyleBackColor = true;
            // 
            // check_wuxueduanti
            // 
            this.check_wuxueduanti.AutoSize = true;
            this.check_wuxueduanti.Location = new System.Drawing.Point(69, 66);
            this.check_wuxueduanti.Name = "check_wuxueduanti";
            this.check_wuxueduanti.Size = new System.Drawing.Size(82, 18);
            this.check_wuxueduanti.TabIndex = 2;
            this.check_wuxueduanti.Text = "武学锻体";
            this.check_wuxueduanti.UseVisualStyleBackColor = true;
            // 
            // check_tianjiayaopin
            // 
            this.check_tianjiayaopin.AutoSize = true;
            this.check_tianjiayaopin.Location = new System.Drawing.Point(198, 105);
            this.check_tianjiayaopin.Name = "check_tianjiayaopin";
            this.check_tianjiayaopin.Size = new System.Drawing.Size(82, 18);
            this.check_tianjiayaopin.TabIndex = 14;
            this.check_tianjiayaopin.Text = "添加药品";
            this.check_tianjiayaopin.UseVisualStyleBackColor = true;
            // 
            // check_qianghuazhuangbei
            // 
            this.check_qianghuazhuangbei.AutoSize = true;
            this.check_qianghuazhuangbei.Location = new System.Drawing.Point(318, 31);
            this.check_qianghuazhuangbei.Name = "check_qianghuazhuangbei";
            this.check_qianghuazhuangbei.Size = new System.Drawing.Size(82, 18);
            this.check_qianghuazhuangbei.TabIndex = 3;
            this.check_qianghuazhuangbei.Text = "强化装备";
            this.check_qianghuazhuangbei.UseVisualStyleBackColor = true;
            // 
            // check_chongwuchuzhan
            // 
            this.check_chongwuchuzhan.AutoSize = true;
            this.check_chongwuchuzhan.Location = new System.Drawing.Point(69, 105);
            this.check_chongwuchuzhan.Name = "check_chongwuchuzhan";
            this.check_chongwuchuzhan.Size = new System.Drawing.Size(82, 18);
            this.check_chongwuchuzhan.TabIndex = 13;
            this.check_chongwuchuzhan.Text = "宠物出战";
            this.check_chongwuchuzhan.UseVisualStyleBackColor = true;
            // 
            // check_shuxingjiadian
            // 
            this.check_shuxingjiadian.AutoSize = true;
            this.check_shuxingjiadian.Location = new System.Drawing.Point(198, 66);
            this.check_shuxingjiadian.Name = "check_shuxingjiadian";
            this.check_shuxingjiadian.Size = new System.Drawing.Size(82, 18);
            this.check_shuxingjiadian.TabIndex = 4;
            this.check_shuxingjiadian.Text = "属性加点";
            this.check_shuxingjiadian.UseVisualStyleBackColor = true;
            // 
            // check_chongwujiadian
            // 
            this.check_chongwujiadian.AutoSize = true;
            this.check_chongwujiadian.Location = new System.Drawing.Point(756, 66);
            this.check_chongwujiadian.Name = "check_chongwujiadian";
            this.check_chongwujiadian.Size = new System.Drawing.Size(82, 18);
            this.check_chongwujiadian.TabIndex = 11;
            this.check_chongwujiadian.Text = "宠物加点";
            this.check_chongwujiadian.UseVisualStyleBackColor = true;
            // 
            // check_xiangqianzhuangbei
            // 
            this.check_xiangqianzhuangbei.AutoSize = true;
            this.check_xiangqianzhuangbei.Location = new System.Drawing.Point(756, 31);
            this.check_xiangqianzhuangbei.Name = "check_xiangqianzhuangbei";
            this.check_xiangqianzhuangbei.Size = new System.Drawing.Size(82, 18);
            this.check_xiangqianzhuangbei.TabIndex = 5;
            this.check_xiangqianzhuangbei.Text = "镶嵌装备";
            this.check_xiangqianzhuangbei.UseVisualStyleBackColor = true;
            // 
            // check_tupoxinjing
            // 
            this.check_tupoxinjing.AutoSize = true;
            this.check_tupoxinjing.Location = new System.Drawing.Point(317, 66);
            this.check_tupoxinjing.Name = "check_tupoxinjing";
            this.check_tupoxinjing.Size = new System.Drawing.Size(82, 18);
            this.check_tupoxinjing.TabIndex = 10;
            this.check_tupoxinjing.Text = "突破心境";
            this.check_tupoxinjing.UseVisualStyleBackColor = true;
            // 
            // check_jingtongzhuangbei
            // 
            this.check_jingtongzhuangbei.AutoSize = true;
            this.check_jingtongzhuangbei.Location = new System.Drawing.Point(627, 31);
            this.check_jingtongzhuangbei.Name = "check_jingtongzhuangbei";
            this.check_jingtongzhuangbei.Size = new System.Drawing.Size(82, 18);
            this.check_jingtongzhuangbei.TabIndex = 6;
            this.check_jingtongzhuangbei.Text = "精通装备";
            this.check_jingtongzhuangbei.UseVisualStyleBackColor = true;
            // 
            // check_shengjijineng
            // 
            this.check_shengjijineng.AutoSize = true;
            this.check_shengjijineng.Location = new System.Drawing.Point(446, 66);
            this.check_shengjijineng.Name = "check_shengjijineng";
            this.check_shengjijineng.Size = new System.Drawing.Size(82, 18);
            this.check_shengjijineng.TabIndex = 9;
            this.check_shengjijineng.Text = "升级技能";
            this.check_shengjijineng.UseVisualStyleBackColor = true;
            // 
            // check_kemingzhuangbei
            // 
            this.check_kemingzhuangbei.AutoSize = true;
            this.check_kemingzhuangbei.Location = new System.Drawing.Point(447, 31);
            this.check_kemingzhuangbei.Name = "check_kemingzhuangbei";
            this.check_kemingzhuangbei.Size = new System.Drawing.Size(89, 18);
            this.check_kemingzhuangbei.TabIndex = 7;
            this.check_kemingzhuangbei.Text = "刻铭装备:";
            this.check_kemingzhuangbei.UseVisualStyleBackColor = true;
            // 
            // check_qinglibeibao
            // 
            this.check_qinglibeibao.AutoSize = true;
            this.check_qinglibeibao.Location = new System.Drawing.Point(627, 66);
            this.check_qinglibeibao.Name = "check_qinglibeibao";
            this.check_qinglibeibao.Size = new System.Drawing.Size(82, 18);
            this.check_qinglibeibao.TabIndex = 8;
            this.check_qinglibeibao.Text = "清理背包";
            this.check_qinglibeibao.UseVisualStyleBackColor = true;
            // 
            // groupBox_lingqushezhi
            // 
            this.groupBox_lingqushezhi.Controls.Add(this.check_lingqushezhiallselect);
            this.groupBox_lingqushezhi.Controls.Add(this.check_hongfubaoxiang);
            this.groupBox_lingqushezhi.Controls.Add(this.check_chengjiujiangli);
            this.groupBox_lingqushezhi.Controls.Add(this.check_huodongzhaohui);
            this.groupBox_lingqushezhi.Controls.Add(this.check_juexuechanwu);
            this.groupBox_lingqushezhi.Controls.Add(this.check_yuyuejiangli);
            this.groupBox_lingqushezhi.Controls.Add(this.check_shoushanyoujian);
            this.groupBox_lingqushezhi.Controls.Add(this.check_fulijiangli);
            this.groupBox_lingqushezhi.Controls.Add(this.check_jishijiangli);
            this.groupBox_lingqushezhi.Controls.Add(this.check_huoyuejiangli);
            this.groupBox_lingqushezhi.Location = new System.Drawing.Point(3, 3);
            this.groupBox_lingqushezhi.Name = "groupBox_lingqushezhi";
            this.groupBox_lingqushezhi.Size = new System.Drawing.Size(925, 129);
            this.groupBox_lingqushezhi.TabIndex = 11;
            this.groupBox_lingqushezhi.TabStop = false;
            this.groupBox_lingqushezhi.Text = "领取设置";
            // 
            // check_lingqushezhiallselect
            // 
            this.check_lingqushezhiallselect.AutoSize = true;
            this.check_lingqushezhiallselect.BackColor = System.Drawing.Color.LightGray;
            this.check_lingqushezhiallselect.Location = new System.Drawing.Point(871, 11);
            this.check_lingqushezhiallselect.Name = "check_lingqushezhiallselect";
            this.check_lingqushezhiallselect.Size = new System.Drawing.Size(54, 18);
            this.check_lingqushezhiallselect.TabIndex = 10;
            this.check_lingqushezhiallselect.Text = "全选";
            this.check_lingqushezhiallselect.UseVisualStyleBackColor = false;
            this.check_lingqushezhiallselect.CheckedChanged += new System.EventHandler(this.check_lingqushezhiallselect_CheckedChanged);
            // 
            // check_hongfubaoxiang
            // 
            this.check_hongfubaoxiang.AutoSize = true;
            this.check_hongfubaoxiang.Location = new System.Drawing.Point(217, 67);
            this.check_hongfubaoxiang.Name = "check_hongfubaoxiang";
            this.check_hongfubaoxiang.Size = new System.Drawing.Size(82, 18);
            this.check_hongfubaoxiang.TabIndex = 7;
            this.check_hongfubaoxiang.Text = "鸿富宝箱";
            this.check_hongfubaoxiang.UseVisualStyleBackColor = true;
            // 
            // check_chengjiujiangli
            // 
            this.check_chengjiujiangli.AutoSize = true;
            this.check_chengjiujiangli.Location = new System.Drawing.Point(86, 34);
            this.check_chengjiujiangli.Name = "check_chengjiujiangli";
            this.check_chengjiujiangli.Size = new System.Drawing.Size(82, 18);
            this.check_chengjiujiangli.TabIndex = 1;
            this.check_chengjiujiangli.Text = "成就奖励";
            this.check_chengjiujiangli.UseVisualStyleBackColor = true;
            // 
            // check_huodongzhaohui
            // 
            this.check_huodongzhaohui.AutoSize = true;
            this.check_huodongzhaohui.Location = new System.Drawing.Point(456, 67);
            this.check_huodongzhaohui.Name = "check_huodongzhaohui";
            this.check_huodongzhaohui.Size = new System.Drawing.Size(82, 18);
            this.check_huodongzhaohui.TabIndex = 9;
            this.check_huodongzhaohui.Text = "活动找回";
            this.check_huodongzhaohui.UseVisualStyleBackColor = true;
            // 
            // check_juexuechanwu
            // 
            this.check_juexuechanwu.AutoSize = true;
            this.check_juexuechanwu.Location = new System.Drawing.Point(217, 34);
            this.check_juexuechanwu.Name = "check_juexuechanwu";
            this.check_juexuechanwu.Size = new System.Drawing.Size(82, 18);
            this.check_juexuechanwu.TabIndex = 2;
            this.check_juexuechanwu.Text = "绝学参悟";
            this.check_juexuechanwu.UseVisualStyleBackColor = true;
            // 
            // check_yuyuejiangli
            // 
            this.check_yuyuejiangli.AutoSize = true;
            this.check_yuyuejiangli.Location = new System.Drawing.Point(338, 67);
            this.check_yuyuejiangli.Name = "check_yuyuejiangli";
            this.check_yuyuejiangli.Size = new System.Drawing.Size(82, 18);
            this.check_yuyuejiangli.TabIndex = 8;
            this.check_yuyuejiangli.Text = "预约奖励";
            this.check_yuyuejiangli.UseVisualStyleBackColor = true;
            // 
            // check_shoushanyoujian
            // 
            this.check_shoushanyoujian.AutoSize = true;
            this.check_shoushanyoujian.Location = new System.Drawing.Point(338, 34);
            this.check_shoushanyoujian.Name = "check_shoushanyoujian";
            this.check_shoushanyoujian.Size = new System.Drawing.Size(82, 18);
            this.check_shoushanyoujian.TabIndex = 3;
            this.check_shoushanyoujian.Text = "收删邮件";
            this.check_shoushanyoujian.UseVisualStyleBackColor = true;
            // 
            // check_fulijiangli
            // 
            this.check_fulijiangli.AutoSize = true;
            this.check_fulijiangli.Location = new System.Drawing.Point(580, 34);
            this.check_fulijiangli.Name = "check_fulijiangli";
            this.check_fulijiangli.Size = new System.Drawing.Size(208, 18);
            this.check_fulijiangli.TabIndex = 4;
            this.check_fulijiangli.Text = "福利奖励(默认全部福利找回)";
            this.check_fulijiangli.UseVisualStyleBackColor = true;
            // 
            // check_jishijiangli
            // 
            this.check_jishijiangli.AutoSize = true;
            this.check_jishijiangli.Location = new System.Drawing.Point(86, 67);
            this.check_jishijiangli.Name = "check_jishijiangli";
            this.check_jishijiangli.Size = new System.Drawing.Size(82, 18);
            this.check_jishijiangli.TabIndex = 6;
            this.check_jishijiangli.Text = "记事奖励";
            this.check_jishijiangli.UseVisualStyleBackColor = true;
            // 
            // check_huoyuejiangli
            // 
            this.check_huoyuejiangli.AutoSize = true;
            this.check_huoyuejiangli.Location = new System.Drawing.Point(456, 34);
            this.check_huoyuejiangli.Name = "check_huoyuejiangli";
            this.check_huoyuejiangli.Size = new System.Drawing.Size(82, 18);
            this.check_huoyuejiangli.TabIndex = 5;
            this.check_huoyuejiangli.Text = "活跃奖励";
            this.check_huoyuejiangli.UseVisualStyleBackColor = true;
            // 
            // check_lingquallselect
            // 
            this.check_lingquallselect.AutoSize = true;
            this.check_lingquallselect.BackColor = System.Drawing.Color.LightGray;
            this.check_lingquallselect.Location = new System.Drawing.Point(564, 3);
            this.check_lingquallselect.Name = "check_lingquallselect";
            this.check_lingquallselect.Size = new System.Drawing.Size(82, 18);
            this.check_lingquallselect.TabIndex = 10;
            this.check_lingquallselect.Text = "一键全选";
            this.check_lingquallselect.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.ForestGreen;
            this.button10.Location = new System.Drawing.Point(743, 426);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 30);
            this.button10.TabIndex = 20;
            this.button10.Text = "保存设置";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // listView_log
            // 
            this.listView_log.HideSelection = false;
            this.listView_log.Location = new System.Drawing.Point(1, 461);
            this.listView_log.Margin = new System.Windows.Forms.Padding(4);
            this.listView_log.Name = "listView_log";
            this.listView_log.Size = new System.Drawing.Size(948, 112);
            this.listView_log.TabIndex = 22;
            this.listView_log.UseCompatibleStateImageBehavior = false;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage5);
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Location = new System.Drawing.Point(-5, 1);
            this.tabControl3.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(958, 422);
            this.tabControl3.TabIndex = 23;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tabControl2);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage5.Size = new System.Drawing.Size(950, 394);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "开始";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dataGridView1);
            this.tabPage6.Controls.Add(this.button5);
            this.tabPage6.Controls.Add(this.button7);
            this.tabPage6.Controls.Add(this.button6);
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage6.Size = new System.Drawing.Size(950, 394);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "账号";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Khaki;
            this.button2.Location = new System.Drawing.Point(531, 426);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 22;
            this.button2.Text = "停止";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Crimson;
            this.button12.Location = new System.Drawing.Point(105, 426);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 30);
            this.button12.TabIndex = 24;
            this.button12.Text = "全部关闭";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Chocolate;
            this.button8.Location = new System.Drawing.Point(213, 426);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 30);
            this.button8.TabIndex = 25;
            this.button8.Text = "关闭";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 578);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.listView_log);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl3);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "安宇智能";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tab_login.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tab_basc.ResumeLayout(false);
            this.group_timelimittask.ResumeLayout(false);
            this.group_timelimittask.PerformLayout();
            this.groupbox_teamworktask.ResumeLayout(false);
            this.groupbox_teamworktask.PerformLayout();
            this.groupBox_singletask.ResumeLayout(false);
            this.groupBox_singletask.PerformLayout();
            this.tab_lingqu.ResumeLayout(false);
            this.tab_lingqu.PerformLayout();
            this.groupBox_tisheng.ResumeLayout(false);
            this.groupBox_tisheng.PerformLayout();
            this.groupBox_lingqushezhi.ResumeLayout(false);
            this.groupBox_lingqushezhi.PerformLayout();
            this.tabControl3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer_tips;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tab_login;
        private System.Windows.Forms.TabPage tab_basc;
        private System.Windows.Forms.TabPage tab_lingqu;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ListView listView_log;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox groupBox_singletask;
        private System.Windows.Forms.CheckBox check_mainLine;
        private System.Windows.Forms.CheckBox check_wenjianxiayi;
        private System.Windows.Forms.CheckBox check_menpairenwu;
        private System.Windows.Forms.CheckBox check_banghuirenwu;
        private System.Windows.Forms.CheckBox check_nagongqixiang;
        private System.Windows.Forms.CheckBox check_zongshidiantang;
        private System.Windows.Forms.TextBox txt_mainlinelimittime;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.CheckBox check_shenghuocaiji;
        private System.Windows.Forms.ComboBox cob_shenghuocaijixuanxiang;
        private System.Windows.Forms.ComboBox cob_shenghuocaijixuanxiangjishu;
        private System.Windows.Forms.ComboBox cob_shenghuozhizaoxuanxiangjishu;
        private System.Windows.Forms.ComboBox cob_shenghuozhizaoxuanxiang;
        private System.Windows.Forms.CheckBox check_shenghuozhizao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox check_autologin;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_shenfenzhenghao;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_yanzhengxingming;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox txt_gamepath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupbox_teamworktask;
        private System.Windows.Forms.CheckBox check_yongchuangshanzhai;
        private System.Windows.Forms.CheckBox check_xixiawangling;
        private System.Windows.Forms.CheckBox check_yanziwu;
        private System.Windows.Forms.CheckBox check_jianghufanguan;
        private System.Windows.Forms.CheckBox check_zhenlongqiju;
        private System.Windows.Forms.CheckBox check_gaobeiqiju;
        private System.Windows.Forms.GroupBox group_timelimittask;
        private System.Windows.Forms.CheckBox check_jianghujixiong;
        private System.Windows.Forms.CheckBox checkshendulunjian;
        private System.Windows.Forms.CheckBox check_bianguanwenzhan;
        private System.Windows.Forms.CheckBox check_banghuiyunbiao;
        private System.Windows.Forms.CheckBox check_hanyuliangong;
        private System.Windows.Forms.CheckBox check_xiaoxiao;
        private System.Windows.Forms.CheckBox check_sidaeren;
        private System.Windows.Forms.CheckBox check_juexuechanwu;
        private System.Windows.Forms.CheckBox check_chengjiujiangli;
        private System.Windows.Forms.CheckBox check_shoushanyoujian;
        private System.Windows.Forms.CheckBox check_fulijiangli;
        private System.Windows.Forms.CheckBox check_selectalltask;
        private System.Windows.Forms.CheckBox check_timelimittaskallselect;
        private System.Windows.Forms.CheckBox check_teamtaskallselect;
        private System.Windows.Forms.CheckBox check_huoyuejiangli;
        private System.Windows.Forms.CheckBox check_jishijiangli;
        private System.Windows.Forms.CheckBox check_hongfubaoxiang;
        private System.Windows.Forms.CheckBox check_yuyuejiangli;
        private System.Windows.Forms.CheckBox check_huodongzhaohui;
        private System.Windows.Forms.CheckBox check_baoshishengyan;
        private System.Windows.Forms.CheckBox check_banghuiyanwu;
        private System.Windows.Forms.CheckBox check_lingquallselect;
        private System.Windows.Forms.GroupBox groupBox_lingqushezhi;
        private System.Windows.Forms.CheckBox check_lingqushezhiallselect;
        private System.Windows.Forms.ComboBox cob_xixiawanglingcengshu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_xixiawanglingxianzhishijian;
        private System.Windows.Forms.CheckBox check_addfriends;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn nickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn account;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.DataGridViewTextBoxColumn server;
        private System.Windows.Forms.DataGridViewTextBoxColumn sect;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isCaptain;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn emulator;
        private System.Windows.Forms.DataGridViewTextBoxColumn platform;
        private System.Windows.Forms.CheckBox chk_qiehuanjuese;
        private System.Windows.Forms.CheckBox check_regroupteam;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox_tisheng;
        private System.Windows.Forms.ComboBox cob_kemingjishu;
        private System.Windows.Forms.CheckBox check_fenjiezhuangbei;
        private System.Windows.Forms.CheckBox check_tishengallselect;
        private System.Windows.Forms.CheckBox check_chuandaizhuangbei;
        private System.Windows.Forms.CheckBox check_beibaojiesuo;
        private System.Windows.Forms.CheckBox check_wuxueduanti;
        private System.Windows.Forms.CheckBox check_tianjiayaopin;
        private System.Windows.Forms.CheckBox check_qianghuazhuangbei;
        private System.Windows.Forms.CheckBox check_chongwuchuzhan;
        private System.Windows.Forms.CheckBox check_shuxingjiadian;
        private System.Windows.Forms.CheckBox check_chongwujiadian;
        private System.Windows.Forms.CheckBox check_xiangqianzhuangbei;
        private System.Windows.Forms.CheckBox check_tupoxinjing;
        private System.Windows.Forms.CheckBox check_jingtongzhuangbei;
        private System.Windows.Forms.CheckBox check_shengjijineng;
        private System.Windows.Forms.CheckBox check_kemingzhuangbei;
        private System.Windows.Forms.CheckBox check_qinglibeibao;
    }
}

