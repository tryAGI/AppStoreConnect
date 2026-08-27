
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission
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
    public static class AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission value)
        {
            return value switch
            {
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.AppPlatform => "appPlatform",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.AppUptimeInMilliseconds => "appUptimeInMilliseconds",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.Architecture => "architecture",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.BatteryPercentage => "batteryPercentage",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.Build => "build",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.BuildBundleId => "buildBundleId",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.Comment => "comment",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.ConnectionType => "connectionType",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.CreatedDate => "createdDate",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.DeviceFamily => "deviceFamily",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.DeviceModel => "deviceModel",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.DevicePlatform => "devicePlatform",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.DiskBytesAvailable => "diskBytesAvailable",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.DiskBytesTotal => "diskBytesTotal",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.Email => "email",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.Locale => "locale",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.OsVersion => "osVersion",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.PairedAppleWatch => "pairedAppleWatch",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.ScreenHeightInPoints => "screenHeightInPoints",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.ScreenWidthInPoints => "screenWidthInPoints",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.Screenshots => "screenshots",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.Tester => "tester",
                AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.TimeZone => "timeZone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission? ToEnum(string value)
        {
            return value switch
            {
                "appPlatform" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.AppPlatform,
                "appUptimeInMilliseconds" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.AppUptimeInMilliseconds,
                "architecture" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.Architecture,
                "batteryPercentage" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.BatteryPercentage,
                "build" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.Build,
                "buildBundleId" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.BuildBundleId,
                "comment" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.Comment,
                "connectionType" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.ConnectionType,
                "createdDate" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.CreatedDate,
                "deviceFamily" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.DeviceFamily,
                "deviceModel" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.DeviceModel,
                "devicePlatform" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.DevicePlatform,
                "diskBytesAvailable" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.DiskBytesAvailable,
                "diskBytesTotal" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.DiskBytesTotal,
                "email" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.Email,
                "locale" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.Locale,
                "osVersion" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.OsVersion,
                "pairedAppleWatch" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.PairedAppleWatch,
                "screenHeightInPoints" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.ScreenHeightInPoints,
                "screenWidthInPoints" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.ScreenWidthInPoints,
                "screenshots" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.Screenshots,
                "tester" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.Tester,
                "timeZone" => AppsBetaFeedbackScreenshotSubmissionsGetToManyRelatedFieldsBetaFeedbackScreenshotSubmission.TimeZone,
                _ => null,
            };
        }
    }
}