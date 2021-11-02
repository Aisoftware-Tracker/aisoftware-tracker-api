using System.Threading.Tasks;
using System.Collections.Generic;
using Aisoftware.Tracker.Borders.Users.DTO;

namespace Aisoftware.Tracker.UseCases.Users.Interfaces
{
    public interface IUserUseCase
    {
        /// <summary>
        /// @Get
        /// </summary>        
        Task<IEnumerable<UserDTO>> FindAll();

        /// <summary>
        /// @Get
        /// <para/>Can only be used by admin or manager users
        /// </summary>
        Task<UserDTO> FindById(int userId);

        /// <summary>
        /// @Post
        /// </summary>
        Task<UserDTO> Save(UserDTO request);

        /// <summary>
        /// @Put
        /// </summary>
        Task<UserDTO> Update(UserDTO request);

        /// <summary>
        /// @Delete
        /// </summary>
        Task Delete(int id);
    }
}