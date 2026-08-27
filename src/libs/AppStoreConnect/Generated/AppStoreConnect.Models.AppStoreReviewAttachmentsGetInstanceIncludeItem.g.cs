
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreReviewAttachmentsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreReviewDetail,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreReviewAttachmentsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreReviewAttachmentsGetInstanceIncludeItem value)
        {
            return value switch
            {
                AppStoreReviewAttachmentsGetInstanceIncludeItem.AppStoreReviewDetail => "appStoreReviewDetail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreReviewAttachmentsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewDetail" => AppStoreReviewAttachmentsGetInstanceIncludeItem.AppStoreReviewDetail,
                _ => null,
            };
        }
    }
}