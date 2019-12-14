using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

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

        Excel.Worksheet activeSheet;

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
    }
}
