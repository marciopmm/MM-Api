using OneGlobal.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace OneGlobal.Infrastructure.Persistence.Abstractions
{
    public interface IOneGlobalDbContext
    {
        DbSet<Device> DeviceDbSet { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}