
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DiagnosticLogsProductDataItemDiagnosticLogCallStackTreeItemCallStack
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callStackRootFrames")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.DiagnosticLogCallStackNode>? CallStackRootFrames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticLogsProductDataItemDiagnosticLogCallStackTreeItemCallStack" /> class.
        /// </summary>
        /// <param name="callStackRootFrames"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiagnosticLogsProductDataItemDiagnosticLogCallStackTreeItemCallStack(
            global::System.Collections.Generic.IList<global::AppStoreConnect.DiagnosticLogCallStackNode>? callStackRootFrames)
        {
            this.CallStackRootFrames = callStackRootFrames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticLogsProductDataItemDiagnosticLogCallStackTreeItemCallStack" /> class.
        /// </summary>
        public DiagnosticLogsProductDataItemDiagnosticLogCallStackTreeItemCallStack()
        {
        }

    }
}