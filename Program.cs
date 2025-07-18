namespace SignaBSG
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            // Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Properties.Settings.Default.Licencia);
            ApplicationConfiguration.Initialize();
            Application.Run(new Home());
        }
    }
}