
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreReviewDetailsAppStoreReviewAttachmentsGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreReviewDetail,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreReviewDetailsAppStoreReviewAttachmentsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreReviewDetailsAppStoreReviewAttachmentsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppStoreReviewDetailsAppStoreReviewAttachmentsGetToManyRelatedIncludeItem.AppStoreReviewDetail => "appStoreReviewDetail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreReviewDetailsAppStoreReviewAttachmentsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewDetail" => AppStoreReviewDetailsAppStoreReviewAttachmentsGetToManyRelatedIncludeItem.AppStoreReviewDetail,
                _ => null,
            };
        }
    }
}