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
using MyBox.Log;

namespace MyBox
{
    public partial class ThisAddIn
    {
        public CustomTaskPane myTaskPane = null;

        private Logger logger;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        public void ShowUserControl()
        {
            int hwnd = this.Application.ActiveWindow.Hwnd;
            Logger.Info("ShowUserControl：" + "Hwnd：" + hwnd.ToString());

            UserControl ctrl = new UserControl();
            CustomTaskPane pane = this.CustomTaskPanes.Add(ctrl, "***", this.Application.ActiveWindow);

            if (taskPane.ContainsKey(hwnd.ToString() + "UserControl"))
            {
                if (taskPane != null && taskPane.Count() != 0)
                {
                    taskPane.TryGetValue(hwnd.ToString() + "UserControl", out pane);
                    Logger.Info(pane.Window.ToString());
                    if (pane.Visible == false)
                    {
                        pane.Visible = true;
                    }
                    else
                    {
                        pane.Visible = false;
                    }
                }
            }
            else
            {
                taskPane.Add(hwnd.ToString() + "UserControl", pane);
                taskPane.TryGetValue(hwnd.ToString() + "UserControl", out pane);
                Logger.Info(pane.ToString());

                pane.DockPosition = Office.MsoCTPDockPosition.msoCTPDockPositionRight;
                pane.Visible = true;
            }
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

        Dictionary<string, CustomTaskPane> taskPane = new Dictionary<string, CustomTaskPane>();

        public void ShowFind()
        {
            int hwnd = this.Application.ActiveWindow.Hwnd;
            Logger.Info("ShowFind：" + "Hwnd：" + hwnd.ToString());

            Find ctrl = new Find();
            CustomTaskPane pane = this.CustomTaskPanes.Add(ctrl, "***", this.Application.ActiveWindow);

            if (taskPane.ContainsKey(hwnd.ToString() + "Find"))
            {
                if (taskPane != null && taskPane.Count() != 0)
                {
                    taskPane.TryGetValue(hwnd.ToString() + "Find", out pane);
                    Logger.Info(pane.Window.ToString());
                    if (pane.Visible == false)
                    {
                        pane.Visible = true;
                    }
                    else
                    {
                        pane.Visible = false;
                    }
                }
            }
            else
            {
                taskPane.Add(hwnd.ToString() + "Find", pane);
                taskPane.TryGetValue(hwnd.ToString() + "Find", out pane);
                Logger.Info(pane.ToString());

                pane.DockPosition = Office.MsoCTPDockPosition.msoCTPDockPositionRight;
                pane.Visible = true;
            }
        }

        public void ShowSheetsNav()
        {
            int hwnd = this.Application.ActiveWindow.Hwnd;
            Logger.Info("ShowSheetsNav：" + "Hwnd：" + hwnd.ToString());

            SheetsNav ctrl = new SheetsNav();
            CustomTaskPane pane = this.CustomTaskPanes.Add(ctrl, "***", this.Application.ActiveWindow);

            if (taskPane.ContainsKey(hwnd.ToString() + "SheetsNav"))
            {
                if (taskPane != null && taskPane.Count() != 0)
                {
                    taskPane.TryGetValue(hwnd.ToString() + "SheetsNav", out pane);
                    Logger.Info(pane.Window.ToString());
                    if (pane.Visible == false)
                    {
                        pane.Visible = true;
                    }
                    else
                    {
                        pane.Visible = false;
                    }
                }
            }
            else
            {
                taskPane.Add(hwnd.ToString() + "SheetsNav", pane);
                taskPane.TryGetValue(hwnd.ToString() + "SheetsNav", out pane);
                Logger.Info(pane.ToString());

                pane.DockPosition = Office.MsoCTPDockPosition.msoCTPDockPositionRight;
                pane.Visible = true;
            }
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
