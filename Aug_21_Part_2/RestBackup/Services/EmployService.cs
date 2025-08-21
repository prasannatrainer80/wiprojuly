using RestBackup.Models;

namespace RestBackup.Services
{
    public class EmployService : IEmployService
    {
        private readonly HttpClient _httpClient; 

        public EmployService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://localhost:7271/api/Employs/");
        }
        public async Task<string> AddEmployAsync(Employ employ)
        {
            var response = await _httpClient.PostAsJsonAsync("Employs", employ);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }

        public async Task<Employ?> SearchByEmpnoAsync(int id)
        {
            var response = await _httpClient.GetAsync($"Employs/{id}");
            if (!response.IsSuccessStatusCode) return null;

            return await response.Content.ReadFromJsonAsync<Employ>();
        }

        public async Task<IEnumerable<Employ>> ShowEmployAsync()
        {
            var response = await _httpClient.GetAsync("Employs");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<IEnumerable<Employ>>()
                   ?? Enumerable.Empty<Employ>();

        }
    }
}
