namespace NDM.API
{
    using Microsoft.AspNetCore.Mvc;
    using NDM.DTO;
    using NDM.Service;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    public class ConfigureGithubController : Controller
    {
        private readonly ConfigureGithubService _configureGithubService;

        public ConfigureGithubController(ConfigureGithubService configureGithubService)
        {
            _configureGithubService = configureGithubService;
        }

        [HttpGet]
        public async Task<List<ConfigureGithubModel>> GetAllAsync()
        {
            return await _configureGithubService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ConfigureGithubModel> GetByIdAsync(int id)
        {
            return await _configureGithubService.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task CreateAsync([FromBody] ConfigureGithubModel model)
        {
            await _configureGithubService.CreateAsync(model);
        }

        [HttpPut]
        public async Task UpdateAsync([FromBody] ConfigureGithubModel model)
        {
            await _configureGithubService.UpdateAsync(model);
        }

        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
            await _configureGithubService.DeleteAsync(id);
        }
    }
}