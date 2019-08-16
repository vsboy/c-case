using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 性别选择
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        private string value;

        public string Value
        {
            get {
                value = radioButton1.Checked ? "男" : "女";
                label1.Text = value;
                return this.value; }
            set { this.value = value;
            if (value == "男")
                radioButton1.Checked = true;
            if(value=="女")
                radioButton2.Checked = true;
            label1.Text = value;
            }
        }
    }
}
