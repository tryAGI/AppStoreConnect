
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaFeedbackScreenshotSubmissionResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaTesters,
        /// <summary>
        /// 
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFeedbackScreenshotSubmissionResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFeedbackScreenshotSubmissionResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                BetaFeedbackScreenshotSubmissionResponseIncludedItemDiscriminatorType.BetaTesters => "betaTesters",
                BetaFeedbackScreenshotSubmissionResponseIncludedItemDiscriminatorType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFeedbackScreenshotSubmissionResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "betaTesters" => BetaFeedbackScreenshotSubmissionResponseIncludedItemDiscriminatorType.BetaTesters,
                "builds" => BetaFeedbackScreenshotSubmissionResponseIncludedItemDiscriminatorType.Builds,
                _ => null,
            };
        }
    }
}