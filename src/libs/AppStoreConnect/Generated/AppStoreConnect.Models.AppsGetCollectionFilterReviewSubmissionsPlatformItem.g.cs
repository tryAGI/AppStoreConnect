
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGetCollectionFilterReviewSubmissionsPlatformItem
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
    public static class AppsGetCollectionFilterReviewSubmissionsPlatformItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionFilterReviewSubmissionsPlatformItem value)
        {
            return value switch
            {
                AppsGetCollectionFilterReviewSubmissionsPlatformItem.Ios => "IOS",
                AppsGetCollectionFilterReviewSubmissionsPlatformItem.MacOs => "MAC_OS",
                AppsGetCollectionFilterReviewSubmissionsPlatformItem.TvOs => "TV_OS",
                AppsGetCollectionFilterReviewSubmissionsPlatformItem.VisionOs => "VISION_OS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionFilterReviewSubmissionsPlatformItem? ToEnum(string value)
        {
            return value switch
            {
                "IOS" => AppsGetCollectionFilterReviewSubmissionsPlatformItem.Ios,
                "MAC_OS" => AppsGetCollectionFilterReviewSubmissionsPlatformItem.MacOs,
                "TV_OS" => AppsGetCollectionFilterReviewSubmissionsPlatformItem.TvOs,
                "VISION_OS" => AppsGetCollectionFilterReviewSubmissionsPlatformItem.VisionOs,
                _ => null,
            };
        }
    }
}