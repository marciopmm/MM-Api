using Global.Domain.Enums;

namespace Global.Application.DTOs
{
    public class AddDeviceDtoRequest
    {
        public string Name { get; set; } = null!;
        public string Brand { get; set; } = null!;
        public State State { get; set; } = State.Inactive;
    }
}