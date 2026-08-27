
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppScreenshotSetsAppScreenshotsGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        AppScreenshotSet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppScreenshotSetsAppScreenshotsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppScreenshotSetsAppScreenshotsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppScreenshotSetsAppScreenshotsGetToManyRelatedIncludeItem.AppScreenshotSet => "appScreenshotSet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppScreenshotSetsAppScreenshotsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appScreenshotSet" => AppScreenshotSetsAppScreenshotsGetToManyRelatedIncludeItem.AppScreenshotSet,
                _ => null,
            };
        }
    }
}