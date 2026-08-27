
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeviceCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Devices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeviceCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeviceCreateRequestDataType value)
        {
            return value switch
            {
                DeviceCreateRequestDataType.Devices => "devices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeviceCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "devices" => DeviceCreateRequestDataType.Devices,
                _ => null,
            };
        }
    }
}