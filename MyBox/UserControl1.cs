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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            string str = txt_ctn.Text;

            if (string.IsNullOrEmpty(str))
            {
                return;
            }

            int index = this.dgv1.Rows.Add();
            dgv1.Rows[index].Cells[1].Value = str;
        }

        private void Dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Excel.Range item in Globals.ThisAddIn.Application.Selection)
            {
                item.Value = dgv1.CurrentRow.Cells[1].Value;
            }
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            dgv1.Rows.Clear();
        }
    }
}
