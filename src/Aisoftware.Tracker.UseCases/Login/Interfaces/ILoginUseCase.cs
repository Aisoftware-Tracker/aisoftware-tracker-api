using System.Threading.Tasks;
using Aisoftware.Tracker.Borders.Users.DTO;

namespace Aisoftware.Tracker.UseCases.Login.Interfaces
{
    public interface ILoginUseCase
    {
        /// <summary>
        /// Login
        /// </summary>
        /// <returns>
        /// return user (session)
        /// </returns>
        Task<UserDTO> Login(UserDTO request);
        Task<UserDTO> GetByToken(string token);
        Task Logout();
    }
}
