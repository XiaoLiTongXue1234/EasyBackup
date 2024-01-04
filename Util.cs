using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBackup
{
    public class Util
    {
        public static string Execute_CMD_Command(string command)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/c " + command;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.Start();

                string result = process.StandardOutput.ReadToEnd();

                process.WaitForExit();

                return result;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,"错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return "";
            }
        }
        public static void Open_Website(string url)
        {
            Execute_CMD_Command("start " + url);
        }
    }
}
