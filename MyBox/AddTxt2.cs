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
            if (string.IsNullOrEmpty(txt_index.Text))
            {
                return;
            }

            if (string.IsNullOrEmpty(txt_content.Text))
            {
                return;
            }

            int index = Convert.ToInt32(txt_index.Text);

            string str = txt_content.Text;

            int cnt = str.Count();

            if (cnt < index)
            {
                index = cnt;
            }

            if (rbt_addToStart.Checked)
            {
                foreach (Excel.Range item in Globals.ThisAddIn.Application.Selection)
                {
                    item.Value = item.Value.Insert(index - 1, txt_content.Text);
                }
            }

            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
