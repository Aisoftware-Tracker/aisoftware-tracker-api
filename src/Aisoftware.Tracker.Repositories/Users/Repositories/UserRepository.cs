using System.Collections.Generic;
using System.Threading.Tasks;
using Aisoftware.Tracker.Borders.Users.Entities;
using Aisoftware.Tracker.Repositories.Users.Interfaces;

namespace Aisoftware.Tracker.Repositories.Login.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<User>> FindAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<User> FindById(int userId)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> Save(User request)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> Update(User request)
        {
            throw new System.NotImplementedException();
        }
    }
}