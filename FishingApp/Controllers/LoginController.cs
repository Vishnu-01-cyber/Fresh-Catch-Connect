using DAL;
using FishingApp.BAL;
using FishingApp.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FishingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ISqlHelper helper;
        private readonly ILoginBAL Login;

        public LoginController(ISqlHelper Helper,ILoginBAL Login)
        {
            helper = Helper;
            this.Login = Login;
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get(int id)
        {
            LoginData login = Login.GetLoginDetails(id);
            return Ok(login);
        }

        [HttpPost]
        public IActionResult Post([FromBody] LoginRequestData loginRequest)
        {
            LoginData login = Login.CreateLogin(loginRequest);
            return Ok(login);
        }
        [HttpGet]
        [Route("{Email}/{Password}")]

        public IActionResult GetUserNamePassword(string Email,string Password)
        {
            return Ok( Login.GetLogin(Email, Password));
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(Login.GetAllLogDetails());
        }
    }
}
