
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreReviewDetailsGetInstanceIncludeItem
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
    public static class AppStoreReviewDetailsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreReviewDetailsGetInstanceIncludeItem value)
        {
            return value switch
            {
                AppStoreReviewDetailsGetInstanceIncludeItem.AppStoreReviewAttachments => "appStoreReviewAttachments",
                AppStoreReviewDetailsGetInstanceIncludeItem.AppStoreVersion => "appStoreVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreReviewDetailsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewAttachments" => AppStoreReviewDetailsGetInstanceIncludeItem.AppStoreReviewAttachments,
                "appStoreVersion" => AppStoreReviewDetailsGetInstanceIncludeItem.AppStoreVersion,
                _ => null,
            };
        }
    }
}