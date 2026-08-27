
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission
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
        CrashLog,
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
        Tester,
        /// <summary>
        ///
        /// </summary>
        TimeZone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission value)
        {
            return value switch
            {
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.AppPlatform => "appPlatform",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.AppUptimeInMilliseconds => "appUptimeInMilliseconds",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.Architecture => "architecture",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.BatteryPercentage => "batteryPercentage",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.Build => "build",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.BuildBundleId => "buildBundleId",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.Comment => "comment",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.ConnectionType => "connectionType",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.CrashLog => "crashLog",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.CreatedDate => "createdDate",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.DeviceFamily => "deviceFamily",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.DeviceModel => "deviceModel",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.DevicePlatform => "devicePlatform",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.DiskBytesAvailable => "diskBytesAvailable",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.DiskBytesTotal => "diskBytesTotal",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.Email => "email",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.Locale => "locale",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.OsVersion => "osVersion",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.PairedAppleWatch => "pairedAppleWatch",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.ScreenHeightInPoints => "screenHeightInPoints",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.ScreenWidthInPoints => "screenWidthInPoints",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.Tester => "tester",
                BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.TimeZone => "timeZone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission? ToEnum(string value)
        {
            return value switch
            {
                "appPlatform" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.AppPlatform,
                "appUptimeInMilliseconds" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.AppUptimeInMilliseconds,
                "architecture" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.Architecture,
                "batteryPercentage" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.BatteryPercentage,
                "build" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.Build,
                "buildBundleId" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.BuildBundleId,
                "comment" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.Comment,
                "connectionType" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.ConnectionType,
                "crashLog" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.CrashLog,
                "createdDate" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.CreatedDate,
                "deviceFamily" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.DeviceFamily,
                "deviceModel" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.DeviceModel,
                "devicePlatform" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.DevicePlatform,
                "diskBytesAvailable" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.DiskBytesAvailable,
                "diskBytesTotal" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.DiskBytesTotal,
                "email" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.Email,
                "locale" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.Locale,
                "osVersion" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.OsVersion,
                "pairedAppleWatch" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.PairedAppleWatch,
                "screenHeightInPoints" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.ScreenHeightInPoints,
                "screenWidthInPoints" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.ScreenWidthInPoints,
                "tester" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.Tester,
                "timeZone" => BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission.TimeZone,
                _ => null,
            };
        }
    }
}