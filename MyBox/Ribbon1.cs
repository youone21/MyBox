using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using Microsoft.Office.Interop.Excel;
using System.Drawing;

namespace MyBox
{
    /*
     * 作成者  日期        详细
     * zjx    2019-12-14  坐标：东京
     */


    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        /// <summary>
        /// 插入文本到开头
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addTxtToStart_Click(object sender, RibbonControlEventArgs e)
        {
            AddTxt1 addTxt1 = new AddTxt1();
            addTxt1.StartPosition = FormStartPosition.CenterParent;
            addTxt1.Text = "插入文本到开头";
            addTxt1.ShowDialog();
        }

        /// <summary>
        /// 插入文本到末尾
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addTxtToEnd_Click(object sender, RibbonControlEventArgs e)
        {
            AddTxt1 addTxt1 = new AddTxt1();
            addTxt1.StartPosition = FormStartPosition.CenterParent;
            addTxt1.Text = "插入文本到末尾";
            addTxt1.ShowDialog();
        }

        /// <summary>
        /// 插入文本到中间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addTxtToMid_Click(object sender, RibbonControlEventArgs e)
        {
            AddTxt2 addTxt2 = new AddTxt2();
            addTxt2.StartPosition = FormStartPosition.CenterParent;
            addTxt2.ShowDialog();
        }

        private void Btn_userControl1_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.ShowUserControl();
        }

        private void Btn_Terminal_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void btn_find_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.ShowFind();
        }

        /// <summary>
        /// 收纳箱
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Storage_Click(object sender, RibbonControlEventArgs e)
        {
            StorageBox sb = new StorageBox();
            sb.StartPosition = FormStartPosition.CenterParent;
            sb.ShowDialog();
        }

        private void btn_sheetNav_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.ShowSheetsNav();
        }

        #region 聚光灯

        private FormatCondition format;
        private Color color = Color.Yellow;

        private void btn_light_Click(object sender, RibbonControlEventArgs e)
        {
            if (btn_light.Checked)
            {

                ApplicationChange(Globals.ThisAddIn.Application.ActiveSheet
                                  , Globals.ThisAddIn.Application.Selection);
                Globals.ThisAddIn.Application.SheetSelectionChange += ApplicationChange;
            }
            else
            {
                if (format != null)
                {
                    format.Delete();
                    format = null;
                }
                Globals.ThisAddIn.Application.SheetSelectionChange -= ApplicationChange;
            }
        }

        private void ApplicationChange(Object sh, Range range)
        {
            if (format != null)
            {
                format.Delete();
                format = null;
            }

            Range range1 = ((Worksheet)sh).Range["$1:$1048576"];
            string rule = "=OR(CELL(\"row\")=ROW(),CELL(\"col\")=COLUMN())";
            format = (FormatCondition)range1.FormatConditions.Add(XlFormatConditionType.xlExpression
                                                                  , Type.Missing
                                                                  , rule
                                                                  , Type.Missing
                                                                  , Type.Missing
                                                                  , Type.Missing
                                                                  , Type.Missing
                                                                  , Type.Missing);

            format.Font.Bold = true;
            format.Interior.Color = color;
        }

        private void btn_ligth_color_Click(object sender, RibbonControlEventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
                ApplicationChange(Globals.ThisAddIn.Application.ActiveSheet
                                  , Globals.ThisAddIn.Application.Selection);
            }
        }

        #endregion
    }
}
