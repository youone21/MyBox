using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBox.Models
{
    public class TabPageAll
    {
        public TabPageAll()
        {
            TabPageNames = new List<TabPageNames>();
        }

        public List<TabPageNames> TabPageNames { get; set; }
    }
}
