using System.Collections.Generic;
using System.Threading.Tasks;
using Aisoftware.Tracker.Borders.Permissions.Entities;

namespace Aisoftware.Tracker.Repositories.Permissions.Interfaces
{
    public interface IPermissionRepository
    {
        /// <summary>
        /// @Post
        /// </summary>
        Task<Permission> Save(Permission request);

        /// <summary>
        /// @Delete
        /// </summary>
        Task<Permission> Delete(Permission request);
    }
}