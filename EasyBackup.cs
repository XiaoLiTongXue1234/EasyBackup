using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBackup
{
    public partial class EasyBackup : Form
    {
        private ConfigManager configManager;
        public EasyBackup()
        {
            InitializeComponent();
            this.configManager = new ConfigManager("config/EasyBackup.config");
        }
        private void EasyBackup_Load(object sender, EventArgs e)
        {
            this.homePanel.Visible = true;
            this.settingsPanel.Visible = false;
            this.othersPanel.Visible = false;
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.homePanel.Visible = true;
            this.settingsPanel.Visible = false;
            this.othersPanel.Visible = false;
        }

        private void settings_Click(object sender, EventArgs e)
        {
            this.homePanel.Visible = false;
            this.settingsPanel.Visible = true;
            this.othersPanel.Visible = false;
        }
        private void others_Click(object sender, EventArgs e)
        {
            this.homePanel.Visible = false;
            this.settingsPanel.Visible = false;
            this.othersPanel.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                this.textBox1.Text = selectedPath;
            }
        }

        private void about_Click(object sender, EventArgs e)
        {
            AboutPage aboutPage=new AboutPage();
            aboutPage.ShowDialog();
        }
    }
}
