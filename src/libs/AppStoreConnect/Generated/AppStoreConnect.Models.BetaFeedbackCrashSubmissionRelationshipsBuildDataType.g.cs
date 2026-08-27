
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaFeedbackCrashSubmissionRelationshipsBuildDataType
    {
        /// <summary>
        ///
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFeedbackCrashSubmissionRelationshipsBuildDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFeedbackCrashSubmissionRelationshipsBuildDataType value)
        {
            return value switch
            {
                BetaFeedbackCrashSubmissionRelationshipsBuildDataType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFeedbackCrashSubmissionRelationshipsBuildDataType? ToEnum(string value)
        {
            return value switch
            {
                "builds" => BetaFeedbackCrashSubmissionRelationshipsBuildDataType.Builds,
                _ => null,
            };
        }
    }
}