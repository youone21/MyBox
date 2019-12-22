using MyBox.Common;
using MyBox.Log;
using MyBox.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBox
{
    /*
     *   作成者     日期            详细
     *   zjx        2019-12-14     坐标：东京
     */

    public partial class StorageBox : Form
    {
        public StorageBox()
        {
            InitializeComponent();
        }

        #region 全局变量
        private string JsonPath;
        private const string JsonFileName = "TabPageName";
        #endregion

        private void StorageBox_Load(object sender, EventArgs e)
        {
            Logger.Debug("[收纳箱界面加载]执行开始");
            GetJsonPath(JsonFileName);

            // 读取json数据存入tpnList里
            TabPageAll tabPageAll = new TabPageAll();
            try
            {
                TabPageAll obj = new TabPageAll();
                JsonAccess.ReadJson(JsonPath, obj);
                if (obj != null)
                {
                    foreach (TabPageNames item in obj.TabPageNames)
                    {
                        TabPageNames tpn1 = new TabPageNames();
                        tpn1.Name = item.Name;
                        tabPageAll.TabPageNames.Add(tpn1);
                    }
                }
            }
            catch (Exception e1)
            {
                Logger.Error(e1.ToString());
            }

            if (tabPageAll == null || tabPageAll.TabPageNames.Count == 0)
            {
                return;
            }

            foreach (TabPageNames item in tabPageAll.TabPageNames)
            {
                Logger.Debug("开始添加Tab：" + item.Name);
                tabC_ctx.TabPages.Add(item.Name);
            }
            Logger.Debug("[收纳箱界面加载]执行结束");
        }

        /// <summary>
        /// 添加类别
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_add_Click(object sender, EventArgs e)
        {
            Logger.Debug("[添加类别] 执行开始");
            string text = txt_typeName.Text;
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("请输入类别名称!");
            }

            // 写入json
            TabPageNameAccess tpnAccess = new TabPageNameAccess();
            string sysPath = AppDomain.CurrentDomain.BaseDirectory;
            string path = sysPath + @"Json\TabPageName.json";
            try
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
            }
            catch (Exception e1)
            {
                Logger.Error(e1.ToString());
                return;
            }


            TabPage tabPage = new TabPage();
            string tabPageName = "tp_" + text;
            tabPage.Name = tabPageName;
            tabPage.Text = text;

            // 写入Json
            tpnAccess.GetPath(path);
            TabPageAll tabPageAll = new TabPageAll();
            bool result = tpnAccess.WriteJsonTabPageNames(tabPageName, tabPageAll);
            if (result)
            {
                tabC_ctx.TabPages.Clear();
                foreach (TabPageNames item in tabPageAll.TabPageNames)
                {
                    Logger.Debug("开始添加Tab：" + item.Name);
                    tabC_ctx.TabPages.Add(item.Name);
                }
            }
            // 添加Tab

            Logger.Debug("[添加类别] 执行终了");
        }

        /// <summary>
        /// 获取Json路径
        /// </summary>
        private void GetJsonPath(string fileName)
        {
            Logger.Debug("[获取Json路径]执行开始");
            string sysPath = AppDomain.CurrentDomain.BaseDirectory;
            JsonPath = sysPath + @"Json\" + fileName + ".json";
            try
            {
                if (!File.Exists(JsonPath))
                {
                    File.Create(JsonPath);
                }
            }
            catch (Exception e1)
            {
                Logger.Error(e1.ToString());
                return;
            }

            Logger.Debug("[获取Json路径]执行结束");
        }
    }
}
