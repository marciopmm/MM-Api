using Global.Application.DTOs;

namespace Global.Application.Abstractions.Services.DeviceDTOs;

public interface IDeviceDtoService
{
    Task<IEnumerable<DeviceDTO>> GetAllDevicesAsync();
    Task<IEnumerable<DeviceDTO>> GetDevicesByStateAsync(string state);
    Task<IEnumerable<DeviceDTO>> GetDevicesByBrandAsync(string brand);
    Task<DeviceDTO> GetDeviceByIdAsync(int id);
    Task AddDeviceAsync(DeviceDTO deviceDto);
    Task UpdateDeviceAsync(DeviceDTO deviceDto);
    Task DeleteDeviceAsync(int id);
}