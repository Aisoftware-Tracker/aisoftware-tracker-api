using System.Threading.Tasks;
using Aisoftware.Tracker.Borders.Users.Entities;
using Aisoftware.Tracker.Borders.Users.DTO;

namespace Aisoftware.Tracker.Repositories.Login.Interfaces
{
    public interface ILoginRepository
    {
        /// <summary>
        /// Login
        /// </summary>
        /// <returns>
        /// return user (session)
        /// </returns>
        Task<User> Login(UserDTO request);
        Task<User> GetByToken(string token);
        Task Logout();
    }
}