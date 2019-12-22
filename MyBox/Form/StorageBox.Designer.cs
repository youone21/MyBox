namespace MyBox
{
    partial class StorageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.Font = new System.Drawing.Font(
                "Consolas",
                9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Pixel, ((byte)(134))
                );
            //this.Font = new System.Drawing.Font(
            //    "Microsoft Sans Serif",
            //    12F, System.Drawing.FontStyle.Regular,
            //    System.Drawing.GraphicsUnit.Pixel, ((byte)(134))
            //    );
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.txt_add = new System.Windows.Forms.Button();
            this.txt_typeName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabC_ctx = new System.Windows.Forms.TabControl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.txt_Search);
            this.groupBox1.Controls.Add(this.txt_add);
            this.groupBox1.Controls.Add(this.txt_typeName);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1060, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "类别名称";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(792, 23);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 47);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "查找";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(560, 30);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(226, 22);
            this.txt_Search.TabIndex = 2;
            // 
            // txt_add
            // 
            this.txt_add.Location = new System.Drawing.Point(262, 23);
            this.txt_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_add.Name = "txt_add";
            this.txt_add.Size = new System.Drawing.Size(75, 47);
            this.txt_add.TabIndex = 1;
            this.txt_add.Text = "添加";
            this.txt_add.UseVisualStyleBackColor = true;
            this.txt_add.Click += new System.EventHandler(this.txt_add_Click);
            // 
            // txt_typeName
            // 
            this.txt_typeName.Location = new System.Drawing.Point(94, 30);
            this.txt_typeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_typeName.Name = "txt_typeName";
            this.txt_typeName.Size = new System.Drawing.Size(148, 22);
            this.txt_typeName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tabC_ctx);
            this.groupBox2.Location = new System.Drawing.Point(12, 112);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1060, 546);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "内容";
            // 
            // tabC_ctx
            // 
            this.tabC_ctx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabC_ctx.Location = new System.Drawing.Point(3, 19);
            this.tabC_ctx.Name = "tabC_ctx";
            this.tabC_ctx.SelectedIndex = 0;
            this.tabC_ctx.Size = new System.Drawing.Size(1054, 523);
            this.tabC_ctx.TabIndex = 0;
            // 
            // StorageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 671);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            //this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1100, 710);
            this.Name = "StorageBox";
            this.Text = "收纳箱";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button txt_add;
        private System.Windows.Forms.TextBox txt_typeName;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabC_ctx;
    }
}