using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace micro_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnvironmentController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            return Environment.MachineName;
        }
    }
}
