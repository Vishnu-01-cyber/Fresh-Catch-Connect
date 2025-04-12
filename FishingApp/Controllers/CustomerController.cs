using DAL;
using FishingApp.BAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FishingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerBAL customerBAL;
        private readonly ISqlHelper sqlHelper;

        public CustomerController(ICustomerBAL customerBAL,ISqlHelper sqlHelper)
        {
            this.customerBAL = customerBAL;
            this.sqlHelper = sqlHelper;
        }

        [HttpGet]

        public IActionResult GetAll()
        {
            return Ok(customerBAL.Customer());
        }
    }
}
