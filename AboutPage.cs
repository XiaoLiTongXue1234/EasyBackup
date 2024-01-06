namespace EasyBackup
{
    partial class AboutPage : Form
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void AboutPage_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Util.Open_Website("https://www.baidu.com");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Util.Open_Website("https://github.com/XiaoLiTongXue1234/EasyBackup");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Util.Open_Website("https://gitee.com/XiaoLiTongXue1234/EasyBackup");
        }
    }
}
