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
            bool result = tpnAccess.WriteJsonTabPageNames(tabPageName);
            if (result)
            {
                tabC_ctx.TabPages.Add(tabPage);
            }
            // 添加Tab

            Logger.Debug("[添加类别] 执行终了");
        }


    }
}
