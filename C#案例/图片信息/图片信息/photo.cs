using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace 图片信息
{
    public partial class photo : UserControl
    {
        public photo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //放图片
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                //获取图片相关信息
                label4.Text=Path.GetFileName(ofd.FileName);//获取文件名
                FileInfo f = new FileInfo(ofd.FileName);
                label5.Text = (f.Length/1024.0).ToString("0.00")+"KB";//文件大小
                label6.Text = pictureBox1.Image.Width + "x" + pictureBox1.Image.Height;//图片尺寸
            }
            else
                MessageBox.Show("出错");
        }
    }
}
