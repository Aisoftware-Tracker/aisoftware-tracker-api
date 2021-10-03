using System.Threading.Tasks;
using Aisoftware.Tracker.Repositories.Devices.Interfaces;
using System.Collections.Generic;
using Aisoftware.Tracker.Borders.Devices.Entities;

namespace Aisoftware.Tracker.Repositories.Devices.Repositories
{
    public class DeviceRepository : IDeviceRepository
    {
        private const string DEVICES = "devices";
        private const string DEVICES_ID = "devices/{id}";
        private const string DEVICES_ID_ACCUMULATORS = "devices/{id}/accumulators";

        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Device>> FindAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<Device> FindById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Device> Save(Device request)
        {
            throw new System.NotImplementedException();
        }

        public Task<Device> Update(Device request)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Device request, string accumulators)
        {
            throw new System.NotImplementedException();
        }
    }
}