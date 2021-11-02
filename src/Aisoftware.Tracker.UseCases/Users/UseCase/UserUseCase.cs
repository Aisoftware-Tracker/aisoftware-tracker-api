using System.Collections.Generic;
using System.Threading.Tasks;
using Aisoftware.Tracker.Borders.Users.DTO;
using Aisoftware.Tracker.UseCases.Users.Interfaces;

namespace Aisoftware.Tracker.UseCases.Login.UseCases
{
    public class UserUseCase : IUserUseCase
    {
        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<UserDTO>> FindAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<UserDTO> FindById(int userId)
        {
            throw new System.NotImplementedException();
        }

        public Task<UserDTO> Save(UserDTO request)
        {
            throw new System.NotImplementedException();
        }

        public Task<UserDTO> Update(UserDTO request)
        {
            throw new System.NotImplementedException();
        }
    }
}