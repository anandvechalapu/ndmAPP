namespace ndm.API
{
   using Microsoft.AspNetCore.Mvc;
   using ndm.DTO;
   using ndm.Service;
   using System.Collections.Generic;
   using System.Threading.Tasks;

   [Route("api/[controller]")]
   [ApiController]
   public class GithubConfigurationController : ControllerBase
   {
      private readonly GithubConfigurationService _githubConfigurationService;

      public GithubConfigurationController(GithubConfigurationService githubConfigurationService)
      {
         _githubConfigurationService = githubConfigurationService;
      }

      [HttpGet]
      public async Task<ActionResult<IEnumerable<GithubConfigurationModel>>> GetGithubConfigurationsAsync()
      {
         return Ok(await _githubConfigurationService.GetGithubConfigurationsAsync());
      }

      [HttpGet("{id}")]
      public async Task<ActionResult<GithubConfigurationModel>> GetGithubConfigurationAsync(int id)
      {
         var githubConfiguration = await _githubConfigurationService.GetGithubConfigurationAsync(id);

         if (githubConfiguration == null)
            return NotFound();

         return Ok(githubConfiguration);
      }

      [HttpPost]
      public async Task<ActionResult<GithubConfigurationModel>> AddGithubConfigurationAsync(GithubConfigurationModel githubConfiguration)
      {
         var createdGithubConfiguration = await _githubConfigurationService.AddGithubConfigurationAsync(githubConfiguration);

         return CreatedAtAction(nameof(GetGithubConfigurationAsync), new { id = createdGithubConfiguration.Id }, createdGithubConfiguration);
      }

      [HttpPut("{id}")]
      public async Task<ActionResult<GithubConfigurationModel>> UpdateGithubConfigurationAsync(int id, GithubConfigurationModel githubConfiguration)
      {
         if (id != githubConfiguration.Id)
            return BadRequest();

         var updatedGithubConfiguration = await _githubConfigurationService.UpdateGithubConfigurationAsync(githubConfiguration);

         if (updatedGithubConfiguration == null)
            return NotFound();

         return Ok(updatedGithubConfiguration);
      }

      [HttpDelete("{id}")]
      public async Task<ActionResult> DeleteGithubConfigurationAsync(int id)
      {
         await _githubConfigurationService.DeleteGithubConfigurationAsync(id);

         return NoContent();
      }
   }
}