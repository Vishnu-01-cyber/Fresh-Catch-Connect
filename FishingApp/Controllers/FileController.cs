using FishingApp.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FishingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        [HttpPost]


        public IActionResult UploadFile(IFormFile file)
        {
            FileResponse fileResponse = new FileResponse();
            try
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), "image", file.FileName);
                FileStream fileStream = new FileStream(path, FileMode.Create);
                file.CopyTo(fileStream);
                fileResponse.Status = Status.Success;
                fileResponse.Message = "Uploaded Successfully.";
            }
            catch (Exception)
            {
                fileResponse.Status = Status.Failed;

                return BadRequest(fileResponse);
            }
            return Ok(fileResponse);
        }
    }
}
