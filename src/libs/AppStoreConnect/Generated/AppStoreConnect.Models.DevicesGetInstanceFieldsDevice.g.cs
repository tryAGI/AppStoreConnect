
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum DevicesGetInstanceFieldsDevice
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
    public static class DevicesGetInstanceFieldsDeviceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DevicesGetInstanceFieldsDevice value)
        {
            return value switch
            {
                DevicesGetInstanceFieldsDevice.AddedDate => "addedDate",
                DevicesGetInstanceFieldsDevice.DeviceClass => "deviceClass",
                DevicesGetInstanceFieldsDevice.Model => "model",
                DevicesGetInstanceFieldsDevice.Name => "name",
                DevicesGetInstanceFieldsDevice.Platform => "platform",
                DevicesGetInstanceFieldsDevice.Status => "status",
                DevicesGetInstanceFieldsDevice.Udid => "udid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DevicesGetInstanceFieldsDevice? ToEnum(string value)
        {
            return value switch
            {
                "addedDate" => DevicesGetInstanceFieldsDevice.AddedDate,
                "deviceClass" => DevicesGetInstanceFieldsDevice.DeviceClass,
                "model" => DevicesGetInstanceFieldsDevice.Model,
                "name" => DevicesGetInstanceFieldsDevice.Name,
                "platform" => DevicesGetInstanceFieldsDevice.Platform,
                "status" => DevicesGetInstanceFieldsDevice.Status,
                "udid" => DevicesGetInstanceFieldsDevice.Udid,
                _ => null,
            };
        }
    }
}