using System;
using System.Collections.Generic;
using System.Text;
using Global.Domain.Entities;

namespace Global.Domain.Ports
{
    public interface IDeviceRepository
    {
        Task<Device> GetByIdAsync(Guid id);
        Task<IEnumerable<Device>> GetAllAsync();
        Task<Device> AddAsync(Device device);
        Task UpdateAsync(Device device);
        Task UpdatePartialAsync(Device device);
        Task DeleteAsync(Guid id);
    }
}
