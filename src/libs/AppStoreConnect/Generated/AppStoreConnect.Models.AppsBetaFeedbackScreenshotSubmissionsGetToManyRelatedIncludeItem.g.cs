
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Build,
        /// <summary>
        ///
        /// </summary>
        Tester,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedIncludeItem.Build => "build",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedIncludeItem.Tester => "tester",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "build" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedIncludeItem.Build,
                "tester" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedIncludeItem.Tester,
                _ => null,
            };
        }
    }
}