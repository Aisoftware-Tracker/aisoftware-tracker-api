using Microsoft.AspNetCore.Mvc;
using Aisoftware.Tracker.UseCases.Session.Interfaces;
using Aisoftware.Tracker.Borders.Users.DTO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Aisoftware.Tracker.UseCases.Tools;
using System;
using System.Web;
using Aisoftware.Tracker.Borders.Constants;

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
            var user = await _useCase.CreateSession(request);

            var cookieOptions = new CookieOptions
            {
                Secure = false,
                HttpOnly = false,
                SameSite = SameSiteMode.None
            };

            ///TODO transformar JSESSIONID em uma constante de classe e remover do jsonconfig
            Response.Cookies.Append(CookieName.JSESSIONID, user.Cookie.Value, cookieOptions);

            var response = new MapperTool<UserDTO, UserResponse>().Mapper().Map<UserResponse>(user);

            return Ok(response);
        }


        [HttpGet]
        public async Task<ActionResult> Find()
        {
            string cookie = Request.Cookies[CookieName.JSESSIONID];

            var response = await _useCase.Find(cookie);

            return Ok(response);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete()
        {
            string cookie = Request.Cookies[CookieName.JSESSIONID];

            await _useCase.Delete(cookie);
            ///TODO deletar cookie a nivel do escopo local tambem
            return Ok();
        }

    }
}
