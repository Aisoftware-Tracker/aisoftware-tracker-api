using System.Threading.Tasks;
using Aisoftware.Tracker.Borders.Permissions.DTO;

namespace Aisoftware.Tracker.UseCases.Permissions.Interfaces
{
    public interface IPermissionUseCase
    {
        /// <summary>
        /// @Post
        /// </summary>
        Task<PermissionDTO> Save(PermissionDTO request);

        /// <summary>
        /// @Delete
        /// </summary>
        Task<PermissionDTO> Delete(PermissionDTO request);
    }
}