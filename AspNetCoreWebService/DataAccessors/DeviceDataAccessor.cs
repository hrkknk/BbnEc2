using AspNetCoreWebService.Entities;

namespace AspNetCoreWebService.DataAccessors
{
    public class DeviceDataAccessor : IDeviceDataAccessor
    {
        public static DeviceDataAccessor Instance = new DeviceDataAccessor();

        private DeviceDataAccessor() { }

        public bool UpsertDevice(Device device)
        {
            // 動作確認のために特定のIDだったら false を返してみる
            if (device.Id == "NGDevice")
            {
                return false;
            }

            return true;
        }
    }
}
