using Global.Domain.Enums;

namespace Global.Application.DTOs
{
    public class DeviceDTO
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = null!;
        public string Brand { get; set; } = null!;
        public State State { get; set; } = State.Inactive;
        public DateTime CreationTime { get; set; } = DateTime.UtcNow;
    }
}