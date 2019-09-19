using AspNetCoreWebService.Entities;

namespace AspNetCoreWebService.DataAccessors
{
    public interface IDeviceDataAccessor
    {
        bool UpsertDevice(Device device);
    }
}
