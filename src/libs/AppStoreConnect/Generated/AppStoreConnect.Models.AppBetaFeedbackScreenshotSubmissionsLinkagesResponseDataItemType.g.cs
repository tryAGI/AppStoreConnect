
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppBetaFeedbackScreenshotSubmissionsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        BetaFeedbackScreenshotSubmissions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppBetaFeedbackScreenshotSubmissionsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppBetaFeedbackScreenshotSubmissionsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppBetaFeedbackScreenshotSubmissionsLinkagesResponseDataItemType.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppBetaFeedbackScreenshotSubmissionsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "betaFeedbackScreenshotSubmissions" => AppBetaFeedbackScreenshotSubmissionsLinkagesResponseDataItemType.BetaFeedbackScreenshotSubmissions,
                _ => null,
            };
        }
    }
}