﻿namespace MyBox
{
    partial class SheetsNav
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.listView_sheets = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listView_sheets
            // 
            this.listView_sheets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_sheets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_sheets.FullRowSelect = true;
            this.listView_sheets.HideSelection = false;
            this.listView_sheets.Location = new System.Drawing.Point(0, 0);
            this.listView_sheets.Name = "listView_sheets";
            this.listView_sheets.Size = new System.Drawing.Size(558, 1255);
            this.listView_sheets.TabIndex = 0;
            this.listView_sheets.UseCompatibleStateImageBehavior = false;
            this.listView_sheets.View = System.Windows.Forms.View.List;
            this.listView_sheets.Click += new System.EventHandler(this.listView_sheets_Click);
            // 
            // SheetsNav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView_sheets);
            this.Name = "SheetsNav";
            this.Size = new System.Drawing.Size(558, 1255);
            this.Load += new System.EventHandler(this.SheetsNav_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_sheets;
    }
}
