
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DiagnosticSignatureAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diagnosticType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.DiagnosticSignatureAttributesDiagnosticTypeJsonConverter))]
        public global::AppStoreConnect.DiagnosticSignatureAttributesDiagnosticType? DiagnosticType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insight")]
        public global::AppStoreConnect.DiagnosticInsight? Insight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticSignatureAttributes" /> class.
        /// </summary>
        /// <param name="diagnosticType"></param>
        /// <param name="signature"></param>
        /// <param name="weight"></param>
        /// <param name="insight"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiagnosticSignatureAttributes(
            global::AppStoreConnect.DiagnosticSignatureAttributesDiagnosticType? diagnosticType,
            string? signature,
            double? weight,
            global::AppStoreConnect.DiagnosticInsight? insight)
        {
            this.DiagnosticType = diagnosticType;
            this.Signature = signature;
            this.Weight = weight;
            this.Insight = insight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticSignatureAttributes" /> class.
        /// </summary>
        public DiagnosticSignatureAttributes()
        {
        }

    }
}