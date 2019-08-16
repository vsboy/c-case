using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyQQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pboxLogin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                //提示为空
                MessageBox.Show("您输入为空", "提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            //else if (textBox1.Text == "1000" && textBox2.Text == "123456")
            //{
            //    //转跳到主窗口
            //    main main1 = new main();
            //    main1.Show();
            //}
            //else
            //{
            //    MessageBox.Show("错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    //输入错误
            //}
            //string ConnectionString = "Data Source=.;Initial Catalog=MyQQ2;integrated security=SSPI";
            //SqlConnection conn = new SqlConnection(ConnectionString);
            //conn.Open();
            //MessageBox.Show("数据库连接成功");
            //连接数据库
            SQLHelper s = new SQLHelper();
            string strSql = string.Format("select * from qq_User where userId={0} and userPwd={1}",textBox1.Text,textBox2.Text);
            //SqlCommand comd=new SqlCommand(strSql,conn);
            object cont = s.ExSca(strSql);
            
            if (cont != null)
            {
                //登陆成功
                main main1 = new main(textBox1.Text);
                main1.Show();
            }
            else
            {
                MessageBox.Show("您输入的用户名密码错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
            //conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register main1 = new register();
            main1.Show();
        }

        private void pboxClose_Click(object sender, EventArgs e)
        {

        }
    }
}
