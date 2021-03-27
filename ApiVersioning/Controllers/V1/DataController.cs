using Microsoft.AspNetCore.Mvc;

namespace ApiVersionApp.Controllers.V1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class DataController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            return "Data from version 1";
        }
    }
}
