using ndm.DTO;

namespace ndm.Service
{
   public interface IGithubConfigurationRepository
   {
      Task<GithubConfigurationModel> GetGithubConfigurationAsync(int id);
      Task<IEnumerable<GithubConfigurationModel>> GetGithubConfigurationsAsync();
      Task<GithubConfigurationModel> AddGithubConfigurationAsync(GithubConfigurationModel githubConfiguration);
      Task<GithubConfigurationModel> UpdateGithubConfigurationAsync(GithubConfigurationModel githubConfiguration);
      Task DeleteGithubConfigurationAsync(int id);
   }
}