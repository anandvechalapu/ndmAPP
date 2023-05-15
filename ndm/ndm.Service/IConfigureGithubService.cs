namespace Ndm.Service
{
    using Ndm.DTO;

    public interface IConfigureGitHubService
    {
        Task<bool> CreateAsync(ConfigureGitHubModel model);
        Task<ConfigureGitHubModel> ReadAsync(int id);
        Task<bool> UpdateAsync(ConfigureGitHubModel model);
        Task<bool> DeleteAsync(int id);
    }
}