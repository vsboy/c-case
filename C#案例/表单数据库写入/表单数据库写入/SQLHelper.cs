using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace 表单数据库写入
{
    class SQLHelper
    {
        string connectionStr = "Data Source=.;Initial Catalog=MyQQ2;integrated security=SSPI";
        SqlConnection conn;
        public SQLHelper()
        {
            conn = new SqlConnection(connectionStr);
            conn.Open();
        }
        public object ExSca(string sqlText)//返回结果查询的第一行第一列
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlCommand comd = new SqlCommand(sqlText, conn);
            object o = comd.ExecuteScalar();
            conn.Close();
            return o;
        }
        public int ExNonQuary(string sqlText)//执行非查询（增删改）操作，返回
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlCommand comd = new SqlCommand(sqlText, conn);
            int count = comd.ExecuteNonQuery();
            conn.Close();
            return count;
        }
        public SqlDataReader ExcDataReader(string sqlText)//返回查询的第一行
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
            conn.Open();
            SqlCommand comd = new SqlCommand(sqlText, conn);
            SqlDataReader dr = comd.ExecuteReader();
            //conn.Close();

            return dr;
        }
    }
}
