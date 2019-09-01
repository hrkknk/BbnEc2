using AspNetCoreWebService.Entities;

namespace AspNetCoreWebService.UseCase
{
    public interface IDevicesUseCase
    {
        bool RegisterDevice(Device device);
    }

    public class DevicesUseCase : IDevicesUseCase
    {
        public DevicesUseCase()
        {

        }

        public bool RegisterDevice(Device device)
        {
            return true;
        }
    }
}
