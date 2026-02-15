using AutoMapper;
using Global.Application.DTOs;
using Global.Domain.Entities;
using Global.Domain.Enums;

namespace Global.Application.Mapping;

public class DeviceProfile : Profile
{
    public DeviceProfile()
    {
        CreateMap<AddDeviceDtoRequest, Device>()
            .ConstructUsing(src =>
                new Device(src.Name, src.Brand, Enum.Parse<State>(src.State, true), DateTime.UtcNow));
        CreateMap<Device, DeviceDTO>()
            .ForMember(dest => dest.State, opt => opt.MapFrom(src => src.State.ToString()));
        CreateMap<DeviceDTO, Device>()
            .ForCtorParam("state", opt => opt.MapFrom(src => Enum.Parse<State>(src.State, true)))
            .ForCtorParam("creationTime", opt => opt.MapFrom(src => src.CreationTime == default ? DateTime.UtcNow : src.CreationTime))
            .ForMember(d => d.Id, opt => opt.Ignore())
            .ForMember(d => d.CreationTime, opt => opt.Ignore());
    }
}