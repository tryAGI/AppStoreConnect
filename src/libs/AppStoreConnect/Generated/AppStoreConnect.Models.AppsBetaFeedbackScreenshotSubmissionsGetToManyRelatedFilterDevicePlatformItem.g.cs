
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFilterDevicePlatformItem
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
    public static class AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFilterDevicePlatformItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFilterDevicePlatformItem value)
        {
            return value switch
            {
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFilterDevicePlatformItem.Ios => "IOS",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFilterDevicePlatformItem.MacOs => "MAC_OS",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFilterDevicePlatformItem.TvOs => "TV_OS",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFilterDevicePlatformItem.VisionOs => "VISION_OS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFilterDevicePlatformItem? ToEnum(string value)
        {
            return value switch
            {
                "IOS" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFilterDevicePlatformItem.Ios,
                "MAC_OS" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFilterDevicePlatformItem.MacOs,
                "TV_OS" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFilterDevicePlatformItem.TvOs,
                "VISION_OS" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFilterDevicePlatformItem.VisionOs,
                _ => null,
            };
        }
    }
}