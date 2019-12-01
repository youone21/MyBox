using MyBox.Log;
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
    public partial class AddTxt2 : Form
    {
        public AddTxt2()
        {
            InitializeComponent();
        }

        private void txt_content_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 48代表0，57代表9，8代表空格，46代表小数点
            if ((e.KeyChar < 48 || e.KeyChar > 57))
            {
                e.Handled = true;
            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_index.Text) && Convert.ToInt32(txt_index.Text) > 1)
            {
                txt_index.Text = (Convert.ToInt32(txt_index.Text) - 1).ToString();
            }
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_index.Text) && Convert.ToInt32(txt_index.Text) < 9999)
            {
                txt_index.Text = (Convert.ToInt32(txt_index.Text) + 1).ToString();
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Logger log = Logger.GetLogger("AddTxt2");

            if (string.IsNullOrEmpty(txt_index.Text))
            {
                return;
            }

            if (string.IsNullOrEmpty(txt_content.Text))
            {
                return;
            }

            if (Globals.ThisAddIn.Application.ActiveCell.Value == null)
            {
                log.Info("所选单元格为空！");
                return;
            }

            try
            {
                int index = Convert.ToInt32(txt_index.Text);

                string str = txt_content.Text;
                log.Info("指示位置：" + str);

                if (rbt_addToStart.Checked)
                {
                    if (0 == index)
                    {
                        return;
                    }
                    foreach (Excel.Range item in Globals.ThisAddIn.Application.Selection)
                    {
                        string itemValue = null;
                        log.Info("所选择的单元格类型：" + item.Value.GetType().ToString());
                        if (typeof(System.Double) == item.Value.GetType())
                        {
                            itemValue = item.Value.ToString("G");
                        }
                        else
                        {
                            itemValue = item.Value.ToString();
                        }

                        int cnt = itemValue.Length;
                        log.Info("所选单元格文字长度：" + cnt.ToString());

                        if (cnt < index)
                        {
                            index = cnt + 1;
                        }

                        item.Value = itemValue.Insert(index - 1, txt_content.Text);
                    }
                }
                else if (rbt_addToEnd.Checked)
                {
                    foreach (Excel.Range item in Globals.ThisAddIn.Application.Selection)
                    {
                        string itemValue = null;
                        log.Info("所选择的单元格类型：" + item.Value.GetType().ToString());
                        if (typeof(System.Double) == item.Value.GetType())
                        {
                            itemValue = item.Value.ToString("G");
                        }
                        else
                        {
                            itemValue = item.Value.ToString();
                        }

                        int cnt = itemValue.Length;
                        log.Info("所选单元格文字长度：" + cnt.ToString());

                        if (cnt < index)
                        {
                            index = cnt;
                        }

                        item.Value = itemValue.Insert(index, txt_content.Text);
                    }

                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_content_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddTxt2_Load(object sender, EventArgs e)
        {
            Excel.Range range = Globals.ThisAddIn.Application.Selection;
            rtb.Text = range.Value;
        }
    }
}
