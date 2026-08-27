
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaFeedbackCrashSubmissionsGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Build,
        /// <summary>
        /// 
        /// </summary>
        Tester,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFeedbackCrashSubmissionsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFeedbackCrashSubmissionsGetInstanceIncludeItem value)
        {
            return value switch
            {
                BetaFeedbackCrashSubmissionsGetInstanceIncludeItem.Build => "build",
                BetaFeedbackCrashSubmissionsGetInstanceIncludeItem.Tester => "tester",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFeedbackCrashSubmissionsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "build" => BetaFeedbackCrashSubmissionsGetInstanceIncludeItem.Build,
                "tester" => BetaFeedbackCrashSubmissionsGetInstanceIncludeItem.Tester,
                _ => null,
            };
        }
    }
}