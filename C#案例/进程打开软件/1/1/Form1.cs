using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
            
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeprocess("calc");
        }

        private void 打开ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("WINWORD");  
        }
        private void closeprocess(string name)
        {
            Process[] p = Process.GetProcessesByName(name);
            foreach (Process pp in p)
            {
                if (pp.Responding)
                    pp.CloseMainWindow();
                else pp.Kill();
            }
        }

        private void 显示所有进程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process[] p= Process.GetProcesses();
            foreach (Process pp in p)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = pp.ProcessName;
                lv.SubItems.Add(pp.VirtualMemorySize64.ToString());
                listView1.Items.Add(lv);
            }
        }

        private void 进程管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 打开百度ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("iexplore", "http://www.baidu.com");
        }

        private void 计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
