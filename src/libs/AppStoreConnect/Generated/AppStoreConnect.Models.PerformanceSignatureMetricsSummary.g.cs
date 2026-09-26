
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PerformanceSignatureMetricsSummary
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceVersions")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.PerformanceSignatureMetricsSummaryReferenceVersion>? ReferenceVersions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceSignatureMetricsSummary" /> class.
        /// </summary>
        /// <param name="referenceVersions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PerformanceSignatureMetricsSummary(
            global::System.Collections.Generic.IList<global::AppStoreConnect.PerformanceSignatureMetricsSummaryReferenceVersion>? referenceVersions)
        {
            this.ReferenceVersions = referenceVersions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceSignatureMetricsSummary" /> class.
        /// </summary>
        public PerformanceSignatureMetricsSummary()
        {
        }

    }
}