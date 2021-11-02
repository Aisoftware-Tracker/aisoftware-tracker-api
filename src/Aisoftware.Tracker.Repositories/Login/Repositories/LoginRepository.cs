using System.Threading.Tasks;
using Aisoftware.Tracker.Borders.Users.Entities;
using Aisoftware.Tracker.Borders.Users.DTO;
using Aisoftware.Tracker.Repositories.Login.Interfaces;

namespace Aisoftware.Tracker.Repositories.Login.Repositories
{
    public class LoginRepository : ILoginRepository
    {

        public LoginRepository()
        {

        }

        public Task<User> Login(UserDTO request)
        {
            throw new System.NotImplementedException();
        }

        public Task Logout()
        {
            throw new System.NotImplementedException();
        }

        public Task<User> GetByToken(string token)
        {
            throw new System.NotImplementedException();
        }
    }
}