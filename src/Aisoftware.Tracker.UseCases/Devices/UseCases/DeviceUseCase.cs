using System.Threading.Tasks;
using Aisoftware.Tracker.UseCases.Devices.Interfaces;
using System.Collections.Generic;
using Aisoftware.Tracker.Borders.Devices.DTO;
using Aisoftware.Tracker.Repositories.Devices.Interfaces;
using Aisoftware.Tracker.Borders.Devices.Entities;
using Aisoftware.Tracker.UseCases.Tools;

namespace Aisoftware.Tracker.UseCases.Devices.UseCases
{
    public class DeviceUseCase : IDeviceUseCase
    {
        private readonly IDeviceRepository _repository;

        public DeviceUseCase(IDeviceRepository repository)
        {
            _repository = repository;
        }

        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<DeviceDTO>> FindAll()
        {
            var devices = await _repository.FindAll();

            var dtos = new MapperTool<Device, DeviceDTO>().Mapper().Map<IEnumerable<DeviceDTO>>(devices);

            return dtos;
        }

        public async Task<DeviceDTO> FindById(int id)
        {
            var device = await _repository.FindById(id);

            var dto = new MapperTool<Device, DeviceDTO>().Mapper().Map<DeviceDTO>(device);

            return dto;
        }

        public async Task<DeviceDTO> Save(DeviceDTO request)
        {
            var device = new MapperTool<Device, DeviceDTO>().Mapper().Map<Device>(request);

            var response = await _repository.Save(device);

            var dto = new MapperTool<Device, DeviceDTO>().Mapper().Map<DeviceDTO>(response);

            return dto;
        }

        public async Task<DeviceDTO> Update(DeviceDTO request)
        {
            var device = new MapperTool<Device, DeviceDTO>().Mapper().Map<Device>(request);

            var response = await _repository.Update(device);

            var dto = new MapperTool<Device, DeviceDTO>().Mapper().Map<DeviceDTO>(response);

            return dto;
        }

        public async Task Update(DeviceDTO request, string accumulators)
        {
            var device = new MapperTool<Device, DeviceDTO>().Mapper().Map<Device>(request);

            await _repository.Update(device, accumulators);
        }
    }
}