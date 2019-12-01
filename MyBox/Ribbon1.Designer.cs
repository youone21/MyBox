namespace MyBox
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.menu1 = this.Factory.CreateRibbonMenu();
            this.btn_addTxtToStart = this.Factory.CreateRibbonButton();
            this.btn_addTxtToMid = this.Factory.CreateRibbonButton();
            this.btn_addTxtToEnd = this.Factory.CreateRibbonButton();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.btn_userControl1 = this.Factory.CreateRibbonButton();
            this.btn_Terminal = this.Factory.CreateRibbonButton();
            this.btn_find = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group3);
            this.tab1.Label = "万能魔盒";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.menu1);
            this.group1.Label = "文本处理";
            this.group1.Name = "group1";
            // 
            // menu1
            // 
            this.menu1.Items.Add(this.btn_addTxtToStart);
            this.menu1.Items.Add(this.btn_addTxtToMid);
            this.menu1.Items.Add(this.btn_addTxtToEnd);
            this.menu1.Label = "插入文本";
            this.menu1.Name = "menu1";
            // 
            // btn_addTxtToStart
            // 
            this.btn_addTxtToStart.Label = "插入文本到开头";
            this.btn_addTxtToStart.Name = "btn_addTxtToStart";
            this.btn_addTxtToStart.ShowImage = true;
            this.btn_addTxtToStart.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_addTxtToStart_Click);
            // 
            // btn_addTxtToMid
            // 
            this.btn_addTxtToMid.Label = "插入文本到中间";
            this.btn_addTxtToMid.Name = "btn_addTxtToMid";
            this.btn_addTxtToMid.ShowImage = true;
            this.btn_addTxtToMid.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_addTxtToMid_Click);
            // 
            // btn_addTxtToEnd
            // 
            this.btn_addTxtToEnd.Label = "插入文本到末尾";
            this.btn_addTxtToEnd.Name = "btn_addTxtToEnd";
            this.btn_addTxtToEnd.ShowImage = true;
            this.btn_addTxtToEnd.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_addTxtToEnd_Click);
            // 
            // group3
            // 
            this.group3.Items.Add(this.btn_userControl1);
            this.group3.Items.Add(this.btn_Terminal);
            this.group3.Items.Add(this.btn_find);
            this.group3.Label = "group3";
            this.group3.Name = "group3";
            // 
            // btn_userControl1
            // 
            this.btn_userControl1.Label = "UserControl1";
            this.btn_userControl1.Name = "btn_userControl1";
            this.btn_userControl1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_userControl1_Click);
            // 
            // btn_Terminal
            // 
            this.btn_Terminal.Label = "Terminal";
            this.btn_Terminal.Name = "btn_Terminal";
            this.btn_Terminal.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Btn_Terminal_Click);
            // 
            // btn_find
            // 
            this.btn_find.Label = "查找对话框";
            this.btn_find.Name = "btn_find";
            this.btn_find.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_find_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu menu1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_addTxtToStart;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_addTxtToMid;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_addTxtToEnd;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_userControl1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_Terminal;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_find;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
