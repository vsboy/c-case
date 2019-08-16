using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Core;//引用中需要添加
using Microsoft.Office.Interop.Excel;
using Excel=Microsoft.Office.Interop.Excel;//创建别名

namespace excel操作
{
    public partial class Form1 : Form
    {
        string score = "";
        Excel.Application excelApp;
        Excel.Workbooks excelBooks;
        Excel.Workbook excelBook;
        Excel.Worksheet excelSheet;
        string fileName = "";//excel文件的路径
        Random r = new Random();//定义一个随机种子
        string sno = "";//当前点名人的信息
        int nameIndex;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void initPic()
        {
            //五个星星变灰色
            pictureBox2.Image = Image.FromFile("star1.png");
            pictureBox3.Image = Image.FromFile("star1.png");
            pictureBox4.Image = Image.FromFile("star1.png");
            pictureBox5.Image = Image.FromFile("star1.png");
            pictureBox6.Image = Image.FromFile("star1.png");
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            initPic();
            pictureBox2.Image = Image.FromFile("star2.png");
            score = "不合格";
            label1.Text = score;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            initPic();
            pictureBox2.Image = Image.FromFile("star2.png");
            pictureBox3.Image = Image.FromFile("star2.png");
            score = "合格";
            label1.Text = score;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            initPic();
            pictureBox2.Image = Image.FromFile("star2.png");
            pictureBox3.Image = Image.FromFile("star2.png");
            pictureBox4.Image = Image.FromFile("star2.png");
            score = "中等";
            label1.Text = score;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            initPic();
            pictureBox2.Image = Image.FromFile("star2.png");
            pictureBox3.Image = Image.FromFile("star2.png");
            pictureBox4.Image = Image.FromFile("star2.png");
            pictureBox5.Image = Image.FromFile("star2.png");
            score = "良好";
            label1.Text = score;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            initPic();
            pictureBox2.Image = Image.FromFile("star2.png");
            pictureBox3.Image = Image.FromFile("star2.png");
            pictureBox4.Image = Image.FromFile("star2.png");
            pictureBox5.Image = Image.FromFile("star2.png");
            pictureBox6.Image = Image.FromFile("star2.png");
            score = "优秀";
            label1.Text = score;
        }

        private void 导入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //读取Excel，放到列表框
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    LoadExcel(ofd.FileName);
                    fileName = ofd.FileName;
                }
                catch
                {
                    MessageBox.Show("打开文件失败！");
                }
            }
        }
        private void LoadExcel(string filename)
        {
            //Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            //Excel.Application app = new Excel.Application();
            excelApp = new Excel.Application();
            excelBooks = excelApp.Workbooks;
            excelBook = excelBooks.Add(filename);
            excelSheet = excelBook.Sheets[1];

            //提取Excel表中数据
            int i = 1;
            Excel.Range range = excelSheet.Cells[i, 1];
            label2.Text = range.Value;
            string row="";
            while (range.Value != null)
            {
                row=range.Value;
                range=excelSheet.Cells[i,2];
                row+=range.Value;
                listBox1.Items.Add(row);
                i++;
                range = excelSheet.Cells[i, 1];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "点名")
            {
                button1.Text = "停止点名";//文字变化
                initPic();
                timer1.Enabled = true;//计时器开始
                stopPic();//打分禁用
                //把打分信息放入excel（内存）
                if(score!="")
                    WriteExcel();
            }
            else
            {
                button1.Text = "点名";//文字变化
                timer1.Enabled = false;//计时器停止
                startPic();//打分开启
                //记录选中名单信息——行
                nameIndex = listBox1.SelectedIndex+1;
            }
        }
        private void WriteExcel()
        {
            Excel.Range range=excelSheet.Cells[nameIndex,3];
            range.Value = score;
        }
        private void startPic()
        {
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
        }
        private void stopPic()
        {
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            listBox1.SelectedIndex = r.Next(1, listBox1.Items.Count);//文本信息变化
            //图像信息变化
            sno=(listBox1.SelectedItem.ToString()).Substring(0,10);
            pictureBox1.Image = Image.FromFile(@"photo\\"+sno+".jpg");//注意转译字符
        }

        private void 快ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 50;
        }

        private void 中ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
        }

        private void 慢ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 300;
        }

        private void 下课ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteExcel();
            //保存excel到外存
            //写入当前信息作为列标题
            excelBook.SaveAs(fileName, Type.Missing, "", "", Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,1, false, Type.Missing, Type.Missing, Type.Missing);

        }
    }
}
