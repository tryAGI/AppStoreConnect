
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaFeedbackScreenshotSubmissionRelationshipsBuildDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFeedbackScreenshotSubmissionRelationshipsBuildDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFeedbackScreenshotSubmissionRelationshipsBuildDataType value)
        {
            return value switch
            {
                BetaFeedbackScreenshotSubmissionRelationshipsBuildDataType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFeedbackScreenshotSubmissionRelationshipsBuildDataType? ToEnum(string value)
        {
            return value switch
            {
                "builds" => BetaFeedbackScreenshotSubmissionRelationshipsBuildDataType.Builds,
                _ => null,
            };
        }
    }
}