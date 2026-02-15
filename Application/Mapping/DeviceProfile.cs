using AutoMapper;
using Global.Application.DTOs;
using Global.Domain.Entities;

namespace Global.Application.Mapping;

public class DeviceProfile : Profile
{
    public DeviceProfile()
    {
        CreateMap<CreateDeviceRequest, Device>()
            .ForCtorParam("id", opt => opt.MapFrom(_ => Guid.NewGuid()))
            .ForCtorParam("creationTime", opt => opt.MapFrom(_ => DateTime.UtcNow));
        CreateMap<Device, DeviceDTO>()
            .ForMember(dest => dest.State, opt => opt.MapFrom(src => src.State.ToString()));
        CreateMap<DeviceDTO, Device>()
            .ForMember(d => d.Id, opt => opt.Ignore())
            .ForMember(d => d.CreationTime, opt => opt.Ignore());
    }
}