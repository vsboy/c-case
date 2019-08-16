namespace WindowsFormsApplication1
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.进程管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.画图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.百度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.显示所有进程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.进程管理ToolStripMenuItem,
            this.显示所有进程ToolStripMenuItem,
            this.listviewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(647, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 进程管理ToolStripMenuItem
            // 
            this.进程管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.计算器ToolStripMenuItem,
            this.画图ToolStripMenuItem,
            this.百度ToolStripMenuItem});
            this.进程管理ToolStripMenuItem.Name = "进程管理ToolStripMenuItem";
            this.进程管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.进程管理ToolStripMenuItem.Text = "进程管理";
            // 
            // 计算器ToolStripMenuItem
            // 
            this.计算器ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.关闭ToolStripMenuItem});
            this.计算器ToolStripMenuItem.Name = "计算器ToolStripMenuItem";
            this.计算器ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.计算器ToolStripMenuItem.Text = "计算器";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关闭ToolStripMenuItem.Text = "关闭";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.关闭ToolStripMenuItem_Click);
            // 
            // 画图ToolStripMenuItem
            // 
            this.画图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem1,
            this.关闭ToolStripMenuItem1});
            this.画图ToolStripMenuItem.Name = "画图ToolStripMenuItem";
            this.画图ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.画图ToolStripMenuItem.Text = "画图";
            // 
            // 打开ToolStripMenuItem1
            // 
            this.打开ToolStripMenuItem1.Name = "打开ToolStripMenuItem1";
            this.打开ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.打开ToolStripMenuItem1.Text = "打开";
            this.打开ToolStripMenuItem1.Click += new System.EventHandler(this.打开ToolStripMenuItem1_Click);
            // 
            // 关闭ToolStripMenuItem1
            // 
            this.关闭ToolStripMenuItem1.Name = "关闭ToolStripMenuItem1";
            this.关闭ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.关闭ToolStripMenuItem1.Text = "关闭";
            this.关闭ToolStripMenuItem1.Click += new System.EventHandler(this.关闭ToolStripMenuItem1_Click);
            // 
            // 百度ToolStripMenuItem
            // 
            this.百度ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem2});
            this.百度ToolStripMenuItem.Name = "百度ToolStripMenuItem";
            this.百度ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.百度ToolStripMenuItem.Text = "百度";
            // 
            // 打开ToolStripMenuItem2
            // 
            this.打开ToolStripMenuItem2.Name = "打开ToolStripMenuItem2";
            this.打开ToolStripMenuItem2.Size = new System.Drawing.Size(100, 22);
            this.打开ToolStripMenuItem2.Text = "打开";
            this.打开ToolStripMenuItem2.Click += new System.EventHandler(this.打开ToolStripMenuItem2_Click);
            // 
            // 显示所有进程ToolStripMenuItem
            // 
            this.显示所有进程ToolStripMenuItem.Name = "显示所有进程ToolStripMenuItem";
            this.显示所有进程ToolStripMenuItem.Size = new System.Drawing.Size(130, 21);
            this.显示所有进程ToolStripMenuItem.Text = "listbox显示所有进程";
            this.显示所有进程ToolStripMenuItem.Click += new System.EventHandler(this.显示所有进程ToolStripMenuItem_Click);
            // 
            // listviewToolStripMenuItem
            // 
            this.listviewToolStripMenuItem.Name = "listviewToolStripMenuItem";
            this.listviewToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.listviewToolStripMenuItem.Text = "listview显示";
            this.listviewToolStripMenuItem.Click += new System.EventHandler(this.listviewToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Location = new System.Drawing.Point(0, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(642, 244);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "进程名";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "进程标识";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "线程数";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "内存";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "虚拟内存";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(0, 278);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(642, 76);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 368);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 进程管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 画图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 百度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripMenuItem 显示所有进程ToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripMenuItem listviewToolStripMenuItem;
    }
}

