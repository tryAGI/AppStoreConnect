
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DiagnosticLogsProductDataItemDiagnosticLogDiagnosticMetaData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bundleId")]
        public string? BundleId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        public string? Event { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("osVersion")]
        public string? OsVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appVersion")]
        public string? AppVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("writesCaused")]
        public string? WritesCaused { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceType")]
        public string? DeviceType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platformArchitecture")]
        public string? PlatformArchitecture { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventDetail")]
        public string? EventDetail { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildVersion")]
        public string? BuildVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticLogsProductDataItemDiagnosticLogDiagnosticMetaData" /> class.
        /// </summary>
        /// <param name="bundleId"></param>
        /// <param name="event"></param>
        /// <param name="osVersion"></param>
        /// <param name="appVersion"></param>
        /// <param name="writesCaused"></param>
        /// <param name="deviceType"></param>
        /// <param name="platformArchitecture"></param>
        /// <param name="eventDetail"></param>
        /// <param name="buildVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiagnosticLogsProductDataItemDiagnosticLogDiagnosticMetaData(
            string? bundleId,
            string? @event,
            string? osVersion,
            string? appVersion,
            string? writesCaused,
            string? deviceType,
            string? platformArchitecture,
            string? eventDetail,
            string? buildVersion)
        {
            this.BundleId = bundleId;
            this.Event = @event;
            this.OsVersion = osVersion;
            this.AppVersion = appVersion;
            this.WritesCaused = writesCaused;
            this.DeviceType = deviceType;
            this.PlatformArchitecture = platformArchitecture;
            this.EventDetail = eventDetail;
            this.BuildVersion = buildVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticLogsProductDataItemDiagnosticLogDiagnosticMetaData" /> class.
        /// </summary>
        public DiagnosticLogsProductDataItemDiagnosticLogDiagnosticMetaData()
        {
        }

    }
}