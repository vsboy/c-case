using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;//诊断系统

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void closeProcess(string name)//关闭函数封装
        {
            Process[] p = Process.GetProcessesByName(name);
            foreach (Process pp in p)
            {
                if (pp.Responding)
                    pp.CloseMainWindow();
                else
                    pp.Kill();
            }
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }

        private void 打开ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Process.Start("iexplore", "http://www.baidu.com");
        }

        private void 打开ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint");
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process[] p = Process.GetProcessesByName("calc");
            foreach (Process pp in p)
            {
                if (pp.Responding)
                    pp.CloseMainWindow();
                else
                    pp.Kill();
            }
        }

        private void 关闭ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            closeProcess("mspaint");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void 显示所有进程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process[] p =Process.GetProcesses();
            foreach (Process myPoc in p)
            {
                listBox1.Items.Add(myPoc.ProcessName+"|"+myPoc.WorkingSet.ToString());
            }
        }

        private void listviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process[] p = Process.GetProcesses();
            foreach (Process myPro in p)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = myPro.ProcessName;
                lvi.SubItems.Add(myPro.Id.ToString());
                lvi.SubItems.Add(myPro.Threads.Count.ToString());
                lvi.SubItems.Add(myPro.WorkingSet64.ToString());
                lvi.SubItems.Add(myPro.VirtualMemorySize64.ToString());
                listView1.Items.Add(lvi);
            }
        }
    }
}
