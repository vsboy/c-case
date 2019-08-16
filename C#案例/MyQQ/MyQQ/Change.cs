using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyQQ
{
    public partial class Change : Form
    {
        public string MainUserID;
        public Change()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLHelper s = new SQLHelper();
            //string strSql = string.Format("update qq_User set nickName=10001 where userId=10000");
            string strSql = string.Format("update qq_User set nickName='{0}',personalMsg='{1}',sex='{2}' where userId='{3}'", textBox1.Text, textBox2.Text, radioButton2.Text,Convert.ToInt32(MainUserID));
            //string strSql = string.Format("update qq_User set nickName='{0}' personalMsg='{1}' sex='{2}' where userId='{3}'", textBox1.Text, textBox2.Text, radioButton2.Text, Convert.ToInt32(MainUserID));

            MessageBox.Show("修改代码成功返回1，失败0：" + Convert.ToInt16(s.ExNonQuary(strSql)));
        }
    }
}
