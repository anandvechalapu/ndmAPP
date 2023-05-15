using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ndm.DTO;
using ndm.Service;

namespace ndm.API
{
    [ApiController]
    public class CustomController : ControllerBase
    {
        private readonly ICustomService _customService;

        public CustomController(ICustomService customService)
        {
            _customService = customService;
        }

        [HttpPost]
        public async Task SendMessageAsync([FromBody] string message)
        {
            await _customService.SendMessageAsync(message);
        }

        [HttpGet]
        public async Task<string> GetMessageAsync()
        {
            return await _customService.GetMessageAsync();
        }
    }
}