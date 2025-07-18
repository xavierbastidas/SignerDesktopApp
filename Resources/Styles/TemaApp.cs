using Microsoft.Win32;

namespace SignaBSG.Resources.Estilos
{
    // Enum que representa los posibles temas
    public enum Tema
    {
        Oscuro,
        Claro,
        Sistema
    }

    // Clase utilitaria para temas
    public static class TemaApp
    {
        // Devuelve el tema del sistema detectado desde el registro
        public static Tema DetectarTemaDelSistema()
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
                            return Tema.Oscuro;
                        else
                            return Tema.Claro;
                    }
                }
            }
            catch
            {
                return Tema.Claro;
                // Si falla la lectura, retorna tema claro como predeterminado
            }

            return Tema.Claro;
        }
    }
}
