
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaFeedbackCrashSubmissionRelationshipsTesterDataType
    {
        /// <summary>
        ///
        /// </summary>
        BetaTesters,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFeedbackCrashSubmissionRelationshipsTesterDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFeedbackCrashSubmissionRelationshipsTesterDataType value)
        {
            return value switch
            {
                BetaFeedbackCrashSubmissionRelationshipsTesterDataType.BetaTesters => "betaTesters",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFeedbackCrashSubmissionRelationshipsTesterDataType? ToEnum(string value)
        {
            return value switch
            {
                "betaTesters" => BetaFeedbackCrashSubmissionRelationshipsTesterDataType.BetaTesters,
                _ => null,
            };
        }
    }
}