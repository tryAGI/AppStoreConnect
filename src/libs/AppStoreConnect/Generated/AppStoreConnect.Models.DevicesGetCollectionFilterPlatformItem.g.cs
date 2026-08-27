
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum DevicesGetCollectionFilterPlatformItem
    {
        /// <summary>
        /// 
        /// </summary>
        Ios,
        /// <summary>
        /// 
        /// </summary>
        MacOs,
        /// <summary>
        /// 
        /// </summary>
        Universal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DevicesGetCollectionFilterPlatformItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DevicesGetCollectionFilterPlatformItem value)
        {
            return value switch
            {
                DevicesGetCollectionFilterPlatformItem.Ios => "IOS",
                DevicesGetCollectionFilterPlatformItem.MacOs => "MAC_OS",
                DevicesGetCollectionFilterPlatformItem.Universal => "UNIVERSAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DevicesGetCollectionFilterPlatformItem? ToEnum(string value)
        {
            return value switch
            {
                "IOS" => DevicesGetCollectionFilterPlatformItem.Ios,
                "MAC_OS" => DevicesGetCollectionFilterPlatformItem.MacOs,
                "UNIVERSAL" => DevicesGetCollectionFilterPlatformItem.Universal,
                _ => null,
            };
        }
    }
}