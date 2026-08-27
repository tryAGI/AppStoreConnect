
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CiTestResultAttributesDestinationTestResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceName")]
        public string? DeviceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("osVersion")]
        public string? OsVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.CiTestStatusJsonConverter))]
        public global::AppStoreConnect.CiTestStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiTestResultAttributesDestinationTestResult" /> class.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="deviceName"></param>
        /// <param name="osVersion"></param>
        /// <param name="status"></param>
        /// <param name="duration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiTestResultAttributesDestinationTestResult(
            string? uuid,
            string? deviceName,
            string? osVersion,
            global::AppStoreConnect.CiTestStatus? status,
            double? duration)
        {
            this.Uuid = uuid;
            this.DeviceName = deviceName;
            this.OsVersion = osVersion;
            this.Status = status;
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiTestResultAttributesDestinationTestResult" /> class.
        /// </summary>
        public CiTestResultAttributesDestinationTestResult()
        {
        }

    }
}