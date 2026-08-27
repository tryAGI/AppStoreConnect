
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppCategoriesGetCollectionFilterPlatform
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
    public static class AppCategoriesGetCollectionFilterPlatformExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCategoriesGetCollectionFilterPlatform value)
        {
            return value switch
            {
                AppCategoriesGetCollectionFilterPlatform.Ios => "IOS",
                AppCategoriesGetCollectionFilterPlatform.MacOs => "MAC_OS",
                AppCategoriesGetCollectionFilterPlatform.TvOs => "TV_OS",
                AppCategoriesGetCollectionFilterPlatform.VisionOs => "VISION_OS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCategoriesGetCollectionFilterPlatform? ToEnum(string value)
        {
            return value switch
            {
                "IOS" => AppCategoriesGetCollectionFilterPlatform.Ios,
                "MAC_OS" => AppCategoriesGetCollectionFilterPlatform.MacOs,
                "TV_OS" => AppCategoriesGetCollectionFilterPlatform.TvOs,
                "VISION_OS" => AppCategoriesGetCollectionFilterPlatform.VisionOs,
                _ => null,
            };
        }
    }
}