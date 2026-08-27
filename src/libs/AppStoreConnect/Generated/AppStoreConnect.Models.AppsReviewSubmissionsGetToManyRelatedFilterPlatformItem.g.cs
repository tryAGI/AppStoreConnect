
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsReviewSubmissionsGetToManyRelatedFilterPlatformItem
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
    public static class AppsReviewSubmissionsGetToManyRelatedFilterPlatformItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsReviewSubmissionsGetToManyRelatedFilterPlatformItem value)
        {
            return value switch
            {
                AppsReviewSubmissionsGetToManyRelatedFilterPlatformItem.Ios => "IOS",
                AppsReviewSubmissionsGetToManyRelatedFilterPlatformItem.MacOs => "MAC_OS",
                AppsReviewSubmissionsGetToManyRelatedFilterPlatformItem.TvOs => "TV_OS",
                AppsReviewSubmissionsGetToManyRelatedFilterPlatformItem.VisionOs => "VISION_OS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsReviewSubmissionsGetToManyRelatedFilterPlatformItem? ToEnum(string value)
        {
            return value switch
            {
                "IOS" => AppsReviewSubmissionsGetToManyRelatedFilterPlatformItem.Ios,
                "MAC_OS" => AppsReviewSubmissionsGetToManyRelatedFilterPlatformItem.MacOs,
                "TV_OS" => AppsReviewSubmissionsGetToManyRelatedFilterPlatformItem.TvOs,
                "VISION_OS" => AppsReviewSubmissionsGetToManyRelatedFilterPlatformItem.VisionOs,
                _ => null,
            };
        }
    }
}