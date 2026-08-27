
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaFeedbackCrashSubmissionCrashLogLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaCrashLogs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFeedbackCrashSubmissionCrashLogLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFeedbackCrashSubmissionCrashLogLinkageResponseDataType value)
        {
            return value switch
            {
                BetaFeedbackCrashSubmissionCrashLogLinkageResponseDataType.BetaCrashLogs => "betaCrashLogs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFeedbackCrashSubmissionCrashLogLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "betaCrashLogs" => BetaFeedbackCrashSubmissionCrashLogLinkageResponseDataType.BetaCrashLogs,
                _ => null,
            };
        }
    }
}