using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using Microsoft.Office.Tools;
using System.Windows.Forms;

namespace MyBox
{
    public partial class ThisAddIn
    {
        public CustomTaskPane myTaskPane = null;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {

        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        public void ShowUserControl()
        {
            int hwnd = this.Application.ActiveWindow.Hwnd;
            Dictionary<int, CustomTaskPane> taskPane = new Dictionary<int, CustomTaskPane>();
            UserControl1 ctrl = new UserControl1();
            CustomTaskPane pane = this.CustomTaskPanes.Add(ctrl, "***", this.Application.ActiveWindow);
            taskPane.Add(this.Application.ActiveWindow.Hwnd, pane);
            taskPane.TryGetValue(this.Application.ActiveWindow.Hwnd, out pane);

            pane.DockPosition = Office.MsoCTPDockPosition.msoCTPDockPositionRight;
            pane.Visible = true;
        }

        public void ShowTerminal()
        {
            int hwnd = this.Application.ActiveWindow.Hwnd;
            Dictionary<int, CustomTaskPane> taskPane = new Dictionary<int, CustomTaskPane>();
            UserControl1 ctrl = new UserControl1();
            CustomTaskPane pane = this.CustomTaskPanes.Add(ctrl, "***", this.Application.ActiveWindow);
            taskPane.Add(this.Application.ActiveWindow.Hwnd, pane);
            taskPane.TryGetValue(this.Application.ActiveWindow.Hwnd, out pane);

            pane.DockPosition = Office.MsoCTPDockPosition.msoCTPDockPositionRight;
            pane.Visible = true;
        }

        #region VSTO 生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
    }
}
