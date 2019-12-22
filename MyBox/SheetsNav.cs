using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace MyBox
{
    public partial class SheetsNav : UserControl
    {
        public SheetsNav()
        {
            InitializeComponent();
        }

        private void SheetsNav_Load(object sender, EventArgs e)
        {
            listView_sheets.Items.Clear();
            foreach (Excel.Worksheet item in Globals.ThisAddIn.Application.Sheets)
            {
                listView_sheets.Items.Add(item.Name);
            }

            //Globals.ThisAddIn.Application.ActiveSheet.SelectionChange += new Excel.DocEvents_SelectionChangeEventHandler(SheetCalculate);
        }
    }
}
