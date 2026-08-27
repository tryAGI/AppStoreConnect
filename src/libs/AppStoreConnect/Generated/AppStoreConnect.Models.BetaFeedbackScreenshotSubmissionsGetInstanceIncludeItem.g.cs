
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaFeedbackScreenshotSubmissionsGetInstanceIncludeItem
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
    public static class BetaFeedbackScreenshotSubmissionsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFeedbackScreenshotSubmissionsGetInstanceIncludeItem value)
        {
            return value switch
            {
                BetaFeedbackScreenshotSubmissionsGetInstanceIncludeItem.Build => "build",
                BetaFeedbackScreenshotSubmissionsGetInstanceIncludeItem.Tester => "tester",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFeedbackScreenshotSubmissionsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "build" => BetaFeedbackScreenshotSubmissionsGetInstanceIncludeItem.Build,
                "tester" => BetaFeedbackScreenshotSubmissionsGetInstanceIncludeItem.Tester,
                _ => null,
            };
        }
    }
}