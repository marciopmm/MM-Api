using Global.Domain.Entities;
using Global.Domain.Enums;

namespace Global.Domain.Ports
{
    public interface IDeviceService
    {
        List<Device> GetAllDevices();
        List<Device> GetDevicesByState(State state);
        List<Device> GetDevicesByBrand(string brand);
        Device GetDeviceById(int id);
        void AddDevice(Device device);
        void UpdateDevice(Device device);
        void DeleteDevice(int id);
    }
}
