using RestEmployCrud.Models;

namespace RestEmployCrud.Services
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient; 

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://localhost:7271/api/");
        }
        public async Task<string> CreateEmployAsync(Employ employ)
        {
            var response = await _httpClient.PostAsJsonAsync("Employs", employ);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }

        public async Task<IEnumerable<Employ>> GetEmployAsync()
        {
            var response = await _httpClient.GetAsync("Employs");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<IEnumerable<Employ>>()
                   ?? Enumerable.Empty<Employ>();
        }

        public async Task<Employ?> GetEmployByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"Employs/{id}");
            if (!response.IsSuccessStatusCode) return null;

            return await response.Content.ReadFromJsonAsync<Employ>();
        }
    }
}
