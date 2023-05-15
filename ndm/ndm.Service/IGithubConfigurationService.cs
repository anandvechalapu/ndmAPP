namespace ndm.Service
{
   using ndm.DTO;
   using System.Collections.Generic;
   using System.Threading.Tasks;

   public interface IGithubConfigurationService
   {
      Task<GithubConfigurationModel> GetGithubConfigurationAsync(int id);
      Task<IEnumerable<GithubConfigurationModel>> GetGithubConfigurationsAsync();
      Task<GithubConfigurationModel> AddGithubConfigurationAsync(GithubConfigurationModel githubConfiguration);
      Task<GithubConfigurationModel> UpdateGithubConfigurationAsync(GithubConfigurationModel githubConfiguration);
      Task DeleteGithubConfigurationAsync(int id);
   }
}