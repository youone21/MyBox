using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBox.Models
{
    /// <summary>
    /// 用于保存TabPage的逻辑名字
    /// </summary>
    public class TabPageNames
    {
        /// <summary>
        /// TabPage的名字
        /// </summary>
        private string _name;

        /// <summary>
        /// 取得 TabPage的名字
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return _name;
        }


        /// <summary>
        /// 设定 TabPage的名字
        /// </summary>
        /// <param name="name"></param>
        public void SetName(string name)
        {
            _name = name;
        }
    }
}
