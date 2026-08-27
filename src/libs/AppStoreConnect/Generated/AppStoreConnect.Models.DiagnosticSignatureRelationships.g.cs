
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DiagnosticSignatureRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logs")]
        public global::AppStoreConnect.DiagnosticSignatureRelationshipsLogs? Logs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticSignatureRelationships" /> class.
        /// </summary>
        /// <param name="logs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiagnosticSignatureRelationships(
            global::AppStoreConnect.DiagnosticSignatureRelationshipsLogs? logs)
        {
            this.Logs = logs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticSignatureRelationships" /> class.
        /// </summary>
        public DiagnosticSignatureRelationships()
        {
        }

    }
}