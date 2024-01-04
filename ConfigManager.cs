using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBackup
{
    public class ConfigManager
    {
        private string configFilePath;
        public ConfigManager(string configFilePath)
        {
            this.configFilePath = configFilePath;
            this.Load_ConfigFile();
        }
        private void Load_ConfigFile()
        {

        }
    }
}
