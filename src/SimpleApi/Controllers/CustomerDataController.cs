using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleApi.DataAccess.Interfaces;

namespace SimpleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerDataController : ControllerBase
    {
        private readonly ICustomerData _customerData;
        public CustomerDataController(ICustomerData customerData)
        {
            _customerData = customerData;
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetCustomerVyId(int id)
        {
            var result = await _customerData.GetCustomerById(id).ConfigureAwait(false);
            if(result is null)
                return NotFound();

            return Ok(result);
        }
    }
}
