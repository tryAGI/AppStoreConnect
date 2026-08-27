
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionsAppStoreReviewDetailGetToOneRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreReviewAttachments,
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionsAppStoreReviewDetailGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsAppStoreReviewDetailGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedIncludeItem.AppStoreReviewAttachments => "appStoreReviewAttachments",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedIncludeItem.AppStoreVersion => "appStoreVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsAppStoreReviewDetailGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewAttachments" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedIncludeItem.AppStoreReviewAttachments,
                "appStoreVersion" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedIncludeItem.AppStoreVersion,
                _ => null,
            };
        }
    }
}