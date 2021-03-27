using Microsoft.AspNetCore.Mvc;

namespace ApiVersionApp.Controllers.V2
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class DataController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Data from version 2";
        }
    }
}
