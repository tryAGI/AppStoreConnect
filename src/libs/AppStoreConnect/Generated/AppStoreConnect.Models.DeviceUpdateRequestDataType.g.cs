
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum DeviceUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        Devices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeviceUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeviceUpdateRequestDataType value)
        {
            return value switch
            {
                DeviceUpdateRequestDataType.Devices => "devices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeviceUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "devices" => DeviceUpdateRequestDataType.Devices,
                _ => null,
            };
        }
    }
}