using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace MyBox
{
    public partial class AddTxt1 : Form
    {
        public AddTxt1()
        {
            InitializeComponent();
        }

        private void AddTxt1_Load(object sender, EventArgs e)
        {
            lbl_error.Text = string.Empty;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string title_1 = "插入文本到开头";
        private string title_2 = "插入文本到末尾";

        /// <summary>
        /// 开始插入文本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ok_Click(object sender, EventArgs e)
        {
            lbl_error.Text = string.Empty;
            string ctn = txt_addTxtContent.Text;
            if (!string.IsNullOrEmpty(ctn))
            {
                Excel.Range currentRange = Globals.ThisAddIn.Application.ActiveCell;

                if (title_1.Equals(this.Text))
                {
                    foreach (Excel.Range item in Globals.ThisAddIn.Application.Selection)
                    {
                        item.Value = ctn + currentRange.Value;
                    }
                }
                else if (title_2.Equals(this.Text))
                {
                    foreach (Excel.Range item in Globals.ThisAddIn.Application.Selection)
                    {
                        item.Value += ctn;
                    }
                }

                this.Close();
            }

            lbl_error.ForeColor = Color.Red;
            lbl_error.Text = "输入的文本为空！";
        }
    }
}
