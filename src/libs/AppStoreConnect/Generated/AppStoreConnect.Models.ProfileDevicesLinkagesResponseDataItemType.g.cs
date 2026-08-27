
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProfileDevicesLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Devices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProfileDevicesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfileDevicesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                ProfileDevicesLinkagesResponseDataItemType.Devices => "devices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfileDevicesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "devices" => ProfileDevicesLinkagesResponseDataItemType.Devices,
                _ => null,
            };
        }
    }
}