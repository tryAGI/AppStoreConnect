
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DiagnosticLogsProductDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signatureId")]
        public string? SignatureId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diagnosticInsights")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.DiagnosticLogsProductDataItemDiagnosticInsight>? DiagnosticInsights { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diagnosticLogs")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.DiagnosticLogsProductDataItemDiagnosticLog>? DiagnosticLogs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticLogsProductDataItem" /> class.
        /// </summary>
        /// <param name="signatureId"></param>
        /// <param name="diagnosticInsights"></param>
        /// <param name="diagnosticLogs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiagnosticLogsProductDataItem(
            string? signatureId,
            global::System.Collections.Generic.IList<global::AppStoreConnect.DiagnosticLogsProductDataItemDiagnosticInsight>? diagnosticInsights,
            global::System.Collections.Generic.IList<global::AppStoreConnect.DiagnosticLogsProductDataItemDiagnosticLog>? diagnosticLogs)
        {
            this.SignatureId = signatureId;
            this.DiagnosticInsights = diagnosticInsights;
            this.DiagnosticLogs = diagnosticLogs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticLogsProductDataItem" /> class.
        /// </summary>
        public DiagnosticLogsProductDataItem()
        {
        }

    }
}