
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PerformanceSignature
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signatureId")]
        public string? SignatureId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        public string? Signature { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public double? Weight { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceFile")]
        public string? SourceFile { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lineNumber")]
        public int? LineNumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trendInfo")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.DiagnosticInsightDirectionJsonConverter))]
        public global::AppStoreConnect.DiagnosticInsightDirection? TrendInfo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metricsSummary")]
        public global::AppStoreConnect.PerformanceSignatureMetricsSummary? MetricsSummary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceSignature" /> class.
        /// </summary>
        /// <param name="signatureId"></param>
        /// <param name="signature"></param>
        /// <param name="count"></param>
        /// <param name="weight"></param>
        /// <param name="sourceFile"></param>
        /// <param name="lineNumber"></param>
        /// <param name="trendInfo"></param>
        /// <param name="metricsSummary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PerformanceSignature(
            string? signatureId,
            string? signature,
            int? count,
            double? weight,
            string? sourceFile,
            int? lineNumber,
            global::AppStoreConnect.DiagnosticInsightDirection? trendInfo,
            global::AppStoreConnect.PerformanceSignatureMetricsSummary? metricsSummary)
        {
            this.SignatureId = signatureId;
            this.Signature = signature;
            this.Count = count;
            this.Weight = weight;
            this.SourceFile = sourceFile;
            this.LineNumber = lineNumber;
            this.TrendInfo = trendInfo;
            this.MetricsSummary = metricsSummary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceSignature" /> class.
        /// </summary>
        public PerformanceSignature()
        {
        }

    }
}