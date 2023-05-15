namespace ndm.Service
{
   using ndm.DataAccess;
   using ndm.DTO;
   using System.Collections.Generic;
   using System.Threading.Tasks;

   public class GithubConfigurationService : IGithubConfigurationService
   {
      private readonly IGithubConfigurationRepository _githubConfigurationRepository;
      public GithubConfigurationService(IGithubConfigurationRepository githubConfigurationRepository)
      {
         _githubConfigurationRepository = githubConfigurationRepository;
      }

      public async Task<GithubConfigurationModel> GetGithubConfigurationAsync(int id)
      {
         return await _githubConfigurationRepository.GetGithubConfigurationAsync(id);
      }

      public async Task<IEnumerable<GithubConfigurationModel>> GetGithubConfigurationsAsync()
      {
         return await _githubConfigurationRepository.GetGithubConfigurationsAsync();
      }

      public async Task<GithubConfigurationModel> AddGithubConfigurationAsync(GithubConfigurationModel githubConfiguration)
      {
         return await _githubConfigurationRepository.AddGithubConfigurationAsync(githubConfiguration);
      }

      public async Task<GithubConfigurationModel> UpdateGithubConfigurationAsync(GithubConfigurationModel githubConfiguration)
      {
         return await _githubConfigurationRepository.UpdateGithubConfigurationAsync(githubConfiguration);
      }

      public async Task DeleteGithubConfigurationAsync(int id)
      {
         await _githubConfigurationRepository.DeleteGithubConfigurationAsync(id);
      }
   }
}