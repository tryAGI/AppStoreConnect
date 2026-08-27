
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission
    {
        /// <summary>
        /// 
        /// </summary>
        AppPlatform,
        /// <summary>
        /// 
        /// </summary>
        AppUptimeInMilliseconds,
        /// <summary>
        /// 
        /// </summary>
        Architecture,
        /// <summary>
        /// 
        /// </summary>
        BatteryPercentage,
        /// <summary>
        /// 
        /// </summary>
        Build,
        /// <summary>
        /// 
        /// </summary>
        BuildBundleId,
        /// <summary>
        /// 
        /// </summary>
        Comment,
        /// <summary>
        /// 
        /// </summary>
        ConnectionType,
        /// <summary>
        /// 
        /// </summary>
        CreatedDate,
        /// <summary>
        /// 
        /// </summary>
        DeviceFamily,
        /// <summary>
        /// 
        /// </summary>
        DeviceModel,
        /// <summary>
        /// 
        /// </summary>
        DevicePlatform,
        /// <summary>
        /// 
        /// </summary>
        DiskBytesAvailable,
        /// <summary>
        /// 
        /// </summary>
        DiskBytesTotal,
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        Locale,
        /// <summary>
        /// 
        /// </summary>
        OsVersion,
        /// <summary>
        /// 
        /// </summary>
        PairedAppleWatch,
        /// <summary>
        /// 
        /// </summary>
        ScreenHeightInPoints,
        /// <summary>
        /// 
        /// </summary>
        ScreenWidthInPoints,
        /// <summary>
        /// 
        /// </summary>
        Screenshots,
        /// <summary>
        /// 
        /// </summary>
        Tester,
        /// <summary>
        /// 
        /// </summary>
        TimeZone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission value)
        {
            return value switch
            {
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.AppPlatform => "appPlatform",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.AppUptimeInMilliseconds => "appUptimeInMilliseconds",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.Architecture => "architecture",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.BatteryPercentage => "batteryPercentage",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.Build => "build",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.BuildBundleId => "buildBundleId",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.Comment => "comment",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.ConnectionType => "connectionType",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.CreatedDate => "createdDate",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.DeviceFamily => "deviceFamily",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.DeviceModel => "deviceModel",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.DevicePlatform => "devicePlatform",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.DiskBytesAvailable => "diskBytesAvailable",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.DiskBytesTotal => "diskBytesTotal",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.Email => "email",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.Locale => "locale",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.OsVersion => "osVersion",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.PairedAppleWatch => "pairedAppleWatch",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.ScreenHeightInPoints => "screenHeightInPoints",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.ScreenWidthInPoints => "screenWidthInPoints",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.Screenshots => "screenshots",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.Tester => "tester",
                BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.TimeZone => "timeZone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission? ToEnum(string value)
        {
            return value switch
            {
                "appPlatform" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.AppPlatform,
                "appUptimeInMilliseconds" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.AppUptimeInMilliseconds,
                "architecture" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.Architecture,
                "batteryPercentage" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.BatteryPercentage,
                "build" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.Build,
                "buildBundleId" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.BuildBundleId,
                "comment" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.Comment,
                "connectionType" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.ConnectionType,
                "createdDate" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.CreatedDate,
                "deviceFamily" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.DeviceFamily,
                "deviceModel" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.DeviceModel,
                "devicePlatform" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.DevicePlatform,
                "diskBytesAvailable" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.DiskBytesAvailable,
                "diskBytesTotal" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.DiskBytesTotal,
                "email" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.Email,
                "locale" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.Locale,
                "osVersion" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.OsVersion,
                "pairedAppleWatch" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.PairedAppleWatch,
                "screenHeightInPoints" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.ScreenHeightInPoints,
                "screenWidthInPoints" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.ScreenWidthInPoints,
                "screenshots" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.Screenshots,
                "tester" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.Tester,
                "timeZone" => BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission.TimeZone,
                _ => null,
            };
        }
    }
}