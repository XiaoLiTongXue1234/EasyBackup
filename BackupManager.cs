using Newtonsoft.Json;

namespace EasyBackup
{
    public class BackupManager
    {
        public ConfigManager configManager;
        public BackupConfigManager backupConfigManager;
        public BackupStorageConfigManager backupStorageConfigManager;
        public BackupManager(string configFilePath, string backupConfigFilePath)
        {
            this.configManager = new ConfigManager(configFilePath);
            this.backupConfigManager = new BackupConfigManager(backupConfigFilePath);

            string backupStorageConfigFilePath = this.configManager.config.backupStoragePath + "\\backupStorage.config.json";
            this.backupStorageConfigManager = new BackupStorageConfigManager(backupStorageConfigFilePath);
        }
        public bool Backup_SelectedItem(int index)
        {
            this.Backup_Item(this.backupConfigManager.backupConfig.files[index]);

            return true;
        }
        public void Backup_Item(string item)
        {
            string currentDir = Directory.GetCurrentDirectory();

            string time = DateTime.Now.ToString("yyyy_MM_dd-HH_mm_ss");
            Directory.SetCurrentDirectory(this.configManager.config.backupStoragePath);
            Directory.CreateDirectory(time);
            Directory.SetCurrentDirectory(this.configManager.config.backupStoragePath + "\\" + time);

            this.backupStorageConfigManager.Add_Backup(time);

            string path;
            if (item.StartsWith("file: "))
            {
                path = item.Substring(6);
                if (File.Exists(path))
                {
                    this.Backup_File(time, path);
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
                    this.Backup_Dir(time, path);
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
        private void Backup_File(string time, string path)
        {
            string currentDir = Directory.GetCurrentDirectory();

            string rootDir = path[..1];
            Directory.CreateDirectory(rootDir);
            Directory.SetCurrentDirectory(rootDir);
            string? tempDirName = Path.GetDirectoryName(path);
            if (tempDirName != null)
            {
                string dir = tempDirName[3..];
                Directory.CreateDirectory(dir);
                File.Copy(path, dir + "\\" + Path.GetFileName(path));

                this.backupStorageConfigManager.Add_File(time, path);
            }
            else
            {
                MessageBox.Show("路径 '" + path + "' 格式错误, 需要绝对路径", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Directory.SetCurrentDirectory(currentDir);
        }
        private void Backup_Dir(string time, string path)
        {
            string currentDir = Directory.GetCurrentDirectory();

            foreach (string file in Directory.GetFiles(path))
            {
                this.Backup_File(time, file);
            }
            foreach (string dir in Directory.GetDirectories(path))
            {
                this.Backup_Dir(time, dir);
            }

            Directory.SetCurrentDirectory(currentDir);
        }
        public void Recovery_File(string itemName,string file)
        {
            string rootDir = file[..1];
            string path = file[3..];
            File.Copy(this.configManager.config.backupStoragePath + "\\" + itemName + "\\" + rootDir + "\\" + path, file);
        }
    }
    public class BackupConfigManager : ConfigManagerInterface
    {
        private readonly string configFilePath;
        public BackupConfig backupConfig;
        public BackupConfigManager(string configFilePath)
        {
            this.configFilePath = configFilePath;
            this.backupConfig = new BackupConfig();

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
            if (!Directory.Exists(this.configFilePath))
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
    public class BackupStorageConfigManager : ConfigManagerInterface
    {
        private readonly string configFilePath;
        public BackupStorageConfig backupStorageConfig;
        public BackupStorageConfigManager(string configFilePath)
        {
            this.configFilePath = configFilePath;
            this.backupStorageConfig = new BackupStorageConfig();

            this.Load_ConfigFile();
            this.Check_And_Init_Config();
        }
        public void Check_And_Init_Config()
        {
            this.Update_ConfigFile();
        }

        public void Create_ConfigFile()
        {
            if (!Directory.Exists(this.configFilePath))
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

        public void Load_ConfigFile()
        {
            if (!File.Exists(this.configFilePath))
            {
                this.Create_ConfigFile();
            }
            string json = File.ReadAllText(this.configFilePath);
            BackupStorageConfig? tempConfig = JsonConvert.DeserializeObject<BackupStorageConfig>(json);
            if (tempConfig != null)
                this.backupStorageConfig = tempConfig;
        }

        public void Reset_ConfigFile()
        {
            File.WriteAllText(this.configFilePath,
                "{" +
                "\"backups\": {}" +
                "}");
            this.Load_ConfigFile();
        }

        public void Update_ConfigFile()
        {
            File.WriteAllText(this.configFilePath, JsonConvert.SerializeObject(this.backupStorageConfig));
        }
        public void Add_Backup(string time)
        {
            this.backupStorageConfig.backups.Add(time, []);

            this.Update_ConfigFile();
        }
        public void Add_File(string time, string file)
        {
            this.backupStorageConfig.backups[time].Add(file);

            this.Update_ConfigFile();
        }
        public void Add_Files(string time, List<string> files)
        {
            foreach (string file in files)
            {
                string? tempDirName = Path.GetDirectoryName(file);
                if (tempDirName != null && !Directory.Exists(tempDirName))
                {
                    Directory.CreateDirectory(tempDirName);
                }
                this.backupStorageConfig.backups[time].Add(file);
            }

            this.Update_ConfigFile();
        }
    }
    public class BackupConfig
    {
        public List<string> files { get; set; }
        public BackupConfig()
        {
            this.files = [];
        }
    }
    public class BackupStorageConfig
    {
        public Dictionary<string, List<string>> backups { get; set; }
        public BackupStorageConfig()
        {
            this.backups = [];
        }
    }
}
