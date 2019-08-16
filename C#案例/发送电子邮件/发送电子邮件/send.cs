using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace 发送电子邮件
{
    public partial class send : Form
    {
        public SmtpClient client;
        public string sendAdd;
        MailMessage mail;
        public send()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //选择附件添加到列表框
            mail = new MailMessage(sendAdd, textBox1.Text);
            mail.Subject = textBox3.Text;
            mail.Body = textBox4.Text;
            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;//多选
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < ofd.FileNames.Length; i++)
                {
                    listBox1.Items.Add(ofd.FileNames[i]);
                    Attachment att = new Attachment(ofd.FileNames[i]);
                    mail.Attachments.Add(att);
                }
            }
            //抄送地址
            string[] address=(textBox2.Text).Split(',');
            foreach (string s in address)
            {
                MailAddress add=new MailAddress(s);
                mail.CC.Add(add);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //发送电子邮件
            try
            {
                client.Send(mail);
                MessageBox.Show("邮件发送成功！");
                //清除邮件信息

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
