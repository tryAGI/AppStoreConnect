
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaFeedbackScreenshotSubmissionType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaFeedbackScreenshotSubmissions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFeedbackScreenshotSubmissionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFeedbackScreenshotSubmissionType value)
        {
            return value switch
            {
                BetaFeedbackScreenshotSubmissionType.BetaFeedbackScreenshotSubmissions => "betaFeedbackScreenshotSubmissions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFeedbackScreenshotSubmissionType? ToEnum(string value)
        {
            return value switch
            {
                "betaFeedbackScreenshotSubmissions" => BetaFeedbackScreenshotSubmissionType.BetaFeedbackScreenshotSubmissions,
                _ => null,
            };
        }
    }
}