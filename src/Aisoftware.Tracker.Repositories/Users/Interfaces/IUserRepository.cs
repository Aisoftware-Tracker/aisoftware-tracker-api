using System.Threading.Tasks;
using Aisoftware.Tracker.Borders.Users.Entities;
using System.Collections.Generic;

namespace Aisoftware.Tracker.Repositories.Users.Interfaces
{
    public interface IUserRepository
    {
        /// <summary>
        /// @Get
        /// </summary>        
        Task<IEnumerable<User>> FindAll();

        /// <summary>
        /// @Get
        /// <para/>Can only be used by admin or manager users
        /// </summary>
        Task<User> FindById(int userId);

        /// <summary>
        /// @Post
        /// </summary>
        Task<User> Save(User request);

        /// <summary>
        /// @Put
        /// </summary>
        Task<User> Update(User request);

        /// <summary>
        /// @Delete
        /// </summary>
        Task Delete(int id);
    }
}