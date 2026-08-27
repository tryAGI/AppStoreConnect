
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeviceConnectionType
    {
        /// <summary>
        /// 
        /// </summary>
        MobileData,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        Wifi,
        /// <summary>
        /// 
        /// </summary>
        Wire,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeviceConnectionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeviceConnectionType value)
        {
            return value switch
            {
                DeviceConnectionType.MobileData => "MOBILE_DATA",
                DeviceConnectionType.None => "NONE",
                DeviceConnectionType.Unknown => "UNKNOWN",
                DeviceConnectionType.Wifi => "WIFI",
                DeviceConnectionType.Wire => "WIRE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeviceConnectionType? ToEnum(string value)
        {
            return value switch
            {
                "MOBILE_DATA" => DeviceConnectionType.MobileData,
                "NONE" => DeviceConnectionType.None,
                "UNKNOWN" => DeviceConnectionType.Unknown,
                "WIFI" => DeviceConnectionType.Wifi,
                "WIRE" => DeviceConnectionType.Wire,
                _ => null,
            };
        }
    }
}