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
    public partial class Face : Form
    {
        public Face()
        {
            InitializeComponent();
        }
        //改造构造函数
        public Face(PictureBox p1)
        {
            this.pictureBox1 = p1;
            InitializeComponent();
        }

        private string facenumber;

        public string Facenumber
        {
            get { return facenumber; }
            set { facenumber = value; }
        }

        private void Face_Load(object sender, EventArgs e)
        {
            main m=new main();
            listView1.LargeImageList=m.imageList1;
            for (int i = 0; i < 100; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.ImageIndex = i;
                lvi.Text = (i+1).ToString();
                listView1.Items.Add(lvi);
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                main m=new main();
                pictureBox1.Image = m.imageList1.Images[Convert.ToInt32(listView1.SelectedItems[0].Text)-1];
            }
        }
        public string str;
        public string Str
        {
            get { return this.str; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            str = this.listView1.SelectedItems[0].Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
