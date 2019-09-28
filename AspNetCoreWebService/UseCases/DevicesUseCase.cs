using AspNetCoreWebService.DataAccessors;
using AspNetCoreWebService.Entities;

namespace AspNetCoreWebService.UseCases
{
    public class DevicesUseCase
    {
        private readonly IDeviceDataAccessor _deviceDataAccessor;

        public DevicesUseCase(IDeviceDataAccessor deviceDataAccessor)
        {
            _deviceDataAccessor = deviceDataAccessor;
        }

        public bool RegisterDevice(Device device)
        {
            var result = _deviceDataAccessor.UpsertDevice(device);

            return result;
        }
    }
}
