using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace MyBox
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        Excel.Worksheet activeSheet;

        /// <summary>
        /// checkBox(HeighLight) click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckbHeighLight_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void OpenHeighLight()
        {

                activeSheet = Globals.ThisAddIn.Application.ActiveSheet;
                activeSheet.SelectionChange += new Excel.DocEvents_SelectionChangeEventHandler(SelectionChanged);
        }

        private void SelectionChanged(Excel.Range target)
        {
            string str = target.AddressLocal;
            MessageBox.Show(str);
        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            Test test = new Test();
            test.StartPosition = FormStartPosition.CenterParent;
            test.ShowDialog();
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
    }
}
