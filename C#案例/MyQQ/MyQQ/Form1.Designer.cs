namespace MyQQ
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.pboxMin = new System.Windows.Forms.PictureBox();
            this.pboxClose = new System.Windows.Forms.PictureBox();
            this.pboxLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(135, 200);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 14);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(135, 231);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(191, 14);
            this.textBox2.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel1.Location = new System.Drawing.Point(343, 221);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(53, 12);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "申请账号";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(135, 260);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "记住密码";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(254, 260);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 16);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "自动登录";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // pboxMin
            // 
            this.pboxMin.BackColor = System.Drawing.Color.Transparent;
            this.pboxMin.Location = new System.Drawing.Point(375, 1);
            this.pboxMin.Name = "pboxMin";
            this.pboxMin.Size = new System.Drawing.Size(27, 28);
            this.pboxMin.TabIndex = 5;
            this.pboxMin.TabStop = false;
            // 
            // pboxClose
            // 
            this.pboxClose.BackColor = System.Drawing.Color.Transparent;
            this.pboxClose.Location = new System.Drawing.Point(402, 1);
            this.pboxClose.Name = "pboxClose";
            this.pboxClose.Size = new System.Drawing.Size(27, 28);
            this.pboxClose.TabIndex = 6;
            this.pboxClose.TabStop = false;
            this.pboxClose.Click += new System.EventHandler(this.pboxClose_Click);
            // 
            // pboxLogin
            // 
            this.pboxLogin.BackColor = System.Drawing.Color.Transparent;
            this.pboxLogin.Location = new System.Drawing.Point(135, 286);
            this.pboxLogin.Name = "pboxLogin";
            this.pboxLogin.Size = new System.Drawing.Size(191, 33);
            this.pboxLogin.TabIndex = 7;
            this.pboxLogin.TabStop = false;
            this.pboxLogin.Click += new System.EventHandler(this.pboxLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyQQ.Properties.Resources.login;
            this.ClientSize = new System.Drawing.Size(432, 331);
            this.ControlBox = false;
            this.Controls.Add(this.pboxLogin);
            this.Controls.Add(this.pboxClose);
            this.Controls.Add(this.pboxMin);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.PictureBox pboxMin;
        private System.Windows.Forms.PictureBox pboxClose;
        private System.Windows.Forms.PictureBox pboxLogin;
    }
}

