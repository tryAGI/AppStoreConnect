
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class XcodeMetricsProductDataItemMetricCategorieMetricDatasetFilterCriteria
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentile")]
        public string? Percentile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("device")]
        public string? Device { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceMarketingName")]
        public string? DeviceMarketingName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeMetricsProductDataItemMetricCategorieMetricDatasetFilterCriteria" /> class.
        /// </summary>
        /// <param name="percentile"></param>
        /// <param name="device"></param>
        /// <param name="deviceMarketingName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public XcodeMetricsProductDataItemMetricCategorieMetricDatasetFilterCriteria(
            string? percentile,
            string? device,
            string? deviceMarketingName)
        {
            this.Percentile = percentile;
            this.Device = device;
            this.DeviceMarketingName = deviceMarketingName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeMetricsProductDataItemMetricCategorieMetricDatasetFilterCriteria" /> class.
        /// </summary>
        public XcodeMetricsProductDataItemMetricCategorieMetricDatasetFilterCriteria()
        {
        }

    }
}