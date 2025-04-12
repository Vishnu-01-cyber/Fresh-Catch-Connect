using FishingApp.BAL;
using FishingApp.Model;
using FishingApp.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FishingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellerController : ControllerBase
    {
        private readonly ISellerBAL sellerBAL;
        private readonly ISellerRepository sellerRepository;

        public SellerController(ISellerBAL sellerBAL, ISellerRepository sellerRepository)
        {
            this.sellerBAL = sellerBAL;
            this.sellerRepository = sellerRepository;
        }

        [HttpPost]
        public IActionResult PostSellerDetails([FromBody] SellerData sellerData)
        {
           string exten= sellerData.ImagePath.Substring(sellerData.ImagePath.LastIndexOf('.')+1);

            SellerIdData sellerIdData = sellerBAL.CreatSellerList(sellerData);
            string path = Path.Combine(Directory.GetCurrentDirectory(), "image", sellerIdData.FishId+"."+ exten);
            int id = sellerIdData.FishId;
            sellerIdData=sellerBAL.FileUpadete(path, id);
            return Ok(sellerIdData);
        }
        [HttpGet]
        [Route("{id:int}")]

        public IActionResult GetByIdSellerDetails(int id)
        {
            return Ok(sellerBAL.GetSellerList(id));
        }
        [HttpGet]
        
        public IActionResult GetAllSellerDetails()
        {
            return Ok(sellerBAL.GetAllSellerList());
        }
        [HttpPut]
        [Route("{id:int}")]

        public IActionResult PutSellerDetails( int id,[FromBody]SellerData sellerData)
        {
            SellerIdData sellerIdData = sellerBAL.updateSellerList(sellerData, id);
            return Ok(sellerIdData);
        }
        [HttpDelete]
        [Route("{id:int}")]
        
        public IActionResult DeleteSellerDetails(int id)
        {

            return Ok(sellerBAL.DeleteSellerList(id));
        }
        
    }
}
