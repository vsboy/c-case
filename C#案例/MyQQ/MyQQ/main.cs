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
    public partial class main : Form
    {
        string userid;
        User User = new User();
        public main()
        {
            InitializeComponent();
        }
        public main(string userID)
        {
            userid = userID;
            InitializeComponent();
        }
        public void getFriendList()
        {
            //创建分组
            ListViewGroup lvg1 = new ListViewGroup();
            lvg1.Header = "好友";
            ListViewGroup lvg2 = new ListViewGroup();
            lvg2.Header = "陌生人";
            ListViewGroup lvg3 = new ListViewGroup();
            lvg3.Header = "黑名单";
            listView1.Groups.Add(lvg1);
            listView1.Groups.Add(lvg1);
            listView1.Groups.Add(lvg1);

            SQLHelper s = new SQLHelper();
            string sql = string.Format("select * from qq_Friends where hostId='{0}' ",userid);
            SqlDataReader sdr = s.ExcDataReader(sql);
            while (sdr.Read())
            {
                SQLHelper s1=new SQLHelper();
                string sqlSelect="select * from qq_User where userId="+sdr[2].ToString();
                User friend=new User();
                SqlDataReader dr=s1.ExcDataReader(sqlSelect);
                dr.Read();
                ListViewItem lvi=new ListViewItem();
                lvi.Name=dr[0].ToString();//将好友ID赋值给Name
                lvi.ImageIndex=Convert.ToInt32(dr["face"]);//头像符号
                lvi.Text=dr["nickName"].ToString();
                listView1.Items.Add(lvi);
                if (Convert.ToInt32(sdr[3]) == 0)//陌生人
                    lvi.Group = listView1.Groups[0];
                else if (Convert.ToInt32(sdr[3]) == 1)//好友
                    lvi.Group = listView1.Groups[0];
                else
                    lvi.Group = listView1.Groups[2];//黑名单
            }
        }
        private void main_Load(object sender, EventArgs e)
        {
            //加载个人信息
            getUserInfo();
            getFriendList();
        }
        public void getUserInfo()
        {
            //加载个人信息
            //User User = new User();
            User.UserId = userid;
            SQLHelper s = new SQLHelper();
            SqlDataReader dr=s.ExcDataReader("select * from qq_User where userId=" +userid);
            dr.Read();//通过read方法一次读取一行数据                                                                                    
            User.UserPwd = dr[1].ToString();
            User.NickName = dr[2].ToString();
            User.RealName=dr[3].ToString();
            User.PersonalMsg=dr[4].ToString();
            User.Age = Convert.ToInt32(dr[5]);
            User.Sex = dr[6].ToString();
            User.Email = dr[7].ToString();
            User.Face = Convert.ToInt32(dr[8]);
            label1.Text = User.NickName;
            label2.Text = User.PersonalMsg;
            pictureBox1.Image = imageList1.Images[User.Face-1];
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Change from1 = new Change();
            from1.MainUserID = userid;
            from1.Show();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            chat c = new chat();
            c.MainUserID = userid;
            c.ChatFriendID = listView1.SelectedItems[0].Name;//直选中一个，所以是0号
            c.Show();
        }
    } 
}
