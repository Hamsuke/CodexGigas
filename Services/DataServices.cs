using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace CodexGigas.Services;
    internal class DataServices
    {
        private readonly HttpClient _httpClient;
        public DataServices()
        {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri("http://localhost:8000"); // Cambia según la IP de Docker
        }

    public async Task<string> EnviarDatosAsync(string x, string y)
    {
        var payload = new { X = x, Y = y };
        var json = JsonSerializer.Serialize(payload);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        HttpResponseMessage response = await _httpClient.PostAsync("/procesar", content);

        if (response.IsSuccessStatusCode)
        {
            string responseData = await response.Content.ReadAsStringAsync();
            return responseData;
        }
        else
        {
            return $"Error: {response.StatusCode}";
        }
    }
}
