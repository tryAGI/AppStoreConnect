
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaFeedbackCrashSubmissionsResponseIncludedItemDiscriminatorType
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
    public static class BetaFeedbackCrashSubmissionsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFeedbackCrashSubmissionsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                BetaFeedbackCrashSubmissionsResponseIncludedItemDiscriminatorType.BetaTesters => "betaTesters",
                BetaFeedbackCrashSubmissionsResponseIncludedItemDiscriminatorType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFeedbackCrashSubmissionsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "betaTesters" => BetaFeedbackCrashSubmissionsResponseIncludedItemDiscriminatorType.BetaTesters,
                "builds" => BetaFeedbackCrashSubmissionsResponseIncludedItemDiscriminatorType.Builds,
                _ => null,
            };
        }
    }
}