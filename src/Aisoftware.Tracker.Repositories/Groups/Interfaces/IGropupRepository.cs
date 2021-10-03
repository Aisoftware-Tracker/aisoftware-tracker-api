using System.Threading.Tasks;
using Aisoftware.Tracker.Borders.Groups.Entities;
using System.Collections.Generic;

namespace Aisoftware.Tracker.Repositories.Groups.Interfaces
{
    public interface IGroupRepository
    {
        /// <summary>
        /// @Get
        /// </summary>        
        Task<IEnumerable<Group>> FindAll();

        /// <summary>
        /// @Get        
        /// <para/> userId: Standard users can use this only with their own userId
        /// <para/> all: Can only be used by admins or managers to fetch all entities
        /// </summary>
        Task<IEnumerable<Group>> FindById(int? userId, bool? all);

        /// <summary>
        /// @Post
        /// </summary>
        Task<Group> Save(Group request);

        /// <summary>
        /// @Put
        /// </summary>
        Task<Group> Update(Group request);

        /// <summary>
        /// @Delete
        /// </summary>
        Task Delete(int id);
    }
}