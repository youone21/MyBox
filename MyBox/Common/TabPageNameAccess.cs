using MyBox.Log;
using MyBox.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBox.Common
{
    public class TabPageNameAccess
    {
        private List<TabPageNames> tpnList = new List<TabPageNames>();
        private string path = null;

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
        public void WriteJsonTabPageNames(string tabPageName)
        {
            Logger.Debug("[保存tabPage的名字] 执行开始");
            // 读取json数据存入tpnList里
            JObject jObj = JsonAccess.ReadJson(tabPageName);

            if (jObj != null && jObj.Count > 0)
            {
                foreach (JToken item in jObj["tabPageNames"])
                {
                    TabPageNames tpn1 = new TabPageNames();
                    tpn1.SetName(item["Name"].ToString());
                    tpnList.Add(tpn1);
                }
            }

            int cnt = 0;

            if (tpnList != null && tpnList.Count > 0)
            {
                cnt = (from tpn in tpnList
                           where tpn.GetName().Contains(tabPageName)
                           select tpn).Count();
            }

            if (cnt == 0)
            {
                // 声明TabPageNames
                TabPageNames tpn2 = new TabPageNames();

                tpn2.SetName(tabPageName);       // 画面传来在name
                                                 // 添加到tpnList里
                tpnList.Add(tpn2);

                // 写入json
                JsonAccess.WriteJson(tabPageName, tpnList);
            }

            // 如果添加在名字存在

            Logger.Debug("[保存tabPage的名字] 执行终了");
        }

    }
}
