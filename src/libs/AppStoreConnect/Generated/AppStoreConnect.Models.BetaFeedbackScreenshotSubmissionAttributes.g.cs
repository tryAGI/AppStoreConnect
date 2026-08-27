
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaFeedbackScreenshotSubmissionAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdDate")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceModel")]
        public string? DeviceModel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("osVersion")]
        public string? OsVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        public string? Locale { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeZone")]
        public string? TimeZone { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("architecture")]
        public string? Architecture { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.DeviceConnectionTypeJsonConverter))]
        public global::AppStoreConnect.DeviceConnectionType? ConnectionType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pairedAppleWatch")]
        public string? PairedAppleWatch { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appUptimeInMilliseconds")]
        public long? AppUptimeInMilliseconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diskBytesAvailable")]
        public long? DiskBytesAvailable { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diskBytesTotal")]
        public long? DiskBytesTotal { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batteryPercentage")]
        public int? BatteryPercentage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("screenWidthInPoints")]
        public int? ScreenWidthInPoints { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("screenHeightInPoints")]
        public int? ScreenHeightInPoints { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appPlatform")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.PlatformJsonConverter))]
        public global::AppStoreConnect.Platform? AppPlatform { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("devicePlatform")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.PlatformJsonConverter))]
        public global::AppStoreConnect.Platform? DevicePlatform { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceFamily")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.DeviceFamilyJsonConverter))]
        public global::AppStoreConnect.DeviceFamily? DeviceFamily { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildBundleId")]
        public string? BuildBundleId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("screenshots")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.BetaFeedbackScreenshotImage>? Screenshots { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFeedbackScreenshotSubmissionAttributes" /> class.
        /// </summary>
        /// <param name="createdDate"></param>
        /// <param name="comment"></param>
        /// <param name="email"></param>
        /// <param name="deviceModel"></param>
        /// <param name="osVersion"></param>
        /// <param name="locale"></param>
        /// <param name="timeZone"></param>
        /// <param name="architecture"></param>
        /// <param name="connectionType"></param>
        /// <param name="pairedAppleWatch"></param>
        /// <param name="appUptimeInMilliseconds"></param>
        /// <param name="diskBytesAvailable"></param>
        /// <param name="diskBytesTotal"></param>
        /// <param name="batteryPercentage"></param>
        /// <param name="screenWidthInPoints"></param>
        /// <param name="screenHeightInPoints"></param>
        /// <param name="appPlatform"></param>
        /// <param name="devicePlatform"></param>
        /// <param name="deviceFamily"></param>
        /// <param name="buildBundleId"></param>
        /// <param name="screenshots"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaFeedbackScreenshotSubmissionAttributes(
            global::System.DateTime? createdDate,
            string? comment,
            string? email,
            string? deviceModel,
            string? osVersion,
            string? locale,
            string? timeZone,
            string? architecture,
            global::AppStoreConnect.DeviceConnectionType? connectionType,
            string? pairedAppleWatch,
            long? appUptimeInMilliseconds,
            long? diskBytesAvailable,
            long? diskBytesTotal,
            int? batteryPercentage,
            int? screenWidthInPoints,
            int? screenHeightInPoints,
            global::AppStoreConnect.Platform? appPlatform,
            global::AppStoreConnect.Platform? devicePlatform,
            global::AppStoreConnect.DeviceFamily? deviceFamily,
            string? buildBundleId,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaFeedbackScreenshotImage>? screenshots)
        {
            this.CreatedDate = createdDate;
            this.Comment = comment;
            this.Email = email;
            this.DeviceModel = deviceModel;
            this.OsVersion = osVersion;
            this.Locale = locale;
            this.TimeZone = timeZone;
            this.Architecture = architecture;
            this.ConnectionType = connectionType;
            this.PairedAppleWatch = pairedAppleWatch;
            this.AppUptimeInMilliseconds = appUptimeInMilliseconds;
            this.DiskBytesAvailable = diskBytesAvailable;
            this.DiskBytesTotal = diskBytesTotal;
            this.BatteryPercentage = batteryPercentage;
            this.ScreenWidthInPoints = screenWidthInPoints;
            this.ScreenHeightInPoints = screenHeightInPoints;
            this.AppPlatform = appPlatform;
            this.DevicePlatform = devicePlatform;
            this.DeviceFamily = deviceFamily;
            this.BuildBundleId = buildBundleId;
            this.Screenshots = screenshots;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFeedbackScreenshotSubmissionAttributes" /> class.
        /// </summary>
        public BetaFeedbackScreenshotSubmissionAttributes()
        {
        }

    }
}