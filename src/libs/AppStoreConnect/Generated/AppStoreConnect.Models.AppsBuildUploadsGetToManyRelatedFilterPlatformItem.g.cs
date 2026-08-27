
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsBuildUploadsGetToManyRelatedFilterPlatformItem
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
    public static class AppsBuildUploadsGetToManyRelatedFilterPlatformItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBuildUploadsGetToManyRelatedFilterPlatformItem value)
        {
            return value switch
            {
                AppsBuildUploadsGetToManyRelatedFilterPlatformItem.Ios => "IOS",
                AppsBuildUploadsGetToManyRelatedFilterPlatformItem.MacOs => "MAC_OS",
                AppsBuildUploadsGetToManyRelatedFilterPlatformItem.TvOs => "TV_OS",
                AppsBuildUploadsGetToManyRelatedFilterPlatformItem.VisionOs => "VISION_OS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBuildUploadsGetToManyRelatedFilterPlatformItem? ToEnum(string value)
        {
            return value switch
            {
                "IOS" => AppsBuildUploadsGetToManyRelatedFilterPlatformItem.Ios,
                "MAC_OS" => AppsBuildUploadsGetToManyRelatedFilterPlatformItem.MacOs,
                "TV_OS" => AppsBuildUploadsGetToManyRelatedFilterPlatformItem.TvOs,
                "VISION_OS" => AppsBuildUploadsGetToManyRelatedFilterPlatformItem.VisionOs,
                _ => null,
            };
        }
    }
}