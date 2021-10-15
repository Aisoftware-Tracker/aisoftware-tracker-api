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
        private AisoftwareTrackerCodeBehind _moviyCode;

        private UserDTO _user;
        private string login;

        private readonly string TOKEN_REMEMBER = "JSESSIONID";
        private readonly string TOKEN = "token";
        private readonly string YES = "S";

        public SessionController(ISessionUseCase useCase)
        {
            _useCase = useCase;
        }

        [HttpPost]
        public async Task<ActionResult> Login(UserRequest request)
        {
            var response = await _useCase.CreateSession(request);

            var isLogged = response != null;

            if (isLogged)
            {
                TokenRemember = true; //TODO Lembrar senha //isRemember; //Colocar esse primeiro, pq os proximos usam esse valor
                login = response.Email;
                Token = response.Token.ToString();
                _user = response;
            }

            return Ok(response);
        }

        public void Logoff()
        {
            _user = null;
            TokenRemember = false;
            Token = null;
            login = string.Empty;
        }

        public bool TokenRemember
        {
            get => _moviyCode.GetValue(TOKEN_REMEMBER) == YES;
            set => _moviyCode.SaveValue(TOKEN_REMEMBER, value, null);
        }
        
        public string Token
        {
            get => _moviyCode.GetValue(TOKEN);
            set => _moviyCode.SaveValue(TOKEN, value, null);
        }
    }
}
