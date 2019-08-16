using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;//oledb数据库命名空间
//word操作相关的命名空间
using Microsoft.Office;
using Microsoft.Office.Interop.Word;
using Word = Microsoft.Office.Interop.Word;//别名

namespace excel改分
{
    public partial class Form1 : Form
    {
        string path;
        string fileName;
        System.Data.DataTable dtExcel = new System.Data.DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void 选择要处理的文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                path = fbd.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
                string strConn = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties = 'Excel 8.0;HDR=YES;IMEX=1'";
                //创建连接
                OleDbConnection conn = new OleDbConnection(strConn);
                //打开连接
                conn.Open();
                //数据操作
                System.Data.DataTable dt = conn.GetSchema("tables");
                DataTableReader dtr = new DataTableReader(dt);
                while (dtr.Read())
                {
                    comboBox1.Items.Add( dtr["Table_Name"].ToString());
                }
                //关闭连接
                conn.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //把对应工作表中的数据显示在数据网格中
            dataGridView1.DataSource= null;
            GetExcelData(comboBox1.SelectedItem.ToString());

        }
        private void GetExcelData(string sheetName)
        {
            string strConn = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties = 'Excel 8.0;HDR=YES;IMEX=1'";
            //创建连接
            OleDbConnection conn = new OleDbConnection(strConn);
            //打开连接
            conn.Open();
            //数据操作
            string ExcelSql = "select * from [" + sheetName + "]";
            //string ExcelSql = string.Format("select * from [{0}]", sheetName);
            OleDbDataAdapter da = new OleDbDataAdapter(ExcelSql,conn);
            da.Fill(dtExcel);
            dataGridView1.DataSource=dtExcel;
            //关闭连接
            conn.Close();
            progressBar1.Maximum = dtExcel.Rows.Count;
        }

        private void 处理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //找到对应的word文档，作对应处理
            string subPath="";
            string wordPath = path;
            Word.Application app = new Word.Application();//创建一个word应用
            //for (int i = 0; i < 1; i++)
            for (int i = 0; i < dtExcel.Rows.Count; i++)
            {
                subPath=((dtExcel.Rows[i]).ItemArray)[0].ToString();
                wordPath = path + @"\" + subPath + @"\试卷.doc";
                Word.Document doc = new Document();
                doc = app.Documents.Open(wordPath);
                //处理文档
                //label2.Text=doc.Paragraphs[2].Range.Text;
                string temp = doc.Paragraphs[2].Range.Text;
                temp=temp.Substring(0, temp.LastIndexOf('：')+1);//最后一个冒号的位置temp.LastIndexOf(':')
                string temp2;
                temp2 = temp + dtExcel.Rows[i].ItemArray[9].ToString()+Environment.NewLine;
                doc.Paragraphs[2].Range.Text = temp2;//修改后的数据放回

                doc.Paragraphs.Last.Range.Text = "编程题得分：" + dtExcel.Rows[i].ItemArray[8].ToString();//文档底部编程题得分信息插入
                object p=System.Reflection.Missing.Value;
                doc.Paragraphs.Add(ref p);
                //关闭文档
                doc.Save();
                doc.Close();
                progressBar1.Value = i + 1;
            }
            label1.Text = "word打开成功！";
            //关闭word应用
        }
    }
}
