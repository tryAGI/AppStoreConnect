
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaFeedbackCrashSubmissionsCrashLogGetToOneRelatedFieldsBetaCrashLog
    {
        /// <summary>
        ///
        /// </summary>
        LogText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFeedbackCrashSubmissionsCrashLogGetToOneRelatedFieldsBetaCrashLogExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFeedbackCrashSubmissionsCrashLogGetToOneRelatedFieldsBetaCrashLog value)
        {
            return value switch
            {
                BetaFeedbackCrashSubmissionsCrashLogGetToOneRelatedFieldsBetaCrashLog.LogText => "logText",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFeedbackCrashSubmissionsCrashLogGetToOneRelatedFieldsBetaCrashLog? ToEnum(string value)
        {
            return value switch
            {
                "logText" => BetaFeedbackCrashSubmissionsCrashLogGetToOneRelatedFieldsBetaCrashLog.LogText,
                _ => null,
            };
        }
    }
}