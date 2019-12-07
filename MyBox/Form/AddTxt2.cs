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

        private string CellValue = string.Empty;
        private string CellInit = "示例文本";

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
            if (!string.IsNullOrEmpty(txt_index.Text) && Convert.ToInt32(txt_index.Text) < 100)
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
            ChangeText();
        }

        private void AddTxt2_Load(object sender, EventArgs e)
        {
            txt_index.Text = "0";
            Excel.Range range = Globals.ThisAddIn.Application.Selection[1];
            if (range.Value == null)
            {
                CellValue = CellInit;
                return;
            }
            string value = null;
            if (typeof(System.Double) == range.Value.GetType())
            {
                value = range.Value.ToString("G");
                CellValue = value;
            }
            else
            {
                value = range.Value.ToString();
                CellValue = value;
            }
            label2.Text = value;
            rtb.Text = value;
        }

        private void ChangeText()
        {
            Logger log = Logger.GetLogger("AddTxt2");

            if (string.IsNullOrEmpty(txt_index.Text))
            {
                return;
            }

            if (string.IsNullOrEmpty(txt_content.Text))
            {
                rtb.Text = CellValue;
                return;
            }

            if (Globals.ThisAddIn.Application.ActiveCell.Value == null)
            {
                log.Info("所选单元格为空");
                return;
            }

            try
            {
                int index = Convert.ToInt32(txt_index.Text);

                string str = txt_content.Text;

                if (rbt_addToStart.Checked)
                {
                    if (0 == index)
                    {
                        return;
                    }

                    string itemValue = null;

                    itemValue = CellValue;

                    int cnt = itemValue.Length;

                    if (cnt < index)
                    {
                        index = cnt + 1;
                    }

                    rtb.Text = itemValue.Insert(index - 1, txt_content.Text);
                }
                else if (rbt_addToEnd.Checked)
                {
                    string itemValue = null;

                    itemValue = CellValue;
                    int cnt = itemValue.Length;

                    if (cnt < index)
                    {
                        index = cnt;
                    }

                    rtb.Text = itemValue.Insert(index, txt_content.Text);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
            }
        }

        private void Txt_index_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_index.Text))
            {
                txt_index.Text = "0";
                return;
            }

            int cnt = txt_index.Text.Count();
            if (cnt > 2)
            {
                txt_index.Text = "99";
            }

            ChangeText();
        }

        private void Rbt_addToEnd_TextChanged(object sender, EventArgs e)
        {
            ChangeText();
        }
    }
}
