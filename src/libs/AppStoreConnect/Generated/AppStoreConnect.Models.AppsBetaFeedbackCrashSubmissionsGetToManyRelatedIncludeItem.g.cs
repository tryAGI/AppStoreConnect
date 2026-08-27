
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsBetaFeedbackCrashSubmissionsGetToManyRelatedIncludeItem
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
    public static class AppsBetaFeedbackCrashSubmissionsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBetaFeedbackCrashSubmissionsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedIncludeItem.Build => "build",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedIncludeItem.Tester => "tester",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBetaFeedbackCrashSubmissionsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "build" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedIncludeItem.Build,
                "tester" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedIncludeItem.Tester,
                _ => null,
            };
        }
    }
}