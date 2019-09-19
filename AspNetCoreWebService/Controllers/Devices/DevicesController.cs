using AspNetCoreWebService.Controllers.Devices;
using AspNetCoreWebService.DataAccessors;
using AspNetCoreWebService.Entities;
using AspNetCoreWebService.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebService.Controllers
{
    [Route("/bbn/v1/devices")]
    public class DevicesController : Controller
    {
        private readonly DevicesUseCase _devicesUseCase = new DevicesUseCase(DeviceDataAccessor.Instance);

        [HttpPost]
        public JsonResult Post([FromBody] Device device)
        {
            var success = _devicesUseCase.RegisterDevice(device);

            return Json(new DeviceRegistrationResult{ success = success });
        }
    }
}
