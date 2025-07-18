using System.Globalization;

namespace SignaBSG.Services
{
    public static class ApiRequest
    {
        public static async Task<byte[]> FirmarPdfPost(
            string pdfPath,
            string certPath,
            string certPassword,
            float coordX,
            float coordY,
            int page)
        {
            try
            {
                using var httpClient = new HttpClient();

                byte[] pdfBytes = File.ReadAllBytes(pdfPath);
                string pdfBase64 = Convert.ToBase64String(pdfBytes);

                byte[] certBytes = File.ReadAllBytes(certPath);
                var certStream = new MemoryStream(certBytes);

                using var form = new MultipartFormDataContent();
                form.Add(new StringContent(pdfBase64), "Base64Pdf");
                form.Add(new StringContent(certPassword), "CertificatePassword");
                form.Add(new StringContent(coordX.ToString(CultureInfo.InvariantCulture)), "CoordinateX");
                form.Add(new StringContent(coordY.ToString(CultureInfo.InvariantCulture)), "CoordinateY");

                form.Add(new StringContent(page.ToString()), "PageNumber");
                form.Add(new StreamContent(certStream), "CertificateP12", Path.GetFileName(certPath));

                var response = await httpClient.PostAsync(Properties.Settings.Default.ApiUrl, form);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsByteArrayAsync();
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error en la respuesta de la API:\n{error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado:\n{ex.Message}", "Error general", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }

}
