using Newtonsoft.Json;
namespace EasyBackup
{
    public interface ConfigManagerInterface
    {
        void Load_ConfigFile();
        void Update_ConfigFile();
        void Create_ConfigFile();
        void Reset_ConfigFile();
        void Check_And_Init_Config();
    }
    public class ConfigManager : ConfigManagerInterface
    {
        private readonly string configFilePath;
        public Config config;
        public ConfigManager(string configFilePath)
        {
            this.configFilePath = configFilePath;
            this.config = new Config();

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
            Config? tempConfig = JsonConvert.DeserializeObject<Config>(json);
            if (tempConfig != null)
                this.config = tempConfig;
        }
        public void Check_And_Init_Config()
        {
            while (this.config.backupStoragePath == "")
            {
                MessageBox.Show("未设置备份存储路径", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderBrowserDialog.SelectedPath;
                    this.Set_BackupStoragePath(selectedPath);
                    break;
                }
            }
            this.Update_ConfigFile();
        }
        public void Reset_ConfigFile()
        {
            File.WriteAllText(this.configFilePath,
                "{" +
                "\"backupStoragePath\": \"\"" +
                "}");
            this.Load_ConfigFile();
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
        public void Update_ConfigFile()
        {
            File.WriteAllText(this.configFilePath, JsonConvert.SerializeObject(this.config));
        }
        public void Set_BackupStoragePath(string str)
        {
            this.config.backupStoragePath = str;
            this.Update_ConfigFile();
        }
    }
    public class Config
    {
        public string backupStoragePath { get; set; }
        public Config()
        {
            backupStoragePath = "";
        }
    }
}
