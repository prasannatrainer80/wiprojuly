using RestBackup.Models;

namespace RestBackup.Services
{
    public interface IEmployService
    {
        Task<IEnumerable<Employ>> ShowEmployAsync();
        Task<Employ?> SearchByEmpnoAsync(int id);
        Task<string> AddEmployAsync(Employ employ);
    }
}
