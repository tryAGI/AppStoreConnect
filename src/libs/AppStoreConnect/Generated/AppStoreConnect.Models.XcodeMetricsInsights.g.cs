
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class XcodeMetricsInsights
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trendingUp")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.MetricsInsight>? TrendingUp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regressions")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.MetricsInsight>? Regressions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeMetricsInsights" /> class.
        /// </summary>
        /// <param name="trendingUp"></param>
        /// <param name="regressions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public XcodeMetricsInsights(
            global::System.Collections.Generic.IList<global::AppStoreConnect.MetricsInsight>? trendingUp,
            global::System.Collections.Generic.IList<global::AppStoreConnect.MetricsInsight>? regressions)
        {
            this.TrendingUp = trendingUp;
            this.Regressions = regressions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XcodeMetricsInsights" /> class.
        /// </summary>
        public XcodeMetricsInsights()
        {
        }

    }
}