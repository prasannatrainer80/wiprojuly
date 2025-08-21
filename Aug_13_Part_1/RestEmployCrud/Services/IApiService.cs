using RestEmployCrud.Models;

namespace RestEmployCrud.Services
{
    public interface IApiService
    {
        Task<IEnumerable<Employ>> GetEmployAsync();
        Task<Employ?> GetEmployByIdAsync(int id);
        Task<string> CreateEmployAsync(Employ employ);
    }
}
