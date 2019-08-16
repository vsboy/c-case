using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;//发送电子邮件

namespace 发送电子邮件
{
    public partial class Form1 : Form
    {
        SmtpClient mailClient;//创建一个邮件客户端的实例
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mailClient = new SmtpClient("smtp.qq.com",25);//初始化邮件服务器（服务器，端口）
            mailClient.EnableSsl = true;//加密连接
            mailClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            mailClient.Credentials = new System.Net.NetworkCredential(textBox2.Text,textBox1.Text);
            //创建电子邮件
            MailMessage mail = new MailMessage(textBox2.Text,textBox2.Text);
            mail.Subject = "test";
            mail.Body = "hello";
            //发送电子邮件
            try
            {
                //mailClient.Send(mail);//给自己发送一封test邮件
                //打开发送邮件窗体
                send send = new send();
                //传递数据
                send.client = mailClient;
                send.sendAdd = textBox2.Text;
                send.ShowDialog();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
