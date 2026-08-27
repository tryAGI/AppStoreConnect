
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsBackgroundAssetsGetToManyRelatedFilterVersionsPlatform
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
    public static class AppsBackgroundAssetsGetToManyRelatedFilterVersionsPlatformExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBackgroundAssetsGetToManyRelatedFilterVersionsPlatform value)
        {
            return value switch
            {
                AppsBackgroundAssetsGetToManyRelatedFilterVersionsPlatform.Ios => "IOS",
                AppsBackgroundAssetsGetToManyRelatedFilterVersionsPlatform.MacOs => "MAC_OS",
                AppsBackgroundAssetsGetToManyRelatedFilterVersionsPlatform.TvOs => "TV_OS",
                AppsBackgroundAssetsGetToManyRelatedFilterVersionsPlatform.VisionOs => "VISION_OS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBackgroundAssetsGetToManyRelatedFilterVersionsPlatform? ToEnum(string value)
        {
            return value switch
            {
                "IOS" => AppsBackgroundAssetsGetToManyRelatedFilterVersionsPlatform.Ios,
                "MAC_OS" => AppsBackgroundAssetsGetToManyRelatedFilterVersionsPlatform.MacOs,
                "TV_OS" => AppsBackgroundAssetsGetToManyRelatedFilterVersionsPlatform.TvOs,
                "VISION_OS" => AppsBackgroundAssetsGetToManyRelatedFilterVersionsPlatform.VisionOs,
                _ => null,
            };
        }
    }
}