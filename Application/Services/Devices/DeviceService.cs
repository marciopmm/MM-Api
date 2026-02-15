using Global.Domain.Entities;
using Global.Domain.Enums;
using Global.Domain.Ports;

namespace Global.Application.Services.Devices
{
    public class DeviceService : IDeviceService
    {
        private readonly IDeviceRepository _deviceRepository;

        public DeviceService(IDeviceRepository deviceRepository)
        {
            _deviceRepository = deviceRepository;
        }

        public List<Device> GetAllDevices()
        {
            throw new NotImplementedException();
        }
        public List<Device> GetDevicesByState(State state)
        {
            throw new NotImplementedException();
        }
        public List<Device> GetDevicesByBrand(string brand)
        {
            throw new NotImplementedException();
        }
        public Device GetDeviceById(int id)
        {
            throw new NotImplementedException();
        }
        public void AddDevice(Device device)
        {
            throw new NotImplementedException();
        }
        public void UpdateDevice(Device device)
        {
            throw new NotImplementedException();
        }
        public void DeleteDevice(int id)
        {
            throw new NotImplementedException();
        }
    }
}
