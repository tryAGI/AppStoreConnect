
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppBetaFeedbackCrashSubmissionsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaFeedbackCrashSubmissions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppBetaFeedbackCrashSubmissionsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppBetaFeedbackCrashSubmissionsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppBetaFeedbackCrashSubmissionsLinkagesResponseDataItemType.BetaFeedbackCrashSubmissions => "betaFeedbackCrashSubmissions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppBetaFeedbackCrashSubmissionsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "betaFeedbackCrashSubmissions" => AppBetaFeedbackCrashSubmissionsLinkagesResponseDataItemType.BetaFeedbackCrashSubmissions,
                _ => null,
            };
        }
    }
}