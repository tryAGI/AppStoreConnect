
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DiagnosticInsight
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insightType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.DiagnosticInsightTypeJsonConverter))]
        public global::AppStoreConnect.DiagnosticInsightType? InsightType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.DiagnosticInsightDirectionJsonConverter))]
        public global::AppStoreConnect.DiagnosticInsightDirection? Direction { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceVersions")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.DiagnosticInsightReferenceVersion>? ReferenceVersions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticInsight" /> class.
        /// </summary>
        /// <param name="insightType"></param>
        /// <param name="direction"></param>
        /// <param name="referenceVersions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiagnosticInsight(
            global::AppStoreConnect.DiagnosticInsightType? insightType,
            global::AppStoreConnect.DiagnosticInsightDirection? direction,
            global::System.Collections.Generic.IList<global::AppStoreConnect.DiagnosticInsightReferenceVersion>? referenceVersions)
        {
            this.InsightType = insightType;
            this.Direction = direction;
            this.ReferenceVersions = referenceVersions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticInsight" /> class.
        /// </summary>
        public DiagnosticInsight()
        {
        }

    }
}