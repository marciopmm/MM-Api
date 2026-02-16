using AutoMapper;
using Global.Application.DTOs;
using Global.Domain.Entities;
using Global.Domain.Enums;
using Global.Domain.Ports;

namespace Global.Application.Services.Devices
{
    internal class DeviceService : IDeviceService
    {
        private readonly IDeviceRepository _deviceRepository;

        public DeviceService(IDeviceRepository deviceRepository)
        {
            _deviceRepository = deviceRepository;
        }

        public async Task<IEnumerable<Device>> GetAllDevicesAsync()
        {
            return await _deviceRepository.GetAllAsync();
        }
        
        public async Task<IEnumerable<Device>> GetDevicesByStateAsync(State state)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Device>> GetDevicesByBrandAsync(string brand)
        {
            throw new NotImplementedException();
        }

        public async Task<Device> GetDeviceByIdAsync(Guid id)
        {
            return await _deviceRepository.GetByIdAsync(id);
        }

        public async Task<Device> AddDeviceAsync(Device device)
        {
            return await _deviceRepository.AddAsync(device);
        }

        public async Task<Device> UpdateDeviceAsync(Guid id, DevicePatch devicePatch)
        {   
            //TODO: Implement update logic in the repository
            return await _deviceRepository.UpdateAsync(id, devicePatch);
        }

        public async Task<Device> UpdateDevicePartialAsync(Guid id, DevicePatch devicePatch)
        {
            //TODO: Implement partial update logic in the repository
            return await _deviceRepository.UpdatePartialAsync(id, devicePatch);
        }

        public async Task DeleteDeviceAsync(Guid id)
        {
            await _deviceRepository.DeleteAsync(id);
        }
    }
}
