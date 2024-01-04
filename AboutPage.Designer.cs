namespace EasyBackup
{
    partial class AboutPage
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            aboutLable0 = new Label();
            aboutLable1 = new Label();
            linkLabel0 = new LinkLabel();
            aboutLabel2 = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            SuspendLayout();
            // 
            // aboutLable0
            // 
            aboutLable0.AutoSize = true;
            aboutLable0.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            aboutLable0.Location = new Point(13, 12);
            aboutLable0.Name = "aboutLable0";
            aboutLable0.Size = new Size(62, 31);
            aboutLable0.TabIndex = 0;
            aboutLable0.Text = "关于";
            // 
            // aboutLable1
            // 
            aboutLable1.AutoSize = true;
            aboutLable1.Location = new Point(13, 43);
            aboutLable1.Name = "aboutLable1";
            aboutLable1.Size = new Size(116, 17);
            aboutLable1.TabIndex = 1;
            aboutLable1.Text = "EasyBackup V1.0.0\r\n";
            // 
            // linkLabel0
            // 
            linkLabel0.ActiveLinkColor = Color.Black;
            linkLabel0.AutoSize = true;
            linkLabel0.LinkColor = Color.Black;
            linkLabel0.Location = new Point(13, 93);
            linkLabel0.Name = "linkLabel0";
            linkLabel0.Size = new Size(32, 17);
            linkLabel0.TabIndex = 2;
            linkLabel0.TabStop = true;
            linkLabel0.Text = "官网";
            linkLabel0.VisitedLinkColor = Color.Black;
            linkLabel0.LinkClicked += linkLabel0_LinkClicked;
            // 
            // aboutLabel2
            // 
            aboutLabel2.AutoSize = true;
            aboutLabel2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            aboutLabel2.Location = new Point(13, 71);
            aboutLabel2.Name = "aboutLabel2";
            aboutLabel2.Size = new Size(74, 22);
            aboutLabel2.TabIndex = 3;
            aboutLabel2.Text = "友情链接";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Black;
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(51, 93);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(46, 17);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Github";
            linkLabel1.VisitedLinkColor = Color.Black;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.Black;
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(103, 93);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(38, 17);
            linkLabel2.TabIndex = 5;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Gitee";
            linkLabel2.VisitedLinkColor = Color.Black;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // AboutPage
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 370);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(aboutLabel2);
            Controls.Add(linkLabel0);
            Controls.Add(aboutLable1);
            Controls.Add(aboutLable0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutPage";
            Padding = new Padding(10, 12, 10, 12);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "关于";
            Load += AboutPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label aboutLable0;
        private Label aboutLable1;
        private LinkLabel linkLabel0;
        private Label aboutLabel2;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}
