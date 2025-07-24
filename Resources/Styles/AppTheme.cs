using Microsoft.Win32;

namespace SignaBSG.Resources.Styles
{
    public enum Theme
    {
        Light,
        Dark,
        System
    }

    public static class AppTheme
    {
        // Detects the current system theme (Light or Dark) by reading Windows registry
        public static Theme DetectSystemTheme()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(
                    @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize"))
                {
                    if (key != null)
                    {
                        object value = key.GetValue("AppsUseLightTheme");
                        if (value != null && Convert.ToInt32(value) == 0)
                            return Theme.Dark;
                        else
                            return Theme.Light;
                    }
                }
            }
            catch
            {
                return Theme.Light;
            }

            return Theme.Light;
        }
    }
}
