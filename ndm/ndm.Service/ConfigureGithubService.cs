namespace Ndm.Service
{
    using Ndm.DataAccess;
    using Ndm.DTO;

    public class ConfigureGitHubService : IConfigureGitHubService
    {
        private readonly IConfigureGitHubRepository _configureGitHubRepository;

        public ConfigureGitHubService(IConfigureGitHubRepository configureGitHubRepository)
        {
            _configureGitHubRepository = configureGitHubRepository;
        }

        public async Task<bool> CreateAsync(ConfigureGitHubModel model)
        {
            return await _configureGitHubRepository.CreateAsync(model);
        }

        public async Task<ConfigureGitHubModel> ReadAsync(int id)
        {
            return await _configureGitHubRepository.ReadAsync(id);
        }

        public async Task<bool> UpdateAsync(ConfigureGitHubModel model)
        {
            return await _configureGitHubRepository.UpdateAsync(model);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _configureGitHubRepository.DeleteAsync(id);
        }
    }
}