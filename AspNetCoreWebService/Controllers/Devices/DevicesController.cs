using AspNetCoreWebService.Controllers.Devices;
using AspNetCoreWebService.Entities;
using AspNetCoreWebService.UseCase;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebService.Controllers
{
    [Route("/bbn/v1/devices")]
    public class DevicesController : Controller
    {
        // TODO: DIする
        private readonly IDevicesUseCase _devicesUseCase = new DevicesUseCase();

        [HttpPost]
        public JsonResult Post([FromBody] Device device)
        {
            var success = _devicesUseCase.RegisterDevice(device);

            return Json(new DeviceRegistrationResult{ success = success });
        }
    }
}
