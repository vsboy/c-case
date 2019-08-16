using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _4_26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.DrawMode = DrawMode.OwnerDrawFixed;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            //获取要在其上绘制项的图形表面
            Graphics g = e.Graphics;
            //获取表示所绘制项的边界的矩形
            System.Drawing.Rectangle rect = e.Bounds;
            //定义要绘制到控件中的图标图像
            Image ico = Image.FromFile("头像2.png");
            //定义字体对象
            System.Drawing.Font font = new Font("宋体", 40);
            if (e.Index >= 0)
            {
                string temp = comboBox1.Items[e.Index].ToString();
                if (e.State == DrawItemState.None)
                {
                    SolidBrush sb = new SolidBrush(Color.FromArgb(200,230,255));
                    g.FillRectangle(sb, rect);
                    g.DrawImage(ico,new Point(rect.Left,rect.Top));
                    SolidBrush sb2=new SolidBrush(Color.Black);
                    g.DrawString(temp,font,sb2,rect.Left+ico.Width,rect.Top);
                    e.DrawFocusRectangle();
                }
                else { 
                    SolidBrush sb = new SolidBrush(Color.LightBlue);
                    g.FillRectangle(sb, rect);
                    g.DrawImage(ico,new Point(rect.Left,rect.Top));
                    SolidBrush sb2=new SolidBrush(Color.Black);
                    g.DrawString(temp,font,sb2,rect.Left+ico.Width,rect.Top);
                    e.DrawFocusRectangle();
                }
            }
        }
    }
}
