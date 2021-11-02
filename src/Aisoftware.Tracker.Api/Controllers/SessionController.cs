using System;
using System.Collections.Generic;
using System.Linq;
using Aisoftware.Tracker.Borders.Health;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Aisoftware.Tracker.UseCases.Session.Interfaces;
using Aisoftware.Tracker.Borders.Users.DTO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Net;
using System.Net.Http;
using System.Web;

namespace Aisoftware.Tracker.Api.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
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

            var cookieOptions = new CookieOptions
            {
                Secure = false,
                HttpOnly = false,
                SameSite = SameSiteMode.None
            };

            ///TODO transformar JSESSIONID em uma constante de classe e remover do jsonconfig
            Response.Cookies.Append("JSESSIONID", response.Cookie.Value, cookieOptions);

            return Ok(response);
        }


        [HttpGet]
        public async Task<ActionResult> Find()
        {
            string cookie = Request.Cookies["JSESSIONID"];

            var response = await _useCase.Find(cookie);

            return Ok(response);
        }

    }
}
