using System.Collections.Generic;
using System.Threading.Tasks;
using Aisoftware.Tracker.Borders.Users.DTO;
using Aisoftware.Tracker.Borders.Users.Entities;
using Aisoftware.Tracker.Repositories.Sessions.Interfaces;
using Aisoftware.Tracker.UseCases.Session.Interfaces;
using Aisoftware.Tracker.UseCases.Tools;

namespace Aisoftware.Tracker.UseCases.Session.UseCases
{
    public class SessionUseCase : ISessionUseCase
    {
        private readonly ISessionRepository _repository;

        public SessionUseCase(ISessionRepository repository)
        {
            _repository = repository;
        }

        public async Task Delete(string cookie)
        {
            await _repository.Delete(cookie);            
        }

        public Task<UserDTO> Find(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<UserResponse> Find(string cookie)
        {
            var user = await _repository.Find(cookie);

            var dto = new MapperTool<User, UserResponse>().Mapper().Map<UserResponse>(user);

            return dto;
        }

        public async Task<UserDTO> CreateSession(UserRequest request)
        {
            var login = new Dictionary<string, string>
            {
                {"email", request.Email},
                {"password", request.Password}
            };

            var user = await _repository.CreateSession(login);

            var dto = new MapperTool<User, UserDTO>().Mapper().Map<UserDTO>(user);

            dto.Cookie = _repository.GetCookie();

            return dto;
        }
    }
}
