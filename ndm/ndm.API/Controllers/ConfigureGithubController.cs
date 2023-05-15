namespace Ndm.API
{
    using Ndm.DTO;
    using Ndm.Service;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/configureGitHub")]
    [ApiController]
    public class ConfigureGitHubController : ControllerBase
    {
        private readonly ConfigureGitHubService _configureGitHubService;

        public ConfigureGitHubController(ConfigureGitHubService configureGitHubService)
        {
            _configureGitHubService = configureGitHubService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(ConfigureGitHubModel model)
        {
            var result = await _configureGitHubService.CreateAsync(model);
            if (!result)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> ReadAsync(int id)
        {
            var result = await _configureGitHubService.ReadAsync(id);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(ConfigureGitHubModel model)
        {
            var result = await _configureGitHubService.UpdateAsync(model);
            if (!result)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var result = await _configureGitHubService.DeleteAsync(id);
            if (!result)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}