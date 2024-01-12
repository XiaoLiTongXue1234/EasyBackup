using System.IO;

namespace EasyBackup
{
    public partial class MainPages : Form
    {
        private BackupManager backupManager;
        public MainPages()
        {
            InitializeComponent();
            this.backupManager = new BackupManager("config/easybackup.config.json", "config/BackupFiles.config.json");
        }
        private void EasyBackup_Load(object sender, EventArgs e)
        {
            this.homePanel.Visible = true;
            this.backupManagerPanel.Visible = false;
            this.settingsPanel.Visible = false;
            this.othersPanel.Visible = false;

            this.Reload_UI();
        }
        private void Reload_UI()
        {
            this.Reload_Config();

            this.Reload_backupFilesListBox();
            this.Reload_backupsListBox();
        }
        private void Reload_Config()
        {
            this.textBox1.Text = this.backupManager.configManager.config.backupStoragePath;
        }
        private void Reload_backupFilesListBox()
        {
            this.backupFilesListBox.Items.Clear();
            foreach (string item in this.backupManager.backupConfigManager.backupConfig.files)
            {
                backupFilesListBox.Items.Add(item);
            }
        }
        private void Reload_backupsListBox()
        {
            this.backupsListBox.Items.Clear();
            foreach (string item in this.backupManager.backupStorageConfigManager.backupStorageConfig.backups.Keys)
            {
                backupsListBox.Items.Add(item);
            }
        }
        private void home_Click(object sender, EventArgs e)
        {
            this.homePanel.Visible = true;
            this.backupManagerPanel.Visible = false;
            this.settingsPanel.Visible = false;
            this.othersPanel.Visible = false;
        }

        private void backupManagerButton_Click(object sender, EventArgs e)
        {
            this.homePanel.Visible = false;
            this.backupManagerPanel.Visible = true;
            this.settingsPanel.Visible = false;
            this.othersPanel.Visible = false;
        }
        private void settings_Click(object sender, EventArgs e)
        {
            this.homePanel.Visible = false;
            this.backupManagerPanel.Visible = false;
            this.settingsPanel.Visible = true;
            this.othersPanel.Visible = false;
        }
        private void others_Click(object sender, EventArgs e)
        {
            this.homePanel.Visible = false;
            this.backupManagerPanel.Visible = false;
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
                this.backupManager.configManager.Set_BackupStoragePath(selectedPath);
            }
        }

        private void about_Click(object sender, EventArgs e)
        {
            AboutPage aboutPage = new AboutPage();
            aboutPage.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.backupManager.configManager.Set_BackupStoragePath(this.textBox1.Text);
        }

        private void settings_ResetButton_Click(object sender, EventArgs e)
        {
            this.backupManager.configManager.Reset_ConfigFile();
            this.Reload_Config();
            this.backupManager.configManager.Check_And_Init_Config();
            this.Reload_Config();
        }

        private void backupFilesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] fileNames = openFileDialog.FileNames;
                foreach (string fileName in fileNames)
                {
                    this.backupManager.backupConfigManager.Add_File(fileName);
                }
            }

            this.Reload_backupFilesListBox();
        }

        private void addDirButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.backupManager.backupConfigManager.Add_Dir(folderBrowserDialog.SelectedPath);
            }

            this.Reload_backupFilesListBox();
        }

        private void deleteSelectedItemButton_Click(object sender, EventArgs e)
        {
            if (this.backupFilesListBox.SelectedIndex != -1)
            {
                this.backupManager.backupConfigManager.Delete_Item(this.backupFilesListBox.SelectedIndex);
                this.Reload_backupFilesListBox();
            }
            else
            {
                MessageBox.Show("未选择条目", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void backupAllFilesButton_Click(object sender, EventArgs e)
        {
            this.homeStatusLabel.Text = "备份中...";

            int length = this.backupManager.backupConfigManager.backupConfig.files.ToArray().Length;
            if (length == 0)
            {
                this.homeProcessLable.Text = "正在备份条目 ''...";
                this.homeProgressBar.Minimum = 0;
                this.homeProgressBar.Maximum = 1;
                this.homeProgressBar.Value = 0;
                this.homeProgressBar.Step = 1;

                this.homeProgressBar.PerformStep();
                this.homeStatusLabel.Text = "完成";
                MessageBox.Show("队列中没有条目", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("备份失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.homeProgressBar.Minimum = 0;
                this.homeProgressBar.Maximum = length;
                this.homeProgressBar.Value = 0;
                this.homeProgressBar.Step = 1;

                foreach (string item in this.backupManager.backupConfigManager.backupConfig.files)
                {
                    this.homeProcessLable.Text = "正在备份条目 '" + item + "'...";

                    this.backupManager.Backup_Item(item);

                    this.homeProgressBar.PerformStep();
                }

                this.homeStatusLabel.Text = "完成";
                MessageBox.Show("备份成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Reload_backupsListBox();
        }

        private void backupSelectedItemButton_Click(object sender, EventArgs e)
        {
            this.homeProcessLable.Text = "正在备份条目 '" + this.backupManager.backupConfigManager.backupConfig.files[this.backupFilesListBox.SelectedIndex] + "'...";
            this.homeProgressBar.Minimum = 0;
            this.homeProgressBar.Maximum = 1;
            this.homeProgressBar.Value = 0;
            this.homeProgressBar.Step = 1;

            if (this.backupFilesListBox.SelectedIndex != -1)
            {
                bool result = this.backupManager.Backup_SelectedItem(this.backupFilesListBox.SelectedIndex);

                this.homeProgressBar.PerformStep();
                if (result)
                {
                    MessageBox.Show("备份成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("未选择条目", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("备份失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void recoverySelectedBackupButton_Click(object sender, EventArgs e)
        {
            object? item = this.backupsListBox.SelectedItem;
            if (item != null)
            {
                string? itemString = item.ToString();
                if (itemString != null)
                {
                    this.backupManagerProcessLable.Text = "正在备份条目 '" + this.backupManager.backupConfigManager.backupConfig.files[this.backupFilesListBox.SelectedIndex] + "'...";
                    this.backupManagerProgressBar.Minimum = 0;
                    this.backupManagerProgressBar.Maximum = this.backupManager.backupStorageConfigManager.backupStorageConfig.backups[itemString].ToArray().Length;
                    this.backupManagerProgressBar.Value = 0;
                    this.backupManagerProgressBar.Step = 1;

                    foreach (string file in this.backupManager.backupStorageConfigManager.backupStorageConfig.backups[itemString])
                    {
                        this.backupManager.Recovery_File(itemString,file);

                        this.backupManagerProgressBar.PerformStep();
                    }

                    MessageBox.Show("备份成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.backupManagerProcessLable.Text = "正在备份条目 'Unknown'...";
                    this.backupManagerProgressBar.Minimum = 0;
                    this.backupManagerProgressBar.Maximum = 1;
                    this.backupManagerProgressBar.Value = 0;
                    this.backupManagerProgressBar.Step = 1;

                    this.backupManagerProgressBar.PerformStep();

                    MessageBox.Show("itemString为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.backupManagerProcessLable.Text = "正在备份条目 'Unknown'...";
                this.backupManagerProgressBar.Minimum = 0;
                this.backupManagerProgressBar.Maximum = 1;
                this.backupManagerProgressBar.Value = 0;
                this.backupManagerProgressBar.Step = 1;

                this.backupManagerProgressBar.PerformStep();

                MessageBox.Show("item为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteSelectedBackupButton_Click(object sender, EventArgs e)
        {

        }
    }
}
