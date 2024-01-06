namespace EasyBackup
{
    internal static class EasyBackup
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainPages());
        }
    }
}