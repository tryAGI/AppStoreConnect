
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsCustomerReviewSummarizationsGetToManyRelatedFilterPlatformItem
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
    public static class AppsCustomerReviewSummarizationsGetToManyRelatedFilterPlatformItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsCustomerReviewSummarizationsGetToManyRelatedFilterPlatformItem value)
        {
            return value switch
            {
                AppsCustomerReviewSummarizationsGetToManyRelatedFilterPlatformItem.Ios => "IOS",
                AppsCustomerReviewSummarizationsGetToManyRelatedFilterPlatformItem.MacOs => "MAC_OS",
                AppsCustomerReviewSummarizationsGetToManyRelatedFilterPlatformItem.TvOs => "TV_OS",
                AppsCustomerReviewSummarizationsGetToManyRelatedFilterPlatformItem.VisionOs => "VISION_OS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsCustomerReviewSummarizationsGetToManyRelatedFilterPlatformItem? ToEnum(string value)
        {
            return value switch
            {
                "IOS" => AppsCustomerReviewSummarizationsGetToManyRelatedFilterPlatformItem.Ios,
                "MAC_OS" => AppsCustomerReviewSummarizationsGetToManyRelatedFilterPlatformItem.MacOs,
                "TV_OS" => AppsCustomerReviewSummarizationsGetToManyRelatedFilterPlatformItem.TvOs,
                "VISION_OS" => AppsCustomerReviewSummarizationsGetToManyRelatedFilterPlatformItem.VisionOs,
                _ => null,
            };
        }
    }
}