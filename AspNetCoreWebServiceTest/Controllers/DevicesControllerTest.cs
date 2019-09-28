using AspNetCoreWebService.Controllers;
using AspNetCoreWebService.Controllers.Devices;
using AspNetCoreWebService.Entities;
using Xunit;

namespace AspNetCoreWebServiceTest.Controllers
{
    public class DevicesControllerTest
    {
        [Fact]
        public void DeviceRegistrationTest()
        {
            var controller = new DevicesController();
            var response = controller.Post(new Device()).Value as DeviceRegistrationResult;
            Assert.True(response.success);
        }
    }
}
