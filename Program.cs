using System.ComponentModel;

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

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1JEaF5cXmRCeUx3Q3xbf1x1ZFRMY15bRnJPIiBoS35Rc0VkWXZfc3dXRGRYVkdzVEFd");
            ApplicationConfiguration.Initialize();
            Application.Run(new Home());
        }
    }
}