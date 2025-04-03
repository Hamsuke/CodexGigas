using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CodexGigas.Services;

public class DataServices : IDataServices
{
    private readonly HttpClient _httpClient;

    public DataServices()
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri("http://host.docker.internal:8000/");// Reemplaza con la IP del host
        _httpClient.Timeout = TimeSpan.FromSeconds(60); // Aumentar timeout
        _httpClient.DefaultRequestHeaders.ExpectContinue = false; // Evita problemas con servidores que no soportan Expect
        _httpClient.DefaultRequestHeaders.ConnectionClose = true; // Cierra la conexión después de la solicitud
    }

    public async Task<string> EnviarDatosAsync(int metodo, string x, string y, string fx, float h, float n, float vali)
    {
        try
        {
            var payload = new { Method = metodo, X = x, Y = y, FX = fx, H = h, N = n };
            var json = JsonSerializer.Serialize(payload);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PostAsync("/app/procesar", content);

            response.EnsureSuccessStatusCode(); // Lanza excepción si la respuesta no es 2xx

            return await response.Content.ReadAsStringAsync();
        }
        catch (HttpRequestException ex)
        {
            return $"Error de solicitud: {ex.Message}";
        }
        catch (Exception ex)
        {
            return $"Error inesperado: {ex.Message}";
        }
    }
}
