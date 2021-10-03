using System.Threading.Tasks;
using Aisoftware.Tracker.Borders.Devices.Entities;
using System.Collections.Generic;

namespace Aisoftware.Tracker.Repositories.Devices.Interfaces
{
    public interface IDeviceRepository
    {
        /// <summary>
        /// @Get
        /// </summary>        
        Task<IEnumerable<Device>> FindAll();

        /// <summary>
        /// @Get
        /// </summary>
        Task<Device> FindById(int id);

        /// <summary>
        /// @Post
        /// </summary>
        Task<Device> Save(Device request);

        /// <summary>
        /// @Put
        /// </summary>
        Task<Device> Update(Device request);

        /// <summary>
        /// @Put
        /// <para/> Update total distance and hours of the Device
        /// </summary>
        Task Update(Device request, string accumulators);

        /// <summary>
        /// @Delete
        /// </summary>
        Task Delete(int id);
    }
}