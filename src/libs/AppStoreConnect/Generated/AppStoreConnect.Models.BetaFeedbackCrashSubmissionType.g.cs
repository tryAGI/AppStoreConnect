
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaFeedbackCrashSubmissionType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaFeedbackCrashSubmissions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFeedbackCrashSubmissionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFeedbackCrashSubmissionType value)
        {
            return value switch
            {
                BetaFeedbackCrashSubmissionType.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFeedbackCrashSubmissionType? ToEnum(string value)
        {
            return value switch
            {
                "betaFeedbackCrashSubmissions" => BetaFeedbackCrashSubmissionType.BetaFeedbackCrashSubmissions,
                _ => null,
            };
        }
    }
}