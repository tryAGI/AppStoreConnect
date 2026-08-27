
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFilterAppPlatformItem
    {
        /// <summary>
        /// 
        /// </summary>
        Ios,
        /// <summary>
        /// 
        /// </summary>
        MacOs,
        /// <summary>
        /// 
        /// </summary>
        TvOs,
        /// <summary>
        /// 
        /// </summary>
        VisionOs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFilterAppPlatformItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFilterAppPlatformItem value)
        {
            return value switch
            {
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFilterAppPlatformItem.Ios => "IOS",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFilterAppPlatformItem.MacOs => "MAC_OS",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFilterAppPlatformItem.TvOs => "TV_OS",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFilterAppPlatformItem.VisionOs => "VISION_OS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFilterAppPlatformItem? ToEnum(string value)
        {
            return value switch
            {
                "IOS" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFilterAppPlatformItem.Ios,
                "MAC_OS" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFilterAppPlatformItem.MacOs,
                "TV_OS" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFilterAppPlatformItem.TvOs,
                "VISION_OS" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFilterAppPlatformItem.VisionOs,
                _ => null,
            };
        }
    }
}