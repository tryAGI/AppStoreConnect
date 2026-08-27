
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DiagnosticLogsProductDataItemDiagnosticLogCallStackTreeItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callStackPerThread")]
        public bool? CallStackPerThread { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callStacks")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.DiagnosticLogsProductDataItemDiagnosticLogCallStackTreeItemCallStack>? CallStacks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticLogsProductDataItemDiagnosticLogCallStackTreeItem" /> class.
        /// </summary>
        /// <param name="callStackPerThread"></param>
        /// <param name="callStacks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiagnosticLogsProductDataItemDiagnosticLogCallStackTreeItem(
            bool? callStackPerThread,
            global::System.Collections.Generic.IList<global::AppStoreConnect.DiagnosticLogsProductDataItemDiagnosticLogCallStackTreeItemCallStack>? callStacks)
        {
            this.CallStackPerThread = callStackPerThread;
            this.CallStacks = callStacks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticLogsProductDataItemDiagnosticLogCallStackTreeItem" /> class.
        /// </summary>
        public DiagnosticLogsProductDataItemDiagnosticLogCallStackTreeItem()
        {
        }

    }
}