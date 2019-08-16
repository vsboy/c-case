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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string ConnectionString = "Data Source=.;Initial Catalog=MyQQ2;integrated security=SSPI";
            //SqlConnection conn = new SqlConnection(ConnectionString);
            //conn.Open();
            //MessageBox.Show("数据库连接成功");
            //连接数据库
            SQLHelper s = new SQLHelper();
            string strSql = string.Format("insert into qq_User(userPwd,nickName,age,sex,realName,email,personalMsg,regTime,face) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}') select @@IDENTITY", textBox3.Text, textBox1.Text, textBox2.Text, radioButton2.Text, textBox5.Text, textBox6.Text, textBox7.Text, DateTime.Now.ToLongTimeString(),Convert.ToInt16(fn));
            MessageBox.Show("恭喜您注册成功！QQ号码为" + Convert.ToInt16(s.ExSca(strSql)));
        }
        String fn = "1";
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //打开头像选择窗体
            //String fn="1";
            Face f = new Face(pictureBox1);
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                fn=f.str;
                //this.textBox1.Text=f.str;
            }
            main m = new main();
            pictureBox1.Image = m.imageList1.Images[Convert.ToInt32(fn) - 1];
        }

        private void register_Load(object sender, EventArgs e)
        {

        }
    }
}
