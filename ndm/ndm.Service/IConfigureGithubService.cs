namespace NDM.Service
{
    using NDM.DTO;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IConfigureGithubService
    {
        Task<List<ConfigureGithubModel>> GetAllAsync();
        Task<ConfigureGithubModel> GetByIdAsync(int id);
        Task CreateAsync(ConfigureGithubModel model);
        Task UpdateAsync(ConfigureGithubModel model);
        Task DeleteAsync(int id);
    }
}