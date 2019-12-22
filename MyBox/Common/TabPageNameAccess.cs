using MyBox.Log;
using MyBox.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBox.Common
{
    public class TabPageNameAccess
    {
        private string path = null;

        public TabPageNameAccess()
        {
        }

        /// <summary>
        /// 获取Json文件路径
        /// </summary>
        /// <param name="pathName"></param>
        public void GetPath(string pathName)
        {
            path = pathName;
            try
            {
                if (!File.Exists(pathName))
                {
                    File.Create(path);
                }
            }
            catch (Exception e)
            {
                Logger.Error(e.ToString());
            }

        }

        /// <summary>
        /// 保存tabPage的名字
        /// </summary>
        public bool WriteJsonTabPageNames(string tabPageName, TabPageAll tabPageAll)
        {
            Logger.Debug("[保存tabPage的名字] 执行开始");
            // 读取json数据存入tpnList里
            try
            {
                TabPageAll obj = JsonAccess.ReadJson_TabNames(path);
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
            catch (Exception e)
            {
                Logger.Error(e.ToString());
                return false;
            }

            int cnt = 0;

            if (tabPageAll != null && tabPageAll.TabPageNames.Count > 0)
            {
                cnt = (from tpn in tabPageAll.TabPageNames
                       where tpn.Name == tabPageName
                       select tpn).Count();
            }

            if (cnt > 0)
            {
                MessageBox.Show("类别名称已存在！");
                return false;
            }
            // 声明TabPageNames
            TabPageNames tpn2 = new TabPageNames();

            tpn2.Name = tabPageName;       // 画面传来在name
                                           // 添加到tpnList里
            tabPageAll.TabPageNames.Add(tpn2);

            // 写入json
            JsonAccess.WriteJson(path, tabPageAll);

            // 如果添加在名字存在

            Logger.Debug("[保存tabPage的名字] 执行终了");
            return true;
        }

    }
}
