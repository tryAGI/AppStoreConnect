
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DiagnosticLogs
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productData")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.DiagnosticLogsProductDataItem>? ProductData { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticLogs" /> class.
        /// </summary>
        /// <param name="productData"></param>
        /// <param name="version"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiagnosticLogs(
            global::System.Collections.Generic.IList<global::AppStoreConnect.DiagnosticLogsProductDataItem>? productData,
            string? version)
        {
            this.ProductData = productData;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticLogs" /> class.
        /// </summary>
        public DiagnosticLogs()
        {
        }

    }
}