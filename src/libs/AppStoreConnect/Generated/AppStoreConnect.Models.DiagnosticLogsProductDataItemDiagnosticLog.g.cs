
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DiagnosticLogsProductDataItemDiagnosticLog
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callStackTree")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.DiagnosticLogsProductDataItemDiagnosticLogCallStackTreeItem>? CallStackTree { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diagnosticMetaData")]
        public global::AppStoreConnect.DiagnosticLogsProductDataItemDiagnosticLogDiagnosticMetaData? DiagnosticMetaData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticLogsProductDataItemDiagnosticLog" /> class.
        /// </summary>
        /// <param name="callStackTree"></param>
        /// <param name="diagnosticMetaData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiagnosticLogsProductDataItemDiagnosticLog(
            global::System.Collections.Generic.IList<global::AppStoreConnect.DiagnosticLogsProductDataItemDiagnosticLogCallStackTreeItem>? callStackTree,
            global::AppStoreConnect.DiagnosticLogsProductDataItemDiagnosticLogDiagnosticMetaData? diagnosticMetaData)
        {
            this.CallStackTree = callStackTree;
            this.DiagnosticMetaData = diagnosticMetaData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticLogsProductDataItemDiagnosticLog" /> class.
        /// </summary>
        public DiagnosticLogsProductDataItemDiagnosticLog()
        {
        }

    }
}