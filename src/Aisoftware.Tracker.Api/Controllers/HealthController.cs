using System;
using Aisoftware.Tracker.Borders.Health;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Aisoftware.Tracker.Api.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class HealthController : ControllerBase
    {
        private readonly ILogger<HealthController> _logger;

        public HealthController(ILogger<HealthController> logger)
        {
            _logger = logger;
        }

        [HttpGet]   
        public ActionResult Get()
        {
            return Ok(new Health {
                Status = "ON",
                Info = "Its Running!!!",
                Now = DateTime.Now,
                Version = "1.0"
            });
        }
    }
}
