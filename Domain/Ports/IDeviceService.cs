using Global.Domain.Entities;
using Global.Domain.Enums;

namespace Global.Domain.Ports
{
    public interface IDeviceService
    {
        Task<IEnumerable<Device>> GetAllDevicesAsync();
        Task<IEnumerable<Device>> GetDevicesByStateAsync(State state);
        Task<IEnumerable<Device>> GetDevicesByBrandAsync(string brand);
        Task<Device> GetDeviceByIdAsync(int id);
        Task<Device> AddDeviceAsync(Device device);
        Task UpdateDeviceAsync(Device device);
        Task DeleteDeviceAsync(int id);
    }
}
