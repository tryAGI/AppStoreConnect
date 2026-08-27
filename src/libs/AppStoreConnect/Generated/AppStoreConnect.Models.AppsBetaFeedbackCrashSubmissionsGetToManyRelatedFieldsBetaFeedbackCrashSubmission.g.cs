
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission
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
    public static class AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission value)
        {
            return value switch
            {
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.AppPlatform => "appPlatform",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.AppUptimeInMilliseconds => "appUptimeInMilliseconds",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.Architecture => "architecture",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.BatteryPercentage => "batteryPercentage",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.Build => "build",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.BuildBundleId => "buildBundleId",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.Comment => "comment",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.ConnectionType => "connectionType",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.CrashLog => "crashLog",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.CreatedDate => "createdDate",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.DeviceFamily => "deviceFamily",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.DeviceModel => "deviceModel",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.DevicePlatform => "devicePlatform",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.DiskBytesAvailable => "diskBytesAvailable",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.DiskBytesTotal => "diskBytesTotal",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.Email => "email",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.Locale => "locale",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.OsVersion => "osVersion",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.PairedAppleWatch => "pairedAppleWatch",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.ScreenHeightInPoints => "screenHeightInPoints",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.ScreenWidthInPoints => "screenWidthInPoints",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.Tester => "tester",
                AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.TimeZone => "timeZone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission? ToEnum(string value)
        {
            return value switch
            {
                "appPlatform" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.AppPlatform,
                "appUptimeInMilliseconds" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.AppUptimeInMilliseconds,
                "architecture" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.Architecture,
                "batteryPercentage" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.BatteryPercentage,
                "build" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.Build,
                "buildBundleId" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.BuildBundleId,
                "comment" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.Comment,
                "connectionType" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.ConnectionType,
                "crashLog" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.CrashLog,
                "createdDate" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.CreatedDate,
                "deviceFamily" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.DeviceFamily,
                "deviceModel" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.DeviceModel,
                "devicePlatform" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.DevicePlatform,
                "diskBytesAvailable" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.DiskBytesAvailable,
                "diskBytesTotal" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.DiskBytesTotal,
                "email" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.Email,
                "locale" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.Locale,
                "osVersion" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.OsVersion,
                "pairedAppleWatch" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.PairedAppleWatch,
                "screenHeightInPoints" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.ScreenHeightInPoints,
                "screenWidthInPoints" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.ScreenWidthInPoints,
                "tester" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.Tester,
                "timeZone" => AppsBetaFeedbackCrashSubmissionsGetToManyRelatedFieldsBetaFeedbackCrashSubmission.TimeZone,
                _ => null,
            };
        }
    }
}