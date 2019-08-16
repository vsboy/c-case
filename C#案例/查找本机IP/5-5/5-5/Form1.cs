using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace _5_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Add(Dns.GetHostName());
            IPAddress[] myIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress ip in myIP)
            {
                listBox1.Items.Add(ip);
            }
        }
    }
}
