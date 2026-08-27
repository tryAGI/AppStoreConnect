
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaFeedbackCrashSubmissionResponseIncludedItemDiscriminatorType
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
    public static class BetaFeedbackCrashSubmissionResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFeedbackCrashSubmissionResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                BetaFeedbackCrashSubmissionResponseIncludedItemDiscriminatorType.BetaTesters => "betaTesters",
                BetaFeedbackCrashSubmissionResponseIncludedItemDiscriminatorType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFeedbackCrashSubmissionResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "betaTesters" => BetaFeedbackCrashSubmissionResponseIncludedItemDiscriminatorType.BetaTesters,
                "builds" => BetaFeedbackCrashSubmissionResponseIncludedItemDiscriminatorType.Builds,
                _ => null,
            };
        }
    }
}