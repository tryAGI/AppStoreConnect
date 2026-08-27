
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFilterAppPlatformItem
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
    public static class AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFilterAppPlatformItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFilterAppPlatformItem value)
        {
            return value switch
            {
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFilterAppPlatformItem.Ios => "IOS",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFilterAppPlatformItem.MacOs => "MAC_OS",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFilterAppPlatformItem.TvOs => "TV_OS",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFilterAppPlatformItem.VisionOs => "VISION_OS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFilterAppPlatformItem? ToEnum(string value)
        {
            return value switch
            {
                "IOS" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFilterAppPlatformItem.Ios,
                "MAC_OS" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFilterAppPlatformItem.MacOs,
                "TV_OS" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFilterAppPlatformItem.TvOs,
                "VISION_OS" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFilterAppPlatformItem.VisionOs,
                _ => null,
            };
        }
    }
}