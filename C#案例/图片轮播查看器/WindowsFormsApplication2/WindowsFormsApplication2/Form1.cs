using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        int i = 1;
        Thread th;
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 1)
                i = 6;
            pictureBox1.Image = Image.FromFile(i.ToString()+".png");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            i++;
            if (i > 6)
                i = 1;
            pictureBox1.Image = Image.FromFile(i.ToString() + ".png");
        }
        //自动播放的方法
        private void AutoPlay()
        {
            while (true)
            {
                i++;
                if (i > 6)
                    i = 1;
                pictureBox1.Image = Image.FromFile(i.ToString() + ".png");
                Thread.Sleep(1000);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            th = new Thread(AutoPlay);
            th.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            th.Suspend();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            th.Resume();
        }
    }
}
