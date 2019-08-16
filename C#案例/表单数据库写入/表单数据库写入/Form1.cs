using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 表单数据库写入
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLHelper s = new SQLHelper();
            //string strSql = string.Format("insert into qq_User(nickName,sex) values('{0}','{1}') select @@IDENTITY", textBox1.Text, radioButton1.Checked ? "男" : "女");
            //MessageBox.Show("账号：" + Convert.ToInt16(s.ExSca(strSql)));
            string strSql = string.Format("insert into qq_User(userPwd,nickName,age,sex,realName,email,personalMsg,regTime,face) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}') select @@IDENTITY", textBox1.Text, textBox1.Text, textBox1.Text, radioButton1.Checked ? "男" : "女", textBox1.Text, textBox1.Text, textBox1.Text, DateTime.Now.ToLongTimeString(),'2');
            MessageBox.Show("恭喜您注册成功！QQ号码为" + Convert.ToInt16(s.ExSca(strSql)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLHelper a = new SQLHelper();
            string strSql = string.Format("update qq_User set nickName='{0}',personalMsg='{1}',sex='{2}' where userId='{3}'", textBox1.Text, textBox1.Text, radioButton1.Checked ? "男" : "女", textBox2.Text);
            MessageBox.Show("修改代码成功返回1，失败0：" + Convert.ToInt16(a.ExNonQuary(strSql)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SQLHelper a = new SQLHelper();
            string strSql = string.Format("delete from qq_User where userId='{0}'",textBox2.Text);
            MessageBox.Show("修改代码成功返回1，失败0：" + Convert.ToInt16(a.ExNonQuary(strSql)));
        }
    }
}
