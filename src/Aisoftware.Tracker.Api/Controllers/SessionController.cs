using System;
using System.Collections.Generic;
using System.Linq;
using Aisoftware.Tracker.Borders.Health;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Aisoftware.Tracker.UseCases.Session.Interfaces;
using Aisoftware.Tracker.Borders.Users.DTO;
using System.Threading.Tasks;

namespace Aisoftware.Tracker.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SessionController : ControllerBase
    {
        private readonly ISessionUseCase _useCase;

        public SessionController(ISessionUseCase useCase)
        {
            _useCase = useCase;
        }

        [HttpPost]
        public async Task<ActionResult> Login(UserRequest request)
        {
            var response = await _useCase.CreateSession(request);

            return Ok(response);
        }
    }
}
