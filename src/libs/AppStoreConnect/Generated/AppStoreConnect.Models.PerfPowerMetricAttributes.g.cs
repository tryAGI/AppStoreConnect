
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PerfPowerMetricAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.PerfPowerMetricAttributesPlatformJsonConverter))]
        public global::AppStoreConnect.PerfPowerMetricAttributesPlatform? Platform { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metricType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.PerfPowerMetricAttributesMetricTypeJsonConverter))]
        public global::AppStoreConnect.PerfPowerMetricAttributesMetricType? MetricType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceType")]
        public string? DeviceType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PerfPowerMetricAttributes" /> class.
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="metricType"></param>
        /// <param name="deviceType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PerfPowerMetricAttributes(
            global::AppStoreConnect.PerfPowerMetricAttributesPlatform? platform,
            global::AppStoreConnect.PerfPowerMetricAttributesMetricType? metricType,
            string? deviceType)
        {
            this.Platform = platform;
            this.MetricType = metricType;
            this.DeviceType = deviceType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PerfPowerMetricAttributes" /> class.
        /// </summary>
        public PerfPowerMetricAttributes()
        {
        }

    }
}