using System.Threading.Tasks;
using Aisoftware.Tracker.Borders.Devices.DTO;
using System.Collections.Generic;

namespace Aisoftware.Tracker.UseCases.Devices.Interfaces
{
    public interface IDeviceUseCase
    {
        /// <summary>
        /// @Get
        /// </summary>        
        Task<IEnumerable<DeviceDTO>> FindAll();

        /// <summary>
        /// @Get
        /// </summary>
        Task<DeviceDTO> FindById(int id);

        /// <summary>
        /// @Post
        /// </summary>
        Task<DeviceDTO> Save(DeviceDTO request);

        /// <summary>
        /// @Put
        /// </summary>
        Task<DeviceDTO> Update(DeviceDTO request);

        /// <summary>
        /// @Put
        /// <para/> Update total distance and hours of the Device
        /// </summary>
        Task Update(DeviceDTO request, string accumulators);

        /// <summary>
        /// @Delete
        /// </summary>
        Task Delete(int id);
    }
}