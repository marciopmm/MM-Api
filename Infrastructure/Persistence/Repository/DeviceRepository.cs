using Global.Domain.Entities;
using Global.Domain.Exceptions;
using Global.Domain.Ports;
using Global.Infrastructure.Persistence.Db;
using Microsoft.EntityFrameworkCore;

namespace Global.Infrastructure.Persistence.Repository;

public class DeviceRepository : IDeviceRepository
{
    private readonly GlobalDbContext _context;

    public DeviceRepository(GlobalDbContext context)
    {
        _context = context;
    }

    public async Task<Device> GetByIdAsync(Guid id)
    {
        return await _context.DeviceDbSet.FindAsync(id) ?? throw new DeviceNotFoundException(id);
    }

    public async Task<IEnumerable<Device>> GetAllAsync()
    {
        return await _context.DeviceDbSet.ToListAsync();
    }
    
    public async Task<Device> AddAsync(Device device)
    {
        await _context.DeviceDbSet.AddAsync(device);
        await _context.SaveChangesAsync();
        return device;
    }

    public async Task UpdateAsync(Device device)
    {
        _context.DeviceDbSet.Update(device);
        await _context.SaveChangesAsync();
    }

    public async Task UpdatePartialAsync(Device device)
    {
        _context.DeviceDbSet.Attach(device);
        _context.Entry(device).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var device = await GetByIdAsync(id);
        _context.DeviceDbSet.Remove(device);
        await _context.SaveChangesAsync();
    }
}