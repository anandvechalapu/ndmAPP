namespace NDM.Service
{
    using NDM.DataAccess;
    using NDM.DTO;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class ConfigureGithubService : IConfigureGithubService
    {
        private readonly IConfigureGithubRepository _configureGithubRepository;

        public ConfigureGithubService(IConfigureGithubRepository configureGithubRepository)
        {
            _configureGithubRepository = configureGithubRepository;
        }

        public async Task<List<ConfigureGithubModel>> GetAllAsync()
        {
            return await _configureGithubRepository.GetAllAsync();
        }

        public async Task<ConfigureGithubModel> GetByIdAsync(int id)
        {
            return await _configureGithubRepository.GetByIdAsync(id);
        }

        public async Task CreateAsync(ConfigureGithubModel model)
        {
            await _configureGithubRepository.CreateAsync(model);
        }

        public async Task UpdateAsync(ConfigureGithubModel model)
        {
            await _configureGithubRepository.UpdateAsync(model);
        }

        public async Task DeleteAsync(int id)
        {
            await _configureGithubRepository.DeleteAsync(id);
        }
    }
}