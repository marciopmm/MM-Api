using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Global.Domain.Entities;

namespace Global.Infrastructure.Persistence.Db
{
    public class GlobalDbContext : DbContext
    {
        private readonly string _dbPath;

        public virtual DbSet<Device> DeviceDbSet { get; set; } = null!;

        public GlobalDbContext(IConfiguration configuration)
        {
            _dbPath = configuration.GetConnectionString("Default") ?? "global.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={_dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the Device entity
            modelBuilder.Entity<Device>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Brand).IsRequired();
                entity.Property(e => e.State).IsRequired();
                entity.Property(e => e.CreationTime).IsRequired();
            });
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            // You can add custom logic here before saving changes, such as auditing or validation
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}