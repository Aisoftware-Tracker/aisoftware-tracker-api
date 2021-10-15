﻿using System;
using System.Collections.Generic;
using System.Linq;
using Aisoftware.Tracker.Borders.Health;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Aisoftware.Tracker.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
            return Ok(new Health
            {
                Status = "ON",
                Info = "Its Running!!!",
                Now = DateTime.Now
            });
        }

        // public static ActionResult Alert(this ActionResult result, HttpResponse response, string text)
        // {
        //     response.Cookies.Append(
        //         "alert",
        //         text,
        //         new CookieOptions() { Path = "/" }
        //     );

        //     return result;
        // }
    }
}
