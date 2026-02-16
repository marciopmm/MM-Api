using Global.Domain.Enums;

namespace Global.Application.DTOs
{
    public class UpdateDeviceDtoRequest
    {
        public string Name { get; set; } = null!;
        public string Brand { get; set; } = null!;
        public State? State { get; set; } = null!;

        public UpdateDeviceDtoRequest(Guid id, string name, string brand, State? state)
        {
            Name = name;
            Brand = brand;
            State = state;
        }
    }
}