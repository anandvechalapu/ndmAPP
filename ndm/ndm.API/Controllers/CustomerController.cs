using ndm.API;
using ndm.DTO;
using ndm.Service;
using Microsoft.AspNetCore.Mvc;

namespace ndm.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Customer>> GetCustomerByIdAsync(int id)
        {
            var customer = await _customerService.GetCustomerByIdAsync(id);
            return Ok(customer);
        }

        [HttpPost]
        public async Task<ActionResult<Customer>> SaveCustomerAsync([FromBody] Customer customer)
        {
            await _customerService.SaveCustomerAsync(customer);
            return Ok();
        }
    }
}