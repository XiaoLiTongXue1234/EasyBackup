using Newtonsoft.Json;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace EasyBackup
{
    public class BackupConfig
    {
        public List<string> files { get; set; }
        public BackupConfig()
        {
            this.files = [];
        }
    }
    public class BackupConfigManager : ConfigManagerInterface
    {
        private string configFilePath;
        public BackupConfig backupConfig = new BackupConfig();
        public BackupConfigManager(string configFilePath)
        {
            this.configFilePath = configFilePath;
            this.Load_ConfigFile();
            this.Check_And_Init_Config();
        }
        public void Load_ConfigFile()
        {
            if (!File.Exists(this.configFilePath))
            {
                this.Create_ConfigFile();
            }
            string json = File.ReadAllText(this.configFilePath);
            BackupConfig? tempConfig = JsonConvert.DeserializeObject<BackupConfig>(json);
            if (tempConfig != null)
                this.backupConfig = tempConfig;
        }
        public void Check_And_Init_Config()
        {
            this.Update_ConfigFile();
        }

        public void Update_ConfigFile()
        {
            File.WriteAllText(this.configFilePath, JsonConvert.SerializeObject(this.backupConfig));
        }

        public void Create_ConfigFile()
        {
            if (!Directory.Exists(configFilePath))
            {
                string? directory = Path.GetDirectoryName(this.configFilePath);
                if (directory != null)
                {
                    Directory.CreateDirectory(directory);
                }
            }
            this.Reset_ConfigFile();
            this.Check_And_Init_Config();
        }

        public void Reset_ConfigFile()
        {
            File.WriteAllText(this.configFilePath,
                "{" +
                "\"files\": []" +
                "}");
            this.Load_ConfigFile();
        }
        public void Add_File(string path)
        {
            if (this.backupConfig.files.Contains("file: " + path))
            {
                MessageBox.Show("文件 '" + path + "' 已经在队列中", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.backupConfig.files.Add("file: " + path);
                this.Update_ConfigFile();
            }
        }
        public void Add_Dir(string path)
        {
            if (this.backupConfig.files.Contains("dir: " + path))
            {
                MessageBox.Show("文件夹 '" + path + "' 已经在队列中", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.backupConfig.files.Add("dir: " + path);
                this.Update_ConfigFile();
            }
        }
        public void Delete_Item(int index)
        {
            this.backupConfig.files.RemoveAt(index);

            this.Update_ConfigFile();
        }
    }
    public class BackupManager
    {
        public ConfigManager configManager;
        public BackupConfigManager backupConfigManager;
        public BackupManager(string configFilePath, string backupConfigFilePath)
        {
            this.configManager = new ConfigManager(configFilePath);
            this.backupConfigManager = new BackupConfigManager(backupConfigFilePath);
        }
        public bool Backup_SelectedItem(int index)
        {
            this.Backup_Item(this.backupConfigManager.backupConfig.files[index]);

            return true;
        }
        public void Backup_Item(string item)
        {
            string currentDir = Directory.GetCurrentDirectory();

            string time = DateTime.Now.ToString("yyyy-MM-dd HH_mm_ss");
            Directory.SetCurrentDirectory(this.configManager.config.backupStoragePath);
            Directory.CreateDirectory(time);
            Directory.SetCurrentDirectory(this.configManager.config.backupStoragePath + "\\" + time);

            string path;
            if (item.StartsWith("file: "))
            {
                path = item.Substring(6);
                if (File.Exists(path))
                {
                    this.Backup_File(path);
                }
                else
                {
                    MessageBox.Show("文件 '" + path + "' 不存在", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (item.StartsWith("dir: "))
            {
                path = item.Substring(5);
                if (Directory.Exists(path))
                {
                    this.Backup_Dir(path);
                }
                else
                {
                    MessageBox.Show("文件夹 '" + path + "' 不存在", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                path = item;
                MessageBox.Show("未知类型的条目 '" + path + "'", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Directory.SetCurrentDirectory(currentDir);
        }
        private void Backup_File(string path)
        {
            string currentDir = Directory.GetCurrentDirectory();

            string rootDir = path.Substring(0, 1);
            Directory.CreateDirectory(rootDir);
            Directory.SetCurrentDirectory(rootDir);
            string? tempDirName = Path.GetDirectoryName(path);
            if (tempDirName != null)
            {
                string dir = tempDirName.Substring(3);
                Directory.CreateDirectory(dir);
                File.Copy(path, dir+"\\"+Path.GetFileName(path));
            }
            else
            {
                MessageBox.Show("路径 '" + path + "' 格式错误, 需要绝对路径", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Directory.SetCurrentDirectory(currentDir);
        }
        private void Backup_Dir(string path)
        {
            string currentDir = Directory.GetCurrentDirectory();

            foreach (string file in Directory.GetFiles(path))
            {
                this.Backup_File(file);
            }
            foreach (string dir in Directory.GetDirectories(path))
            {
                this.Backup_Dir(dir);
            }

            Directory.SetCurrentDirectory(currentDir);
        }
    }
}
