
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum DevicesGetCollectionFieldsDevice
    {
        /// <summary>
        ///
        /// </summary>
        AddedDate,
        /// <summary>
        ///
        /// </summary>
        DeviceClass,
        /// <summary>
        ///
        /// </summary>
        Model,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        Platform,
        /// <summary>
        ///
        /// </summary>
        Status,
        /// <summary>
        ///
        /// </summary>
        Udid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DevicesGetCollectionFieldsDeviceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DevicesGetCollectionFieldsDevice value)
        {
            return value switch
            {
                DevicesGetCollectionFieldsDevice.AddedDate => "addedDate",
                DevicesGetCollectionFieldsDevice.DeviceClass => "deviceClass",
                DevicesGetCollectionFieldsDevice.Model => "model",
                DevicesGetCollectionFieldsDevice.Name => "name",
                DevicesGetCollectionFieldsDevice.Platform => "platform",
                DevicesGetCollectionFieldsDevice.Status => "status",
                DevicesGetCollectionFieldsDevice.Udid => "udid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DevicesGetCollectionFieldsDevice? ToEnum(string value)
        {
            return value switch
            {
                "addedDate" => DevicesGetCollectionFieldsDevice.AddedDate,
                "deviceClass" => DevicesGetCollectionFieldsDevice.DeviceClass,
                "model" => DevicesGetCollectionFieldsDevice.Model,
                "name" => DevicesGetCollectionFieldsDevice.Name,
                "platform" => DevicesGetCollectionFieldsDevice.Platform,
                "status" => DevicesGetCollectionFieldsDevice.Status,
                "udid" => DevicesGetCollectionFieldsDevice.Udid,
                _ => null,
            };
        }
    }
}