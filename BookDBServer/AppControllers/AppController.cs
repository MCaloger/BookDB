using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookDBServer.AppControllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class AppController : ControllerBase
    {
        [HttpGet]
        [Route("/")]
        public IActionResult ServeFrontend()
        {
            return File("index.html", "text/html");
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        [Route("/error")]
        public IActionResult HandleError()
        {
            return BadRequest("Error");
        }

        
        
    }
}
