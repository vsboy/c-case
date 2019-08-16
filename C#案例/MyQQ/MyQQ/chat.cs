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
    public partial class chat : Form
    {
        public string MainUserID, ChatFriendID;
        public chat()
        {
            InitializeComponent();
        }

        private void chat_DoubleClick(object sender, EventArgs e)
        {

        }

        private void chat_Load(object sender, EventArgs e)
        {
            //label1.Text = MainUserID;
            //label2.Text = ChatFriendID;
            //加载聊天好友的相关信息：头像、昵称、个性签名
            LoadFriendInfo();
            //加载当前好友发送的未读消息
            LoadMessage(); 
        }
        private void SendMessage()
        {
            //把消息加入上文本框（注意格式）
            
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            DateTime d = DateTime.Now;
            richTextBox1.AppendText(d.ToString());
            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.SelectionColor = Color.Blue;
            richTextBox1.AppendText(richTextBox2.Text);
            richTextBox1.AppendText(Environment.NewLine);
            
            //把消息传入数据库
            string sql3 = string.Format("insert into qq_Messages(fromId,toId,mInfo,state,sendTime) values('{0}','{1}','{2}',0,'{3}')",MainUserID,ChatFriendID,richTextBox2.Text,d);
            SQLHelper s3 = new SQLHelper();
            s3.ExNonQuary(sql3);
            richTextBox2.Text = "";

        }
        private void LoadMessage()
        {
            string sql = string.Format("select * from qq_Messages where fromId='{0}' and toId='{1}' and state=0",ChatFriendID,MainUserID);
            SQLHelper s = new SQLHelper();
            SqlDataReader sdr = s.ExcDataReader(sql);
            while (sdr.Read())//读取消息
            {
                //读取时间
                richTextBox1.SelectionColor = Color.Black;
                richTextBox1.AppendText(sdr["sendTime"].ToString());
                richTextBox1.AppendText(Environment.NewLine);
                //消息
                richTextBox1.SelectionColor = Color.Green;
                richTextBox1.SelectionFont=new Font(richTextBox1.Font.FontFamily,20);
                richTextBox1.AppendText(sdr["mInfo"].ToString());
                richTextBox1.AppendText(Environment.NewLine);
                //修改消息状态
                string sql1=string.Format("update qq_Messages set state=1 where fromId='{0}' and toId='{1}'",ChatFriendID,MainUserID);
                SQLHelper s1 = new SQLHelper();
                s1.ExNonQuary(sql1);
            }
        }
        private void LoadFriendInfo()
        {
            string sql = "select * from qq_User where userId="+ChatFriendID;
            SQLHelper s = new SQLHelper();
            SqlDataReader sdr=s.ExcDataReader(sql);
            sdr.Read();
            label1.Text = sdr[2].ToString();
            label2.Text = sdr["personalMsg"].ToString();
            main m=new main();
            pictureBox1.Image=m.imageList1.Images[Convert.ToInt32(sdr["face"])];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
