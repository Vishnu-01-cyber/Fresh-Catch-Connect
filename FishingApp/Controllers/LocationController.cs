using DAL;
using FishingApp.BAL;
using FishingApp.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FishingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ISqlHelper sqlHelper;
        private readonly ILocationBAL locationBAL;

        public LocationController(ISqlHelper sqlHelper,ILocationBAL locationBAL)
        {
            this.sqlHelper = sqlHelper;
            this.locationBAL = locationBAL;
        }

        [HttpGet]
        public IActionResult GetCountry()
        {
            Location location = new Location();
            List<Country> country = locationBAL.GetCountryDetails();
            location.Countries = country;
            List<State> states = locationBAL.GetStateDetails();
            location.States = states;
            List<District> districts = locationBAL.GetDistrictDetails();
            location.Districts = districts;

            return Ok(location);
        }


        //[HttpGet]
        //public IActionResult GetCoutryData()
        //{
        //  List<Country> country = locationBAL.GetCountryDetails();
        //    return Ok(country);
        //}
        //[HttpGet]

        //public IActionResult GetStateData()
        //{
        //    List<State> states = locationBAL.GetStateDetails();
        //    return Ok(states);
        //}

        //[HttpGet]

        //public IActionResult GetDistrictData()
        //{
        //    List<District> districts = locationBAL.GetDistrictDetails();
        //    return Ok(districts);
        //}
    }
}
