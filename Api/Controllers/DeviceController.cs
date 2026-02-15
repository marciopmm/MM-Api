using Microsoft.AspNetCore.Mvc;
using Global.Application.DTOs;
using Global.Application.Abstractions.Services;
using Global.Domain.Entities;

namespace Global.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeviceController : ControllerBase
    {
        private readonly IDeviceDtoService _deviceDtoService;

        public DeviceController(IDeviceDtoService deviceDtoService)
        {
            _deviceDtoService = deviceDtoService;
        }

        [HttpGet(Name = "Devices")]
        public async Task<IEnumerable<DeviceDTO>> Get()
        {
            return await _deviceDtoService.GetAllDevicesAsync();
        }

        [HttpPost(Name = "Devices")]
        public async Task<DeviceDTO> Post([FromBody] AddDeviceDtoRequest addDeviceDto)
        {
            return await _deviceDtoService.AddDeviceAsync(addDeviceDto);
        }
    }
}
