using Ndm.DTO;
using Ndm.Repositories;

namespace Ndm.Service
{
    public interface IConfigureGithubRepository
    {
        Task<bool> CreateAsync(ConfigureGithubModel model);
        Task<bool> UpdateAsync(ConfigureGithubModel model);
        Task<bool> DeleteAsync(int id);
        Task<ConfigureGithubModel> GetAsync(int id);
        Task<IEnumerable<ConfigureGithubModel>> GetAllAsync();
    }
}