
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGameCenterEnabledVersionsGetToManyRelatedFilterPlatformItem
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
        TvOs,
        /// <summary>
        ///
        /// </summary>
        VisionOs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsGameCenterEnabledVersionsGetToManyRelatedFilterPlatformItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGameCenterEnabledVersionsGetToManyRelatedFilterPlatformItem value)
        {
            return value switch
            {
                AppsGameCenterEnabledVersionsGetToManyRelatedFilterPlatformItem.Ios => "IOS",
                AppsGameCenterEnabledVersionsGetToManyRelatedFilterPlatformItem.MacOs => "MAC_OS",
                AppsGameCenterEnabledVersionsGetToManyRelatedFilterPlatformItem.TvOs => "TV_OS",
                AppsGameCenterEnabledVersionsGetToManyRelatedFilterPlatformItem.VisionOs => "VISION_OS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGameCenterEnabledVersionsGetToManyRelatedFilterPlatformItem? ToEnum(string value)
        {
            return value switch
            {
                "IOS" => AppsGameCenterEnabledVersionsGetToManyRelatedFilterPlatformItem.Ios,
                "MAC_OS" => AppsGameCenterEnabledVersionsGetToManyRelatedFilterPlatformItem.MacOs,
                "TV_OS" => AppsGameCenterEnabledVersionsGetToManyRelatedFilterPlatformItem.TvOs,
                "VISION_OS" => AppsGameCenterEnabledVersionsGetToManyRelatedFilterPlatformItem.VisionOs,
                _ => null,
            };
        }
    }
}