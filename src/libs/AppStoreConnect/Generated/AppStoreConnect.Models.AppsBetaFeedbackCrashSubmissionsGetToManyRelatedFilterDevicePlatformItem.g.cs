
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFilterDevicePlatformItem
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
    public static class AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFilterDevicePlatformItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFilterDevicePlatformItem value)
        {
            return value switch
            {
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFilterDevicePlatformItem.Ios => "IOS",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFilterDevicePlatformItem.MacOs => "MAC_OS",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFilterDevicePlatformItem.TvOs => "TV_OS",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFilterDevicePlatformItem.VisionOs => "VISION_OS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFilterDevicePlatformItem? ToEnum(string value)
        {
            return value switch
            {
                "IOS" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFilterDevicePlatformItem.Ios,
                "MAC_OS" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFilterDevicePlatformItem.MacOs,
                "TV_OS" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFilterDevicePlatformItem.TvOs,
                "VISION_OS" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFilterDevicePlatformItem.VisionOs,
                _ => null,
            };
        }
    }
}