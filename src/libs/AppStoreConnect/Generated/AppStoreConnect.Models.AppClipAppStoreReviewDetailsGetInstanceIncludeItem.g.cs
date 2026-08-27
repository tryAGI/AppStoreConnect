
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipAppStoreReviewDetailsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        AppClipDefaultExperience,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAppStoreReviewDetailsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAppStoreReviewDetailsGetInstanceIncludeItem value)
        {
            return value switch
            {
                AppClipAppStoreReviewDetailsGetInstanceIncludeItem.AppClipDefaultExperience => "appClipDefaultExperience",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAppStoreReviewDetailsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appClipDefaultExperience" => AppClipAppStoreReviewDetailsGetInstanceIncludeItem.AppClipDefaultExperience,
                _ => null,
            };
        }
    }
}