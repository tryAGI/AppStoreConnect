
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaFeedbackScreenshotSubmissionRelationshipsTesterDataType
    {
        /// <summary>
        ///
        /// </summary>
        BetaTesters,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFeedbackScreenshotSubmissionRelationshipsTesterDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFeedbackScreenshotSubmissionRelationshipsTesterDataType value)
        {
            return value switch
            {
                BetaFeedbackScreenshotSubmissionRelationshipsTesterDataType.BetaTesters => "betaTesters",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFeedbackScreenshotSubmissionRelationshipsTesterDataType? ToEnum(string value)
        {
            return value switch
            {
                "betaTesters" => BetaFeedbackScreenshotSubmissionRelationshipsTesterDataType.BetaTesters,
                _ => null,
            };
        }
    }
}