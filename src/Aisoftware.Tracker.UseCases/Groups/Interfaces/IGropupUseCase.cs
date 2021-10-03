using System.Threading.Tasks;
using System.Collections.Generic;
using Aisoftware.Tracker.Borders.Groups.DTO;

namespace Aisoftware.Tracker.UseCases.Groups.Interfaces
{
    public interface IGroupUseCase
    {
        /// <summary>
        /// @Get
        /// </summary>        
        Task<IEnumerable<GroupDTO>> FindAll();

        /// <summary>
        /// @Get        
        /// <para/> userId: Standard users can use this only with their own userId
        /// <para/> all: Can only be used by admins or managers to fetch all entities
        /// </summary>
        Task<IEnumerable<GroupDTO>> FindById(int? userId, bool? all);

        /// <summary>
        /// @Post
        /// </summary>
        Task<GroupDTO> Save(GroupDTO request);

        /// <summary>
        /// @Put
        /// </summary>
        Task<GroupDTO> Update(GroupDTO request);

        /// <summary>
        /// @Delete
        /// </summary>
        Task Delete(int id);
    }
}