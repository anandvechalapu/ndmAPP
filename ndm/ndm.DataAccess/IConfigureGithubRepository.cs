using NDM.DTO;

namespace NDM.Service
{
    public interface IConfigureGithubRepository
    {
        Task<List<ConfigureGithubModel>> GetAllAsync();
        Task<ConfigureGithubModel> GetByIdAsync(int id);
        Task CreateAsync(ConfigureGithubModel model);
        Task UpdateAsync(ConfigureGithubModel model);
        Task DeleteAsync(int id);
    }
}